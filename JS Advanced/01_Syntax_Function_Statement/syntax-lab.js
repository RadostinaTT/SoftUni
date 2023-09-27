
// 8.	Aggregate Elements

function solve(array){
    let sum = 0;
    let sumInvert = 0;
    let concat = '';
    for (let i = 0; i < array.length; i++) {
        sum += +array[i];
        sumInvert += 1/+array[i];
        concat += array[i];        
    }

    console.log(sum);
    console.log(sumInvert);
    console.log(concat);
}

solve([1, 2, 3])



// 7.	Day of Week
// function dayOfWeek(input){
//     let result;
//     switch (input) {
//         case 'Monday': result = 1; break;
//         case 'Tuesday': result = 2; break;
//         case 'Wednesday': result = 3; break;
//         case 'Thursday': result = 4; break;
//         case 'Friday': result = 5; break;    
//         case 'Saturday': result = 6; break;    
//         case 'Sunday': result = 7; break;    
//         default: result = 'error';  break;
//     }
//     return result;
// }

// console.log(dayOfWeek('rdaa'));




// 6.	Square of Stars

// function printStars(num){
//     for (let i = 0; i < num; i++) {
//         console.log("* ".repeat(num));        
//     }
// }

// printStars(5)



// 5.	Circle Area

// function solve(input){
//     let typeOfInput = typeof(input);
    
//     if (typeOfInput === 'number') {
//         let area = ((input**2) * Math.PI).toFixed(2);
//         console.log(area);        
//     }else{
//         console.log(`We can not calculate the circle area, because we receive a ${typeOfInput}.`);        
//     }    
// }

// solve('name')



// 4.	Largest Number

// function solve(num1, num2, num3){
//     let result = Math.max(num1, num2, num3);
//     console.log(`The largest number is ${result}.`);    
// }

// solve(-3, -5, -22.5);




// 3.	Sum of Numbers N…M

// function solve(start, end){
//     let result =  0;
//     for (let index = Number(start); index <= Number(end); index++) {
//         result += index;
//     }
//     console.log(result);    
// }

// solve('-8', '20')




// 2.	Math Operations

// function solve(num1, num2, operator){
//     let result = 0;
//     switch (operator) {
//         case '+':
//             result = num1 + num2;
//             break;
//         case '-':
//             result = num1 - num2;
//             break;
//         case '*':
//             result = num1 * num2;
//             break;
//         case '/':
//             result = num1 / num2;
//             break;
//         case '**':
//             result = num1 ** num2;
//             break;
//         case '%':
//             result = num1 % num2;
//             break;
//         default:
//             break;
//     }
//     console.log(result);
// }

// solve(3, 5.5, '*')



// 1.	String Length

// function solve(input1, input2, input3){
//     let sum = 0;
//     let averageLength;
//     sum += input1.length;
//     sum += input2.length;
//     sum += input3.length;

//     console.log(sum);
//     averageLength = Math.round( sum / 3);
//     console.log(averageLength); 
// }

// solve('chocolate', 'ice cream', 'cake');