echo Building %1
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild ServiceApp.sln /t:Rebuild /nologo /p:Configuration=%1 /p:SkipInvalidConfigurations=true /p:DeployOnBuild=True /p:DeployTarget=Package /p:MSDeployPublishMethod=InProc /p:DeployIISAppPath=%2 /p:DeployToDatabase=false /p:CreatePackageOnPublish=True /p:OutPath="Package"
