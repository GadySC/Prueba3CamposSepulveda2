<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="Prueba3CamposSepulveda.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Medidores</h3>
                </div>

                <div class="card-body">
                    <div class="form-group">
                        <label for ="tipoDdl"> Filtrar por Tipo: </label>
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="tipolDdl_SelectedIndexChanged" runat="server" ID="tipoDdl">
                            <asp:ListItem Value="1" Text="Electronico"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Mecanico"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
               
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        OnRowCommand="grillaMedidores_RowCommand"
                        EmptyDataText="No hay Medidores" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grillaMedidores">
                       <Columns>
                           <asp:BoundField DataField="Numero Medidor" HeaderText="Numero Medidor" />
                           <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                       </Columns>
                    </asp:GridView>

                </div>
            </div>
        </div>

</asp:Content>
