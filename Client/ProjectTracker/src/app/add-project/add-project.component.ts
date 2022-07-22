import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Category } from '../models/category.model';
import { Project } from '../models/project.model'
import { CategoryService } from '../services/category.service';
import { ProjectsService } from '../services/projects.service';

@Component({
  selector: 'app-add-project',
  templateUrl: './add-project.component.html',
  styleUrls: ['./add-project.component.css']
})
export class AddProjectComponent implements OnInit {

  constructor(private builder:FormBuilder, private categoryService: CategoryService, private projectService: ProjectsService) { }

  addProjectForm: FormGroup;
  project :Project = new Project();

  categories: Category[] = [];

  ngOnInit(): void {
    this.addProjectForm = this.builder.group({
      name: ['', [Validators.required, Validators.minLength(3)]],
      description:['',Validators.required],
      categoryId:['', Validators.required]
    });

    this.categoryService.getCategories().subscribe(data => this.categories = data);
  }

  checkNameIsEmpty():boolean | undefined{
    return this.addProjectForm.get('name')?.hasError('required') && 
           (this.addProjectForm.get('name')?.dirty || this.addProjectForm.get('name')?.pristine)
  }

  checkNameIsMinLength():boolean | undefined{
    console.log('denetleniyor');
    return this.addProjectForm.get('name')?.hasError('minLength') && 
          this.addProjectForm.get('name')?.dirty;
  }

  checkDescriptionIsEmpty():boolean | undefined{
    return this.addProjectForm.get('description')?.hasError('required') && 
           (this.addProjectForm.get('description')?.dirty || this.addProjectForm.get('description')?.pristine)
  }

  checkCategoryIsEmpty():boolean | undefined{
    return this.addProjectForm.get('categoryId')?.hasError('required') && 
           (this.addProjectForm.get('categoryId')?.untouched)
  }

  addProject(){
    if (this.addProjectForm.valid) {
      this.project = this.addProjectForm.value;

      console.log('sunucuya gönderilebilir.');
      console.log(this.project);
      this.projectService.addProject(this.project).subscribe(data=>alert(data.name + '  projesi eklendi'));
    }
  }



}
