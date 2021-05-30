import { Injectable } from '@angular/core'

@Injectable({
	providedIn: 'root',
})
export class LocalStorageService {
	private authKey = 'auth-token'

	public addAuth(value: string): void {
		localStorage.setItem(this.authKey, value)
	}

	public removeAuth(): void {
		localStorage.removeItem(this.authKey)
	}

	public isLogged(): boolean {
		return !!localStorage.getItem(this.authKey)
	}
}
