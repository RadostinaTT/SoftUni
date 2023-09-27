function solve() {
  let quizee = document.getElementById('quizzie');
  let sections = document.getElementsByTagName('section'); 
  let correctAnswers = ['onclick', 'JSON.stringify()', 'A programming API for HTML and XML documents'];
  let totalAnswers = 0;

  quizee.addEventListener('click', (e) => {
    
    if (e.target.className === 'answer-text') {
      console.log(e.target);
      console.log(e.target.innerHTML);

      if (correctAnswers.some(answer === e.target.innerHTML)) {
        totalAnswers++;       
      }
    }

  })
}
