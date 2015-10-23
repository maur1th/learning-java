/*jslint es6, node*/ // jshint ignore:line
'use strict';
const http = require('http');
const bl = require('bl');

http.get(process.argv[2], function (res) {
    res.setEncoding('utf-8');
    // Using bl
    res.pipe(bl(function (err, data) {
        if (err) {
            throw err;
        }
        console.log('## Using bl ##');
        data = data.toString();
        console.log(data.length);
        console.log(data);
    }));
    // Without bl
    var s = '';
    res.on('data', function (chunk) {
        s += chunk;
    });
    res.on('end', function () {
        console.log('## Without bl ##');
        console.log(s.length);
        console.log(s);
    });
    res.on('error', console.log);
});