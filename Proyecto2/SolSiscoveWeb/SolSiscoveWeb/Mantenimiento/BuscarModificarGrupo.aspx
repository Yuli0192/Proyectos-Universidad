<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="BuscarModificarGrupo.aspx.vb" Inherits="SolSiscoveWeb.BuscarModificarGrupo" 
    title="Untitled Page" %>
<%@ Register assembly="EO.Web" namespace="EO.Web" tagprefix="eo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 312px;
        }
        #divLeft
        {
            width: 433px;
            top: 4px;
            left: -292px;
        }
        #Right
        {
            width: 493px;
            margin-right: 0px;
        }
        .style2
        {
            width: 154px;
        }
        .style3
        {
            width: 402px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="Principal" 
        style="width: 1024px; height: 543px; font-family: Arial, Helvetica, sans-serif; font-size: smaller;">
        <div id="titulo" style="width:1024"><p>Buscar Grupo de ventas</p></div>
        <div id="divLeft" style="position: relative; margin-top: 30px;">
            <table style="width: 411px">
                <tr>
                    <td>
                        <asp:Label ID="lblCriterio" runat="server" Text="Label">Codigo: </asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtCriterio" runat="server" Width="248px"></asp:TextBox></td>
                    <td>
                        <asp:ImageButton ID="btnBuscar" runat="server" 
                            ImageUrl="~/imagenes/btnBuscar.png" ToolTip="Buscar" /></td>
                </tr>
            </table>
            <table style="margin-top: 20px; height: 361px;">
                <tr>
                    <td class="style3">
                        <eo:Grid ID="gridGrupo" runat="server" BorderColor="#828790" BorderWidth="1px" 
                            ColumnHeaderAscImage="00050204" ColumnHeaderDescImage="00050205" 
                            ColumnHeaderDividerImage="00050203" ColumnHeaderHeight="24" 
                            FixedColumnCount="1" Font-Bold="False" Font-Italic="False" Font-Names="Tahoma" 
                            Font-Overline="False" Font-Size="8.75pt" Font-Strikeout="False" 
                            Font-Underline="False" GridLineColor="240, 240, 240" GridLines="Both" 
                            Height="347px" ItemHeight="19" Width="400px">
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
                                <eo:StaticColumn Width="150" HeaderText="Codigo del Grupo" DataField="codGrupo"></eo:StaticColumn>                                
                                <eo:StaticColumn Width="250" HeaderText="Descripcion" DataField="descripcionGrupo"></eo:StaticColumn>
                                <eo:StaticColumn Width="10" HeaderText="id del Encargado" DataField="idEncargadoGrupo" Visible = "false" ></eo:StaticColumn>
       
                            </Columns>
                        </eo:Grid>
                    </td>
                </tr>
            </table> 
            <table cellpadding="10" cellspacing="10" style="width: 429px">
                    <tr>
                        <td class="style1">&nbsp;</td>
                        <td class="style7">
                            <asp:ImageButton ID="btnModificar" runat="server" 
                            ImageUrl="~/imagenes/btnModificar.png" ToolTip="Registrar" /></td>
                        <td class="style8"><asp:ImageButton ID="btnEliminar" runat="server" 
                            ImageUrl="~/imagenes/btnEliminar.png" ToolTip="Eliminar" /></td>
                    </tr>
            </table> 
        </div>
        <div id="Derecha" 
            
            style="position: relative; margin-top: 30px; top: -518px; left: 215px; width: 494px;" runat ="server"  >
            <table cellpadding="5" cellspacing="5" style="width: 478px" >
                <tr>
                    <td class="style2"><asp:Label ID="LblCodigo" runat="server" Text="Codigo: "></asp:Label></td>
                    
                    <td><asp:TextBox ID="txtCodigo" runat="server" Height="20px" 
                            Width="273px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="style2"><asp:Label ID="lblDescripcion" runat="server" 
                            Text="Descripcion: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtDescripcion" runat="server" Height="72px" 
                            Width="277px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="style2"><asp:Label ID="lblEncargado" runat="server" Text="Encargado: "></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="DdlEncargado" runat="server" Height="24px" Width="260px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="style2"></td>
                    <td align="right">
                            <asp:ImageButton ID="btnmodificar2" runat="server" 
                            ImageUrl="~/imagenes/btnConfirmarModificacion.png" ToolTip="Modificar2" /></td>
                </tr>
            </table> 
            
            <table style="width: 42px; padding-left: 20px; height: 119px;">
                <tr>
                    <td>
                        <asp:Label ID="lblServicios" runat="server" Text="Label">Servicios</asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <eo:Grid ID="GridServicioDisp" runat="server" BorderColor="#828790" BorderWidth="1px" 
                            ColumnHeaderAscImage="00050204" ColumnHeaderDescImage="00050205" 
                            ColumnHeaderDividerImage="00050203" ColumnHeaderHeight="24" 
                            FixedColumnCount="1" Font-Bold="False" Font-Italic="False" Font-Names="Tahoma" 
                            Font-Overline="False" Font-Size="8.75pt" Font-Strikeout="False" 
                            Font-Underline="False" GridLineColor="240, 240, 240" GridLines="Both" 
                            Height="100px" ItemHeight="19" Width="200px">
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
                                <eo:StaticColumn Width="10" HeaderText="codServicio" DataField="codServicio" visible="false"></eo:StaticColumn>                                
                                <eo:StaticColumn Width="183" HeaderText="Nombre" DataField="nombre"></eo:StaticColumn>
                            </Columns>
                        </eo:Grid>
                    </td>
                    <td>
                        <div id="divBotonesAsignar" align="right" 
                            style="float:right; margin: 2px 4px 0px 0px; height: 95px; width: 42px;">
                            <br />
                            <asp:ImageButton ID="btnAgregarServicio" runat="server" 
                            ImageUrl="~/imagenes/btnDerecha.png" ToolTip="agregarServicio" /><br /><br />
                            <asp:ImageButton ID="btnRemoverServicio" runat="server" 
                            ImageUrl="~/imagenes/btnIzquierda.png" ToolTip="removerServicio" /><br />
                            &nbsp;<br />
                            </div>
                    </td>
                    <td>
                        <eo:Grid ID="gridServicio" runat="server" BorderColor="#828790" BorderWidth="1px" 
                            ColumnHeaderAscImage="00050204" ColumnHeaderDescImage="00050205" 
                            ColumnHeaderDividerImage="00050203" ColumnHeaderHeight="24" 
                            FixedColumnCount="1" Font-Bold="False" Font-Italic="False" Font-Names="Tahoma" 
                            Font-Overline="False" Font-Size="8.75pt" Font-Strikeout="False" 
                            Font-Underline="False" GridLineColor="240, 240, 240" GridLines="Both" 
                            Height="100px" ItemHeight="19" Width="200px">
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
                                <eo:StaticColumn Width="10" HeaderText="codServicio" DataField="codServicio" visible="false"></eo:StaticColumn>                                
                                <eo:StaticColumn Width="183" HeaderText="Nombre" DataField="nombre"></eo:StaticColumn>
                            </Columns>
                        </eo:Grid>
                    </td>
                </tr>
            </table>
            
            <table style="width: 42px; padding-left: 20px; height: 119px;">
                <tr>
                    <td>
                        <asp:Label ID="lblVendedores" runat="server" Text="Label">Vendedores</asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <eo:Grid ID="gridVendedorDisp" runat="server" BorderColor="#828790" BorderWidth="1px" 
                            ColumnHeaderAscImage="00050204" ColumnHeaderDescImage="00050205" 
                            ColumnHeaderDividerImage="00050203" ColumnHeaderHeight="24" 
                            FixedColumnCount="1" Font-Bold="False" Font-Italic="False" Font-Names="Tahoma" 
                            Font-Overline="False" Font-Size="8.75pt" Font-Strikeout="False" 
                            Font-Underline="False" GridLineColor="240, 240, 240" GridLines="Both" 
                            Height="100px" ItemHeight="19" Width="200px">
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
                                <eo:StaticColumn Width="10" HeaderText="cedula" DataField="cedula" visible="false"></eo:StaticColumn>                                
                                <eo:StaticColumn Width="183" HeaderText="Nombre" DataField="nombreCompleto"></eo:StaticColumn>
                            </Columns>
                        </eo:Grid>
                    </td>
                    <td>
                        <div id="div2" align="right" 
                            style="float:right; margin: 2px 4px 0px 0px; height: 103px; width: 42px;">
                            <br />
                            <asp:ImageButton ID="btnAgregarVendedor" runat="server" 
                            ImageUrl="~/imagenes/btnDerecha.png" ToolTip="agregarVendedor" /><br /><br />
                            <asp:ImageButton ID="btnRemoverVendedor" runat="server" 
                            ImageUrl="~/imagenes/btnIzquierda.png" ToolTip="removerVendedor" /><br />
                            &nbsp;<br />
                            </div>
                    </td>
                    <td>
                        <eo:Grid ID="gridVendedor" runat="server" BorderColor="#828790" BorderWidth="1px" 
                            ColumnHeaderAscImage="00050204" ColumnHeaderDescImage="00050205" 
                            ColumnHeaderDividerImage="00050203" ColumnHeaderHeight="24" 
                            FixedColumnCount="1" Font-Bold="False" Font-Italic="False" Font-Names="Tahoma" 
                            Font-Overline="False" Font-Size="8.75pt" Font-Strikeout="False" 
                            Font-Underline="False" GridLineColor="240, 240, 240" GridLines="Both" 
                            Height="100px" ItemHeight="19" Width="200px">
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
                                <eo:StaticColumn Width="10" HeaderText="cedula" DataField="cedula" visible="false"></eo:StaticColumn>                                
                                <eo:StaticColumn Width="183" HeaderText="Nombre" DataField="nombreCompleto"></eo:StaticColumn>
                            </Columns>
                        </eo:Grid>
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
