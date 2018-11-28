import { Component } from "@angular/core";
import { IonicPage, NavController, NavParams } from "ionic-angular";
import { CarTypes } from "../../constants/car-types";
import { Post } from "../../models/post";
import { Camera, CameraOptions } from "@ionic-native/camera";
import { normalizeURL, Platform } from "ionic-angular";
import { DomSanitizer, SafeUrl} from "@angular/platform-browser";
/**
 * Generated class for the CreatePostPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: "page-create-post",
  templateUrl: "create-post.html"
})
export class CreatePostPage {
  carTypes = CarTypes;
  carTypesKeys = Object.keys(CarTypes);
  post: Post = new Post();
  base64Image: any;
  testImage1 = "data:image/jpeg;base64," +  "file:///storage/emulated/0/Android/data/io.ionic.devapp/cache/1543400158947.jpg";
  testImage2 :any;
  testImage3 :any;
  images: Array<{src: String}> = [];

  constructor(
    public navCtrl: NavController,
    public navParams: NavParams,
    private camera: Camera,
    private platform: Platform,
    private sanitizer: DomSanitizer
  ) {
    this.post.createdDate = new Date();
  }
  cameraOptions: CameraOptions = {
    quality: 100,
    destinationType: this.camera.DestinationType.FILE_URI,
    encodingType: this.camera.EncodingType.JPEG,
    mediaType: this.camera.MediaType.PICTURE
  };
  ionViewDidLoad() {
    console.log("ionViewDidLoad CreatePostPage");
    this.testImage2 = this.sanitizer.bypassSecurityTrustUrl(this.testImage1);
    this.testImage3 = this.sanitizer.bypassSecurityTrustResourceUrl(this.testImage1);
  }

  createPost() {
    console.log(this.post);
  }
  takePhoto123() {
    this.camera.getPicture(this.cameraOptions).then(
      imageData => {
        if (this.platform.is("ios")) {
          this.base64Image = normalizeURL(imageData);
          
        } else {
          console.log("Image Data",imageData);
          let normalize = normalizeURL(imageData);
          console.log("Image Path normalize",normalize);
          this.base64Image = this.sanitizer.bypassSecurityTrustResourceUrl(normalize);
          
          
        }
        console.log("Image Path",this.base64Image);
      },
      error => {
        console.log("ERROR -> " + JSON.stringify(error));
      }
    );
  }
  takePhoto(){
    const options: CameraOptions = {
      quality: 80,
      destinationType: this.camera.DestinationType.DATA_URL,
      sourceType: this.camera.PictureSourceType.CAMERA,
      allowEdit: false,
      encodingType: this.camera.EncodingType.JPEG,
      saveToPhotoAlbum: false
    }
    this.camera.getPicture(options).then((imageData) => {
     // imageData is either a base64 encoded string or a file URI
     // If it's base64:
     let base64Image = 'data:image/jpeg;base64,' + imageData;
     this.images.unshift({
       src: base64Image
     })
    }, (err) => {
     // Handle error
    });
  }
}



//file:///storage/emulated/0/Android/data/io.ionic.devapp/cache/1543400158947.jpg
//file:///storage/emulated/0/Android/data/io.ionic.devapp/cache/1543400158947.jpg