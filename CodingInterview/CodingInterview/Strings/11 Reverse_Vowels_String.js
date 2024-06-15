
/********************* REVERSE VOWELS
 *INPUT: Cristobal | apple | Carolina
 OUTPUT: Crastobil | eppla | Carilona
 */

function IsVowel(letter) {
    switch (letter) {
        case 'a': case 'e': case 'i': case 'o': case 'u':
            return true;
            break;
        default:
            return false;
            break;
    }
}

let str = 'apple';
let vow = [];

for (let l of str) {
    if (IsVowel(l)) {
        vow.push(l);
    }
}

let idx = vow.length - 1;
var newstr = str.split('').map(cur => {
    if (vow.indexOf(cur) >= 0) {
        return vow[idx--];
    } else {
        return cur;
    }
});

//console.log(test('r'));
//console.log(IsVowel('u'));
console.log(newstr.join(''));