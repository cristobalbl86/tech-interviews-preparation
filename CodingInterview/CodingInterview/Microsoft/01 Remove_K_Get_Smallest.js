/*
 * MS INTERVIEW - 2ND ROUND
int number = 14312129 output = 11129;
int number = 1111 output = 1
int number = 110 output = 0

int k = 3;

Given a non - negative integer num represented as a int, remove k digits from the number so that the new number is the smallest possible.
*/

class ItemInfo {
    constructor(num, index, final) {
        this.num = num;
        this.index = index;
        this.final = final;
    }
}

function SmallestPossibleNumber(number, k) {
    let items = [];
    let idx = 0;
    let newnum = number.toString();
    let removed = 0;

    for (let n of number.toString().split('')) {
        let iteminfo = new ItemInfo(n, idx,
            number.toString().substr(0, idx) + number.toString().substr(idx + 1, number.toString().length));
        items.push(iteminfo);
        idx++;
    }

    console.log(items);

    items.sort((a, b) =>
        //a.final > b.final ? 1 : -1
        a.final - b.final 
    );

    console.log(items);

    for (let i in items) {
        idx = i.index - removed; //new index considering items removed
        newnum = newnum.substr(0, idx) + newnum.substr(idx + 1, newnum.length);
        removed++;

        if (removed === k) {
            break;
        }
    }

    return newnum;
}

console.log(SmallestPossibleNumber(14312129));

/*
SELECT TOP 3 SALARY
FROM TBLEMPLOYEE
ORDER BY SALARY DESC

Employee
//ID, NAME, SALARY
Personal Info
//ID, ADDRESS, SSN

SELECT E.ID, E.NAME, E.SALARY, I.ADDRESS, I.SSN
FROM TBLEMPLOYEE E
INNER JOIN TBLINFO I ON E.ID = I.ID
*/