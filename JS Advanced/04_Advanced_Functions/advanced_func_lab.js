// function add(num){
//     var add = num;
//     function solution(input){
//         add += input;
//         return solution;
//     }
//     solution.toString = function(){
//         return add
//     };
//     return solution;
// }
// console.log(add(1).toString()); // 1
// console.log(add(2)(3).toString()); // 5
// console.log(add(1)(1)(1)(1)(1).toString()); // 5
// console.log(add(1)(0)(-1)(-1).toString()); // -1



// function solution(input){
//     return function(numToAdd){
//         return input + numToAdd;
//     }
// }

// let add5 = solution(5);
// console.log(add5(2));
// console.log(add5(3));

function result(currencyFormatter){
    let separator = ","
    let = symbol = "$"
    let = symbolFirst = true

    let dollarFormatter = value => currencyFormatter(separator, symbol, symbolFirst, value);
    return dollarFormatter;
}


function currencyFormatter(separator, symbol, symbolFirst, value) {
    let result = Math.trunc(value) + separator;
    result += value.toFixed(2).substr(-2,2);
    if (symbolFirst) return symbol + ' ' + result;
    else return result + ' ' + symbol;
}

 

let dollarFormatter = result(currencyFormatter);
console.log(dollarFormatter(5345));   // $ 5345,00
console.log(dollarFormatter(3.1429)); // $ 3,14
console.log(dollarFormatter(2.709));  // $ 2,71


