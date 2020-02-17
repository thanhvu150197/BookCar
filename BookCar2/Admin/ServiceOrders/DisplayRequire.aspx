<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="DisplayRequire.aspx.cs" Inherits="BookCar2.Admin.ServiceOrders.DisplayRequire" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style4 {
        width: 169px;
    }
        .auto-style6 {
            width: 223px;
        }
        .textBox{
            border-radius:4px;
        }
        .ddlCar{
            border-radius:3px;
        }
        .auto-style1 {
            width: 100%;
        }
        .btn-Search{
            border-radius: 11px;
        }
        .auto-style7 {
            width: 118px;
        }
        .auto-style8 {
            width: 209px;
        }
        .auto-style9 {
            width: 111px;
        }
        .auto-style10 {
            width: 223px;
            text-align: right;
        }
        .auto-style11 {
            width: 209px;
            text-align: right;
        }
        .auto-style12 {
            width: 111px;
            text-align: right;
        }
        .auto-style13 {
            text-align: right;
        }
        .auto-style14 {
            text-align: center;
        }
        </style>
    <script>
        function getdatetime(x) {
            var dateselect = new Date();
            dateselect = x.get_selectedDate();
            var timeDisplay = new Date();
            x.get_element().value = dateselect.format("M/d/yyyy") + " " + timeDisplay.format("hh:mm:ss tt");
        }
        <%--$(document).ready(function () {
            $("#<%=btnConfirm.ClientID%>").click(function () {
                alert("Cập nhật thành công");
            });
        });--%>
    </script>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table class="auto-style1">
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style11"><strong>
                <asp:Label ID="Label1" runat="server" Text="OrderID"></asp:Label>
                </strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtOrderID" CssClass="textBox" runat="server" Width="110px" Height="23px" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style10"><strong>
                <asp:Label ID="Label8" runat="server" Text="Customer Name"></asp:Label>
                </strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="txtCusName" CssClass="textCusName" runat="server" Width="110px" Height="23px" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
            </td>
            <td style="width:5%" class="auto-style13">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style11"><strong>
                <asp:Label ID="Label2" runat="server" Text="CarID"></asp:Label>
                </strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtCarID" CssClass="textBox" runat="server" Width="110px" Height="23px" BackColor="#CCCCFF"></asp:TextBox>
            </td>
            <td class="auto-style10"><strong>
                <asp:Label ID="Label3" runat="server" Text="Time"></asp:Label>
                </strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="txtOD" CssClass="textCusName" runat="server" Width="30px" Height="23px" BackColor="#CCCCFF" ReadOnly="True" style="margin-left: 0px"></asp:TextBox>
                <asp:TextBox ID="txtCT" CssClass="textCusName" runat="server" Width="72px" Height="23px" BackColor="#CCCCFF" ReadOnly="True" style="margin-left: 0px"></asp:TextBox>
            </td>
            <td class="auto-style13">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style11"><strong>
                <asp:Label ID="Label4" runat="server" Text="Plan Start"></asp:Label>
                </strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtPSDTG" CssClass="textBox" runat="server" Width="170px" Height="23px" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
                
            </td>
            <td class="auto-style10"><strong>
                <asp:Label ID="Label5" runat="server" Text="Plan End"></asp:Label>
                </strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="txtPEDTG" CssClass="textBox" runat="server" Width="170px" Height="23px" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
                
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style8"><strong>
                <asp:Label ID="Label10" runat="server" Text="Create By"></asp:Label>
                </strong></td>
            <td class="auto-style4">
                <asp:Label ID="lblCrBy" runat="server"></asp:Label>
                </td>
            <td class="auto-style6"><strong>
                <asp:Label ID="Label11" runat="server" Text="Created DTG"></asp:Label>
                </strong></td>
            <td class="auto-style7">
                <asp:Label ID="lblCrByDTG" runat="server"></asp:Label>
                </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style4">
                &nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style8"><strong>
                <asp:Label ID="Label12" runat="server" Text="Status"></asp:Label>
                </strong></td>
            <td class="auto-style4">
                <strong>
                <asp:Label ID="Label13" runat="server" Text="Waiting to confirm.." ForeColor="Red"></asp:Label>
                </strong></td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style14" colspan="5">
                <asp:Button ID="btnCancle" runat="server" BackColor="#CCFFCC" Font-Bold="True" ForeColor="Red" Text="Back" CssClass="btn-Search" Height="38px" Width="107px" OnClick="btnCancle_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
