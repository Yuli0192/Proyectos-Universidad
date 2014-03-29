<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="ctnAyuda.aspx.vb" Inherits="SolSiscoveWeb.ctnAyuda" 
    title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
        #form1
        {
            height: 479px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 475px">
        <asp:Label ID="lblAyudaSiscove" runat="server" Text="Ayuda Siscove" runat="server" Font-Names="Arial" Font-Size="20pt" ForeColor="#000066"></asp:Label>
        <br /><br /><br />
        <asp:Table ID="tblContenedora" runat="server" Height="368px" Width="753px">
            <asp:TableFooterRow >
                <asp:TableCell Width="170" align="left">
                    <asp:TreeView ID="tvAyuda" runat="server">
                        <Nodes>
                            <asp:TreeNode Text="Cliente" Expanded="False">
                                <asp:TreeNode Text="Buscar Cliente" ></asp:TreeNode>
                                <asp:TreeNode Text="Eliminar Cliente" ></asp:TreeNode>
                                <asp:TreeNode Text="Modificar Cliente" ></asp:TreeNode>
                                <asp:TreeNode Text="Registrar Cliente" ></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="Factura" Expanded="False">
                                <asp:TreeNode Text="Buscar Factura"  ></asp:TreeNode>
                                <asp:TreeNode Text="Eliminar Factura"  ></asp:TreeNode>
                                <asp:TreeNode Text="Modificar Factura" ></asp:TreeNode>
                                <asp:TreeNode Text="Registrar Factura" ></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="Grupo de Ventas" Expanded="False">
                                <asp:TreeNode Text="Buscar Grupo de Ventas"></asp:TreeNode>
                                <asp:TreeNode Text="Eliminar Grupo de Ventas" ></asp:TreeNode>
                                <asp:TreeNode Text="Modificar Grupo de Ventas"></asp:TreeNode>
                                <asp:TreeNode Text="Registrar Grupo de Ventas"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="Plan de Ventas" Expanded="False">
                                <asp:TreeNode Text="Buscar Plan de Ventas"></asp:TreeNode>
                                <asp:TreeNode Text="Eliminar Plan de Ventas"></asp:TreeNode>
                                <asp:TreeNode Text="Modificar Plan de Ventas"></asp:TreeNode>
                                <asp:TreeNode Text="Registrar Plan de Ventas" ></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="Servicio" Expanded="False">
                                <asp:TreeNode Text="Buscar Servicio"></asp:TreeNode>
                                <asp:TreeNode Text="Eliminar Servicio"></asp:TreeNode>
                                <asp:TreeNode Text="Modificar Servicio"></asp:TreeNode>
                                <asp:TreeNode Text="Registrar Servicio"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="Sesión" Expanded="False">
                                <asp:TreeNode Text="Iniciar Sesión"></asp:TreeNode>
                                <asp:TreeNode Text="Cerrar Sesión"></asp:TreeNode>
                            </asp:TreeNode>
                            <asp:TreeNode Text="Usuario" Expanded="False">
                                <asp:TreeNode Text="Buscar Usuario"></asp:TreeNode>
                                <asp:TreeNode Text="Eliminar Usuario"></asp:TreeNode>
                                <asp:TreeNode Text="Modificar Usuario"></asp:TreeNode>
                                <asp:TreeNode Text="Registrar Usuario"></asp:TreeNode>
                            </asp:TreeNode>
                        </Nodes>
                    </asp:TreeView>
                </asp:TableCell>
                <asp:TableCell ColumnSpan="2">
                    <asp:TextBox ID="txtAtuda" runat="server"  ReadOnly="True" TextMode="MultiLine" Height="390" Width="500" Font-Size="15"></asp:TextBox>                        
                </asp:TableCell> 
            </asp:TableFooterRow>
        </asp:Table>
    </div>
</asp:Content>
