# rolloutHubspot.Model.Error

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubCategory** | **string** | A specific category that contains more specific detail about the error | [optional] 
**Context** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | Context about the error condition | [optional] 
**CorrelationId** | **Guid** | A unique identifier for the request. Include this value with any error reports or support tickets | 
**Links** | **Dictionary&lt;string, string&gt;** | A map of link names to associated URIs containing documentation about the error or recommended remediation steps | [optional] 
**Message** | **string** | A human readable message describing the error along with remediation steps where appropriate | 
**Category** | **string** | The error category | 
**Errors** | [**List&lt;ErrorDetail&gt;**](ErrorDetail.md) | further information about the error | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

