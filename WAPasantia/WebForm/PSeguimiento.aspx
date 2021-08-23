<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPAdministrativo.Master" AutoEventWireup="true" CodeBehind="PSeguimiento.aspx.cs" Inherits="WAPasantia.WebForm.PSeguimiento" %>

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
                                <a id="ContentPlaceHolder1_LKBSiu" title="Gestiona tu información personal" style="display: inline-block; font-size: 13px; height: 50px; width: 750px; margin: 0 5px 0 0;"><b style="font-size: 35px">S</b>OLICITUD DE PASANTIAS</a>
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
                            <tr">
                                <td class="buscador">Buscar por nombre:
                                    <asp:TextBox runat="server" ID="txtBuscarNombre" OnTextChanged="txtBuscarNombre_TextChanged"/>
                                </td>
                                <td class="buscador">Buscar por carrera:
                                    <asp:TextBox runat="server" ID="txtBuscarCarrera" OnTextChanged="txtBuscarCarrera_TextChanged"/>
                                </td>
                                <td class="buscador">Buscar por estado:
                                    <asp:DropDownList runat="server" ID="ddlBuscarEstado" OnTextChanged="ddlBuscarEstado_TextChanged" AutoPostBack="true">
                                        <asp:ListItem>Pendiente</asp:ListItem>
                                        <asp:ListItem>Revisado</asp:ListItem>
                                    </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td colspan="3">
                                    <div runat="server">
                                        <asp:GridView runat="server" ID="GVPasantia" OnRowCommand="GVPasantia_RowCommand" AutoGenerateColumns="false" HeaderStyle-CssClass="header" RowStyle-CssClass="contentItem" CellPadding="4" CellSpacing="0" Width="100%">
                                            <Columns>
                                                <asp:BoundField DataField="Id_Postulacion" ItemStyle-CssClass="hiden">
                                                    <HeaderStyle CssClass="hiden" />
                                                    <ItemStyle CssClass="hiden" />
                                                    <FooterStyle CssClass="hiden" />
                                                </asp:BoundField>
                                                <asp:BoundField DataField="NombreCompleto" HeaderText="NOMBRE COMPLETO" />
                                                <asp:BoundField DataField="NombreInstitucion" HeaderText="EMPRESA" />
                                                <asp:BoundField DataField="FechaRegistro" HeaderText="FECHA DE POSTULACIÓN" />
                                                <asp:ButtonField Text="HABILITAR" HeaderText="HABILITAR" CommandName="Select" ControlStyle-CssClass="detalle" ButtonType="Button" />
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