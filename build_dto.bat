call "%VSAPPIDDIR%..\Tools\VsDevCmd.bat"
for %%f in (RegistrySchemas\XSD\*.xsd) do "xsd.exe" /c /l:cs /o:RegistrySchemas\DTO /n:RegistrySchemas.DTO.%%~nf /nologo %%f
