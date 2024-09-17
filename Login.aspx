<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="jumbotron" style="background-color: #1E90FF">
        <h1 class="text-center" style="color: #000000; font-size: xx-large;"><strong>Welcome to your personal budget manager</strong></h1>
    </div>

   <!-- <div class="Jumbotron">-->

    <br>
     <div style=" position:relative; top:-20px; left: 0px;">
            <table class="nav-justified">
                <tr>
                    <td style="height: 55px; font-size: x-large; color: #000000;" class="text-center" colspan="2">
                        <strong>&nbsp;LOGIN</strong></td>
                </tr>
                <tr>
                    <td style="height: 35px; width: 50%" class="text-right">
                        <strong>
                        <asp:Label ID="lblUser" runat="server" Text="Username" style="font-size: large; color: #000000;"></asp:Label>
                        </strong></td>
                    <td style="height: 35px" class="text-left">
                        &nbsp;&nbsp;
                        </td>
                </tr>
                <tr>
                    <td style="height: 35px; " class="text-center" colspan="2">
                        <asp:TextBox ID="txtUser" runat="server" style="font-size: medium" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height: 35px; width: 50%" class="text-right">
                        <strong>
                        <asp:Label ID="lblPass" runat="server" Text="Password" style="font-size: large; color: #000000;"></asp:Label>
                        </strong></td>
                    <td style="height: 35px" class="text-left">
                        &nbsp;&nbsp;&nbsp;</td>
                </tr>
                <tr>
                    <td style="height: 35px; " class="text-center" colspan="2">
                        <asp:TextBox ID="txtPass" runat="server" TextMode="Password" style="font-size: medium" Width="170px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="height: 41px;" class="text-center" colspan="2">
                        &nbsp;<asp:Label ID="lblError" runat="server" style="color: #FF0000" Text="The Username or Password you entered is wrong!"></asp:Label>
                    </td>
                    
                </tr>
                <tr>
                    <td style="color: #000000;" class="text-center" colspan="2"><strong>
                        <asp:Button ID="btnLogIn" runat="server" OnClick="btnLogIn_Click" style="font-weight: bold; font-size: medium; margin-left: 0; background-color: #666666;" Text="Log In" Width="80px" href="~/About" Height="30px" />
                        </strong> </td>
                    
                </tr>
            </table>
        </div>
     <br>
<div class="text-center">Don&#39;t have an account yet? <a href="SignIn.aspx">Click me</a></div>


    <br><br>

</asp:Content>
