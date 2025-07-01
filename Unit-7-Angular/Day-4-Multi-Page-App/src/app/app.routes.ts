import { Routes }        from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { StateSealsComponent } from './components/state-seals/state-seals.component';
import { StudentListComponent } from './components/student-list/student-list.component';


// The Routes object is an array of objects to associate a URL path to a component
export const routes: Routes = [
    {path: '', redirectTo: '/home', pathMatch: 'full' },
    {path: 'home', component: HomeComponent},
    {path: 'seals', component: StateSealsComponent},
    {path: 'student-list', component: StudentListComponent}
];
