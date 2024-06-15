/*COUNT THE NUMBER OF DUPLICATES

Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input 
string. The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

Example:
"abcde" -> 0 # no characters repeats more than once
"aabbcde" -> 2 # 'a' and 'b'
"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
"indivisibility" -> 1 # 'i' occurs six times
"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
"aA11" -> 2 # 'a' and '1'
"ABBA" -> 2 # 'A' and 'B' each occur twice

 */

//Solution #1
function duplicateCount(text) {

    let mapChar = {};
    let counts = 0;
    text = text.toLowerCase();
    for(let l of text) {
        if (mapChar[l]) {
            mapChar[l]++;
            if (mapChar[l] === 2)
                counts++;
        } else {
            mapChar[l] = 1;
        }
    }
    return counts;
}

//Solution #2
function duplicateCount_sol2(text) {
    return (text.toLowerCase().split('').sort().join('').match(/([^])\1+/g) || []).length;
}

//Solution #3
function duplicateCount_sol3(text) {
    return text.toLowerCase().split('').filter(function (val, i, arr) {
        return arr.indexOf(val) !== i && arr.lastIndexOf(val) === i;
    }).length;
}

console.log(duplicateCount('Indivisibilities'));