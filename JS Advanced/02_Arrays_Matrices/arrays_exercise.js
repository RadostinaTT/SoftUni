



//7.	Magic Matrices

// judge 100 / 100
//
// function magicMatrices(matrix) {
//     let IsMagic = true;
//     let sum = 0;
//     matrix[0].forEach(x => sum += x);
//     for (let row = 1; row < matrix.length; row++) {
//         let rowSum = 0;
//         matrix[row].forEach(x => rowSum += x);
//         if (rowSum != sum)	IsMagic = false;
//     }
//     for (let col = 0; col < matrix[0].length; col++) {
//         let colSum = 0;
//         for (let row = 0; row < matrix.length; row++)
//             colSum += matrix[row][col];
//         if (colSum != sum)	IsMagic = false;
//     }
//     console.log( IsMagic);
// }

// judge 80/100
//
// function magicMatrice(input) {
//     let IsMagic = true;
//     let magicSum = input[0].reduce((a, b) => a + b, 0);

//     for (let row = 0; row < input.length; row++) {
//         let rowSum = input[row].reduce((a, b) => a + b, 0);

//         if (rowSum !== magicSum) {
//             IsMagic = false;
//             break;
//         }

//         let colSum = 0;
//         for (let col = 0; col < input[row].length; col++) {
//             colSum += input[row][col];
//         }

//         if (colSum !== magicSum) {
//             IsMagic = false;
//             break;
//         }
//     }

//     console.log(IsMagic);
// }

magicMatrices(
    [[1, 0, 0],
 [0, 0, 1],
 [0, 1, 0]]


)


// //6.	Sort an Array by 2 Criteria

// function sortArray(input){
//     const newArr = input.sort((a, b) => a.length - b.length || a.localeCompare(b)) ;

//     console.log(newArr.join('\n'));
// }

// sortArray(['alpha', 
// 'beta', 
// 'gamma']

// )



//5.	Extract Increasing Subsequence from an Array

// function increasingSubsequence(input = []){
//     let result = input.reduce((acc, currentElement) => {
//         const lastElement = acc[acc.length - 1];
//         if (currentElement >= lastElement || lastElement === undefined ) {
//             acc.push(currentElement);
//         }
//         return acc;
//     }, []);

//     console.log(result.join('\n'));
// }

// increasingSubsequence([1, 
//     3, 
//     8, 
//     4, 
//     10, 
//     12, 
//     3, 
//     2, 
//     24]
//     );



//4.	Rotate Array

// function rotation(input){
//     let rotation = Number(input.pop());
//     let result = input.slice(0);
//     rotation = rotation % result.length;

//     for (let index = 0; index < rotation; index++) {
//         result.unshift(result.pop());;
//     }
//     console.log(result.join(' '));
// }

// rotation(['Banana', 
// 'Orange', 
// 'Coconut', 
// 'Apple', 
// '15']
// )

//3.	Add and Remove Elements from an Array

// function addRemoveElementsFromArray(input){
//     let result = [];

//     for (let index = 0; index < input.length; index++) {
//         let command = input[index];

//         if (command === 'add') {
//             result.push(index + 1);
//         }else if (command === 'remove') {
//             result.pop();
//         }        
//     }
//     console.log(result.length > 0 ? result.join('\n') : 'Empty');
// }

// addRemoveElementsFromArray(
//     [
//         'add', 
//         'add', 
//         'remove', 
//         'add', 
//         'add'
//     ]

// );


//2. Print Every N-th Element from an Array 

/**
 *
 * @param {Array} input
 */

// function printN_thElement(input){
//     let step = Number(input.pop());

//     for (let index = 0; index < input.length; index+= step) {
//         console.log(input[index]);       
//     }
// }


// printN_thElement(['5', 
// '20', 
// '31', 
// '4', 
// '20', 
// '2']
// );

//1. Print an Array with a Given Delimiter
//
// function printWithDelimiter(input){
//     let separator = input.pop();
//     let result = input.join(separator);

//     console.log(result);
// }

// printWithDelimiter(['One', 
// 'Two', 
// 'Three', 
// 'Four', 
// 'Five', 
// '-']
// );
