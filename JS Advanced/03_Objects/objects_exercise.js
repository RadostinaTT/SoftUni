//8.	Unique Sequences

// function sequences(input) {
//     let parsedInput = [];

//     for (let line of input) {
//         let arr = JSON.parse(line);
//         parsedInput.push(arr.map(Number).sort((a, b) => b - a));
//     }

//     for (let i = 0; i < parsedInput.length; i++) {
//         let IsEqual = false;
//         for (let j = i + 1; j < parsedInput.length; j++) {
//             if (compareArrays(parsedInput[i], parsedInput[j])) {
//                     parsedInput.splice(j, 1);
//                     j--;
            
//             }
//         }
//     }

    
//     parsedInput.sort((a, b) => a.length - b.length)
//     parsedInput.forEach(a => console.log("[" + a.join(", ") + "]"));

//     function compareArrays(arr1, arr2) {
//         if(arr1.length != arr2.length) {
//             return false;
//         } else {
//             for(let i=0; i<arr1.length; i++) {
//                 if(arr1[i] != arr2[i]){
//                     return false;
//                 }
//             }
//             return true;
//         }
//     }
// }
// sequences([
//     "[-3, -2, -1, 0, 1, 2, 3, 4]",
//     "[10, 1, -17, 0, 2, 13]",
//     "[4, -3, 3, -2, 2, -1, 1, 0]"]
// )


// 7.	Usernames

// function sortSet(input){
//     let uniqueArr = [...new Set(input)];

//     let sortedArr = uniqueArr.sort((a, b) => {
//             return a.length - b.length || a.localeCompare(b);
//     }).forEach( x => console.log(x)); 
// }

// sortSet(['Ashton',
// 'Kutcher',
// 'Ariel',
// 'Lilly',
// 'Keyden',
// 'Aizen',
// 'Billy',
// 'Braston']
// );



// 6.	System Components

// function components(input){
//     let parsedInput = input.reduce((acc, componentsInfo) => {
//         let [systemName, componentName, subcomponentName] = componentsInfo.split(' | ').map(x => x.trim());

//         if (!acc[systemName]) {
//             acc[systemName] = {[componentName]: [subcomponentName]};
//             return acc;
//         }

//         if (!acc[systemName][componentName]) {
//             acc[systemName][componentName] = [subcomponentName];
//             return acc;
//         }

//         acc[systemName][componentName] = [...acc[systemName][componentName], subcomponentName];

//         return acc;
//     }, {})

//     let sortedSystem = Object.keys(parsedInput).sort((a,b) => {
//         if (Object.keys(parsedInput[a]).length !== Object.keys(parsedInput[b]).length) {
//             return Object.keys(parsedInput[b]).length - Object.keys(parsedInput[a]).length;
//         }
//         return (a.toLowerCase()).localeCompare(b.toLowerCase());
//     })

//     for(let system of sortedSystem) {
//         console.log(system);
//         let sortedComponents = Object.keys(parsedInput[system]).sort((a , b) => {
//             return Object.keys(parsedInput[system][b]).length - Object.keys(parsedInput[system][a]).length
//         })

//         for(let component of sortedComponents) {
//             console.log(`|||${component}`);
//             parsedInput[system][component].forEach(sc => console.log(`||||||${sc}`))
//         }
//     }
// }


// components(['SULS | Main Site | Home Page',
// 'SULS | Main Site | Login Page',
// 'SULS | Main Site | Register Page',
// 'SULS | Judge Site | Login Page',
// 'SULS | Judge Site | Submittion Page',
// 'Lambda | CoreA | A23',
// 'SULS | Digital Site | Login Page',
// 'Lambda | CoreB | B24',
// 'Lambda | CoreA | A24',
// 'Lambda | CoreA | A25',
// 'Lambda | CoreC | C4',
// 'Indice | Session | Default Storage',
// 'Indice | Session | Default Security']
// )

// 5.	Auto-Engineering Company
// function autoCompamy(input){
//     let parsedInput = input.reduce((acc, autoInfo) => {
//         let [carBrand, carModel, producedCars] = autoInfo.split(' | ').map(x => x.trim());

//         if (!acc[carBrand]) {
//             acc[carBrand] = { [carModel]: Number(producedCars)};
//             return acc;
//         }

//         if (!acc[carBrand][carModel]) {
//             acc[carBrand][carModel] = Number(producedCars);
//             return acc;
//         }

//         acc[carBrand][carModel] += Number(producedCars);

//         return acc;
//     }, {})

//     for(let car of Object.keys(parsedInput)){
//         console.log(car);
//         for(let component of Object.keys(parsedInput[car]))
//         console.log(`###${component} -> ${parsedInput[car][component]}` );

//     }
// }

// autoCompamy(['Mercedes-Benz | 50PS | 123',
//     'Mini | Clubman | 20000',
//     'Mini | Convertible | 1000',
//     'Mercedes-Benz | 60PS | 3000',
//     'Hyunday | Elantra GT | 20000',
//     'Mini | Countryman | 100',
//     'Mercedes-Benz | W210 | 100',
//     'Mini | Clubman | 1000',
//     'Mercedes-Benz | W163 | 200']
// )


// 4.	Store Catalogue

// function catalog(input){
//     let parsedInput = input.reduce((acc, productInfo) => {
//         let[productName, price] = productInfo.split(' : ').map( x => x.trim());

//         if (acc[productName[0]]) {
//             acc[productName[0]] = [...acc[productName[0]], productInfo]
//         }else{
//             acc[productName[0]] = [productInfo]
//         }
//         return acc;
//     }, {})

//     Object.keys(parsedInput).sort().map(x => {
//         console.log(x)

//         parsedInput[x].sort().map(product => {
//             console.log(` ${product.split(' : ').join(': ')}`)            
//         })
//     })
// }

// catalog(['Appricot : 20.4',
// 'Fridge : 1500',
// 'TV : 1499',
// 'Deodorant : 10',
// 'Boiler : 300',
// 'Apple : 1.25',
// 'Anti-Bug Spray : 15',
// 'T-Shirt : 10']
// )


// 3.	Cappy Juice

// function juiceFactory(input){
//     let parsedInput = input.reduce((acc, juiceKVP) => {
//         let [juiceName, juiceQuantity] = juiceKVP.split(' => ');

//         if (acc.currentJuiceQuantity[juiceName]) {
//             acc.currentJuiceQuantity[juiceName] += +juiceQuantity;
//         }else{
//             acc.currentJuiceQuantity[juiceName] = +juiceQuantity;
//         }

//         let bottledJuices = Math.floor(acc.currentJuiceQuantity[juiceName] / 1000);

//         if (bottledJuices > 0 && !acc.completedJuices.includes(juiceName)) {
//             acc.completedJuices.push(juiceName);
//         }

//         return acc;

//     }, { completedJuices: [], currentJuiceQuantity: {} })

//     parsedInput.completedJuices.map(juice => { 
//         console.log(`${juice} => ${Math.floor(parsedInput.currentJuiceQuantity[juice] / 1000)}`);
//     })
// }


// juiceFactory(['Kiwi => 234',
// 'Pear => 2345',
// 'Watermelon => 3456',
// 'Kiwi => 4567',
// 'Pear => 5678',
// 'Watermelon => 6789']
// );



// 2.	JSON’s Table
// function htmlTable(input){
//     let parsedInput = input.map(x => JSON.parse(x))

//     let createTable = content => `<table>${content}\n</table>`
//     let createRow = content => `\n	<tr>${content}\n	</tr>`
//     let createData = content => `\n		<td>${content}</td>`

//     let result =  parsedInput.reduce((accRows, row) => {
//         let tdForPerson = Object.values(row).reduce((accTd, td) => {
//             return accTd + createData(td)
//         }, '')
//         return accRows + createRow(tdForPerson)
//     }, '')
//     return createTable(result);  
// }

// console.log(htmlTable(['{"name":"Pesho","position":"Promenliva","salary":100000}',
// '{"name":"Teo","position":"Lecturer","salary":1000}',
// '{"name":"Georgi","position":"Lecturer","salary":1000}']
// )
// );



// 1.	 Heroic Inventory

// function heroicInventory(input){
//     return JSON.stringify(input.reduce((acc, heroString, i, arr) => {
//         let [name, level, items] = heroString.split(' / ');
//         acc.push({name, level: Number(level), items: items ? items.split(',').map(x => x.trim()) : []})
//         return acc;
//     }, []))
// }

// console.log(heroicInventory(['Isacc / 25 / Apple, GravityGun',
// 'Derek / 12 / BarrelVest, DestructionSword',
// 'Hes / 1 / Desolator, Sentinel, Antara']
// ));
