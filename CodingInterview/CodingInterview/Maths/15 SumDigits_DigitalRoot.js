﻿/*
 * Sum of Digits / Digital Root
 * 
Digital root is the recursive sum of all the digits in a number.

Given n, take the sum of the digits of n.If that value has more than one digit, continue reducing in this way until a single - digit number is produced.This is only applicable to the natural numbers.

    Examples
16  -- > 1 + 6 = 7
942  -- > 9 + 4 + 2 = 15  -- > 1 + 5 = 6
132189  -- > 1 + 3 + 2 + 1 + 8 + 9 = 24  -- > 2 + 4 = 6
493193  -- > 4 + 9 + 3 + 1 + 9 + 3 = 29  -- > 2 + 9 = 11  -- > 1 + 1 = 2
*/

function digital_root(n) {
    // ...
    return SumDig(n);
}

function SumDig(num) {
    if (num.toString().length == 1)
        return parseInt(num);

    let result = num.toString().split('').reduce((prev, cur) => {
        return prev += parseInt(cur);
    }, 0);

    return SumDig(result);

}


/*
 Test.assertEquals( digital_root(16), 7 )
Test.assertEquals( digital_root(456), 6 )
 */