function subtract() {
    const firstInputElement = document.getElementById('firstNumber');
    const secondInputElement = document.getElementById('secondNumber');
    const divElement = document.getElementById('result');

    const result = +firstInputElement.value - + secondInputElement.value;

    divElement.textContent = result;
}