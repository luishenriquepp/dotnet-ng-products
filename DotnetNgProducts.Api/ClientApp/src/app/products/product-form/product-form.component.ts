import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core'
import { FormControl, FormGroup, Validators } from '@angular/forms'
import { Router } from '@angular/router'

@Component({
	selector: 'app-product-form',
	templateUrl: './product-form.component.html',
	styleUrls: ['./product-form.component.css'],
	changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ProductFormComponent implements OnInit {
	form: FormGroup

	constructor(private router: Router) {}

	ngOnInit() {
		this.form = new FormGroup({
			name: new FormControl('', [Validators.required, Validators.minLength(4)]),
			price: new FormControl(1, [Validators.required, Validators.min(0.1)]),
		})
	}

	onSubmit(): void {
		this.router.navigate(['products'])
	}

	get name() {
		return this.form.get('name')
	}

	get price() {
		return this.form.get('price')
	}
}
