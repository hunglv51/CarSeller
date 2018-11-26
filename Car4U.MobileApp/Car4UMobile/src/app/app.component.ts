import { Component, ViewChild } from "@angular/core";
import { Platform, Nav, Menu } from "ionic-angular";
import { StatusBar } from "@ionic-native/status-bar";
import { SplashScreen } from "@ionic-native/splash-screen";

import { LoginPage } from "../pages/login/login";
import { CarsPage } from "../pages/cars/cars";
import { DashboardPage } from "../pages/dashboard/dashboard";
@Component({
  templateUrl: "app.html"
})
export class MyApp {
  rootPage: any = LoginPage;
  @ViewChild(Nav) nav: Nav;
  @ViewChild(Menu) menu: Menu;
  constructor(
    platform: Platform,
    statusBar: StatusBar,
    splashScreen: SplashScreen
  ) {
    platform.ready().then(() => {
      // Okay, so the platform is ready and our plugins are available.
      // Here you can do any higher level native things you might need.
      statusBar.styleDefault();
      splashScreen.hide();
    });
  }
  logout() {
    this.nav.setRoot(LoginPage);
    this.menu.toggle();
    // console.log("Logout");
  }
  goPage(pageName: string) {
    switch (pageName) {
      case "car":
        this.nav.push(CarsPage);
        break;
      case "post":
        this.nav.push(DashboardPage);
        break;
      // case "notification":
      //   this.nav.push(CarsPage);
      //   break;
      // case "user":
      //   this.nav.push(CarsPage);
      //   break;
      // case "favorite":
      //   this.nav.push(CarsPage);
      //   break;
    }
    this.menu.toggle();
    
  }
}
