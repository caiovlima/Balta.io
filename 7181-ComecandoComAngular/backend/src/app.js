const express = require('express');
const mongoose = require('mongoose');

const app = express();
const router = express.Router();

//connection string


//loading models



//loading routes
const indexRoute = require('./routes/index-route.js');


//use routings
app.use('/', indexRoute);

module.exports = app;