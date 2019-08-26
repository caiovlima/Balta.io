export class ProductModel {
    public _id: string = '';
    public name: string = '';
    public description: string = '';
    public imageURL: string = '';
    public price: number = 0;
    public createdAt: number = Date.now();
}