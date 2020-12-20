import { CustomerService } from './../services/customer.service';
import { Model } from 'mongoose';
import { Controller, Put, Post, Get, Delete, Param, Body, UseInterceptors } from '@nestjs/common';
import { Customer } from '../models/customer.model';
import { Result } from '../models/result.model';
import { CreateCustomerContract } from '../contracts/customer.contract';
import { ValidatorInterceptor } from '../../../shared/interceptors/validator.interceptor';
import { CreateCustomerDto } from '../dtos/customer/create-customer.dto';
import { AccountService } from '../services/account.service';
import { User } from '../models/user.model';

@Controller('v1/customers')
export class CustomerController {

    constructor(
        private readonly accountService: AccountService,
        private readonly customerService: CustomerService) {
        
    }

    @Get(':document')
    getById(@Param('document') document) {
        return new Result(null, true, {}, null);
    }

    @Get()
    get() {
        return new Result(null, true, [], null);
    }

    @Post()
    @UseInterceptors(new ValidatorInterceptor(new CreateCustomerContract()))
    async post(@Body() model: CreateCustomerDto) {

        try {
            const user = await this.accountService.create(
                new User(model.document, model.password, true),
                );
                
            const customer = new Customer(model.name, model.document, model.email, null, null, null, null, user);
            const res = await this.customerService.create(customer);
            return new Result('Cliente Criado com Sucesso!', true, user, null);

            
        } catch (error) {
            throw new HttpException(new ResultDto('Não foi possível realizar seu cadastro', false, null, error), HttpStatus.BAD_REQUEST);
        }

    }

    @Put(':document')
    put(@Param('document') document, @Body() body: Customer) {
        return new Result('Cliente alterado com sucesso', true, body, null);
    }

    @Delete(':document')
    delete(@Param('document') document) {
        return 'Excluir Clientes';
    }
}
