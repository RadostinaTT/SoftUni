//let input = '0100011011010111100100100000011011100110000101101101011001010010000001101001011100110010';
function solve() {
	let input = document.getElementById('input').value;
	let resultRef = document.getElementById('resultOutput');

	let num = input.split('').map(Number).reduce((acc, x) => acc + x, 0);

	while (num > 9) {
		num = num.toString().split('').map(Number).reduce((acc, x) => acc + x, 0);
	}

	let cutInput = input.slice(num, input.length - num);
	//let matches = input.match(/\d{1,8}/g) pravi masiv ot namerenite chisla

	let chars = [];
	for (let i = 0; i < Math.ceil(cutInput.length / 8); i++) {
		chars.push(String.fromCharCode(parseInt(cutInput.slice(i * 8, (i + 1) * 8), 2)));		
	}
	
	resultRef.innerHTML = chars.filter(x => x.match(/[A-Za-z ]/)).join('');	
}

// solve();