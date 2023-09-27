// 2.	Person

class Person{
    constructor(fn, ln){
        this.firstName = fn,
        this.lastName = ln
        //this.fullName = () => {this.firstName + ' ' + this.lastName}
    }
    firstName(name){
        return this.firstName = name;
    }

    lastName(name1){
        return this.lastName = name1;
    }

    get fullName(){
        return this.firstName + ' ' + this.lastName;
    }

    set fullname(newName){
        let [newFN, newLN] = newName.split(' ').map(x => x.trim());
        if(newFN && newLN){
            this._firstName = newFN;
            this._lastName = newLN;
        }

    }

}


let person = new Person("Peter", "Ivanov");
console.log(person.fullName);//Peter Ivanov
person.firstName = "George";
console.log(person.fullName);//George Ivanov
person.lastName = "Peterson";
console.log(person.fullName);//George Peterson
person.fullName = "Nikola Tesla";
console.log(person.firstName)//Nikola
console.log(person.lastName)//Tesla


// 1.	Area and Volume Calculator

// function solve(area, vol, input) {
//     let obj = JSON.parse(input);
//     let result = [];
//     for(let row of obj){
//         let x1 = Number(row.x);
//         let y1 = Number(row.y);
//         let z1 = Number(row.z);
//         let currentResult = { 
//             x: Math.abs(x1),
//             y: Math.abs(y1),
//             z: Math.abs(z1),
//             area1: area,
//             volume1: vol            
//         };
//         let newObj = {
//             area: currentResult.area1(),
//             volume: currentResult.volume1()
//         }        
//         result.push(newObj); 
//     }
//     console.log(result);
    
//     return result;
// }
// function area() {
//     return this.x * this.y;
// };

// function vol() {
//     return this.x * this.y * this.z;
// };


// solve(area, vol, '[{"x":"10","y":"-22","z":"10"},{"x":"47","y":"7","z":"-5"},{"x":"55","y":"8","z":"0"},{"x":"100","y":"100","z":"100"},{"x":"55","y":"80","z":"250"}]');
