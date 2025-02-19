# Knoq.Api.UsersApi

All URIs are relative to *http://knoq.trap.jp/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetIcalSecret**](UsersApi.md#geticalsecret) | **GET** /users/me/ical |  |
| [**GetMe**](UsersApi.md#getme) | **GET** /users/me | 自分のユーザー情報を取得 |
| [**GetUsers**](UsersApi.md#getusers) | **GET** /users |  |
| [**GrantPrivilege**](UsersApi.md#grantprivilege) | **PATCH** /users/{userID}/privileged |  |
| [**ResetIcalSecret**](UsersApi.md#reseticalsecret) | **PUT** /users/me/ical |  |
| [**SyncUsers**](UsersApi.md#syncusers) | **POST** /users/sync |  |

<a id="geticalsecret"></a>
# **GetIcalSecret**
> IcalSecret GetIcalSecret ()



/ical で使う`secret`を取得

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Knoq.Api;
using Knoq.Client;
using Knoq.Model;

namespace Example
{
    public class GetIcalSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UsersApi(httpClient, config, httpClientHandler);

            try
            {
                IcalSecret result = apiInstance.GetIcalSecret();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetIcalSecret: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIcalSecretWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IcalSecret> response = apiInstance.GetIcalSecretWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetIcalSecretWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**IcalSecret**](IcalSecret.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getme"></a>
# **GetMe**
> ResponseUser GetMe ()

自分のユーザー情報を取得

自分のユーザー情報を取得

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Knoq.Api;
using Knoq.Client;
using Knoq.Model;

namespace Example
{
    public class GetMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UsersApi(httpClient, config, httpClientHandler);

            try
            {
                // 自分のユーザー情報を取得
                ResponseUser result = apiInstance.GetMe();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetMe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分のユーザー情報を取得
    ApiResponse<ResponseUser> response = apiInstance.GetMeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetMeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ResponseUser**](ResponseUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getusers"></a>
# **GetUsers**
> List&lt;ResponseUser&gt; GetUsers (bool? includeSuspended = null)



ユーザー一覧を返す

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Knoq.Api;
using Knoq.Client;
using Knoq.Model;

namespace Example
{
    public class GetUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UsersApi(httpClient, config, httpClientHandler);
            var includeSuspended = false;  // bool? | アカウントがアクティブでないユーザーを含めるかどうか。 | traQ由来のquery。 | de (optional) 

            try
            {
                List<ResponseUser> result = apiInstance.GetUsers(includeSuspended);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ResponseUser>> response = apiInstance.GetUsersWithHttpInfo(includeSuspended);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **includeSuspended** | **bool?** | アカウントがアクティブでないユーザーを含めるかどうか。 | traQ由来のquery。 | de | [optional]  |

### Return type

[**List&lt;ResponseUser&gt;**](ResponseUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="grantprivilege"></a>
# **GrantPrivilege**
> void GrantPrivilege (Guid userID)



管理者権限を付与したいuserのuserIDをパラメータに入れる. APIを叩く本人が管理者権限を持っている必要がある.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Knoq.Api;
using Knoq.Client;
using Knoq.Model;

namespace Example
{
    public class GrantPrivilegeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UsersApi(httpClient, config, httpClientHandler);
            var userID = "userID_example";  // Guid | 

            try
            {
                apiInstance.GrantPrivilege(userID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GrantPrivilege: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GrantPrivilegeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GrantPrivilegeWithHttpInfo(userID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GrantPrivilegeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userID** | **Guid** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Nocontent |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reseticalsecret"></a>
# **ResetIcalSecret**
> IcalSecret ResetIcalSecret ()



/ical で使う`secret`を再生成

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Knoq.Api;
using Knoq.Client;
using Knoq.Model;

namespace Example
{
    public class ResetIcalSecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UsersApi(httpClient, config, httpClientHandler);

            try
            {
                IcalSecret result = apiInstance.ResetIcalSecret();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.ResetIcalSecret: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResetIcalSecretWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IcalSecret> response = apiInstance.ResetIcalSecretWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.ResetIcalSecretWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**IcalSecret**](IcalSecret.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="syncusers"></a>
# **SyncUsers**
> void SyncUsers ()



管理者権限が必要。 traQのuserと同期します。 存在していないユーザーは作成されます。 stateが同期されます。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Knoq.Api;
using Knoq.Client;
using Knoq.Model;

namespace Example
{
    public class SyncUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new UsersApi(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.SyncUsers();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.SyncUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SyncUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.SyncUsersWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.SyncUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

