// 9.	Equal Neighbors

function solve(input){
    let countMatches = 0;
    for (let row = 0; row < input.length - 1; row++) {
        for (let col = 0; col < input[row].length - 1; col++) {
            if ((input[row][col] === input[row + 1][col]) || (input[row][col] === input[row][col + 1])) {
                countMatches++;
            }
        }
        if (input[row][input[row].length - 1] === input[row + 1][input[row + 1].length - 1]) {
            countMatches++;
        }
    }
    return countMatches;
}

console.log(solve(
    [[2, 2, 5, 7, 4],
    [4, 0, 5, 3, 4],
    [2, 5, 5, 4, 2]]   
));



// 8.	Diagonal Sums
// function solve(matrix){
//     let sumMainDiagonal = 0;
//     let sumSecondaryDiagonal = 0;

//     for (let i = 0; i < matrix[0].length; i++) {
//         sumMainDiagonal += +matrix[i][i]; 
//         sumSecondaryDiagonal += +matrix[i][matrix[0].length - 1 - i];
//     }
    
//     console.log(sumMainDiagonal + ' ' + sumSecondaryDiagonal); 
// }

// solve([[3, 5, 17],
//     [-1, 7, 14],
//     [1, -8, 89]]   
//    );



// 7.	Biggest Element
// function solve(input){
//     let arrayAllNumber = [];
//     input.forEach(element => {
//         element.forEach(el => arrayAllNumber.push(el));
//     });
//     let sortedArray = arrayAllNumber.sort((a, b) => b - a);
//     return sortedArray[0];
// }

// console.log(solve([[3, 5, 7, 12],
//     [-1, 4, 33, 2],
//     [8, 3, 0, 4]]
//    ));


// 6.	Smallest Two Numbers
// function solve(input){
//     let sorted = input.sort((a, b) => a - b);
//     console.log(`${sorted[0]} ${sorted[1]}`);
// }

// solve([3, 0, 10, 4, 7, 3]);

// 5.	Process Odd Numbers

// function solved(input){
//     let result = [];

//     for (let i = 0; i < input.length; i++) {
//         if (i % 2 !== 0) {
//             result.push((input[i] * 2));
//         }        
//     }

//     result.reverse();
//     console.log(result.join(' '));
// }

//     solved([3, 0, 10, 4, 7, 3]);


// 4.	Last K Numbers Sequence

// function solve(length, countSum){
//     let result = [1];
//     result.fill(0, 1, length);
//     for (let i = 1; i < length; i++) {
//         result.push(0);
//         let currentNumber = 0;
//         for (let j = 0; j <= countSum; j++) {
//             if ((i - j) >= 0) {
//                 currentNumber += +result[i - j];
//             }
//         }
//         result[i] = currentNumber;
//     }
//     console.log(result.join(' '));    
// }

// solve(8, 2);



// 3.	Negative / Positive Numbers

// function solve(input){
//     let result = [];
//     for (let i = 0; i < input.length; i++) {
//         if (input[i] < 0) {
//             result.unshift(input[i]);
//         }else{
//             result.push(input[i]);
//         }
//     }
//     result.forEach(x => console.log(x));
// }

// solve([3, -2, 0, -1]);




// 2.	Even Position Element

// function solve(input){
//     let filtered = [];
//     for (let i = 0; i < input.length; i++) {
//         if (i % 2 == 0) {
//             filtered.push(input[i]);
//         }        
//     }
//     return filtered.join(' ');
// }

// console.log(solve(['20', '30', '40']));


// 1.	Sum First Last

// function solve(input){
//     let result = 0;
//     result = Number(input[0]) + Number(input[input.length - 1]);
//     return result;
// }

// console.log(solve(['5', '10']));




// const myUsers = [
//     { name: 'chuloo', likes: 'grilled chicken' },
//     { name: 'chris', likes: 'cold beer' },
//     { name: 'sam', likes: 'fish biscuits' }
// ];
// const usersByFood = myUsers.map(item => {
//     const container = {};
//     container[item.name] = item.likes;
//     container.age = item.name.length * 10;
//     return container;
// });
// console.log(usersByFood);
