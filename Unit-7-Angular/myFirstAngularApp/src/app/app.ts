// This contains the Typescript code for the component
// It defines several things Angular needs to know about the component

import { Component } from '@angular/core';      // Give me access to basic Angular features
import { RouterOutlet } from '@angular/router'; // Give me access to the Angular router

// @Component idetifies the attributes/characterisitics of the component
@Component({
  // selector is the tag-name used in the html reference the component
  selector: 'app-root',           // Where to insert the HTML generated by Angular for component
  imports: [RouterOutlet],
  templateUrl: './app.html',      // Name of the html for the component (content of the component)
  styleUrl: './app.css'           // Name of the css file for the component (styling of the component)
})

// export allows other processes outside this TypeScript file (like Angular) 
//        to access stuff in the TypesScript
export class App { // The class name is used in import statements to reference the data/methods in this export
  protected title = 'myFirstAngularApp';
}
