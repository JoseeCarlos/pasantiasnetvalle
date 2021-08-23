<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.Master" AutoEventWireup="true" CodeBehind="PMenu.aspx.cs" Inherits="WAPasantia.WebForm.PMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<link href="../Estilo/SNotificacion.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div>
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
									<td class="LBLContenido" >BIBLIOTECA DIGITAL</td>
								</tr>
							</table>
							<table cellpadding="0" cellspacing="0" style="border-width:0;" >
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido">POSTULAR A BECAS</td>
								</tr>
							</table>
							<table cellpadding="0" cellspacing="0" style="border-width:0;" >
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido"><a href="PFormularioPasantia.aspx" style="display:inline-block;" class="linkNoticacion">PASANTIAS<h8><b><font color='red'> - Nuevo</font></b></h8></a></td>
								</tr>
							</table>
							<table cellpadding="0" cellspacing="0" style="border-width:0;">
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido">BIBLIOTECAS VIRTUALES</td>
								</tr>
							</table>
							<table cellpadding="0" cellspacing="0" style="border-width:0;">
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido">CONTRASEÑA DE CORREO</td>
								</tr>
							</table>
							<table cellpadding="0" cellspacing="0" style="border-width:0;">
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido">FORMAR HORARIO</td>
								</tr>
							</table>
							<table cellpadding="0" cellspacing="0" style="border-width:0;">
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido">FORMULARIOS</td>								
								</tr>
							</table>
							<table cellpadding="0" cellspacing="0" style="border-width:0;">
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido">PLAN DE PAGOS</td>
								</tr>
							</table>
							<table cellpadding="0" cellspacing="0" style="border-width:0;">
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido">PUBLICACIONES</td>
								</tr>
							</table>
							<table cellpadding="0" cellspacing="0" style="border-width:0;">
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido">DOCUMENTOS Y REGLAMENTOS</td>
								</tr>
							</table>
							<table cellpadding="0" cellspacing="0" style="border-width:0;">
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido">CONSULTA A BIBLIOTECA</td>
								</tr>
							</table>
							<table cellpadding="0" cellspacing="0" style="border-width:0;">
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido">SOFTWARE ACADEMICO</td>
								</tr>
							</table>
							<table cellpadding="0" cellspacing="0" style="border-width:0;">
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido">LIBROS Y REVISTAS</td>
								</tr>
							</table>
							<table cellpadding="0" cellspacing="0" style="border-width:0;">
								<tr class="LBLContenido">
									<td ><a><img src="../Imagenes/bullet_selected.png" alt="" style="border-width:0;"/></a></td>
									<td class="LBLContenido">SIMULADORES</td>
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
