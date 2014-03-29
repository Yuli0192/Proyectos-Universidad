<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="BuscarModificarFactura.aspx.vb" Inherits="SolSiscoveWeb.BuscarModificarFactura" 
    title="Untitled Page" %>

<%@ Register Assembly="EO.Web" Namespace="EO.Web" TagPrefix="eo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #FacturaBuscar
        {
            width: 441px;
        }
        .style1
        {
            width: 79px;
        }
        .style2
        {
            width: 248px;
        }
        #FacuraModificar
        {
            width: 526px;
            top: -592px;
            left: 210px;
        }
        .style3
        {
            width: 232px;
        }
        .style4
        {
            width: 214px;
        }
        .style5
        {
            width: 165px;
        }
        #PrincipalFactura
        {
            height: 639px;
        }
        .style6
        {
            width: 284px;
        }
        .style7
        {
            width: 31px;
        }
        .style8
        {
            width: 21px;
        }
        .style9
        {
            height: 28px;
        }
        .style10
        {
            width: 337px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id= "PrincipalFactura" 
        style="width: 1024px; font-family: Arial, Helvetica, sans-serif; font-size: smaller;">
    
    <div id="titulo" style="width:1024"><p>Modificar Factura</p></div>
    
        <div id="FacturaBuscar" align="left" 
            style="position: relative; top: 32px; left: -284px;">
            <table style="width: 411px">
                <tr>
                    <td class="style1">
                        <asp:Label ID="lblCriterio" runat="server" Text="Label">Numero: </asp:Label></td>
                    <td class="style6">
                        <asp:TextBox ID="txtCriterio" runat="server" Width="248px"></asp:TextBox></td>
                    <td>
                        <asp:ImageButton ID="btnBuscar" runat="server" 
                            ImageUrl="~/imagenes/btnModificar.png" ToolTip="Modificar" /></td>
                </tr>
            </table>
            <table style="margin-top: 20px; height: 446px; width: 466px;">
                <tr>
                    <td>
                        <eo:Grid ID="gridFactura" runat="server" BorderColor="#828790" BorderWidth="1px" 
                            ColumnHeaderAscImage="00050204" ColumnHeaderDescImage="00050205" 
                            ColumnHeaderDividerImage="00050203" ColumnHeaderHeight="24" 
                            FixedColumnCount="1" Font-Bold="False" Font-Italic="False" Font-Names="Tahoma" 
                            Font-Overline="False" Font-Size="8.75pt" Font-Strikeout="False" 
                            Font-Underline="False" GridLineColor="240, 240, 240" GridLines="Both" 
                            Height="460px" ItemHeight="19" Width="400px">
                            <FooterStyle CssText="padding-bottom:4px;padding-left:4px;padding-right:4px;padding-top:4px;" />
                            <ColumnTemplates>
                                <eo:TextBoxColumn>
                                    <TextBoxStyle CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; FONT-SIZE: 8.75pt; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; FONT-FAMILY: Tahoma" />
                                </eo:TextBoxColumn>
                                <eo:DateTimeColumn>
                                    <DatePicker ControlSkinID="None" DayCellHeight="16" DayCellWidth="19" 
                                        DayHeaderFormat="FirstLetter" DisabledDates="" OtherMonthDayVisible="True" 
                                        SelectedDates="" TitleLeftArrowImageUrl="DefaultSubMenuIconRTL" 
                                        TitleRightArrowImageUrl="DefaultSubMenuIcon">
                                        <TodayStyle CssText="font-family: tahoma; font-size: 12px; border-right: #bb5503 1px solid; border-top: #bb5503 1px solid; border-left: #bb5503 1px solid; border-bottom: #bb5503 1px solid" />
                                        <SelectedDayStyle CssText="font-family: tahoma; font-size: 12px; background-color: #fbe694; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                        <DisabledDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                        <PickerStyle CssText="border-bottom-color:#7f9db9;border-bottom-style:solid;border-bottom-width:1px;border-left-color:#7f9db9;border-left-style:solid;border-left-width:1px;border-right-color:#7f9db9;border-right-style:solid;border-right-width:1px;border-top-color:#7f9db9;border-top-style:solid;border-top-width:1px;font-family:Courier New;font-size:8pt;margin-bottom:0px;margin-left:0px;margin-right:0px;margin-top:0px;padding-bottom:1px;padding-left:2px;padding-right:2px;padding-top:2px;" />
                                        <CalendarStyle CssText="background-color: white; border-right: #7f9db9 1px solid; padding-right: 4px; border-top: #7f9db9 1px solid; padding-left: 4px; font-size: 9px; padding-bottom: 4px; border-left: #7f9db9 1px solid; padding-top: 4px; border-bottom: #7f9db9 1px solid; font-family: tahoma" />
                                        <TitleArrowStyle CssText="cursor:hand" />
                                        <DayHoverStyle CssText="font-family: tahoma; font-size: 12px; border-right: #fbe694 1px solid; border-top: #fbe694 1px solid; border-left: #fbe694 1px solid; border-bottom: #fbe694 1px solid" />
                                        <MonthStyle CssText="font-family: tahoma; font-size: 12px; margin-left: 14px; cursor: hand; margin-right: 14px" />
                                        <TitleStyle CssText="background-color:#9ebef5;font-family:Tahoma;font-size:12px;padding-bottom:2px;padding-left:6px;padding-right:6px;padding-top:2px;" />
                                        <OtherMonthDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                        <DayHeaderStyle CssText="font-family: tahoma; font-size: 12px; border-bottom: #aca899 1px solid" />
                                        <DayStyle CssText="font-family: tahoma; font-size: 12px; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                    </DatePicker>
                                </eo:DateTimeColumn>
                                <eo:MaskedEditColumn>
                                    <MaskedEdit ControlSkinID="None" 
                                        TextBoxStyle-CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; font-family:Courier New;font-size:8pt;">
                                    </MaskedEdit>
                                </eo:MaskedEditColumn>
                            </ColumnTemplates>
                            <ColumnHeaderStyle CssText="background-image:url('00050201');padding-left:8px;padding-top:4px;" />
                            <ItemStyles>
                                <eo:GridItemStyleSet>
                                    <ItemStyle CssText="background-color: white" />
                                    <ItemHoverStyle CssText="background-image: url(00050206); background-repeat: repeat-x" />
                                    <SelectedStyle CssText="background-image: url(00050207); background-repeat: repeat-x" />
                                    <CellStyle CssText="padding-left:8px;padding-top:2px;white-space:nowrap;" />
                                </eo:GridItemStyleSet>
                            </ItemStyles>
                            <ColumnHeaderHoverStyle CssText="background-image:url('00050202');padding-left:8px;padding-top:4px;" />
                            <Columns>
                                <eo:StaticColumn Width="150" HeaderText="Numero de factura" DataField="num"></eo:StaticColumn>                                
                                <eo:StaticColumn Width="250" Visible="false" DataField="idCliente"></eo:StaticColumn>
                                <eo:StaticColumn Width="250" Visible="false" DataField="idUsuario"></eo:StaticColumn>
                                <eo:StaticColumn Width="250" Visible="false" DataField="fechaFacturacion"></eo:StaticColumn>
                                <eo:StaticColumn Width="250" Visible="false" DataField="fechaCreacion"></eo:StaticColumn>
                                <eo:StaticColumn Width="250" Visible="false" DataField="fechaValidez"></eo:StaticColumn>
                                <eo:StaticColumn Width="250" Visible="false" DataField="moneda"></eo:StaticColumn>
                                <eo:StaticColumn Width="250" HeaderText="Estado" DataField="estado"></eo:StaticColumn>
                                <eo:StaticColumn Width="250" Visible="false" DataField="monto"></eo:StaticColumn>
                                <eo:StaticColumn Width="250" Visible="false" DataField="tipoDeCambio"></eo:StaticColumn>
                            </Columns>
                        </eo:Grid>
                    </td>
                </tr>
            </table> 
            <table cellpadding="10" cellspacing="10" style="width: 429px">
                    <tr>
                        <td class="style2">&nbsp;</td>
                        <td class="style7">
                            <asp:ImageButton ID="btnModify" runat="server" 
                            ImageUrl="~/imagenes/btnRegistrar.png" ToolTip="Modificar" /></td>
                        <td class="style8"><asp:ImageButton ID="btnEliminar" runat="server" 
                            ImageUrl="~/imagenes/btnEliminar.png" ToolTip="Eliminar" /></td>
                    </tr>
            </table> 
        </div>
        
        <div id="FacturaModificar" align="left" runat="server"
            
            
            
            style="position: relative; margin-top: 30px; height: 592px; margin-right: 4px; top: -592px; left: 206px; width: 481px;">
            <table cellpadding="3" cellspacing="3" >
                <tr>
                    <td class="style4">
                        <asp:Label ID="lblNumero" runat="server" Text="Label">Numero: </asp:Label></td>
                    <td>
                        <asp:TextBox ID="TxtNum" runat="server" Width="221px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:Label ID="lblCliente" runat="server" Text="Label">Cliente: </asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtCliente" runat="server" Width="221px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:Label ID="lblVendedor" runat="server" Text="Label">Vendedor: </asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtVendedor" runat="server" Width="221px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:Label ID="lblFecCrecion" runat="server" Text="Label">Fecha de Creacion: </asp:Label></td>
                    <td>
                        <asp:TextBox ID="textCreacion" runat="server" Width="221px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:Label ID="lblFecValidez" runat="server" Text="Label">Fecha Maxima de Validez: </asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtValidez" runat="server" Height="23px" Width="221px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:Label ID="lblFecFacturacion" runat="server" Text="Label">Fecha Facturacion: </asp:Label></td>
                    <td>
                        <asp:TextBox ID="textFacturacion" runat="server" Height="24px" Width="221px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:Label ID="lblMoneda" runat="server" Text="Label">Moneda: </asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtMoneda" runat="server" Height="24px" Width="221px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="style4">
                        <asp:Label ID="lblEstado" runat="server" Text="Label">Estado: </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddlEstado" runat="server" Height="24px" Width="224px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style4"></td>
                    <td align="right">
                        <asp:ImageButton ID="btnModificar" runat="server" 
                            ImageUrl="~/imagenes/btnModificar.png" ToolTip="Modificar" /></td>
                </tr>
            </table>
            <table style="width: 463px; " cellpadding="3">
                <tr>
                    <td class="style9"><asp:Label ID="LblServicios" runat="server" Text="Label">Servicios </asp:Label></td>
                </tr>
                <tr>
                    <td class="style3">
                        <asp:DropDownList ID="DdlServiciosDisp" runat="server" Height="24px" 
                            Width="220px">
                        </asp:DropDownList>
                    </td>
                    <td class="style5">
                        <asp:Label ID="LblCantidad" runat="server" Text="Label">Cantidad: &nbsp;
                        <asp:TextBox ID="TxtCantidad" runat="server" Height="20px" Width="40px"></asp:TextBox>
                        </asp:Label>
                    </td>
                    <td>
                        <asp:ImageButton ID="btnAgregarDetalle" runat="server" 
                            ImageUrl="~/imagenes/btnModificar.png" ToolTip="Modificar" /></td>
                </tr>
                
            </table>
            <table style="margin-top: 20px">
                <tr>
                    <td>
                        <eo:Grid ID="gridDetalle" runat="server" BorderColor="#828790" BorderWidth="1px" 
                            ColumnHeaderAscImage="00050204" ColumnHeaderDescImage="00050205" 
                            ColumnHeaderDividerImage="00050203" ColumnHeaderHeight="24" 
                            FixedColumnCount="1" Font-Bold="False" Font-Italic="False" Font-Names="Tahoma" 
                            Font-Overline="False" Font-Size="8.75pt" Font-Strikeout="False" 
                            Font-Underline="False" GridLineColor="240, 240, 240" GridLines="Both" 
                            Height="134px" ItemHeight="19" Width="460px">
                            <FooterStyle CssText="padding-bottom:4px;padding-left:4px;padding-right:4px;padding-top:4px;" />
                            <ColumnTemplates>
                                <eo:TextBoxColumn>
                                    <TextBoxStyle CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; FONT-SIZE: 8.75pt; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; FONT-FAMILY: Tahoma" />
                                </eo:TextBoxColumn>
                                <eo:DateTimeColumn>
                                    <DatePicker ControlSkinID="None" DayCellHeight="16" DayCellWidth="19" 
                                        DayHeaderFormat="FirstLetter" DisabledDates="" OtherMonthDayVisible="True" 
                                        SelectedDates="" TitleLeftArrowImageUrl="DefaultSubMenuIconRTL" 
                                        TitleRightArrowImageUrl="DefaultSubMenuIcon">
                                        <TodayStyle CssText="font-family: tahoma; font-size: 12px; border-right: #bb5503 1px solid; border-top: #bb5503 1px solid; border-left: #bb5503 1px solid; border-bottom: #bb5503 1px solid" />
                                        <SelectedDayStyle CssText="font-family: tahoma; font-size: 12px; background-color: #fbe694; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                        <DisabledDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                        <PickerStyle CssText="border-bottom-color:#7f9db9;border-bottom-style:solid;border-bottom-width:1px;border-left-color:#7f9db9;border-left-style:solid;border-left-width:1px;border-right-color:#7f9db9;border-right-style:solid;border-right-width:1px;border-top-color:#7f9db9;border-top-style:solid;border-top-width:1px;font-family:Courier New;font-size:8pt;margin-bottom:0px;margin-left:0px;margin-right:0px;margin-top:0px;padding-bottom:1px;padding-left:2px;padding-right:2px;padding-top:2px;" />
                                        <CalendarStyle CssText="background-color: white; border-right: #7f9db9 1px solid; padding-right: 4px; border-top: #7f9db9 1px solid; padding-left: 4px; font-size: 9px; padding-bottom: 4px; border-left: #7f9db9 1px solid; padding-top: 4px; border-bottom: #7f9db9 1px solid; font-family: tahoma" />
                                        <TitleArrowStyle CssText="cursor:hand" />
                                        <DayHoverStyle CssText="font-family: tahoma; font-size: 12px; border-right: #fbe694 1px solid; border-top: #fbe694 1px solid; border-left: #fbe694 1px solid; border-bottom: #fbe694 1px solid" />
                                        <MonthStyle CssText="font-family: tahoma; font-size: 12px; margin-left: 14px; cursor: hand; margin-right: 14px" />
                                        <TitleStyle CssText="background-color:#9ebef5;font-family:Tahoma;font-size:12px;padding-bottom:2px;padding-left:6px;padding-right:6px;padding-top:2px;" />
                                        <OtherMonthDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                        <DayHeaderStyle CssText="font-family: tahoma; font-size: 12px; border-bottom: #aca899 1px solid" />
                                        <DayStyle CssText="font-family: tahoma; font-size: 12px; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                    </DatePicker>
                                </eo:DateTimeColumn>
                                <eo:MaskedEditColumn>
                                    <MaskedEdit ControlSkinID="None" 
                                        TextBoxStyle-CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; font-family:Courier New;font-size:8pt;">
                                    </MaskedEdit>
                                </eo:MaskedEditColumn>
                            </ColumnTemplates>
                            <ColumnHeaderStyle CssText="background-image:url('00050201');padding-left:8px;padding-top:4px;" />
                            <ItemStyles>
                                <eo:GridItemStyleSet>
                                    <ItemStyle CssText="background-color: white" />
                                    <ItemHoverStyle CssText="background-image: url(00050206); background-repeat: repeat-x" />
                                    <SelectedStyle CssText="background-image: url(00050207); background-repeat: repeat-x" />
                                    <CellStyle CssText="padding-left:8px;padding-top:2px;white-space:nowrap;" />
                                </eo:GridItemStyleSet>
                            </ItemStyles>
                            <ColumnHeaderHoverStyle CssText="background-image:url('00050202');padding-left:8px;padding-top:4px;" />
                            <Columns>
                                <eo:StaticColumn HeaderText="Codigo" DataField="codServicio" Width="60"></eo:StaticColumn>
                                <eo:StaticColumn HeaderText="Nombre" DataField="nombre" Width="200"></eo:StaticColumn>
                                <eo:StaticColumn HeaderText="Cantidad" DataField="cantidad" Width="70"></eo:StaticColumn>
                                <eo:StaticColumn HeaderText="Precio" DataField="precio" Width="130"></eo:StaticColumn>
                            </Columns>
                        </eo:Grid>
                    </td>
                </tr>
            </table>
            <table style="margin-top: 10px; width: 466px; margin-left: 0px;" align="left">
                <tr>
                    <td>
                        <asp:Label ID="lblMonto" runat="server" Text="Label">Monto Total: </asp:Label></td>
                    <td class="style10">
                        <asp:TextBox ID="txtMonto" runat="server" Height="24px" Width="315px"></asp:TextBox></td>
                       <td><asp:ImageButton ID="btnEliminarDetalle" runat="server" 
                            ImageUrl="~/imagenes/btnEliminar.png" ToolTip="Eliminar" /></td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
