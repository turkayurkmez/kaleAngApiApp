import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private userService: UserService, private router:Router) { }

  userName:string;
  passWord:string;

  userLogin(){
    this.userService.validateUser(this.userName,this.passWord);
    if (this.userService.isLoggedIn && this.userService.returnUrl != undefined) {
      console.log(this.userService.returnUrl);
      this.router.navigateByUrl(this.userService.returnUrl);
    }

  }

  ngOnInit(): void {
  }

}
