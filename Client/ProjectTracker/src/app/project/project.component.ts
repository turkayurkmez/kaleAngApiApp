import { AfterContentChecked, Component, Input, OnInit } from '@angular/core';
import { Project } from '../models/project.model';

@Component({
  selector: 'app-project',
  templateUrl: './project.component.html',
  styleUrls: ['./project.component.css']
})
export class ProjectComponent implements OnInit, AfterContentChecked {

  constructor() { }
  ngAfterContentChecked(): void {
    this.inCompletedTaskCount = this.project?.tasks?.filter(t => !t.isCompleted).length;
    this.isTaskFound = this.inCompletedTaskCount != undefined && this.inCompletedTaskCount > 0
    this.isEven = this.inCompletedTaskCount != undefined && this.inCompletedTaskCount  % 2 == 0;
  }

  @Input() project: Project;

  inCompletedTaskCount?: number;
  isTaskFound: boolean;
  isEven: boolean;

  ngOnInit(): void {


  }



}
