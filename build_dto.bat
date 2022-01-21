call "%VSAPPIDDIR%..\Tools\VsDevCmd.bat"
for %%f in (RegistrySchemas\*.xsd) do "xsd.exe" /c /l:cs /o:RegistrySchemas /n:RegistrySchemas.%%~nf /nologo %%f
