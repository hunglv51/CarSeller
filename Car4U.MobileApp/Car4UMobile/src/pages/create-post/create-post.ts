import { Component, ViewChild } from "@angular/core";
import { IonicPage, NavController, NavParams, Slides,ToastController } from "ionic-angular";
import { CarTypes } from "../../constants/car-types";
import { Post } from "../../models/post";
import { Camera, CameraOptions } from "@ionic-native/camera";
import { CarTransmission } from "../../constants/car-transmission";
import { CarImage } from "../../models/car-image";
import { PostProvider } from "../../providers/post/post-provider";
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
  transmission = CarTransmission;
  transmissionKeys = Object.keys(CarTransmission);

  post: Post = new Post();
  data = "data:image/jpeg;base64,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";

  images: Array<CarImage> = [new CarImage(this.data, false),new CarImage(this.data, true)];
  isFirstImg = true;
  @ViewChild(Slides) slides: Slides;
  constructor(
    private toastController: ToastController,
    public navCtrl: NavController,
    public navParams: NavParams,
    private camera: Camera,
    private postProvider: PostProvider
  ) 
  {
    this.post.createdDate = new Date();
    this.post.images = this.images;
  }
  
  ionViewDidLoad() {
    console.log("ionViewDidLoad CreatePostPage");
  }

  createPost() {
    console.log(this.post);
    this.postProvider.createNewPost(this.post).subscribe(data =>{
      console.log(data);
      
    });
  }
  
  takePhoto(){
      const options: CameraOptions = {
        quality: 100,
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
       this.images.unshift(new CarImage(
         base64Image,
         this.isFirstImg
       ));
       this.isFirstImg = false;
       let toast = this.toastController.create({
         message: "Tap set button to set avatar",
         duration: 5000,
         position: "bottom"
       });
       toast.present();
      }, (err) => {
       console.log(err);
       
      });
  }

  setAvatar(image)
  {
    this.images.forEach(img => img.isAvatar = false);
    image.isAvatar = true;
  }
  removeImage(deletingImage)
  {
    console.log(this.slides.length);
    this.slides.slidePrev();
    this.images = this.images.filter(img => img != deletingImage);
    console.log(this.slides.length);
    
  }
}
