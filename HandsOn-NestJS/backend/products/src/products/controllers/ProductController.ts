import { Controller, Get, Post, Put, Delete, Body, Res, Param } from '@nestjs/common';
import { ProductModel } from '../models/ProductModel';
import { ProductService } from '../services/ProductService';

@Controller('/products')
export class ProductController {
    constructor(private readonly service: ProductService) { }

    @Post()
    async create(@Body() model: ProductModel) {
        const product = await this.service.create(model);
        return product;
    }

    @Get('/')
    async get(): Promise<ProductModel[]> {
        const product = await this.service.get();
        return product;
    }

    @Get('/:id')
    async getProduct(@Param('id') id) {
        const product = await this.service.getById(id);
        return product;
    }

    @Delete('/delete/:id')
    async deleteProduct(@Param('id') id) {
        this.service.delete(id);
    }

    @Put('/update/:id')
    async updateProduct(@Param('id') id, @Body() model: ProductModel) {
        const product = await this.service.update(id, model);
        return product;
    }
}