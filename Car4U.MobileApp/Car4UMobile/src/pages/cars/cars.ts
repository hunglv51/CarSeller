import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { CarBrand } from '../../models/car-brand';
import { PostProvider } from '../../providers/post/post-provider';

/**
 * Generated class for the CarsPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-cars',
  templateUrl: 'cars.html',
})
export class CarsPage {
  carBrands: CarBrand[];
  constructor(public navCtrl: NavController, public navParams: NavParams, private postProvider: PostProvider) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad CarsPage');
    this.postProvider.getPostCategories().subscribe(data => {
      this.carBrands = data;
      console.log("car brands",this.carBrands);
    });
    
  }

  
  
}
