<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente.Master" AutoEventWireup="true" CodeBehind="PageCliente.aspx.cs" Inherits="Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
    <tr>
        <td colspan="3"><h3> Clientes </h3></td>
    </tr>
    <tr>
        <td style="width: 188px;">  
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </td>
        <td style="width: 261px;">
            <asp:Label ID="Label1" runat="server" Text="Id Cliente"></asp:Label>
        </td>
        <td style="width: 301px;">
            <asp:TextBox ID="txtidClientes" runat="server"></asp:TextBox>
               
        </td>
        <td>
            <asp:Button ID="btAgregar" runat="server" Text="Agregar" Height="23px" OnClick="btAgregar_Click" Width="126px" />
        </td>
    </tr>
    <tr>
        <td style="width: 188px">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Consultar Tabla" Width="116px" />
        </td>     
        <td style="width: 261px">
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
        </td>
        <td style="width: 301px">
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
               
     </td>
     
        <td>
            <asp:Button ID="btModificar" runat="server" OnClick="Button1_Click" Text="Modificar" Width="126px" /> 
        </td>
    </tr>
        <tr>
        <td style="width: 188px">&nbsp;</td>
        <td style="width: 261px">
            <asp:Label ID="Label3" runat="server" Text="Dirección"></asp:Label>
            </td>
        <td style="width: 301px">
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
               
            </td>
            <td>
                <asp:Button ID="btEliminar" runat="server" OnClick="Button1_Click1" Text="Eliminar" Width="126px" />
            </td>

    </tr>
        <tr>
        <td style="width: 188px">&nbsp;</td>
        <td style="width: 261px">
            <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
            </td>
        <td style="width: 301px">
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
               
            </td>
            <td>

                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click2" Text="Consultar" />

            </td>
    </tr>
        <tr>
            <td style="width: 188px">
                <asp:Label ID="lblEstado" runat="server"></asp:Label>
            </td>
            <td style="width: 261px">&nbsp;</td>
            <td style="width: 301px">
                &nbsp;</td>
            <td>

            </td>
        
    </tr>
</table>

</asp:Content>