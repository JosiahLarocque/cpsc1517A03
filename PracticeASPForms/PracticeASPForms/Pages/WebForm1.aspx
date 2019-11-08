<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PracticeASPForms.Pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="page-header">
        <h1>User Registration</h1>
    </div>

    <div class="row col-md-12">
        <div class="alert alert-info">
            <blockquote style="font-style: italic">
                Please fill in the form below and click submit. After submitting the
                form, you will receive an email with a link to confirm your registration.
                By clicking on that link, you will complete the registration process.
            </blockquote>
        </div>
    </div>

    <div class="row">
        <div class="col-md-6">
            <fieldset class="form-horizontal">
                <legend>User Information</legend>
                <asp:Label ID="Label1" runat="server" Text="First Name"
                     AssociatedControlID="FirstName"></asp:Label>
                <asp:TextBox ID="FirstName" runat="server" 
                    ToolTip="Enter your first name." MaxLength="25"></asp:TextBox> 
                 <asp:Label ID="Label6" runat="server" Text="Last Name"
                     AssociatedControlID="LastName"></asp:Label>
                <asp:TextBox ID="LastName" runat="server" 
                    ToolTip="Enter your last name." MaxLength="25"></asp:TextBox>
                <asp:Label ID="Label2" runat="server" Text="User Name"
                    AssociatedControlID="UserName"></asp:Label>
                <asp:TextBox ID="UserName" runat="server"
                    ToolTip="Enter your user name." MaxLength="25" ></asp:TextBox>
                <asp:Label ID="Label3" runat="server" Text="Email Address"
                     AssociatedControlID="EmailAddress"></asp:Label>
                <asp:TextBox ID="EmailAddress" runat="server" 
                    ToolTip="Enter your email address"
                     TextMode="Email"></asp:TextBox> 
                <asp:Label ID="Label4" runat="server" Text="Confirm Email"
                     AssociatedControlID="ConfirmEmail"></asp:Label>
                <asp:TextBox ID="ConfirmEmail" runat="server" 
                    ToolTip="Re-Enter your email address"
                     TextMode="Email"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="Password"
                    AssociatedControlId="Password"></asp:Label>
                <asp:TextBox ID="Password" runat="server"
                     ToolTip="Enter a password"
                      TextMode="Password"></asp:TextBox>
                <asp:Label ID="Label7" runat="server" Text="Password"
                    AssociatedControlId="Password"></asp:Label>
                <asp:TextBox ID="ConfirmPassword" runat="server"
                     ToolTip="Re-enter your password"
                      TextMode="Password"></asp:TextBox>
            </fieldset>

            <br />
            <asp:CheckBox ID="Terms" runat="server" Text="I agree to the terms of this site" />
            
        </div>
    </div>
</asp:Content>
