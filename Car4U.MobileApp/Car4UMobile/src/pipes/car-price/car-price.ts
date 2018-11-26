import { Pipe, PipeTransform } from '@angular/core';

/**
 * Generated class for the CarPricePipe pipe.
 *
 * See https://angular.io/api/core/Pipe for more info on Angular Pipes.
 */
@Pipe({
  name: 'carPrice',
})
export class CarPricePipe implements PipeTransform {
  /**
   * Takes a value and makes it lowercase.
   */
  transform(value: number, ...args) {
    let bil = Math.floor(value / 1000);
    let mil = value - bil * 1000;
    let rs = '';
    if(bil > 0)
      rs += (bil + ' tỷ ');
    if(mil > 0)
      rs += (mil + ' triệu ');
    return rs;
  }
}
