# Knoq.Model.RequestEventStock
既存の部屋を使う

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** |  | 
**Description** | **string** |  | 
**SharedRoom** | **bool** | 部屋の共用をするか | 
**TimeStart** | **string** |  | 
**TimeEnd** | **string** |  | 
**RoomId** | **Guid** |  | 
**GroupId** | **Guid** |  | 
**Open** | **bool** | グループ外のユーザーが参加予定を出来るか | [optional] 
**Admins** | **List&lt;Guid&gt;** | 編集権を持つユーザー | 
**Tags** | [**List&lt;RequestEventInstantTagsInner&gt;**](RequestEventInstantTagsInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

