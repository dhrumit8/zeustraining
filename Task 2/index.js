let button = document.getElementById("button");
let username = document.getElementById("name");
let comments = document.getElementById("comments");
let male = document.getElementById("male");
let female = document.getElementById("female");

function Validate() {
    if (username.value == "") {
        alert("All fields are compulsory");
        username.focus();
    }
    else if (comments.value == "") {
        alert("All fields are compulsory");
        comments.focus();
    }
    else if (male.checked == false && female.checked == false) {
        alert("All fields are compulsory");
    }
    else {
        alert("Submitted!!");
    }
}