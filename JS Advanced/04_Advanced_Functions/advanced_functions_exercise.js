// 5.	Breakfast Robot

function breakfast(){
    const products = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0,
    };

    return function breakfastRobot(input){
        const [command, product, quantity] = input.split(' ').map(x => x.trim());

        const recepies = {
            apple: {
                carbohydrate: 1,
                flavour: 2,
            },
            lemonade: {
                carbohydrate: 10,
                flavour: 20,
            },
            burger: {
                carbohydrate: 5,
                fat: 7,
                flavour: 3,
            },
            eggs: {
                protein: 5,
                fat: 1,
                flavour: 1,
            },
            turkey: {
                protein: 10,
                carbohydrate: 10,
                fat: 10,
                flavour: 10,
            },
        };

        function restock(product, quantity){
            products[product] += Number(quantity);
            return 'Success';
        }

        function prepare(recepie, quantity){
            //let ingredientMissing = [];
            for(let ingridient in recepies[recepie]){
                const neededQuantity = recepies[recepie][ingridient] * Number(quantity);
                if (neededQuantity > products[ingridient]) {
                    return `Error: not enough ${ingridient} in stock`
                }else{
                    products[ingridient] -= neededQuantity;
                    
                }
            }
            return 'Success';
        }

        function report(){
            return `protein=${products.protein} carbohydrate=${products.carbohydrate} fat=${products.fat} flavour=${products.flavour}`
        }
        
        if (command === 'restock') {
            return restock(product, quantity);
        }else if(command === 'prepare'){
            return prepare(product, quantity);
        }else{
            return report();
        }        
    }    
}

let rob = breakfast();
console.log(rob ('restock carbohydrate 10'));
console.log(rob ('restock flavour 10'));
console.log(rob ('prepare apple 1'));
console.log(rob ('restock fat 10'));
console.log(rob ('prepare burger 1'));
console.log(rob ('report'))




// function solution() {
 
//     const products = {
//         protein: 0,
//         carbohydrate: 0,
//         fat: 0,
//         flavour: 0,
//     };
 
//     return function breakfastRobot(input) {
//         const [command, currentProduct, amount] = input.split(' ');
 
//         const recepiesMenu = {
//             apple: {
//                 carbohydrate: 1,
//                 flavour: 2,
//             },
//             lemonade: {
//                 carbohydrate: 10,
//                 flavour: 20,
//             },
//             burger: {
//                 carbohydrate: 5,
//                 fat: 7,
//                 flavour: 3,
//             },
//             eggs: {
//                 protein: 5,
//                 fat: 1,
//                 flavour: 1,
//             },
//             turkey: {
//                 protein: 10,
//                 carbohydrate: 10,
//                 fat: 10,
//                 flavour: 10,
//             },
//         };
 
//         function restock(product, quantity) {
//             (products[product] += Number(quantity));
//             return 'Success';
//         }
           
//         function prepare(recepie, quantity) {
//             const ingredientsNeeded = JSON.parse(
//                 JSON.stringify(recepiesMenu[recepie]),
//             );
//             let canMake = true;
//             const missingIngredients = [];
 
//             Object.keys(ingredientsNeeded).forEach(ingredient => {
//                 if (
//                     products[ingredient] <
//                     ingredientsNeeded[ingredient] * quantity
//                 ) {
//                     missingIngredients.push(ingredient);
//                     canMake = false;
//                 }
//             });
 
//             if (canMake) {
//                 Object.keys(ingredientsNeeded).forEach(ingredient => {
//                     products[ingredient] -=
//                         ingredientsNeeded[ingredient] * quantity;
//                 });
 
//                 return 'Success';
//             }
 
//             return `Error: not enough ${missingIngredients[0]} in stock`;
//         }
 
//         function report(obj) {
//             const currentReport = Object.entries(obj).reduce((acc, value) => {
//                 acc.push(`${value[0]}=${value[1]}`);
 
//                 return acc;
//             }, []);
 
//             return currentReport.join(' ');
//         }
 
//         if (command === 'restock') {
//             return restock(currentProduct, amount);
//         } else if (command === 'prepare') {
//             return prepare(currentProduct, amount);
//         } else {
//             return report(products);
//         }
//     };
// }
// let rob = solution();
// console.log(rob ('restock carbohydrate 10'));
// console.log(rob ('restock flavour 10'));
// console.log(rob ('prepare apple 1'));
// console.log(rob ('restock fat 10'));
// console.log(rob ('prepare burger 1'));
// console.log(rob ('report'))



// function solution() {
//     const products = {
//         protein: 0,
//         carbohydrate: 0,
//         fat: 0,
//         flavour: 0
//     }
//     const meals = {
//         apple: { carbohydrate: 1, flavour: 2 },
//         lemonade: { carbohydrate: 10, flavour: 20 },
//         burger: { carbohydrate: 5, fat: 7, flavour: 3 },
//         eggs: { protein: 5, fat: 1, flavour: 1 },
//         turkey: { protein: 10, carbohydrate: 10, fat: 10, flavour: 10 }
//     }
 
//     return function action (str) {
//         let array=str.split(' ');
//         let toDo = array[0];
 
//         if (toDo === 'restock') {
//             let product = array[1];
//             let quantity = Number(array[2]);
//             products[product] += quantity;
//             return 'Success';
//         } else if (toDo === 'prepare') {
//             let meal = array[1];
//             let quantity = Number(array[2]);
//             for (let ingredient in meals[meal]) {
//                 const neededQuantity = meals[meal][ingredient] * quantity;
//                 if (neededQuantity > products[ingredient]) {
//                     return `Error: not enough ${ingredient} in stock`;
//                 } else {
//                     const neededQuantity = meals[meal][ingredient] * quantity;
//                     products[ingredient] -= neededQuantity;
//                     return 'Success';
//                 }
//             }
//         } else if (toDo === 'report') {
//             return `protein=${products.protein} carbohydrate=${products.carbohydrate} fat=${products.fat} flavour=${products.flavour}`;
//         }
//     }
// }
// let rob = solution();
// console.log(rob ('restock carbohydrate 10'));
// console.log(rob ('restock flavour 10'));
// console.log(rob ('prepare apple 1'));
// console.log(rob ('restock fat 10'));
// console.log(rob ('prepare burger 1'));
// console.log(rob ('report'))



// function solution() {
//     let ingredients = {};
//     ingredients['protein'] = 0;
//     ingredients['carbohydrate'] = 0;
//     ingredients['fat'] = 0;
//     ingredients['flavour'] = 0;


//     function restock([microelement, quantity]) {
//         quantity = Number(quantity);
//         ingredients[microelement] += quantity;
//          return "Success";
//     }

//     function prepare([recipe, quantity]) {
//         quantity = Number(quantity);
//         let message = "";
//         switch (recipe) {
//             case "apple":
//                 if (ingredients['flavour'] < quantity * 2) {
//                     message =  "Error: not enough flavour in stock";
//                 }
//                 if (ingredients['carbohydrate'] < quantity) {
//                     message =  "Error: not enough carbohydrate in stock";
//                 }

//                 if (message == "") {
//                     ingredients['flavour'] -= quantity * 2;
//                     ingredients['carbohydrate'] -= quantity;
//                     return "Success";
//                 }
//                 return message;

//                 break;
//             case "coke":
//                 if (ingredients['flavour'] < quantity * 20) {
//                     message = "Error: not enough flavour in stock";
//                 }
//                 if (ingredients['carbohydrate'] < quantity * 10) {
//                     message = "Error: not enough carbohydrate in stock";
//                 }
//                 if (message == "") {
//                     ingredients['flavour'] -= quantity * 20;
//                     ingredients['carbohydrate'] -= quantity * 10;
//                     return "Success";
//                 }
//                 return message;
//                 break;
//             case "burger":
//                 if (ingredients['flavour'] < quantity * 3) {
//                     message = "Error: not enough flavour in stock";
//                 }
//                 if (ingredients['fat'] < quantity * 7) {
//                     message = "Error: not enough fat in stock";
//                 }
//                 if (ingredients['carbohydrate'] < quantity * 5) {
//                     message = "Error: not enough carbohydrate in stock";
//                 }
//                 if (message == "") {
//                     ingredients['flavour'] -= quantity * 3;
//                     ingredients['fat'] -= quantity * 7;
//                     ingredients['carbohydrate'] -= quantity * 5;
//                     return "Success";
//                 }
//                 return message;
//                 break;
//             case "omelet":
//                 if (ingredients['flavour'] < quantity) {
//                     message = "Error: not enough flavour in stock";
//                 }
//                 if (ingredients['fat'] < quantity) {
//                     message = "Error: not enough fat in stock";
//                 }
//                 if (ingredients['protein'] < quantity * 5) {
//                     message = "Error: not enough protein in stock";
//                 }
//                 if (message == "") {
//                     ingredients['flavour'] -= quantity;
//                     ingredients['fat'] -= quantity;
//                     ingredients['protein'] -= quantity * 5;
//                     return "Success";
//                 }
//                 return message;
//                 break;
//             case "cheverme":
//                 if (ingredients['flavour'] < quantity * 10) {
//                     message = "Error: not enough flavour in stock";
//                 }
//                 if (ingredients['fat'] < quantity * 10) {
//                     message = "Error: not enough fat in stock";
//                 }
//                 if (ingredients['carbohydrate'] < quantity * 10) {
//                     message = "Error: not enough carbohydrate in stock";
//                 }
//                 if (ingredients['protein'] < quantity * 10) {
//                     message = "Error: not enough protein in stock";
//                 }
//                 if (message == "") {
//                     ingredients['flavour'] -= quantity * 10;
//                     ingredients['fat'] -= quantity * 10;
//                     ingredients['carbohydrate'] -= quantity * 10;
//                     ingredients['protein'] -= quantity * 10;
//                     return "Success";
//                 }
//                 return message
//                 break;
//         }
//     }

//     function report() {
//         return `protein=${ingredients['protein']} carbohydrate=${ingredients['carbohydrate']} fat=${ingredients['fat']} flavour=${ingredients['flavour']}`;
//     }

//     return function (command) {

//         let tokens = command.split(' ');
//         let action = tokens.shift();
//         switch (action) {
//             case "prepare":
//                 return prepare(tokens);
//                 break;
//             case "restock":
//                 return restock(tokens);
//                 break;
//             case "report":
//                 return report();
//         }
//     }
// };

// let rob = solution();
// console.log(rob ('restock carbohydrate 10'));
// console.log(rob ('restock flavour 10'));
// console.log(rob ('prepare apple 1'));
// console.log(rob ('restock fat 10'));
// console.log(rob ('prepare burger 1'));
// console.log(rob ('report'))



//4.	Vector Math
// (() => {
//     let add = (vec1, vec2) => [vec1[0]+vec2[0], vec1[1]+vec2[1]];
//     let multiply = (vec1, scalar) => [vec1[0] * scalar, vec1[1] * scalar];
//     let length = (vec1) => Math.sqrt(Math.pow(vec1[0], 2) + Math.pow(vec1[1], 2));
//     let dot = (vec1, vec2) => vec1[0] * vec2[0] + vec1[1] * vec2[1];
//     let cross = (vec1, vec2) => vec1[0] * vec2[1] - vec1[1] * vec2[0];

//     return {add, multiply, length, dot, cross};
// })();


//3.	Personal BMI 
// function bmi(name, age, weight, heightCM){
//     let output = {
//         name,
//         personalInfo:{
//             age,
//             weight,
//             height: heightCM
//         }
//     }
//     let heightM = heightCM / 100;

//     let bmi = Math.round( weight /  (heightM ** 2));
//     output['BMI'] = bmi;
    
//     if (bmi < 18.5) {
//         output.status = 'underweight';
//     }else if (bmi < 25) {
//         output.status = 'normal';
//     }else if (bmi < 30) {
//         output.status = 'overweight';
//     }else if (bmi >= 30) {
//         output.status = 'obese';
//         output.recommendation = 'admission required';
//     }

// return output;
// }
// console.log(bmi("Peter", 29, 75, 182));






// 2.	Argument Info

// function argumentSort(...input){
//     const obj = {};

//     input.forEach(el => {
//         const inputType = typeof el;
//         console.log(`${typeof(el)}: ${el}`);    
        
//         if (!obj.hasOwnProperty(inputType)) {
//             obj[inputType] = 0;
//         }

//         obj[inputType]++;
//     });

//     Object.entries(obj)
//     .sort((a, b) => {
//         const [aKey, aValue] = a;
//         const [bKey, bValue] = b;

//         return bValue - aValue;
//     })
//     .forEach((el) => {
//         const [type, value] = el;
//         console.log(`${type} = ${value}`);
        
//     });
// }

// argumentSort('cat', 42, function () { console.log('Hello world!'); });


// 1.	Sort Array

// function sort(array, command){

//     let sortedArray = [];

//     if (command === 'asc') {
//         sortedArray = array.sort((a,b) => a-b);
//     }
//     else if(command === 'desc'){
//         sortedArray = array.sort((a,b) => b-a);
//     }
//     let result = [...sortedArray];
//     return sortedArray;
// }

// console.log(sort([14, 7, 17, 6, 8], 'desc'));

