<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPAdministrativo.Master" AutoEventWireup="true" CodeBehind="PMenuSecretariaCarrera.aspx.cs" Inherits="WAPasantia.WebForm.PMenuSecretaria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<link href="../Estilo/SNotificacion.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



	<div>
		<table style="width: 750px; text-align: center">
            <tbody>
                <tr>
                    <td>
                        <ul class="mainmenu">
                            <li id="ContentPlaceHolder1_liSiu">
                                <a id="ContentPlaceHolder1_LKBSiu" title="Gestiona tu información personal" style="display: inline-block; font-size: 13px; height: 50px; width: 440px; margin: 0 5px 0 0;"><b style="font-size: 35px">I</b>NICIO SECRETARIA INTERNACIONAL</a>
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
	 <table style="width: 100%" align="center" >
	  <tr>
	   <td>
	    <fieldset style="width: 800px" align="center">
			<legend style="text-align: left"></legend>
			<table width="800px">
				<tr id="ContentPlaceHolder1_CURecursosEstudiante_TRMenu">
					<td style="width: 25%; vertical-align: top">       
						<fieldset>
							<legend style="text-align: left">
								<span id="LBLLengend" class="cssLegend">Opciones</span>
							</legend>     
		
							<table cellpadding="0" cellspacing="0" style="border-width:0;" >
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido"><a href="PSolicitudAceptadaDirectorCarrera.aspx" style="display:inline-block;" class="linkNoticacion">CARTA CONVENIO</a></td>
								</tr>
							</table>
							
							<a id="ContentPlaceHolder1_CURecursosEstudiante_TRVMenu_SkipLink"></a>
	                </fieldset>
					</td>
					<td style="width: 70%; height: 100%; vertical-align: top"></td>
				</tr>
				<tr>
					<td style="width: 100%; vertical-align: top" colspan="2"></td>
				</tr>
				<tr>
					<td colspan="2" style="text-align: center">
						<span id="ContentPlaceHolder1_CURecursosEstudiante_LBLError" class="LabelMensajeError"></span>
					</td>
				</tr>
			</table>
		</fieldset>
	   </td>
	  </tr>
	 </table>
	</div>
</asp:Content>

