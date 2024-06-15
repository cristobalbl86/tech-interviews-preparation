/*
UNIQUE STRINGS CHARACTERS.

In this Kata, you will be given two strings a and b and your task will be to return the characters that are not common in the two strings.

For example:
solve("xyab","xzca") = "ybzc" 
--The first string has 'yb' which is not in the second string. 
--The second string has 'zc' which is not in the first string. 
Notice also that you return the characters from the first string concatenated with those from the second string.
*/

function solve(a,b){
 let strret = '';
 
 for (let l of a){
   if(b.indexOf(l) < 0)
     strret += l;  
 }
 
 for (let l of b){
   if(a.indexOf(l) < 0)
     strret += l;  
 }
 
 return strret;
 
};

//Other solution:
function solve2(a,b){
 return (a+b).split("").filter(c => !a.includes(c) || !b.includes(c)).join("");
};


console.log(solve("xyab", "xzca")); //"ybzc"
console.log(solve("xyabb", "xzca")); //"ybbzc"
console.log(solve("abcd", "xyz")); //"abcdxyz"
console.log(solve("xxx", "xzca")); //"zca"
console.log(solve("Cristobal", "Carolina")); //"stbn"
console.log(solve("Lio", "Ivan")); //"lovan"