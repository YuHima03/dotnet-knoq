# KnoqNet

A dotnet library for the knoQ API.

# Usage

## Use in Generic Host

You can add `IKnoqApiClient` to your dependency injection container using an extension method.

```cs
services.AddKnoqApiClient(options =>
{
	options.BaseAddress = "https://knoq.trap.jp/api"
});
```

You can also load options from configuration.

```cs
services.Configure<KnoqApiClientOptions>(configuration.GetSection("Knoq"));
services.AddSingleton<IKnoqApiClient, KnoqApiClient>();
```
