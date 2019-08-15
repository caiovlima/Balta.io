const mongoose = require('mongoose');
const Schema = mongoose.Schema();

const itemSchema = new Schema({
    description: {
        type: String,
        required: true
    },

    done: {
        type: Boolean
    }
}); 

module.exports = mongoose.model("Item", todoSchema);