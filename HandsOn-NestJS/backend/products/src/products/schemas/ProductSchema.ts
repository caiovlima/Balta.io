import * as mongoose from 'mongoose'

export const ProductSchema = new mongoose.Schema({
    name: {
        type: String,
        required: true
    },

    description: {
        type: String
    },

    imageURL: {
        type: String
    },

    price: {
        type: Number,
        required: true
    },

    createdAt: {
        type: Date,
        default: Date.now
    },


});