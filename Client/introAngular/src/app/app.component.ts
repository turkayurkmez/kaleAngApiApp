import { Component } from '@angular/core';
import { TodoItem } from './models/todoItem.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title: string = "Angular'a hoşgeldiniz!";
  owner: string = 'Türkay Ürkmez';
  generatedDate: string = "Temmuz 2022";
  newTodoTask:string;

  todoItems: TodoItem[] = [
    new TodoItem('Çiçekleri sula',false),
    new TodoItem('Gazete alınacak', true)    
  ];

  addNewTask(taskName: string){
    let todoItem = new TodoItem(taskName, false);
    this.todoItems.push(todoItem);
  }

}
