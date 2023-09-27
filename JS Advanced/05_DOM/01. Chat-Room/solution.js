function solve() {
   let sendButton = document.getElementById('send');
   let input = document.getElementById('chat_input')
   let messageBox = document.getElementById('chat_messages');


   sendButton.addEventListener('click', (e) => {
         
   let newElement = document.createElement('div');
   newElement.innerHTML = input.value;
   newElement.classList.add('message', 'my-message');
   messageBox.appendChild(newElement);
   input.value = '';
   })   
}


