# WindowsStoreServices
You can query the Windows Store Services API (only Analytics API as of now) with WindowsStoreServices.
It provides an easy and strongly-typed way to interact with data about your Windows Store apps.

Data you can get from this SDK are :
- App acquisitions
- A list of your published applications
- Error reporting data
- IAP acquisitions
- Ratings
- Reviews

It still is an early release.
If you encounter any bugs, please report it or feel free to participate on this repository.

Prerequisites
-------
WindowsStoreServices SDK will require you to setup properly your Dev Center account with your Azure AD to authenticate you, otherwise you won't be allow to query for data.

All the prerequisites needed for this SDK are under "Associate an Azure AD application with your Windows Dev Center account" : https://msdn.microsoft.com/en-us/windows/uwp/monetize/access-analytics-data-using-windows-store-services


How to install it
-------
A NuGet package of this SDK is available here : https://www.nuget.org/packages/WindowsStoreServices/

It's a Portable Class Library that supports .NET Framework 4.5, Windows 8 up to 10, Windows Phone 8, ASP.NET Core 1.0 and Xamarin (Android and iOS).

Otherwise, you can clone this repository.


How to get an OAuth token
-------
Once all the prerequisites have been done, you will need to get an authentication token for your Azure AD application before querying the API.

Here's how to do it :
```csharp
var oauthClient = new WindowsStoreServices.OAuth.OAuthClient();
var token = await oauthClient.GetTokenAsync("{YOUR-AZURE-AD-TENANT-ID}",
                                            "{YOUR-AZURE-AD-APPLICATION-CLIENT-ID}",
                                            "{YOUR-AZURE-AD-APPLICATION-SECRETKEY}");
```


How to get analytics data
-------
```csharp
var analyticsContext = new AnalyticsContext(token);

// Retrieve all the apps published by your Dev Center account
var apps = await analyticsContext.Applications().GetResultsAsync();

// Retrieve reviews for an app
var reviews = await analyticsContext.Reviews(apps.First().ApplicationId)
                                    .Between(new DateTime(2016, 1, 1), DateTime.Now)
                                    .OrderBy(ReviewsOrderBy.OsVersion)
                                    .ThenOrderBy(ReviewsOrderBy.Rating, OrderByDirections.Descending)
                                    .Take(5)
                                    .GetResultsAsync();
```
