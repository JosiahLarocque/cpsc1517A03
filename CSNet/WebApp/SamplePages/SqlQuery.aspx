<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SqlQuery.aspx.cs" Inherits="WebApp.SamplePages.SqlQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>SqlQuery: Secondary queries in BLL</h1>
    <div class="offset-2">
        <asp:Label ID="Label1" runat="server" Text="Select a Category:"></asp:Label>&nbsp;&nbsp;
        <asp:DropDownList ID="CategoryList" runat="server"></asp:DropDownList>&nbsp;&nbsp;
        <asp:Button ID="Fetch" runat="server" Text="Fetch" OnClick="Fetch_Click" />
        <br /><br />
        <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
        <br />
        <asp:GridView ID="ProductList" runat="server" AutoGenerateColumns="False"
            CssClass="table table-striped" GridLines="Horizontal" 
            BorderStyle="None" AllowPaging="True" PageSize="5" OnPageIndexChanging="ProductList_PageIndexChanging">
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" 
                            Text='<%# Eval("ProductID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemStyle HorizontalAlign="Left"> </ItemStyle>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" 
                            Text='<%# Eval("ProductName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Qty/Per">
                    <ItemStyle HorizontalAlign="left"> </ItemStyle>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" 
                            text='<%# Eval("QuantityPerUnit") == null ? "each" : Eval("QuantityPerUnit") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="$">
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" 
                            Text='<%# Eval("Price") %>'></asp:Label>
                <asp:TemplateField HeaderText="Disc">
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" 
                            Text='<%# Eval("Discontinued") %>'></asp:Label>
                       
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                No data to display
            </EmptyDataTemplate>
            <PagerSettings FirstPageText="Start" LastPageText="End" Mode="NumericFirstLast" PageButtonCount="3" />
        </asp:GridView>
    </div>
</asp:Content>
