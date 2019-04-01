import { Component, OnDestroy, Inject } from '@angular/core';
import { DOCUMENT } from '@angular/common';
import { Router } from '@angular/router';

import { navUsuario, navFuncionario, navEmpresa } from './../../navs';
import { User } from '../../views/Models';
import { AccountService } from '../../views/account.service';
import { ToastrService } from 'ngx-toastr';



@Component({
  selector: 'app-dashboard',
  templateUrl: './default-layout.component.html'
})
export class DefaultLayoutComponent implements OnDestroy {
  public navItems = navUsuario;
  public sidebarMinimized = true;
  private changes: MutationObserver;
  public element: HTMLElement;
  public usuario: User;

  constructor(private accountService: AccountService,
    private router: Router,
    private toasterservice: ToastrService,
    @Inject(DOCUMENT) _document?: any) {

    this.usuario = this.accountService.recuperausuarioLogado();

    switch (this.usuario.role[0]) {
      case 'usuario': {
         this.navItems = navUsuario;
         break;
      }
      case 'empresa': {
        this.navItems = navEmpresa;
         break;
      }
      case 'funcionario': {
        this.navItems = navFuncionario;
         break;
      }
   }

    this.changes = new MutationObserver((mutations) => {
      this.sidebarMinimized = _document.body.classList.contains('sidebar-minimized');
    });
    this.element = _document.body;
    this.changes.observe(<Element>this.element, {
      attributes: true,
      attributeFilter: ['class']
    });
  }

  ngOnDestroy(): void {
    this.changes.disconnect();
  }

  logOut() {
    this.accountService.logOut().subscribe(
      (resultSuccess) => {
        this.toasterservice.success('Você foi deslogado do sistema.', 'Sucesso');
      },
      (resultError) => {},
      () => {
        localStorage.removeItem('usuarioLogado');
        this.router.navigate(['./login']);
      }
    );
  }
}
