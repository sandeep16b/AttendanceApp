import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { CounterComponent } from './counter/counter.component';
import { EnrollmentFormComponent } from './enrollment-form/enrollment-form.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { HomeComponent } from './home/home.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';


import { ClassService } from './services/class.service';
import { ClassTypeService } from './services/class-type.service';
import { CourseService } from './services/course.service';
import { EnrollmentService } from './services/enrollment.service';
import { StudentService } from './services/student.service';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    EnrollmentFormComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    HttpModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'enrollments/new', component: EnrollmentFormComponent},
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
    ])
  ],
  providers: [
    EnrollmentService,
    StudentService,
    ClassService,
    CourseService,
    ClassTypeService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
