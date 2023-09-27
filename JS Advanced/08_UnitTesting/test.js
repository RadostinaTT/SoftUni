// 7.	Payment Package

let PaymentPackage= require('./js');
let assert = require('chai').assert;
  
describe('PaymentPackage() behavior', () => {
    let actualResult;
    let expectedResult;
    
    beforeEach(() => {
        actualResult = null;
        expectedResult = null;
    });

    describe('constructor() behahior', () => {
        let payment = new PaymentPackage('debit', 100);
        it('name', () => {
            assert.equal(payment.name, 'debit', 'name');
        });
        it('value', () => {
            assert.equal(payment.value, 100, 'value');
        });
        it('VAT', () => {
            assert.equal(payment.VAT, 20, 'VAT');
        });
        it('active', () => {
            assert.equal(payment.active, true, 'active');
        });
    });

    describe('name', () => {
        
        it('invalid parameter - number', () => {
            actualResult = () => new PaymentPackage(123, 100);
            expectedResult = 'Name must be a non-empty string';

            assert.throw(actualResult, expectedResult);
        });
        it('invalid parameter - empty', () => {
            actualResult = () => new PaymentPackage('', 100);
            expectedResult = 'Name must be a non-empty string';

            assert.throw(actualResult, expectedResult);
        });
        it('valid parameter - string', () => {
            actualResult = new PaymentPackage('debit', 100);
            expectedResult = 'debit';

            assert.equal(actualResult.name, expectedResult);
        });
        it('change parameter - string', () => {
            actualResult = new PaymentPackage('credit', 100);
            actualResult.name = 'debit';
            expectedResult = 'debit';

            assert.equal(actualResult.name, expectedResult);
        });
    });

    describe('value', () => {
        it('invalid parameter - string', () => {
            actualResult = () => new PaymentPackage('debit', '100');
            expectedResult = 'Value must be a non-negative number';

            assert.throw(actualResult, expectedResult);
        });
        it('invalid parameter - empty', () => {
            actualResult = () => new PaymentPackage('debit', -40);
            expectedResult = 'Value must be a non-negative number';

            assert.throw(actualResult, expectedResult);
        });
    });

});

// 5.	String Builder

// let StringBuilder = require('./js');
// let assert = require('chai').assert;

// describe('StringBuilder() behavior', () => {
//     let actualResult;
//     let expectedResult;
//     let sb;
    
//     beforeEach(() => {
//         actualResult = null;
//         expectedResult = null;
//         sb = new StringBuilder('test');

//     });
//     describe('properties', () => {
//         it('append', () => {
//             actualResult = Object.getPrototypeOf(sb).hasOwnProperty('append');
//             expectedResult = true;

//             assert.equal(actualResult, expectedResult);
//         });
//         it('prepend', () => {
//             actualResult = Object.getPrototypeOf(sb).hasOwnProperty('prepend');
//             expectedResult = true;

//             assert.equal(actualResult, expectedResult);
//         });
//         it('insertAt', () => {
//             actualResult = Object.getPrototypeOf(sb).hasOwnProperty('insertAt');
//             expectedResult = true;

//             assert.equal(actualResult, expectedResult);
//         });
//         it('remove', () => {
//             actualResult = Object.getPrototypeOf(sb).hasOwnProperty('remove');
//             expectedResult = true;

//             assert.equal(actualResult, expectedResult);
//         });
//         it('toString', () => {
//             actualResult = Object.getPrototypeOf(sb).hasOwnProperty('toString');
//             expectedResult = true;

//             assert.equal(actualResult, expectedResult);
//         });
//         it('toString', () => {
//             actualResult = sb.toString();
//             expectedResult = 'test';

//             assert.equal(actualResult, expectedResult);
//         });                
//     });


//     describe('constructor() behavior', () => {
//         it('without param', ()=> {
//             actualResult = new StringBuilder();
//             expectedResult = [];

//             assert.deepEqual(actualResult._stringArray, []);
//         });//ne
//         it('with param', ()=> {
//             actualResult = new StringBuilder('one')._stringArray;
//             expectedResult = ['o', 'n', 'e'];

//             assert.deepEqual(actualResult, expectedResult);
//         }); //ne
//         it('with boolean param', ()=> {
//             actualResult = () => new StringBuilder(true);
//             expectedResult = 'Argument must be string';

//             assert.throw(actualResult, expectedResult);
//         });//ne
//         it('with number param', ()=> {
//             actualResult = () => new StringBuilder(123);
//             expectedResult = 'Argument must be string';

//             assert.throw(actualResult, expectedResult);
//         });//ne
//     });

//     describe('append() behavior', () => {
//         it('valid argument', ()=> {
//             sb.append('one');
//             actualResult = sb._stringArray;
//             expectedResult = ['t', 'e', 's', 't', 'o', 'n', 'e'];

//             assert.deepEqual(actualResult, expectedResult);
//         });//ne
//         it('invalid argument', ()=> {
//             actualResult = () => sb.append(1);
//             expectedResult = 'Argument must be string';

//             assert.throw(actualResult, expectedResult);
//         });
//     });
//     describe('prepend() behavior', () => {
//         it('valid argument', ()=> {
//             sb.prepend('one');
//             actualResult = sb._stringArray;
//             expectedResult = [ 'o', 'n', 'e', 't', 'e', 's', 't'];

//             assert.deepEqual(actualResult, expectedResult);
//         });
//         it('invalid argument', ()=> {
//             actualResult = () => sb.prepend(true);
//             expectedResult = 'Argument must be string';

//             assert.throw(actualResult, expectedResult);
//         });
//     });
//     describe('insertAt() behavior', () => {
//         it('valid argument', ()=> {
//             sb.insertAt('rd', 1);
//             actualResult = sb._stringArray;
//             expectedResult = [ 't', 'r', 'd', 'e', 's', 't'];

//             assert.deepEqual(actualResult, expectedResult);
//         });//ne
//         it('invalid argument', ()=> {
//             actualResult = () => sb.insertAt(4, 1);
//             expectedResult = 'Argument must be string';

//             assert.throw(actualResult, expectedResult);
//         });
//         it('invalid argument', ()=> {
//             actualResult = () => sb.insertAt([1, 4, 6]);
//             expectedResult = 'Argument must be string';

//             assert.throw(actualResult, expectedResult);
//         });
//     });
//     describe('remove() behavior', () => {
//         it('valid argument', ()=> {
//             sb.remove(2, 1);
//             actualResult = sb._stringArray;
//             expectedResult = [ 't', 'e', 't'];

//             assert.deepEqual(actualResult, expectedResult);
//         });
//     });

// });


// 4.	Math Enforcer

// let mathEnforcer = require('./js');
// let assert = require('chai').assert;

// describe('mathEnforcer() behavior', () => {
//     let actualResult;
//     let expectedResult;
    
//     beforeEach(() => {
//         actualResult = null;
//         expectedResult = null;
//     });
//     describe('addFive()', () => {
//         it('invalid argument - String', () => {
//             actualResult = mathEnforcer.addFive('red');
//             expectedResult = undefined;

//             assert.equal(actualResult, expectedResult);
//         });
    
//         it('invalid argument - Boolean', () => {
//             actualResult = mathEnforcer.addFive(false);
//             expectedResult = undefined;

//             assert.equal(actualResult, expectedResult);
//         });

//         it('valid argument - Negative value', () => {
//             actualResult = mathEnforcer.addFive(-10);
//             expectedResult = -5;

//             assert.equal(actualResult, expectedResult);
//         });

//         it('valid argument - Double', () => {
//             actualResult = mathEnforcer.addFive(10.5);
//             expectedResult = 15.5;

//             assert.equal(actualResult, expectedResult);
//         });  
        
//     // it('valid argument - Positive value', () => {
//             //     actualResult = mathEnforcer.addFive(10);
//             //     expectedResult = 15;

//             //     assert.equal(actualResult, expectedResult);
//      // });      
//     });
//     describe('subtractTen()', () => {
//         it('invalid argument - String', () => {
//             actualResult = mathEnforcer.subtractTen('red');
//             expectedResult = undefined;

//             assert.equal(actualResult, expectedResult);
//         });
    
//         it('invalid argument - Boolean', () => {
//             actualResult = mathEnforcer.subtractTen(false);
//             expectedResult = undefined;

//             assert.equal(actualResult, expectedResult);
//         });

//         it('valid argument - Negative value', () => {
//             actualResult = mathEnforcer.subtractTen(-10);
//             expectedResult = -20;

//             assert.equal(actualResult, expectedResult);
//         });

//         it('valid argument - Double', () => {
//             actualResult = mathEnforcer.subtractTen(10.5);
//             expectedResult = 0.5;

//             assert.equal(actualResult, expectedResult);
//         });
//     });
//     describe('sum()', () => {
//         it('invalid first argument - String', () => {
//             actualResult = mathEnforcer.sum('red', 1);
//             expectedResult = undefined;

//             assert.equal(actualResult, expectedResult);
//         });

//         it('invalid second argument - String', () => {
//             actualResult = mathEnforcer.sum(3, 'red');
//             expectedResult = undefined;

//             assert.equal(actualResult, expectedResult);
//         });
    
//         it('invalid first argument - Boolean', () => {
//             actualResult = mathEnforcer.sum(false , 4);
//             expectedResult = undefined;

//             assert.equal(actualResult, expectedResult);
//         });

//         it('invalid second argument - Boolean', () => {
//             actualResult = mathEnforcer.sum(5, false);
//             expectedResult = undefined;

//             assert.equal(actualResult, expectedResult);
//         });

//         it('valid argument - Negative value', () => {
//             actualResult = mathEnforcer.sum(-10 , 30);
//             expectedResult = 20;

//             assert.equal(actualResult, expectedResult);
//         });

//         it('valid argument - Double', () => {
//             actualResult = mathEnforcer.sum(10.5 , 10);
//             expectedResult = 20.5;

//             assert.equal(actualResult, expectedResult);
//         });

//         it('valid argument - Zero', () => {
//             actualResult = mathEnforcer.sum(0 , 10);
//             expectedResult = 10;

//             assert.equal(actualResult, expectedResult);
//         });
//         // it('valid argument - Negative value', () => {
//         //     actualResult = mathEnforcer.sum(10 , -30);
//         //     expectedResult = -20;

//         //     assert.equal(actualResult, expectedResult);
//         // });

//         it('valid argument - Double', () => {
//             actualResult = mathEnforcer.sum(10 , 10.5);
//             expectedResult = 20.5;

//             assert.equal(actualResult, expectedResult);
//         });

//         // it('valid argument - Zero', () => {
//         //     actualResult = mathEnforcer.sum(10 , 0);
//         //     expectedResult = 10;

//         //     assert.equal(actualResult, expectedResult);
//         // });
//     });
// });



// 3.	Char Lookup

// let lookupChar = require('./js');
// let assert = require('chai').assert;

// describe('lookupChar() behavior', () => {
//     it('check the type of input First argument - Number type', () => {
//         assert.equal(lookupChar(5, 5), undefined, 'first argument should be string')
//     });
//     it('check the type of input First argument - Boolean type', () => {
//         assert.equal(lookupChar(true, 5), undefined, 'first argument should be string')
//     });
    
//     it('check the type of input Second argument - String type', () => {
//         assert.equal(lookupChar('sea', 'five'), undefined, 'second argument should be number')
//     });
//     it('check the type of input Second argument - Double type', () => {
//         assert.equal(lookupChar('sea', 3.5), undefined, 'second argument should be integer')
//     });
//     it('check the type of input Second argument - Boolean type', () => {
//         assert.equal(lookupChar('sea', true), undefined, 'second argument should be number')
//     });

//     it('check the length of string argument - <= index', () => {
//         assert.equal(lookupChar('seashell', 9), "Incorrect index", 'length of the string should be less then index')
//     });
//     it('check the value of index argument - < 0', () => {
//         assert.equal(lookupChar('seashell', -1), "Incorrect index", "length of the string shouldn't be negative number")
//     });

//     it('check the value of returned index', () => {
//         assert.equal(lookupChar('seashell', 1), 'e', "Should be 'e'")
//     });
//     it('check the value of the last index', () => {
//         assert.equal(lookupChar('seashell', 7), 'l', "Should be 'l'")
//     });
// });



// 2.	Even or Odd

// let isOddOrEven = require('./js');

// let assert = require('chai').assert;

// describe('isOddOrEven() behavior', () => {
    
//     it("check the type of input - Boolean case", () =>{
        
//         assert.equal(isOddOrEven(false), undefined, 'The result is not undefined');
//     });
//     it("check the type of input - Number case", () =>{
      
//         assert.equal(isOddOrEven(14), undefined, 'The result is not undefined');
//     });

//     it("check the type of input - Odd String case", () =>{
        
//         assert.equal(isOddOrEven('false'), 'odd', 'The result is not odd');
//     });

//     it("check the type of input - Even String case", () =>{
        
//         assert.equal(isOddOrEven('falses'), 'even', 'The result is not even');
//     });
// });
