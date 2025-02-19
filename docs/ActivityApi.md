# Knoq.Api.ActivityApi

All URIs are relative to *http://knoq.trap.jp/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEventActivities**](ActivityApi.md#geteventactivities) | **GET** /activity/events |  |

<a id="geteventactivities"></a>
# **GetEventActivities**
> List&lt;ResponseEvent&gt; GetEventActivities ()



最近7日間に作成変更削除があったイベントを取得。 削除されたものを含んで返す。 

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
    public class GetEventActivitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ActivityApi(httpClient, config, httpClientHandler);

            try
            {
                List<ResponseEvent> result = apiInstance.GetEventActivities();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivityApi.GetEventActivities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventActivitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ResponseEvent>> response = apiInstance.GetEventActivitiesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivityApi.GetEventActivitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ResponseEvent&gt;**](ResponseEvent.md)

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

