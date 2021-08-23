<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPAdministrativo.Master" AutoEventWireup="true" CodeBehind="PSubirArchivos.aspx.cs" Inherits="WAPasantia.WebForm.PSubirArchivos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/SGridView.css" rel="stylesheet" />
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
                    
                    <label>Carta de aceptacion de la carrera (PDF)</label>
                    <br />
                    <asp:FileUpload ID="SubirCartaCarrera" runat="server" />
                    <br />
                    <label>Carta de aceptacion de la empresa (PDF)</label>
                    <br />
                    <asp:FileUpload ID="SubirCartaEmpresa" runat="server" />
                    <br />
                    <label>Fotocopia simple de NIT de la empresa (Opcional)</label>
                    <br />
                    <asp:FileUpload ID="SubirNIT" runat="server" />
                    <br />
                    <asp:Button ID="btnSubirArchivos" runat="server" Text="SubirArchivos" OnClick="btnSubirArchivos_Click" />
                    <br />
                    <label runat="server" id="MensageDeError">...</label>
                    


                </form>
            </fieldset>
        </div>
    </div>
</asp:Content>
