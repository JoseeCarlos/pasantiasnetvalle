<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPAdministrativo.Master" AutoEventWireup="true" CodeBehind="PInicioCartaConvenio.aspx.cs" Inherits="WAPasantia.WebForm.PInicioCartaConvenio" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript" src="../Js/JCartaInicioConvenio.js"></script>
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
                                <a id="ContentPlaceHolder1_LKBTips" title="Tips para tomar en cuenta" style="display: inline-block; font-size: 13px; height: 50px; width: 100px; margin: 0 5px 0 0;"><style="font-size: 35px"/></a>
                            </li>
                            <li id="ContentPlaceHolder1_li1">
                                <a id="ContentPlaceHolder1_LKBPerfil" title="Revisa tu perfil de usuario" style="display: inline-block; font-size: 13px; height: 50px; width: 110px; padding-left: 15px; padding-right: 15px">
                                    <asp:Image ID="Image2" runat="server" Style="height: 35px; width: 35px; border: 0 none; margin-top: 5px" ImageUrl="~/Imagenes/perfil.png"/>
                                </a>
                            </li>
                        </ul>
                    </td>
                </tr>
            </tbody>
        </table>
    <div class="">
        <div class="form-style-10">
            <h1>Datos<span>Asignación de inicio de pasantía</span></h1>
            <div class="caja">
                <div style="width: 350px; height: 150px;">
                    <div class="datos">
                        <div>
                            <label for="">Estudiante :</label>
                            <br>
                            <label for="" style="background-color: #ffffff"><span id="sPostulacion" runat="server">---</span></label>
                        </div>
                        <div>
                            <label for="">Empresa :</label><br>
                            <label for="" style="background-color: #ffffff"><span id="sEstudiante" runat="server">---</span></label>
                        </div>
                    </div>
                </div>
                <div style="width: 470px; height: 300px;">

                    <form runat="server"  method="post">
                        <div class="datos">
                            <div>
                                <label for="">Codigo Carta :</label>
                                <input  runat="server" type="text" id="codigoCarta" name="codigoCarta">
                            </div>
                            <div>
                                <label for="">Fecha Inicio Pasantia :</label>
                                <input  runat="server" ID="fechaActual" name="fechaActual" type="date" onchange="handler(event);" min="2021-06-27" max="2040-06-27">

                            </div>
                            <div>
                                <label for="">Fecha Plazo :</label>
                                <input runat="server" ID="fechaPlazo" name="fechaPlazo" type="date" value="2021-06-27" disabled>

                            &nbsp;</div>
                        </div>

                     

                        <div class="content_button">
                            <asp:button type="submit" id="btnVisualizar" runat="server" onclick="btnVisualizar_Click" class="btn" Text="Visualizar"/>
                            
                            <asp:Button class="btn" ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
                        </div>
                        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />

                   </form>

                </div>
            </div>


        </div>

    </div>
         </div>
</asp:Content>
