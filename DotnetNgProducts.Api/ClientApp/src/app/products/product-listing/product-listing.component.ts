import { ChangeDetectionStrategy, Component, OnDestroy, OnInit } from '@angular/core'
import { Observable } from 'rxjs'
import { Product } from '../models/product.model'
import { ProductService } from '../services/product.service'

@Component({
	selector: 'app-product-listing',
	templateUrl: './product-listing.component.html',
	styleUrls: ['./product-listing.component.css'],
	changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProductListingComponent implements OnInit {
	products$: Observable<Product[]>

	constructor(private productService: ProductService) {}

	ngOnInit() {
		this.products$ = this.productService.get()
	}
}
