String API

This API takes a string as input and returns the reversed string while checking if the input string is a palindrome.

 Prerequisites

- .NET Core SDK 8.0
- Visual Studio 2022 or later

Getting Started

Installation

1. Clone the repository:

   ```sh
   git clone https://github.com/<COLBY123456>/<StringApi>.git
   cd <StringApi>

Open the project:
* Open the solution file (.sln) in Visual Studio 2022.
Restore dependencies:
* In Visual Studio, go to Tools > NuGet Package Manager > Package Manager Console.
* Run the following command:   dotnet restore


Usage
* Run the project in Visual Studio. Swagger UI should open automatically.
* Use Swagger UI to test the API endpoints.
Example:
1. Send a GET request to the /api/string endpoint with the input query parameter.
GET https://localhost:5001/api/string?input=racecar

{
    "reversedString": "racecar",
    "isPalindrome": true
}


Contributing
Contributions are welcome! Please follow these steps:
1. Fork the repository.
2. Create a new branch (git checkout -b feature-name).
3. Make your changes.
4. Commit your changes (git commit -am 'Add new feature').
5. Push to the branch (git push origin feature-name).
6. Create a new Pull Request.

License
This project is licensed under the MIT License.


Explanation:

- Project Title and Description:Clearly states the purpose of the project.
  
- Prerequisites:Lists the software and tools required to run the project.

- Getting Started:
  - Installation:Provides steps to clone the repository, open it in Visual Studio, and restore dependencies.
  
- Usage:Explains how to run the project, interact with the API using Swagger UI, and provides an example request and response.

- Contributing:Outlines guidelines for contributing to the project, including how to fork, create branches, commit changes, and submit pull requests.

- License:*Specifies the license under which the project is distributed.

