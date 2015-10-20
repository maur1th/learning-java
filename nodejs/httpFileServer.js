/*jslint es6, node*/
"use strict";
let http = require('http');
let fs = require('fs');
http.createServer(function (ignore, res) {
    res.writeHead(200, {'content-type': 'text/plain'});
    fs.createReadStream(process.argv[3]).pipe(res);
}).listen(process.argv[2]);