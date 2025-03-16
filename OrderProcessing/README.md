# OrderProccessing

# Overview
This is a sample app for VisaPro deliverablae

# Prerequisies
.NET SDK 8.0 or higher
Visual Studio 2022
You can clone the repository and run via visual studio or via terminal by building
it first with "dotnet build" and then running it with "dotnet run"

# Repository
https://github.com/Hamza-Bin-Shoaib/OrderProccessing.git

# Running Tests
Open Orderprocssing.sln in visual studio
Go to nuget package manager console and run tests via "dotnet test" command
Tests can also run by selecting test dropdown on top of VS studio

# Branching Strategy
master (Main Branch): Stable production-ready code.
dev (Development Branch): Active development branch where features and fixes are integrated before merging into master.

# CI/CD Setup
The pipeline runs on push and pull requests to the master and dev branches.
It performs the following steps:
Checkout Code – Pulls the latest code from the repository.
Setup .NET – Installs .NET 8 runtime and SDK.
Restore Dependencies – Runs dotnet restore to install project dependencies.
Build the Project – Runs dotnet build to compile the application.
Run Tests – Executes unit tests using dotnet test.

