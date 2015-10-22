'use strict';
const events = require('events');
const util = require('util');
const fs = require('fs');

const watchDir = './watch';
const processedDir = './done';

function Watcher(watchDir, processedDir) {
  this.watchDir = watchDir;
  this.processedDir = processedDir;
}

util.inherits(Watcher, events.EventEmitter);

Watcher.prototype.watch = function() {
  const watcher = this;
  fs.readdir(this.watchDir, function (err, files) {
    if (err) throw err;
    files.forEach(function (file) {
      watcher.emit('process', file);
    });
  });
};

Watcher.prototype.start = function() {
  const watcher = this;
  fs.watchFile(watchDir, function () {
    watcher.watch();
  });
};

const watcher = new Watcher(watchDir, processedDir);
watcher.on('process', function (file) {
  const watchFile = this.watchDir + '/' + file;
  const processedFile = this.processedDir + '/' + file.toLowerCase();

  fs.rename(watchFile, processedFile, function (err) {
    if (err) throw err;
  });
});

watcher.start();
