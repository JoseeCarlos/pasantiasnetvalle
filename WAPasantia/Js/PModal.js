let cerrar = document.querySelectorAll(".close")[0];
let cerrarR = document.querySelectorAll(".close")[1];
let cerrarMensajeA = document.querySelectorAll(".close")[2];
let cerrarMensajeR = document.querySelectorAll(".close")[3];
let cancelar = document.querySelectorAll(".btnCancelar")[0];
let cancelarR = document.querySelectorAll(".btnCancelar")[1];
let aceptarMensaje = document.querySelectorAll(".aAceptar")[0];
let aceptarMensajeR = document.querySelectorAll(".aAceptar")[1];
let aceptar = document.querySelectorAll(".aceptar")[0];
let rechazar = document.querySelectorAll(".rechazar")[0];
let modal = document.querySelectorAll(".modal")[0];
let modalR = document.querySelectorAll(".modal")[1];
let modalMensajeA = document.querySelectorAll(".modal")[2];
let modalMensajeR = document.querySelectorAll(".modal")[3];
let modalCA = document.querySelectorAll(".modal-container-aceptar")[0];
let modalCR = document.querySelectorAll(".modal-container-rechazar")[0];
let modalCMensajeA = document.querySelectorAll(".modal-container-mensajeAceptado")[0];
let modalCMensajeR = document.querySelectorAll(".modal-container-mensajeRechazado")[0];

aceptar.addEventListener("click", function (e) {
    e.preventDefault();
    modalCA.style.opacity = "1";
    modalCA.style.visibility = "visible";
    modal.classList.toggle("modal-close");
});

rechazar.addEventListener("click", function (e) {
    e.preventDefault();
    modalCR.style.opacity = "1";
    modalCR.style.visibility = "visible";
    modalR.classList.toggle("modal-close");
});

cerrar.addEventListener("click", function () {
    modal.classList.toggle("modal-close");
    setTimeout(function () {
        modalCA.style.opacity = "0";
        modalCA.style.visibility = "hidden";
    }, 800);
});

cerrarR.addEventListener("click", function () {
    modalR.classList.toggle("modal-close");
    setTimeout(function () {
        modalCR.style.opacity = "0";
        modalCR.style.visibility = "hidden";
    }, 800);
});

cerrarMensajeA.addEventListener("click", function () {
    location.replace("PSolicitudPasantia.aspx");
});

cerrarMensajeR.addEventListener("click", function () {
    location.replace("PSolicitudPasantia.aspx");
});

cancelar.addEventListener("click", function () {
    modal.classList.toggle("modal-close");
    setTimeout(function () {
        modalCA.style.opacity = "0";
        modalCA.style.visibility = "hidden";
    }, 800);
});

cancelarR.addEventListener("click", function () {
    modalR.classList.toggle("modal-close");
    setTimeout(function () {
        modalCR.style.opacity = "0";
        modalCR.style.visibility = "hidden";
    }, 800);
});

aceptarMensaje.addEventListener("click", function () {
    location.replace("PSolicitudPasantia.aspx");
});

aceptarMensajeR.addEventListener("click", function () {
    location.replace("PSolicitudPasantia.aspx");
});

window.addEventListener("click", function (e) {
    if (e.target == modalCA) {
        modal.classList.toggle("modal-close");
        setTimeout(function () {
            modalCA.style.opacity = "0";
            modalCA.style.visibility = "hidden";
        }, 800);
    }
    else if (e.target == modalCR) {
        modalR.classList.toggle("modal-close");
        setTimeout(function () {
            modalCR.style.opacity = "0";
            modalCR.style.visibility = "hidden";
        }, 800);
    }
    else if (e.target == modalCMensajeA) {
        location.replace("PSolicitudPasantia.aspx");
    }
    else if (e.target == modalCMensajeR) {
        location.replace("PSolicitudPasantia.aspx");
    }
});