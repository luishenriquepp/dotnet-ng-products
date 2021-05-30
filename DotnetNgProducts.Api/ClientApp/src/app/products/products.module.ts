import { NgModule } from '@angular/core'
import { CommonModule } from '@angular/common'
import { ReactiveFormsModule } from '@angular/forms'

import { ProductFormComponent } from './product-form/product-form.component'

@NgModule({
	declarations: [ProductFormComponent],
	imports: [CommonModule, ReactiveFormsModule],
	exports: [ProductFormComponent],
})
export class ProductsModule {}
