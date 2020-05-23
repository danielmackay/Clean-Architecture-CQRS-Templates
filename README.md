# Clean Architecture CQRS Templates

Command and Query templates that are designed to be used with the clean architecture dotnet template (ca-sln).

## Development
These instructions are for making template changes and testing locally

### Build

1. Make any required changes
2. Navigate to \templates
3. run `dotnet new -i .\`

### Test

1. Navigate to \test
2. run `dotnet new ca-command --name [COMMAND_NAME]` or `dotnet new ca-query --name [QUERY_NAME]`

## Production
The easiest way to share with others is to build a nuget package to share.

### Package

1. Navigate to \templates
2. Run `dotnet pack`

### Install
1. Run `dotnet new -i [PATH_TO_NUPKG_FILE]`

Alternatively, if the file has been uploaded to a nuget feed you can use `dotnet new -i [PACKAGE_ID]`

## Usage
Once the template package has been installed it should be used as follows.

### Creating a Command
1. Navigate to the top-level directory for the entity you are creating a command for. (e.g. Pets)
2. Run `dotnet new ca-command --name CreatePet`

This will create the following structure:

- Pets (existing)
  - Commands
    - CreatePetCommand
    - CreatePetCommandValidator

### Creating a Query
1. Navigate to the top-level directory for the entity you are creating a command for. (e.g. Pets)
2. Run `dotnet new ca-query --name GetAllPets`

This will create the following structure:

- Pets (existing)
  - Queries
    - GetAllPetsQuery
