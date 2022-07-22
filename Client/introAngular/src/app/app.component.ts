import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { tap } from 'rxjs';
import { TodoItem } from './models/todoItem.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title: string = "Angular'a hoşgeldiniz!";
  owner: string = 'Türkay Ürkmez';
  generatedDate: string = "Temmuz 2022";
  newTodoTask: string;

  todoItems: TodoItem[] = [
    new TodoItem('Çiçekleri sula', false),
    new TodoItem('Gazete alınacak', true)
  ];





  addNewTask(taskName: string) {
    let todoItem = new TodoItem(taskName, false);
    this.todoItems.push(todoItem);
  }

  constructor(private httpClient: HttpClient) { }
  ngOnInit(): void {
    console.log("initialized.....")
    this.httpClient.get<any[]>('https://localhost:7276/api/Categories')
      .pipe(tap(x => console.log(x)))
      .subscribe(data => console.log(data))

  }

}
