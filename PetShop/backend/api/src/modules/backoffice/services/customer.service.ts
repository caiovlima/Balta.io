import { Model } from 'mongoose';
import { Injectable } from '@nestjs/common';
import { Customer } from '../models/customer.model';
import { InjectModel } from '@nestjs/mongoose';

@Injectable()
export class CustomerService {
    constructor(@InjectModel('Customer') private readonly model: Model<Customer>) {
        
    }

    async create(data: Customer): Promise<Customer> {
        const customer = new this.model(data);
        return await customer.save();
    }
}
