let myImage = document.querySelector('img');

myImage.onclick = function() {
  let mySrc = myImage.getAttribute('src');
  if(mySrc === "https://icons.iconarchive.com/icons/carlosjj/mozilla/256/Firefox-icon.png") {
    myImage.setAttribute ('src',"https://icons.iconarchive.com/icons/carlosjj/mozilla/256/Firefox-icon.png");
  } else {
    myImage.setAttribute ('src',"https://icons.iconarchive.com/icons/carlosjj/mozilla/256/Firefox-icon.png");
  }
}

// Personalized welcome message code

let myButton = document.querySelector('button');
let myHeading = document.querySelector('h1');

function setUserName() {
  let myName = prompt('Please enter your name.');
  if(!myName) {
    setUserName();
  } else {
    localStorage.setItem('name', myName);
    myHeading.innerHTML = 'Mozilla is cool, ' + myName;
  }
}

if(!localStorage.getItem('name')) {
  setUserName();
} else {
  let storedName = localStorage.getItem('name');
  myHeading.innerHTML = 'Mozilla is cool, ' + storedName;
}

myButton.onclick = function() {
  setUserName();
}