/*
Highest and lowest

In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
    Example:
highAndLow("1 2 3 4 5");  // return "5 1"
highAndLow("1 2 -3 4 5"); // return "5 -3"
highAndLow("1 9 3 4 -5"); // return "9 -5"
Notes:
•	All numbers are valid Int32, no need to validate them.
•	There will always be at least one number in the input string.
•	Output string must be two numbers separated by a single space, and highest number is first.

*/



function highAndLow(numbers) {

    ////Solution #1 ***************************************
    //return numbers.split(' ').reduce((prev, cur) => {
    //    if (prev.length > 0) {
    //        if (parseInt(cur) > parseInt(prev[0])) {
    //            prev[0] = cur;
    //        } else if (parseInt(cur) < parseInt(prev[1])) {
    //            prev[1] = cur;
    //        }
    //    } else {
    //        prev[0] = cur;
    //        prev[1] = cur;
    //    }
    //    return prev;
    //}, []).join(' ');


    //Solution #2 ***************************************
    let sorted = numbers.split(' ').sort((a, b) => {
        return a - b; //for numbers
    });
    return sorted[sorted.length - 1] + ' ' + sorted[0];
}

//OTHER SOLUTIONs(BEST PRACTICE) ***************************************
function highAndLow2(numbers) {
    numbers = numbers.split(' ');
    return `${Math.max(...numbers)} ${Math.min(...numbers)}`;
}

console.log(highAndLow("4 5 29 54 4 0 -214 542 -64 1 -3 6 -6")); //"542 -214"