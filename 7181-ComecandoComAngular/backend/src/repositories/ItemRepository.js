const mongoose = require('mongoose');
const Item = mongoose.model('Item');

exports.get = async() => {
    const res = await Item.find();
    return res;
}

exports.getById = async(id) => {
    const res = await Item.findById(id);
    return res;
}

exports.create = async(body) => {
    var item = new Item(body);
    await item.save();
}

exports.update = async(id, body) => {
    await Item.findByIdAndUpdate(id, {
        $set: {
            description: body.description,
            done: body.done
        }
    });
}

exports.delete = async(id) => {
    await Item.findByIdAndUpdate(id);
}