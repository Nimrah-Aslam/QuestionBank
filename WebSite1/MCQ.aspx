<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MCQ.aspx.cs" Inherits="MCQ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
     
 <%@ Register Src="~/WebUserControl.ascx" TagPrefix="uc1" TagName="WebUserControl" %>
    

    <!DOCTYPE html>
<html>
    <head>
        <title>
               My page
            </title>
            </head>
    <body>
        <div>
           <uc1:WebUserControl runat="server" ID="WebUserControl" />
           
        </div>
    </body>
</html>
</asp:Content>