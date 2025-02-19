# Knoq.Api.RoomsApi

All URIs are relative to *http://knoq.trap.jp/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAllRooms**](RoomsApi.md#addallrooms) | **POST** /rooms/all | traPで確保した部屋の情報追加 |
| [**AddRooms**](RoomsApi.md#addrooms) | **POST** /rooms | 部屋の情報追加 |
| [**DeleteRoom**](RoomsApi.md#deleteroom) | **DELETE** /rooms/{roomID} | 部屋の情報を削除 |
| [**GetRoom**](RoomsApi.md#getroom) | **GET** /rooms/{roomID} | 一件取得する |
| [**GetRooms**](RoomsApi.md#getrooms) | **GET** /rooms | 進捗部屋の情報を取得 |
| [**UnverifyRoom**](RoomsApi.md#unverifyroom) | **DELETE** /rooms/{roomID}/verified | 部屋を未確認にする |
| [**VerifyRoom**](RoomsApi.md#verifyroom) | **POST** /rooms/{roomID}/verified | 部屋を確認する |

<a id="addallrooms"></a>
# **AddAllRooms**
> List&lt;ResponseRoom&gt; AddAllRooms (List<AddAllRoomsRequestInner> addAllRoomsRequestInner)

traPで確保した部屋の情報追加

特権が必要。

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
    public class AddAllRoomsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var addAllRoomsRequestInner = new List<AddAllRoomsRequestInner>(); // List<AddAllRoomsRequestInner> | 進捗部屋情報

            try
            {
                // traPで確保した部屋の情報追加
                List<ResponseRoom> result = apiInstance.AddAllRooms(addAllRoomsRequestInner);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.AddAllRooms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddAllRoomsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // traPで確保した部屋の情報追加
    ApiResponse<List<ResponseRoom>> response = apiInstance.AddAllRoomsWithHttpInfo(addAllRoomsRequestInner);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.AddAllRoomsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addAllRoomsRequestInner** | [**List&lt;AddAllRoomsRequestInner&gt;**](AddAllRoomsRequestInner.md) | 進捗部屋情報 |  |

### Return type

[**List&lt;ResponseRoom&gt;**](ResponseRoom.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/csv
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addrooms"></a>
# **AddRooms**
> ResponseRoom AddRooms (RequestRoom requestRoom)

部屋の情報追加

部屋の情報追加

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
    public class AddRoomsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var requestRoom = new RequestRoom(); // RequestRoom | 部屋の追加

            try
            {
                // 部屋の情報追加
                ResponseRoom result = apiInstance.AddRooms(requestRoom);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.AddRooms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddRoomsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 部屋の情報追加
    ApiResponse<ResponseRoom> response = apiInstance.AddRoomsWithHttpInfo(requestRoom);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.AddRoomsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestRoom** | [**RequestRoom**](RequestRoom.md) | 部屋の追加 |  |

### Return type

[**ResponseRoom**](ResponseRoom.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | successful operation |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteroom"></a>
# **DeleteRoom**
> void DeleteRoom (Guid roomID, Guid? excludeEventID = null)

部屋の情報を削除

(関連する予約を削除する) エラーを出して削除を促す予定

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
    public class DeleteRoomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var roomID = "roomID_example";  // Guid | 
            var excludeEventID = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid? | 除外するイベントのID。 (optional) 

            try
            {
                // 部屋の情報を削除
                apiInstance.DeleteRoom(roomID, excludeEventID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.DeleteRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 部屋の情報を削除
    apiInstance.DeleteRoomWithHttpInfo(roomID, excludeEventID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.DeleteRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomID** | **Guid** |  |  |
| **excludeEventID** | **Guid?** | 除外するイベントのID。 | [optional]  |

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
| **200** | successful operation |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getroom"></a>
# **GetRoom**
> ResponseRoom GetRoom (Guid roomID, Guid? excludeEventID = null)

一件取得する

一件取得する

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
    public class GetRoomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var roomID = "roomID_example";  // Guid | 
            var excludeEventID = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid? | 除外するイベントのID。 (optional) 

            try
            {
                // 一件取得する
                ResponseRoom result = apiInstance.GetRoom(roomID, excludeEventID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 一件取得する
    ApiResponse<ResponseRoom> response = apiInstance.GetRoomWithHttpInfo(roomID, excludeEventID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomID** | **Guid** |  |  |
| **excludeEventID** | **Guid?** | 除外するイベントのID。 | [optional]  |

### Return type

[**ResponseRoom**](ResponseRoom.md)

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

<a id="getrooms"></a>
# **GetRooms**
> List&lt;ResponseRoom&gt; GetRooms (string? dateBegin = null, string? dateEnd = null, Guid? excludeEventID = null)

進捗部屋の情報を取得

進捗部屋の情報を取得

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
    public class GetRoomsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var dateBegin = 2006-01-02T15:04:05Z;  // string? | 特定の日時から。 (optional) 
            var dateEnd = 2006-01-02T15:04:05Z;  // string? | 特定の日時まで。 (optional) 
            var excludeEventID = 3fa85f64-5717-4562-b3fc-2c963f66afa6;  // Guid? | 除外するイベントのID。 (optional) 

            try
            {
                // 進捗部屋の情報を取得
                List<ResponseRoom> result = apiInstance.GetRooms(dateBegin, dateEnd, excludeEventID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.GetRooms: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRoomsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 進捗部屋の情報を取得
    ApiResponse<List<ResponseRoom>> response = apiInstance.GetRoomsWithHttpInfo(dateBegin, dateEnd, excludeEventID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.GetRoomsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dateBegin** | **string?** | 特定の日時から。 | [optional]  |
| **dateEnd** | **string?** | 特定の日時まで。 | [optional]  |
| **excludeEventID** | **Guid?** | 除外するイベントのID。 | [optional]  |

### Return type

[**List&lt;ResponseRoom&gt;**](ResponseRoom.md)

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

<a id="unverifyroom"></a>
# **UnverifyRoom**
> void UnverifyRoom (Guid roomID)

部屋を未確認にする

特権が必要。部屋が使用できることの確認を取り消す。

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
    public class UnverifyRoomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var roomID = "roomID_example";  // Guid | 

            try
            {
                // 部屋を未確認にする
                apiInstance.UnverifyRoom(roomID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.UnverifyRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnverifyRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 部屋を未確認にする
    apiInstance.UnverifyRoomWithHttpInfo(roomID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.UnverifyRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomID** | **Guid** |  |  |

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
| **200** | successful operation |  -  |
| **403** | Forbidden |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="verifyroom"></a>
# **VerifyRoom**
> void VerifyRoom (Guid roomID)

部屋を確認する

特権が必要。部屋が使用できることを確認する

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
    public class VerifyRoomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new RoomsApi(httpClient, config, httpClientHandler);
            var roomID = "roomID_example";  // Guid | 

            try
            {
                // 部屋を確認する
                apiInstance.VerifyRoom(roomID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoomsApi.VerifyRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VerifyRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 部屋を確認する
    apiInstance.VerifyRoomWithHttpInfo(roomID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RoomsApi.VerifyRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomID** | **Guid** |  |  |

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
| **200** | successful operation |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

