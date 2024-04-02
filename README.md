
ONWaRD is short for Online Network for Writing and Retrieving Data. This is a REST API service built with the Spring Boot framework that allows a platform where companies can electronically manage all their data, enabling them to go paperless. <br/>
This application demonstrates how to utilize Microsoft .NET Maui Framework, Spring Boot application, and Project Lombok to work together  to create an innovative product. <br/>
 <br/> This is a front end part <br/>

  * [_Technologies Used_](#technologies-used)
  * [_Extension on Visual Studio_](#extension-on-visual-studio)
  * [_Requirements_](#requirements)
  * [_Installation_](#installation)
  * [_Contributing_](#contributing)
  * [_License_](#license)
  * [_Acknowledgements_](#acknowledgements)

## _Technologies Used_

The following technologies were used to build this application: <br/>
+ Maven <br/>
+ Microsoft .NET Maui Framework <br/>
+ C#
+ XAML
+ JSON
+ Visual Studio  <br/>

## _Extension on Visual Studio_

The following Extension were used in Visual Studio : <br/>

+ .NET Extension Pack v1.0.13<br/>
+ C# v2.22.5 <br/>
+ CS-Script v2.2.1<br/>
Optional:
+ Spring Boot Dashboard v0.2.1 <br/>


## _Requirements_


* Having Microsoft .NET Maui Framework for the Front end. <br>
  Install **Microsoft .NET Maui Framework 8.0.3** from [Microsoft's website](https://dotnet.microsoft.com/en-us/download).

  Having Android SDK platform  by Xamarin. Follow the step in [Microsoft's website](https://learn.microsoft.com/en-us/xamarin/android/get-started/installation/android-sdk?tabs=windows).


  
## _Installation_

1. Clone this repository to your local machine using this
   command: <br/> `git clone https://github.com/LyonKhang/onward.git`
2. Import the project into your IDE (such as Eclipse or Visual Studio code).
3. start the application from OnwardApplication.java
4. Run the application as a Spring Boot application (usually located in your IDE), or use the Maven plugin `mvn spring-boot:run`.
5. Go to localhost:8080/ on your web browser.

*Try adding endpoints with simple text and stuff, 
follow the template for greeting and add endpoint methods to DemoController,
just make sure you do it in the form @GetMapping("/YOURTEXTHERE")
The first slash is important

## _Architecture_

Frontend
* Microsoft .NET MAUI Framework: Our choice for the frontend to create a responsive and interactive user interface that operates across different platforms (Windows, macOS, iOS, Android) with a single codebase.
* C# and XAML: The primary languages used for development, where C# provides the logic and XAML defines the UI layout and design. This combination ensures a powerful yet flexible way to build our app’s interface.

Development Environment
* Visual Studio : The main Integrated Development Environment (IDE) used for the project, Mianly devleopd for hightly focus gcc..NET Extension Pack, and more for comprehensive development support.

Integration and Data Management
* JSON: Standard format for data exchange between the frontend and backend, ensuring compatibility and ease of data manipulation.

## _Knowledge Gained_

## _Contributing_
To make effective contributions to this software, follow these steps:
1. Fork this repository to your GitHub account.
2. Clone the forked repository to your local machine.
3. Create a new branch for your changes.
4. Make your changes and commit with descriptive commit messages in the following format:
5. Push your changes to your GitHub account.
6. Create a pull request from your branch to the original repository's main branch.
When making contributions, please keep the following in mind:
* Follow the code style and formatting guidelines used in the project.
* Follow the format for commit messages and be concise.
* Make sure that your changes do not break existing functionality.
*Write tests for any new code and ensure that all existing tests pass.

## _License_

Users outside have the right to use, copy, modify, and distribute the code included in this project (3/26/2024).

## _Acknowledgements_

This README structure was based on that within Nidhal Naffati's Rental-Car-Agency repository, which happened to use a very similar technology set as our project. The repository for this can be found here: [Car Rental Agency](https://github.com/NidhalNaffati/Rental-Car-Agency).
