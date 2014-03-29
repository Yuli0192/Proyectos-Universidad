<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="frmRegistrarPlanVenta.aspx.vb" Inherits="SolSiscoveWeb.frmRegistrarPlanVenta" 
    title="Registrar Plan de Ventas" %>
<%@ Register assembly="EO.Web" namespace="EO.Web" tagprefix="eo" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #divDatos
        {
            height: 438px;
        }
        #divDescripcion
        {
            height: 98px;
            width: 1329px;
        }
        #divFechaInicio
        {
            width: 315px;
            height: 220px;
        }
        #divFechaFin
        {
            width: 215px;
            height: 29px;
        }
        #divFechas
        {
            height: 99px;
            width: 1192px;
        }
    </style>
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <script type="text/javascript">
        function agregarDato()
        {
            //Vamos a obtener el textBox donde meten la cantidad de servicios.
            var textbox = document.getElementById("txtVentaPlaneada");
            
            //Validamos que no este en blanco.
            if(textbox.value != ""){
                //Despues le explico este codigo... solo voy a ver si sirve.. :D
                var grid = eo_GetObject("ltbServicios");
            	
                //Item que se selecciona
                var item = grid.getSelectedItem();
        	    grid.deleteItem(item.getIndex());
            	
        	    //Get the Grid object
                var gridDestino = eo_GetObject("ltbserviciosPlan");
                
                //Add a new item
                var itemDestino = gridDestino.addItem();
                itemDestino.getCell(0).setValue(item.getCell(0).getValue());
                itemDestino.getCell(1).setValue(item.getCell(1).getValue());
                itemDestino.getCell(2).setValue(textbox.value);
                
                textbox.value = "";
            }else{
                alert("Debe ingresar la cantidad de ventas.");
            }
        }
        
        function removerDato()
        {
        	//Get the Grid object
            var grid = eo_GetObject("ltbserviciosPlan");
        	
            //Item que se selecciona
            var item = grid.getSelectedItem();
        	grid.deleteItem(item.getIndex());
        	
        	//Get the Grid object
            var gridDestino = eo_GetObject("ltbServicios");
            
            //Add a new item
            var itemDestino = gridDestino.addItem();
            itemDestino.getCell(0).setValue(item.getCell(0).getValue());
            itemDestino.getCell(1).setValue(item.getCell(1).getValue());
        }
    </script>
    <div id="divPrincipal" style="height: 600px; width: 1029px; padding-top:20px;">
        <%-- Label Id--%>
        <div id="divlblRegistrar">
         
            <asp:Label ID="lblRegistrarPlan" runat="server" Text="Registrar Plan de Ventas" 
                Font-Names="Arial" Font-Size="20pt" ForeColor="#000066"></asp:Label>
       
        </div>
        
        <table style="width:400px; padding-top:20px;">
        <tr>
        <td><asp:Label ID="lblIdentificador" runat="server" Text="Identificador:" 
                    Font-Size="11pt"></asp:Label></td>
        <td><asp:TextBox ID="txtId" runat="server" Font-Size="11pt" Width="232px" 
                    Height="25px" MaxLength="50"></asp:TextBox></td>
        </tr>
        
        <tr>
        <td> <asp:Label ID="lblDescripcion" runat="server" Font-Size="11pt" 
                    Text="Descripción:"></asp:Label></td>
        <td><asp:TextBox TextMode="MultiLine" ID="txtDescripcion" style="resize:none;" runat="server" Height="67px" Width="232px" 
                    MaxLength="250"></asp:TextBox> </td>
        </tr>
        <tr>
        <td><asp:Label ID="lbInicio" runat="server"  Font-Size="11pt" Text="Fecha Inicio:"></asp:Label></td>
        <td><eo:DatePicker ID="dtpFechaInicio" runat="server" ControlSkinID="None" 
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
                </eo:DatePicker></td>
                
        </tr>
        
        <tr>
        <td><asp:Label ID="lblFin" runat="server" Font-Size="11pt" Text="Fecha Fin:"></asp:Label></td>
                <td><eo:DatePicker ID="dtpFechaFin" runat="server" ControlSkinID="None" 
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
                </eo:DatePicker></td>
                </tr>
        </table>
        
    
    
        <%-- Button Derecha--%>
        <div id="divlblAsignarServicio" style="padding-top:20px;">
           
                   <asp:Label ID="lblAsignarServicio" class ="titulos" runat="server" Font-Size="15pt" 
                    Text="Asignar Servicio al Plan de Ventas" Font-Names="Arial" 
                    ForeColor="#000066"></asp:Label>
                    
              </div>
              
              <table style="width:500px;">
              <tr>
              <td><asp:Label ID="lblServiciosSinAsignar" runat="server" Font-Size="11pt" 
                                Text="Servicios Sin Asignar"></asp:Label> </td>
              <td> </td>
              <td><asp:Label ID="lblServiciosAsignados" runat="server" Font-Size="11pt" 
                            Text="Servicios Asignados "></asp:Label>
              </td>
              </tr>
              
              <tr>
              <td><eo:Grid runat="server" id="ltbServicios" BorderColor="#828790" 
                        BorderWidth="1px" GridLines="Both"
                        FixedColumnCount="1" ColumnHeaderDescImage="00050205" 
                        GridLineColor="240, 240, 240" Width="240px"
                        IsCallbackByMe="False" ItemHeight="19" ColumnHeaderAscImage="00050204" ColumnHeaderHeight="24"
                        Height="161px" Font-Size="8.75pt" Font-Names="Tahoma" 
                            ColumnHeaderDividerImage="00050203">
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
		                            <DayHoverStyle CssText="font-family: tahoma; font-size: 12px; border-right: #fbe694 1px solid; border-top: #fbe694 1px solid; border-left: #fbe694 1px solid; border-bottom: #fbe694 1px solid"></DayHoverStyle>
		                            <TitleStyle CssText="background-color:#9ebef5;font-family:Tahoma;font-size:12px;padding-bottom:2px;padding-left:6px;padding-right:6px;padding-top:2px;"></TitleStyle>
		                            <DayHeaderStyle CssText="font-family: tahoma; font-size: 12px; border-bottom: #aca899 1px solid"></DayHeaderStyle>
		                            <DayStyle CssText="font-family: tahoma; font-size: 12px; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid"></DayStyle>
		                            <SelectedDayStyle CssText="font-family: tahoma; font-size: 12px; background-color: #fbe694; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid"></SelectedDayStyle>
		                            <TitleArrowStyle CssText="cursor:hand"></TitleArrowStyle>
		                            <TodayStyle CssText="font-family: tahoma; font-size: 12px; border-right: #bb5503 1px solid; border-top: #bb5503 1px solid; border-left: #bb5503 1px solid; border-bottom: #bb5503 1px solid"></TodayStyle>
		                            <PickerStyle CssText="border-bottom-color:#7f9db9;border-bottom-style:solid;border-bottom-width:1px;border-left-color:#7f9db9;border-left-style:solid;border-left-width:1px;border-right-color:#7f9db9;border-right-style:solid;border-right-width:1px;border-top-color:#7f9db9;border-top-style:solid;border-top-width:1px;font-family:Courier New;font-size:8pt;margin-bottom:0px;margin-left:0px;margin-right:0px;margin-top:0px;padding-bottom:1px;padding-left:2px;padding-right:2px;padding-top:2px;"></PickerStyle>
		                            <OtherMonthDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid"></OtherMonthDayStyle>
		                            <CalendarStyle CssText="background-color: white; border-right: #7f9db9 1px solid; padding-right: 4px; border-top: #7f9db9 1px solid; padding-left: 4px; font-size: 9px; padding-bottom: 4px; border-left: #7f9db9 1px solid; padding-top: 4px; border-bottom: #7f9db9 1px solid; font-family: tahoma"></CalendarStyle>
		                            <DisabledDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid"></DisabledDayStyle>
		                            <MonthStyle CssText="font-family: tahoma; font-size: 12px; margin-left: 14px; cursor: hand; margin-right: 14px"></MonthStyle>
	                            </DatePicker>
                            </eo:DateTimeColumn>
                            <eo:MaskedEditColumn>
	                            <MaskedEdit ControlSkinID="None" TextBoxStyle-CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; font-family:Courier New;font-size:8pt;"></MaskedEdit>
                            </eo:MaskedEditColumn>
                        </ColumnTemplates>
                        <Columns>
                            <%--<eo:RowNumberColumn Width="40"></eo:RowNumberColumn>	--%>	        
                            <eo:StaticColumn Width="120" HeaderText="Id" DataField="Id"></eo:StaticColumn>
                            <%--<eo:StaticColumn HeaderText="Cedula" DataField="Cedula"></eo:StaticColumn>--%>
                            <eo:StaticColumn Width="120" HeaderText="Nombre" DataField="Nombre"></eo:StaticColumn>
                            <%--<eo:StaticColumn Width="100" HeaderText="PrimerApellido" DataField="PrimerApellido"></eo:StaticColumn>
                            <eo:StaticColumn Width="100" HeaderText="SegundoApellido" DataField="SegundoApellido"></eo:StaticColumn>
                            <eo:StaticColumn Width="100" HeaderText="NombreUsuario" DataField="NombreUsuario"></eo:StaticColumn>
                            <eo:StaticColumn Width="100" HeaderText="Rol" DataField="Rol"></eo:StaticColumn>--%>
                        </Columns>
                        <ColumnHeaderStyle CssText="background-image:url('00050201');padding-left:8px;padding-top:4px;"></ColumnHeaderStyle>
                    </eo:Grid> </td>
              <td>
              <img src="/Imagenes/btnIzquierda.png" alt="Quitar Servicios al Plan" onclick="removerDato()"/> 
              <br /><br />
              <img src="/Imagenes/btnDerecha.png" alt="Asignar Servicios al Plan" onclick="agregarDato()"/>
              </td>
              <td> <eo:Grid runat="server" id="ltbserviciosPlan" BorderColor="#828790" 
                            BorderWidth="1px" GridLines="Both"
                            FixedColumnCount="1" ColumnHeaderDescImage="00050205" 
                            GridLineColor="240, 240, 240" Width="280px"
                            IsCallbackByMe="False" ItemHeight="19" ColumnHeaderAscImage="00050204" ColumnHeaderHeight="24"
                            Height="161px" Font-Size="8.75pt" Font-Names="Tahoma" 
                                ColumnHeaderDividerImage="00050203" style="margin-bottom: 2px">
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
			                            <TodayStyle CssText="font-family: tahoma; font-size: 12px; border-right: #bb5503 1px solid; border-top: #bb5503 1px solid; border-left: #bb5503 1px solid; border-bottom: #bb5503 1px solid" />
                                        <SelectedDayStyle CssText="font-family: tahoma; font-size: 12px; background-color: #fbe694; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                        <DisabledDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                        <PickerStyle CssText="border-bottom-color:#7f9db9;border-bottom-style:solid;border-bottom-width:1px;border-left-color:#7f9db9;border-left-style:solid;border-left-width:1px;border-right-color:#7f9db9;border-right-style:solid;border-right-width:1px;border-top-color:#7f9db9;border-top-style:solid;border-top-width:1px;font-family:Courier New;font-size:8pt;margin-bottom:0px;margin-left:0px;margin-right:0px;margin-top:0px;padding-bottom:1px;padding-left:2px;padding-right:2px;padding-top:2px;" />
                                        <CalendarStyle CssText="background-color: white; border-right: #7f9db9 1px solid; padding-right: 4px; border-top: #7f9db9 1px solid; padding-left: 4px; font-size: 9px; padding-bottom: 4px; border-left: #7f9db9 1px solid; padding-top: 4px; border-bottom: #7f9db9 1px solid; font-family: tahoma" />
                                        <TitleArrowStyle CssText="cursor:hand" />
			                            <DayHoverStyle CssText="font-family: tahoma; font-size: 12px; border-right: #fbe694 1px solid; border-top: #fbe694 1px solid; border-left: #fbe694 1px solid; border-bottom: #fbe694 1px solid"></DayHoverStyle>
			                            <MonthStyle CssText="font-family: tahoma; font-size: 12px; margin-left: 14px; cursor: hand; margin-right: 14px" />
			                            <TitleStyle CssText="background-color:#9ebef5;font-family:Tahoma;font-size:12px;padding-bottom:2px;padding-left:6px;padding-right:6px;padding-top:2px;"></TitleStyle>
			                            <OtherMonthDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
			                            <DayHeaderStyle CssText="font-family: tahoma; font-size: 12px; border-bottom: #aca899 1px solid"></DayHeaderStyle>
			                            <DayStyle CssText="font-family: tahoma; font-size: 12px; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid"></DayStyle>
		                            </DatePicker>
	                            </eo:DateTimeColumn>
	                            <eo:MaskedEditColumn>
		                            <MaskedEdit ControlSkinID="None" TextBoxStyle-CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; font-family:Courier New;font-size:8pt;"></MaskedEdit>
	                            </eo:MaskedEditColumn>
                            </ColumnTemplates>
                            <Columns>        
                                <eo:StaticColumn Width="95" HeaderText="Id" DataField="Id"></eo:StaticColumn>
                                <eo:StaticColumn Width="95" HeaderText="Nombre" DataField="Nombre"></eo:StaticColumn>
                                <eo:StaticColumn Width="90" HeaderText="Cantidad" DataField="CantVentas"></eo:StaticColumn>
                            </Columns>
                            <ColumnHeaderStyle CssText="background-image:url('00050201');padding-left:8px;padding-top:4px;"></ColumnHeaderStyle>
                        </eo:Grid>
              </td>
              </tr>
              
              </table>
                                    
             
                     
        <%-- Label ltbserviciosPlan--%>
        <div id="divVentasPlaneadas" style="width:560px;">
         
            <div style="float:left;">
                       <%--Inicio del 2er Grid--%>
                       <asp:Label ID="lblVentasPlaneadas" runat="server" Font-Size="11pt" 
                            Text="Ventas Planeadas:"></asp:Label>
                            <input id="txtVentaPlaneada" style="WIDTH: 100px" type="text" />
                   </div> 
                    <div style="float:right;">
                   
                        <asp:ImageButton ID="bntRegistrar" runat="server" 
                            ImageUrl="~/Imagenes/btnRegistrar.png" />
                            <asp:ImageButton ID="bntLimpiar" runat="server" 
                            ImageUrl="~/Imagenes/btnLimpiar.png" />
                </div>  
                <div style="clear:both;"></div> 
        </div> 
       
        
             
      
    </div>
</asp:Content>


<asp:Content ID="Content3" runat="server" contentplaceholderid="head">

    <style type="text/css">
        #divDatos
        {
            height: 886px;
        }
        #divFechas
        {
            height: 253px;
            width: 1273px;
        }
        #divServiciosSinPlan
        {
            height: 245px;
            width: 424px;
        }
        #divAsignarServicios
        {
            height: 299px;
            width: 1536px;
        }
        #divBotonesModificarEliminar
        {
            width: 938px;
            height: 45px;
        }
        #divBotonRegistrar
        {
            height: 53px;
            width: 892px;
        }
        #divServicio
        {
            height: 44px;
            width: 376px;
        }
    </style>

</asp:Content>



