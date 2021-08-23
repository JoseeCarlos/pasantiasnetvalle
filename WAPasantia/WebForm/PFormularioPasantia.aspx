<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PaginaMaestra/MPInicio.Master" CodeBehind="PFormularioPasantia.aspx.cs" Inherits="WAPasantia.WebForm.PFormularioPasantia" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Estilo/SModal.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-style-10">
        <h1>Formulario<span>Datos a completar para la pasantia</span></h1>



        <form runat="server">
            <div class="section">Datos del Estudiante</div>
            <div class="inner-wrap">

                <label>Nombre:<input type="text" name="field01" id="txtNombreEstudiante" runat="server" /></label>
                <label>Apellido:<input type="text" name="field02" id="txtApellidoEstudiante" runat="server" /></label>
                <label>Cedula de identidad:<input type="text" name="field03" id="txtCi" runat="server" /></label>
                <label>Emitido en:<input type="text" name="field04" id="txtEmitido" runat="server" /></label>
                <label>Celular:<input type="number" name="field05" id="txtCelularEstudiante" runat="server" /></label>
                <label>Telefono:<input type="number" name="field06" id="txtTelefonoEstudiante" runat="server" /></label>
                <label>E-Mail:<input type="email" name="field07" id="txtEmailEstudiante" runat="server" /></label>



            </div>






            <!--aqui se llena con los nombres de empresas -->



            <div id="datosE" runat="server" class="section">Datos de la Empresa</div>
            <br />





            <div class="section">
                <asp:DropDownList runat="server" ID="ddlBuscarEmpresa" class="aceptar123" OnTextChanged="ddlBuscarEmpresa_TextChanged" AutoPostBack="false">
                </asp:DropDownList>
            </div>

            <div id="datosE1" class="inner-wrap" runat="server">




                <label>Carta dirigida a :<input type="text" name="txtResponsable" id="txtResponsable" runat="server" /></label>
                <label>Cargo:<input type="text" name="txtCargo" id="txtCargo" runat="server" /></label>
                <label>Empresa:<input type="text" name="txtEmpresa" id="txtEmpresa" runat="server" /></label>
                <label>Direccion:<input type="text" name="txtDireccion" id="txtDireccion" runat="server" /></label>
                <label>Telefono:<input type="number" name="txtTelefono" id="txtTelefono" runat="server" /></label>
                <label>Ciudad:<input type="text" name="txtCiudad" id="txtCiudad" runat="server" /></label>
                <label>E-Mail:<input type="email" name="txtEmail" id="txtEmail" runat="server" /></label>
                <asp:Button Text="Editar" runat="server" />
                <asp:Button Text="Cancelar" runat="server" />
                <asp:Button Text="Aceptar" runat="server" />
            </div>



            <div class="section">
            </div>

            <div class="section">

                <div id="Div2" runat="server" class="section">Datos de la Modalidad</div>
                <br />
                <asp:DropDownList runat="server" ID="practicaM" OnTextChanged="practica_TextChanged" AutoPostBack="true">
                    <asp:ListItem Text="Practica profecional" />
                    <asp:ListItem Text="Modalidad de titulacion" />
                </asp:DropDownList><br />
                <br />



                <asp:DropDownList runat="server" ID="modalidadT">
                </asp:DropDownList><br />
                <br />

            </div>





            <div class="button-section">
                <br />
                <br />
                <br />
                <br />
                <hr style="color: #681e3c;" />
                <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" />
            </div>



            <!-- llamar-->




            <!--Modal Crear Empresa -->
            <div class="modal-container-empresa">
                <div class="modal modal-close">
                    <div class="modal-textos">
                        <h1>INGRESE DATOS DE LA EMPRESA</h1>
                    </div>
                    <div class="modal-textbox">
                        <h2 style="color: #681e3c;">Datos del Responsable</h2>
                        <asp:Label Text="" runat="server" /><br />
                        <asp:TextBox runat="server" ID="txtNombreResponsable" placeholder="Nombres"></asp:TextBox><br />
                        <asp:TextBox runat="server" ID="txtApellido1Responsable" placeholder="Primer apellido"></asp:TextBox><br />
                        <asp:TextBox runat="server" ID="txtApellido2Responsable" placeholder="Segundo Apellido"></asp:TextBox><br />
                        <hr />
                        <hr />
                        <h2 style="color: #681e3c;">Datos de la Institucion o Empresa</h2>
                        <asp:Label Text="" runat="server" /><br />
                        <asp:TextBox runat="server" ID="txtCargoIntitucion" placeholder="Cargo "></asp:TextBox><br />
                        <asp:TextBox runat="server" ID="txtNombreInstitucion" placeholder="Nombre institucion"></asp:TextBox><br />
                        <asp:TextBox runat="server" ID="txtDireccionInstitucion" placeholder="Direccion"></asp:TextBox><br />
                        <asp:TextBox runat="server" ID="txtTelefonoInstitucion" placeholder="Telefono"></asp:TextBox><br />
                        <asp:TextBox runat="server" ID="txtEmailInstitucion" placeholder="Email"></asp:TextBox><br />
                        <asp:DropDownList runat="server" ID="nombreCiudad"></asp:DropDownList><br />
                        <br />
                        <br />
                        <br />
                    </div>
                    <div class="modal-button">
                        <asp:Button runat="server" Text="CANCELAR" CssClass="btnCancelar" ID="btnCancelarModal" OnClick="btnCancelarModal_Click" />
                        <asp:Button runat="server" ID="registrarEmpresa" Text="REGISTRAR" OnClick="registrarEmpresa_Click" />
                    </div>
                </div>
            </div>

            <!-- Fin Modal Crear Empresa -->




        </form>

    </div>
    <script src="../Js/PModalAgregarEmpresa.js"></script>
</asp:Content>
