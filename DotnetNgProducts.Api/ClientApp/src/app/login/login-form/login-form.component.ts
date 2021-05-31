import { ChangeDetectionStrategy, ChangeDetectorRef, Component, OnInit } from '@angular/core'
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { Router } from '@angular/router'
import { LocalStorageService } from 'src/app/services/local-storage.service'
import { LoginService } from '../services/login.service'

@Component({
	selector: 'app-login-form',
	templateUrl: './login-form.component.html',
	styleUrls: ['./login-form.component.css'],
	changeDetection: ChangeDetectionStrategy.OnPush,
})
export class LoginFormComponent implements OnInit {
	form: FormGroup
	loginErrorMessage: string

	constructor(
		private loginService: LoginService,
		private router: Router,
		private localStorageService: LocalStorageService,
		private changeDetector: ChangeDetectorRef
	) {}

	ngOnInit(): void {
		this.form = new FormGroup({
			username: new FormControl('11234567890', [Validators.required, Validators.minLength(6)]),
			password: new FormControl('09876543211', [Validators.required, Validators.minLength(6)]),
		})
	}

	onSubmit(): void {
		this.loginErrorMessage = null

		this.loginService.login(this.username.value, this.password.value).subscribe((res) => {
			if (res.success) {
				this.localStorageService.addAuth('1234')
				this.router.navigate(['/products'])
			} else {
				this.loginErrorMessage = res.error
				this.changeDetector.detectChanges()
			}
		})
	}

	get username() {
		return this.form.get('username')
	}

	get password() {
		return this.form.get('password')
	}
}
