import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { CarImage } from '../../models/car-image';
import { CarBrand } from '../../models/car-brand';

/*
  Generated class for the PostProvider provider.

  See https://angular.io/guide/dependency-injection for more info on providers
  and Angular DI.
*/
@Injectable()
export class PostProvider {

  constructor(public http: HttpClient) {
    
  }

  getPosts(pageIndex:number) : Observable<Array<CarImage>>
  {
    return this.http.get<Array<CarImage>>("/api/posts");
  }

  getPostsByBrand(brandName:string)
  {
    return this.http.get<Array<CarImage>>("/api/posts?brandName=" + brandName);
  }

  getPostCategories() : Observable<Array<CarBrand>>
  {
    return this.http.get<Array<CarBrand>>("/api/postcategory");
  }
}
