//let key = '4ds';
//let message = 'eaSt 19,432567noRt north east 53,123456north 43,3213454dsNot all those who wander are lost.4dsnorth 47,874532';
function solve() {
    let key = document.getElementById('string').value;
    let message = document.getElementById('text').value;
    let resultRef = document.getElementById('result');
    let regMessage = message.match(`${key}(.+)${key}`)[1];
    let regEx = new RegExp(/(?<direction>east|north).*?(?<coordinates>\d{2}).*?,[^,].*?(?<decimals>\d{6})/gmi);
   
    let north;
    let east;
    let temp = regEx.exec(message);
    while (temp) {
        if (temp[1].toLowerCase() === 'east') {
            east = `${temp[2]}.${temp[3]}`;
        }else{
            north = `${temp[2]}.${temp[3]}`;
        }
        temp = regEx.exec(message);
    }

    resultRef.innerHTML = `
    <p>${north} N</p>
    <p>${east} E</p>
    <p>Message: ${regMessage}</p>
    `    
}
    // console.log(regMessage);
    // console.log(message.match(regEx));
//solve();