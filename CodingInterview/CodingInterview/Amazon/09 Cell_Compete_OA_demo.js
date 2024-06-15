// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME FUNCTIONALITY WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY FUNCTION NEEDED
// FUNCTION SIGNATURE BEGINS, THIS FUNCTION IS REQUIRED
function cellCompete(states, days) {
    // WRITE YOUR CODE HERE 
    let lastdaystate = [];
    let tempstate = states;
    let idx = 1;
    while (idx <= days) {
        lastdaystate = [];

        for (let el = 0; el <= tempstate.length - 1; el++) {
            let adjcellp = tempstate[el - 1] ? tempstate[el - 1] : 0;
            let adjcelln = tempstate[el + 1] ? tempstate[el + 1] : 0;

            if (adjcellp === adjcelln) {
                lastdaystate.push(0);
            } else {
                lastdaystate.push(1);
            }
        }

        /*
        let lastdaystate = tempstate.reduce((prev, cur, i) => {
            
        }, []);
        */

        idx++;

        tempstate = lastdaystate;
    }

    return tempstate;

}
// FUNCTION SIGNATURE ENDS