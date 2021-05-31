import { ChangeDetectionStrategy, ChangeDetectorRef, Component, OnDestroy, OnInit } from '@angular/core'
import { ActivatedRoute, Router } from '@angular/router'
import { NgxUiLoaderService } from 'ngx-ui-loader'
import { Product } from '../models/product.model'
import { ProductService } from '../services/product.service'

@Component({
	selector: 'app-product-listing',
	templateUrl: './product-listing.component.html',
	styleUrls: ['./product-listing.component.css'],
	changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProductListingComponent implements OnInit {
	products: Product[]

	constructor(
		private productService: ProductService,
		private router: Router,
		private route: ActivatedRoute,
		private ngxLoader: NgxUiLoaderService,
		private changeDetector: ChangeDetectorRef
	) {}

	ngOnInit() {
		this.ngxLoader.start()
		this.productService.get().subscribe((products) => {
			this.products = products
			this.ngxLoader.stop()
			this.changeDetector.detectChanges()
		})
	}

	goToCreateProduct() {
		this.router.navigate(['create'], { relativeTo: this.route })
	}

	remove(id: number) {
		this.ngxLoader.start()
		this.productService.delete(id).subscribe(() => {
			this.ngxLoader.stop()
		})
		this.ngOnInit()
	}
}
