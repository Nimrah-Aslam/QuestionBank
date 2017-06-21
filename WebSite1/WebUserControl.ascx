<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="WebUserControl" %>
<center><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ADD Question" Width="198px" Height="26px" BackColor="#336699" />
<br />
<asp:TextBox ID="TextBox1" runat="server" Height="26px" Width="143px"></asp:TextBox>
&nbsp;
<asp:Button ID="Button2" runat="server" Height="27px" Text="Add" Width="42px" OnClick="Button2_Click" BackColor="#336699" />
<br />
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
<asp:Button ID="Button3" runat="server" Height="28px" Text="Add Options" Width="173px" OnClick="Button3_Click" Style="margin-left: 17px" BackColor="#336699" />
<br />

<asp:Panel ID="Panel1" runat="server">

    <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound" OnItemCommand="Repeater1_ItemCommand">
        <HeaderTemplate>
            
            <br />
        </HeaderTemplate>
        <ItemTemplate>
            <asp:Label ID="Label2" runat="server" Text='<%#Eval("_option") %>'></asp:Label>
         <%--   <asp:CheckBox ID="CheckBox1" runat="server"   />--%>
            <asp:Label ID="Label3" runat="server" Text='<%#Eval("_chk") %>'></asp:Label>
            <asp:Button ID="Button6" runat="server" Text="Delete"></asp:Button>
            <br />
            <br />
        </ItemTemplate>
        <FooterTemplate>
        </FooterTemplate>
    </asp:Repeater>
</asp:Panel>
<asp:Panel ID="Panel2" runat="server">
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      <asp:TextBox ID="TextBox2" runat="server" Height="19px" Width="167px"></asp:TextBox>
            <asp:CheckBox ID="CheckBox3" runat="server" OnCheckedChanged="CheckBox3_CheckedChanged" />
             <br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button4" runat="server" Text="Add" OnClick="Button4_Click" BackColor="#336699" />
</asp:Panel>

   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

   <asp:Button ID="Button5" runat="server" Text="DONE" OnClick="Button5_Click1" BackColor="#336699" Height="23px" Width="98px" />


    </center>
