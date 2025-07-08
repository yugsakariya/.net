<style type="text/css">
    .auto-style1 {
        width: 63px;
    }
</style>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1.aspx.cs" Inherits="Prac_4._1" %>

<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml"><head runat="server"><title></title></head><body><form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lb1" runat="server" Text="Enter No. 1"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="text1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lb2" runat="server" Text="Enter No. 2"></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:TextBox ID="text2" runat="server"></asp:TextBox>        
                </td>
            </tr>
        </table>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="Add_Click"/>
        <asp:Button ID="btnSub" runat="server" Text="Sub" OnClick="Sub_Click"/>
        <asp:Button ID="btnMulti" runat="server" Text="Multi" OnClick="Multi_Click"/>       
        <asp:Button ID="btnDiv" runat="server" Text="Divide" OnClick="Div_Click"/><br />
        <asp:Label ID="lbResult" runat="server"></asp:Label>
    </form>
</body>
</html>
    