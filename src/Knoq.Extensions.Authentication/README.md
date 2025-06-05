# KnoqNet.Extensions.Authentication

A dotnet library that provides authenticated client for the knoQ API through traQ OAuth2 authentication flow.

# Usage

## Use in DI Container

You can add authenticated `IKnoqApiClient` to your dependency injection container using an extension method.

```cs
services.AddAuthenticatedKnoqApiClient(
	(sp, knoqOptions) =>
	{
		knoqOptions.BaseAddress = "https://knoq.trap.jp/api";
	},
	(sp, traqAuthInfo) =>
	{
		traqAuthInfo.UsePasswordAuthentication("user", "password");
	}
)
```

You can also simply get cookie authentication token for the knoQ API.

```cs
var token = await AuthenticationExtensions.GetKnoqAccessTokenAsync(
	"https://knoq.trap.jp/api", // knoQ API base address
	"https://q.trap.jp/api/v3", // traQ API base address
	traqAuthInfo,
	ct
);
```
