
let cerrar = document.querySelectorAll(".close")[0];

let cancelar = document.querySelectorAll(".close")[0];

let aceptar = document.querySelectorAll(".aceptar123")[0];

let modal = document.querySelectorAll(".modalEm")[0];

let modalE = document.querySelectorAll(".modal-container-empresa")[0];


aceptar.addEventListener("change", function (e) {

    if (aceptar.value == "Agregar Nueva Empresa") {
        e.preventDefault();
        modalE.style.opacity = "1";
        modalE.style.visibility = "visible";
        modal.classList.toggle("modal-close");
    }
});

cerrar.addEventListener("click", function () {
    modal.classList.toggle("modal-close");
    setTimeout(function () {
        modalE.style.opacity = "0";
        modalE.style.visibility = "hidden";
    }, 800);
});



cancelar.addEventListener("click", function () {
    modal.classList.toggle("modal-close");
    setTimeout(function () {
        modalE.style.opacity = "0";
        modalE.style.visibility = "hidden";
    }, 800);
});


window.addEventListener("click", function (e) {
    if (e.target == modalE) {
        modal.classList.toggle("modal-close");
        setTimeout(function () {
            modalE.style.opacity = "0";
            modalE.style.visibility = "hidden";
        }, 800);
    }

});