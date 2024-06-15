/*
 FIRST UNIQUE CHAR IN A STRING - LEET CODE
 */

//Given a string, find the first non - repeating character in it and return it's index. If it doesn't exist, return -1.
//Examples:
//s = "leetcode"
//return 0.

//s = "loveleetcode",
//return 2.


var firstUniqChar = function (s) {

    if (s.length === 0) return -1;

    let mapChar = {};
    let pos = -1;

    for (let c of s.split('')) {
        if (mapChar[c]) {
            mapChar[c] += 1;
        } else {
            mapChar[c] = 1;
        }
    }

    for (let k of Object.keys(mapChar)) {
        if (mapChar[k] === 1) {
            pos = s.indexOf(k);
            break;
        }
    }

    return pos;

};