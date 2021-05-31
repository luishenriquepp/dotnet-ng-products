import { Pipe, PipeTransform } from '@angular/core'
import { DomSanitizer } from '@angular/platform-browser'

@Pipe({
	name: 'sanitizeBase64',
})
export class SanitizeBase64Pipe implements PipeTransform {
	constructor(private _sanitizer: DomSanitizer) {}

	transform(value: any, args?: any): any {
		let a = ''
		if (value) {
			a = atob(value)
		}
		return this._sanitizer.bypassSecurityTrustResourceUrl('data:image/jpg;base64,' + value)
	}
}
