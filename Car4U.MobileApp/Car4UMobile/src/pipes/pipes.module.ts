import { NgModule } from '@angular/core';
import { CarPricePipe } from './car-price/car-price';
@NgModule({
	declarations: [CarPricePipe],
	imports: [],
	exports: [CarPricePipe]
})
export class PipesModule {}
