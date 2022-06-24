<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarLecturas.aspx.cs" Inherits="Prueba3CamposSepulveda.AgregarLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Lecturas</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="medTxt">Numero de medidor: </label>                      
                        <asp:DropDownList ID="medTxt" CssClass="form-control" runat="server" CausesValidation="true">
                        </asp:DropDownList>
                    </div>
                    <br>
                    
                    <div class="form-group">
                        <label for="fecha">Fecha de lectura: </label>
                        <div class="col-md-3">
                            <asp:Calendar ID = "calendario" runat="server">
                            </asp:Calendar>   
                        </div>
                            <br>
                        <div class="float right">
                            <label for="horaLectura">Hora de lectura: (00 - 23)</label>
                            <asp:TextBox ID="horaLectura" CssClass="col-xs-2" runat="server" CausesValidation="true"></asp:TextBox>

                            <label for="minutoLectura">Minuto de lectura: (00 - 59)</label>
                            <asp:TextBox ID="minutoLectura" CssClass="col-xs-2" runat="server" CausesValidation="true"></asp:TextBox>
                        </div>
                            <br>
                        <div class="float right">
                            <label for="valorConsumo">Valor de consumo: </label>
                            <asp:TextBox ID="valorConsumo" CssClass="col-xs-2" runat="server" CausesValidation="true"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarLecturaBtn" Text="Agregar Lectura" CssClass="btn btn-primary" OnClick="agregarLecturaBtn_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
