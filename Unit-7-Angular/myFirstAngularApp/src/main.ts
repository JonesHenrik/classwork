// This starts the angular application
// when you do ng serve it looks for main.ts to start the app
// This is where you define the component representing the home page

import { bootstrapApplication } from '@angular/platform-browser'; // Starts the Angular app
import { appConfig } from './app/app.config'; // Angular app configuration information

// Specify the folder containing the home page and its name

// import name -used-in-this-code from 'path-to-the-component-files'
// The component path contains the folder and high-level name of the component
// The component path is relative to the source folder
// ./app/app
//
// . says the folder you are in (src folder)
// /app says the folder named app in the folder your in
// second /app says allfiles related to the component will start with app

// The name of the import must match an export class in a TypeScript file
import { App } from './app/app'; // Get the Angular component stuff from './app/app'
// saying app.component does the same thing, above .component is assumed
// Frank says that is a clearer coding techinique. Clearly showing its a folder and not a singular file


// bootstrapApplication function is what the Angular server calls to start the app
// Give it: (name-of-import-for-component, configuration)
bootstrapApplication(App, appConfig)
  .catch((err) => console.error(err));
