import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { Category } from '../models/category.model';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'app-add-category',
  templateUrl: './add-category.component.html',
  styleUrls: ['./add-category.component.css']
})
export class AddCategoryComponent implements OnInit {

  constructor(private categoryService: CategoryService, private router:Router) { }

  ngOnInit(): void {
  }

  category: Category = new Category();

  submitForm(form: NgForm) {
    if (form.valid) {
      this.category = form.value;
      console.log(this.category);
      //! Burada servis üzerinden post edilecek.
      this.categoryService.addCategory(this.category).subscribe(data => {
        alert('yeni kategori eklendi');
        location=location;
        //this.router.navigateByUrl('');
      });

    }

  }

}
