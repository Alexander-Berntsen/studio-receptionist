h1><b>Studio Receptionist</b></h1>

# TOC

<!-- TOC -->

- [TOC](#toc)
- [Contributors guide](#contributors-guide)
    - [Prerequisits](#prerequisits)
    - [Create a local dev environment](#create-a-local-dev-environment)
    - [Run the project](#run-the-project)
    - [Project and solution structure](#project-and-solution-structure)
        - [Capgemini.StudioReceptionist.UI](#capgeministudioreceptionistui)
            - [Project structure](#project-structure)
            - [NPM commands](#npm-commands)
            - [Concepts](#concepts)
                - [SASS and styles](#sass-and-styles)
        - [Capgemini.StudioReceptionist.API](#capgeministudioreceptionistapi)
    - [Build process](#build-process)
    - [Unit testing vs. integration testing](#unit-testing-vs-integration-testing)

<!-- /TOC -->

# Contributors guide

This guide contains all information to start development with the Studio Receptionist AI solution.

## Prerequisits

The following software should get installed:

* Visual Studio 2017 (with NodeJS development and ASP.NET Web Development)
* NodeJS (newest LTS version)

## Create a local dev environment

* clone the repository (TODO: link to repo url)
* Open StudioReceptionistAI.sln in visual studio
* Build

> You have maybe manually to trigger the "npm install" task in the StudioReceptionistAI.UI solution by right clicking on npm folder and choosing "Install missing NPM packages".

## Run the project

* open the project in Visual Studio
* ensure that StudioReceptionistAI.API is set as the startup project
* ensure that "Debug" is used as the build configuration
* run the project by pressing CTRL+F5B

> Under the hood, in Application_Start on Global.asax the application runs the "npm start" command on the UI project, so a second webserver (webpack-dev-server) is brought up. Application_Unload removes the running npm start process.
> TODO: Application_End does not throw down the process, current implementation does not work

After you started the project:

* the browser is brought up with 2 tabs, one with the UI project running and one with the API project running
* when you change a file in  the UI project, the browser tab will reload with your newest changes in it.

## Project and solution structure

The solution consists of the following projects:

* Capgemini.StudioReceptionist.UI - React Application
* Capgemini.StudioReceptionist.API - Web API Project
* Capgemini.StudioReceptionist.API.Tests -  Unit test project for Web API

### Capgemini.StudioReceptionist.UI

Frontend for the receptionist project.

Technologies:

* Typescript
* NPM
* Webpack
* React
* Babel

#### Project structure

> Main folder: Capgemini.StudioReceptionist.UI

* Folder ***src*** contains the react application
* Folder ***config*** contains several configurations like webpack

#### NPM commands

Command | Description
--- | ---
`npm start` | Build app continuously (HMR enabled) and serve @ `http://localhost:8080`
`npm run start-prod` | Build app once (HMR disabled) and serve @ `http://localhost:3000`
`npm run build` | Build app to `/dist/`
`npm run test` | Run tests
`npm run lint` | Run Typescript and SASS linter
`npm run lint:ts` | Run Typescript linter
`npm run lint:sass` | Run SASS linter
`npm run start` | (alias of `npm run start-dev`)

#### Concepts

##### SASS and styles

A sass processor is already implemented. You can use sass notation for writing scss files. You should read more about SASS [here](https://sass-lang.com/).

Use [BEM](http://getbem.com/introduction/) as naming convention in CSS will save your life, so use it! Once understood, finding CSS in your sass files will be very easy.

### Capgemini.StudioReceptionist.API

Web API project for serving the backend.

Technologies:

* ASP.NET MVC WebApi
* C# 4.7

## Build process

## Unit testing vs. integration testing
