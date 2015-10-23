'use strict';
var dir = process.argv[2];
var ext = process.argv[3];
var mymodule = require('./mymodule.js');
mymodule(dir, ext, function (err, data) {
  if (err) {
    throw err;
  }
  data.forEach(function (file) {
    console.log(file);
  });
});
