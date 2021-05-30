import { NgModule } from '@angular/core'
import { Routes, RouterModule } from '@angular/router'
import { AuthGuard } from './guards/auth.guard'

const routes: Routes = [
	{
		path: 'login',
		loadChildren: () => import('./login/login.module').then((m) => m.LoginModule),
	},
	{
		path: 'products',
		loadChildren: () => import('./products/products.module').then((m) => m.ProductsModule),
		canActivate: [AuthGuard],
	},
	{
		path: '',
		redirectTo: '/login',
		pathMatch: 'full',
	},
]

@NgModule({ imports: [RouterModule.forRoot(routes)], exports: [RouterModule] })
export class AppRoutingModule {}
