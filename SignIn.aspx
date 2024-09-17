<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="SignIn" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="background-color: #1E90FF">
        <h1 class="text-center" style="color: #000000; font-size: 30px;"><strong>Enter your information to register</strong></h1>
       
    </div>


    <div>
    <table style="width:100%;">
        <tr>
            <td class="text-center" colspan="2" style="font-size: x-large; color: #000000; height: 55px;"><strong>Sign In</strong></td>
        </tr>
        <tr>
            <td class="text-right" style="width: 51%; font-size: large; color: #000000; height: 35px"><strong>Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
            <td style="height: 35px">&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
        <tr>
            <td class="text-center" style="font-size: large; color: #000000; height: 35px" colspan="2">
                <asp:TextBox ID="txtName" runat="server" Width="170px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 51%; font-size: large; color: #000000; height: 35px"><strong>Surname&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
            <td style="height: 35px">&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
        <tr>
            <td class="text-center" style="font-size: large; color: #000000; height: 35px" colspan="2">
                <asp:TextBox ID="txtSurname" runat="server" Width="170px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 51%; font-size: large; color: #000000; height: 35px"><strong>Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
            <td style="height: 35px">&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
        <tr>
            <td class="text-center" style="font-size: large; color: #000000; height: 35px" colspan="2">
                <asp:TextBox ID="txtEmail" runat="server" Width="170px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 51%; font-size: large; color: #000000; height: 35px"><strong>Username&nbsp;&nbsp; </strong></td>
            <td style="height: 35px">&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
        <tr>
            <td class="text-center" style="font-size: large; color: #000000; height: 35px" colspan="2">
                <asp:TextBox ID="txtUser" runat="server" Width="170px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-right" style="width: 51%; font-size: large; color: #000000; height: 35px"><strong>Password&nbsp;&nbsp; </strong></td>
            <td style="height: 35px">&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
        <tr>
            <td class="text-center" style="font-size: large; color: #000000; height: 35px" colspan="2">
                <asp:TextBox ID="txtPass" runat="server" Width="170px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" colspan="2" style="font-size: large; color: #000000; height: 42px">
                <asp:Label ID="lblError" runat="server" style="color: #FF0000" Text="This user already exist!"></asp:Label>
            </td>
        </tr>
        <tr style="color: #000000">
            <td class="text-center" colspan="2" style="height: 46px"><strong>
                <asp:Button ID="btnSignIn" runat="server" Height="30px" OnClick="btnSignIn_Click" style="font-weight: bold; font-size: medium; background-color: #666666;" Text="Sign In" Width="80px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" Height="30px" OnClick="btnCancel_Click" style="font-weight: bold; font-size: medium; background-color: #666666" Text="Cancel" Width="80px" />
                </strong></td>
        </tr>
    </table>
    </div>
    
    <br><br>
</asp:Content>
