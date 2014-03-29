<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master"  CodeBehind="frmBuscarModificarCliente.aspx.vb" Inherits="SolSiscoveWeb.frmBuscarModificarCliente" 
    title="Buscar_Modificar_Cliente" %>
<%@ Register assembly="EO.Web" namespace="EO.Web" tagprefix="eo" %>
    
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
       #divEncabezadoBuscar{
    width: 350px;
}

#divEncabezadoModificar{
    width: 446px;
}

#divBotonBuscar{
    width: 180px;
}

#divDatosBuscar{
    width: 649px;
    height: 317px;
}

#divBotonesEliminarModificar{
    height: 138px;
    width: 576px;
            margin-top: 38px;
        }
#divNombre{
    height: 40px;
    width: 541px;
}
    
#divTelefono{
    height: 40px;
    width: 541px;
}

#divCorreo{
    height: 40px;
    width: 541px;
}

#divContacto{
    height: 40px;
    width: 541px;
}

#divDireccion{
    height: 40px;
    width: 541px;
}

#divBotonesModificar{
    height: 40px;
    width: 424px;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divPrincipal" style="height: 700px; width: 1029px; padding-top:30px;">
    
    
         <div id="izquierda" style="float:left; width:529px;">
        
        <asp:Label ID="lblBuscarServicio" runat="server" Text="Buscar Cliente" 
                Font-Names="Arial" Font-Size="20pt" ForeColor="#000066"></asp:Label>
                <br />
        
        <div id="divBuscar" style="float:left; text-align:left; width:355px; padding-top:20px; padding-left:10px;">
            
           
                  <asp:RadioButtonList ID="rblCriterio" AutoPostBack="True" runat="server" Width="180px" RepeatLayout="Flow" RepeatDirection="Horizontal">
                    <asp:ListItem Value="rbtId" Selected="True">Identificador</asp:ListItem>
                    <asp:ListItem Value="rbtNombre">Nombre</asp:ListItem>
                      
                </asp:RadioButtonList>
                
                <asp:TextBox ID="txtCriterio" runat="server" Width="161px"></asp:TextBox>
</div>
<div id="buscarBtn" style="float:left; height:30px; padding-top:16px;">
                <asp:ImageButton ID="bntBuscar" runat="server" 
                        ImageUrl="~/Imagenes/btnBuscar.png" ToolTip="Buscar" Width="30px" 
                        Height="31px" />
</div>
      
      <div class="clear" style="clear:both;"></div>
         
        <%-- Grid Cliente--%>
        <div id="divgridCliente" style="width:500px;">
           <eo:Grid runat="server" id="gridCliente" BorderColor="#828790" 
                                BorderWidth="1px" GridLines="Both"
	                            FixedColumnCount="1" ColumnHeaderDescImage="00050205" 
                                GridLineColor="240, 240, 240" Width="500px"
	                            IsCallbackByMe="False" ItemHeight="19" 
                ColumnHeaderAscImage="00050204" ColumnHeaderHeight="24"
	                            Height="276px" Font-Size="8.75pt" Font-Names="Tahoma" 
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
		                            	        
                                    <eo:StaticColumn Width="100" HeaderText="Identificador" DataField="idCliente"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="180" HeaderText="Nombre" DataField="nombreCliente"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="100" HeaderText="Teléfono" DataField="telefonoCliente"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="120" HeaderText="Correo" DataField="correoCliente"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="180" HeaderText="Contacto" DataField="contactoCliente"></eo:StaticColumn>
                                    
                                    <eo:StaticColumn Width="180" HeaderText="Dirección" DataField="direccionCliente"></eo:StaticColumn>
                                   
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
        <div id="divbntModificar" style="width:503px; text-align:right; padding-top:10px;">
          
                 <asp:ImageButton ID="bntModificar" runat="server" 
                         ImageUrl="~/Imagenes/btnModificar.png" ToolTip="Modificar" />
                         <asp:ImageButton ID="bntEliminar" runat="server" 
                         ImageUrl="~/Imagenes/btnEliminar.png" Width="30px" ToolTip="Eliminar" />
            
            </div> 
            
            </div>
     
           
                  <div id="derecha" runat="server" visible="false" style="float:left; width:500px;"> 
                 <%-- Label Modificar--%>
        <div id="divlblModificar">
        
            <asp:Label ID="lblModificar" runat="server" Text="Modificar Cliente" 
                Font-Names="Arial" Font-Size="20pt" ForeColor="#000066"></asp:Label>
         
       </div>
       
       <table style="width:400px; text-align:right; padding-top:20px;">
       <tr>
       <td><asp:Label ID="lblId" runat="server" Text="Identificación:" Font-Size="11pt"></asp:Label></td>
       <td> 
           <asp:TextBox ID="txtId" runat="server" Height="25px" Width="210px" 
                    ToolTip="Ej.: 3224307" Font-Size="11pt" ReadOnly="True"></asp:TextBox></td>
       </tr>
       
       <tr>
       <td><asp:Label ID="lblNombre" runat="server" Text="Nombre:" Font-Size="11pt"></asp:Label></td>
       <td><asp:TextBox ID="txtNombre" runat="server" Height="25px" Width="210px" 
                    ToolTip="Ej.: INA o Eduardo Solano Mate" Font-Size="11pt"></asp:TextBox></td>
       </tr>
       <tr>
       <td> <asp:Label ID="lblTelefono" runat="server" Text="Teléfono:" Font-Size="11pt"></asp:Label></td>
       <td> <asp:TextBox ID="txtTelefono" runat="server" Height="25px" Width="210px" 
                    ToolTip="2574-1023" Font-Size="11pt"></asp:TextBox></td>
       </tr>
       
       <tr>
       <td>
                <asp:Label ID="lblCorreo" runat="server" Text="Correo Cliente:" 
                    Font-Size="11pt"></asp:Label></td>
       <td><asp:TextBox ID="txtCorreo" runat="server" Height="25px" Width="210px" 
                    ToolTip="Ej.: cliente@argus.com" Font-Size="11pt"></asp:TextBox></td>
       </tr>
       
       <tr>
       <td>  <asp:Label ID="lblContacto" runat="server" Text="Contacto:" Font-Size="11pt"></asp:Label></td>
       <td><asp:TextBox ID="txtContacto" runat="server" Height="24px" Width="210px" 
                    ToolTip="Ej.: Manuel Quesada Mate" Font-Size="11pt"></asp:TextBox></td>
       </tr>
       
       <tr>
       <td> <asp:Label ID="lblDireccion" runat="server" Text="Dirección:" Font-Size="11pt"></asp:Label></td>
       <td><asp:TextBox ID="txtDireccion" runat="server" Height="25px" Width="210px" 
                    ToolTip="San Jose" Font-Size="11pt"></asp:TextBox></td>
       </tr>
        </table>
       


       <%-- Button Confirmar Modificar--%>
       <div id="btnConfirmarModificacion" style="width:400px; text-align:right; padding-top:10px;">
        
            <asp:ImageButton ID="bntConfirmarModificacion" runat="server" 
                         ImageUrl="~/Imagenes/btnConfirmarModificacion.png" 
                         ToolTip="Confirmar Modificación" />
        
        </div>
            
            </div> 
         
         <div class="clear" style="clear:both;"></div>
         
  
            
   
         
             
    </div>
</asp:Content>
