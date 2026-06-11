<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListarSucursales.aspx.cs" Inherits="Vistas.ListarSucursales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td class="colBordes">&nbsp;</td>
            <td class="colEtiquetas"></td>
            <td class="colCampos">
                <h2>Listado De Sucursales</h2>
            </td>
            <td class="colValidacion">&nbsp;</td>
            <td class="colBordes">&nbsp;</td>
        </tr>
        <tr>
            <td class="colBordes">&nbsp;</td>
            <td class="colEtiquetas"></td>
          <!--  <td class="colCampos">Nombre: &nbsp;&nbsp;
                <asp:TextBox ID="txtNombre" runat="server" Width="215px" ToolTip="por comienzo de nombre"></asp:TextBox>
            </td>
            -->
            <td class="colValidacion">&nbsp;</td>
            <td class="colBordes">&nbsp;</td>
        </tr>
        <tr>
            <td class="colBordes">&nbsp;</td>
            <td class="colEtiquetas"></td>

            <td class="colCampos">Ingrese Id: 
                <asp:TextBox ID="txtBusqueda" runat="server" Width="215px"></asp:TextBox>
            </td>
            <td class="colBordes"></td>
        </tr>
        <tr>
            <td class="colBordes">&nbsp;</td>
            <td class="colEtiquetas"></td>
            <td class="colCampos">
                <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
                <asp:Button ID="btnMostrarTodos" runat="server" Text="Mostrar todos" OnClick="btnMostrarTodos_Click" /></td>
            <td class="colValidacion">&nbsp;</td>
            <td class="colBordes">&nbsp;</td>
        </tr>
        <tr>
            <td class="colBordes">&nbsp;</td>
            <td class="colEtiquetas">&nbsp;</td>
            <td class="colCampos">
                <!--
                <asp:Label ID="lblError" runat="server" Text="No existe la sucursal" Visible="False" />
                &nbsp; 
                <asp:CompareValidator ID="cvFiltrar" runat="server" ControlToValidate="txtBusqueda" ErrorMessage="Debe ingresar un número mayor a 0" Operator="GreaterThan" Type="Integer" ValueToCompare="0">*</asp:CompareValidator>
                <asp:ValidationSummary ID="vsErrores" runat="server" ShowMessageBox="true" ShowSummary="true" />
                -->
            </td>
            <td class="colValidacion">&nbsp; </td>
            <td class="colBordes">&nbsp;</td>
        </tr>
        <tr>
            <td class="colBordes">&nbsp;</td>
            <td class="colEtiquetas">&nbsp;</td>
            <td class="colCampos">&nbsp; </td>
            <td class="colValidacion">&nbsp; </td>
            <td class="colBordes">&nbsp;</td>
        </tr>
        <tr>
            <td class="colBordes">&nbsp;</td>
            <td class="colEtiquetas">&nbsp;</td>
            <td class="colCampos">
                <asp:Label ID="lblCantResultados" runat="server" Text="Resultados:" BorderColor="#003366" Font-Bold="True" ForeColor="#006666"></asp:Label>
            </td>
            <td class="colValidacion">&nbsp; </td>
            <td class="colBordes">&nbsp;</td>
        </tr>
        <tr>
            <td class="colBordes">&nbsp;</td>
            <td class="colEtiquetas">&nbsp;</td>
            <td class="colCampos">
                <asp:GridView ID="gvSucursales" runat="server"></asp:GridView>
            </td>
            <td class="colValidacion">&nbsp;</td>
            <td class="colBordes">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
