var counter = 1;
setInterval(function () {
  document.getElementById("radio" + counter).checked = true;
  counter++;

  if (counter > 3) {
    counter = 1;
  }
}, 5000);

function reveal() {
  let reveals = document.querySelectorAll(".reveal");

  for (let i = 0; i < reveals.length; i++) {
    let windowHeight = window.innerHeight;
    let elementTop = reveals[i].getBoundingClientRect().top;
    let elementVisible = 150;

    if (elementTop < windowHeight - elementVisible) {
      reveals[i].classList.add("active");
    } else {
      reveals[i].classList.remove("active");
    }
  }
}

window.addEventListener("scroll", reveal);

function show() {
  var x = document.getElementById("joinus");
  if (x.style.display == "none") {
    x.style.display = "block";
  } else {
    x.style.display = "none";
  }
}

let orders = [];

function addOrder() {
  let name = document.getElementById("fullname").value;
  // أنشئ كائن newOrder
  let newOrder = {
    name: name,
  };
  // أدرج الكائن إلى المصفوفة
  orders.push(newOrder);
  // طبق الخطوة 7 تحت هذا الكومنت
  load();
}

function load() {
  const button = document.getElementById("joinusss");
  const detail = document.getElementById("joinus");
  button.style.visibility = "hidden";
  button.style.display = "none";
  detail.style.visibility = "hidden";
  detail.style.display = "none";
  let container = document.getElementById("name1");
  container.innerHTML = "";

  // طبّق الخطوة 6 تحت هذا الكومنت
  orders.forEach((item) => {
    container.innerHTML += `<h4>${item.name}</h4>`;
  });
}

function button1() {
  document.getElementById("myButton");
  location.href = "/html_files/web_categories.html";
}
