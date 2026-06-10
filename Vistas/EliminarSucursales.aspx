<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursales.aspx.cs" Inherits="Vistas.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 145px;
        }
        .auto-style3 {
            width: 132px;
        }
        .auto-style4 {
            width: 145px;
            height: 23px;
        }
        .auto-style5 {
            width: 132px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            width: 169px;
        }
        .auto-style8 {
            height: 23px;
            width: 169px;
        }
        .auto-style9 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Surucsal</asp:HyperLink>
                    </td>
                    <td class="auto-style5"></td>
                    <td class="auto-style8">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ListarSucursales.aspx">Listado de sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style6">
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/EliminarSucursales.aspx">Eliminar sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Eliminar Sucursal</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Ingresar ID sucursal</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtbEliminar" runat="server" CssClass="auto-style9" Width="195px"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" BackColor="White" BorderColor="White"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
