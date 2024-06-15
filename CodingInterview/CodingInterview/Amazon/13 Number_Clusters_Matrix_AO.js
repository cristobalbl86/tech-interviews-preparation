// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME FUNCTIONALITY WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY FUNCTION NEEDED
// FUNCTION SIGNATURE BEGINS, THIS FUNCTION IS REQUIRED
function numberAmazonGoStores(rows, column, grid) {
    // WRITE YOUR CODE HERE
    let groups = {};
    let clusters = 0;
    for (let row = 0; row < rows; row++) {
        for (let col = 0; col < column; col++) {
            if (grid[row][col] === 1) {
                console.log(row, col);
                console.log(checkAdj(row, col, grid, rows, column));
                if (checkAdj(row, col, grid, rows, column) === false) {
                    /*
                    if(groups[clusters+1]){
                        groups[clusters+1] += ` ${row},${col}`;
                    }else{
                        groups[clusters+1] = `${row},${col}`;
                    }
                    */
                    clusters++;
                    //}else{
                    //    console.log('increaded closture');
                    //    clusters++;
                    //    groups[clusters+1] = `${row},${col}`;
                }
            }
        }
    }

    return clusters;
}


function checkAdj(r, c, grid, rows, columns) {

    //check left
    if ((c === 0 ? false : grid[r][c - 1] === 1) ||
        (c === columns - 1 ? false : grid[r][c + 1] === 1) ||
        (r === 0 ? false : grid[r - 1][c] === 1) ||
        (r === rows - 1 ? false : grid[r + 1][c] === 1)) {
        return true;
    } else { return false; }
}
// FUNCTION SIGNATURE ENDS

//#########################################################################
/*
Given a 2d grid map of '1's(land) and '0's(water), count the number of islands.An island is surrounded by water and is formed by connecting 
adjacent lands horizontally or vertically.You may assume all four edges of the grid are all surrounded by water.

    Example 1:
Input:
11110
11010
11000
00000

Output: 1

Example 2:
Input:
11000
11000
00100
00011

Output: 3
*/
/*
Runtime: 76 ms, faster than 50.94% of JavaScript online submissions for Number of Islands.
Memory Usage: 36.4 MB, less than 97.67% of JavaScript online submissions for Number of Islands.
*/

//DFS in MATRIZ
var numIslands = function (grid) {
    const H = grid.length;
    const W = grid[0].length; //H && grid[0].length;
    let count = 0;

    for (let r = 0; r < H; r++) {
        for (let c = 0; c < W; c++) {
            if (grid[r][c] === '0') continue;

            //Increase counter when found a '1', and then verify its adjacents
            count++;
            dfs(r, c);
        }
    }
    return count;

    //Recursive function to set all adjacent to '0'
    function dfs(r, c) {
        if (r < 0 || c < 0 || r === H || c === W) return;
        if (grid[r][c] === '0') return;

        grid[r][c] = '0';
        dfs(r - 1, c);
        dfs(r + 1, c);
        dfs(r, c - 1);
        dfs(r, c + 1);
    }
};