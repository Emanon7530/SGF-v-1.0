alter view vw_ftfiscal as 
select distinct ftfactm.*,ftfactd.line_no,ftfactd.unit_code,	ftfactd.item_code,ftfactd.qty,
	ftfactd.price,	ftfactd.dscto,	ftfactd.factor,	ftfactd.itbis as itbisd,	ftfactd.costo,	ftfactd.ind_cobertura,
	ftdomim.domi_date,    ftdomim.domi_cambio,    ftdomim.vend_mensaj,    ftdomim.domi_pago,
    ftdomim.tarj_code,ftsegrm.aseg_poliza,	ftsegrm.segr_autorizacion,	ftsegrm.empl_amount,	ftsegrm.cia_amount,
	ftsegrm.cia_serial,	ftsegrm.plan_serial,	ftsegrm.segr_recetaunica,	ftsegrm.clini_code,cccustm.cust_name,
	cccustm.csttype_code,cccustm.contact_name,	cccustm.rnc_id,	cccustm.cust_phone,	cccustm.cust_address,
	cccustm.city_code,	cccustm.sector_code,	cccustm.cust_apellidos,	cccustm.contact_apellidos,	sgasegm.aseg_nombre,
	sgasegm.aseg_address,	sgasegm.aseg_phone,	sgasegm.aseg_cedula,	sgasegm.aseg_status,	sgasegm.aseg_principal,
	sgasegm.aseg_apellidos, sgciasm.cia_name,
sgciasm.cia_address,	sgciasm.cia_phone,sgciasm.cia_codigo,cccity.city_name,
       ccsectorm.sector_name,cjtranrm.pay_method,
	cjtranrm.amount,
	cjtranrm.ncr_code,
	cjtranrm.chk_code,
	cjtranrm.tart_code,
	cjtranrm.cust_seg,
	cjtranrm.vuelto
 from 
ftfactm inner join ftfactd on ftfactm.ftserial_no = ftfactd.ftserial_no
        left outer join ftdomim on ftfactm.ftserial_no = ftdomim.ftserial_no
        left outer join ftsegrm on ftfactm.ftserial_no = ftsegrm.ftserial_no
        left outer join cccustm on ftfactm.cust_code = cccustm.cust_code
        left outer join sgasegm on ftsegrm.aseg_poliza = sgasegm.aseg_poliza
                    and ftsegrm.cia_serial = sgasegm.cia_serial
                    and ftsegrm.plan_serial = sgasegm.plan_serial
        left outer join sgciasm on ftsegrm.plan_serial = sgciasm.cia_serial
        left outer join sgplanm on ftsegrm.plan_serial = sgplanm.plan_serial
        left outer join cccity on cccustm.city_code = cccity.city_code
        left outer join ccsectorm on cccustm.sector_code = ccsectorm.sector_code
        left outer join pvtarjeta on ftdomim.tarj_code = pvtarjeta.tarj_code
        left outer join ftvendm on ftfactm.vend_code = ftvendm.vend_code
        inner join cjtranrm on ftfactm.ftserial_no = cjtranrm.ftserial_no
               and cjtranrm.pay_method <> 'SEG'
        
  
  
  
  
  
            
     
        
        
 