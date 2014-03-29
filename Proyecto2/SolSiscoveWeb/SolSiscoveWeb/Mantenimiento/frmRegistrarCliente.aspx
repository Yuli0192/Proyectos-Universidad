<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="frmRegistrarCliente.aspx.vb" Inherits="SolSiscoveWeb.frmRegistrarCliente" title="RegistrarCliente" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divPrincipal" style="height: 585px; width:1029px; padding-top:20px;">
        <%-- Label Registrar--%>
        <div id="divlblRegistrar">
        
            <asp:Label ID="lblRegistar" runat="server" Text="Registrar Cliente" 
                Font-Names="Arial" Font-Size="20pt" ForeColor="#000066"></asp:Label>
         
       </div>
       
       <table style="width:320px; text-align:right; padding-top:20px;">
       <tr>
       <td><asp:Label ID="lblId" runat="server" Text="Identificación:" Font-Size="11pt"></asp:Label></td>
       <td><asp:TextBox ID="txtId" runat="server" Height="25px" Width="210px" 
                    ToolTip="Ej.: 3224307" Font-Size="11pt"></asp:TextBox></td>
       </tr>
       
       <tr>
       <td><asp:Label ID="lblNombre" runat="server" Text="Nombre:" Font-Size="11pt"></asp:Label></td>
       <td><asp:TextBox ID="txtNombre" runat="server" Height="25px" Width="210px" 
                    ToolTip="Ej.: INA o Eduardo Solano Mate" Font-Size="11pt"></asp:TextBox></td>
       </tr>
       
       <tr>
       <td><asp:Label ID="lblTelefono" runat="server" Text="Teléfono:" Font-Size="11pt"></asp:Label></td>
       <td> <asp:TextBox ID="txtTelefono" runat="server" Height="25px" Width="210px" 
                    ToolTip="2574-1023" Font-Size="11pt"></asp:TextBox></td>
       </tr>
       
       
       <tr>
       <td><asp:Label ID="lblCorreo" runat="server" Text="Correo Cliente:" 
                    Font-Size="11pt"></asp:Label></td>
       <td><asp:TextBox ID="txtCorreo" runat="server" Height="25px" Width="210px" 
                    ToolTip="Ej.: cliente@argus.com" Font-Size="11pt"></asp:TextBox></td>
       </tr>
       
       <tr>
       <td><asp:Label ID="lblContacto" runat="server" Text="Contacto:" Font-Size="11pt"></asp:Label></td>
       <td> <asp:TextBox ID="txtContacto" runat="server" Height="24px" Width="210px" 
                    ToolTip="Ej.: Manuel Quesada Mate" Font-Size="11pt"></asp:TextBox></td>
       </tr>
       
       <tr>
       <td><asp:Label ID="lblDireccion" runat="server" Text="Dirección:" Font-Size="11pt"></asp:Label></td>
       <td>  <asp:TextBox ID="txtDireccion" runat="server" Height="25px" Width="210px" 
                    ToolTip="San Jose" Font-Size="11pt"></asp:TextBox></td>
       </tr>
       
 
       </table>
     
      
    

      <%-- Button Registrar--%>
        <div id="divRegistrar" style="width:320px; text-align:right; padding-top:10px;">
        
            <asp:ImageButton ID="bntRegistrar" runat="server" 
                ImageUrl="~/Imagenes/btnRegistrar.png" ToolTip="Registrar" Height="30px" 
                Width="30px"/>
                <asp:ImageButton ID="bntLimpiar" runat="server" 
                ImageUrl="~/Imagenes/btnLimpiar.png" ToolTip="Limpiar" />
       </div>
 
     </div>
</asp:Content>
   

