<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="frmBuscarModificarPlanVenta.aspx.vb" Inherits="SolSiscoveWeb.frmBuscarPlanVenta" 
    title="Buscar/Modificar/Plan de Ventas" %>
<%@ Register assembly="EO.Web" namespace="EO.Web" tagprefix="eo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #divEncabezadoBuscar
        {
            width: 304px;
            height: 26px;
        }
        #divEncabezadoModificar
        {
            height: 29px;
        }
        #divDatos
        {
            height: 779px;
        }
        #divDatosBuscar
        {
            width: 736px;
            height: 770px;
        }
        #divBotonBuscar
        {
            width: 458px;
            height: 43px;
            margin-top: 0px;
        }
        #divBusqueda
        {
            height: 413px;
            width: 666px;
        }
        #divDescripcion
        {
            height: 90px;
            width: 436px;
        }
        #divModificarServicios
        {
            height: 531px;
        }
        .style4
        {
            width: 193px;
        }
    </style>
</asp:Content>
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
                
                __doPostBack(item.getCell(0).getValue() + ",agregar," + textbox.value );
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
            
            __doPostBack(item.getCell(0).getValue() + ",remover, ");
        }
    </script>
    
    
        <div id="div1" style="width:1029px; height:602px;  padding-top:30px;">
        <div id="buscarServicio" style="float:left; width:580px; height: 525px;">
        
                <asp:Label ID="lblBuscarPlan" runat="server" Font-Names="Arial" 
                    Font-Size="20pt" ForeColor="#000066" Text="Buscar Plan de Ventas"></asp:Label>

        <div id="div2" 
                style="float:left; text-align:left; padding-top:20px;">
            <table style="width:200px;">
            <tr>
            <td><asp:Label ID="lblFechaInicio" runat="server" Font-Size="11pt" 
                            Text="Fecha Inicio:"></asp:Label>
                <eo:DatePicker ID="dtpInicio" runat="server" AutoPostbackOnSelect="True" ControlSkinID="None" 
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
            <td> <asp:Label ID="lblFechaFin" runat="server" Font-Size="11pt" Text="Fecha Fin:"></asp:Label>
                <eo:DatePicker ID="dtpFechaFin" runat="server" ControlSkinID="None"  AutoPostbackOnSelect="True"
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
                <td><asp:ImageButton ID="bntBuscar" runat="server" 
                    ImageUrl="~/Imagenes/btnBuscar.png" style="margin-top:10px;" ToolTip="Buscar" Height="30px" 
                    Width="30px" /></td>
            </tr>
            </table>
                
                    
                   
</div>
<div id="Div3" style="float:left; height:30px; padding-top:16px;">
                
                
</div>
      
      <div class="clear" style="clear:both; height: 19px;"></div>
        
         
        <%-- Grid Cliente--%>
        <div id="divgridServicio">
           <eo:Grid runat="server" id="gridPlanVenta" BorderColor="#828790" 
                                BorderWidth="1px" GridLines="Both"
	                            FixedColumnCount="1" ColumnHeaderDescImage="00050205" 
                                GridLineColor="240, 240, 240" Width="550px"
	                            IsCallbackByMe="False" ItemHeight="19" 
                ColumnHeaderAscImage="00050204" ColumnHeaderHeight="24"
	                            Height="276px" Font-Size="8.75pt" Font-Names="Tahoma" 
                                    ColumnHeaderDividerImage="00050203" style="cursor:pointer;">
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
		                            	        
                                    <eo:StaticColumn Width="80" HeaderText="Identificador" DataField="idPlanVenta"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="300" HeaderText="Descripcion" DataField="descripcion"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="90" HeaderText="Fecha Inicio" DataField="fechaInicio"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="90" HeaderText="Fecha Fin" DataField="fechaFin"></eo:StaticColumn>
           
	                            </Columns>
	                            <ColumnHeaderStyle CssText="background-image:url('00050201');padding-left:8px;padding-top:4px;"></ColumnHeaderStyle>
                            </eo:Grid>
          <%--  <asp:GridView ID="gvCliente" runat="server" CellPadding="4" ForeColor="#333333" 
                GridLines="None" CaptionAlign="Left" Height="200px" Width="400px" 
                style="margin-bottom: 0px">
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Seleccionar" 
                        ShowHeader="True" Text="Seleccionar" />
                </Columns>
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#999999" />
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            </asp:GridView>--%>
           </div>
           
             <%-- Button Modificar--%>
        <div id="divbtnModificarEliminar" style="width:555px; padding-top:10px;">
          
          <div style="float:right;">
                <asp:ImageButton ID="bntModificar" runat="server" 
                    ImageUrl="~/Imagenes/btnModificar.png" ToolTip="Modificar" />
                <asp:ImageButton ID="bntEliminar" runat="server" 
                    ImageUrl="~/Imagenes/btnEliminar.png" ToolTip="Eliminar" />
            
             </div>
            </div>   
            
             </div>   
       
           <div id="modificarServicio" runat="server" visible="False" style="float:left; width:439px;">
         
      
         
          <%-- Label Modificar--%>
        <div id="div4" style="height: 32px;">
        
            <asp:Label ID="lblModificar" runat="server" Text="Modificar Plan" 
                Font-Names="Arial" Font-Size="20pt" ForeColor="#000066"></asp:Label>
         
       </div>
       
        <%-- Table Identificador--%>
    
            <table id="ServicioTabla" style="width:400px; padding-top:20px; text-align:right;">
                <tr>
                
                <td><asp:Label ID="lblId" runat="server" Font-Size="11pt" Text="Identificador:"></asp:Label></td>
                <td><asp:TextBox ID="txtId" runat="server" Width="207px" ReadOnly="True"></asp:TextBox>  </td>
                </tr>
                
                <tr>
                <td><asp:Label ID="lblDescripcion" runat="server" Font-Size="11pt" Text="Descripción:"></asp:Label></td>
                <td><textarea ID="txtDescripcion" runat="server" style="resize:none;" rows="5" cols="22"  readonly="readonly" /></td>
                </tr>
                
                <tr>
                <td  <asp:Label ID="Label2" runat="server" Text="Descripción:" Font-Size="11pt"></asp:Label> <asp:Label ID="lblFechaInicio2" runat="server" Font-Size="11pt" Text="Fecha Inicio:"></asp:Label></td>
                <td>  <asp:TextBox ID="txtFechaInicio" runat="server" Font-Size="11pt" 
                        Height="23px" Width="208px" ReadOnly="True"></asp:TextBox></td>
                </tr>
                
                <tr>
                    <td> <asp:Label ID="lblfechaFin2" runat="server" Font-Size="11pt" Text="Fecha Fin:"></asp:Label> </td>
                    <td><asp:TextBox ID="txtFechaFin" runat="server" Font-Size="11pt" 
                        Width="207px" Height="23px" ReadOnly="True"></asp:TextBox></td>
                    
                </tr>
                
              
               
            </table>
            
            
            
            
            
        <%-- Table Identificador--%>
    
            <table id="Table1" 
                   style="width:400px; padding-top:20px; text-align:right; height: 235px; margin-top: 36px;">
                <tr>
                
                    <td class="style4">
                        <asp:Label ID="lblModificarServicio" runat="server" Font-Size="13pt" 
                            ForeColor="#000066" Text="Modificar Servicio del Plan"></asp:Label>
                    </td>
                    <td> </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                
                <td class="style4"><asp:Label ID="lblServiciosSinAsignar" runat="server" Font-Size="11pt" Text="Servicios Sin Asignar"></asp:Label></td>
                <td> </td>
                <td><asp:Label ID="lblServiciosAsignados" runat="server" Font-Size="11pt" Text="Servicios Asignados "></asp:Label>  </td>
                </tr>
                
                <tr>
                <td class="style4" style="text-align:left;">
                     <eo:Grid ID="ltbServicios" runat="server" BorderColor="#828790" 
                         BorderWidth="1px" ColumnHeaderAscImage="00050204" 
                         ColumnHeaderDescImage="00050205" ColumnHeaderDividerImage="00050203" 
                         ColumnHeaderHeight="24" FixedColumnCount="1" Font-Names="Tahoma" 
                         Font-Size="8.75pt" GridLineColor="240, 240, 240" GridLines="Both" 
                         Height="152px" IsCallbackByMe="False" ItemHeight="19" Width="186px">
                         <ItemStyles>
                             <eo:GridItemStyleSet>
                                 <ItemHoverStyle CssText="background-image: url(00050206); background-repeat: repeat-x" />
                                 <SelectedStyle CssText="background-image: url(00050207); background-repeat: repeat-x" />
                                 <CellStyle CssText="padding-left:8px;padding-top:2px;" />
                                 <ItemStyle CssText="background-color: white" />
                             </eo:GridItemStyleSet>
                         </ItemStyles>
                         <ColumnHeaderHoverStyle CssText="background-image:url('00050202');padding-left:8px;padding-top:4px;" />
                         <ColumnTemplates>
                             <eo:TextBoxColumn>
                                 <TextBoxStyle CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; FONT-SIZE: 8.75pt; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; FONT-FAMILY: Tahoma" />
                             </eo:TextBoxColumn>
                             <eo:DateTimeColumn>
                                 <DatePicker ControlSkinID="None" DayCellHeight="16" DayCellWidth="19" 
                                     DayHeaderFormat="FirstLetter" DisabledDates="" OtherMonthDayVisible="True" 
                                     SelectedDates="" TitleLeftArrowImageUrl="DefaultSubMenuIconRTL" 
                                     TitleRightArrowImageUrl="DefaultSubMenuIcon">
                                     <DayHoverStyle CssText="font-family: tahoma; font-size: 12px; border-right: #fbe694 1px solid; border-top: #fbe694 1px solid; border-left: #fbe694 1px solid; border-bottom: #fbe694 1px solid" />
                                     <TitleStyle CssText="background-color:#9ebef5;font-family:Tahoma;font-size:12px;padding-bottom:2px;padding-left:6px;padding-right:6px;padding-top:2px;" />
                                     <DayHeaderStyle CssText="font-family: tahoma; font-size: 12px; border-bottom: #aca899 1px solid" />
                                     <DayStyle CssText="font-family: tahoma; font-size: 12px; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                     <SelectedDayStyle CssText="font-family: tahoma; font-size: 12px; background-color: #fbe694; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                     <TitleArrowStyle CssText="cursor:hand" />
                                     <TodayStyle CssText="font-family: tahoma; font-size: 12px; border-right: #bb5503 1px solid; border-top: #bb5503 1px solid; border-left: #bb5503 1px solid; border-bottom: #bb5503 1px solid" />
                                     <PickerStyle CssText="border-bottom-color:#7f9db9;border-bottom-style:solid;border-bottom-width:1px;border-left-color:#7f9db9;border-left-style:solid;border-left-width:1px;border-right-color:#7f9db9;border-right-style:solid;border-right-width:1px;border-top-color:#7f9db9;border-top-style:solid;border-top-width:1px;font-family:Courier New;font-size:8pt;margin-bottom:0px;margin-left:0px;margin-right:0px;margin-top:0px;padding-bottom:1px;padding-left:2px;padding-right:2px;padding-top:2px;" />
                                     <OtherMonthDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                     <CalendarStyle CssText="background-color: white; border-right: #7f9db9 1px solid; padding-right: 4px; border-top: #7f9db9 1px solid; padding-left: 4px; font-size: 9px; padding-bottom: 4px; border-left: #7f9db9 1px solid; padding-top: 4px; border-bottom: #7f9db9 1px solid; font-family: tahoma" />
                                     <DisabledDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" />
                                     <MonthStyle CssText="font-family: tahoma; font-size: 12px; margin-left: 14px; cursor: hand; margin-right: 14px" />
                                 </DatePicker>
                             </eo:DateTimeColumn>
                             <eo:MaskedEditColumn>
                                 <MaskedEdit ControlSkinID="None" 
                                     TextBoxStyle-CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; font-family:Courier New;font-size:8pt;">
                                 </MaskedEdit>
                             </eo:MaskedEditColumn>
                         </ColumnTemplates>
                         <Columns>
                             <eo:StaticColumn DataField="Id" HeaderText="Id" Width="93">
                             </eo:StaticColumn>
                             <eo:StaticColumn DataField="Nombre" HeaderText="Nombre" Width="93">
                             </eo:StaticColumn>
                         </Columns>
                         <ColumnHeaderStyle CssText="background-image:url('00050201');padding-left:8px;padding-top:4px;" />
                     </eo:Grid>
                    </td>
                <td> 
                    <img alt="Asignar Servicios al Plan" 
                        onclick="agregarDato()" 
                        src="/Imagenes/btnDerecha.png" 
                        style="margin-top: 10px" />
                        <img 
                        alt="Quitar Servicios al Plan" onclick="removerDato()" 
                        src="/Imagenes/btnIzquierda.png" 
                        style="margin-top: 24px" /></td>
                <td style="text-align:left;">
                    <eo:Grid ID="ltbserviciosPlan" runat="server" BorderColor="#828790" 
                        BorderWidth="1px" ColumnHeaderAscImage="00050204" 
                        ColumnHeaderDescImage="00050205" ColumnHeaderDividerImage="00050203" 
                        ColumnHeaderHeight="24" FixedColumnCount="1" Font-Names="Tahoma" 
                        Font-Size="8.75pt" GridLineColor="240, 240, 240" GridLines="Both" 
                        Height="161px" IsCallbackByMe="False" ItemHeight="19" Width="240px">
                        <ItemStyles>
                            <eo:GridItemStyleSet>
                                <ItemHoverStyle CssText="background-image: url(00050206); background-repeat: repeat-x" />
                                <SelectedStyle CssText="background-image: url(00050207); background-repeat: repeat-x" />
                                <CellStyle CssText="padding-left:8px;padding-top:2px;" />
                                <ItemStyle CssText="background-color: white" />
                            </eo:GridItemStyleSet>
                        </ItemStyles>
                        <ColumnHeaderHoverStyle CssText="background-image:url('00050202');padding-left:8px;padding-top:4px;" />
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
                        <Columns>
                            <eo:StaticColumn DataField="Id" HeaderText="Id" Width="93">
                            </eo:StaticColumn>
                            <eo:StaticColumn DataField="Nombre" HeaderText="Nombre" Width="93">
                            </eo:StaticColumn>
                            <eo:StaticColumn DataField="CantVentas" HeaderText="Cantidad de Ventas" 
                                Width="64">
                            </eo:StaticColumn>
                        </Columns>
                        <ColumnHeaderStyle CssText="background-image:url('00050201');padding-left:8px;padding-top:4px;" />
                    </eo:Grid>
                    </td>
                </tr>
                
                <tr>
                <td  <asp:Label ID="Label4" runat="server" Text="Descripción:" Font-Size="11pt" 
                        class="style4"></asp:Label> <asp:Label ID="lblVentasPlaneadas" runat="server" Font-Size="11pt" Text="Ventas Planeadas:"></asp:Label><input ID="txtVentaPlaneada" style="WIDTH: 70px; margin-left: 11px;" type="text" /></td>
                <td>  &nbsp;</td>
                </tr>
                
                <tr>
                    <td class="style4"> &nbsp;</td>
                    <td>&nbsp;</td>
                    
                </tr>
                
              
               
            </table>
          
             
             
             </div>
             
             <div class="clear" style="clear:both;"></div>
           </div>   
    
</asp:Content>
