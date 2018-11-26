import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { DashboardPage } from '../dashboard/dashboard';
import { RegisterPage } from '../register/register';

@Component({
  selector: 'page-login',
  templateUrl: 'login.html'
})
export class LoginPage {

  constructor(public navCtrl: NavController) {

  }

  ionViewDidLoad()
  {
    // let inputMasks = document.getElementsByClassName("inputMask");
    // for(let index in inputMasks)
    // {
    //   inputMasks[index].addEventListener('click', () => inputMasks[index].setSelectionRange(0, 4));
    // }
  }
  login(){
    this.navCtrl.setRoot(DashboardPage);
  }
  register(){
    this.navCtrl.push(RegisterPage);
  }
  
  handleClick(event)
  {
    console.log(event);
    let maskInput = event.target;
    // console.log(maskInput.value);
    
    // let previosFocus = event.relatedTarget;
    // if(maskInput != previosFocus)
    maskInput.setSelectionRange(0, maskInput.value.length);
  }
}
