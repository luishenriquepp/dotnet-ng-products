import { Injectable } from '@angular/core'
import { Observable, of } from 'rxjs'
import { Product } from '../models/product.model'

@Injectable({
	providedIn: 'root',
})
export class ProductService {
	public get(): Observable<Array<Product>> {
		return of([
			{ Id: 1, Name: 'Product 1', Price: Math.random() * 10 } as Product,
			{ Id: 2, Name: 'Product 2', Price: Math.random() * 10 } as Product,
			{ Id: 3, Name: 'Product 3', Price: Math.random() * 10 } as Product,
			{ Id: 4, Name: 'Product 4', Price: Math.random() * 10 } as Product,
			{ Id: 5, Name: 'Product 5', Price: Math.random() * 10 } as Product,
		])
	}
}
