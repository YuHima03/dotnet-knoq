# Knoq.Api.ICalApi

All URIs are relative to *http://knoq.trap.jp/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetIcal**](ICalApi.md#getical) | **GET** /ical/v1/{icalToken} |  |
| [**GetIcalSecret**](ICalApi.md#geticalsecret) | **GET** /users/me/ical |  |
| [**ResetIcalSecret**](ICalApi.md#reseticalsecret) | **PUT** /users/me/ical |  |

<a id="getical"></a>
# **GetIcal**
> string GetIcal (string icalToken, string? q = null)



Icalを取得

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
    public class GetIcalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ICalApi(httpClient, config, httpClientHandler);
            var icalToken = "icalToken_example";  // string | 
            var q = "q_example";  // string? | Syntax: <br> top  : ε | expr, expr : term ( ( \"||\" | \"&&\" ) term)*<br> term : cmp | \"(\" expr \")\"<br> cmp  : Attr ( \"==\" | \"!=\" ) UUID<br> Attr : \"event\" | \"user\" | \"group\" | \"tag\"  (optional) 

            try
            {
                string result = apiInstance.GetIcal(icalToken, q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ICalApi.GetIcal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIcalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<string> response = apiInstance.GetIcalWithHttpInfo(icalToken, q);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ICalApi.GetIcalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **icalToken** | **string** |  |  |
| **q** | **string?** | Syntax: &lt;br&gt; top  : ε | expr, expr : term ( ( \&quot;||\&quot; | \&quot;&amp;&amp;\&quot; ) term)*&lt;br&gt; term : cmp | \&quot;(\&quot; expr \&quot;)\&quot;&lt;br&gt; cmp  : Attr ( \&quot;&#x3D;&#x3D;\&quot; | \&quot;!&#x3D;\&quot; ) UUID&lt;br&gt; Attr : \&quot;event\&quot; | \&quot;user\&quot; | \&quot;group\&quot; | \&quot;tag\&quot;  | [optional]  |

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/calendar


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | iCal形式でイベントを出力 外部カレンダーを想定  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            var apiInstance = new ICalApi(httpClient, config, httpClientHandler);

            try
            {
                IcalSecret result = apiInstance.GetIcalSecret();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ICalApi.GetIcalSecret: " + e.Message);
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
    Debug.Print("Exception when calling ICalApi.GetIcalSecretWithHttpInfo: " + e.Message);
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
            var apiInstance = new ICalApi(httpClient, config, httpClientHandler);

            try
            {
                IcalSecret result = apiInstance.ResetIcalSecret();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ICalApi.ResetIcalSecret: " + e.Message);
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
    Debug.Print("Exception when calling ICalApi.ResetIcalSecretWithHttpInfo: " + e.Message);
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

