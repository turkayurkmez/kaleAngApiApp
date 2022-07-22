import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private httpClient: HttpClient) { }

  isLoggedIn: boolean= false;
  returnUrl:string;
  url:string ='https://localhost:7276/api/Users';

  validateUser(userName: string, password:string):void{
    var user = {userName: userName, passWord: password};
    this.httpClient.post(this.url,user).subscribe((data:any)=>{
      console.log(data.token);
      localStorage.setItem('token',data.token);
      this.isLoggedIn = true;
    });
    // if (userName == 'turkay' && password == '123456') {
    //   this.isLoggedIn = true;
    
    // }
  
  }


}
