// 7.	City Markets

function solve(input){
    let parsedInput = input.reduce((acc, componentsInfo) => {
        let [town, product, salesInfo] = componentsInfo.split(' -> ').map(x => x.trim());
        let [amountOfSales, priceForOneUnit] = salesInfo.split(' : ').map(x => x.trim());
        let productTotalIncome = Number(amountOfSales) * Number(priceForOneUnit);

        if (!acc[town]) {
            acc[town] = {[product]: productTotalIncome};
            return acc;
        }
        if(!acc[town][product]){
            acc[town][product] = productTotalIncome;
            return acc;
        }

        acc[town][product] += productTotalIncome;

        return acc;
    }, {})


    for(let town in parsedInput){
        console.log(`Town - ${town}`);
        for(let product of Object.keys(parsedInput[town])){
            console.log(`$$$${product} : ${parsedInput[town][product]}`);            
        }
    }
}

solve(['Sofia -> Laptops HP -> 200 : 2000',
'Sofia -> Raspberry -> 200000 : 1500',
'Sofia -> Audi Q7 -> 200 : 100000',
'Montana -> Portokals -> 200000 : 1',
'Montana -> Qgodas -> 20000 : 0.2',
'Montana -> Chereshas -> 1000 : 0.3']
)


// 6.	Populations in Towns

// function solve(input){
//     let towns = {};
//     for(let row of input){
//         let args = row.split(' <-> ');
//         if (!towns.hasOwnProperty(args[0])) {
//             towns[args[0]] = 0;
//         }
//         towns[args[0]] += Number(args[1]);
//     }

//     for(let town in towns){
//         console.log(`${town} : ${towns[town]}`);
        
//     }
// }

// solve(['Sofia <-> 1200000',
// 'Montana <-> 20000',
// 'New York <-> 10000000',
// 'Washington <-> 2345000',
// 'Las Vegas <-> 1000000']
// )

// 5.	Count Words in a Text

// function solve([input]){
//     let words = input.split(/\W+/).filter((w => w != ""));
//     let obj = {};
//     for(let word of words){
//         if (!obj.hasOwnProperty(word)) {
//             obj[word] = 0;
//         }
//         obj[word]++;
//     }
//     console.log(JSON.stringify(obj));    
// }

// solve(["Far too slow, you're far too slow.]);



// 4.	Sum by Town

// function solve(input){
//     let towns = {};
//     for (let i = 0; i < input.length - 1; i += 2) {
//         let townKey = input[i];
//         let townIncome = input[i + 1];
//         if (!towns.hasOwnProperty(townKey)) {
//             towns[townKey] = 0;
//         }
//         towns[townKey] += Number(townIncome);
//     }
//     let result = JSON.stringify(towns);
//     console.log(result);
// }

// solve(['Sofia',
// '20',
// 'Varna',
// '3',
// 'Sofia',
// '5',
// 'Varna',
// '4']
// );



// 3.	From JSON to HTML Table
// function solve(input){

//     String.prototype.htmlEscape = function(){
//         return this.replace(/&/g, '&amp;')
//             .replace(/</g, '&lt;')
//             .replace(/>/g, '&gt;')
//             .replace(/"/g, '&quot;')
//             .replace(/'/g, '&#39;');
//     };
    
//     let result = "<table>\n";
//     let objArr = input;
//     result += '  <tr>';
//     Object.keys(objArr[1]).forEach(k => result += `<th>${k}</th>`);
//     result += '</tr>\n';

//     for(let obj of objArr){
//         result += '  <tr>';
//         Object.keys(obj).forEach(k => result += `<td>${String(obj[k]).htmlEscape()}</td>`);
//         result += '</tr>\n';
//     }
//     result += "</table>";   
//     console.log(result); 
// }

// solve([{"Name":"Pesho <div>-a","Age":20,"City":"Sofia"},{"Name":"Gosho","Age":18,"City":"Plovdiv"},{"Name":"Angel","Age":18,"City":"Veliko Tarnovo"}])

//[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]




// 2.	Score to HTML

// 100/100
// function solve(input) {
 
//     String.prototype.htmlEscape = function(){
//         return this.replace(/&/g, '&amp;')
//             .replace(/</g, '&lt;')
//             .replace(/>/g, '&gt;')
//             .replace(/"/g, '&quot;')
//             .replace(/'/g, '&#39;');
//     };
 
//     let result = "<table>\n  <tr><th>name</th><th>score</th></tr>\n";
//     let table = JSON.parse(input);
 
//     for (let record of table) {
//         result += `  <tr><td>${record.name.htmlEscape()}</td><td>${record.score}</td></tr>\n`;
//     }
 
//     result += "</table>";
//     return result;
// }

// ERROR
// function solve(input){

//     String.prototype.htmlEscape = function(){
//         return this.replace(/&/g, '&amp;')
//             .replace(/</g, '&lt;')
//             .replace(/>/g, '&gt;')
//             .replace(/"/g, '&quot;')
//             .replace(/'/g, '&#39;');
//     };

//     let objArray = JSON.parse(input);
//     let html = '<table>\n';
//     html += '   <tr><th>name</th><th>score</th></tr>';

//     for(let obj of objArray){
//         html += `  <tr><td>${obj.name.htmlEscape()}</td><td>${htmlEscape(obj.score)}</td></tr>\n`;
//     }
//     html += '</table>';

//     return(html);

    
// }
    // function htmlEscape(unsafe) {
    //     return unsafe.replace(/[&<"']/g, function(m) {
    //       switch (m) {
    //         case '&':
    //           return '&amp;';
    //         case '<':
    //           return '&lt;';
    //         case '"':
    //           return '&quot;';
    //         default:
    //           return '&#039;';
    //       }
    //     });
    //   };


//     // function htmlEscape(unsafe) {
//     //     return unsafe
//     //          .replace(/&/g, "&amp;")
//     //          .replace(/</g, "&lt;")
//     //          .replace(/>/g, "&gt;")
//     //          .replace(/"/g, "&quot;")
//     //          .replace(/'/g, "&#039;");
//     // }

//     // function htmlEscape(text) {
//     //     let map = { '"': '&quot;', '&': '&amp;',
//     //         "'": '&#39;', '<': '&lt;', '>': '&gt;' };
//     //     return text.replace(/[\"&'<>]/g, ch => map[ch]);
//     // }


//  solve([{"name":"Pesho","score":479},{"name":"Gosho","score":205}]);




// 1.	Towns to JSON

// function solve(input){
//     let towns = [];

//     for(let line of input.splice(1)){
//         let args = line.split('|').map((x) => x.trim());
//         let latitude = Number(args[2]).toFixed(2);
//         let longitude = Number(args[3]).toFixed(2);
//         let townObj = { Town: args[1], Latitude: Number(latitude), Longitude: Number(longitude)};
//         towns.push(townObj);
//     }
//     console.log(JSON.stringify(towns));    
// }

// solve(['| Town | Latitude | Longitude |',
// '| Sofia | 42.696552 | 23.32601 |',
// '| Beijing | 39.913818 | 116.363625 |']
// );


// function solve(input){
//     let json = JSON.stringify(input);

//     console.log(json);
//     let parsedJSON = JSON.parse(json);

//     console.log(parsedJSON);
    


// }

// solve([{"name":"Pesho","score":479},
// {"name":"Gosho","score":205}]
// );