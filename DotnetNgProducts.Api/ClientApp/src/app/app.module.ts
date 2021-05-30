import { BrowserModule } from '@angular/platform-browser'
import { NgModule } from '@angular/core'
import { FormsModule } from '@angular/forms'
import { HttpClientModule } from '@angular/common/http'

import { AppComponent } from './app.component'
import { LoginModule } from './login/login.module'
import { ProductsModule } from './products/products.module'

@NgModule({
	declarations: [AppComponent],
	imports: [
		BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
		HttpClientModule,
		FormsModule,
		LoginModule,
		ProductsModule,
	],
	providers: [],
	bootstrap: [AppComponent],
})
export class AppModule {}
