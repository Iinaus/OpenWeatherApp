# C# OpenWeatherApp

## Table of contents
- [About](#about)
- [Features](#features)
- [Getting started](#getting-started)
    - [Prerequisites](#prerequisites)
    - [Dependencies](#dependencies)
    - [Dev setup step-by-step](#dev-setup-step-by-step)

## About

This is a simple .NET application that fetches and displays weather information for two cities, Nurmijärvi and Rovaniemi, using the OpenWeatherMap API. The application retrieves the current weather data and presents it in a user-friendly format, including temperature, humidity, and other weather statistics. The project was developed as part of the coursework for an object-oriented programming (OOP) course at Lapland University of Applied Sciences.

With this exercise, we practiced:
- Fetching data from a third-party API (OpenWeatherMap).
- Working with environment variables for secure storage of sensitive information (API keys).
- Parsing and deserializing JSON data.
- Displaying weather information in a user-friendly format in the console.
- Error handling and debugging within a .NET application.

## Features

- Fetches weather data for two cities: Nurmijärvi and Rovaniemi.
- Displays the current temperature, feels like temperature, maximum and minimum temperatures, and humidity.
- Converts Unix timestamp to a human-readable date.
- Uses environment variables for storing the API key securely.

## Getting started

Instructions on how to set up and run the project.

### Prerequisites

- .NET 6.0 or higher
- [OpenWeatherMap API key](https://openweathermap.org/api)
    - You need to sign up and get your own API key
- [dotenv.net](https://github.com/huobby/dotenv.net) 
    - library for loading environment variables

### Dev setup step-by-step

1. Clone or download this repository.
2. Open the solution in Visual Studio or your preferred .NET IDE.
3. Install the required dependencies:
   - `dotenv.net` (for loading environment variables)
4. Create `.env` file in the project root and add API key to the file `API_KEY=XXXXXXXXXXXXXXX`
5. Run the project with command `dotnet run`
