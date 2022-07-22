import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCategoryComponent } from './add-category/add-category.component';
import { AddProjectComponent } from './add-project/add-project.component';
import { LoginComponent } from './login/login.component';
import { LoginGuard } from './login/login.guard';
import { ProjectListComponent } from './project-list/project-list.component';

const routes: Routes = [
  {path:'kategoriekle',component:AddCategoryComponent},
  {path:'projeekle',component:AddProjectComponent , canActivate:[LoginGuard] },
  {path:'',component:ProjectListComponent},
  {path:'anasayfa',component:ProjectListComponent}, 
  {path:'login', component:LoginComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
