import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { HttpService } from 'src/app/service/http.service';
import { Product } from './product.model';

@Component({
    selector: 'app-product',
    templateUrl: './product.component.html',
})
export class ProductComponent implements OnInit {
    productForm: FormGroup;
    prod: Product = new Product();
    products: Product[] = [];

    constructor(private service: HttpService) { }

    ngOnInit() {
        this.productForm = new FormGroup({
            name: new FormControl(''),
            price: new FormControl(''),
            rating: new FormControl('')
        });

        this.getAllProducts();
    }

    onSubmit(prodForm: FormGroup) {
        this.prod.name = prodForm.value.name;
        this.prod.price = parseFloat(prodForm.value.price);
        this.prod.rating = parseInt(prodForm.value.rating);

        let apiurl = 'product/addproduct';

        this.service.post(this.prod, apiurl).subscribe(data => {
            this.getAllProducts();
        });

        this.productForm = new FormGroup({
            name: new FormControl(''),
            price: new FormControl(''),
            rating: new FormControl('')
        });
    }

    getAllProducts() {
        this.service.get(null, 'product/getproducts').subscribe(pd => {
            this.products = pd;
        });
    }
}
