const express = require('express');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');
const config = require('./config');

const app = express();
const router = express.Router();

//conectar ao mongo
mongoose.connect(config.connectionString, {useNewUrlParser: true});

//carregando as models
const Product = require('./models/product');
const Order = require('./models/order');
const Customer = require('./models/customer');

//carrega as rotas
const indexRoute = require('./routes/index-route.js');
const productRoute = require('./routes/product-route.js');
const customerRoute = require('./routes/customer-route');
const orderRoute = require('./routes/order-route');


app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));


app.use('/', indexRoute);
app.use('/products', productRoute);
app.use('/customers', customerRoute);
app.use('/orders', orderRoute);

module.exports = app;