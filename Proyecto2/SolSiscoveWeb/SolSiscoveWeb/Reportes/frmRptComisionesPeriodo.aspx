<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Master.Master" CodeBehind="frmRptComisionesPeriodo.aspx.vb" Inherits="SolSiscoveWeb.frmRptComisionesPeriodo" 
    title="Reporte Total Comisiones Por Periodo" %>
<%@ Register assembly="EO.Web" namespace="EO.Web" tagprefix="eo" %>
<%@ Register assembly="CrystalDecisions.Web, Version=10.5.3700.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divPrincipal" style=" height:650px; width: 1029px; padding-top:20px;">
        <%-- Data Picker Fecha Inicio--%>
        <div id="divlblRptComisiones">
            <asp:Label ID="lblTotalComisiones" runat="server" Font-Names="Arial" Font-Size="20pt" ForeColor="#000066" Text="Reporte Total Comisiones Por Periodo"></asp:Label>
        </div>
       <table style="width:500px; padding-top:20px; padding-bottom:20px;">
       <tr>
       <td><asp:Label ID="lblFechaInicio" runat="server" Font-Names="Arial" Font-Size="11pt" Text="Fecha Inicio:"></asp:Label></td>
       <td><eo:DatePicker ID="dtpFechaInicio" runat="server" ControlSkinID="None" 
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
                
                <td style="padding-top:2px;"><asp:ImageButton ID="bntReporte" runat="server" 
                ImageUrl="~/Imagenes/btnGenerarReporte.png" ToolTip="Generar Reporte" /></td>
       </tr>
       
       </table>
       
         <%-- Crystal--%>
        <div id="divCrystal" style="height:450px; overflow-x:none; overflow-y:scroll;">
            
            <CR:CrystalReportViewer ID="crv1" runat="server" 
                AutoDataBind="true" DisplayGroupTree="False" ReportSourceID="crs1" Visible="false"/>
                
            <CR:CrystalReportSource ID="crs1" runat="server">
	            <Report FileName="~/Reportes/ReporteTotalComisionesPorPeriodo.rpt">
		            <Parameters>
		                <CR:ControlParameter ControlID="" ConvertEmptyStringToNull="False" 
                            DefaultValue="01/01/2000" Name="fechainicio" PropertyName="" ReportName="" />
			            <CR:ControlParameter ControlID="" ConvertEmptyStringToNull="False" 
                            DefaultValue="01/02/2000" Name="fechafin" PropertyName="" ReportName="" />
		            </Parameters>
	            </Report>
            </CR:CrystalReportSource>
        </div>             
         
    </div>
</asp:Content>
