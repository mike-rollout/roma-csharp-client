# rolloutHubspot.Api.SearchApi

All URIs are relative to *https://api.hubapi.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostCrmV3ObjectsContactsSearchDoSearch**](SearchApi.md#postcrmv3objectscontactssearchdosearch) | **POST** /crm/v3/objects/contacts/search |  |

<a id="postcrmv3objectscontactssearchdosearch"></a>
# **PostCrmV3ObjectsContactsSearchDoSearch**
> CollectionResponseWithTotalSimplePublicObjectForwardPaging PostCrmV3ObjectsContactsSearchDoSearch (PublicObjectSearchRequest publicObjectSearchRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using rolloutHubspot.Api;
using rolloutHubspot.Client;
using rolloutHubspot.Model;

namespace Example
{
    public class PostCrmV3ObjectsContactsSearchDoSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.hubapi.com";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure API key authorization: private_apps
            config.AddApiKey("private-app", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("private-app", "Bearer");

            var apiInstance = new SearchApi(config);
            var publicObjectSearchRequest = new PublicObjectSearchRequest(); // PublicObjectSearchRequest | 

            try
            {
                CollectionResponseWithTotalSimplePublicObjectForwardPaging result = apiInstance.PostCrmV3ObjectsContactsSearchDoSearch(publicObjectSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SearchApi.PostCrmV3ObjectsContactsSearchDoSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCrmV3ObjectsContactsSearchDoSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CollectionResponseWithTotalSimplePublicObjectForwardPaging> response = apiInstance.PostCrmV3ObjectsContactsSearchDoSearchWithHttpInfo(publicObjectSearchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SearchApi.PostCrmV3ObjectsContactsSearchDoSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **publicObjectSearchRequest** | [**PublicObjectSearchRequest**](PublicObjectSearchRequest.md) |  |  |

### Return type

[**CollectionResponseWithTotalSimplePublicObjectForwardPaging**](CollectionResponseWithTotalSimplePublicObjectForwardPaging.md)

### Authorization

[oauth2](../README.md#oauth2), [private_apps](../README.md#private_apps)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **0** | An error occurred. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

