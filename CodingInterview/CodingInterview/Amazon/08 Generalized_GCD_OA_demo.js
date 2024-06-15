// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME FUNCTIONALITY WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY FUNCTION NEEDED
// FUNCTION SIGNATURE BEGINS, THIS FUNCTION IS REQUIRED

function generalizedGCD(num, arr) {
    let maxdiv = 0;
    let maxval = Math.max(...arr);
    let tempdiv = 0;
    // WRITE YOUR CODE HERE 

    for (let x = 1; x <= maxval; x++) {
        for (let el of arr) {
            if (el % x === 0) {
                tempdiv = x;
            } else {
                tempdiv = 0;
                break;
            }
        }

        if (tempdiv !== 0) {
            maxdiv = tempdiv;
        }
    }

    return maxdiv;
}
// FUNCTION SIGNATURE ENDS