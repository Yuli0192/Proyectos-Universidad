<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="frmRegistrarServicio.aspx.vb" Inherits="SolSiscoveWeb.frmRegistrarServicio" title="RegistrarServicio" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divPrincipal" style="height: 585px; width:1029px;">
        <br />
        <div id="divEncabezado" class ="titulos" align="center" style="width: 1029px; height: 45px;">
        <asp:Label 
                ID="lblRegistar" runat="server" Text="Registrar Servicio"></asp:Label>
            
         </div>
         
        <div id="divDatos" style="width: 1029px; height: 487px;" align="center">
        
        
               
                    <table id="RegistrarServicio" style="width:500px;">
                
                        <tr>
                                 <td><asp:Label ID="lblCodigo" runat="server" Text="Codigo:" Font-Size="11pt"></asp:Label> </td>           
                                 <td><asp:TextBox ID="txtCodigo" runat="server" Height="25px" Width="210px" 
                                 ToolTip="PP-897" Font-Size="11pt"></asp:TextBox> 
                                 </td>
                        </tr>
                        
                          
                        <tr>
                                 <td><asp:Label ID="lblNombre" runat="server" Text="Nombre:" Font-Size="11pt"></asp:Label> </td>           
                                 <td><asp:TextBox ID="txtNombre" runat="server" Height="25px" Width="210px" 
                                 ToolTip="Power Ponit" Font-Size="11pt"></asp:TextBox> 
                                 </td>
                        </tr>         
                                 
                        
                        <tr>
                                 <td><asp:Label ID="lblDescripcion" runat="server" Text="Descripcion:" Font-Size="11pt"></asp:Label> </td>           
                                 <td><asp:TextBox ID="txtDescripcion" runat="server" Height="25px" Width="210px" 
                                 ToolTip="Power Point" Font-Size="11pt"></asp:TextBox> 
                                 </td>
                        </tr>         
                        
          
                        <tr>
                                 <td><asp:Label ID="lblPrecioColones" runat="server" Text="Precio en colones:" Font-Size="11pt"></asp:Label> </td>           
                                 <td><asp:TextBox ID="txtPrecioColones" runat="server" Height="25px" Width="210px" 
                                 ToolTip="15.000" Font-Size="11pt"></asp:TextBox> 
                                 </td>
                        </tr>
                        
                        
                         <tr>
                                 <td><asp:Label ID="lblPrecioDolares" runat="server" Text="Precio en dolares:" Font-Size="11pt"></asp:Label> </td>           
                                 <td><asp:TextBox ID="txtPrecioDolares" runat="server" Height="25px" Width="210px" 
                                 ToolTip="15.000" Font-Size="11pt"></asp:TextBox> 
                                 </td>
                        </tr> 
                        
                        
                        <tr>
                                 <td><asp:Label ID="lblJuniorColones" runat="server" Text="Comision junior en colones:" Font-Size="11pt"></asp:Label> </td>           
                                 <td><asp:TextBox ID="txtJuniorColones" runat="server" Height="25px" Width="210px" 
                                 ToolTip="15.000" Font-Size="11pt"></asp:TextBox> 
                                 </td>
                        </tr>
                        
                        
                         <tr>
                                 <td><asp:Label ID="lblJuniorDolares" runat="server" Text="Comision junior en dolares:" Font-Size="11pt"></asp:Label> </td>           
                                 <td><asp:TextBox ID="txtJuniorDolares" runat="server" Height="25px" Width="210px" 
                                 ToolTip="15.000" Font-Size="11pt"></asp:TextBox> 
                                 </td>
                        </tr>
                        
                        
                         <tr>
                                 <td><asp:Label ID="lblSeniorColones" runat="server" Text="Comision senior en colones:" Font-Size="11pt"></asp:Label> </td>           
                                 <td><asp:TextBox ID="txtSeniorColones" runat="server" Height="25px" Width="210px" 
                                 ToolTip="15.000" Font-Size="11pt"></asp:TextBox> 
                                 </td>
                        </tr>
                        
                        
                        <tr>
                                 <td><asp:Label ID="lblSeniorDolares" runat="server" Text="Comision senior en dolares:" Font-Size="11pt"></asp:Label> </td>           
                                 <td><asp:TextBox ID="txtSeniorDolares" runat="server" Height="25px" Width="210px" 
                                 ToolTip="15.000" Font-Size="11pt"></asp:TextBox> 
                                 </td>
                        </tr>
                        
                        
                        <tr>
                                 <td><asp:Label ID="lblMsterColones" runat="server" Text="Comision master en colones:" Font-Size="11pt"></asp:Label> </td>           
                                 <td><asp:TextBox ID="txtMasterColones" runat="server" Height="25px" Width="210px" 
                                 ToolTip="15.000" Font-Size="11pt"></asp:TextBox> 
                                 </td>
                        </tr>
                        
                        
                        <tr>
                                 <td><asp:Label ID="lblMasterDolares" runat="server" Text="Comision master en dolares:" Font-Size="11pt"></asp:Label> </td>           
                                 <td><asp:TextBox ID="txtMasterDolares" runat="server" Height="25px" Width="210px" 
                                 ToolTip="15.000" Font-Size="11pt"></asp:TextBox> 
                                 </td>
                        </tr>    
                
                    
                    </table>
                    
                    <div id="botonesRegistrarServicio" style="text-align:right; width:370px; padding-top:20px;" >
                                 <asp:ImageButton ID="bntRegistrar" runat="server"  
                                ImageUrl="~/Imagenes/btnRegistrar.png" ToolTip="Registrar" style="margin-right:10px;"/>
                                
                                <asp:ImageButton ID="bntLimpiar" runat="server" 
                                 ImageUrl="~/Imagenes/btnLimpiar.png" ToolTip="Limpiar"/>
                                 </div>
                
                               
     
               
           
           

        </div>
        
         </div>
       
       
</asp:Content>
   

