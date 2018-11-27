import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';
import { MyApp } from './app.component';
import { LoginPage } from '../pages/login/login';
import { DashboardPage } from '../pages/dashboard/dashboard';
import { RegisterPage } from '../pages/register/register';
import { CarsPage } from '../pages/cars/cars';
import { PostProvider } from '../providers/post/post-provider';
import { HttpClientModule } from '@angular/common/http';
import { CarPricePipe } from '../pipes/car-price/car-price';
import {DxTextBoxModule} from 'devextreme-angular';
import { ListPostPage } from '../pages/list-post/list-post';
@NgModule({
  declarations: [
    MyApp,
    LoginPage,
    DashboardPage,
    RegisterPage,
    CarsPage,
    CarPricePipe,
    ListPostPage
  ],
  imports: [
    BrowserModule,
    IonicModule.forRoot(MyApp),
    HttpClientModule,
    DxTextBoxModule
    
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    LoginPage,
    DashboardPage,
    RegisterPage,
    CarsPage,
    ListPostPage
  ],
  providers: [
    StatusBar,
    SplashScreen,
    {provide: ErrorHandler, useClass: IonicErrorHandler},
    PostProvider
  ]
})
export class AppModule {}
