import { Module } from '@nestjs/common';
import { ProductController } from './controllers/ProductController';
import { ProductService } from './services/ProductService';
import { MongooseModule } from '@nestjs/mongoose/dist/mongoose.module';
import { ProductSchema } from './schemas/ProductSchema';

@Module({
    imports: [MongooseModule.forFeature([{name: 'Product', schema: ProductSchema}])],
    controllers: [ProductController],
    providers: [ProductService]
})
export class ProductModule {}
