echo Building %1
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild ServiceApp.sln /t:Rebuild /nologo /p:Configuration=Release /p:SkipInvalidConfigurations=true /p:DeployOnBuild=True /p:DeployTarget=Package /p:MSDeployPublishMethod=InProc /p:MsDeployServiceUrl=%1 /p:DeployToDatabase=false /p:CreatePackageOnPublish=True /p:OutPath="Package
