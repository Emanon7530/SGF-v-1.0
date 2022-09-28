echo "Registrando librerias ..."
REM Buscar todos los archivos de extension DLL en todos los
REM sub directorios y lo registra
CALL "%VSVARS%"
for /r %%i in (bin\*.dll) do gacutil -u "%%i"
echo "Listo!"
pause
