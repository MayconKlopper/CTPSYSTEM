import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Router } from '@angular/router';

import { AccountService } from '../views/account.service';
import { ToastrService } from 'ngx-toastr';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {
    constructor(private accountService: AccountService,
        private router: Router,
        private toasterService: ToastrService) { }

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        return next.handle(request).pipe(catchError(erro => {
            if (erro.status === 401) {
                this.accountService.logOut();
                this.toasterService.warning('Sua sessão expirou, por favor, efetue o LogIN novamente', 'Atenão');
                localStorage.removeItem('usuarioLogado');
                this.router.navigate(['/login']);
            }

            return throwError(erro);
        }));
    }
}
