import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../shared/services/product.service';
import { Product } from '../../shared/interfaces/product';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  products: Product[] = [];

  constructor(private productService: ProductService) { }

  ngOnInit() {
    this.getAll();
  }

  getAll() {
    this.productService.getProducts()
      .subscribe(
        res => {
          this.products = res;
        },
        err => console.log(err)
      );
  }

  deleteProduct(id: string) {
    this.productService.deleteProduct(id)
      .subscribe(
        res => {
          this.getAll();
        },
        err => console.log(err)
      )
  }

}
