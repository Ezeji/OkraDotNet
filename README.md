# Okra API wrapper for .Net

This library provides a convenient way to consume the [Okra API](https://docs.okra.ng/) from .Net projects.

## How to Install
1. #### Via Visual Studio IDE

+ On a new project, Navigate to the ***Solution Explorer*** tab within Visual Studio. 
+ Right-click on the ***References*** node and click on the *Manage Nuget Packages* from the resulting context menu. 
+ On the Nuget Package Manager window navigate to the ***Browse*** Tab. 
+ Key in **OkraDotNET** and select version _1.0.0_ or higher. 
+ Click on the ***Install*** button and accept the licences to proceed. .

![Install Package](ScreenShots/packageMgrInst.PNG) 

2. #### Via .NET CLI 

+ From the _command prompt/powershell window_ opened in your project directory, key in the following and press *Enter*. 

```powershell 
 dotnet add package OkraDotNET --version 1.0.0
```
> Ensure you have the latest version of the package. Visit [Nuget](https://www.nuget.org/packages/OkraDotNet/) for more info on the latest release of this package. 

3. #### Via Nuget Package Manger Console 

+ On your Nuget package manager console,key in the following and press *Enter* 
```powershell 
Install-Package OkraDotNET -Version 1.0.0 
```
> Ensure you have the latest version of the package. Visit [Nuget](https://www.nuget.org/packages/OkraDotNet/) for more info on the latest release of this package

# Usage
The **[OkraApi](https://github.com/abiolakunle/OkraDotNet/blob/master/OkraDotNet/OkraApi.cs)** class is an important type in this library .  This can be created as follows:

+ To use this package ensure you include the following `using` statement to your project file: 
```csharp 
 using OkraDotNet;
```

The package needs to be configured with your Okra.ng **accessToken** which you can get from your dashboard. 

```csharp  

 var accessToken = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx.xxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
 var isProduction = true;
 var api = new OkraApi(accessToken, isProduction);
  
```


## Auth API
To access the Auth API, use methods from the **[IAuthApi](https://github.com/abiolakunle/OkraDotNet/blob/master/OkraDotNet/Auth/AuthApi.cs)** interface (available via the **Auth** property of **OkraDotNET**, viz:
```c#

//Retrieve Auth request
var response1 = api.RetrieveAuthAsync(new PaginatedRequest { Limit = 10, Page = 1 }).Result;
if (response1.IsSuccess)
{
    RetrieveAuthResponseData data = response1.Value;
    // do something with data
}
else
{
    var error = response1.Error;
    //use error
}


//Auth By id
var response2 = api.AuthByIdAsync(new AuthByIdRequest { Id = "5f338d5c9e5c6e823a71e5e1", Limit = 2, Page = 1 }).Result;
if (response2.IsSuccess)
{
    AuthResponseData data = response2.Value;
    // do something with data
}
else
{
    var error = response2.Error;
    //use error
}

```

The **AuthApi** is defined as follows:
```c#
public interface IAuthApi
{
    Task<Result<AuthResponseData, OkraError>> AuthByBankAsync(AuthByBankRequest request);

    Task<Result<AuthResponseData, OkraError>> AuthByCustomerAsync(AuthByCustomerRequest request);

    Task<Result<AuthResponseData, OkraError>> AuthByCustomerAndDateAsync(AuthByCustomerAndDateRequest request);

    Task<Result<AuthResponseData, OkraError>> AuthByDateAsync(AuthByDateRequest request);

    Task<Result<AuthResponseData, OkraError>> AuthByIdAsync(AuthByIdRequest request);

    Task<Result<RetrieveAuthResponseData, OkraError>> RetrieveAuthAsync(PaginatedRequest request);

    Task<Result<string, OkraError>> RetrieveAuthAsPdfAsync(PaginatedRequest request);

    Task<Result<AuthCallbackResponseData, OkraError>> AuthCallBackAsync(string record);
}
```



