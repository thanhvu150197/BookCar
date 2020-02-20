<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="BookCar2.Admin.Cars.Display" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

     
        .textBox{
            border-radius:4px;
        }
        .ddlCar{
            border-radius:3px;
        }
       
        .auto-style2 {
            text-align: center;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="auto-style2" colspan="7" ><h2 style="color:darkseagreen">Car Detail</h2></td>
        </tr>
        <tr>
            <td style="width:35px">&nbsp;</td>
            <td style="width:95px">&nbsp;</td>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
            <td style="width:106px">&nbsp;</td>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td  ><strong>
                <asp:Label ID="Label2" runat="server" Text="Plate Number"></asp:Label>
                </strong></td>
            <td >
                <asp:TextBox ID="txtPlateNumber" CssClass="textBox" runat="server" Width="110px" Height="23px" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
            </td>
            <td >&nbsp;</td>
            <td ><strong>
                <asp:Label ID="Label4" runat="server" Text="Car Category"></asp:Label>
                </strong></td>
            <td>
                <asp:TextBox ID="txtCategoryName" CssClass="textBox" runat="server" Width="110px" Height="23px" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
            </td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td  >&nbsp;</td>
            <td >
                &nbsp;</td>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
            <td>
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td  ><strong>
                <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label>
                </strong></td>
            <td >
                <asp:TextBox ID="txtPrice" CssClass="textBox" runat="server" Width="110px" Height="23px" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
            </td>
            <td >&nbsp;</td>
            <td ><strong>
                <asp:Label ID="Label6" runat="server" Text="Color"></asp:Label>
                </strong></td>
            <td>
                <asp:TextBox ID="txtColor" CssClass="textBox" runat="server" Width="110px" Height="23px" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
            </td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td  >&nbsp;</td>
            <td >
                &nbsp;</td>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
            <td>
                &nbsp;</td>
            <td >
                &nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td  ><strong>
                <asp:Label ID="Label3" runat="server" Text="Mô Tả"></asp:Label>
                </strong></td>
            <td >
                <asp:TextBox ID="txtDes" CssClass="textBox" runat="server" Width="204px" Height="69px" TextMode="MultiLine" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
            </td>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
            <td>&nbsp;</td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td  ><strong>
                <asp:Label ID="lblCreateBy" runat="server" Text="Created By"></asp:Label>
                </strong></td>
            <td ><strong>
                <asp:Label ID="lblCrBy" runat="server" Font-Bold="False" Font-Italic="True"></asp:Label>
                </strong></td>
            <td >&nbsp;</td>
            <td ><strong>
                <asp:Label ID="lblCreateDTG" runat="server" Text="Created DTG"></asp:Label>
                </strong></td>
            <td><strong>
                <asp:Label ID="lblCrDTG" runat="server" Font-Bold="False" Font-Italic="True"></asp:Label>
                </strong></td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td  >&nbsp;</td>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
            <td>&nbsp;</td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td  ><strong>
                <asp:Label ID="lblUpdateBy" runat="server" Text="Update By"></asp:Label>
                </strong></td>
            <td><strong>
                <asp:Label ID="lblUpBy" runat="server" Font-Bold="False" Font-Italic="True"></asp:Label>
                </strong></td>
            <td >&nbsp;</td>
            <td ><strong>
                <asp:Label ID="lblUpdateDTG" runat="server" Text="Update DTG"></asp:Label>
                </strong></td>
            <td><strong>
                <asp:Label ID="lblUpDTG" runat="server" Font-Bold="False" Font-Italic="True"></asp:Label>
                </strong></td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td  >&nbsp;</td>
            <td>&nbsp;</td>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
            <td>&nbsp;</td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="2">
                <asp:Button ID="btnBack" runat="server" BackColor="#FFFF99" Font-Bold="True" Height="32px"  Text="Back" Width="103px" OnClick="btnBack_Click" />
            </td>
            <td >&nbsp;</td>
            <td >
                &nbsp;</td>
            <td>&nbsp;</td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td  >&nbsp;</td>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
            <td>&nbsp;</td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td  >&nbsp;</td>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
            <td>&nbsp;</td>
            <td  style="width:280px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
