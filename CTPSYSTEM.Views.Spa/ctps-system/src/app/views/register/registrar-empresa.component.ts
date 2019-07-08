import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgxUiLoaderService } from 'ngx-ui-loader';

import { Register, MessageModel, CriarEmpresa, EmpresaDetalhes, Estado } from '../Models';
import { AccountService } from '../account.service';
import { PasswordValidation } from '../../Helpers/PasswordValidator';
import { EmpresaService } from '../empresa/empresa.service';
import { UtilsService } from '../../Helpers/utils.service';

@Component({
  selector: 'app-registrar-empresa',
  templateUrl: 'registrar-empresa.component.html'
})
export class RegistrarEmpresarComponent implements OnInit {
  public novoUsuario: Register = new Register();
  public novaEmpresa: CriarEmpresa = new CriarEmpresa();
  public estados: Array<Estado>;

  public cadastroUsuarioFormGroup = this.formBuilder.group({
    nomeFantasia: ['nomeFantasia', Validators.required],
    razaoSocial: ['razaoSocial', Validators.required],
    estado: ['estado', Validators.required],
    cidade: ['cidade', Validators.required],
    rua: ['rua', Validators.required],
    numero: ['numero', Validators.required],
    sala: ['sala', Validators.required],
    seguimento: ['seguimento', Validators.required],
    userName: ['userName',
      [
        Validators.required,
        Validators.minLength(14)
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

  public get nomeFantasia() { return this.cadastroUsuarioFormGroup.get('nomeFantasia'); }
  public get razaoSocial() { return this.cadastroUsuarioFormGroup.get('razaoSocial'); }
  public get estado() { return this.cadastroUsuarioFormGroup.get('estado'); }
  public get cidade() { return this.cadastroUsuarioFormGroup.get('cidade'); }
  public get seguimento() { return this.cadastroUsuarioFormGroup.get('seguimento'); }
  public get rua() { return this.cadastroUsuarioFormGroup.get('rua'); }
  public get numero() { return this.cadastroUsuarioFormGroup.get('numero'); }
  public get sala() { return this.cadastroUsuarioFormGroup.get('sala'); }
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
    private empresaService: EmpresaService,
    private router: Router) { }

  ngOnInit(): void {
    this.utilsService.recuperaEstados().subscribe(
      (sucesso) => {
        this.estados = sucesso as Array<Estado>;
        this.novaEmpresa.idEstado = this.estados[0].id;
      }
    );
  }

  selectEstado(idEstado: number) {
    this.novaEmpresa.idEstado = idEstado;
  }

  cadastrarEmpresa() {
    this.ngxUiLoaderService.start();
    this.novoUsuario.role = 'empresa';
    this.novaEmpresa.CNPJ = this.novoUsuario.userName;
    this.accountService.cadastrarUsuario(this.novoUsuario).subscribe(
      (sucessoUsuario) => {
        this.empresaService.cadastrarEmpresa(this.novaEmpresa).subscribe(
          (sucessoEmpresa) => {
            const mensagemSucesso = sucessoUsuario as MessageModel;
            this.toasterService.success(mensagemSucesso.texto, 'Sucesso');
            this.router.navigate(['./login']);
          },
          (erroEmpresa) => {
            const mensagemErroEmpresa = erroEmpresa.error as MessageModel;
            this.toasterService.error(mensagemErroEmpresa.texto, 'Erro');
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
