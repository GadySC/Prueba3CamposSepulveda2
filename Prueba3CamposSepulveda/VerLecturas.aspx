<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="Prueba3CamposSepulveda.VerLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Lecturas</h3>
                </div>

                <div class="card-body">
                    <div class="form-group">
                        <label for ="lecturaDdl"> Filtrar por Medidor: </label>
                        <asp:DropDownList AutoPostBack="true"  runat="" ID="lecturaDdl">
                        </asp:DropDownList>
                    </div>
               
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        EmptyDataText="No hay Medidores" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grillaMedidores">
                       <Columns>
                           <asp:BoundField DataField="Num_Medidor" HeaderText="Numero Medidor" />
                           <asp:BoundField DataField="TipoTxt" HeaderText="Tipo" />
                       </Columns>
                    </asp:GridView>

                </div>
            </div>
        </div>
</asp:Content>
