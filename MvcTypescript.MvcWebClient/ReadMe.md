# MVC & TypeScript Reference Project

## Strategy
* Encapsulate all UI behaviors into jQuery Widgets
* Allow for module exports to make dependency management easier
* Use Gulp tasks to watch and compile JS code during development
* Include source maps to allow for browser debugging

## Instructions
* Install Node.js
  * Tested against v4.0.0
  * Consider using NVM to manage node versions `https://github.com/coreybutler/nvm-windows`
* Install Gulp LCI
    * `npm install gulp-cli -g`
* Ensure you have Task Runner Explorer installed.  For VS2015, this is built in.  Otherwise, install from: 

        https://visualstudiogallery.msdn.microsoft.com/8e1b4368-4afb-467a-bc13-9650572db708s
* git clone `url`

## Implementation Notes
* Use Dan Wahlin's guide for *Creating a TypeScript Workflow with Gulp*: `http://weblogs.asp.net/dwahlin/creating-a-typescript-workflow-with-gulp`
* Disable Visual Studio Typescript compilation  
  * Add `<TypeScriptCompileBlocked>true</TypeScriptCompileBlocked>` to the first `<PropertyGroup>` in project file


