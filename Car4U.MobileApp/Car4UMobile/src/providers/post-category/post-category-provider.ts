import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { PostCategory } from '../../models/post-category';

/*
  Generated class for the PostCategoryProvider provider.

  See https://angular.io/guide/dependency-injection for more info on providers
  and Angular DI.
*/
@Injectable()
export class PostCategoryProvider {

  constructor(public http: HttpClient) {
    console.log('Hello PostCategoryProvider Provider');
  }
  getPostCategories() : Observable<Array<PostCategory>>
  {
    return this.http.get<Array<PostCategory>>("/api/postcategory");
  }
}
