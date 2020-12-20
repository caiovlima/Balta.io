var config = require('../config.js');
var sendgrid = require('sendgrid')(config.sendgridKey);

exports.send = async (to, subject, body) => {
    sendgrid.send({
        to: to,
        from: 'caio_lima_nh@hotmail.com',
        subject: subject,
        html: body
    });
}