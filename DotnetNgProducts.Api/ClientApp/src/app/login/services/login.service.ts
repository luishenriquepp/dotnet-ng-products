import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Injectable } from '@angular/core'
import { Observable, of } from 'rxjs'
import { LoginResponse } from '../models/login-response.model'

@Injectable({
	providedIn: 'root',
})
export class LoginService {
	private url = 'https://dev.sitemercado.com.br/api/login'

	constructor(private http: HttpClient) {}

	login(username: string, password: string): Observable<LoginResponse> {
		const authorizationData = 'Basic ' + btoa(`${username}` + ':' + `${password}`)

		const headerOptions = {
			headers: new HttpHeaders({
				'Content-Type': 'application/json',
				Authorization: authorizationData,
			}),
		}

		return this.http.post<LoginResponse>(this.url, {}, headerOptions)
	}
}
