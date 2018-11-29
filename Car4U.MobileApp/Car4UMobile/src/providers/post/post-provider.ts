import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { CarImage } from '../../models/car-image';
import { Post } from '../../models/post';

/*
  Generated class for the PostProvider provider.

  See https://angular.io/guide/dependency-injection for more info on providers
  and Angular DI.
*/
const bassUrl = "/api/posts"
@Injectable()
export class PostProvider {

  constructor(public http: HttpClient) {
    
  }

  getPosts(pageIndex:number) : Observable<Array<CarImage>>
  {
    return this.http.get<Array<CarImage>>(bassUrl);
  }

  getPostsByBrand(brandName:string)
  {
    return this.http.get<Array<CarImage>>(bassUrl + "?brandName=" + brandName);
  }
  createNewPost(post:Post)
  {
    return this.http.post<Post>(bassUrl,post);
  }
  
}
