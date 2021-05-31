import { ChangeDetectionStrategy, ChangeDetectorRef, Component, OnInit } from '@angular/core'
import { FormControl, FormGroup, Validators } from '@angular/forms'
import { ActivatedRoute, Router } from '@angular/router'
import { Product } from '../models/product.model'
import { ProductService } from '../services/product.service'

@Component({
	selector: 'app-product-form',
	templateUrl: './product-form.component.html',
	styleUrls: ['./product-form.component.css'],
	changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProductFormComponent implements OnInit {
	private currentId: number
	form: FormGroup
	pictureBase64: string

	constructor(
		private router: Router,
		private productService: ProductService,
		private route: ActivatedRoute,
		private changeDetector: ChangeDetectorRef
	) {}

	ngOnInit() {
		this.form = this.buildForm('', 1)

		const productId = this.route.snapshot.paramMap.get('id')
		if (productId) {
			this.currentId = parseInt(productId)
			this.productService.getById(this.currentId).subscribe((p) => {
				this.pictureBase64 = p.base64Picture
				this.form = this.buildForm(p.name, p.price)
				this.changeDetector.detectChanges()
			})
		}
	}

	onSubmit(): void {
		if (this.isFormInvalid) return

		const product = {
			id: this.currentId,
			name: this.name.value,
			price: this.price.value,
			base64Picture: this.pictureBase64,
		} as Product

		if (this.isUpdate) {
		} else {
			this.productService.add(product).subscribe((res) => {
				this.router.navigate(['products'])
			})
		}
	}

	buildForm(name: string, price: number): FormGroup {
		return new FormGroup({
			name: new FormControl(name, [Validators.required, Validators.minLength(4)]),
			price: new FormControl(price, [Validators.required, Validators.min(0.1)]),
		})
	}

	selectFile(event) {
		var files = event.target.files
		var file = files[0] as File

		if (files && file) {
			var reader = new FileReader()
			reader.onload = this.handleFile.bind(this)
			reader.readAsBinaryString(file)
		}
	}

	handleFile(event) {
		var binaryString = event.target.result
		this.pictureBase64 = btoa(binaryString)
		this.changeDetector.detectChanges()
	}

	get name() {
		return this.form.get('name')
	}

	get price() {
		return this.form.get('price')
	}

	get isUpdate(): boolean {
		return this.currentId > 0
	}

	get addPictureText(): string {
		return this.pictureBase64 ? 'update' : 'add'
	}

	get isFormInvalid(): boolean {
		return this.form.invalid || !this.pictureBase64
	}
}
