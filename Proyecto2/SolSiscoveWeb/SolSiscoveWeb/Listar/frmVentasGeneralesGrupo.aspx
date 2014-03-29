<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="frmVentasGeneralesGrupo.aspx.vb" Inherits="SolSiscoveWeb.frmVentasGeneralesGrupo" 
    title="Listar Ventas Generales" %>
<%@ Register assembly="EO.Web" namespace="EO.Web" tagprefix="eo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divPrincipal" style="height: 712px; width: 1029px; margin-right: 0px;">
        
        <%-- Textbox Monto--%>
        <div id="divBuscarUsuario">
            <asp:Label ID="lblBuscarGrupo" runat="server" Font-Names="Arial" 
                Font-Size="20pt" ForeColor="#000066" Text="Buscar Grupo"></asp:Label>
        </div>
        
        <%-- Grid Linea Detalle--%>
        <div id="divlblCedula">
            <asp:Label ID="lblCodigo" runat="server" Font-Names="Arial" Font-Size="11pt" 
                Text="Código Grupo:"></asp:Label>
        </div>
        
        <%-- Textbox Monto--%>
        <div id="divdpdlCedula">
            <asp:DropDownList ID="cmbListar" runat="server" Height="29px" Width="125px" 
                AutoPostBack="True">
            </asp:DropDownList>
        </div>
        
        <table style="width:480px;">
        <tr>
        <td><asp:Label ID="lblFechaInicio" runat="server" Font-Names="Arial" Font-Size="11pt" Text="Fecha Inicio:"></asp:Label></td>
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
                    <SelectedDayStyle CssText="font-size: 11px; font-family: verdana;border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; background-color: white" />
                    <CalendarStyle CssText="border-right: #cfd9e3 1px solid; border-top: #cfd9e3 1px solid; font-size: 11px; border-left: #cfd9e3 1px solid; cursor: hand; border-bottom: #cfd9e3 1px solid; font-family: verdana; background-color: #eaeaea" />
                    <DayHoverStyle CssText="font-size: 11px; font-family: verdana;border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; background-color: white" />
                    <TitleStyle CssText="padding-right: 3px; padding-left: 3px; font-weight: bold; padding-bottom: 3px; color: white; padding-top: 3px; border-bottom: #cfd9e3 1px solid; background-color: #006699; font-size: 11px; font-family: verdana;" />
                    <DayHeaderStyle CssText="font-size: 11px; font-family: verdana;height: 17px" />
                    <DayStyle CssText="font-size: 11px; font-family: verdana;border-right: #eaeaea 1px solid; border-top: #eaeaea 1px solid; border-left: #eaeaea 1px solid; border-bottom: #eaeaea 1px solid; background-color: #eaeaea" />
                </eo:DatePicker>
        </td>
        <td><asp:Label ID="lblFechaFin" runat="server" Font-Names="Arial" Font-Size="11pt" Text="Fecha Fin:"></asp:Label></td>
        <td><eo:DatePicker ID="dtpFechaFin" runat="server" ControlSkinID="None" 
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
        <td> <asp:ImageButton ID="bntBuscarGrupos" runat="server" 
            ImageUrl="~/Imagenes/btnVer.png" ToolTip="Ver Ventas " /></td>
        </tr>
        </table>
        
        
        
        
          <%-- Label Ventas Generales--%>
        <div id="divlblVentasGenerales" style="padding-top:20px;">
        <asp:Label ID="lblVentasGenerales" runat="server" Font-Names="Arial" 
                Font-Size="15pt" Text="Ventas Generales" ForeColor="#000066" Visible="False"></asp:Label>
        </div>
        
      
            
      
      <table style="width:300px; text-align:right;">
      <tr>
      <td><asp:Label ID="lblCodigoGrupo" runat="server" Font-Names="Arial" 
                Font-Size="11pt" Text="Código del grupo:" Visible="False"></asp:Label>
                <asp:TextBox ID="txtCodigoGrupo" runat="server" Visible="False"></asp:TextBox></td>
      </tr>
      <tr>
      <td> <asp:Label ID="lblMontoTotal" runat="server" Font-Names="Arial" 
                Font-Size="11pt" Text="Monto Total:" Visible="False"></asp:Label>
                 <asp:TextBox ID="txtMontoTotal" runat="server" Visible="False"></asp:TextBox></td>
      </tr>
      </table>
        
      
       
        
            <%-- Label Facturas--%>
        <div id="divlblFacturas" style="width:725px; text-align:left;">
        <asp:Label ID="lblFacturas" runat="server" Font-Names="Arial" Font-Size="15pt" 
                Text="Facturas Vendedores" ForeColor="#000066" Visible="False"></asp:Label>
        </div>
        
         <%-- Textbox Monto--%>         <%-- Grid Linea Detalle--%>
        <div id="divgridComision">  
            <eo:Grid runat="server" id="gridGrupo" BorderColor="#828790" 
                                BorderWidth="1px" GridLines="Both"
	                            FixedColumnCount="1" ColumnHeaderDescImage="00050205" 
                                GridLineColor="240, 240, 240" Width="723px"
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

                                    <eo:StaticColumn Width="120" HeaderText="Número de factura" DataField="num"></eo:StaticColumn>
                                    <eo:StaticColumn Width="180" HeaderText="Cliente" DataField="idCliente"></eo:StaticColumn>
                                    <eo:StaticColumn Width="180" HeaderText="Usuario" DataField="idUsuario"></eo:StaticColumn>
                                    <eo:StaticColumn Width="120" HeaderText="Fecha Facturación" DataField="fechaFacturacion"></eo:StaticColumn>
                                    <eo:StaticColumn Width="120" HeaderText="Monto" DataField="monto"></eo:StaticColumn>
                                    
	                            </Columns>
	                            <ColumnHeaderStyle CssText="background-image:url('00050201');padding-left:8px;padding-top:4px;"></ColumnHeaderStyle>
                            </eo:Grid>
        </div> 
            
        
       
        
     
        
     
        
    </div>
</asp:Content>