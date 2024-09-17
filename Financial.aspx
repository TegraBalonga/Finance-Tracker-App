<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Financial.aspx.cs" Inherits="PROG_TASK_3.Financial" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
            <div class="jumbotron" style="background-color: #1E90FF">
        <h1 class="text-center" style="color: #000000; font-size: xx-large;"><strong>Finacial Details</strong></h1>
    </div>
    
    <br>

<div>
        <strong>
        <asp:Label ID="Label1" runat="server" style="font-size: large; color: #000000" Text="Gross monthly Income(Before Deductions)(R):"></asp:Label>
        </strong>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtGrossIncome" runat="server"></asp:TextBox>
        </div>

    <br>
         <div>
             <table style="width: 100%; color: #000000;">
                 <tr>
                     <td style="height: 50px; width: 294px; background-color: #666666"><strong>
                         &nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Label ID="Label2" runat="server" Text="Estim. Monthly Tax Deduct.(R)"></asp:Label>
                    </strong> </td>
                     
                     <td class="text-center" style="height: 50px; width: 215px; background-color: #666666">
                         <asp:TextBox ID="txtMonthlyTax" runat="server" style="font-weight: bold"></asp:TextBox>
                     </td>
                    
                     <td class="text-right" style="height: 50px; width: 345px; background-color: #666666"><strong>
                         <asp:Label ID="Label5" runat="server" Text="Water and Lights(R)"></asp:Label>
                         </strong></td>
                     <td class="text-center" style="height: 50px; background-color: #666666">
                         <asp:TextBox ID="txtWaterLight" runat="server" ></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td style="height: 50px; width: 294px; background-color: #666666"><strong>
                         &nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Label ID="Label3" runat="server" Text="Groceries(R)"></asp:Label>
                         </strong></td>
                     <td class="text-center" style="height: 50px; width: 215px; background-color: #666666">
                         <asp:TextBox ID="txtGroceries" runat="server" style="font-weight: bold"></asp:TextBox>
                     </td>
                     <td class="text-right" style="height: 50px; width: 345px; background-color: #666666"><strong>
                         <asp:Label ID="Label6" runat="server" Text="Travel Cost(inc. petrol)(R)"></asp:Label>
                         </strong></td>
                     <td class="text-center" style="height: 50px; background-color: #666666">
                         <asp:TextBox ID="txtTravelCost" runat="server"></asp:TextBox>
                     </td>
                 </tr>
                 <tr>
                     <td style="height: 50px; width: 294px; background-color: #666666"><strong>
                         &nbsp;&nbsp;&nbsp;&nbsp;
                         <asp:Label ID="Label4" runat="server" Text="Other(R)"></asp:Label>
                         </strong></td>
                     <td class="text-center" style="height: 50px; width: 215px; background-color: #666666">
                         <asp:TextBox ID="txtOtherExpenses" runat="server" style="font-weight: bold"></asp:TextBox>
                     </td>
                     <td class="text-right" style="height: 50px; width: 345px; background-color: #666666"><strong>
                         <asp:Label ID="Label7" runat="server" Text="CellPhone and Telephone(R)"></asp:Label>
                         </strong></td>
                     <td class="text-center" style="height: 50px; background-color: #666666">
                         <asp:TextBox ID="txtCellPhone" runat="server"></asp:TextBox>
                         </td>
                 </tr>
             </table>
         </div>
    <br>
    <div>   
        <table style="width:100%;">
            <tr>
                <td style="width: 50%; background-color: #666666; font-size: medium; color: #000000; height: 50px;">
                    <strong>
                    <asp:Label ID="Label8" runat="server" Text="Saving" style="text-decoration: underline; font-size: large"></asp:Label>
                    </strong>
                </td>
                <td style="background-color: #666666; height: 50px;"><strong>
                    <asp:CheckBox ID="chbSave" runat="server"  style="color: #000000" Text="I want to save" AutoPostBack="True" OnCheckedChanged="chbSave_CheckedChanged" />
                    </strong></td>
            </tr>
            <tr>
                <td style="width: 50%; background-color: #666666; font-size: medium; color: #000000; height: 40px;">
                    <strong>
                    <asp:Label ID="Label9" runat="server" Text="Amount to save:"></asp:Label>
                    </strong>
                </td>
                <td style="background-color: #666666; height: 40px;">
                    <asp:TextBox ID="txtSaveAmount" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%; background-color: #666666; font-size: medium; color: #000000; height: 40px;">
                    <strong>
                    <asp:Label ID="Label12" runat="server" Text="Interest Rate:"></asp:Label>
                    </strong>
                </td>
                <td style="background-color: #666666; height: 40px;">
                    <asp:TextBox ID="txtSaveInterest" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%; background-color: #666666; font-size: medium; color: #000000; height: 90px;">
                    <strong>
                    <asp:Label ID="Label10" runat="server" Text="Reason for saving:"></asp:Label>
                    </strong>
                </td>
                <td style="background-color: #666666; height: 90px;">
                    <asp:TextBox ID="txtReason" runat="server" Height="67px" TextMode="MultiLine" Width="251px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%; background-color: #666666; font-size: medium; color: #000000; height: 40px;">
                    <strong>
                    <asp:Label ID="Label11" runat="server" Text="Date limit:"></asp:Label>
                    </strong>
                </td>
                <td style="background-color: #666666; height: 40px;">
                    <asp:Calendar ID="calDate" runat="server" style="color: #000000"></asp:Calendar>
                </td>
            </tr>
        </table>
            </div>
    <br>
            <div class="text-center">
                <strong>
                <asp:Label ID="lblError" runat="server" style="color: #FF0000; font-size: medium" Text="Label"></asp:Label>
                </strong>
            </div>

     <br>
            <div class="text-center">
                <strong>
                <asp:Button ID="btnSave" runat="server" Height="38px" style="font-size: medium; font-weight: bold; background-color: #1E90FF; color: #000000;" Text="Save Info" Width="88px" OnClick="btnSave_Click" />
                </strong>
            </div>
            <br>
           
           
            
</asp:Content>
