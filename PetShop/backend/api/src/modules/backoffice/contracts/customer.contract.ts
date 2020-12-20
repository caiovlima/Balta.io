import { Contract } from './contract';
import { Flunt } from '../../../utils/flunt';
import { Injectable } from '@nestjs/common';
import { CreateCustomerDto } from '../dtos/customer/create-customer.dto';

@Injectable()
export class CreateCustomerContract implements Contract {
    errors: any[];

    validate(model: CreateCustomerDto): boolean {
        const flunt = new Flunt();

        flunt.hasMinLen(model.name, 5, 'Nome inválido');
        flunt.isEmail(model.email, 'E-mail inválido');
        flunt.isFixedLen(model.document, 11, 'CPF inválido');
        flunt.hasMinLen(model.password, 5, 'Senha inválida');
        
        this.errors = flunt.errors;
        return this.errors.length === 0;

    }
}