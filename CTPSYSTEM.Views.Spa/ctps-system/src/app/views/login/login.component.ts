import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

import { LogIn, User, Roles } from '../Models';
import { AccountService } from '../account.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: 'login.component.html',
  providers: [ AccountService, FormBuilder ]
})
export class LoginComponent {
  public usuario: LogIn = new LogIn();


  logInForm = this.formBuilder.group({
    userName: ['userName', Validators.required],
    password: ['password', Validators.required]
  });

  public get userName() { return this.logInForm.get('userName'); }
  public get password() { return this.logInForm.get('password'); }

  constructor(private formBuilder: FormBuilder,
    private accountservice: AccountService,
    private router: Router,
    private toasterService: ToastrService) {}

  logIn() {
    this.accountservice.logIn(this.usuario).subscribe(
      (resultSuccess) => {
        const usuario = resultSuccess as User;
        localStorage.setItem('usuarioLogado', JSON.stringify(usuario));
        this.router.navigate(['./home']);
      },
      (resultError) => {
        this.toasterService.info('Sessão expirada. Faça logIn novamento', 'Informação');
      },
      () => {  }
    );
  }
}
