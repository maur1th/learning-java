/*jslint es6, node*/ // jshint ignore:line
'use strict';
var http = require('http');
http.get(process.argv[2], function (res) {
    res.setEncoding('utf-8');
    res.on('data', console.log);
    res.on('error', console.error);
});