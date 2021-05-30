import { NgModule } from '@angular/core'
import { CommonModule } from '@angular/common'
import { ReactiveFormsModule } from '@angular/forms'
import { LoginRoutingModule } from './login-routing-module'
import { LoginFormComponent } from './login-form/login-form.component'

@NgModule({
	declarations: [LoginFormComponent],
	imports: [CommonModule, ReactiveFormsModule, LoginRoutingModule],
})
export class LoginModule {}
