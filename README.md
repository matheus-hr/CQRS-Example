# CQRS Example

This project is intended for learning purposes and demonstrates how to apply the CQRS pattern in a simple customer registration system.

## Overview

This project showcases two different implementations:

1. **Basic Example (Without Full CQRS -  https://github.com/matheus-hr/CQRS-Example/tree/whitout_MediatR)**  
   A simple implementation that introduces the idea of the CQRS pattern, but without fully applying it.

2. **CQRS with MediatR - https://github.com/matheus-hr/CQRS-Example/tree/main**  
   An example that fully implements CQRS, using MediatR to orchestrate commands and queries with their respective handlers.

## Features

This project includes a basic customer management system with the following functionalities:

- **Create a customer**  
  You can register a new customer by providing the following information:
  - `Id`
  - `FullName`
  - `Email`
  - `PhoneNumber`

- **Retrieve a customer**  
  - You can search for a customer by their `Id`.
  - You can search for a customer by their `FullName` and  `Email`.

## How to Run the Project

Follow these steps to run the project locally:

1. Clone this repository:
   ```bash
   git clone https://github.com/matheus-hr/CQRS-Example.git

2. Navigate to the project directory:
   ```bash
   cd cqrs-example

3. Restore the project dependencies:
   ```bash
   dotnet restore

4. Build the project:
   ```bash
   dotnet build

5. Run the application:
   ```bash
   dotnet run
   
6. Or Execute in your Visual Studio
