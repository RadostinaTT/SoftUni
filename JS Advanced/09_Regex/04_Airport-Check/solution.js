function solve() {
    let resultRef = document.getElementById('result');
    let [stringInput, method] = document.getElementById('string').value.split(',');
    //let [stringInput, method] = 'ahah George-Adams )*))&&ba SOF/VAR ela** FB973 - Bulgaria*Air -opFB900 pa-SOF/VAr//_- T12G12 STD08:45  STA09:35 , all'.split(' , ');

    let nameReg = / [A-Z][A-Za-z]*-[A-Z][A-Za-z]*( |\.-[A-Z][A-Za-z]* )/;
    let airportReg = / [A-Z]{3}\/[A-Z]{3} /;
    let flightNumberReg = / [A-Z]{1,3}[\d]{1,5} /;
    let companyReg = /- [A-Z][A-Za-z]*\*[A-Z][A-Za-z]* /;    

    // let nameReg = (/ [A-Z][A-Za-z]*-[A-Z][A-Za-z]*( |\.-[A-Z][A-Za-z]* )/gm);
    // let airportReg = (/ [A-Z]{3}\/[A-Z]{3} /gm);
    // let flightNumberReg = (/ [A-Z]{1,3}[\d]{1,5} /gm);
    // let companyReg = (/- [A-Z][A-Za-z]*\*[A-Z][A-Za-z]* /gm);    

    let funcObj = {
        'name': () => `Mr/Ms, ${stringInput.match(nameReg)[0].trim().replace(/-/g, ' ').replace(/\*/g, ' ')}, have a nice flight!`,
        'flight': () =>  {
            let [from, to] = stringInput.match(airportReg)[0].split('/')
            return `Your flight number ${stringInput.match(flightNumberReg)[0].trim()} is from ${trom.trim()} to ${to.trim()}.`
        },
        'company': () =>  `'Have a nice flight with ${stringInput.match(companyReg)[0].trim().replace(/-/g, ' ').replace(/\*/g, ' ')}.`,
        'all': () => {
            let airport = stringInput.match(airportReg)
            let [from, to] = stringInput.match(airportReg)[0].split('/')
            return `Mr/Ms, ${stringInput.match(nameReg)[0].trim().replace(/-/g, ' ').replace(/\*/g, ' ')}, your flight number ${stringInput.match(flightNumberReg)[0].trim()} is from ${from.trim()} to ${to.trim()}. Have a nice flight with ${stringInput.match(companyReg)[0].trim().replace(/-/g, ' ').replace(/\*/g, ' ').trim()}.`
        } 
    }
    resultRef.innerHTML = funcObj[method.trim()]();
    //console.log(funcObj[method.trim()]());   
}

solve()