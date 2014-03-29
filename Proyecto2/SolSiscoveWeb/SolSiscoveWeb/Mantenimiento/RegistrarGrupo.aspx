<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="RegistrarGrupo.aspx.vb" Inherits="SolSiscoveWeb.RegistrarGrupo" 
    title="Untitled Page" %>
<%@ Register assembly="EO.Web" namespace="EO.Web" tagprefix="eo" %>
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
        #Servicios
        {
            width: 475px;
            height: 124px;
            top: -256px;
            left: 243px;
        }
        </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <script type="text/javascript">
        function agregar(grid1, grid2)
        {          
                //Get the Grid object
                var grid = eo_GetObject(grid1);
            	
                //Item que se selecciona
                var item = grid.getSelectedItem();
        	    grid.deleteItem(item.getIndex());
            	
        	    //Get the Grid object
                var gridDestino = eo_GetObject(grid2);
                
                //Add a new item
                var itemDestino = gridDestino.addItem();
                itemDestino.getCell(0).setValue(item.getCell(0).getValue());
                itemDestino.getCell(1).setValue(item.getCell(1).getValue());
        }
        
        function remover(grid1, grid2)
        {
        	//Get the Grid object
            var grid = eo_GetObject(grid1);
        	
            //Item que se selecciona
            var item = grid.getSelectedItem();
        	grid.deleteItem(item.getIndex());
        	
        	//Get the Grid object
            var gridDestino = eo_GetObject(grid2);
            
            //Add a new item
            var itemDestino = gridDestino.addItem();
            itemDestino.getCell(0).setValue(item.getCell(0).getValue());
            itemDestino.getCell(1).setValue(item.getCell(1).getValue());   
        }
    </script>
    
    <div id="principalGrupo" 
           
        style="width: 1024px; font-family: arial, Helvetica, sans-serif; font-size: smaller; height: 344px;">
        
        <div id="titulo" style="width:1024"><p>Registrar Grupo de ventas</p></div>
        
        <div id="datosFactura" 
            style="width: 510px; margin-top: 25px; position: relative; top: 3px; left: -254px; height: 269px;" 
            align="left">
            <table cellpadding="10" cellspacing="15" style="width: 478px" >
                <tr>
                    <td class="style2"><asp:Label ID="Label1" runat="server" Text="Label">Codigo: </asp:Label></td>
                    
                    <td class="style4">
                        <asp:TextBox ID="txtCodigo" runat="server" Height="20px" 
                            Width="220px" MaxLength="50"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="style2"><asp:Label ID="Label2" runat="server" Text="Label">Descripcion: </asp:Label></td>
                    <td class="style4">
                        <asp:TextBox ID="txtDescripcion" TextMode="MultiLine"  runat="server" Height="72px" 
                            Width="220px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="style5"><asp:Label ID="Label4" runat="server" Text="Label">Encargado: </asp:Label></td>
                    <td class="style6">
                        <asp:DropDownList ID="ddlEncargado" runat="server" Height="24px" Width="220px">
                        </asp:DropDownList>
                    </td>
                </tr>
            </table> 
        </div>
        <div id="Servicios" align="left" style="position: relative">
            <table style="width: 42px; padding-left: 20px; height: 119px;">
                <tr>
                    <td>
                        <asp:Label ID="lblServicios" runat="server" Text="Label">Servicios</asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <eo:Grid ID="gridServicioDisp" runat="server" BorderColor="#828790" BorderWidth="1px" 
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
                            style="float:right; margin: 2px 4px 0px 0px; height: 84px; width: 42px;">
                            <br />
                            <img src="/imagenes/btnDerecha.png" alt="Asignar Servicios al Grupo" 
                                onclick="agregar('gridServicioDisp','gridServicio')" id="btnAgregarServicio"/><br /><br />
                            <img src="/imagenes/btnIzquierda.png" alt="Quitar Servicios al Grupo" 
                                onclick="remover('gridServicio','gridServicioDisp')" id="btnEliminarServicio"/><br />
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
        </div>
        
        <div id="Vendedores" align="left" 
            
            
            style="position: relative; top: -254px; left: 250px; width: 488px; height: 162px;">
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
                            style="float:right; margin: 2px 4px 0px 0px; height: 84px; width: 42px;">
                            <br />
                            <img src="/imagenes/btnDerecha.png" alt="Asignar Vendedores al Grupo" 
                                onclick="agregar('gridVendedorDisp','gridVendedor')" id="btnAgregarVendedores"/><br /><br />
                            <img src="/imagenes/btnIzquierda.png" alt="Quitar Vendedores al Grupo" 
                                onclick="remover('gridVendedor','gridVendedorDisp')" id="btnEliminarVendedor"/><br />
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
            <table>
                <tr align="right" style="padding-top: 20px; margin-top: 20px;">
                    <td style="width:400px">&nbsp;</td>
                    <td style="width:50px"><asp:ImageButton ID="btnRegistrar" runat="server" 
                        ImageUrl="~/imagenes/btnRegistrar.png" ToolTip="Registrar" />&nbsp;</td>
                    <td style="width:50px"><asp:ImageButton ID="btnLimpiar" runat="server" 
                        ImageUrl="~/imagenes/btnLimpiar.png" ToolTip="Limpiar" /></td>
                </tr>
            </table>
        </div>
    </div>
    
    
</asp:Content>
