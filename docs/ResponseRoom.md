# Knoq.Model.ResponseRoom

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RoomId** | **Guid** |  | 
**Place** | **string** |  | 
**TimeStart** | **string** |  | 
**TimeEnd** | **string** |  | 
**Verified** | **bool** | 部屋が使えることを保証する | 
**FreeTimes** | [**List&lt;Duration&gt;**](Duration.md) | どのイベントも使用していない時間帯 | [optional] 
**SharedTimes** | [**List&lt;Duration&gt;**](Duration.md) | 部屋を共用すれば、使用できる時間帯 | [optional] 
**Admins** | **List&lt;Guid&gt;** | 編集権を持つユーザー | 
**CreatedBy** | **Guid** |  | 
**CreatedAt** | **string** |  | 
**UpdatedAt** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

