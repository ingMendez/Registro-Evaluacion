<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rCategorias.aspx.cs" Inherits="RegistroEvaluaciones.UI.Registros.rCategorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    </br>
    <div class="form-row justify-content-center">
        <aside class="col-sm-6">
            <div class="card text-white bg-dark mb-3">
                <div class="card-header text-uppercase text-center">Categoria</div>
                <article class="card-body">
                    <form>
                        <div class="form-row ">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <div class="form-group col-md-0">
                                <asp:Label ID="Label6" runat="server" Text="Fecha"></asp:Label>
                            </div>
                            <div class="col-lg-1 p-0">
                                <asp:TextBox class="form-control" ID="FechaTextBox" type="date" Width="190px" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4 col-md-offset-1">
                            <div class="container">
                               <div class="form-group">                                 
                                    <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label>
                                    <asp:Button class="btn btn-info btn-sm" ID="BuscarButton" runat="server" Text="Buscar" OnClick="BuscarButton_Click"/>
                                    <asp:TextBox class="form-control" ID="CategoriaId" type="number" Text="0" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-7 col-md-offset-5">
                            <div class="container">
                                <div class="form-group"> 
                                    <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                                    <asp:TextBox class="form-control" ID="NombreTextBox" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>               
                        <div class="panel-footer">
                            <div class="text-center">
                                <div class="form-group" style="display: inline-block">
                                    <asp:Button class="btn btn-primary" ID="nuevoButton" runat="server" Text="Nuevo" OnClick="nuevoButton_Click"  />
                                    <asp:Button class="btn btn-success" ID="guardarButton" runat="server" Text="Guardar" OnClick="guadarButton_Click" />
                                    <asp:Button class="btn btn-danger" ID="eliminarButton" runat="server" Text="Eliminar" OnClick="eliminarButton_Click"  />
                                </div>
                            </div>
                        </div>
                    </form>
                </article>
                </div>
                </aside>
            </div>
   
</asp:Content>
