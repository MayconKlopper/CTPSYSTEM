import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AccountService } from '../account.service';

@Injectable({
  providedIn: 'root'
})
export class GuardService implements CanActivate {
    constructor(private accountService: AccountService,
      private router: Router) {}
    canActivate(
        next: ActivatedRouteSnapshot,
        state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {

        if (this.accountService.logado()) {
          return true;
        } else {
          this.router.navigate(['/login']);
          return false;
        }
    }
}