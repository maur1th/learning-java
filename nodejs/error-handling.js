'use strict';
const events = require('events');
const myEmitter = new events.EventEmitter();

myEmitter.on('error', function (err) {
  console.log('ERROR: ' + err.message);
});
myEmitter.emit('error', new Error('Something went wrong'));
