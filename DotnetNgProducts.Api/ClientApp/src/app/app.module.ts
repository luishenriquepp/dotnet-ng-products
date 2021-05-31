import { BrowserModule } from '@angular/platform-browser'
import { NgModule } from '@angular/core'
import { FormsModule } from '@angular/forms'
import { HttpClientModule } from '@angular/common/http'
import { AppRoutingModule } from './app-routing-module'

import { AppComponent } from './app.component'
import { NavbarComponent } from './navbar/navbar.component'
import { LoginModule } from './login/login.module'
import { ProductsModule } from './products/products.module'
import { AuthGuard } from './guards/auth.guard'
import { NgxUiLoaderModule } from 'ngx-ui-loader'

@NgModule({
	declarations: [AppComponent, NavbarComponent],
	imports: [
		BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
		AppRoutingModule,
		HttpClientModule,
		FormsModule,
		LoginModule,
		ProductsModule,
		NgxUiLoaderModule,
	],
	providers: [AuthGuard],
	bootstrap: [AppComponent],
})
export class AppModule {}
