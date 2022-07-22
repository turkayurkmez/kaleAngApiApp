import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, throwError } from 'rxjs';
import { Project } from '../models/project.model';

@Injectable({
  providedIn: 'root'
})
export class ProjectsService {

  url:string ='https://localhost:7276/api/Projects';

  constructor(private httpClient: HttpClient) { }

  getProjects():Observable<Project[]>{
    return this.httpClient.get<Project[]>(this.url)
                          .pipe(catchError((err:HttpErrorResponse) => {
                           console.log(err.message);
                           return throwError(()=> new Error(err.statusText))
                          }));
  }

  addProject(project: Project):Observable<Project>{
    let option = {
      headers: new HttpHeaders({
        'Authorization':'Bearer '+ localStorage.getItem('token')
      })
    };
    console.log(project,this.url)
    return this.httpClient.post<Project>(this.url,project,option);


  }
}
