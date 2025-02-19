# Knoq.Api.EventsApi

All URIs are relative to *http://knoq.trap.jp/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddEventTag**](EventsApi.md#addeventtag) | **POST** /events/{eventID}/tags | タグを追加 |
| [**AddEvents**](EventsApi.md#addevents) | **POST** /events | 部屋の使用宣言を行う |
| [**DeleteEvent**](EventsApi.md#deleteevent) | **DELETE** /events/{eventID} | 使用宣言を削除 |
| [**DeleteEventTag**](EventsApi.md#deleteeventtag) | **DELETE** /events/{eventID}/tags/{tagName} | タグを削除 |
| [**GetEventActivities**](EventsApi.md#geteventactivities) | **GET** /activity/events |  |
| [**GetEventDetail**](EventsApi.md#geteventdetail) | **GET** /events/{eventID} | 一件取得 |
| [**GetEvents**](EventsApi.md#getevents) | **GET** /events | 使用宣言の情報を取得 |
| [**GetEventsOfGroup**](EventsApi.md#geteventsofgroup) | **GET** /groups/{groupID}/events |  |
| [**GetEventsOfRoom**](EventsApi.md#geteventsofroom) | **GET** /rooms/{roomID}/events |  |
| [**GetMyEvents**](EventsApi.md#getmyevents) | **GET** /users/me/events |  |
| [**GetUserEvents**](EventsApi.md#getuserevents) | **GET** /users/{userID}/events |  |
| [**UpdateEvent**](EventsApi.md#updateevent) | **PUT** /events/{eventID} | 部屋の使用宣言を更新 |
| [**UpdateSchedule**](EventsApi.md#updateschedule) | **PUT** /events/{eventID}/attendees/me | 自分の参加予定を編集 |

<a id="addeventtag"></a>
# **AddEventTag**
> void AddEventTag (Guid eventID, RequestTag requestTag)

タグを追加

タグを追加

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
    public class AddEventTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EventsApi(httpClient, config, httpClientHandler);
            var eventID = "eventID_example";  // Guid | 
            var requestTag = new RequestTag(); // RequestTag | イベントにタグを追加

            try
            {
                // タグを追加
                apiInstance.AddEventTag(eventID, requestTag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.AddEventTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddEventTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // タグを追加
    apiInstance.AddEventTagWithHttpInfo(eventID, requestTag);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.AddEventTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventID** | **Guid** |  |  |
| **requestTag** | [**RequestTag**](RequestTag.md) | イベントにタグを追加 |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Nocontent |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addevents"></a>
# **AddEvents**
> ResponseEventDetail AddEvents (RequestEvent requestEvent)

部屋の使用宣言を行う

部屋の使用宣言を行う

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
    public class AddEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EventsApi(httpClient, config, httpClientHandler);
            var requestEvent = new RequestEvent(); // RequestEvent | 予約の編集

            try
            {
                // 部屋の使用宣言を行う
                ResponseEventDetail result = apiInstance.AddEvents(requestEvent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.AddEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 部屋の使用宣言を行う
    ApiResponse<ResponseEventDetail> response = apiInstance.AddEventsWithHttpInfo(requestEvent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.AddEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestEvent** | [**RequestEvent**](RequestEvent.md) | 予約の編集 |  |

### Return type

[**ResponseEventDetail**](ResponseEventDetail.md)

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

<a id="deleteevent"></a>
# **DeleteEvent**
> void DeleteEvent (Guid eventID)

使用宣言を削除

adminsのみ

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
    public class DeleteEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EventsApi(httpClient, config, httpClientHandler);
            var eventID = "eventID_example";  // Guid | 

            try
            {
                // 使用宣言を削除
                apiInstance.DeleteEvent(eventID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.DeleteEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 使用宣言を削除
    apiInstance.DeleteEventWithHttpInfo(eventID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.DeleteEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventID** | **Guid** |  |  |

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteeventtag"></a>
# **DeleteEventTag**
> void DeleteEventTag (Guid eventID, string tagName)

タグを削除

locked=falseだけ

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
    public class DeleteEventTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EventsApi(httpClient, config, httpClientHandler);
            var eventID = "eventID_example";  // Guid | 
            var tagName = "tagName_example";  // string | 

            try
            {
                // タグを削除
                apiInstance.DeleteEventTag(eventID, tagName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.DeleteEventTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEventTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // タグを削除
    apiInstance.DeleteEventTagWithHttpInfo(eventID, tagName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.DeleteEventTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventID** | **Guid** |  |  |
| **tagName** | **string** |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            var apiInstance = new EventsApi(httpClient, config, httpClientHandler);

            try
            {
                List<ResponseEvent> result = apiInstance.GetEventActivities();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetEventActivities: " + e.Message);
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
    Debug.Print("Exception when calling EventsApi.GetEventActivitiesWithHttpInfo: " + e.Message);
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

<a id="geteventdetail"></a>
# **GetEventDetail**
> ResponseEventDetail GetEventDetail (Guid eventID)

一件取得

一件取得

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
    public class GetEventDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EventsApi(httpClient, config, httpClientHandler);
            var eventID = "eventID_example";  // Guid | 

            try
            {
                // 一件取得
                ResponseEventDetail result = apiInstance.GetEventDetail(eventID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetEventDetail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventDetailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 一件取得
    ApiResponse<ResponseEventDetail> response = apiInstance.GetEventDetailWithHttpInfo(eventID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetEventDetailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventID** | **Guid** |  |  |

### Return type

[**ResponseEventDetail**](ResponseEventDetail.md)

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

<a id="getevents"></a>
# **GetEvents**
> List&lt;ResponseEvent&gt; GetEvents (string? dateBegin = null, string? dateEnd = null, string? q = null)

使用宣言の情報を取得

使用宣言の情報を取得

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
    public class GetEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EventsApi(httpClient, config, httpClientHandler);
            var dateBegin = 2006-01-02T15:04:05Z;  // string? | 特定の日時から。 (optional) 
            var dateEnd = 2006-01-02T15:04:05Z;  // string? | 特定の日時まで。 (optional) 
            var q = "q_example";  // string? | Syntax: <br> top  : ε | expr, expr : term ( ( \"||\" | \"&&\" ) term)*<br> term : cmp | \"(\" expr \")\"<br> cmp  : Attr ( \"==\" | \"!=\" ) UUID<br> Attr : \"event\" | \"user\" | \"group\" | \"tag\"  (optional) 

            try
            {
                // 使用宣言の情報を取得
                List<ResponseEvent> result = apiInstance.GetEvents(dateBegin, dateEnd, q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 使用宣言の情報を取得
    ApiResponse<List<ResponseEvent>> response = apiInstance.GetEventsWithHttpInfo(dateBegin, dateEnd, q);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dateBegin** | **string?** | 特定の日時から。 | [optional]  |
| **dateEnd** | **string?** | 特定の日時まで。 | [optional]  |
| **q** | **string?** | Syntax: &lt;br&gt; top  : ε | expr, expr : term ( ( \&quot;||\&quot; | \&quot;&amp;&amp;\&quot; ) term)*&lt;br&gt; term : cmp | \&quot;(\&quot; expr \&quot;)\&quot;&lt;br&gt; cmp  : Attr ( \&quot;&#x3D;&#x3D;\&quot; | \&quot;!&#x3D;\&quot; ) UUID&lt;br&gt; Attr : \&quot;event\&quot; | \&quot;user\&quot; | \&quot;group\&quot; | \&quot;tag\&quot;  | [optional]  |

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

<a id="geteventsofgroup"></a>
# **GetEventsOfGroup**
> List&lt;ResponseEvent&gt; GetEventsOfGroup (Guid groupID)



groupIdのeventsを取得

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
    public class GetEventsOfGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EventsApi(httpClient, config, httpClientHandler);
            var groupID = "groupID_example";  // Guid | 

            try
            {
                List<ResponseEvent> result = apiInstance.GetEventsOfGroup(groupID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetEventsOfGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventsOfGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ResponseEvent>> response = apiInstance.GetEventsOfGroupWithHttpInfo(groupID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetEventsOfGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupID** | **Guid** |  |  |

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

<a id="geteventsofroom"></a>
# **GetEventsOfRoom**
> List&lt;ResponseEvent&gt; GetEventsOfRoom (Guid roomID)



指定した部屋で行われるイベントを返す

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
    public class GetEventsOfRoomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EventsApi(httpClient, config, httpClientHandler);
            var roomID = "roomID_example";  // Guid | 

            try
            {
                List<ResponseEvent> result = apiInstance.GetEventsOfRoom(roomID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetEventsOfRoom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventsOfRoomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ResponseEvent>> response = apiInstance.GetEventsOfRoomWithHttpInfo(roomID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetEventsOfRoomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roomID** | **Guid** |  |  |

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

<a id="getmyevents"></a>
# **GetMyEvents**
> List&lt;ResponseEvent&gt; GetMyEvents (string? relation = null)



所属しているイベントを返す

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
    public class GetMyEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EventsApi(httpClient, config, httpClientHandler);
            var relation = "admins";  // string? | どのような関係性でユーザーと結びつけるか。 取り得る値は、 admins(ユーザーが管理者), belongs(ユーザーが所属している),  belongs-or-admins(ユーザーが管理者または所属している)  イベントはさらに、attendees(not absent) 値がない場合は、belongs として振る舞う  (optional) 

            try
            {
                List<ResponseEvent> result = apiInstance.GetMyEvents(relation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetMyEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ResponseEvent>> response = apiInstance.GetMyEventsWithHttpInfo(relation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetMyEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **relation** | **string?** | どのような関係性でユーザーと結びつけるか。 取り得る値は、 admins(ユーザーが管理者), belongs(ユーザーが所属している),  belongs-or-admins(ユーザーが管理者または所属している)  イベントはさらに、attendees(not absent) 値がない場合は、belongs として振る舞う  | [optional]  |

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

<a id="getuserevents"></a>
# **GetUserEvents**
> List&lt;ResponseEvent&gt; GetUserEvents (Guid userID, string? relation = null)



所属しているイベントを返す

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
    public class GetUserEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EventsApi(httpClient, config, httpClientHandler);
            var userID = "userID_example";  // Guid | 
            var relation = "admins";  // string? | どのような関係性でユーザーと結びつけるか。 取り得る値は、 admins(ユーザーが管理者), belongs(ユーザーが所属している),  belongs-or-admins(ユーザーが管理者または所属している)  イベントはさらに、attendees(not absent) 値がない場合は、belongs として振る舞う  (optional) 

            try
            {
                List<ResponseEvent> result = apiInstance.GetUserEvents(userID, relation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetUserEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<ResponseEvent>> response = apiInstance.GetUserEventsWithHttpInfo(userID, relation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetUserEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userID** | **Guid** |  |  |
| **relation** | **string?** | どのような関係性でユーザーと結びつけるか。 取り得る値は、 admins(ユーザーが管理者), belongs(ユーザーが所属している),  belongs-or-admins(ユーザーが管理者または所属している)  イベントはさらに、attendees(not absent) 値がない場合は、belongs として振る舞う  | [optional]  |

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

<a id="updateevent"></a>
# **UpdateEvent**
> ResponseEventDetail UpdateEvent (Guid eventID, RequestEvent requestEvent)

部屋の使用宣言を更新

adminsのみ

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
    public class UpdateEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EventsApi(httpClient, config, httpClientHandler);
            var eventID = "eventID_example";  // Guid | 
            var requestEvent = new RequestEvent(); // RequestEvent | 予約の編集

            try
            {
                // 部屋の使用宣言を更新
                ResponseEventDetail result = apiInstance.UpdateEvent(eventID, requestEvent);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.UpdateEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 部屋の使用宣言を更新
    ApiResponse<ResponseEventDetail> response = apiInstance.UpdateEventWithHttpInfo(eventID, requestEvent);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.UpdateEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventID** | **Guid** |  |  |
| **requestEvent** | [**RequestEvent**](RequestEvent.md) | 予約の編集 |  |

### Return type

[**ResponseEventDetail**](ResponseEventDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateschedule"></a>
# **UpdateSchedule**
> void UpdateSchedule (Guid eventID, RequestSchedule requestSchedule)

自分の参加予定を編集

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
    public class UpdateScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new EventsApi(httpClient, config, httpClientHandler);
            var eventID = "eventID_example";  // Guid | 
            var requestSchedule = new RequestSchedule(); // RequestSchedule | イベントの参加予定を更新

            try
            {
                // 自分の参加予定を編集
                apiInstance.UpdateSchedule(eventID, requestSchedule);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.UpdateSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分の参加予定を編集
    apiInstance.UpdateScheduleWithHttpInfo(eventID, requestSchedule);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.UpdateScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventID** | **Guid** |  |  |
| **requestSchedule** | [**RequestSchedule**](RequestSchedule.md) | イベントの参加予定を更新 |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Nocontent |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

