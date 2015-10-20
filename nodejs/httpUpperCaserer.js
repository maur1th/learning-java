/*jslint es6, node*/
"use strict";
const http = require('http');
http.createServer(function (req, res) {
    if(req.method !== 'POST') {
        return;
    }
    let s = "";
    req.setEncoding('utf-8');
    req.on('data', function (chunk) {
        s += chunk.toUpperCase();
    });
    req.on('end', function () {
        res.writeHead(200, {'content-type': 'text/plain'});
        res.end(s);
    });
}).listen(process.argv[2]);