<%@ Page Title="Prueba 3" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Prueba3CamposSepulveda.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="numMedTxt">Numero Medidor: </label>
                        <asp:TextBox ID="nombreTxt" CssClass="form-control" runat="server"></asp:TextBox> 
                    </div>

                    <div class="form-group">
                        <label for="tipoRbl">Tipo</label>
                        <asp:RadioButtonList runat="server" ID="tipoRbl">
                            <asp:ListItem Selected="True" Value="1" Text="Electronico"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Mecanico"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>

                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" Text="Agregar Medidor" CssClass="btn btn-primary" OnClick="agregarBtn_Click"/>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
