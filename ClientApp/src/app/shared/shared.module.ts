import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ApiService } from './api.service';
import { PersonService } from './Person.service';
import { HttpTokenInterceptor } from './http.interceptor';


@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule
  ],
  declarations: [
    
  ],
  exports:[
    CommonModule,
    FormsModule,
  ],
  providers:[
    { provide: HTTP_INTERCEPTORS, useClass: HttpTokenInterceptor, multi: true },
    ApiService,
    PersonService,
  ]
  
})
export class SharedModule {}
