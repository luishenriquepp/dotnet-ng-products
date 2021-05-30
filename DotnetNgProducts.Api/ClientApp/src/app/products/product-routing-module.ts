import { NgModule } from '@angular/core'
import { Routes, RouterModule } from '@angular/router'

import { ProductFormComponent } from './product-form/product-form.component'
import { ProductListingComponent } from './product-listing/product-listing.component'

const routes: Routes = [
	{
		path: '',
		component: ProductListingComponent,
	},
	{
		path: 'create',
		component: ProductFormComponent,
	},
	{
		path: 'edit/:id',
		component: ProductFormComponent,
	},
]

@NgModule({
	imports: [RouterModule.forChild(routes)],
	exports: [RouterModule],
})
export class ProductRoutingModule {}
