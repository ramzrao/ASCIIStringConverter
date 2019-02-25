import { ModuleWithProviders, NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { SharedModule } from '../shared/shared.module';
import { PersonComponent } from './person.component';

@NgModule({
  imports: [
    SharedModule
  ],
  declarations: [
    PersonComponent
  ],

  providers: [
  ]
})
export class PersonModule {}
