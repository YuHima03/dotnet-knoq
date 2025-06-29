# Knoq.Model.ResponseEventDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventId** | **Guid** |  | 
**Name** | **string** |  | 
**Description** | **string** |  | 
**SharedRoom** | **bool** | 部屋の共用をするか | 
**TimeStart** | **string** |  | 
**TimeEnd** | **string** |  | 
**Place** | **string** |  | 
**GroupName** | **string** |  | 
**Open** | **bool** | グループ外のユーザーが参加予定を出来るか | 
**Room** | [**ResponseRoom**](ResponseRoom.md) |  | 
**Group** | [**ResponseGroup**](ResponseGroup.md) |  | 
**Admins** | **List&lt;Guid&gt;** | 編集権を持つユーザー | 
**Tags** | [**List&lt;ResponseEventTagsInner&gt;**](ResponseEventTagsInner.md) |  | 
**Attendees** | [**List&lt;ResponseEventDetailAttendeesInner&gt;**](ResponseEventDetailAttendeesInner.md) |  | 
**CreatedBy** | **Guid** |  | 
**CreatedAt** | **string** |  | 
**UpdatedAt** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

