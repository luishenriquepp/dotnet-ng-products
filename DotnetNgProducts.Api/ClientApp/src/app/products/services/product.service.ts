import { HttpClient } from '@angular/common/http'
import { Injectable } from '@angular/core'
import { Observable } from 'rxjs'
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

	public add(entity: Product): Observable<Product[]> {
		return this.http.post<Product[]>(this.url, entity)
	}

	public getById(id: number): Observable<Product> {
		return this.http.get<Product>(`${this.url}/${id}`)
	}

	public delete(id: number): Observable<void> {
		return this.http.delete<void>(`${this.url}/${id}`)
	}
}
