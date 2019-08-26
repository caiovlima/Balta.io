import { Controller, Get, Post, Put, Delete, Body, Res, Param } from '@nestjs/common';
import { ProductModel } from '../models/ProductModel';
import { ProductService } from '../services/ProductService';

@Controller('v1/products')
export class ProductController {
    constructor(private readonly service: ProductService) { }

    @Post()
    async create(@Body() model: ProductModel) {
        this.service.create(model);
    }

    @Get('/')
    async get(): Promise<ProductModel[]> {
        return this.service.get();
    }

    @Get('/:id')
    async getProduct(@Param('id') _id) {
        return this.service.getById(_id);
    }

    @Delete('/delete/:id')
    async deleteProduct(@Param('id') id) {
        this.service.delete(id);
    }

    @Put('/update/:id')
    async updateProduct(@Param('id') id, @Body('body') body) {
        this.service.update(id, body);
    }
}