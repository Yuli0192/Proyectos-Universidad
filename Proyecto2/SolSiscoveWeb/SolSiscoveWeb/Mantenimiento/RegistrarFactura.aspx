<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="RegistrarFactura.aspx.vb" Inherits="SolSiscoveWeb.RegistrarFactura" 
    title="Untitled Page" %>

<%@ Register Assembly="EO.Web" Namespace="EO.Web" TagPrefix="eo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 298px;
        }
        #datosFactura
        {
            width: 536px;
        }
        .style4
        {
            width: 395px;
        }
        .style5
        {
            width: 298px;
            height: 52px;
        }
        .style6
        {
            width: 395px;
            height: 52px;
        }
    .style7
    {
            width: 227px;
        }
    .style8
    {
        width: 163px;
    }
        .style9
        {
            height: 34px;
        }
        .style10
        {
            height: 34px;
            width: 275px;
        }
        .style11
        {
            width: 98px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="principalFactura" 
    
        style="width: 1024px; font-family: arial, Helvetica, sans-serif; font-size: smaller; height: 446px;">
        <div id="titulo" style="width:1024"><p>Registrar Factura</p></div>
        <div id="datosFactura" 
            style="width: 510px; margin-top: 25px; position: relative; top: 0px; left: -255px;">
            <table cellpadding="10" cellspacing="10" style="width: 478px" >
                <tr>
                    <td class="style2"><asp:Label ID="Label1" runat="server" Text="Label">Numero: </asp:Label></td>
                    
                    <td class="style4">
                        <asp:TextBox ID="txtNumero" runat="server" Height="20px" 
                            Width="220px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="style2"><asp:Label ID="Label2" runat="server" Text="Label">Cliente: </asp:Label></td>
                    <td class="style4">
                        <asp:DropDownList ID="DdlCliente" runat="server" Height="24px" Width="220px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style2"><asp:Label ID="Label3" runat="server" Text="Label">Fecha Maxima Validez: </asp:Label></td>
                    <td class="style4">
                        <eo:DatePicker ID="dpValidez" runat="server" ControlSkinID="None" 
                            DayCellHeight="16" DayCellWidth="19" DayHeaderFormat="FirstLetter" 
                            DisabledDates="" OtherMonthDayVisible="True" SelectedDates="" 
                            TitleLeftArrowImageUrl="DefaultSubMenuIconRTL" 
                            TitleRightArrowImageUrl="DefaultSubMenuIcon" VisibleDate="2011-08-01" 
                            Height="24px" Width="221px">
                            <TodayStyle CssText="font-family: tahoma; font-size: 12px; border-right: #bb5503 1px solid; border-top: #bb5503 1px solid; border-left: #bb5503 1px solid; border-bottom: #bb5503 1px solid" />
                            <SelectedDayStyle CssText="font-family: tahoma; font-size: 12px; background-color: #fbe694; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                            <DisabledDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                            <PickerStyle CssText="font-family:Courier New; padding-left:5px; padding-right: 5px;" />
                            <CalendarStyle CssText="background-color: white; border-right: #7f9db9 1px solid; padding-right: 4px; border-top: #7f9db9 1px solid; padding-left: 4px; font-size: 9px; padding-bottom: 4px; border-left: #7f9db9 1px solid; padding-top: 4px; border-bottom: #7f9db9 1px solid; font-family: tahoma" />
                            <TitleArrowStyle CssText="cursor:hand" />
                            <DayHoverStyle CssText="font-family: tahoma; font-size: 12px; border-right: #fbe694 1px solid; border-top: #fbe694 1px solid; border-left: #fbe694 1px solid; border-bottom: #fbe694 1px solid" />
                            <MonthStyle CssText="font-family: tahoma; font-size: 12px; margin-left: 14px; cursor: hand; margin-right: 14px" />
                            <TitleStyle CssText="background-color:#9ebef5;font-family:Tahoma;font-size:12px;padding-bottom:2px;padding-left:6px;padding-right:6px;padding-top:2px;" />
                            <OtherMonthDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                            <DayHeaderStyle CssText="font-family: tahoma; font-size: 12px; border-bottom: #aca899 1px solid" />
                            <DayStyle CssText="font-family: tahoma; font-size: 12px; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                        </eo:DatePicker>
                    </td>
                </tr>
                <tr>
                    <td class="style5"><asp:Label ID="Label4" runat="server" Text="Label">Moneda: </asp:Label></td>
                    <td class="style6">
                        <asp:DropDownList ID="DdlMoneda" runat="server" Height="24px" Width="220px" AutoPostBack ="true">
                            <asp:ListItem Selected="True">Seleccionar</asp:ListItem>
                            <asp:ListItem>Colones</asp:ListItem>
                            <asp:ListItem>Dolares</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
            </table> 
            <table style="width: 500px; padding-left: 20px;">
                <tr>
                    <td class="style7"><asp:Label ID="LblServicios" runat="server" Text="Label">Servicios </asp:Label></td>
                </tr>
                <tr>
                    <td class="style7">
                        <asp:DropDownList ID="DdlServiciosDisp" runat="server" Height="24px" 
                            Width="220px">
                        </asp:DropDownList>
                    </td>
                    <td class="style8">
                        <asp:Label ID="LblCantidad" runat="server" Text="Label">Cantidad: &nbsp;
                        <asp:TextBox ID="TxtCantidad" runat="server" Height="20px" Width="40px"></asp:TextBox>
                        </asp:Label>
                    </td>
                </tr>
            </table>
            <table cellpadding="10" cellspacing="10">
            <tr>
                <td class="style10">&nbsp;</td>
                <td class="style9"><asp:ImageButton ID="btnRegistrar" runat="server" 
                    ImageUrl="~/imagenes/btnRegistrar.png" ToolTip="Registrar" /></td>
                <td class="style9"><asp:ImageButton ID="btnLimpiar" runat="server" 
                    ImageUrl="~/imagenes/btnLimpiar.png" ToolTip="Limpiar" /></td>
            </tr>
        </table>
        </div>
        <div id="Detalle" 
            style="width: 429px; position: relative; top: -377px; left: -78px; float: right; margin-top: 20px;">
            <table>
                <tr>
                    <td>
                        <eo:Grid ID="gridDetalle" runat="server" BorderColor="#828790" BorderWidth="1px" 
                            ColumnHeaderAscImage="00050204" ColumnHeaderDescImage="00050205" 
                            ColumnHeaderDividerImage="00050203" ColumnHeaderHeight="24" 
                            FixedColumnCount="1" Font-Bold="False" Font-Italic="False" Font-Names="Tahoma" 
                            Font-Overline="False" Font-Size="8.75pt" Font-Strikeout="False" 
                            Font-Underline="False" GridLineColor="240, 240, 240" GridLines="Both" 
                            Height="200px" ItemHeight="19" Width="420px">
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
                               
                                <eo:StaticColumn Width="85" HeaderText="Codigo" DataField="codServicio"></eo:StaticColumn>                                
                                <eo:StaticColumn Width="125" HeaderText="Nombre" DataField="nombre"></eo:StaticColumn>
                                <eo:StaticColumn Width="85" HeaderText="Cantidad" DataField="cantidad"></eo:StaticColumn>                                
                                <eo:StaticColumn Width="125" HeaderText="Precio" DataField="precio"></eo:StaticColumn>
                                
                            </Columns>
                        </eo:Grid>
                    </td>
                </tr>
            </table>
            <table style="margin-top: 10px">
                <tr>
                    <td class="style11">
                        <asp:Label ID="lblMonto" runat="server" Text="Label">Monto Total: </asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtMonto" runat="server" Height="24px" Width="220px"></asp:TextBox></td>
                </tr>
            </table>
        </div>

    </div>
</asp:Content>
