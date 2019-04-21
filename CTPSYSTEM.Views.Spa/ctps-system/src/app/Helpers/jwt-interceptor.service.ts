import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class JwtInterceptor implements HttpInterceptor {
    constructor() { }

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        // add authorization header with jwt token if available
        let usuarioLogado = JSON.parse(localStorage.getItem('usuarioLogado'));
        if (usuarioLogado && usuarioLogado.token) {
            request = request.clone({
                setHeaders: {
                    Authorization: `Bearer ${usuarioLogado.token}`
                }
            });
        }

        return next.handle(request);
    }
}
