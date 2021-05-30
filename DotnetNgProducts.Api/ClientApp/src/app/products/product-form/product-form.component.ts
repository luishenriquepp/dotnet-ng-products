import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core'
import { FormControl, FormGroup, Validators } from '@angular/forms'
import { Router } from '@angular/router'
import { Product } from '../models/product.model'
import { ProductService } from '../services/product.service'

@Component({
	selector: 'app-product-form',
	templateUrl: './product-form.component.html',
	styleUrls: ['./product-form.component.css'],
	changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProductFormComponent implements OnInit {
	form: FormGroup

	constructor(private router: Router, private productService: ProductService) {}

	ngOnInit() {
		this.form = new FormGroup({
			name: new FormControl('', [Validators.required, Validators.minLength(4)]),
			price: new FormControl(1, [Validators.required, Validators.min(0.1)]),
		})
	}

	onSubmit(): void {
		if (this.form.invalid) return

		const product = {
			name: this.name.value,
			price: this.price.value,
		} as Product

		this.productService.add(product).subscribe((res) => {
			this.router.navigate(['products'])
		})
	}

	get name() {
		return this.form.get('name')
	}

	get price() {
		return this.form.get('price')
	}
}
