let arrow = document.querySelectorAll(".arrow");
for (var i = 0; i < arrow.length; i++) {
  arrow[i].addEventListener("click", (e) => {
    let arrowParent = e.target.parentElement.parentElement; //selecting main parent of arrow
    arrowParent.classList.toggle("showMenu");
  });
}
let sidebar = document.querySelector(".sidebar");
let sidebarBtn = document.querySelector(".bx-menu");
console.log(sidebarBtn);
sidebarBtn.addEventListener("click", () => {
  sidebar.classList.toggle("close");
});

function challenges() {
  var x = document.getElementById("challengs-box");
  const course = document.getElementById("container_course");
  if (x.style.display == "block") {
    x.style.display = "none";
    course.style.display = "block";
  } else {
    x.style.display = "block";
    course.style.display = "none";
  }
}
function course() {
  var x = document.getElementById("challengs-box");
  const course = document.getElementById("container_course");
  if (x.style.display == "block") {
    x.style.display = "none";
    course.style.display = "block";
  } else {
    x.style.display = "none";
    course.style.display = "block";
  }
}
function mybutton1() {
  document.getElementById("pythoncourse");
  location.href = "/html_files/python.html";
}
function mybutton2() {
  document.getElementById("hourofcode");
  location.href = "/html_files/hour_of_code.html";
}
function mybutton3() {
  document.getElementById("coderbyte");
  location.href = "/html_files/coderbyte.html";
}
function mybutton4() {
  document.getElementById("hackerrank");
  location.href = "/html_files/hackerrank.html";
}
function mybutton5() {
  document.getElementById("exercism");
  location.href = "/html_files/exercism.html";
}
