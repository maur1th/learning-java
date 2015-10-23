/*jslint es6, node*/ // jshint ignore:line
'use strict';
var fs = require('fs');
var data = fs.readFileSync(process.argv[2]);
var lines = data.toString().split('\n').length - 1;
console.log(lines);