<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="AddNew.aspx.cs" Inherits="BookCar2.Admin.Cars.AddNew" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="auto-style2" colspan="7" ><h2 style="color:darkseagreen" class="auto-style1">ADD CAR</h2></td>
        </tr>
        <tr>
            <td style="width:35px">&nbsp;</td>
            <td colspan="5"><strong>
                <asp:Label ID="lblMess" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="Red"></asp:Label>
                </strong></td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td  ><strong>
                <asp:Label ID="Label2" runat="server" Text="Plate Number"></asp:Label>
                </strong></td>
            <td >
                <asp:TextBox ID="txtPlateNumber" CssClass="textBox" runat="server" Width="110px" Height="23px" BackColor="White"></asp:TextBox>
            </td>
            <td >&nbsp;</td>
            <td ><strong>
                <asp:Label ID="Label4" runat="server" Text="Car Category"></asp:Label>
                </strong></td>
            <td>
                <asp:DropDownList ID="ddlCategory" DataTextField="Name" DataValueField="CarCategoryID" runat="server" BackColor="#99FF66" CssClass="ddlCar" Font-Bold="True" Height="23px" Width="110px">
                </asp:DropDownList>
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
                <asp:TextBox ID="txtPrice" CssClass="textBox" runat="server" Width="110px" Height="23px"></asp:TextBox>
            </td>
            <td >&nbsp;</td>
            <td ><strong>
                <asp:Label ID="Label6" runat="server" Text="Color"></asp:Label>
                </strong></td>
            <td>
                <asp:TextBox ID="txtColor" CssClass="textBox" runat="server" Width="110px" Height="23px"></asp:TextBox>
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
                <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
                </strong></td>
            <td >
                <asp:TextBox ID="txtDes" CssClass="textBox" runat="server" Width="204px" Height="69px" TextMode="MultiLine"></asp:TextBox>
            </td>
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
            <td>&nbsp;</td>
            <td >&nbsp;</td>
            <td >&nbsp;</td>
            <td>&nbsp;</td>
            <td >&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="2">
                <asp:Button ID="btnUS" runat="server" BackColor="#FFFF99" Font-Bold="True" Height="32px"  Text="Add" Width="103px" OnClick="btnUS_Click1" />
            </td>
            <td >&nbsp;</td>
            <td colspan="2" >
                <asp:Button ID="btnBack" runat="server" BackColor="#FFFF99" Font-Bold="True" Height="32px"  Text="Back" Width="103px" PostBackUrl="~/Admin/Cars/Default.aspx" />
            </td>
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
