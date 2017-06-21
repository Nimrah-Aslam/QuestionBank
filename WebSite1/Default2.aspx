<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <!DOCTYPE html>
<html>
    <head>
        <title>
               My page
            </title>
            </head>
    <body>
        <center>
        <div>
            <br />
            <br />
           <p><b>what you want to do?</b>
               <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                   <asp:ListItem Value="1">
                       MCQ
                   </asp:ListItem>
                   <asp:ListItem Value="2">
                       Fill in the blank
                   </asp:ListItem>
               </asp:RadioButtonList>
               <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click2" BackColor="#336699" BorderColor="#000066" /></p>
        </div>
            </center>
    </body>
</html>
</asp:Content>