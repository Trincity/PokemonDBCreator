import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'ascendingOrder'
})
export class AscendingOrderPipe implements PipeTransform {

  transform(value: Array<any>, args?: any): Array<any> {
    value.sort((a: any, b: any) => {
      if (a < b) {
        return -1;
      } else if (a > b) {
        return 1;
      } else {
        return 0;
      }
    });
    return value;
  }

}
