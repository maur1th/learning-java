/*jslint es6, node*/ // jshint ignore:line
'use strict';
const fs = require('fs');
fs.createReadStream(process.argv[2]).pipe(process.stdout);