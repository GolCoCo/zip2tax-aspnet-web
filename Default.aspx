<%@ Page Title="Zip2Tax" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Zip2TaxWebApp._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main style="background-color: #d8d8e5;">
        <div class="row zx-title-div">Account Note - Keyword Counts</div>
        <div class="row zx-date-range-row-div">
            <div class="zx-date-range-picker-div" style="margin-left:20px">Date Range:</div>
            <diV class="zx-date-range-picker-div">From:</diV>
            <asp:TextBox CssClass ="zx-date-range-picker" ID ="tbxFromDate" runat="server" TextMode="Date" AutoPostBack="true" OnTextChanged="tbxFromDate_TextChanged"></asp:TextBox>
            <diV class="zx-date-range-picker-div">To:</diV>
            <asp:TextBox CssClass ="zx-date-range-picker" ID ="tbxToDate" runat="server" TextMode="Date" AutoPostBack="true" OnTextChanged="tbxToDate_TextChanged"></asp:TextBox>
        </div >

        <div class="row">
            <asp:GridView ID="GridView1" runat="server" Width="100%">
            </asp:GridView>
        </div>
    </main>
</asp:Content>
