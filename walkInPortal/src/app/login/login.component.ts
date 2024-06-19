import { Component } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {
  loginInfo = new FormGroup({
    email: new FormControl("", [Validators.required, Validators.email]),
  })
  get Email(): FormControl {
    return this.loginInfo.get('email') as FormControl;
  }
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private authService: AuthService
  ) {}
  loginbutton(){
    if (this.loginInfo.valid) {
      this.router.navigate(['/walkin']);
    }
  }

}
