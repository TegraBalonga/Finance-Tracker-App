<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PropertyAndCar.aspx.cs" Inherits="PROG_TASK_3.PropertyAndCar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="background-color: #1E90FF">
        <h1 class="text-center" style="color: #000000; font-size: xx-large;"><strong>Property and Car</strong></h1>
    </div>

    <br>
    <div>
        <table style="width: 100%; background-color: #666666;">
            <tr>
                <td class="text-center" style="color: #000000; height: 50px">
                    <strong>
                       <asp:RadioButton ID="rdbAccom" GroupName="prop" runat="server" Text="Rent an accomodation" Style="font-size: medium" AutoPostBack="True" OnCheckedChanged="rdbAccom_CheckedChanged" />
                        
                    </strong></td>
                <td class="text-center" style="color: #000000; height: 50px">
                    <strong>
                        <span style="font-size: medium">
                            <asp:RadioButton ID="rdbProperty" GroupName="prop" runat="server" Text="Buy a Property" AutoPostBack="True" OnCheckedChanged="rdbProperty_CheckedChanged" />
                        </span></strong>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 50%; height: 35px; text-align: right; color: #000000; background-color: #FFFFFF;"><strong>
                    <asp:Label ID="lblRentOrPrice" runat="server" Text="Purchase Price(R)"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; </strong></td>
                <td style="height: 35px; background-color: #FFFFFF;">
                    <asp:TextBox ID="txtRentOrPrice" runat="server" Style="font-size: medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 50%; height: 31px; text-align: right; color: #000000; background-color: #FFFFFF;"><strong>
                    <asp:Label ID="lblDepo" runat="server" Text="Total Deposit(R)"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
                <td style="height: 31px; background-color: #FFFFFF;">
                    <asp:TextBox ID="txtDepo" runat="server" Style="font-size: medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 50%; height: 35px; text-align: right; color: #000000; background-color: #FFFFFF;"><strong>
                    <asp:Label ID="lblInterest" runat="server" Text="InterestRate(%)"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
                <td style="height: 35px; background-color: #FFFFFF;">
                    <asp:TextBox ID="txtInterest" runat="server" Style="font-size: medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 50%; height: 35px; text-align: right; color: #000000; background-color: #FFFFFF;"><strong>
                    <asp:Label ID="lblNoMonths" runat="server" Text="No of Repay Months"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp; </strong></td>
                <td style="height: 35px; background-color: #FFFFFF;">
                    <asp:TextBox ID="txtNoMonths" runat="server" Style="font-size: medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="height: 35px; text-align: right; color: #000000; background-color: #FFFFFF;" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="modal-sm" style="width: 50%; height: 46px; text-align: right; color: #000000; background-color: #FFFFFF;"></td>
                <td style="height: 46px; background-color: #FFFFFF;"></td>
            </tr>
            <tr>
                <td class="modal-sm" style="height: 50px; text-align: center; color: #000000;"><strong>
                    <asp:RadioButton ID="rdbCar" GroupName="car" runat="server" Style="font-size: medium" Text="Buy a car" AutoPostBack="True" OnCheckedChanged="rdbCar_CheckedChanged" />
                </strong></td>
                <td class="modal-sm" style="height: 50px; text-align: center; color: #000000;"><strong>
                    <asp:RadioButton ID="rdbCancel" GroupName="car" runat="server" AutoPostBack="True" OnCheckedChanged="rdbCancel_CheckedChanged" Style="font-size: medium" Text="Cancel" />
                </strong></td>
            </tr>
            <tr>
                <td class="modal-sm" style="height: 35px; text-align: right; color: #000000; background-color: #FFFFFF;"><strong>
                    <asp:Label ID="lblModel" runat="server" Text="Model and Make"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
                <td class="modal-sm" style="height: 35px; text-align: left; color: #000000; background-color: #FFFFFF;">
                    <asp:TextBox ID="txtModel" runat="server" Style="font-size: medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="height: 35px; text-align: right; color: #000000; background-color: #FFFFFF;"><strong>
                    <asp:Label ID="lblCarPrice" runat="server" Text="Purchase Price(R)"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
                <td class="modal-sm" style="height: 35px; text-align: left; color: #000000; background-color: #FFFFFF;">
                    <asp:TextBox ID="txtCarPrice" runat="server" Style="font-size: medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="height: 35px; text-align: right; color: #000000; background-color: #FFFFFF;"><strong>
                    <asp:Label ID="lblCarDepo" runat="server" Text="Total Deposit(R)"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
                <td class="modal-sm" style="height: 35px; text-align: left; color: #000000; background-color: #FFFFFF;">
                    <asp:TextBox ID="txtCarDepo" runat="server" Style="font-size: medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="height: 35px; text-align: right; color: #000000; background-color: #FFFFFF;"><strong>
                    <asp:Label ID="lblCarInterest" runat="server" Text="Interest Rate(%)"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
                <td class="modal-sm" style="height: 35px; text-align: left; color: #000000; background-color: #FFFFFF;">
                    <asp:TextBox ID="txtCarInterest" runat="server" Style="font-size: medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="height: 35px; text-align: right; color: #000000; background-color: #FFFFFF;"><strong>
                    <asp:Label ID="lblInsur" runat="server" Text="Estim. Insurance Premium"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp; </strong></td>
                <td class="modal-sm" style="height: 35px; text-align: left; color: #000000; background-color: #FFFFFF;">
                    <asp:TextBox ID="txtInsurance" runat="server" Style="font-size: medium"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="modal-sm" style="height: 35px; text-align: right; color: #000000; background-color: #FFFFFF;">&nbsp;</td>
                <td class="modal-sm" style="height: 35px; text-align: left; color: #000000; background-color: #FFFFFF;">&nbsp;</td>
            </tr>
        </table>
    </div>

    <br>

    <div class="text-center">
        <strong>
            <asp:Label ID="lblError" runat="server" Style="font-size: large; color: #FF0000" Text="Label"></asp:Label>
        </strong>
    </div>

    <br>

    <br>
    <div class="text-center">
        <strong>
            <asp:Button ID="btnSave" runat="server" Height="30px" Style="font-size: medium; font-weight: bold; color: #000000; background-color: #1E90FF;" Text="Save Info" Width="80px" OnClick="btnSave_Click" />
        </strong>
    </div>
    <br>
</asp:Content>
