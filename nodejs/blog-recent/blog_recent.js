/*jslint es6, node*/ // jshint ignore:line
'use strict';
const http = require('http');
const fs = require('fs');

http.createServer(function (req, res) {
  if (req.url === '/') {
    fs.readFile('./titles.json', function (err, data) {
      if (err) return hadError(err, res);
      const titles = JSON.parse(data.toString());
      fs.readFile('./template.html', function (err, data) {
        if (err) return hadError(err, res);
        const tmpl = data.toString();
        const html = tmpl.replace('%', titles.join('</li><li>'));
        res.end(html);
      });
    });
  } 
}).listen(8000, '127.0.0.1');

function hadError(err, res) {
  console.error(err);
  res.end('Server Error');
}
