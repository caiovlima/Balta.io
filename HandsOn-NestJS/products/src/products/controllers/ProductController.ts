import { Get, Controller, Post, Body } from '@nestjs/common';
import { ProductModel } from '../models/ProductModel';
import { ProductService } from '../services/ProductService';

@Controller('v1/products')
export class ProductController {
    constructor(private readonly service: ProductService) { }

    @Post()
    async create(@Body() model: ProductModel) {
        this.service.create(model);
    }

    @Get()
    async get(): Promise<ProductModel[]> {
        return this.service.get();
    }
}