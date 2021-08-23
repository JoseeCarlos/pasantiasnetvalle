<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPAdministrativo.Master" AutoEventWireup="true" CodeBehind="PReportes.aspx.cs" Inherits="WAPasantia.WebForm.PReportes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center_content">
        <table style="width: 750px; text-align: center">
            <tbody>
                <tr>
                    <td>
                        <ul class="mainmenu">
                            <li id="ContentPlaceHolder1_liSiu">
                                <a id="ContentPlaceHolder1_LKBSiu" title="Gestiona tu información personal" style="display: inline-block; font-size: 13px; height: 50px; width: 440px; margin: 0 5px 0 0;"><b style="font-size: 35px">R</b>EPORTES</a>
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
            <fieldset style="width: auto; height: auto;">
                <legend>
                    <span>REPORTES</span>
                </legend>
                <form method="/" runat="server">
                    <table align="center" style="width: auto;">
                        <tbody>
                            <tr>
                                <td class="buscador">REPORTE GENERAL
                                    <asp:Button Text="GENERAR REPORTE" ID="ReportG" runat="server" OnClick="ReportG_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td class="buscador">REPORTE GENERAL POR AÑO
                                    <asp:TextBox ID="txtyear" placeholder="INGRESE EL AÑO" runat="server"></asp:TextBox>
                                    <asp:Button Text="GENERAR REPORTE" ID="ReportGFECHA" runat="server" OnClick="ReportGFECHA_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td class="buscador">REPORTE GENERAL POR FACULTAD
                                      <asp:DropDownList runat="server" Width="165px" ID="cbFacultad1" Height="28px" AutoPostBack="true">
                                          <asp:ListItem Text="ARQUITECTURA Y TURISMO" />
                                          <asp:ListItem Text="CIENCIAS DE LA SALUD" />
                                          <asp:ListItem Text="CIENCIAS EMPRESARIALES Y SOCIALES" />
                                          <asp:ListItem Text="INFORMATICA Y ELECTRONICA" />
                                          <asp:ListItem Text="TECNOLOGIA" />
                                      </asp:DropDownList>
                                    <asp:Button Text="GENERAR REPORTE" ID="ReportFac" runat="server" OnClick="ReportFac_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td class="buscador">REPORTE GENERAL POR FACULTAD POR AÑO
                                    <div class="row">
                                        <div class="col-md-6">
                                            <asp:DropDownList runat="server" Width="165px" ID="CbFacultad2" Height="28px" AutoPostBack="true">
                                                <asp:ListItem Text="ARQUITECTURA Y TURISMO" />
                                                <asp:ListItem Text="CIENCIAS DE LA SALUD" />
                                                <asp:ListItem Text="CIENCIAS EMPRESARIALES Y SOCIALES" />
                                                <asp:ListItem Text="INFORMATICA Y ELECTRONICA" />
                                                <asp:ListItem Text="TECNOLOGIA" />
                                            </asp:DropDownList>
                                        </div>
                                        <div class="col-md-6">
                                            <asp:TextBox ID="txtyear2" placeholder="INGRESE EL AÑO" runat="server"></asp:TextBox>
                                            <asp:Button Text="GENERAR REPORTE" ID="ReporteFacFecha" runat="server" OnClick="ReporteFacFecha_Click" />
                                        </div>
                                    </div>

                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <div runat="server">
                                        <asp:GridView ID="dg1" runat="server"></asp:GridView>
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


</asp:Content>
