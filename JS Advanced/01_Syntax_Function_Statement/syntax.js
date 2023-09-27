function validyCheckers(arr){
    let x1 = Number(arr[0]);
    let y1 = Number(arr[1]);
    let x2 = Number(arr[2]);
    let y2 = Number(arr[3]);
    let firstPointToCenter = Math.sqrt((0-x1)*(0-x1) + (0 - y1)*(0 - y1));
    let secondPointToCenter = Math.sqrt((0-x2)*(0-x2) + (0 - y2)*(0 - y2));
    let distanceBetweenTwoPoints = Math.sqrt((x2-x1)*(x2-x1) + (y2 - y1)*(y2 - y1));
    let IsValid = false;
    if (Number.isInteger(firstPointToCenter)) {
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    }else{
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }
    if (Number.isInteger(secondPointToCenter)) {
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    }else{
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }
    if (Number.isInteger(distanceBetweenTwoPoints)) {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    }else{
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }
}
validyCheckers(2, 1, 1, 1)

// 7.	Cooking by Numbers
//
// •	chop - divide the number by two
// •	dice - square root of number
// •	spice - add 1 to number
// •	bake - multiply number by 3
// •	fillet - subtract 20% from number

// function cooking(params) {
//     let n = parseInt(params[0]);

//     let functions = {
//         chop: (x) => x / 2,
//         dice: (x) => Math.sqrt(x),
//         spice: (x) =>x + 1,
//         bake: (x) => x * 3,
//         fillet: (x) => x * 0.80
//     }

//     for (let i = 1; i < params.length; i++) {
//         n = functions[params[i]](n)     
//         console.log(n);
//     }
// }

// cooking(['9', 'dice', 'spice', 'chop', 'bake', 'fillet']);


// 6.	Road Radar
//
// function roadRadar([speed, area]){
//
//     const limits = {
//         motorway: 130,
//         interstate: 90,
//         city: 50,
//         residential: 20
//     }

//     let calculateOverLimit = (limit, speed) => {
//         if (limit >= speed) {
//             console.log();
//             return;
//         }

//         let overLimit = speed - limit;
//         if (overLimit <= 20) {
//             console.log('speeding');            
//         }else if (overLimit <= 40) {
//             console.log('excessive speeding');            
//         }else if (overLimit > 40) {
//             console.log('reckless driving');            
//         }
//     };

//     switch (area) {
//         case 'motorway':
//             calculateOverLimit(limits[area], speed)
//             break;
//         case 'interstate':
//             calculateOverLimit(limits[area], speed)
//             break;
//         case 'city':
//             calculateOverLimit(limits[area], speed)
//             break;
//         case 'residential':
//             calculateOverLimit(limits[area], speed)
//             break;
//         default:
//             break;
//     }
// }

// roadRadar([200, 'motorway'])

//5.	Calorie Object
//
// function calorieObject(elements){
//     let result = {}
//     for (let i = 0; i < elements.length; i+= 2) {
//         result[elements[i]] = parseInt(elements[i + 1]);
        
//     }
//     return result;
// }

//4.	Time to Walk
//
// function timeToWalk(stepsCount, lenghtOfStep, speed){
//     let totalLenght = stepsCount * lenghtOfStep;
//     let breaksCount = Math.floor(totalLenght  / 500);
//     let totalTimeInSec = Math.ceil(((totalLenght / speed / 1000)* 60 + breaksCount) * 60);
//     let hour = Math.floor(totalTimeInSec / 3600);
//     let min = Math.floor(totalTimeInSec / 60);
//     let sec = totalTimeInSec - hour * 360 - min *  60;
//     let result = new Date(null, null, null, null, null, totalTimeInSec)
    
//     return result.toTimeString().split(' ')[0];
// }

//3.	Same Numbers
//
// function sameNumbers(number){
//     let numToString = number.toString().split('');
//     let IsSame = true;
//     let sum = 0;
//     for (let index = 0; index < numToString.length; index++) {
//         sum += Number(numToString[index]);
//         if (numToString[0] !== numToString[index]) {
//             IsSame = false;
//         }        
//     }
//     console.log(IsSame);
//     console.log(sum);
//  }


//2.	Greatest Common Divisor - GCD
//
// function gcd(a, b){
//     let copyA = a;
//     let copyB = b;
//     while (copyB !== 0) {
//         [copyA, copyB] = [copyB, copyA % copyB]
//     }

//     return copyA;
// }

//1.	Fruit
//
// function fruit(fruit, weight, money){
//     console.log(`I need $${(money * (weight / 1000)).toFixed(2)} to buy ${(weight / 1000).toFixed(2)} kilograms ${fruit}.`);
// }