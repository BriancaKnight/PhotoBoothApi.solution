# Photo Booth API

### An api to find active photobooths in the Portland, OR area. 

#### By Brianca Knight

## Technologies Used

* C#
* .Net 6
* ASP.Net Core MVC
* Entity Framework Core
* MySQL
* MySQL Workbench
* Swagger
* Postman

## Description

An API  that functions as a photo booth locator for the Portland, Or area. Project includes authentication for Create, Update and Delete functionality. Users without tokens have Read functionality. Users can reach endpoints through postman and swagger. 

## Setup/Installation Requirements

### Cloning, Database, and AppSettings
* Clone this repo from `https://github.com/BriancaKnight/PhotoBoothApi.Solution`.

* In the production sub directory (named `PhotoBoothApi`) create a file named `appsettings.json` and add the following code to it:

 ```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=photo_booth_api;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  },
  "JWT": {
    "ValidAudience": "[EXAMPLE-AUDIENCE]",
    "ValidIssuer": "[EXAMPLE-AUDIENCE]",
    "Secret": "[SECRETPASSWORD12]"
  }
}
   ```

  Make sure to update the stringS with your own values for [USERNAME], [PASSWORD], [EXAMPLE-AUDENCE], and [SECRETPASSWORD12]without square brackets.

* In the terminal run the commands `dotnet restore` to install dependencies. 

* To set up the database schema run the command `dotnet ef database update`. 

* Run the command `dotnet run` to have access to the API in the broser via Swagger or in Postman. 

### API Use and Documentation

* Authorize a user through Postman by opening a POST request to `https://localhost:5000/accounts/register`. Add the following query to the body tab as raw data.
```
{
  "email": "test@test.com,
  "userName": test,
  "Password": "TestPassword1!"
}
```

* Past the generated token into the token parameter in the Authorization tab. Make sure the type is set to `Bearer Token`.

#### API Endpoints

Base URL: `https://localhost:5000`

##### HTTP REQUEST STRUCTURE
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id} 
```

##### Example Query
```
https://localhost:5000/api/booths/1
```

##### Sample JSON Response
```
{
    "boothId": 1,
    "location": "The Florida Room",
    "address": "435 N Killingsworth St, Portland, OR 97217",
    "neighborhood": "NE",
    "type": "Digital",
    "color": "Both"
}
```

##### Booths

Access info on current photobooths in the Portland area.

##### HTTP Request
```
GET /api/booths
POST /api/booths
GET /api/booths/{id}
PUT /api/booths/{id}
DELETE /api/booths/{id}
```

##### Path Parameters
| Parameter | Type | Required | Description |
| :---: | :---: | :---: | --- |
| type | string | false | Return matches by type.
| neighborhood | string | true | Return matches by neighborhood. |


##### Example Query
```
https://localhost:5000/api/booths?type=analog&neighborhood=sw
```

#### Sample JSON Response
```
    {
        "boothId": 2,
        "location": "Stumptown Coffee",
        "address": "1026 SW Harvey Milk St, Portland, OR 97205",
        "neighborhood": "SW",
        "type": "Analog",
        "color": "B&W"
    }
```

## Known Bugs
* None.

## License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2023 Brianca Knight