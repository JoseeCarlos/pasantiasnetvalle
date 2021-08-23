<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPAdministrativo.Master" AutoEventWireup="true" CodeBehind="PMenuJefeDeCarrera.aspx.cs" Inherits="WAPasantia.WebForm.PMenuJefeDeCarrera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.0/css/all.css" integrity="sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ" crossorigin="anonymous">
    <link href="../Estilo/SNotificacion.css" rel="stylesheet" />
    <link href="../Estilo/SModal.css" rel="stylesheet" />
    <script type="text/javascript">
        document.addEventListener("DOMContentLoaded", function MensajeConfirmacion() {
            function getVariableGetByName() {
                var variables = {};
                var arreglos = window.location.href.replace(/[?&]+([^=&]+)=([^&]*)/gi, function (m, key, value) {
                    variables[key] = value;
                });
                return variables;
            }
            var cantidad = getVariableGetByName()["cantidadPostulacion"];
            if (cantidad > 1) {
                document.getElementById("lblMensaje").innerHTML = "¡TIENES " + cantidad + " PASANTIAS PENDIENTES!";

            }
            else {
            document.getElementById("lblMensaje").innerHTML = "¡TIENES " + cantidad + " PASANTIA PENDIENTE!";

            }
            var tienePostulacion = getVariableGetByName()["tienePostulacion"];
            if (tienePostulacion == 1) {
                document.getElementById("modalPostulacion").style.opacity = "1";
                document.getElementById("modalPostulacion").style.visibility = "visible";
                document.getElementById("modal").classList.toggle("modal-close");
            }
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center_content">
        <table style="width: 750px; text-align: center">
            <tbody>
                <tr>
                    <td>
                        <ul class="mainmenu">
                            <li id="ContentPlaceHolder1_liSiu">
                                <a id="ContentPlaceHolder1_LKBSiu" title="Gestiona tu información personal" style="display: inline-block; font-size: 13px; height: 50px; width: 440px; margin: 0 5px 0 0;"><b style="font-size: 35px">S</b>OLICITUD DE PASANTIAS</a>
                            </li>
                            <li id="ContentPlaceHolder1_liTips">
                                <a id="ContentPlaceHolder1_LKBTips" title="Tips para tomar en cuenta" style="display: inline-block; font-size: 13px; height: 50px; width: 100px; margin: 0 5px 0 0;"><b style="font-size: 35px"></a>
                            </li>
                            <li id="ContentPlaceHolder1_li1">
                                <a id="ContentPlaceHolder1_LKBPerfil" title="Revisa tu perfil de usuario" style="display: inline-block; font-size: 13px; height: 50px; width: 110px; padding-left: 15px; padding-right: 15px">
                                    <asp:Image ID="Image2" runat="server" Style="height: 35px; width: 35px; border: 0 none; margin-top: 5px" ImageUrl="~/Imagenes/perfil.png" />
                                </a>
                            </li>
                        </ul>
                    </td>
                </tr>
            </tbody>
        </table>
        <table style="width: 100%" align="center">
            <tr>
                <td>
                    <fieldset style="width: 800px" align="center">
                        <legend style="text-align: left"></legend>
                        <table width="800px">
                            <tr id="ContentPlaceHolder1_CURecursosEstudiante_TRMenu">
                                <td style="width: 45%; vertical-align: top">
                                    <fieldset>
                                        <legend style="text-align: left">
                                            <span id="LBLLengend" class="cssLegend">Opciones</span>
                                        </legend>
                                        <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                                            <tr class="LBLContenido">
                                                <td><a>
                                                    <img src="../Imagenes/bullet_selected.png" alt="" style="border-width: 0;" /></a></td>
                                                <td class="LBLContenido">BIBLIOTECA DIGITAL</td>
                                            </tr>
                                        </table>
                                        <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                                            <tr class="LBLContenido">
                                                <td><a>
                                                    <img src="../Imagenes/bullet_selected.png" alt="" style="border-width: 0;" /></a></td>
                                                <td class="LBLContenido"><a href="PSolicitudPasantia.aspx" class="linkNoticacion">POSTULACIONES A PASANTIAS <label id="lblIcono" runat="server"> <b> - </b><i style="color: red;" class="fas fa-bell" id="notification"></i></label><asp:Label runat="server" CssClass="lblNotificacion" ID="lblNotificacion"> 2 </asp:Label></a></td>
                                            </tr>
                                        </table>
                                        <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                                            <tr class="LBLContenido">
                                                <td><a>
                                                    <img src="../Imagenes/bullet_selected.png" alt="" style="border-width: 0;" /></a></td>
                                                <td class="LBLContenido">BIBLIOTECAS VIRTUALES</td>
                                            </tr>
                                        </table>
                                        <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                                            <tr class="LBLContenido">
                                                <td><a>
                                                    <img src="../Imagenes/bullet_selected.png" alt="" style="border-width: 0;" /></a></td>
                                                <td class="LBLContenido">CONTRASEÑA DE CORREO</td>
                                            </tr>
                                        </table>
                                        <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                                            <tr class="LBLContenido">
                                                <td><a>
                                                    <img src="../Imagenes/bullet_selected.png" alt="" style="border-width: 0;" /></a></td>
                                                <td class="LBLContenido">FORMULARIOS</td>
                                            </tr>
                                        </table>
                                        <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                                            <tr class="LBLContenido">
                                                <td><a>
                                                    <img src="../Imagenes/bullet_selected.png" alt="" style="border-width: 0;" /></a></td>
                                                <td class="LBLContenido">PUBLICACIONES</td>
                                            </tr>
                                        </table>
                                        <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                                            <tr class="LBLContenido">
                                                <td><a>
                                                    <img src="../Imagenes/bullet_selected.png" alt="" style="border-width: 0;" /></a></td>
                                                <td class="LBLContenido">DOCUMENTOS Y REGLAMENTOS</td>
                                            </tr>
                                        </table>
                                        <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                                            <tr class="LBLContenido">
                                                <td><a>
                                                    <img src="../Imagenes/bullet_selected.png" alt="" style="border-width: 0;" /></a></td>
                                                <td class="LBLContenido">CONSULTA A BIBLIOTECA</td>
                                            </tr>
                                        </table>
                                        <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                                            <tr class="LBLContenido">
                                                <td><a>
                                                    <img src="../Imagenes/bullet_selected.png" alt="" style="border-width: 0;" /></a></td>
                                                <td class="LBLContenido">SOFTWARE ACADEMICO</td>
                                            </tr>
                                        </table>
                                        <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                                            <tr class="LBLContenido">
                                                <td><a>
                                                    <img src="../Imagenes/bullet_selected.png" alt="" style="border-width: 0;" /></a></td>
                                                <td class="LBLContenido">LIBROS Y REVISTAS</td>
                                            </tr>
                                        </table>
                                        <table cellpadding="0" cellspacing="0" style="border-width: 0;">
                                            <tr class="LBLContenido">
                                                <td><a>
                                                    <img src="../Imagenes/bullet_selected.png" alt="" style="border-width: 0;" /></a></td>
                                                <td class="LBLContenido">SIMULADORES</td>
                                            </tr>
                                        </table>
                                    </fieldset>
                                </td>
                                <td style="width: 70%; height: 100%; vertical-align: top"></td>
                            </tr>
                            <tr>
                                <td style="width: 100%; vertical-align: top" colspan="2"></td>
                            </tr>
                            <tr>
                            </tr>
                        </table>
                    </fieldset>
                </td>
            </tr>
        </table>
           <form runat="server">
              <div class="modal-container-aceptar" id="modalPostulacion">
                <div class="modal modal-close" id="modal">
                    <p class="close">X</p>
                    <div class="modal-textos">
                        <label id="lblMensaje"></label>
                    </div>
                    <div class="modal-button">
                        <a class="btnRevisar" href="PSolicitudPasantia.aspx">REVISAR AHORA</a>
                        <a class="btnCancelar">CANCELAR</a>
                    </div>
                </div>
            </div>
        </form>
    </div>
    <script src="../Js/PModalAlertaJefeCarrera.js"></script>
</asp:Content>
