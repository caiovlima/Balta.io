const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const schema = new Schema({
    //referenciando "relacionamento", dando o nome de outro Schema por padrão
    customer: {
        //atribuindo o relacionamento a propriedade type
        type: mongoose.Schema.Types.ObjectId,
        //indicando qual o schema 
        ref: 'Customer'
    },

    number: {
        type: String,
        required: true
    },
    
    createdDate: {
        type: Date,
        required: true,
        default: Date.now
    },

    status: {
        type: String,
        required: true,
        enum: ['created', 'done'],
        default: 'created'
    },

    items: [{
        quantity: {
            type: Number,
            required: true,
            default: 1
        },

        price: {
            type: Number,
            required: true
        },

        product: {
            type: mongoose.Schema.Types.ObjectId,
            ref: 'Product'
        }
    }]
});

module.exports = mongoose.model('Order', schema);