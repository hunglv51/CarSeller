import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { CarsPage } from './cars';
import { PostProvider } from '../../providers/post/post-provider';

@NgModule({
  declarations: [
    CarsPage,
  ],
  imports: [
    IonicPageModule.forChild(CarsPage),
  ],
  providers:
  [
    PostProvider
  ]
})
export class CarsPageModule {}
