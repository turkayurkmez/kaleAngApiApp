import { Pipe, PipeTransform } from '@angular/core';
import { Project } from '../models/project.model';

@Pipe({
  name: 'search'
})
export class SearchPipe implements PipeTransform {

  transform(value: Project[], searchKey: string): Project[] {
    return searchKey != undefined ? value.filter(proj => proj.name?.toLowerCase().includes(searchKey.toLocaleLowerCase()))
                                  : value;
  }

}
