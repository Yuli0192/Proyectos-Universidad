<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="iniciarSesion.aspx.vb" Inherits="SolSiscoveWeb.iniciarSesion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Iniciar Sessi&oacute;n</title>
    <style type="text/css">
    
#login-box {
	width:333px;
	height: 352px;
	padding: 58px 76px 0 76px;
	color: #ebebeb;
	font: 12px Arial, Helvetica, sans-serif;
	background: url(/Imagenes/login-box-backg.png) no-repeat left top;
}

#login-box img {
	border:none;
}

#login-box h2 {
	padding:0;
	margin:0;
	color: #ebebeb;
	font: bold 32px "Calibri", Arial;
}


#login-box-name {
	float: left;
	display:inline;
	width:80px;
	text-align: right;
	padding: 14px 10px 0 0;
	margin:0 0 7px 0;
}

#login-box-field {
	float: left;
	display:inline;
	width:230px;
	margin:0;
	margin:0 0 7px 0;
}


.form-login  {
	width: 205px;
	padding: 10px 4px 6px 3px;
	border: 1px solid #0d2c52;
	background-color:#1e4f8a;
	font-size: 16px;
	color: #ebebeb;
}


.login-box-options  {
	clear:both;
	padding-left:87px;
	font-size: 11px;
}

.login-box-options a {
	color: #ebebeb;
	font-size: 11px;
}
    
    </style>

</head>
<body style="background-image:url(/Imagenes/bg.jpg);">

 <form id="form1" runat="server">
     
     <div style="margin-left:auto; margin-right:auto; width:500px; padding-top:80px;">
            
<div id="login-box">

<h2>Sistemas Educativos S.A.</h2>
<br />
<br />
<table style="width:320px; text-align:right; padding-top:20px;">
<tr>
<td>Correo Electr&oacute;nico:</td>
<td><asp:TextBox ID="txtCorreo" runat="server" style="margin-left: 0px" 
                                Width="190px"></asp:TextBox></td>
</tr>
<tr>
<td>Contrase&ntilde;a:</td>
<td><asp:TextBox ID="txtContrasenna" runat="server" TextMode="Password" 
                                Width="190px"></asp:TextBox></td>
</tr>
<tr>
<td></td><td></td>
</tr>
<tr>
<td></td>
<td><asp:ImageButton ID="btnmodificar2" runat="server" 
                            ImageUrl="~/imagenes/login-btn.png" ToolTip="Ingresar" /></td>
</tr>
</table>


</div>




</div>

  </form>
   
</body>
</html>
