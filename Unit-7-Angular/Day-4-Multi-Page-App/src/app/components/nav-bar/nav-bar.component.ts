import { Component } from '@angular/core';
import { HomeComponent } from '../home/home.component';
import { StateSealsComponent } from '../state-seals/state-seals.component';

@Component({
  selector: 'nav-bar', // is used in the html to include this component
  standalone: true,
  imports: [],
  templateUrl: './nav-bar.component.html', // is the file with the html for the component
  styleUrl: './nav-bar.component.css' // file with the css for the component
})
export class NavBarComponent {
  
}
