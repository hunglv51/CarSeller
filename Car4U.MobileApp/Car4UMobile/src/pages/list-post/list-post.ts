import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { PostProvider } from '../../providers/post/post-provider';
import { CarImage } from '../../models/car-image';

/**
 * Generated class for the ListPostPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-list-post',
  templateUrl: 'list-post.html',
})
export class ListPostPage {
  brandName:string;
  listPost: Array<CarImage>;
  constructor(public navCtrl: NavController, public navParams: NavParams, private postProvider: PostProvider) {
    this.brandName = this.navParams.get("brandName");
    
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad ListPostPage');
    this.postProvider.getPostsByBrand(this.brandName).subscribe(data => {
      this.listPost = data['items'];
    });
  }

}
