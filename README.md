<div align="center">
  <img src="https://user-images.githubusercontent.com/70706753/109709512-46a57180-7ba5-11eb-944e-3c0e918e4405.png"  alt="RestAPI-NoSQL"/>
</div>

## Table of contents

> * [Table of contents](#table-of-contents)
> * [General info](#general-info)
> * [Used technologies & tools](#used-technologies--tools)
> * [Usage](#Usage)
>   * [Requirements](#Requirements)
>   * [Running application](#running-application)

## General Info

* ASP.NET Core 5 web api with a functional REST API and its own MongoDB database.
* Implementing basic CQRS
* Project status: learning prototype

## Used Technologies & Tools
* ASP.NET Core 5.0 - _a cross-platform software framework._
* C# 9.0 _programming language_
* MongoDB.Driver/2.11.6 - _official .NET driver for MongoDB._
* AutoMapper/10.1.1 - _a convention-based object-object mapper._
* MediatR/9.0.0 - _simple, unambitious mediator implementation in .NET._

## Usage

### Requirements
* Installed .NET 5.0 SDK on your machine


* Running MongoDB server. Optionally you can run it as a container on Docker (using Command Line):

  `docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo`

### Running Application
* Open **RestAPI-NoSQL** folder directory on Command Line - "cd" to directory:
  
  `cd path/to/directory/of/RestAPI-NoSQL`


* Start application:

  `dotnet run --project ./RestAPI-NoSQL.WebApi/RestAPI-NoSQL.WebApi.csproj`


* Open `https://localhost:5001/swagger/index.html` on your browser to launch a **Swagger UI** and visually render documentation for the application.