function solve() {
    let optionMenu = document.querySelectorAll('#selectMenuTo')[0];
    let button = document.querySelector('button')
    let input = document.querySelector('#input')

    optionMenu.innerHTML = `
    <option selected value=""></option>
    <option value="binary">Binary</option>
    <option value="hexadecimal">Hexadecimal</option>
    `

    button.addEventListener('click', () => {
        console.log(input.value)
        console.log(optionMenu.value, ' <= select')

        let result
        if(optionMenu.value === 'binary'){
            result = (Number(input.value)).toString(2)
        }else {
            result = (Number(input.value)).toString(16).toUpperCase()
        }

        document.getElementById('result').value = result;
    })  
}