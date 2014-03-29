<%@ Page Language="vb" AutoEventWireup="true" MasterPageFile="~/Master.Master" CodeBehind="frmListarVentas.aspx.vb" Inherits="SolSiscoveWeb.frmListarVentas" 
    title="Listar Ventas" %>
<%@ Register assembly="EO.Web" namespace="EO.Web" tagprefix="eo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #divDatos
        {
            height: 456px;
        }
        #divFechas
        {
            height: 89px;
            width: 493px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divPrincipal" style="height: 561px; width: 1029px; padding-top:20px;">
        <div id="izquierda" style="float:left; width:529;">
       <%-- Label Cliente--%>
        <div id="divBuscarUsuario">
            <asp:Label ID="lblBuscarUsuario" runat="server" Font-Names="Arial" Font-Size="20pt" ForeColor="#000066" Text="Buscar Usuario"></asp:Label>
        </div>
        
        <%-- Label Fecha Facturacion--%>
        <div id="divlblCedula"  style="padding-top:20px;">
            <asp:Label ID="lblCedula" runat="server" Font-Names="Arial" Font-Size="11pt" Text="Cédula Usuario:"></asp:Label>
            <asp:DropDownList ID="dpdlCedula" runat="server" Height="29px" Width="125px" 
                AutoPostBack="True">
            </asp:DropDownList>
        </div>
  
        
         <%-- Label Monto--%>  
        <div id="divFecha" style="padding-top:10px;">
        <table style="width:480px; text-align:right;">
        <tr>
        <td> <asp:Label ID="lblFechaInicio" runat="server" Font-Names="Arial" Font-Size="11pt" Text="Fecha Inicio:"></asp:Label></td>
        <td>
             <eo:DatePicker ID="dtpFechaInicio" runat="server" ControlSkinID="None" 
                    DayCellHeight="16" DayCellWidth="22" DayHeaderFormat="Short" DisabledDates="" 
                    MonthSelectorVisible="True" SelectedDates="" 
                    TitleLeftArrowDownImageUrl="00040103" TitleLeftArrowImageUrl="00040101" 
                    TitleRightArrowDownImageUrl="00040104" TitleRightArrowImageUrl="00040102" 
                    VisibleDate="2011-08-01" WeekSelectorVisible="True">
                    <TodayStyle CssText="background-image:url('00040106');" />
                    <SelectedDayStyle CssText="FONT-SIZE: 8pt; FONT-FAMILY: Tahoma; background-image:url('00040105');color:white;" />
                    <DisabledDayStyle CssText="FONT-SIZE: 8pt; FONT-FAMILY: Tahoma; COLOR: gray" />
                    <FooterTemplate>
                        <div style="FONT-WEIGHT: bold; FONT-SIZE: 11px; FONT-FAMILY: Tahoma&quot;">
                            <img src="{img:00040106}"> Today: {var:today:MM/dd/yyyy} </img></div>
                    </FooterTemplate>
                    <CalendarStyle CssText="border-bottom-color:Black;border-bottom-style:solid;border-bottom-width:1px;border-left-color:Black;border-left-style:solid;border-left-width:1px;border-right-color:Black;border-right-style:solid;border-right-width:1px;border-top-color:Black;border-top-style:solid;border-top-width:1px;padding-bottom:5px;padding-left:5px;padding-right:5px;padding-top:5px;background-color:white" />
                    <DayHoverStyle CssText="FONT-SIZE: 8pt; FONT-FAMILY: Tahoma; text-decoration:underline" />
                    <MonthStyle CssText="MARGIN: 0px 4px; cursor:hand" />
                    <TitleStyle CssText="PADDING-RIGHT: 3px; PADDING-LEFT: 3px; FONT-WEIGHT: bold; FONT-SIZE: 8pt; PADDING-BOTTOM: 3px; COLOR: white; PADDING-TOP: 3px; FONT-FAMILY: Tahoma; BACKGROUND-COLOR: #0054e3" />
                    <DayHeaderStyle CssText="FONT-SIZE: 11px; COLOR: #0054e3; BORDER-BOTTOM: black 1px solid; FONT-FAMILY: Tahoma" />
                    <DayStyle CssText="FONT-SIZE: 8pt; FONT-FAMILY: Tahoma; text-decoration:none" />
                </eo:DatePicker>
        </td>
        <td><asp:Label ID="lblFechaFin" runat="server" Font-Names="Arial" Font-Size="11pt" Text="Fecha Fin:"></asp:Label></td>
        <td> 
                <eo:DatePicker ID="dtpFechaFin" runat="server" ControlSkinID="None" 
                    DayCellHeight="16" DayCellWidth="21" DayHeaderFormat="FirstLetter" 
                    DisabledDates="" GridLineColor="207, 217, 227" GridLineFrameVisible="False" 
                    GridLineVisible="True" SelectedDates="" TitleFormat="MMM yyyy" 
                    TitleLeftArrowHtml="&amp;lt;" TitleRightArrowHtml="&amp;gt;" 
                    VisibleDate="2011-08-01">
                    <SelectedDayStyle CssText="font-size: 11px; font-family: verdana;border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; background-color: white" />
                    <CalendarStyle CssText="border-right: #cfd9e3 1px solid; border-top: #cfd9e3 1px solid; font-size: 11px; border-left: #cfd9e3 1px solid; cursor: hand; border-bottom: #cfd9e3 1px solid; font-family: verdana; background-color: #eaeaea" />
                    <DayHoverStyle CssText="font-size: 11px; font-family: verdana;border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; background-color: white" />
                    <TitleStyle CssText="padding-right: 3px; padding-left: 3px; font-weight: bold; padding-bottom: 3px; color: white; padding-top: 3px; border-bottom: #cfd9e3 1px solid; background-color: #006699; font-size: 11px; font-family: verdana;" />
                    <DayHeaderStyle CssText="font-size: 11px; font-family: verdana;height: 17px" />
                    <DayStyle CssText="font-size: 11px; font-family: verdana;border-right: #eaeaea 1px solid; border-top: #eaeaea 1px solid; border-left: #eaeaea 1px solid; border-bottom: #eaeaea 1px solid; background-color: #eaeaea" />
                </eo:DatePicker></td>
                <td><asp:ImageButton ID="bntBuscarVentas" runat="server" 
            ImageUrl="~/Imagenes/btnVer.png" ToolTip="Buscar" /></td>
        </tr>
        </table>
           
           
                
               
        </div>
        
        <div id="divgVerVentas">  
            <eo:Grid runat="server" id="gVerVentas" BorderColor="#828790" 
                                BorderWidth="1px" GridLines="Both"
	                            FixedColumnCount="1" ColumnHeaderDescImage="00050205" 
                                GridLineColor="240, 240, 240" Width="301px"
	                            IsCallbackByMe="False" ItemHeight="19" 
                ColumnHeaderAscImage="00050204" ColumnHeaderHeight="24"
	                            Height="161px" Font-Size="8.75pt" Font-Names="Tahoma" 
                                    ColumnHeaderDividerImage="00050203" Visible="False">
	                            <ItemStyles>
		                            <eo:GridItemStyleSet>
			                            <ItemHoverStyle CssText="background-image: url(00050206); background-repeat: repeat-x"></ItemHoverStyle>
			                            <SelectedStyle CssText="background-image: url(00050207); background-repeat: repeat-x"></SelectedStyle>
			                            <CellStyle CssText="padding-left:8px;padding-top:2px;"></CellStyle>
			                            <ItemStyle CssText="background-color: white"></ItemStyle>
		                            </eo:GridItemStyleSet>
	                            </ItemStyles>
	                            <ColumnHeaderHoverStyle CssText="background-image:url('00050202');padding-left:8px;padding-top:4px;"></ColumnHeaderHoverStyle>
	                            <ColumnTemplates>
		                            <eo:TextBoxColumn>
			                            <TextBoxStyle CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; FONT-SIZE: 8.75pt; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; FONT-FAMILY: Tahoma"></TextBoxStyle>
		                            </eo:TextBoxColumn>
		                            <eo:DateTimeColumn>
			                            <DatePicker DayHeaderFormat="FirstLetter" DayCellHeight="16" DisabledDates="" TitleLeftArrowImageUrl="DefaultSubMenuIconRTL"
				                            OtherMonthDayVisible="True" DayCellWidth="19" TitleRightArrowImageUrl="DefaultSubMenuIcon"
				                            ControlSkinID="None" SelectedDates="">
				                            <TodayStyle CssText="font-family: tahoma; font-size: 12px; border-right: #bb5503 1px solid; border-top: #bb5503 1px solid; border-left: #bb5503 1px solid; border-bottom: #bb5503 1px solid"></TodayStyle>
				                            <SelectedDayStyle CssText="font-family: tahoma; font-size: 12px; background-color: #fbe694; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid"></SelectedDayStyle>
				                            <DisabledDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid"></DisabledDayStyle>
				                            <PickerStyle CssText="border-bottom-color:#7f9db9;border-bottom-style:solid;border-bottom-width:1px;border-left-color:#7f9db9;border-left-style:solid;border-left-width:1px;border-right-color:#7f9db9;border-right-style:solid;border-right-width:1px;border-top-color:#7f9db9;border-top-style:solid;border-top-width:1px;font-family:Courier New;font-size:8pt;margin-bottom:0px;margin-left:0px;margin-right:0px;margin-top:0px;padding-bottom:1px;padding-left:2px;padding-right:2px;padding-top:2px;"></PickerStyle>
				                            <CalendarStyle CssText="background-color: white; border-right: #7f9db9 1px solid; padding-right: 4px; border-top: #7f9db9 1px solid; padding-left: 4px; font-size: 9px; padding-bottom: 4px; border-left: #7f9db9 1px solid; padding-top: 4px; border-bottom: #7f9db9 1px solid; font-family: tahoma"></CalendarStyle>
				                            <TitleArrowStyle CssText="cursor:hand"></TitleArrowStyle>
				                            <DayHoverStyle CssText="font-family: tahoma; font-size: 12px; border-right: #fbe694 1px solid; border-top: #fbe694 1px solid; border-left: #fbe694 1px solid; border-bottom: #fbe694 1px solid"></DayHoverStyle>
				                            <MonthStyle CssText="font-family: tahoma; font-size: 12px; margin-left: 14px; cursor: hand; margin-right: 14px"></MonthStyle>
				                            <TitleStyle CssText="background-color:#9ebef5;font-family:Tahoma;font-size:12px;padding-bottom:2px;padding-left:6px;padding-right:6px;padding-top:2px;"></TitleStyle>
				                            <OtherMonthDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid"></OtherMonthDayStyle>
				                            <DayHeaderStyle CssText="font-family: tahoma; font-size: 12px; border-bottom: #aca899 1px solid"></DayHeaderStyle>
				                            <DayStyle CssText="font-family: tahoma; font-size: 12px; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid"></DayStyle>
			                            </DatePicker>
		                            </eo:DateTimeColumn>
		                            <eo:MaskedEditColumn>
			                            <MaskedEdit ControlSkinID="None" TextBoxStyle-CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; font-family:Courier New;font-size:8pt;"></MaskedEdit>
		                            </eo:MaskedEditColumn>
	                            </ColumnTemplates>
	                            <Columns>
		                            	        
                                    <eo:StaticColumn Width="120" HeaderText="Número Factura" DataField="num"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="180" HeaderText="Cliente" DataField="idCliente"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="40" Visible="false" DataField="idUsuario"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="40" visible ="false" DataField="fechaFacturacion"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="40" visible ="false" DataField="fechaCreacion"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="40" visible ="false" DataField="fechaValidez"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="40" visible ="false" DataField="moneda"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="40" visible ="false" DataField="estado"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="40" visible ="false" DataField="monto"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="40" visible ="false" DataField="tipoDeCambio"></eo:StaticColumn>
                                    
	                            </Columns>
	                            <ColumnHeaderStyle CssText="background-image:url('00050201');padding-left:8px;padding-top:4px;"></ColumnHeaderStyle>
                            </eo:Grid>
        </div>
        
            <div id="divbtnVerVentas" style="width:305px; text-align:right; padding-top:10px;">    
            <asp:ImageButton ID="bntVerVentas" runat="server" 
                ImageUrl="~/Imagenes/btnVer.png" ToolTip="Ver Ventas" Visible="False" />
        </div>
        
        
        </div>
        <div id="derecha" style="float:left; width:500px;" >
        <div id="divVentas">
        <asp:Label ID="lblVentas" runat="server" Font-Names="Arial" Font-Size="20pt" 
                Text="Ventas" ForeColor="#000066" Visible="False"></asp:Label>
        </div>
        <table style="width:350px; text-align:right;">
        <tr>
            <td><asp:Label ID="lblNumero" runat="server" Font-Names="Arial" Font-Size="11pt" 
                Text="Número Ventas" Visible="False"></asp:Label></td>
            <td><asp:TextBox ID="txtNumero" runat="server" Font-Names="Arial" Font-Size="11pt" 
                Width="188px" Visible="False"></asp:TextBox></td>
        </tr>
        <tr>
        <td><asp:Label ID="lblCliente" runat="server" Font-Names="Arial" Font-Size="11pt" 
            Text="Cliente" Visible="False"></asp:Label></td>
        <td><asp:TextBox ID="txtCliente" runat="server" Font-Names="Arial" Font-Size="11pt" 
                Width="188px" Visible="False"></asp:TextBox></td>
        </tr>
        <tr>
        <td> <asp:Label ID="lblFechaFacturacion" runat="server" Font-Names="Arial" 
            Font-Size="11pt" Text="Fecha Facturación" Visible="False"></asp:Label></td>
        <td><asp:TextBox ID="txtFechaFacturacion" runat="server" Font-Names="Arial" 
            Font-Size="11pt" Width="188px" Visible="False"></asp:TextBox></td>
        </tr>
        <tr>
        <td> <asp:Label ID="lblMonto" runat="server" Font-Names="Arial" Font-Size="11pt" 
            Text="Monto" Visible="False"></asp:Label></td>
        <td> <asp:TextBox ID="txtMonto" runat="server" Font-Names="Arial" Font-Size="11pt" 
                Width="188px" Visible="False"></asp:TextBox></td>
        </tr>
        </table>
        
        
       
         <div id="divlblVentasVendedor" style="width:355px; text-align:left;">
            <asp:Label ID="lblVerVentas" runat="server" Text="Ventas del Vendedor" 
                Font-Names="Arial" Font-Size="11pt" Visible="False"></asp:Label>
        </div>
        <div id="divgridLineaDetalle"> 
            <eo:Grid runat="server" id="gridLineasDetalle" BorderColor="#828790" 
                                BorderWidth="1px" GridLines="Both"
	                            FixedColumnCount="1" ColumnHeaderDescImage="00050205" 
                                GridLineColor="240, 240, 240" Width="353px"
	                            IsCallbackByMe="False" ItemHeight="19" 
                ColumnHeaderAscImage="00050204" ColumnHeaderHeight="24"
	                            Height="161px" Font-Size="8.75pt" Font-Names="Tahoma" 
                                    ColumnHeaderDividerImage="00050203" Visible="False">
	                            <ItemStyles>
		                            <eo:GridItemStyleSet>
			                            <ItemHoverStyle CssText="background-image: url(00050206); background-repeat: repeat-x"></ItemHoverStyle>
			                            <SelectedStyle CssText="background-image: url(00050207); background-repeat: repeat-x"></SelectedStyle>
			                            <CellStyle CssText="padding-left:8px;padding-top:2px;"></CellStyle>
			                            <ItemStyle CssText="background-color: white"></ItemStyle>
		                            </eo:GridItemStyleSet>
	                            </ItemStyles>
	                            <ColumnHeaderHoverStyle CssText="background-image:url('00050202');padding-left:8px;padding-top:4px;"></ColumnHeaderHoverStyle>
	                            <ColumnTemplates>
		                            <eo:TextBoxColumn>
			                            <TextBoxStyle CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; FONT-SIZE: 8.75pt; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; FONT-FAMILY: Tahoma"></TextBoxStyle>
		                            </eo:TextBoxColumn>
		                            <eo:DateTimeColumn>
			                            <DatePicker DayHeaderFormat="FirstLetter" DayCellHeight="16" DisabledDates="" TitleLeftArrowImageUrl="DefaultSubMenuIconRTL"
				                            OtherMonthDayVisible="True" DayCellWidth="19" TitleRightArrowImageUrl="DefaultSubMenuIcon"
				                            ControlSkinID="None" SelectedDates="">
				                            <TodayStyle CssText="font-family: tahoma; font-size: 12px; border-right: #bb5503 1px solid; border-top: #bb5503 1px solid; border-left: #bb5503 1px solid; border-bottom: #bb5503 1px solid"></TodayStyle>
				                            <SelectedDayStyle CssText="font-family: tahoma; font-size: 12px; background-color: #fbe694; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid"></SelectedDayStyle>
				                            <DisabledDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid"></DisabledDayStyle>
				                            <PickerStyle CssText="border-bottom-color:#7f9db9;border-bottom-style:solid;border-bottom-width:1px;border-left-color:#7f9db9;border-left-style:solid;border-left-width:1px;border-right-color:#7f9db9;border-right-style:solid;border-right-width:1px;border-top-color:#7f9db9;border-top-style:solid;border-top-width:1px;font-family:Courier New;font-size:8pt;margin-bottom:0px;margin-left:0px;margin-right:0px;margin-top:0px;padding-bottom:1px;padding-left:2px;padding-right:2px;padding-top:2px;"></PickerStyle>
				                            <CalendarStyle CssText="background-color: white; border-right: #7f9db9 1px solid; padding-right: 4px; border-top: #7f9db9 1px solid; padding-left: 4px; font-size: 9px; padding-bottom: 4px; border-left: #7f9db9 1px solid; padding-top: 4px; border-bottom: #7f9db9 1px solid; font-family: tahoma"></CalendarStyle>
				                            <TitleArrowStyle CssText="cursor:hand"></TitleArrowStyle>
				                            <DayHoverStyle CssText="font-family: tahoma; font-size: 12px; border-right: #fbe694 1px solid; border-top: #fbe694 1px solid; border-left: #fbe694 1px solid; border-bottom: #fbe694 1px solid"></DayHoverStyle>
				                            <MonthStyle CssText="font-family: tahoma; font-size: 12px; margin-left: 14px; cursor: hand; margin-right: 14px"></MonthStyle>
				                            <TitleStyle CssText="background-color:#9ebef5;font-family:Tahoma;font-size:12px;padding-bottom:2px;padding-left:6px;padding-right:6px;padding-top:2px;"></TitleStyle>
				                            <OtherMonthDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid"></OtherMonthDayStyle>
				                            <DayHeaderStyle CssText="font-family: tahoma; font-size: 12px; border-bottom: #aca899 1px solid"></DayHeaderStyle>
				                            <DayStyle CssText="font-family: tahoma; font-size: 12px; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid"></DayStyle>
			                            </DatePicker>
		                            </eo:DateTimeColumn>
		                            <eo:MaskedEditColumn>
			                            <MaskedEdit ControlSkinID="None" TextBoxStyle-CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; font-family:Courier New;font-size:8pt;"></MaskedEdit>
		                            </eo:MaskedEditColumn>
	                            </ColumnTemplates>
	                            <Columns>
		                            	        
                                    <eo:StaticColumn Width="110" HeaderText="Código Servicio" DataField="codServicio"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="80" HeaderText="Nombre" DataField="nombre"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="80" HeaderText="Cantidad" DataField="cantidad"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="80" HeaderText="Precio" DataField="precio"></eo:StaticColumn>
                                 
	                            </Columns>
	                            <ColumnHeaderStyle CssText="background-image:url('00050201');padding-left:8px;padding-top:4px;"></ColumnHeaderStyle>
                            </eo:Grid>
            
        </div>
        
    
        </div>
        <div class="clear" style="clear:both;"></div>
       
        
       
    

    </div>
</asp:Content>
