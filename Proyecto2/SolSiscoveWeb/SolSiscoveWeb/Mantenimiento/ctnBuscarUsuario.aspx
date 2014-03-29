<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="ctnBuscarUsuario.aspx.vb" Inherits="SolSiscoveWeb.ctnBuscarUsuario" 
    title="Untitled Page" %>
    <%@ Register Assembly="EO.Web" Namespace="EO.Web" TagPrefix="eo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
    #form1
    {
        height: 700px;
        width: 1199px;
        margin-right: 0px;
    }
    #divCriterios
    {
        width: 430px;
    }
    #divCont1
    {
        height: 243px;
    }
    #divLista
    {
        height: 218px;
        width: 430px;
    }
    #divBuscar
    {
        width: 430px;
    }
    #divBtnModificar
    {
        height: 38px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divPrincipal" style="height: 764px; width:1029px; padding-top:20px;">
      <div id="izquierda" style="width:529px; float:left;">
                    <div id="divBuscar" style="text-align:center;">
                        <asp:Label ID="lblBuscarUsuario" runat="server" Text="Buscar Usuario" runat="server" Font-Names="Arial" Font-Size="20pt" ForeColor="#000066"></asp:Label>
                    </div>
                    <br />
                    <div id="divCont1" style="top: 200px; left: 200px; width: 431px;">
                        <div id="divCriterios" style="padding-bottom:10px;">
                            <asp:RadioButton ID="rbtIdentificacion" runat="server" Text="Identificación" 
                                Checked="True" GroupName="criterio" AutoPostBack="True" Font-Names="Arial" Font-Size="11pt"/>
                            &nbsp;&nbsp;
                            <asp:RadioButton ID="rbtNombre" runat="server" Text="Nombre" 
                                groupname="criterio" AutoPostBack="True" Font-Names="Arial" Font-Size="11pt"/>
                            &nbsp;
                            <asp:TextBox ID="txtCriterio" runat="server" style="margin-bottom: 0px; margin-left: 0px; margin-right: 0px;" 
                                Width="176px"/>
                            &nbsp;
                            <asp:ImageButton ID="btnBuscar" runat="server" Height="30px" Width="30px" 
                                ImageUrl="~/Imagenes/btnBuscar.png" ToolTip="Buscar" />
                        </div>
                        <div id="divLista">
                            <eo:Grid ID="gridListaUsuarios" runat="server" BorderColor="#828790" 
                                BorderWidth="1px" ColumnHeaderAscImage="00050204" 
                                ColumnHeaderDescImage="00050205" ColumnHeaderDividerImage="00050203" 
                                ColumnHeaderHeight="24" FixedColumnCount="1" Font-Bold="False" 
                                Font-Italic="False" Font-Names="Tahoma" Font-Overline="False" 
                                Font-Size="8.75pt" Font-Strikeout="False" Font-Underline="False" 
                                GoToBoxVisible="True" GridLineColor="240, 240, 240" GridLines="Both" 
                                Height="200px" ItemHeight="19" Width="430px"><FooterStyle CssText="padding-bottom:4px;padding-left:4px;padding-right:4px;padding-top:4px;" /><ColumnTemplates><eo:TextBoxColumn><TextBoxStyle CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; FONT-SIZE: 8.75pt; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; FONT-FAMILY: Tahoma" /></eo:TextBoxColumn><eo:DateTimeColumn><DatePicker ID="DatePicker1" runat="server" ControlSkinID="None" DayCellHeight="16" DayCellWidth="19" 
                                            DayHeaderFormat="FirstLetter" DisabledDates="" OtherMonthDayVisible="True" 
                                            SelectedDates="" TitleLeftArrowImageUrl="DefaultSubMenuIconRTL" 
                                            TitleRightArrowImageUrl="DefaultSubMenuIcon"><TodayStyle CssText="font-family: tahoma; font-size: 12px; border-right: #bb5503 1px solid; border-top: #bb5503 1px solid; border-left: #bb5503 1px solid; border-bottom: #bb5503 1px solid" /><SelectedDayStyle CssText="font-family: tahoma; font-size: 12px; background-color: #fbe694; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" /><DisabledDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" /><PickerStyle CssText="border-bottom-color:#7f9db9;border-bottom-style:solid;border-bottom-width:1px;border-left-color:#7f9db9;border-left-style:solid;border-left-width:1px;border-right-color:#7f9db9;border-right-style:solid;border-right-width:1px;border-top-color:#7f9db9;border-top-style:solid;border-top-width:1px;font-family:Courier New;font-size:8pt;margin-bottom:0px;margin-left:0px;margin-right:0px;margin-top:0px;padding-bottom:1px;padding-left:2px;padding-right:2px;padding-top:2px;" /><CalendarStyle CssText="background-color: white; border-right: #7f9db9 1px solid; padding-right: 4px; border-top: #7f9db9 1px solid; padding-left: 4px; font-size: 9px; padding-bottom: 4px; border-left: #7f9db9 1px solid; padding-top: 4px; border-bottom: #7f9db9 1px solid; font-family: tahoma" /><TitleArrowStyle CssText="cursor:hand" /><DayHoverStyle CssText="font-family: tahoma; font-size: 12px; border-right: #fbe694 1px solid; border-top: #fbe694 1px solid; border-left: #fbe694 1px solid; border-bottom: #fbe694 1px solid" /><MonthStyle CssText="font-family: tahoma; font-size: 12px; margin-left: 14px; cursor: hand; margin-right: 14px" /><TitleStyle CssText="background-color:#9ebef5;font-family:Tahoma;font-size:12px;padding-bottom:2px;padding-left:6px;padding-right:6px;padding-top:2px;" /><OtherMonthDayStyle CssText="font-family: tahoma; font-size: 12px; color: gray; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" /><DayHeaderStyle CssText="font-family: tahoma; font-size: 12px; border-bottom: #aca899 1px solid" /><DayStyle CssText="font-family: tahoma; font-size: 12px; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid" /></DatePicker></eo:DateTimeColumn><eo:MaskedEditColumn><MaskedEdit ID="MaskedEdit1" runat="server" ControlSkinID="None" 
                                            TextBoxStyle-CssText="BORDER-RIGHT: #7f9db9 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7f9db9 1px solid; PADDING-LEFT: 2px; PADDING-BOTTOM: 1px; MARGIN: 0px; BORDER-LEFT: #7f9db9 1px solid; PADDING-TOP: 2px; BORDER-BOTTOM: #7f9db9 1px solid; font-family:Courier New;font-size:8pt;"></MaskedEdit></eo:MaskedEditColumn></ColumnTemplates><ColumnHeaderStyle CssText="background-image:url('00050201');padding-left:8px;padding-top:4px;" /><ItemStyles><eo:GridItemStyleSet><ItemStyle CssText="background-color: white" /><ItemHoverStyle CssText="background-image: url(00050206); background-repeat: repeat-x" /><SelectedStyle CssText="background-image: url(00050207); background-repeat: repeat-x" /><CellStyle CssText="padding-left:8px;padding-top:2px;white-space:nowrap;" /></eo:GridItemStyleSet></ItemStyles><ColumnHeaderHoverStyle CssText="background-image:url('00050202');padding-left:8px;padding-top:4px;" /><Columns><eo:StaticColumn HeaderText="Cédula" ReadOnly="True" DataField="cedula"></eo:StaticColumn><eo:StaticColumn HeaderText="Nombre" ReadOnly="True" DataField="nombre"></eo:StaticColumn><eo:StaticColumn HeaderText="Primer Apellido" MinWidth="10" ReadOnly="True" DataField="apellido1"
                                        Width="115"></eo:StaticColumn><eo:StaticColumn HeaderText="Segundo Apellido" ReadOnly="True" Width="115" DataField="apellido2"></eo:StaticColumn></Columns></eo:Grid>
                        </div>
                        <div style="width: 430px;" align="right">
                            <asp:ImageButton ID="btnLlenarModificar" runat="server" Height= "30" Width="30" 
                                ImageUrl="~/Imagenes/btnModificar.png" ToolTip="Modificar"/>
                            &nbsp; &nbsp;
                            <asp:ImageButton ID="btnEliminar" runat="server" Height= "30px" Width="30px" 
                                ImageUrl="~/Imagenes/btnEliminar.png" ToolTip="Eliminar"/>
                        </div>
                    </div>
                    </div>
                    
                    <div id="derecha" style="width:500px; float:left;">
               
                    <div id="divTModificar" style="text-align:center;">
                        <asp:Label ID="lblTituloModificar" runat="server" Text="Modificar Usuario" runat="server" Font-Names="Arial" Font-Size="20pt" ForeColor="#000066"></asp:Label>
                    </div>
                    <br />
                    <div id="divContenedorModificar" style="text-align:right;">
                        <asp:Label ID="lblCedula"  runat="server" Text="Cédula:" Font-Names="Arial" Font-Size="11pt"/>
                        &nbsp;
                        <asp:TextBox ID="txtCedula" runat="server" Width="154px" 
                            style="margin-right: 100px; margin-top: 0px" ReadOnly="True" />  
                        <br /><br />
                        <asp:Label ID="lblNombre"  runat="server" Text="Nombre:" Font-Names="Arial" Font-Size="11pt"/>
                        &nbsp;
                        <asp:TextBox ID="txtNombre" runat="server" Width="154px" style="margin-right: 100px; margin-top: 0px" />  
                        <br /><br />
                        <asp:Label ID="lblApellido1"  runat="server" Text="Primer Apellido:" Font-Names="Arial" Font-Size="11pt" />
                        &nbsp;
                        <asp:TextBox ID="txtApellido1" runat="server" Width="154px" style="margin-right: 100px; margin-top: 0px" />  
                        <br /><br />
                        <asp:Label ID="lblApellido2"  runat="server" Text="Segundo Apellido:" Font-Names="Arial" Font-Size="11pt" />
                        &nbsp;
                        <asp:TextBox ID="txtApellido2" runat="server" Width="154px" style="margin-right: 100px; margin-top: 0px" />  
                        <br /><br />
                        <asp:Label ID="lblCorreo"  runat="server" Text="Correo Electrónico:" Font-Names="Arial" Font-Size="11pt" />
                        &nbsp;
                        <asp:TextBox ID="txtCorreo" runat="server" Width="154px" style="margin-right: 100px; margin-top: 0px" />  
                        <br /><br />
                        <asp:Label ID="lblRol"  runat="server" Text="Rol:" Font-Names="Arial" Font-Size="11pt"/>
                        &nbsp;
                        <asp:DropDownList ID="ddlRol" runat="server" Height="24px" Width="154px" style="margin-right: 100px; margin-top: 0px">
                        </asp:DropDownList>
                        <br /><br />
                        <asp:Label ID="lblDepartamento"  runat="server" Text="Departamento:" Font-Names="Arial" Font-Size="11pt"/>
                        &nbsp;
                        <asp:DropDownList ID="ddlDepartamento" runat="server" Height="24px" 
                            Width="154px" style="margin-right: 100px; margin-top: 0px">
                        </asp:DropDownList>
                        <br /><br />
                    </div> 
                    <div id="divBtnModificar" style="text-align:right; width:300px;">
                        <asp:ImageButton ID="btnModificar" runat="server" 
                            ImageUrl="~/Imagenes/btnConfirmarModificacion.png" 
                            ToolTip="Aceptar Modificación" />
                    </div>
            </div> 
            <div style="clear:both;"></div>   
    </div>   
</asp:Content>
