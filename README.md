# dotnet-knoq

.NET client library for the [knoQ](https://github.com/traPtitech/knoQ) API.

The source code is generated from the [OpenAPI Spec for the knoQ API](https://github.com/traPtitech/knoQ/blob/master/docs/swagger.yaml) by [Microsoft Kiota](https://github.com/microsoft/kiota).

## How to Use

### Use in Generic Host

An extension method for the `IServiceCollection` type can be used.

In the sample code below, an instance of the `TraqApiClient` class configured by environment variables (`KNOQ_BASE_ADDRESS` and `KNOQ_COOKIE_TOKEN`) is added to the service collection.

```cs
var host = Host.CreateDefaultApplication(args)
    .ConfigureServices((ctx, services) =>
    {
        services.AddKnoqApiClient(options =>
        {
            var conf = ctx.Configuration;
            options.BaseAddress = conf["KNOQ_BASE_ADDRESS"];
            options.CookieAuthToken = conf["KNOQ_COOKIE_TOKEN"];
        });
    })
    .Build();

host.Run();
```

You can also separate configurator from the `AddKnoqApiClient` method by using parameterless method.
In the following code, the added `KnoqApiClient` automatically use configured `KnoqApiClientOptions`.

```cs
var host = Host.CreateDefaultApplication(args)
    .ConfigureServices((ctx, services) =>
    {
        services.Configure<KnoqApiClientOptions>(ctx.Configuration);
        services.AddKnoqApiClient();
    })
    .Build();

host.Run();
```

### Create API Client Manually

The `CreateFromOptions` method in the `KnoqApiClientHelper` class is useful to create a new instance of the `KnoqApiClient` class with specified options.

```cs
KnoqApiClientOptions options = new()
{
    BaseAddress = "Base address of the knoQ API",
    CookieAuthToken = "Cookie authentication token"
}
var client = KnoqApiClientHelper.CreateFromOptions(options);
```

The `KnoqApiClient` class implements `Microsoft.Kiota.Abstractions.BaseRequestBuilder` so that you can manually manage methods to access the knoQ API.

For more information, please check [Kiota Official Documentation](https://learn.microsoft.com/en-us/openapi/kiota/overview).

## Source Generation

[Docker](https://www.docker.com) and [Task](https://taskfile.dev) are required for source generation.

To generate API client for certain version of knoQ, set it to the `KNOQ_TAG_NAME` variable and run `task`, `task gen` or `task generate-client`.

The following command generates API client for knoQ v2.5.12.

```bash
KNOQ_TAG_NAME="v2.5.12" task
```
