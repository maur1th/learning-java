var sum = function () {
    var result = 0;
    return function (n) {
        result += +n;
        return (result);
    };
}();

for (var i = 2; i < process.argv.length; i++ ) {
    var result = sum(process.argv[i]);
}
console.log(result);
