import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class UtilsService {
    private API = 'http://localhost:5001/api/Utils/';

    constructor(private http: HttpClient) {
    }

    public recuperaEstados() {
        return this.http.get(this.API + 'RecuperaEstados');
    }

    public transformaEnumParaVetor(enumEx: any): { id: number, value: string }[] {
        const length = Object.keys(enumEx).length / 2;
        const enumArray: { id: number, value: string }[] = [];
        for (let i = 1; i <= length; i++) {
            enumArray.push({ id: i, value: enumEx[i] });
        }

        return enumArray;
    }
}

