#Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (SignereNoAddons.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](http://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=SignereNoAddons-CSharp&workspaceName=SignereNoAddons&projectName=SignereNoAddons.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the SignereNoAddons library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](http://apidocs.io/illustration/cs?step=addProject&workspaceFolder=SignereNoAddons-CSharp&workspaceName=SignereNoAddons&projectName=SignereNoAddons.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](http://apidocs.io/illustration/cs?step=createProject&workspaceFolder=SignereNoAddons-CSharp&workspaceName=SignereNoAddons&projectName=SignereNoAddons.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](http://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=SignereNoAddons-CSharp&workspaceName=SignereNoAddons&projectName=SignereNoAddons.PCL)

### 3. Add reference of the library project

In order to use the SignereNoAddons library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](http://apidocs.io/illustration/cs?step=addReference&workspaceFolder=SignereNoAddons-CSharp&workspaceName=SignereNoAddons&projectName=SignereNoAddons.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` SignereNoAddons.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```SignereNoAddons.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=createReference&workspaceFolder=SignereNoAddons-CSharp&workspaceName=SignereNoAddons&projectName=SignereNoAddons.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=addCode&workspaceFolder=SignereNoAddons-CSharp&workspaceName=SignereNoAddons&projectName=SignereNoAddons.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication and 
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | The OAuth 2.0 access token to be set before API calls |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string oAuthAccessToken = "oAuthAccessToken"; // The OAuth 2.0 access token to be set before API calls

SignereNoAddonsClient client = new SignereNoAddonsClient(oAuthAccessToken);
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [SignatureRolesCheck](#signature_roles_check)
* [OfficialPersonRegistry](#official_person_registry)
* [PersonalInfo](#personal_info)
* [CompanyInfo](#company_info)
* [CreditCheck](#credit_check)

### <a name="signature_roles_check"></a>![Class: ](http://apidocs.io/img/class.png "Signere.no.Controllers.SignatureRolesCheck") SignatureRolesCheck

#### Get singleton instance

The singleton instance of the ``` SignatureRolesCheck ``` class can be accessed from the API Client.

```csharp
SignatureRolesCheck signatureRolesCheck = client.SignatureRolesCheck;
```

#### <a name="create_signature_roles_check_check_signatures"></a>![Method: ](http://apidocs.io/img/method.png "Signere.no.Controllers.SignatureRolesCheck.CreateSignatureRolesCheckCheckSignatures") CreateSignatureRolesCheckCheckSignatures

> Check signatures / prokura


```csharp
Task<SignereNoAddonservicesModelsSignatureCheckSignatureStatusResponse> CreateSignatureRolesCheckCheckSignatures(
        Guid accountId,
        SignereNoAddonservicesModelsSignatureCheckSignatureCheckRequest data,
        bool? isprod = null,
        bool? includereport = null,
        string countrycode = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | Signere account Id |
| data |  ``` Required ```  | An array including all the organizations you want to check |
| isprod |  ``` Optional ```  | Test environment if false |
| includereport |  ``` Optional ```  | Returns a pdf report explaining the validity of the checked signatures, default value is true |
| countrycode |  ``` Optional ```  | Default value is "NO" |


#### Example Usage

```csharp
Guid accountId = Guid.NewGuid();
var data = new SignereNoAddonservicesModelsSignatureCheckSignatureCheckRequest();
bool? isprod = true;
bool? includereport = true;
string countrycode = "countrycode";

SignereNoAddonservicesModelsSignatureCheckSignatureStatusResponse result = await signatureRolesCheck.CreateSignatureRolesCheckCheckSignatures(accountId, data, isprod, includereport, countrycode);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad request |
| 401 | Not authorized |
| 500 | Internal server error (Miscellaneous) |
| 404 | Organization data not found |


#### <a name="get_signature_roles_check_get_rights"></a>![Method: ](http://apidocs.io/img/method.png "Signere.no.Controllers.SignatureRolesCheck.GetSignatureRolesCheckGetRights") GetSignatureRolesCheckGetRights

> Get rights


```csharp
Task<SignereNoAddonservicesModelsSignatureCheckSignatureRights> GetSignatureRolesCheckGetRights(
        Guid accountId,
        string orgnumber,
        bool? isprod = null,
        string countrycode = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | Signere account Id |
| orgnumber |  ``` Required ```  | TODO: Add a parameter description |
| isprod |  ``` Optional ```  | Set to false if you want to use the test environment, else true |
| countrycode |  ``` Optional ```  | Default value is "NO" |


#### Example Usage

```csharp
Guid accountId = Guid.NewGuid();
string orgnumber = "orgnumber";
bool? isprod = true;
string countrycode = "countrycode";

SignereNoAddonservicesModelsSignatureCheckSignatureRights result = await signatureRolesCheck.GetSignatureRolesCheckGetRights(accountId, orgnumber, isprod, countrycode);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad request |
| 401 | Not authorized |
| 500 | Internal server error (Miscellaneous) |
| 404 | Organization data not found |


[Back to List of Controllers](#list_of_controllers)

### <a name="official_person_registry"></a>![Class: ](http://apidocs.io/img/class.png "Signere.no.Controllers.OfficialPersonRegistry") OfficialPersonRegistry

#### Get singleton instance

The singleton instance of the ``` OfficialPersonRegistry ``` class can be accessed from the API Client.

```csharp
OfficialPersonRegistry officialPersonRegistry = client.OfficialPersonRegistry;
```

#### <a name="get_official_person_registry_get_by_address"></a>![Method: ](http://apidocs.io/img/method.png "Signere.no.Controllers.OfficialPersonRegistry.GetOfficialPersonRegistryGetByAddress") GetOfficialPersonRegistryGetByAddress

> Name and full address


```csharp
Task<InfotorgInfotorgetResponse> GetOfficialPersonRegistryGetByAddress(
        Guid accountId,
        string username,
        string password,
        string firstname,
        string lastname,
        string address,
        string postalcode,
        string reason,
        string system,
        bool? isprod = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | Signere account Id |
| username |  ``` Required ```  | Infotorget username |
| password |  ``` Required ```  | Infotorget password |
| firstname |  ``` Required ```  | Query param |
| lastname |  ``` Required ```  | Query param |
| address |  ``` Required ```  | Query param |
| postalcode |  ``` Required ```  | Query param |
| reason |  ``` Required ```  | Reason for request |
| system |  ``` Required ```  | Your system name (Cannot contain any special characters or numbers) |
| isprod |  ``` Optional ```  | Test environment when false or undefined |


#### Example Usage

```csharp
Guid accountId = Guid.NewGuid();
string username = "username";
string password = "password";
string firstname = "firstname";
string lastname = "lastname";
string address = "address";
string postalcode = "postalcode";
string reason = "reason";
string system = "system";
bool? isprod = true;

InfotorgInfotorgetResponse result = await officialPersonRegistry.GetOfficialPersonRegistryGetByAddress(accountId, username, password, firstname, lastname, address, postalcode, reason, system, isprod);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad request |
| 401 | Not authorized |
| 500 | Internal server error (Miscellaneous) |


#### <a name="get_official_person_registry_get_by_dateof_birth_and_name"></a>![Method: ](http://apidocs.io/img/method.png "Signere.no.Controllers.OfficialPersonRegistry.GetOfficialPersonRegistryGetByDateofBirthAndName") GetOfficialPersonRegistryGetByDateofBirthAndName

> Date of birth and name


```csharp
Task<SignereNoAddonservicesModelsPersonOfficialPersonRegistryResponse> GetOfficialPersonRegistryGetByDateofBirthAndName(
        Guid accountId,
        string username,
        string password,
        int dateofbirth,
        string firstname,
        string lastname,
        string reason,
        string system,
        bool? isprod = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | Signere account Id |
| username |  ``` Required ```  | Infotorget username |
| password |  ``` Required ```  | Infotorget password |
| dateofbirth |  ``` Required ```  | Query param |
| firstname |  ``` Required ```  | Query param |
| lastname |  ``` Required ```  | Query param |
| reason |  ``` Required ```  | Reason for request |
| system |  ``` Required ```  | Your system name (Cannot contain any special characters or numbers) |
| isprod |  ``` Optional ```  | Test environment when false or undefined |


#### Example Usage

```csharp
Guid accountId = Guid.NewGuid();
string username = "username";
string password = "password";
int dateofbirth = 245;
string firstname = "firstname";
string lastname = "lastname";
string reason = "reason";
string system = "system";
bool? isprod = true;

SignereNoAddonservicesModelsPersonOfficialPersonRegistryResponse result = await officialPersonRegistry.GetOfficialPersonRegistryGetByDateofBirthAndName(accountId, username, password, dateofbirth, firstname, lastname, reason, system, isprod);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad request |
| 401 | Not authorized |
| 500 | Internal server error (Miscellaneous) |


#### <a name="get_official_person_registry_get_by_name_and_social_sec"></a>![Method: ](http://apidocs.io/img/method.png "Signere.no.Controllers.OfficialPersonRegistry.GetOfficialPersonRegistryGetByNameAndSocialSec") GetOfficialPersonRegistryGetByNameAndSocialSec

> Social security and name


```csharp
Task<InfotorgInfotorgetResponse> GetOfficialPersonRegistryGetByNameAndSocialSec(
        Guid accountId,
        string username,
        string password,
        string socialSecurityNumber,
        string firstname,
        string lastname,
        string reason,
        string system,
        bool? isprod = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | Signere account Id |
| username |  ``` Required ```  | Infotorget username |
| password |  ``` Required ```  | Infotorget password |
| socialSecurityNumber |  ``` Required ```  | Query param |
| firstname |  ``` Required ```  | Query param |
| lastname |  ``` Required ```  | Query param |
| reason |  ``` Required ```  | Reason for request |
| system |  ``` Required ```  | Your system name (Cannot contain any special characters or numbers) |
| isprod |  ``` Optional ```  | Test environment when false or undefined |


#### Example Usage

```csharp
Guid accountId = Guid.NewGuid();
string username = "username";
string password = "password";
string socialSecurityNumber = "socialSecurityNumber";
string firstname = "firstname";
string lastname = "lastname";
string reason = "reason";
string system = "system";
bool? isprod = true;

InfotorgInfotorgetResponse result = await officialPersonRegistry.GetOfficialPersonRegistryGetByNameAndSocialSec(accountId, username, password, socialSecurityNumber, firstname, lastname, reason, system, isprod);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad request |
| 401 | Not authorized |
| 500 | Internal server error (Miscellaneous) |


#### <a name="get_official_person_registry_get_by_social_sec"></a>![Method: ](http://apidocs.io/img/method.png "Signere.no.Controllers.OfficialPersonRegistry.GetOfficialPersonRegistryGetBySocialSec") GetOfficialPersonRegistryGetBySocialSec

> Social Security number


```csharp
Task<InfotorgInfotorgetResponse> GetOfficialPersonRegistryGetBySocialSec(
        Guid accountId,
        string username,
        string password,
        string socialSecurityNumber,
        string reason,
        string system,
        bool? isprod = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | Signere account Id |
| username |  ``` Required ```  | Infotorget username |
| password |  ``` Required ```  | Infotorget password |
| socialSecurityNumber |  ``` Required ```  | Query param |
| reason |  ``` Required ```  | Reason for request |
| system |  ``` Required ```  | Your system name (Cannot contain any special characters or numbers) |
| isprod |  ``` Optional ```  | Test environment when false or undefined |


#### Example Usage

```csharp
Guid accountId = Guid.NewGuid();
string username = "username";
string password = "password";
string socialSecurityNumber = "socialSecurityNumber";
string reason = "reason";
string system = "system";
bool? isprod = true;

InfotorgInfotorgetResponse result = await officialPersonRegistry.GetOfficialPersonRegistryGetBySocialSec(accountId, username, password, socialSecurityNumber, reason, system, isprod);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad request |
| 401 | Not authorized |
| 500 | Internal server error (Miscellaneous) |


[Back to List of Controllers](#list_of_controllers)

### <a name="personal_info"></a>![Class: ](http://apidocs.io/img/class.png "Signere.no.Controllers.PersonalInfo") PersonalInfo

#### Get singleton instance

The singleton instance of the ``` PersonalInfo ``` class can be accessed from the API Client.

```csharp
PersonalInfo personalInfo = client.PersonalInfo;
```

#### <a name="get_personal_info_person_info_phone_number"></a>![Method: ](http://apidocs.io/img/method.png "Signere.no.Controllers.PersonalInfo.GetPersonalInfoPersonInfoPhoneNumber") GetPersonalInfoPersonInfoPhoneNumber

> Phonenumber


```csharp
Task<SignereNoAddonservicesModelsPersonPersonInformation> GetPersonalInfoPersonInfoPhoneNumber(Guid accountId, string phonenumber)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | TODO: Add a parameter description |
| phonenumber |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
Guid accountId = Guid.NewGuid();
string phonenumber = "phonenumber";

SignereNoAddonservicesModelsPersonPersonInformation result = await personalInfo.GetPersonalInfoPersonInfoPhoneNumber(accountId, phonenumber);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad request |
| 401 | Not authorized |
| 500 | Internal server error (Miscellaneous) |


#### <a name="get_personal_info_person_info_social_sec"></a>![Method: ](http://apidocs.io/img/method.png "Signere.no.Controllers.PersonalInfo.GetPersonalInfoPersonInfoSocialSec") GetPersonalInfoPersonInfoSocialSec

> Name and social security number


```csharp
Task<SignereNoAddonservicesModelsPersonPersonInformation> GetPersonalInfoPersonInfoSocialSec(Guid accountId, string name, string socialSec)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | Signere account Id |
| name |  ``` Required ```  | Query param |
| socialSec |  ``` Required ```  | Query param |


#### Example Usage

```csharp
Guid accountId = Guid.NewGuid();
string name = "name";
string socialSec = "socialSec";

SignereNoAddonservicesModelsPersonPersonInformation result = await personalInfo.GetPersonalInfoPersonInfoSocialSec(accountId, name, socialSec);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad request |
| 401 | Not authorized |
| 500 | Internal server error (Miscellaneous) |


#### <a name="get_personal_info_person_info_date_of_birth"></a>![Method: ](http://apidocs.io/img/method.png "Signere.no.Controllers.PersonalInfo.GetPersonalInfoPersonInfoDateOfBirth") GetPersonalInfoPersonInfoDateOfBirth

> Date of birth and name


```csharp
Task<SignereNoAddonservicesModelsPersonPersonInformation> GetPersonalInfoPersonInfoDateOfBirth(Guid accountId, string name, string dateOfBirth)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | Signere account Id |
| name |  ``` Required ```  | Query param |
| dateOfBirth |  ``` Required ```  | Query param |


#### Example Usage

```csharp
Guid accountId = Guid.NewGuid();
string name = "name";
string dateOfBirth = "dateOfBirth";

SignereNoAddonservicesModelsPersonPersonInformation result = await personalInfo.GetPersonalInfoPersonInfoDateOfBirth(accountId, name, dateOfBirth);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad request |
| 401 | Not authorized |
| 500 | Internal server error (Miscellaneous) |


[Back to List of Controllers](#list_of_controllers)

### <a name="company_info"></a>![Class: ](http://apidocs.io/img/class.png "Signere.no.Controllers.CompanyInfo") CompanyInfo

#### Get singleton instance

The singleton instance of the ``` CompanyInfo ``` class can be accessed from the API Client.

```csharp
CompanyInfo companyInfo = client.CompanyInfo;
```

#### <a name="get_company_info_get_org_info_bisnode"></a>![Method: ](http://apidocs.io/img/method.png "Signere.no.Controllers.CompanyInfo.GetCompanyInfoGetOrgInfoBisnode") GetCompanyInfoGetOrgInfoBisnode

> Matchit


```csharp
Task<SignereNoAddonservicesModelsCompanyCompanyInformationResponse> GetCompanyInfoGetOrgInfoBisnode(Guid accountId, string companyname = null, string orgnumber = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | Signere account Id |
| companyname |  ``` Optional ```  | query param |
| orgnumber |  ``` Optional ```  | query param |


#### Example Usage

```csharp
Guid accountId = Guid.NewGuid();
string companyname = "companyname";
string orgnumber = "orgnumber";

SignereNoAddonservicesModelsCompanyCompanyInformationResponse result = await companyInfo.GetCompanyInfoGetOrgInfoBisnode(accountId, companyname, orgnumber);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Not found |
| 401 | Not authorized |
| 400 | Bad request |
| 500 | Internal Server Error (Miscellaneous) |


#### <a name="get_company_info_get_org_info_difi"></a>![Method: ](http://apidocs.io/img/method.png "Signere.no.Controllers.CompanyInfo.GetCompanyInfoGetOrgInfoDifi") GetCompanyInfoGetOrgInfoDifi

> Difi


```csharp
Task<SignereNoAddonservicesModelsCompanyDifiResponse> GetCompanyInfoGetOrgInfoDifi(string orgnumber = null, string companyname = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orgnumber |  ``` Optional ```  | TODO: Add a parameter description |
| companyname |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string orgnumber = "orgnumber";
string companyname = "companyname";

SignereNoAddonservicesModelsCompanyDifiResponse result = await companyInfo.GetCompanyInfoGetOrgInfoDifi(orgnumber, companyname);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Not found |
| 400 | Bad request |
| 500 | Internal Server Error (Miscellaneous) |


[Back to List of Controllers](#list_of_controllers)

### <a name="credit_check"></a>![Class: ](http://apidocs.io/img/class.png "Signere.no.Controllers.CreditCheck") CreditCheck

#### Get singleton instance

The singleton instance of the ``` CreditCheck ``` class can be accessed from the API Client.

```csharp
CreditCheck creditCheck = client.CreditCheck;
```

#### <a name="get_credit_check_business_credit_check"></a>![Method: ](http://apidocs.io/img/method.png "Signere.no.Controllers.CreditCheck.GetCreditCheckBusinessCreditCheck") GetCreditCheckBusinessCreditCheck

> Business credit check


```csharp
Task<SignereNoAddonservicesModelsCompanyCreditCheckCompanyResponse> GetCreditCheckBusinessCreditCheck(
        Guid accountId,
        int orgnumber,
        bool? isprod = null,
        string userId = null,
        string password = null,
        string countryCode = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | Signere account Id |
| orgnumber |  ``` Required ```  | TODO: Add a parameter description |
| isprod |  ``` Optional ```  | Test environment when false or undefined |
| userId |  ``` Optional ```  | Override bisnode user Id |
| password |  ``` Optional ```  | Override bisnode password |
| countryCode |  ``` Optional ```  | Default = "NO" |


#### Example Usage

```csharp
Guid accountId = Guid.NewGuid();
int orgnumber = 245;
bool? isprod = true;
string userId = "userId";
string password = "password";
string countryCode = "countryCode";

SignereNoAddonservicesModelsCompanyCreditCheckCompanyResponse result = await creditCheck.GetCreditCheckBusinessCreditCheck(accountId, orgnumber, isprod, userId, password, countryCode);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad request |
| 401 | Not authorized |
| 500 | Internal server error (Miscellaneous) |


#### <a name="get_credit_check_private_credit_check"></a>![Method: ](http://apidocs.io/img/method.png "Signere.no.Controllers.CreditCheck.GetCreditCheckPrivateCreditCheck") GetCreditCheckPrivateCreditCheck

> Private credit check


```csharp
Task<SignereNoAddonservicesModelsPersonCreditCheckPersonResponse> GetCreditCheckPrivateCreditCheck(
        Guid accountId,
        long socialSecurityNumber,
        bool? isprod = null,
        string userId = null,
        string password = null,
        int? phonenumber = null,
        string email = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | Signere account Id |
| socialSecurityNumber |  ``` Required ```  | TODO: Add a parameter description |
| isprod |  ``` Optional ```  | Test environment when false or undefined |
| userId |  ``` Optional ```  | Override bisnode user Id |
| password |  ``` Optional ```  | Override bisnode password |
| phonenumber |  ``` Optional ```  | Specify this to use electronic duplicate letters |
| email |  ``` Optional ```  | Specify this to use electronic duplicate letters |


#### Example Usage

```csharp
Guid accountId = Guid.NewGuid();
long socialSecurityNumber = 245;
bool? isprod = false;
string userId = "userId";
string password = "password";
int? phonenumber = 82;
string email = "email";

SignereNoAddonservicesModelsPersonCreditCheckPersonResponse result = await creditCheck.GetCreditCheckPrivateCreditCheck(accountId, socialSecurityNumber, isprod, userId, password, phonenumber, email);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Bad request |
| 401 | Not authorized |
| 500 | Internal server error (Miscellaneous) |


[Back to List of Controllers](#list_of_controllers)



