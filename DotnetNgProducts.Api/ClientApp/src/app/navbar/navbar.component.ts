import { ChangeDetectionStrategy, Component } from '@angular/core'
import { LocalStorageService } from '../services/local-storage.service'

@Component({
	selector: 'app-navbar',
	templateUrl: './navbar.component.html',
	styleUrls: ['./navbar.component.css'],
	changeDetection: ChangeDetectionStrategy.OnPush,
})
export class NavbarComponent {
	constructor(private localStorageService: LocalStorageService) {}

	get isLogged(): boolean {
		return this.localStorageService.isLogged()
	}
}
