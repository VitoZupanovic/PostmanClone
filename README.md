# Postman Clone

A desktop HTTP client built with C# and Windows Forms as a university project. It allows users to send API requests, inspect responses, and revisit previous requests.

## Features

- Send GET, POST, PUT, and DELETE requests
- Configure query parameters, path parameters, and headers
- Send JSON, XML, or plain-text request bodies
- Use bearer tokens through the Authorization header
- View response content, HTTP status, response time, and size
- Save, reload, and clear request history
- Handle empty URLs and connection errors

## Technologies

- C#
- .NET 8
- Windows Forms
- HttpClient
- System.Text.Json

## How to run

1. Use Windows with Visual Studio 2022 and the .NET desktop development workload installed.
2. Clone or download this repository.
3. Open PostmanClone.sln.
4. Build the solution and press F5.

The application can send requests to any accessible HTTP API. No database or separate backend is required to launch it.

## Request history

Request history is stored locally in request-history.json.
It may contain sensitive request and response data, so it is excluded from Git.