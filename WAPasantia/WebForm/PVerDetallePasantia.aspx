<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPAdministrativo.Master" AutoEventWireup="true" CodeBehind="PVerDetallePasantia.aspx.cs" Inherits="WAPasantia.WebForm.PVerDetallePasantia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/SModal.css" rel="stylesheet" />
    <link href="../Estilo/SEstiloFormulario.css" rel="stylesheet" />
    <script type="text/javascript">
        document.addEventListener("DOMContentLoaded", function MensajeConfirmacion() {
            function getVariableGetByName() {
                var variables = {};
                var arreglos = window.location.href.replace(/[?&]+([^=&]+)=([^&]*)/gi, function (m, key, value) {
                    variables[key] = value;
                });
                return variables;
            }

            var mensaje = getVariableGetByName()["mensaje"];
            if (mensaje == 1) {
                document.getElementById("modalMensajeAprobado").style.opacity = "1";
                document.getElementById("modalMensajeAprobado").style.visibility = "visible";
                document.getElementById("modal").classList.toggle("modal-close");
            }
            else if (mensaje == 0) {
                document.getElementById("modalMensajeRechazado").style.opacity = "1";
                document.getElementById("modalMensajeRechazado").style.visibility = "visible";
                document.getElementById("modalR").classList.toggle("modal-close");
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

        <div class="form-style-11">

            <div style="margin-top: 0px">
                <h1>Datos Postulación<span>Datos Ingresados por  Estudiante</span></h1>
            </div>
            <form runat="server" name="formVerDetalle">
                <div id="Content">
                    <div id="left">
                        <div class="tile-sud">Datos del Estudiante</div>
                        <asp:Label runat="server" CssClass="label">Nombres:</asp:Label>
                        <asp:Label runat="server" ID="lblNombre"></asp:Label><br />
                        <asp:Label runat="server" CssClass="label">Apellidos:</asp:Label>
                        <asp:Label runat="server" ID="lblApellidos"></asp:Label><br />
                        <asp:Label runat="server" CssClass="label">Cedula de identidad:</asp:Label>
                        <asp:Label runat="server" ID="lblCedulaIdent"></asp:Label><br />
                        <asp:Label runat="server" CssClass="label">Emitido en:</asp:Label>
                        <asp:Label runat="server" ID="lblEmitido"></asp:Label><br />
                        <asp:Label runat="server" CssClass="label">Celular:</asp:Label>
                        <asp:Label runat="server" ID="lblCelular"></asp:Label><br />
                        <asp:Label runat="server" CssClass="label">Telefono:</asp:Label>
                        <asp:Label runat="server" ID="lblTelefono"></asp:Label><br />
                        <asp:Label runat="server" CssClass="label">E-Mail:</asp:Label>
                        <asp:Label runat="server" ID="lblEmail"></asp:Label><br />

                    </div>
                    <div id="right">
                        <div class="tile-sud">Datos de la Empresa</div>
                        <asp:Label runat="server" CssClass="label">Empresa:</asp:Label>
                        <asp:Label runat="server" ID="lblEmpresa"></asp:Label><br />
                        <asp:Label runat="server" CssClass="label">Carta dirigida a:</asp:Label>
                        <asp:Label runat="server" ID="lblCartaDirigida"></asp:Label><br />
                        <asp:Label runat="server" CssClass="label">Cargo:</asp:Label>
                        <asp:Label runat="server" ID="lblCargo"></asp:Label><br />
                        <asp:Label runat="server" CssClass="label">Direccion:</asp:Label>
                        <asp:Label runat="server" ID="lblDireccion"></asp:Label><br />
                        <asp:Label runat="server" CssClass="label">Telefono:</asp:Label>
                        <asp:Label runat="server" ID="lblTelefonoEmpresa"></asp:Label><br />
                        <asp:Label runat="server" CssClass="label">Ciudad:</asp:Label>
                        <asp:Label runat="server" ID="lblCiudad"></asp:Label><br />
                        <asp:Label runat="server" CssClass="label">E-Mail:</asp:Label>
                        <asp:Label runat="server" ID="lblEmailEmpresa"></asp:Label><br />

                    </div>
                </div>
                <div id="footer">
                    <div class="button-section">
                        <asp:Button CssClass="aceptar" ID="btnAceptar" runat="server" Text="Aceptar" />
                        <asp:Button CssClass="rechazar" ID="btnRechaar" runat="server" Text="Rechazar " />
                    </div>
                </div>

                <div class="modal-container-aceptar">
                    <div class="modal modal-close">
                        <p class="close">X</p>
                        <div class="modal-textos">
                            INGRESE LAS HORAS DE PASANTIA
                        </div>
                        <div class="modal-textbox">
                            <input type="number" style="width: 65%;" runat="server" id="txtHoras" value="1" min="1" max="999" onclick="if(this.value=='1') this.value=''" onblur="if(this.value=='') " required />
                        </div>
                        <div class="modal-button">
                            <asp:Button runat="server" CssClass="btnAceptar" ID="btnAceptarHoras" Text="ACEPTAR" OnClick="btnAceptarHoras_Click" />
                            <a class="btnCancelar">CANCELAR</a>
                        </div>
                    </div>
                </div>

                <div class="modal-container-rechazar">
                    <div class="modal modal-close">
                        <p class="close">X</p>
                        <div class="modal-textos">
                            INGRESE LAS OBSERVACIONES
                        </div>
                        <div class="modal-textbox">
                            <input type="text" runat="server" id="txtObservaciones" value="OBSERVACIÓN" onclick="if(this.value=='OBSERVACIÓN') this.value=''" required />
                        </div>
                        <div class="modal-button">
                            <asp:Button runat="server" CssClass="btnAceptar" ID="btnEnviarObservaciones" Text="ENVIAR" OnClick="btnEnviarObservaciones_Click" />
                            <a class="btnCancelar">CANCELAR</a>
                        </div>
                    </div>
                </div>

                <div class="modal-container-mensajeAceptado" id="modalMensajeAprobado">
                    <div class="modal modal-close" id="modal">
                        <p class="close">X</p>
                        <div class="modal-textos" style="font-weight: bold">
                            ¡POSTULACIÓN APROBADA!
                        </div>
                        <div class="modal-button">
                            <a class="aAceptar">ACEPTAR</a>
                        </div>
                    </div>
                </div>

                <div class="modal-container-mensajeRechazado" id="modalMensajeRechazado">
                    <div class="modal modal-close" id="modalR">
                        <p class="close">X</p>
                        <div class="modal-textos" style="font-weight: bold">
                            ¡POSTULACIÓN RECHAZADA!
                        </div>
                        <div class="modal-button">
                            <a class="aAceptar">ACEPTAR</a>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
    <script src="../Js/PModal.js"></script>
</asp:Content>
