function course() {
  var x = document.getElementById("container-video");
  const course = document.getElementById("container-lessons");
  if (x.style.display == "block") {
    x.style.display = "none";
    course.style.display = "block";
  } else {
    x.style.display = "none";
    course.style.display = "block";
  }
}
function videos() {
  var x = document.getElementById("container-lessons");
  const course = document.getElementById("container-video");
  if (x.style.display == "block") {
    x.style.display = "none";
    course.style.display = "block";
  } else {
    x.style.display = "none";
    course.style.display = "block";
  }
}
function resources() {
  var x = document.getElementById("container-lessons");
  var a = document.getElementById("container-video");
  const course = document.getElementById("container-resources");
  if (x.style.display == "block") {
    x.style.display = "none";
    course.style.display = "block";
  } else if (a.style.display == "block") {
    a.style.display = "none";
    course.style.display = "block";
  } else {
    x.style.display = "none";
    a.style.display = "none";
    course.style.display = "block";
  }
}
