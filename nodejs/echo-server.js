'use strict';
const net = require('net');

net.createServer(function (socket) {
    socket.on('data', function (data) {
        socket.write(data);
    });
}).listen(8888);
