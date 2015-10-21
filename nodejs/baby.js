/*jslint es6, node*/ // jshint ignore:line
'use strict';
console.log(process.argv.reduce(function (prev, curr, idx) {
    return idx > 1 ? prev + (+curr) : 0;
}));