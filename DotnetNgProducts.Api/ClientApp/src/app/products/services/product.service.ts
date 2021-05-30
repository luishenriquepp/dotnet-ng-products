import { HttpClient } from '@angular/common/http'
import { Injectable } from '@angular/core'
import { Observable, of } from 'rxjs'
import { Product } from '../models/product.model'

@Injectable({
	providedIn: 'root',
})
export class ProductService {
	private url = 'https://localhost:44305/api/product'

	constructor(private http: HttpClient) {}

	public get(): Observable<Product[]> {
		return this.http.get<Product[]>(this.url)
	}
}
