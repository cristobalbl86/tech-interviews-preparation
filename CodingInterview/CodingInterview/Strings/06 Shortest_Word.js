/*
SHORTEST WORD

Simple, given a string of words, return the length of the shortest word(s).
String will never be empty and you do not need to account for different data types.
*/

function findShort(s) {
        let warr = s.split(' ');
        let shorter = '';

        warr.forEach(e => {
            if (shorter === '') {
                shorter = e;
            } else if (shorter.length > e.length) {
                shorter = e;
            }
        });

        return shorter.length;
}



//OTHER SOLUTIONS(BP)
function findShort(s) {
    return Math.min(...s.split(" ").map(s => s.length));
}

/*
 TEST CASES
Test.describe("Example tests", _ => {
    Test.assertEquals(findShort("bitcoin take over the world maybe who knows perhaps"), 3);
    Test.assertEquals(findShort("turns out random test cases are easier than writing out basic ones"), 3);
});
 */