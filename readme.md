# GetApp Import
Small application to import Products from external files (YAML/CSV) to database.

## Design
- I implemented a Factory to get the Product Provider: Capterra, Software Advise or a new one based on CSV Files (from URL). All of them implement a common interface and they have different business logic to map the products from the files.
- My understanding is that each provider can have a different format file, for that reason each of them have a different business logic for mapping.
- I'm using Dependency Injection to inject the DataService that I want to use, in this case MySQL but the system is ready to use another implmenentations of IDataService (MongoDB, or others)
- I created a Product Processor Async to avoid get the app frozen during the import of the products (in case that we are importing a lot of records)
- I created some dummy data to avoid persist any information
- I created a Unit Test project using MSTest

## Installation steps
- Console Application. Could be deployed in a VM or physical server

## Execution steps
- Execute command: dotnet GetApp_Import.dll [Source] [FilePath]
	* Source: can be capterra / softwareadvice / csvfile
	* FilePath: path of the file to import

## GIT Repository
https://github.com/tdtorre/GetApp_Import

## Future improvements
- Create a job that check periodically the folder and execute the import automatically
- Create more Unit Tests and Integration Tests
- Use some mapping library
