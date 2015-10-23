/*jslint es6, node*/ // jshint ignore:line
'use strict';
const http = require('http');
http.createServer(function (req, res) {
    if (req.method !== 'GET') {
        return;
    }
    const qs = require('url').parse(req.url, true);
    const time = new Date(qs.query.iso);
    let result;
    if (qs.pathname === '/api/parsetime') {
        result = {
            hour: time.getHours(),
            minute: time.getMinutes(),
            second: time.getSeconds()
        };
    } else if (qs.pathname === '/api/unixtime') {
        result = {unixtime: time.getTime()};
    }
    if (result) {
        res.writeHead(200, {'Content-Type': 'application/json'});
        res.end(JSON.stringify(result));
    } else {
        res.writeHead(404);
        res.end();
    }
}).listen(process.argv[2]);