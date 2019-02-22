import { Injectable } from '@angular/core';

import { ContratoTrabalho } from '../Models';
import { AppModule } from '../../app.module';

@Injectable()
export class UsuarioService {
    public getContratoTrabalho() : ContratoTrabalho {
        return JSON.parse(localStorage.getItem('selectedContratoTrabalho'));
    }
}