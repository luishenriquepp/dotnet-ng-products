import { NgModule } from '@angular/core'
import { Routes, RouterModule } from '@angular/router'
import { AuthGuard } from '../guards/auth.guard'

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
		canActivate: [AuthGuard],
	},
	{
		path: 'edit/:id',
		component: ProductFormComponent,
		canActivate: [AuthGuard],
	},
]

@NgModule({
	imports: [RouterModule.forChild(routes)],
	exports: [RouterModule],
})
export class ProductRoutingModule {}
