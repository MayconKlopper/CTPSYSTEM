import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { defineLocale } from 'ngx-bootstrap/chronos';
import { NgxUiLoaderService } from 'ngx-ui-loader';
import { ptBrLocale } from 'ngx-bootstrap/locale';
defineLocale('pt-br', ptBrLocale);

import { Register, MessageModel, CriarFuncionario, Estado } from '../Models';
import { AccountService } from '../account.service';
import { PasswordValidation } from '../../Helpers/PasswordValidator';
import { UtilsService } from '../../Helpers/utils.service';
import { UsuarioService } from '../usuario/usuario.service';

@Component({
    selector: 'app-registrar-cidadao',
    templateUrl: './registrar-cidadao.component.html'
})
export class RegistrarCidadaoComponent implements OnInit {
    public novoUsuario: Register = new Register();
    public novoFuncionario: CriarFuncionario = new CriarFuncionario();
    public estados: Array<Estado>;

    public cadastroUsuarioFormGroup = this.formBuilder.group({
        name: ['name', Validators.required],
        data: ['data', Validators.required],
        estado: ['estado', Validators.required],
        cidade: ['cidade', Validators.required],
        userName: ['userName',
            [
                Validators.required,
                Validators.minLength(11)
            ]
        ],
        password: ['password',
            [
                Validators.required,
                Validators.minLength(8)
            ]
        ],
        email: ['email',
            [
                Validators.required,
                Validators.email
            ]
        ],
        celular: ['celular',
            [
                Validators.required,
                Validators.minLength(11)
            ]
        ],
        confirmPassword: ['confirmPassword', Validators.required]
    },
        { validator: PasswordValidation.matchPassword });

    public get name() { return this.cadastroUsuarioFormGroup.get('name'); }
    public get data() { return this.cadastroUsuarioFormGroup.get('data'); }
    public get estado() { return this.cadastroUsuarioFormGroup.get('estado'); }
    public get cidade() { return this.cadastroUsuarioFormGroup.get('cidade'); }
    public get userName() { return this.cadastroUsuarioFormGroup.get('userName'); }
    public get password() { return this.cadastroUsuarioFormGroup.get('password'); }
    public get email() { return this.cadastroUsuarioFormGroup.get('email'); }
    public get celular() { return this.cadastroUsuarioFormGroup.get('celular'); }
    public get confirmPassword() { return this.cadastroUsuarioFormGroup.get('confirmPassword'); }

    constructor(private accountService: AccountService,
        private ngxUiLoaderService: NgxUiLoaderService,
        private formBuilder: FormBuilder,
        private toasterService: ToastrService,
        private utilsService: UtilsService,
        private usuarioService: UsuarioService,
        private localeService: BsLocaleService,
        private router: Router) { }

    ngOnInit(): void {
        this.localeService.use('pt-br');
        this.novoFuncionario.data = new Date();
        this.utilsService.recuperaEstados().subscribe(
            (sucesso) => {
                this.estados = sucesso as Array<Estado>;
                this.novoFuncionario.idEstado = this.estados[0].id;
            }
        );
    }

    selectEstado(idEstado: number) {
        this.novoFuncionario.idEstado = idEstado;
    }

    cadastrarUsuario() {
        this.ngxUiLoaderService.start();
        this.novoUsuario.role = 'usuario';
        this.novoFuncionario.cpf = this.novoUsuario.userName;
        this.accountService.cadastrarUsuario(this.novoUsuario).subscribe(
            (sucessoUsuario) => {
                this.usuarioService.cadastrarFuncionario(this.novoFuncionario).subscribe(
                    (sucessoFuncionario) => {
                        const mensagemSucessoFuncionario = sucessoFuncionario as MessageModel;
                        this.toasterService.success(mensagemSucessoFuncionario.texto, 'Sucesso');
                        this.router.navigate(['./login']);
                    },
                    (erroFuncionario) => {
                        const mensagemErroFuncionario = erroFuncionario.error as MessageModel;
                        this.toasterService.error(mensagemErroFuncionario.texto, 'Erro');
                        this.ngxUiLoaderService.stop();
                    }
                );
            },
            (erroUsuario) => {
                const mensagemErroUsuario = erroUsuario.error as MessageModel;
                this.toasterService.error(mensagemErroUsuario.texto, 'Erro');
                this.ngxUiLoaderService.stop();
            },
            () => { this.ngxUiLoaderService.stop(); }
        );
    }
}
