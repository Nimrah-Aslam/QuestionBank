<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="blanks.aspx.cs" Inherits="blanks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
      <%@ Register Src="~/WebUserControl2.ascx" TagPrefix="uc1" TagName="WebUserControl2" %>


    <!DOCTYPE html>
<html>
    <head>
        <title>
               My page
            </title>
            </head>
    <body>
        <div>
            <center>
            <uc1:WebUserControl2 runat="server" id="WebUserControl2" />
           </center>
        </div>
    </body>
</html>
</asp:Content>