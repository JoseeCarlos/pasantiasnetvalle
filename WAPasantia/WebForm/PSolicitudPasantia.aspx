<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPAdministrativo.Master" AutoEventWireup="true" CodeBehind="PSolicitudPasantia.aspx.cs" Inherits="WAPasantia.WebForm.PSolicitudPasantia" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/SGridView.css" rel="stylesheet" />
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
        <div class="caja">
            <fieldset>
                <legend>
                    <span>Lista de Pasantias</span>
                </legend>
                <form method="post" runat="server">
                    <table align="center" style="width: 100%;">
                        <tbody>
                            <tr>
                                <td class="buscador">Buscar por nombre:
                                    <asp:TextBox runat="server" ID="txtBuscarNombre" AutoPostBack="true" OnTextChanged ="txtBuscarNombre_TextChanged"></asp:TextBox></td>
                                <td class="buscador">Buscar por estado:
                                    <asp:DropDownList runat="server" ID="ddlBuscarEstado" OnTextChanged="ddlBuscarEstado_TextChanged" AutoPostBack="true">
                                        <asp:ListItem>Pendiente</asp:ListItem>
                                        <asp:ListItem>Revisado</asp:ListItem>
                                    </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <div runat="server">
                                        <asp:GridView runat="server" ID="GVPasantia" OnRowCommand="GVPasantia_RowCommand" AutoGenerateColumns="false" HeaderStyle-CssClass="header" RowStyle-CssClass="contentItem" CellPadding="4" CellSpacing="0" Width="100%">
                                            <Columns>
                                                <asp:BoundField DataField="Id_Postulacion" ItemStyle-CssClass="hiden">
                                                    <HeaderStyle CssClass="hiden" />
                                                    <ItemStyle CssClass="hiden" />
                                                    <FooterStyle CssClass="hiden" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="NombreCompleto" HeaderText="NOMBRE COMPLETO" />
                                                <asp:BoundField DataField="NombreCarrera" HeaderText="CARRERA" />
                                                <asp:BoundField DataField="Correo" ItemStyle-CssClass="hiden">
                                                    <HeaderStyle CssClass="hiden" />
                                                    <ItemStyle CssClass="hiden" />
                                                    <FooterStyle CssClass="hiden" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="NombreInstitucion" HeaderText="EMPRESA" />
                                                <asp:BoundField DataField="FechaRegistro" HeaderText="FECHA DE POSTULACIÓN" />
                                                <asp:ButtonField Text="VER DETALLE" HeaderText="VER DETALLE" CommandName="Select" ControlStyle-CssClass="detalle" ButtonType="Button" />
                                                <asp:ButtonField Text="ACEPTAR" HeaderText="ACEPTAR" CommandName="Aceptar" ItemStyle-CssClass="aceptar" ControlStyle-CssClass="controlItem" ButtonType="Link" />
                                                <asp:ButtonField Text="RECHAZAR" HeaderText="RECHAZAR" CommandName="Rechazar" ItemStyle-CssClass="rechazar" ControlStyle-CssClass="controlItem" ButtonType="Link" />
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align: center"></td>
                            </tr>
                        </tbody>
                    </table>
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
                                <asp:Button runat="server" CssClass="btnAceptar" ID="btnEnviarObservaciones" Text="ENVIAR" OnClick="btnEnviarObservaciones_Click"/>
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
            </fieldset>
        </div>
    </div>
    <script src="../Js/PModal.js"></script>
</asp:Content>


