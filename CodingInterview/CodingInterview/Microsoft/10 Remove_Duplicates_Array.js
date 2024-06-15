// MS INTERVIEW - 1ST ROUND
// Remove duplicates in sorted array
// I/p- {1,2,2,3,3,3,4,4,5}
// O/p - {1,2,3,4,5}

//FIRST TRY... so so *********************************
function RemoveDuplicates() {
    let arr = [1, 2, 2, 3, 3, 3, 4, 4, 5];
    let newarr = [];
    let prev = 0;

    for (let item of arr) {
        if (item != prev) {
            newarr.push(item);
        }
        prev = item;
    }

    console.log(arr);
    console.log(newarr);
}

//SECOND TRY ...so so *********************************
function RemoveDuplicates2() {
    let arr = [1, 2, 2, 3, 3, 3, 4, 4, 5];
    let strvalues = '';
    let prev = 0;

    for (let item of arr) {
        if (item != prev) {
            strvalues += `${item}|`;
        }
        prev = item;
    }

    console.log(arr);
    arr = strvalues.split('|');

    console.log(arr);
}

//THIRD TRY...SOOOO BAD :(
// let arr = [1,2,2,3,3,3,4,4,5];
// 		  //1,2,0,3,0,0,4,0,5
//         //1,2,3,4,5
// let prev = 0;

// for(let item of arr)
// {
//   if(item === prev){
//     item = 0;
//   }
//   prev = item;
// }

// console.log(arr);
// arr = arr.map(el=> el > 0);
// console.log(arr);


//GOOD ONE (AFTER INTERVIEW) =(

function RemoveDuplicates3() {
    var arr = [1, 2, 2, 3, 3, 3, 4, 4, 5];

    var uniq = arr.reduce((prev, cur) => {
        if (prev.indexOf(cur) < 0)
            prev.push(cur);
        return prev;
    }, []);

    console.log(uniq, arr);
}