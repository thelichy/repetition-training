function Square(side) {
    for (let row = 0; row < side; row++) {
        for (let i = 0; i < side; i++) {
            process.stdout.write('* ');
        }
        console.log();
    }
}

Square(4);