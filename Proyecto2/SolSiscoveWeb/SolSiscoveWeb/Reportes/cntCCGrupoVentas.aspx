<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="cntCCGrupoVentas.aspx.vb" Inherits="SolSiscoveWeb.cntCCGrupoVentas" 
    title="Untitled Page" %>
<%@ Register Assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <div style="width:1029px; padding-top:20px;">
            <asp:Table ID="Table1" runat="server" Height="139px">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblTitulo" runat="server" Text="Generar Reporte Comisiones por Grupo de Ventas" Font-Names="Arial" Font-Size="20pt" ForeColor="#000066"></asp:Label>
                    </asp:TableCell>
                </asp:TableRow><asp:TableRow>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <br /><br /><br /><br /><br />
                        <asp:Label ID="lblId" runat="server" Text="Id del Grupo de Ventas:" Font-Names="Arial" Font-Size="11pt"></asp:Label>
                        &nbsp;&nbsp;
                        <asp:TextBox ID="txtCriterio" runat="server"></asp:TextBox>
                        &nbsp;&nbsp
                        <asp:ImageButton ID="btnGenerarReporte" runat="server" ImageUrl="~/Imagenes/btnGenerarReporte.png" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <CR:CrystalReportViewer ID="crvGrupo" runat="server" DisplayGroupTree="False"  
                            AutoDataBind="True" Height="1106px" DisplayToolbar="True"
                            Width="876px" Visible="False"/>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </center>
</asp:Content>
