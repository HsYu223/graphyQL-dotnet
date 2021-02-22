# graphyQL-dotnet

如果頁面有多個需要同時存取的控制項, 可以合併成一個查詢, 一次性拿回頁面初始化需要的所有內容, 不用發起多次要求

## 依賴套件

```bash
GraphQL

# GraphQL.Server.Transports.AspNetCore.NewtonsoftJson
GraphQL.Server.Transports.AspNetCore.SystemTextJson


# test ui
GraphQL.Server.Ui.Playground
```

## GraphyQL定義

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




