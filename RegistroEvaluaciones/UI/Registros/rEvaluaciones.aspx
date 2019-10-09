﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rEvaluaciones.aspx.cs" Inherits="RegistroEvaluaciones.UI.Registros.rEvaluaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
    <div class="form-row justify-content-center">
        <aside class="col-sm-8">
            <div class="card text-white bg-dark mb-3">
                <div class="card-header text-uppercase text-center">Evaluacion</div>
                <article class="card-body">
                    <form>
                        <div class="form-row">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <div class="form-group col-md-1">
                                <asp:Label ID="Label6" runat="server" Text="Fecha"></asp:Label>
                            </div>
                            <div class="col-lg-1 p-0">
                                <asp:TextBox class="form-control" ID="FechaTextBox" type="date" Width="190px" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-row">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <div class="form-group col-md-2">
                                <asp:Label ID="Label4" runat="server" Text="Id"></asp:Label>
                                <asp:TextBox class="form-control" ID="IdTextBox" type="number" Text="0" runat="server" Width="100px"></asp:TextBox>
                            </div>
                            <div class="col-lg-1 p-0">
                                <asp:LinkButton ID="BuscarLinkButton" CssClass="btn btn-info mt-4" runat="server">
                                <span class="fas fa-search"></span>Buscar
                                </asp:LinkButton>
                            </div>
                        </div>
                        <div class="col-md-6 col-md-offset-4">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label7" runat="server" Text="Estudiante"></asp:Label>
                                    <asp:DropDownList ID="EstudianteDropDownList" class="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6 col-md-offset-3">
                            <div class="container">
                                <div class="form-group">
                                    <asp:Label ID="Label1" runat="server" Text="Categoria"></asp:Label>
                                    <asp:DropDownList ID="CategoriaDropDownList" class="form-control" runat="server"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="form-row">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <div class="form-group col-md-2">
                                <asp:Label ID="Label8" runat="server" Text="Valor"></asp:Label>
                                <asp:TextBox class="form-control" ID="ValorTextBox" type="number" runat="server" Width="140px"></asp:TextBox>

                            </div>
                            <div class="form-group col-md-2">
                                <asp:Label ID="Label9" runat="server" Text="Logrado"></asp:Label>
                                <asp:TextBox class="form-control" ID="LogradoTextBox" type="number" runat="server" Width="140px" AutoPostBack="True"></asp:TextBox>
                            </div>
                            <div class="form-group col-md-2">
                                <asp:Label ID="Label11" runat="server" Text="Perdido"></asp:Label>
                                <asp:TextBox class="form-control" ID="PerdidoTextBox" runat="server" Width="140px" ReadOnly="True"></asp:TextBox>
                            </div>
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <div class="col-lg-1 p-0">
                                <asp:LinkButton ID="agregarLinkButton" CssClass="btn btn-warning mt-4" runat="server">
                                <span class="fas fa-search"></span>Agregar
                                </asp:LinkButton>
                            </div>
                            &nbsp;&nbsp;
                        </div>

                        <hr>
                        <div class="form-row">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <div class="form-group col-md-2">
                                <asp:Label ID="Label3" runat="server" Text="Total Logrados"></asp:Label>
                                <asp:TextBox class="form-control" ID="TotalLogradosTextBox" Text="0" runat="server" Width="150px" ReadOnly="True" BackColor="#3399FF"></asp:TextBox>
                            </div>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <div class="form-group col-md-2">
                                <asp:Label ID="Label10" runat="server" Text="Total Perdidos"></asp:Label>
                                <asp:TextBox class="form-control" ID="TotalPerdidosTextBox" runat="server" Width="150px" BackColor="#3399FF" ReadOnly="True"></asp:TextBox>
                            </div>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <div class="form-group col-md-2">
                                <asp:Label ID="Label5" runat="server" Text="Estado"></asp:Label>
                                <asp:TextBox class="form-control" ID="EstadoTextBox" runat="server" Width="150px" BackColor="#3399FF" ReadOnly="True"></asp:TextBox>
                            </div>
                        </div>
                        <div class="panel-footer">
                            <div class="text-center">
                                <div class="form-group" style="display: inline-block">
                                    <asp:Button Text="Nuevo" class="btn btn-primary btn-sm" runat="server" ID="nuevoButton" />
                                    <asp:Button Text="Guardar" class="btn btn-success btn-sm" runat="server" ID="guadarButton" />
                                    <asp:Button Text="Eliminar" class="btn btn-danger btn-sm" runat="server" ID="eliminarButton" />
                                </div>
                            </div>
                        </div>
                    </form>
                </article>
            </div>
    </div>

</asp:Content>
