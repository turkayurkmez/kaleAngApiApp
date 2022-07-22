import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, tap, throwError } from 'rxjs';
import { Category } from '../models/category.model';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  constructor(private httpClient: HttpClient) { }
  url: string =  'https://localhost:7276/api/Categories';

  getCategories(): Observable<Category[]> {
    console.log(this.url);
    return this.httpClient.get<Category[]>(this.url).pipe(tap(data=>console.log(data)));
      
  }

  addCategory(category:Category): Observable<Category>{
    console.log('post çalıştı');
    return this.httpClient.post(this.url,category);
  }



  /*
    console.log("initialized.....")
    this.httpClient.get<any[]>('https://localhost:7276/api/Categories')
      .pipe(tap(x => console.log(x)))
      .subscribe(data => console.log(data))
   */

}
