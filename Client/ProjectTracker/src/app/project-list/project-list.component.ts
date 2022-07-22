import { Component, OnInit } from '@angular/core';
import { Projects } from '../models/mocks/projects.mock';
import { Project } from '../models/project.model';
import { ProjectsService } from '../services/projects.service';

@Component({
  selector: 'app-project-list',
  templateUrl: './project-list.component.html',
  styleUrls: ['./project-list.component.css']
})
export class ProjectListComponent implements OnInit {

  constructor(private projectsService: ProjectsService) { }

  projects: Project[];

  searchingName:string

  ngOnInit(): void {
    this.projectsService.getProjects().subscribe(data=>this.projects = data);
  }

}
