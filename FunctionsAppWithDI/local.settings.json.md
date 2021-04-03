# local.settings.json

In order to be able to run this application locally, you need to have a `local.settings.json` file in the same directory with this documentation. The contents of that file is described below.

``` JSON
{
    "IsEncrypted": false,
    "Values": {
        "AzureWebJobsStorage": "UseDevelopmentStorage=true",
        "FUNCTIONS_WORKER_RUNTIME": "dotnet",


        "myapp:data:connectionstring": "",
        "myapp:data:databasename": "",
        "myapp:data:containername": "",

        "myapp:application:clientid": "",
        "myapp:application:clientsecret": ""
    }
}
```

The `IsEncrypted`, `AzureWebJobsStorage` and `FUNCTIONS_WORKER_RUNTIME` are just the standard Azure Functions settings that you get by default. The rest of the settings are just to simulate various configuration sections that you typically have in an application.

The `myapp:data` contains information about how the application would connect to a database. The `myapp:application` contains information that the application would need to connect to Microsoft Graph for instance.

> Please note that these are completely fictional and are not used in the application in any way. If you want, you can leave them blank.
