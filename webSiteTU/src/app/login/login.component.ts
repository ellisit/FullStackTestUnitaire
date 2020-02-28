import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroupDirective, FormGroup, NgForm, Validators, AbstractControl } from '@angular/forms';
import { AuthService } from '../services/auth.service';
import { Router } from '@angular/router';
import { first } from 'rxjs/operators';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { WarningDialogComponent } from '../warning-dialog/warning-dialog.component';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm = new FormGroup({
    email: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [Validators.required]),
  });

  public users;
  constructor(private router: Router, public dialog: MatDialog,private authService: AuthService) { }

  ngOnInit() {
  }
  get email(): AbstractControl {
    return this.loginForm.get('email');
  }
  get password(): AbstractControl {
    return this.loginForm.get('password');
  }
  getEmailErrorMessage() {
    return this.loginForm.get('email').hasError('required') ? 'You must enter a value' :
      this.loginForm.get('password').hasError('email') ? 'Not a valid email' :
        '';
  }

  getPasswordErrorMessage() {
    return this.loginForm.get('password').hasError('required') ? 'Password is required' : '';
  }

  errorLogin() {
    const dialogConfig: MatDialogConfig = new MatDialogConfig();
    dialogConfig.disableClose = true;
    dialogConfig.data = {
      title: 'Avertissement',
      text: 'L\'email et le mot de passe ne correspondent pas.'
    }
    const dialogRef = this.dialog.open(WarningDialogComponent, dialogConfig);
  }

  public handleSubmit() {
    if(this.loginForm.valid) {
      this.authService.login(this.email.value, this.password.value).pipe(first())
      .subscribe(authorize => {
        if(authorize !== null) {
          this.router.navigate(['/librairie'])
        } else {
          this.errorLogin();
        }

      }, error => {
        console.log('erreur');
      });
    }
  }
}
