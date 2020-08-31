<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PagPrincipal.aspx.cs" Inherits="WebCar.PagPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;

                     <div class="row">
        <div class="col-md-4">
            <h2>VEHICULO</h2>
       </div>
    </div>
    <div class="row">
        <div class="col-md-1">
            <asp:Label ID="Label1" runat="server" Text="Placa"></asp:Label>

        </div>
        <div class="col-md-1">
            <asp:TextBox ID="TxtPlacaVehiculo" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-1">
            <asp:Label ID="Label2" runat="server" Text="Marca:"></asp:Label>

        </div>
        <div class="col-md-1">
            <asp:TextBox ID="txtMarcaVehiculo" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-1">
            <asp:Label ID="Label3" runat="server" Text="modelo:"></asp:Label>

        </div>
        <div class="col-md-1">
            <asp:TextBox ID="txtModelo" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="row">
        <div class="col-md-1">
            <asp:Label ID="Label4" runat="server" Text="Estado:"></asp:Label>

        </div>
        <div class="col-md-1">
            <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
           
        </div>
    </div>
    <div class="row">
        <div class="col-md-1">
            <asp:Button ID="btnCrear" runat="server" Text="Crear" OnClick="btnCrear_Click" />

        </div>
        <div class="col-md-1">
        </div>
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
        <div class="col-md-1">
        </div>
        <div class="col-md-1">
        </div>
        <div class="col-md-1">
           <asp:GridView ID="gvResult" AutoGenerateColumns ="False" runat="server">
                 <Columns>
                     <asp:BoundField DataField="MATRICULA" />
                     <asp:BoundField DataField="MARCA" />
                     <asp:BoundField DataField="ESTADO" />
                     <asp:BoundField DataField="MODELO" />
                     
                 </Columns>
             </asp:GridView>
        </div>
    </div>
    
    <div class="row">
         <div class="col-md-4">
         </div>
        </div>


                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
