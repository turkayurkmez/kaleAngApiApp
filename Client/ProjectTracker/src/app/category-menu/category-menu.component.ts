import { Component, OnInit } from '@angular/core';
import { tap } from 'rxjs';
import { Category } from '../models/category.model';
import { Categories } from '../models/mocks/categories.mock';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'app-category-menu',
  templateUrl: './category-menu.component.html',
  styleUrls: ['./category-menu.component.css']
})
export class CategoryMenuComponent implements OnInit {

  constructor(private categoryService: CategoryService) { }

  categories: Category[];

  ngOnInit(): void {
    this.categoryService.getCategories()
                        .subscribe(data=> this.categories =data );
  }

}
