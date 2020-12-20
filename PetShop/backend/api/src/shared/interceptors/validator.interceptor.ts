import { Contract } from './../../modules/backoffice/contracts/contract';
import { Result } from '../../modules/backoffice/models/result.model';
import { NestInterceptor, ExecutionContext, Injectable, HttpException, HttpStatus, CallHandler } from "@nestjs/common";
import { Observable } from "rxjs";

@Injectable()
export class ValidatorInterceptor implements NestInterceptor {
    constructor(public contract: Contract) { }


    intercept(context: ExecutionContext, next: CallHandler): Observable<any> {
        const body = context.switchToHttp().getRequest().body;
        const valid = this.contract.validate(body);

        if (!valid) {
            throw new HttpException(
                new Result('Ops, algo saiu errado',
                    false,
                    null,
                    this.contract.errors),
                HttpStatus.BAD_REQUEST);

        }

        return next.handle();
    }
}


