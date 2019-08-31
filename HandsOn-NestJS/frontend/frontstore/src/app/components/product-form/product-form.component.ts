import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { Product } from '../../shared/interfaces/product';
import { ProductService } from '../../shared/services/product.service';

@Component({
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})
export class ProductFormComponent implements OnInit {

  product: Product = {
    name: '',
    description: '',
    price: 0,
    imageURL: ''
  };
  constructor(private productService: ProductService, private router: Router) { }

  ngOnInit() {
  }

  submitProduct() {
    this.productService.createProduct(this.product)
      .subscribe(
        res => {
          console.log(res);
          this.router.navigate(['/']);
        },
        err => console.log(err)
      )
  }

}
