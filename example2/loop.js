(function () {
    var i = 0;

    function loop() {
        i = i + 1;
        console.log("Loop #" + i);
    }

    setInterval(loop, 1000);

    
})();