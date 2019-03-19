<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente.Master" AutoEventWireup="true" CodeBehind="PageCliente.aspx.cs" Inherits="Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
    <tr>
        <td colspan="3"><h3> Clientes </h3></td>
    </tr>
    <tr>
        <td style="height: 30px; width: 82px;">&nbsp;</td>
        <td style="height: 30px">
            <asp:Label ID="Label1" runat="server" Text="Id Cliente"></asp:Label>
        </td>
        <td style="height: 30px">
            <asp:TextBox ID="txtidClientes" runat="server"></asp:TextBox>
                <asp:Button ID="btAgregar" runat="server" Text="Agregar" Height="23px" OnClick="btAgregar_Click" Width="126px" />
        </td>
    </tr>
    <tr>
        <td style="width: 82px">&nbsp;</td>     
        <td>
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                
        </td>
    </tr>
        <tr>
        <td style="width: 82px">&nbsp;</td>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Dirección"></asp:Label>
            </td>
        <td>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
               
            </td>
    </tr>
        <tr>
        <td style="width: 82px">&nbsp;</td>
        <td>
            <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
            </td>
        <td>
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                
            </td>
    </tr>
        <tr>
            <td style="width: 82px">
                <asp:Label ID="lblEstado" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>
                &nbsp;</td>
        
    </tr>
</table>

</asp:Content>
