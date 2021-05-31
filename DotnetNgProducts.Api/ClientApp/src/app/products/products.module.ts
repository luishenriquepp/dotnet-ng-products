import { NgModule } from '@angular/core'
import { CommonModule } from '@angular/common'
import { ReactiveFormsModule } from '@angular/forms'
import { ProductRoutingModule } from './product-routing-module'
import { ProductFormComponent } from './product-form/product-form.component'
import { ProductListingComponent } from './product-listing/product-listing.component'
import { SanitizeBase64Pipe } from '../pipes/decode-64.pipe'

@NgModule({
	declarations: [ProductFormComponent, ProductListingComponent, SanitizeBase64Pipe],
	imports: [CommonModule, ReactiveFormsModule, ProductRoutingModule],
})
export class ProductsModule {}
