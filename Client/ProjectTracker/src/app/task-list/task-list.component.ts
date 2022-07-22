import { Component, Input, OnInit } from '@angular/core';
import { ProjectTask } from '../models/projectTask.model';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css']
})
export class TaskListComponent implements OnInit {

  constructor() { }

  @Input() tasks?: ProjectTask[];

  ngOnInit(): void {
  }

}
