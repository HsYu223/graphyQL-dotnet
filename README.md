# graphyQL-dotnet

�p�G�������h�ӻݭn�P�ɦs�������, �i�H�X�֦��@�Ӭd��, �@���ʮ��^������l�ƻݭn���Ҧ����e, ���εo�_�h���n�D

## �̿�M��

```bash
GraphQL

# GraphQL.Server.Transports.AspNetCore.NewtonsoftJson
GraphQL.Server.Transports.AspNetCore.SystemTextJson


# test ui
GraphQL.Server.Ui.Playground
```

## GraphyQL�w�q

* Schema
* Query
* Type

## Startup

ConfigureServices

```csharp
services.AddScoped<GraphyQuery>();
services.AddScoped<CustomType>();
services.AddScoped<ISchema, GraphySchema>();

services
    .AddGraphQL(options =>
    {
        options.EnableMetrics = true;
    })
    .AddErrorInfoProvider(opt => opt.ExposeExceptionStackTrace = true)
    .AddSystemTextJson();
```

Configure

```csharp
// add http for Schema at default url /graphql
app.UseGraphQL<ISchema>();

// use graphql-playground at default url /ui/playground
app.UseGraphQLPlayground();
```




