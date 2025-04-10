# 🌦️ Resideo Weather Application Overview

---

## 📖 Purpose

This repository contains the source code for the *Resideo Weather Data Exercise*.

The Resideo Weather Application is a simple WinForms application that retrieves weather data from AWS cloud storage for three different cities across six different dates. 

The application processes this data and generates a JSON report that can be viewed within the application interface. It is built using C# and .NET Framework.

---

## ⚙️ Functionality

The application performs the following steps:

1. Fetches weather data files stored in AWS S3 buckets.
2. Processes this data to extract relevant information.
3. Transforms the processed data into a specified format.
4. Displays the transformed data as a JSON report within the application.

---

## 🛠️ Tools and Technologies Used

- **Microsoft Visual Studio** — The primary IDE used for development.
- **C#** — The programming language used to build the application.
- **.NET Core 8.0** — The framework used for building the application.
- **GitHub** — The version control system used for managing the source code.
- **GitHub Copilot** — AI-powered code completion tool that assists in writing code and documentation.

---

## 🚀 How to Run

1. Clone the repository to your local machine using Git:
```
```bash
git clone https://github.com/Fike-Rehman/ResideoWeather
```
2. Open the solution file (.sln) in Microsoft Visual Studio.
3. Build and run the application using Visual Studio.
4. Click the `Get Weather` button to view the report.

---

## 🔧 Project Structure

### Model Folder
Contains classes that represent the data structures used within the application. These models correspond to the structure of the weather data being processed by this application.

### Services Folder
Includes classes responsible for handling the core logic of the application, such as retrieving data from remote sources, processing it, and generating the JSON report. These services are designed to be modular and reusable, allowing for easy extension or replacement of functionality without impacting the overall application structure. The services are injected into the main form using dependency injection, promoting a clean separation of concerns and enhancing testability.

There are two main services:

- **RemoteDataImporter.cs** — This service currently imports data from the AWS S3 buckets and loads it into the application model. Only the relevant data is retrieved using the `Newtonsoft.Json` package and an `HttpClient`. No assumptions are made about the available data (number of cities or dates). This service can easily be extended or replaced to retrieve data from other sources (e.g., local files, Azure Cloud) by adding new interfaces without impacting the rest of the application.

- **ResideoWeatherReportFormatter.cs** — This service is responsible for formatting the weather data into a JSON report as required. It takes the processed data and converts it into a structured JSON format that can be easily displayed within the application. It encapsulates the formatting logic, allowing for easy modifications or enhancements in the future.

The service also uses `Newtonsoft.Json` library to serialize the data into JSON format. There are three distinct steps that are followed here:

1. **Transform** — Format the incoming data into the shape needed for the report.
2. **Filter** — Filter out the data to only get the city with the lowest temperature for each date.
3. **Format** — Finally, format the data into a JSON string that can be displayed in the UI with correct field names and values.

---

### ConfigurationManager.cs
Manages application configurations. Currently, it reads the three AWS S3 URL strings from the `appSettings.json` file.

### appSettings.json
A settings file that stores URL strings for the remote data sources. More URL strings can be added here as needed, and they will be included in the data processing.

### Program.cs
The main entry point of the application, initializing and running the WinForms application. It also registers the services with the dependency injection container, ensuring that the necessary services are available for use within the application. This setup allows for a clean and maintainable architecture, where services can be easily replaced or extended without impacting the overall application structure.

### ResideoWeather.cs & ResideoWeather.Designer.cs
Define the main form of the application, including the user interface elements and their event handlers.

---

## 🌐 Future Enhancements

I wanted to timebox this exercise, but I can definitely see the value in adding some unit tests to the services to ensure that the data processing and formatting logic works as expected when adding new data sources or modifying existing ones. 

For example:
- Cities with uneven number of dates
- Cities with no data
- Certain missing data

These scenarios could be effectively covered with unit tests to ensure robustness.

