/*jslint node*/
"use strict";
var sum = process.argv.reduce(function (prev, curr, idx) {
    return idx > 1
        ? prev + +curr
        : 0;
});

console.log(sum);
