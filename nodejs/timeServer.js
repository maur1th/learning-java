/*jslint es6, node*/
"use strict";
let net = require('net');
let strftime = require('strftime');
net.createServer(function (socket) {
    socket.end(strftime('%F %H:%M') + '\n');
}).listen(process.argv[2]);