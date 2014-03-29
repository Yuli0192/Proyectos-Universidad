<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="ctnRegistrarUsuario.aspx.vb" Inherits="SolSiscoveWeb.ctnRegistrarUsuario" 
    title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
    #frmRegistrarUsuario
    {
        height: 446px;
    }
    #divContenedorCajas
    {
        height: 268px;
        width: 170px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <div id="divPrincipal">
            <asp:Table runat="server" Width="1029px">
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2">
                        <div id="divContenedor" style="text-align:center;">
                        <br /><br />
                            <asp:Label ID="lblTitulo" runat="server" Text="Registrar Usuario" Font-Names="Arial" Font-Size="20pt" ForeColor="#000066"></asp:Label>
                        </div>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <div id="divContenedorValores" style="text-align:right;">
                            <br /><br /><br />
                            <asp:Label ID="lblCedula" runat="server" Text="Cédula:" Font-Names="Arial" Font-Size="11pt"></asp:Label>          
                            &nbsp;
                            <br /><br /><br />
                            <asp:Label ID="nombre" runat="server" Text="Nombre: " Font-Names="Arial" Font-Size="11pt"></asp:Label>
                            &nbsp;
                            <br /><br /><br />
                            <asp:Label ID="lblApellido1" runat="server" Text="Primer Apellido: " Font-Names="Arial" Font-Size="11pt"></asp:Label>
                            &nbsp;
                            <br /><br /><br />
                            <asp:Label ID="lblApellido2" runat="server" Text="Segundo Apellido: " Font-Names="Arial" Font-Size="11pt"></asp:Label>
                            &nbsp;
                            <br /><br /><br />
                            <asp:Label ID="lblCorreo" runat="server" Text="Correo Electrónico: " Font-Names="Arial" Font-Size="11pt"></asp:Label>
                            &nbsp;
                            <br /><br /><br />
                            <asp:Label ID="lblContrasenna" runat="server" Text="Contraseña: " Font-Names="Arial" Font-Size="11pt"></asp:Label>
                            &nbsp;
                            <br /><br /><br />
                            <asp:Label ID="lblRol" runat="server" Text="Rol: " Font-Names="Arial" Font-Size="11pt"></asp:Label>
                            &nbsp;
                            <br /><br /><br />
                            <asp:Label ID="lblDepartamento" runat="server" Text="Departamento: " Font-Names="Arial" Font-Size="11pt"></asp:Label>
                            &nbsp;
                        </div>
                    </asp:TableCell>
                    <asp:TableCell>
                        <div id="divContenedorLlenar" style="text-align:left;">
                            <br /><br /><br />
                            <asp:TextBox ID="txtCedula" runat="server" Width="154px" 
                            style="margin-top: 4px"></asp:TextBox>
                            <br /><br />
                            <asp:TextBox ID="txtNombre" runat="server" Width="154px" 
                            style="margin-top: 19px"></asp:TextBox>
                            <br /><br />
                            <asp:TextBox ID="txtApellido1" runat="server" Width="154px" 
                            style="margin-top: 15px"></asp:TextBox>
                            <br /><br />
                            <asp:TextBox ID="txtApellido2" runat="server" Width="154px" 
                            style="margin-top: 14px"></asp:TextBox>
                            <br /><br />
                            <asp:TextBox ID="txtCorreo" runat="server" Width="154px" 
                            style="margin-top: 19px"></asp:TextBox>
                             <br /><br />
                            <asp:TextBox ID="txtContrasenna" runat="server" Width="154px" 
                             TextMode="Password" style="margin-top: 20px"></asp:TextBox>
                            
                            <br /><br />
                            <asp:DropDownList ID="dlbRol" runat="server" Height="24px" 
                            style="margin-left: 0px; margin-top: 14px" Width="154px">
                            </asp:DropDownList>
                            <br /><br />
                            <asp:DropDownList ID="dlbDepartamento" runat="server" Height="24px" 
                            style="margin-left: 0px; margin-top: 26px" Width="154px">
                            </asp:DropDownList>
                        </div>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2">
                        <div id="divContenedorBotones" style="text-align:center;">
                            <br />
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:ImageButton ID="bntRegistrar" runat="server" 
                            ImageUrl="~/Imagenes/btnRegistrar.png" ToolTip="Registrar"/>
                            &nbsp;&nbsp;
                            <asp:ImageButton ID="bntLimpiar" runat="server" 
                            ImageUrl="~/Imagenes/btnLimpiar.png" ToolTip="Limpiar" />    
                        </div>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </center>
</asp:Content>
