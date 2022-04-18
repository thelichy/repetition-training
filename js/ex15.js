function triangle(side) {

    for(let i = 1; i <= side; i++) {

        for(let ii = 1; ii <= i; ii++) {
            process.stdout.write('* ')
        }
        console.log();
    }
};

triangle(7);