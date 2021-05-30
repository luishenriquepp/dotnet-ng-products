import { Injectable } from '@angular/core'
import { BehaviorSubject, Observable } from 'rxjs'

@Injectable({
	providedIn: 'root',
})
export class LocalStorageService {
	private authKey = 'auth-token'
	private onLogin = new BehaviorSubject<boolean>(undefined)

	public addAuth(value: string): void {
		localStorage.setItem(this.authKey, value)
		this.onLogin.next(true)
	}

	public removeAuth(): void {
		localStorage.removeItem(this.authKey)
		this.onLogin.next(false)
	}

	public isLogged(): boolean {
		return !!localStorage.getItem(this.authKey)
	}

	public getLoginStatus(): Observable<boolean> {
		return this.onLogin.asObservable()
	}
}
