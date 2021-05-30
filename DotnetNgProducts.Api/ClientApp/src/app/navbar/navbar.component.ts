import { ChangeDetectionStrategy, ChangeDetectorRef, Component, OnInit } from '@angular/core'
import { LocalStorageService } from '../services/local-storage.service'

@Component({
	selector: 'app-navbar',
	templateUrl: './navbar.component.html',
	styleUrls: ['./navbar.component.css'],
	changeDetection: ChangeDetectionStrategy.OnPush,
})
export class NavbarComponent implements OnInit {
	constructor(private localStorageService: LocalStorageService, private changeDetector: ChangeDetectorRef) {}

	ngOnInit(): void {
		this.localStorageService.getLoginStatus().subscribe((login) => {
			this.changeDetector.detectChanges()
		})
	}

	get isLogged(): boolean {
		return this.localStorageService.isLogged()
	}
}
