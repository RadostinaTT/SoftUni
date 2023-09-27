// 4.	Elemelons

function solve(){
    class Melon{
        constructor(weight, melonSort){
            if (new.target === Melon) {
                throw new TypeError("Abstract class cannot be instantiated directly");
            }

            this.weight = weight;
            this.melonSort = melonSort;
            this.element = '';
        }

        get  elementIndex(){
            return this.weight * this.melonSort.length;
        }

        toString(){
            let output = '';
            output += `Element: ${this.element}`;
            output += `\nSort: ${this.melonSort}`;
            output += `\nElement Index: ${this.elementIndex}`;

            return output;
        }
    }

    class Watermelon extends Melon{
        constructor(weight, melonSort){
            super(weight, melonSort);
            this.element = 'Water';
        }
    }

    class Firemelon extends Melon{
        constructor(weight, melonSort){
            super(weight, melonSort);
            this.element = 'Fire';
        }
    }

    class Earthmelon extends Melon{
        constructor(weight, melonSort){
            super(weight, melonSort);
            this.element = 'Earth';
        }
    }

    class Airmelon extends Melon{
        constructor(weight, melonSort){
            super(weight, melonSort);
            this.element = 'Air';
        }
    }

    class Melolemonmelon extends Watermelon{
        constructor(weight, melonSort){
            super(weight, melonSort);
            this.elementTypes = ['Fire','Earth','Air','Water']
        }

        morph(){
            let newType = this.elementTypes.shift();
            this.element = newType;
            this.elementTypes.push(newType);
        }
    }

    return{
        Melon,
        Watermelon,
        Firemelon,
        Earthmelon,
        Airmelon,
        Melolemonmelon
    }
}

solve();






// 3.	Posts

// function solve(){
//     class Post{
//         constructor(title, content){
//             this.title = title;
//             this.content = content;
//         }

//         toString(){
//             return `Post: ${this.title}\nContent: ${this.content}`;            
//         }
//     }

//     class SocialMediaPost extends Post{
//         constructor(title, content, likes, dislikes){
//             super(title, content);
//             this.likes = likes;
//             this.dislikes = dislikes;
//             this.comments = [];
//         }

//         addComment(input){
//             this.comments.push(input);
//         }

//         toString(){
//             if(this.comments.length > 0){
//                 let commentsToString = this.comments.map(c => ` * ${c}`).join('\n');
//                 return `Post: ${this.title}\nContent: ${this.content}\nRating: ${this.likes - this.dislikes}\nComments:\n${commentsToString}`;            
//             }
//             else{
//                 return `Post: ${this.title}\nContent: ${this.content}\nRating: ${this.likes - this.dislikes}`;            
//             }                       
//         }    
//     }

//     class BlogPost extends Post{
//         constructor(title, content, views){
//             super(title, content);
//             this.views = views;
//         }

//         view(){
//             this.views++;
//             return this;
//         }

//         toString(){
//             let output = super.toString();
//             output += `\nViews: ${this.views}`    
//             return output;
//         }    
//     }

//     return{
//         Post,
//         SocialMediaPost,
//         BlogPost
//     }
// }

// solve()
// let post = new SocialMediaPost('Butterfly', 'Butterfly content', 10, 4);
    // post.addComment('You suck');
    // post.addComment('Great!');
    // post.addComment('Number 1');
    // console.log(post.toString());
    // let post = new BlogPost('Butterfly', 'Butterfly content', 4);
    // post.view();
    // console.log(post.toString());




// 2.	People

// function solve(){
//     class Employee{
//         constructor(name, age){
//             this.name = name;
//             this.age = age;
//             this.salary = 0;
//             this.tasks = [];
//         }

//         work(){
//             let temp = this.tasks.shift();
//             this.tasks.push(temp);
//             console.log(`${this.name}${temp}`);
//         }

//         collectSalary(){
//             console.log(`${this.name} received ${this.salary} this month.`);            
//         }
//     }

//     class Junior extends Employee{
//         constructor(name, age){
//             super(name, age);
//             this.tasks.push(' is working on a simple task.');
//         }
//     }

//     class Senior extends Employee{
//         constructor(name, age){
//             super(name, age);
//             this.tasks.push(' is working on a complicated task.');
//             this.tasks.push(' is taking time off work.');
//             this.tasks.push(' is supervising junior workers.');
//         }
//     }

//     class Manager extends Employee{
//         constructor(name, age){
//             super(name, age);
//             this.dividend = 0;
//             this.tasks.push(' scheduled a meeting.');
//             this.tasks.push(' is preparing a quarterly report.');
//         }

//         collectSalary(){
//             console.log(`${this.name} received ${this.salary + this.dividend} this month.`);            
//         }
//     }

//     return{
//         Employee,
//         Junior,
//         Senior,
//         Manager
//     }
// }

// solve();

   // let first = new Employee('Rosen', 34);
    // first.salary = 200;
    // console.log(first);
    // first.work();
    // first.collectSalary();









// 1.	Balloons

// function solve(){
//     class Balloon{
//         constructor(color, gasWeight){
//             this.color = color;
//             this.gasWeight = gasWeight;
//         }
//     }

//     class PartyBalloon extends Balloon{
//         constructor(color, gasWeight, ribbonColor, ribbonLength){
//             super(color, gasWeight);
//             this._ribbon = {
//                 color: ribbonColor,
//                 length: ribbonLength
//             }
//         }

//         get ribbon(){
//             return this._ribbon;
//         }

//     }

//     class BirthdayBalloon extends PartyBalloon{
//         constructor(color, gasWeight, ribbonColor, ribbonLength, text){
//             super(color, gasWeight, ribbonColor, ribbonLength);
//             this._text = text;
//         }

//         get text(){
//             return this._text;
//         }
//     }

//     return{
//         Balloon,
//         PartyBalloon,
//         BirthdayBalloon
//     }
// }

// solve();

// let b = new Balloon('blue', 2);

// let p = new PartyBalloon('red', 2, 'gold', 3);

// let birth = new BirthdayBalloon('silver', 4, 'green', 6, 'HBD');

// console.log(b);

// console.log(p);

// console.log(birth);


