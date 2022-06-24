<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="Prueba3CamposSepulveda.VerLecturas" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
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
                        <asp:DropDownList AutoPostBack="true" OnSelectedIndexChanged="lecturaDdl_SelectedIndexChanged" runat="server" ID="lecturaDdl">
                        </asp:DropDownList>

                        <asp:Button runat="server" ID="actualizarBtn" Text="Actualizar" CssClass="btn btn-primary" OnClick="actualizarBtn_Click"/>
                    </div>
               
                    <asp:GridView CssClass="table table-hover table-bordered mt-5" 
                        EmptyDataText="No hay Medidores" ShowHeader="true"
                        AutoGenerateColumns="false" runat="server" ID="grillaMedidores">
                       <Columns>
                           <asp:BoundField DataField="Num_Medidor" HeaderText="Numero Medidor" />

                       </Columns>
                    </asp:GridView>
                    <div>
                        <asp:Chart ID="grafico" runat="server">
                            <Series >
                                <asp:Series Name="lecturas" ChartType="Line"></asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="lecturas"></asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>
                    </div>
                        
                </div>
            </div>
        </div>
</asp:Content>

