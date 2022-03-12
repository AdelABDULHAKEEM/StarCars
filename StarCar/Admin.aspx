<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="StarCar.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <header style="padding-bottom:30px;">
        <h2>Know Weight Of a Car</h2>
    </header>
<div class="Weight_Cars">
<div class="container">
    <div class="row">
<div class="col-md-4">
<div class="form-group">
     <asp:Label  runat="server" Text="Car Height"></asp:Label>
    <asp:TextBox ID="Height" runat="server" class="form-control"></asp:TextBox>
</div>
    </div>
        <div class="col-md-4">
<div class="form-group">
     <asp:Label  runat="server" Text="Car Width"></asp:Label>
    <asp:TextBox ID="Width" runat="server" class="form-control"></asp:TextBox>
</div>
    </div>

         <div class="col-md-4">
<div class="form-group">
     <asp:Label  runat="server" Text="Car Class"  ></asp:Label>
    <asp:DropDownList runat="server" AutoPostBack="True" class="form-control" DataSourceID="SqlDataSource_StarCars" DataTextField="Model_Car" DataValueField="Model_Car"></asp:DropDownList>
     <asp:SqlDataSource ID="SqlDataSource_StarCars" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Model_Cars]"></asp:SqlDataSource>
</div>
    </div>

</div>
</div>

    </div>
</asp:Content>
