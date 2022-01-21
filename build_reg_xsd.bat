call "%VSAPPIDDIR%..\Tools\VsDevCmd.bat"
"xsd.exe" /c /l:cs /o:RegistrySchemaBuilder /n:RegistrySchemaBuilder.Q018 /nologo RegistrySchemaBuilder\Q018.xsd

dotnet run --project RegistrySchemaBuilder RegistrySchemaBuilder\Q018.xsd RegistrySchemaBuilder\Q018.xml RegistrySchemas