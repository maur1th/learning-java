/*jslint es6, node*/
"use strict";
const http = require('http');
const bl = require('bl');

http.get(process.argv[2], function (res) {
    res.setEncoding('utf-8');
    res.pipe(bl(function (err, data) {
        if (err) {
            throw err;
        }
        data = data.toString();
        console.log(data.length);
        console.log(data);
    }));
});