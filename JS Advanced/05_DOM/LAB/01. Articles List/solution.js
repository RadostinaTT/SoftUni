function createArticle() {
	
	let h3 = document.createElement('h3');
	let p = document.createElement('p');
	let newArticle = document.createElement('article');

	let articleRef = document.getElementById('articles');
	let inputTitleRef = document.getElementById('createTitle');
	let inputArticleRef = document.getElementById('createContent');

		let value = inputTitleRef.value.toString();
	if (value.lentg !== 0	) {
		h3.innerHTML = inputTitleRef.value;
		p.innerHTML = inputArticleRef.value;
		newArticle.appendChild(h3);
		newArticle.appendChild(p);

	articleRef.appendChild(newArticle);
	}
	h3.innerHTML = inputTitleRef.value;
	p.innerHTML = inputArticleRef.value;
	newArticle.appendChild(h3);
	newArticle.appendChild(p);

	articleRef.appendChild(newArticle);

	inputTitleRef.value = '';
	inputArticleRef.value = '';
}
createArticle()