# Knoq.Api.GroupsApi

All URIs are relative to *http://knoq.trap.jp/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMeToGroup**](GroupsApi.md#addmetogroup) | **PUT** /groups/{groupID}/members/me | 自分を追加。open&#x3D;true |
| [**CreateGroup**](GroupsApi.md#creategroup) | **POST** /groups | グループ作成 |
| [**DeleteGroup**](GroupsApi.md#deletegroup) | **DELETE** /groups/{groupID} | Delete group |
| [**DeleteMeFromGroup**](GroupsApi.md#deletemefromgroup) | **DELETE** /groups/{groupID}/members/me | 自分しか削除出来ない。open&#x3D;true |
| [**GetGroup**](GroupsApi.md#getgroup) | **GET** /groups/{groupID} | 一件取得 |
| [**GetGroups**](GroupsApi.md#getgroups) | **GET** /groups | グループを全て取得 |
| [**GetMyGroups**](GroupsApi.md#getmygroups) | **GET** /users/me/groups |  |
| [**GetUserGroups**](GroupsApi.md#getusergroups) | **GET** /users/{userID}/groups |  |
| [**UpdateGroup**](GroupsApi.md#updategroup) | **PUT** /groups/{groupID} |  |

<a id="addmetogroup"></a>
# **AddMeToGroup**
> void AddMeToGroup (Guid groupID)

自分を追加。open=true

自分をメンバーに追加する

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
    public class AddMeToGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GroupsApi(httpClient, config, httpClientHandler);
            var groupID = "groupID_example";  // Guid | 

            try
            {
                // 自分を追加。open=true
                apiInstance.AddMeToGroup(groupID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.AddMeToGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMeToGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分を追加。open=true
    apiInstance.AddMeToGroupWithHttpInfo(groupID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.AddMeToGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupID** | **Guid** |  |  |

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

<a id="creategroup"></a>
# **CreateGroup**
> ResponseGroup CreateGroup (RequestGroup requestGroup)

グループ作成

グループを作成します。traQのグループとは無関係です。

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
    public class CreateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GroupsApi(httpClient, config, httpClientHandler);
            var requestGroup = new RequestGroup(); // RequestGroup | グループの追加

            try
            {
                // グループ作成
                ResponseGroup result = apiInstance.CreateGroup(requestGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // グループ作成
    ApiResponse<ResponseGroup> response = apiInstance.CreateGroupWithHttpInfo(requestGroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.CreateGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestGroup** | [**RequestGroup**](RequestGroup.md) | グループの追加 |  |

### Return type

[**ResponseGroup**](ResponseGroup.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletegroup"></a>
# **DeleteGroup**
> void DeleteGroup (Guid groupID)

Delete group

グループの削除

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
    public class DeleteGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GroupsApi(httpClient, config, httpClientHandler);
            var groupID = "groupID_example";  // Guid | 

            try
            {
                // Delete group
                apiInstance.DeleteGroup(groupID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete group
    apiInstance.DeleteGroupWithHttpInfo(groupID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.DeleteGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupID** | **Guid** |  |  |

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
| **404** | Groupid not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletemefromgroup"></a>
# **DeleteMeFromGroup**
> void DeleteMeFromGroup (Guid groupID)

自分しか削除出来ない。open=true

自分しか削除出来ない。open=true

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
    public class DeleteMeFromGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GroupsApi(httpClient, config, httpClientHandler);
            var groupID = "groupID_example";  // Guid | 

            try
            {
                // 自分しか削除出来ない。open=true
                apiInstance.DeleteMeFromGroup(groupID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteMeFromGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMeFromGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 自分しか削除出来ない。open=true
    apiInstance.DeleteMeFromGroupWithHttpInfo(groupID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.DeleteMeFromGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupID** | **Guid** |  |  |

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

<a id="getgroup"></a>
# **GetGroup**
> ResponseGroup GetGroup (Guid groupID)

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
    public class GetGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GroupsApi(httpClient, config, httpClientHandler);
            var groupID = "groupID_example";  // Guid | 

            try
            {
                // 一件取得
                ResponseGroup result = apiInstance.GetGroup(groupID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 一件取得
    ApiResponse<ResponseGroup> response = apiInstance.GetGroupWithHttpInfo(groupID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupID** | **Guid** |  |  |

### Return type

[**ResponseGroup**](ResponseGroup.md)

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

<a id="getgroups"></a>
# **GetGroups**
> List&lt;ResponseGroup&gt; GetGroups ()

グループを全て取得

すべてのグループを取得する

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
    public class GetGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GroupsApi(httpClient, config, httpClientHandler);

            try
            {
                // グループを全て取得
                List<ResponseGroup> result = apiInstance.GetGroups();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // グループを全て取得
    ApiResponse<List<ResponseGroup>> response = apiInstance.GetGroupsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ResponseGroup&gt;**](ResponseGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getmygroups"></a>
# **GetMyGroups**
> List&lt;Guid&gt; GetMyGroups (string? relation = null)



自分の所属しているグループのIDを返す

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
    public class GetMyGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GroupsApi(httpClient, config, httpClientHandler);
            var relation = "admins";  // string? | どのような関係性でユーザーと結びつけるか。 取り得る値は、 admins(ユーザーが管理者), belongs(ユーザーが所属している),  belongs-or-admins(ユーザーが管理者または所属している)  イベントはさらに、attendees(not absent) 値がない場合は、belongs として振る舞う  (optional) 

            try
            {
                List<Guid> result = apiInstance.GetMyGroups(relation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetMyGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMyGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Guid>> response = apiInstance.GetMyGroupsWithHttpInfo(relation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetMyGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **relation** | **string?** | どのような関係性でユーザーと結びつけるか。 取り得る値は、 admins(ユーザーが管理者), belongs(ユーザーが所属している),  belongs-or-admins(ユーザーが管理者または所属している)  イベントはさらに、attendees(not absent) 値がない場合は、belongs として振る舞う  | [optional]  |

### Return type

**List<Guid>**

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

<a id="getusergroups"></a>
# **GetUserGroups**
> List&lt;Guid&gt; GetUserGroups (Guid userID, string? relation = null)



ユーザーが所属しているグループのIDを返す

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
    public class GetUserGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GroupsApi(httpClient, config, httpClientHandler);
            var userID = "userID_example";  // Guid | 
            var relation = "admins";  // string? | どのような関係性でユーザーと結びつけるか。 取り得る値は、 admins(ユーザーが管理者), belongs(ユーザーが所属している),  belongs-or-admins(ユーザーが管理者または所属している)  イベントはさらに、attendees(not absent) 値がない場合は、belongs として振る舞う  (optional) 

            try
            {
                List<Guid> result = apiInstance.GetUserGroups(userID, relation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.GetUserGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<Guid>> response = apiInstance.GetUserGroupsWithHttpInfo(userID, relation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.GetUserGroupsWithHttpInfo: " + e.Message);
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

**List<Guid>**

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

<a id="updategroup"></a>
# **UpdateGroup**
> ResponseGroup UpdateGroup (Guid groupID, RequestGroup requestGroup)



adminsのみ変更可能

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
    public class UpdateGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://knoq.trap.jp/api";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new GroupsApi(httpClient, config, httpClientHandler);
            var groupID = "groupID_example";  // Guid | 
            var requestGroup = new RequestGroup(); // RequestGroup | グループの追加

            try
            {
                ResponseGroup result = apiInstance.UpdateGroup(groupID, requestGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ResponseGroup> response = apiInstance.UpdateGroupWithHttpInfo(groupID, requestGroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.UpdateGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupID** | **Guid** |  |  |
| **requestGroup** | [**RequestGroup**](RequestGroup.md) | グループの追加 |  |

### Return type

[**ResponseGroup**](ResponseGroup.md)

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

