/*jslint node*/
"use strict";
console.log(process.argv.reduce(function (prev, curr, idx) {
    return idx > 1
        ? prev + +curr
        : 0;
}));