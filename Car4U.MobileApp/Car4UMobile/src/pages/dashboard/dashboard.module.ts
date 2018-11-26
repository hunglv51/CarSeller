import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { DashboardPage } from './dashboard';
import { PostProvider } from '../../providers/post/post-provider';
import { CarPricePipe } from '../../pipes/car-price/car-price';

@NgModule({
  declarations: [
    DashboardPage,
    CarPricePipe
  ],
  imports: [
    IonicPageModule.forChild(DashboardPage),
  ],
  providers:[
    PostProvider
  ]
})
export class DashboardPageModule {}
