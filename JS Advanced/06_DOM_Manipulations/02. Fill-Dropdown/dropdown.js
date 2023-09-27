function addItem() {
    const elements = {
        inputText: document.getElementById('newItemText'),
        inputValue: document.getElementById('newItemValue'),
        inputMenu: document.getElementById('menu')
    }

    const option = document.createElement('option');

    option.textContent = elements.inputText.value;
    option.value = elements.inputValue.value;

    elements.inputMenu.appendChild(option);

    elements.inputText.value = "";
    elements.inputValue.value = "";
}