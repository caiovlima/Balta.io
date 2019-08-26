import { Model } from 'mongoose';
import { ProductModel } from '../models/ProductModel';
import { Injectable } from '@nestjs/common';
import { InjectModel } from '@nestjs/mongoose';



@Injectable()
export class ProductService {
    constructor(@InjectModel('Product') private readonly model: Model<ProductModel>) { }
        
        async get(): Promise<ProductModel[]> {
            return await this.model.find().exec();
        }

        async getById(_id: string): Promise<ProductModel[]> {
            const product = await this.model.findById(_id).exec();
            return product;
        }

        async create(model: ProductModel): Promise<ProductModel> {
            const product = new this.model(model);
            return await product.save();
        }

        async delete(id: string): Promise<ProductModel> {
            const product = await this.model.findByIdAndDelete(id);
            return product;
        }

        async update(id: string, body: string): Promise<ProductModel> {
            const product = await this.model.findByIdAndUpdate(id, ...body);
            return product;
        }
    
}