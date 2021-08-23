sumaFecha = function (d, fecha) {
    var Fecha = new Date();
    var sFecha = fecha || (Fecha.getDate() + "/" + (Fecha.getMonth() + 1) + "/" + Fecha.getFullYear());
    var sep = sFecha.indexOf('/') != -1 ? '/' : '-';
    var aFecha = sFecha.split(sep);
    var fecha = aFecha[2] + '/' + aFecha[1] + '/' + aFecha[0];
    fecha = new Date(fecha);
    fecha.setDate(fecha.getDate() + parseInt(d));
    var anno = fecha.getFullYear();
    var mes = fecha.getMonth() + 1;
    var dia = fecha.getDate();
    mes = (mes < 10) ? ("0" + mes) : mes;
    dia = (dia < 10) ? ("0" + dia) : dia;
    var fechaFinal = anno + '-' + mes + '-' + dia;
    return fechaFinal;
}

function handler(e) {
    var fecha = e.target.value;
    var sep = fecha.indexOf('/') != -1 ? '/' : '-';
    var sFecha = fecha.split(sep);
    var formato = sFecha[2] + '-' + sFecha[1] + '-' + sFecha[0];
    var sumaFinal = sumaFecha(10, formato);
    document.getElementById("ContentPlaceHolder1_fechaPlazo").value = sumaFinal;
}

window.onload = function () {
    var fecha = new Date(); 
    var mes = fecha.getMonth();
    var dia = fecha.getDate(); 
    var ano = fecha.getFullYear(); 
    if (dia < 10)
        dia = '0' + dia; 
    if (mes < 10)
        mes = '0' + mes
    document.getElementById('ContentPlaceHolder1_fechaActual').value = ano + "-" + mes + "-" + dia;
}