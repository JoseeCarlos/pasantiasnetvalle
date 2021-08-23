let cerrar = document.querySelectorAll(".close")[0];
let modal = document.querySelectorAll(".modal")[0];
let modalCA = document.querySelectorAll(".modal-container-aceptar")[0];
let cancelar = document.querySelectorAll(".btnCancelar")[0];

cerrar.addEventListener("click", function () {
    modal.classList.toggle("modal-close");
    setTimeout(function () {
        modalCA.style.opacity = "0";
        modalCA.style.visibility = "hidden";
    }, 800);
    location.replace("PMenuJefeDeCarrera.aspx");
});

cancelar.addEventListener("click", function () {
    modal.classList.toggle("modal-close");
    setTimeout(function () {
        modalCA.style.opacity = "0";
        modalCA.style.visibility = "hidden";
    }, 800);
    location.replace("PMenuJefeDeCarrera.aspx");
});

window.addEventListener("click", function (e) {
    modal.classList.toggle("modal-close");
    setTimeout(function () {
        modalCA.style.opacity = "0";
        modalCA.style.visibility = "hidden";
    }, 800);
    location.replace("PMenuJefeDeCarrera.aspx");
});