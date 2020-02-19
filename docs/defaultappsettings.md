## Default appsettings.json

```
{
  "ConnectionStrings": {
    "DefaultConnection": " *DB Connection String* ",
    "AzureConnection": " *AzureBlobStorage Connection String*",
  },
  "tokenManagement": {
    "secret": " *app secret* ",
    "issuer": " *issuer* ",
    "audience": " *audience* ",
    "accessExpiration": *time in minutes* ,
    "refreshExpiration": *time in minutes*
  },
  "Serilog": {
    "MinimumLevel": {
      "Default": "Information",
      "Override": {
        "System": "Information",
        "Microsoft": "Information"
      }
    },
    "WriteTo": [
      {
        "Name": "Async",
        "Args": {
          "configure": [
            {
              "Name": "Console"
            },
            {
              "Name": "Debug"
            },
            {
              "Name": "File",
              "Args": {
                "path": ".\\Logs\\log.txt",
                "rollingInterval": "Day",
                "retainedFileCountLimit": "21",
                "restrictedToMinimumLevel": "Warning"
              }
            }
          ]
        }
      }
    ],
    "Enrich": [
      "FromLogContext",
      "WithExceptionDetails"
    ]
  }
}
```