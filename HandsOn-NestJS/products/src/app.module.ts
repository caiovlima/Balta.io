import { Module } from '@nestjs/common';
import { ProductModule } from './products/products.module';
import { MongooseModule } from '@nestjs/mongoose/dist/mongoose.module';


@Module({
  imports: [
    ProductModule,
    MongooseModule.forRoot('mongodb+srv://admin:root@meancourse-u9bx1.mongodb.net/test?retryWrites=true&w=majority')
  ],
})
export class AppModule {}
