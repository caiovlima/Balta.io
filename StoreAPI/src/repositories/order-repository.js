const mongoose = require('mongoose');
const Order = mongoose.model('Order');

exports.get = async(body) => {
    const res = await Order.find({}, 'number status customer items')
        .populate('customer')
        .populate('items.product');
    return res;
}

exports.create = async(body) => {
    var oder = new Order(body);
    await order.save();
}
//aula30