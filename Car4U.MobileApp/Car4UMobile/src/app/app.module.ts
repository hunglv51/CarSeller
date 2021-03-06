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
import { ListPostPage } from '../pages/list-post/list-post';
import { CreatePostPage } from '../pages/create-post/create-post';
import { FormsModule } from '@angular/forms';
import {Camera} from "@ionic-native/camera";
import { PostCategoryProvider } from '../providers/post-category/post-category-provider';
@NgModule({
  declarations: [
    MyApp,
    LoginPage,
    DashboardPage,
    RegisterPage,
    CarsPage,
    CarPricePipe,
    ListPostPage,
    CreatePostPage
  ],
  imports: [
    BrowserModule,
    IonicModule.forRoot(MyApp),
    HttpClientModule,
    FormsModule
    
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    LoginPage,
    DashboardPage,
    RegisterPage,
    CarsPage,
    ListPostPage,
    CreatePostPage
  ],
  providers: [
    Camera,
    StatusBar,
    SplashScreen,
    {provide: ErrorHandler, useClass: IonicErrorHandler},
    PostProvider,
    PostCategoryProvider
  ]
})
export class AppModule {}
