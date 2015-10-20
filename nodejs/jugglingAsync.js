/*jslint es6, node*/
"use strict";
let http = require('http');
let results = [];
let cbCount = 0;
process.argv.forEach(function (url, idx) {
    if (idx < 2) {
        return;
    }
    http.get(url, function (res) {
        let tmp = "";
        res.on('data', function (chunk) {
            tmp += chunk;
        });
        res.on('end', function () {
            cbCount += 1;
            results[idx] = tmp.toString();
            if(cbCount == 3) {
                results.forEach(function (s) {
                    console.log(s);
                });
            }
        });
        res.on('error', console.log);
    });
});