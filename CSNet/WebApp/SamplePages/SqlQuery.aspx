﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SqlQuery.aspx.cs" Inherits="WebApp.SamplePages.SqlQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>SqlQuery: Secondary queries in BLL</h1>
    <div class="offset-2">
        <asp:Label ID="Label1" runat="server" Text="Select a Category"></asp:Label>&nbsp;&nbsp;
        <asp:DropDownList ID="CategoryList" runat="server"></asp:DropDownList>&nbsp;&nbsp;
        <asp:Button ID="Fetch" runat="server" Text="Button" />
        <br /><br />
        <asp:Label ID="MessageLabel" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="ProductList" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    <ItemTemplate>
                        <%# Eval("ProductID") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" 
                            Text='<%# string.Format("{0:0.00}",Eval("ProductName")) %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                No Data to display
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>
