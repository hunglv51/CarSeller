import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { PostProvider } from '../../providers/post/post-provider';
import { CarImage } from '../../models/car-image';
/**
 * Generated class for the DashboardPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-dashboard',
  templateUrl: 'dashboard.html',
})
export class DashboardPage {

  listPost:Array<CarImage>;
  constructor(public navCtrl: NavController, public navParams: NavParams, private postService: PostProvider) {
    
    // this.getPosts(1);
    // console.log(this.listPost);
    // this.postService.testAPI().subscribe(data => console.log(data));  
  }

  ionViewOnInit(){
    
  }
  ionViewDidLoad() {
    console.log('ionViewDidLoad DashboardPage');
    // this.postService.testAPI().subscribe(data => console.log(data));
    this.getPosts(1);

    console.log(this.listPost);
  }

  getPosts(pageIndex:number)
  {
    this.postService.getPosts(pageIndex).subscribe((data) => {
      this.listPost = data["items"];
      console.log(this.listPost);
      
    });
  }
}
