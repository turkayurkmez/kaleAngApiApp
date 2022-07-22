import { Component, OnInit } from '@angular/core';
import { Category } from '../models/category.model';
import { Categories } from '../models/mocks/categories.mock';

@Component({
  selector: 'app-category-menu',
  templateUrl: './category-menu.component.html',
  styleUrls: ['./category-menu.component.css']
})
export class CategoryMenuComponent implements OnInit {

  constructor() { }

  categories: Category[] = Categories

  ngOnInit(): void {
  }

}
