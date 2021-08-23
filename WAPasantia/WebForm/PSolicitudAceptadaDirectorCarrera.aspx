<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPAdministrativo.Master" AutoEventWireup="true" CodeBehind="PSolicitudAceptadaDirectorCarrera.aspx.cs" Inherits="WAPasantia.WebForm.PSolicitudAceptadaDirectorCarrera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/SGridView.css" rel="stylesheet" />
    <link href="../Estilo/SModal.css" rel="stylesheet" />
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
                    <span>Solicitudes Aceptadas</span>
                </legend>
                <form method="post" runat="server">
                    <table align="center" style="width: 100%;">
                        <tbody>
                            <tr">
                                <td class="buscador">Buscar por nombre:
                                    <asp:TextBox runat="server" ID="txtBuscarNombre" AutoPostBack="true" OnTextChanged="txtBuscarNombre_TextChanged"> </asp:TextBox></td>
                                <td class="buscador">Buscar por estado:
                                    <asp:DropDownList runat="server" ID="ddlBuscarEstado"  AutoPostBack="true" OnTextChanged="ddlBuscarEstado_TextChanged">
                                        <asp:ListItem>Aceptado</asp:ListItem>
                                        <asp:ListItem>Revisado</asp:ListItem>
                                    </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <div runat="server">
                                        <asp:GridView  runat="server" ID="GVPasantia" OnRowCommand="GVPasantia_RowCommand" AutoGenerateColumns="false" HeaderStyle-CssClass="header" RowStyle-CssClass="contentItem" CellPadding="4" CellSpacing="0" Width="100%">
                                            <Columns>
                                                <asp:BoundField DataField="Id_Estudiante" ItemStyle-CssClass="hiden">
                                                    <HeaderStyle CssClass="hiden" />
                                                    <ItemStyle CssClass="hiden" />
                                                    <FooterStyle CssClass="hiden" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="Id_Postulacion" ItemStyle-CssClass="hiden">
                                                    <HeaderStyle CssClass="hiden" />
                                                    <ItemStyle CssClass="hiden" />
                                                    <FooterStyle CssClass="hiden" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="NombreCompleto" HeaderText="NOMBRE COMPLETO" />
                                                <asp:BoundField HeaderText="CARRERA" />
                                                <asp:BoundField DataField="NombreInstitucion" HeaderText="EMPRESA" />
                                                <asp:BoundField DataField="FechaRegistro" HeaderText="FECHA DE POSTULACIÓN" />
                                                <asp:ButtonField Text="CARTA CONVENIO" HeaderText="GENERAR CARTA" CommandName="Select" ControlStyle-CssClass="detalle" ButtonType="Button" />
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
                </form>
            </fieldset>
        </div>
    </div>
    <script src="../Js/PModal.js"></script>
</asp:Content>