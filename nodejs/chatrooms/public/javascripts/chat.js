/*jslint es6, node*/ // jshint ignore:line
'use strict';

var Chat = function (socket) {
    this.socket = socket;
};

Chat.prototype.sendMessage = function(room, text) {
    const message = {
        room: room,
        text: text
    };
    this.socket.emit('message', message);
};

Chat.prototype.changeRoom = function(room) {
    this.socket.emit('join', {
        newRoom: room
    });
};

Chat.prototype.processCommand = function(command) {
    const words = command.split(' ');
    command = words[0]
                .substring(1, words[0].length)
                .toLowerCase();
    // command = words.shift().slice(1).toLowerCase();
    let message = false;

    switch(command) {
        case 'join':
            words.shift();  // to delete
            const room = words.join(' ');
            this.changeRoom(room);
            break;
        case 'nick':
            words.shift();  // to delete
            const name = words.join(' ');
            this.socket.emit('nameAttempt', name);
            break;
        default:
            message = 'Unrecognized command.';
            break;
    }
    return message;
};
