<div align="center">
  <img src="https://user-images.githubusercontent.com/70706753/109709512-46a57180-7ba5-11eb-944e-3c0e918e4405.png"  alt="RestAPI-NoSQL"/>
</div>

## Table of contents

> * [Table of contents](#table-of-contents)
> * [General info / Synopsis](#general-info)
> * [Used technologies](#used-technologies--tools)
> * [Usage](#Usage)
>   * [Requirements](#Requirements)

## General Info

* ASP.NET Core 5 web api with a functional REST API and its own MongoDB database.
* Implementing basic CQRS
* Project status: learning prototype

## Used Technologies & Tools
* ASP.NET Core 5.0
* C# 9.0
* MongoDB.Driver/2.11.6
* AutoMapper/10.1.1
* MediatR/9.0.0

## Usage

### Requirements
* Installed .NET 5.0 SDK on your machine


* Running MongoDB server. Optionally can run it as a container on Docker (using Command Line):

  `docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo`

### Running Application
* Open **RestAPI-NoSQL** folder directory on Command Line - "cd" to directory:
  
  `cd path/to/directory`


* Start application:

  `dotnet run --project ./RestAPI-NoSQL.WebApi/RestAPI-NoSQL.WebApi.csproj`


* Open `https://localhost:5001/swagger/index.html` on your browser to launch a **Swagger UI** to visually render documentation for application.