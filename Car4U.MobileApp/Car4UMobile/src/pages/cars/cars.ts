import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { CarBrand } from '../../models/car-brand';
import { ListPostPage } from '../list-post/list-post';
import { PostCategoryProvider } from '../../providers/post-category/post-category-provider';

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
  constructor(public navCtrl: NavController, public navParams: NavParams, private postCategoryProvider: PostCategoryProvider) {
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad CarsPage');
    this.postCategoryProvider.getPostCategories().subscribe(data => {
      this.carBrands = data;
      console.log("car brands",this.carBrands);
    });
    
      
  }
    goCategory(categoryName: string){
      console.log(categoryName);      
      this.navCtrl.push(ListPostPage, {brandName: categoryName})
    }
}
