
/****** Object:  View [dbo].[vw_ftdevnccc]    Script Date: 02/20/2015 09:56:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER view [dbo].[vw_ftdevnccc] as             
select ''ftserial_no, ccinvcem.cust_code
	,cust_name
	,rnc_id
	,invce_no fact_number,invce_date fact_date,amount fact_total,            
        cargo_desc descto,itbis,type_code,null bus_name,invce_ncf fact_ncf,'' ncf_type,''fact_tasa,            
        ivsetup.percent_itbis,ccinvcem.vend_code,0 fact_cond,invce_status fact_status,''aft_ncf
  from ccinvcem INNER JOIN cccustm on ccinvcem.cust_code = cccustm.cust_code             
                INNER JOIN ivsetup on ivsetup.setup_id = 1            
  where type_code in('NCC','NDC')            
union            
SELECT     
	ftfactm.ftserial_no ,       
	cccustm."cust_code",            
     case isnull(ftfactm.cust_code, -1) when  -1 then
    (select cust.cust_name from cccustm cust where cust.cust_code = ftfactm.cust_serial ) else 
    (select cust.cust_name from cccustm cust where cust.cust_code = ftfactm.cust_code) end cust_name,
    case isnull(ftfactm.cust_code, -1) when  -1 then
    (select cust.rnc_id from cccustm cust where cust.cust_code = ftfactm.cust_serial ) else 
    (select cust.rnc_id from cccustm cust where cust.cust_code = ftfactm.cust_code) end rnc,          
    ftfactm."fact_number",            
    ftfactm."fact_date",            
    case ftfactm.fact_status when 0 then 0 else ftfactm."fact_total" end fact_total,            
    case ftfactm.fact_status when 0 then 0 else ftfactm."descto" end descto,            
    case ftfactm.fact_status when 0 then 0 else ftfactm."itbis" end itbis,            
    ftfactm."type_code",            
    ftfactm."bus_name",            
    ftfactm."fact_ncf",            
    ftncfm.ncf_type,            
    ''"fact_tasa",            
    ivsetup.percent_itbis,          
    ftfactm.vend_code,      
    ftfactm.fact_cond,       
    ftfactm.fact_status,
     case ftfactm.type_code when 'DEV' then 
    (select fact_ncf  from ftfactm  ftfact where ftfact.ftserial_no = ftfactm.ftserial_no ) end aft_ncf  
   FROM            
    ((ftfactm ftfactm INNER JOIN ivtypem ivtypem ON ftfactm."type_code" = ivtypem."type_code"             
    and ftfactm.fact_status in(0,2) and ftfactm.type_code in('FPV','FSG','FTS','FCT','DEV')) 
    inner join  ftncfm on ftncfm.ncf_literal = substring(ftfactm.fact_ncf,1,11) 
    and ftncfm.whse_code = ftfactm.whse_code)                         
    LEFT JOIN cccustm ON  ftfactm."cust_code" = cccustm."cust_code"              
         INNER JOIN ivsetup on ivsetup.setup_id = 1     


GO