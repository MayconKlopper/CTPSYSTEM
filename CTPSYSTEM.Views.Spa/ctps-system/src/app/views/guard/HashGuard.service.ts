import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable } from 'rxjs';

import { HashService } from '../hashService.service';

@Injectable({
  providedIn: 'root'
})
export class HashGuardService implements CanActivate {
    constructor(private hashService: HashService,
      private router: Router) {}

    canActivate(
        next: ActivatedRouteSnapshot,
        state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {

        if (this.hashService.hashValido()) {
          return true;
        } else {
          this.router.navigate(['/inserir-chave']);
          return false;
        }
    }
}