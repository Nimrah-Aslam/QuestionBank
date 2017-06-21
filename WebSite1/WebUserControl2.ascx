<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl2.ascx.cs" Inherits="WebUserControl2" %>
<center>
<asp:Button ID="Button1" runat="server" Height="30px" Text="Add Fill In the Blank" Width="147px" OnClick="Button1_Click" BackColor="#336699" />
<br />
<p>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
</p>
    <p>
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
</p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label3" runat="server" Text="Enter Statement"></asp:Label>
    :
<asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="169px"></asp:TextBox>
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label4" runat="server" Text="Enter Answer"></asp:Label>
    :
<asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="179px"></asp:TextBox>

    <br />

<asp:Button ID="Button2" runat="server" style="margin-left: 59px" Text="Submit" OnClick="Button2_Click" BackColor="#336699" Height="28px" Width="258px" />
</center>