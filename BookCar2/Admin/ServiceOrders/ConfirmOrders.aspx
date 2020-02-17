<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="ConfirmOrders.aspx.cs" Inherits="BookCar2.Admin.ServiceOrders.ConfirmOrders" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%@ Register Assembly="SMCUI" Namespace="SoftMart.Core.UIControls" TagPrefix="sm" %>

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
        </style>
    <script>
        function getdatetime(x) {
            var dateselect = new Date();
            dateselect = x.get_selectedDate();
            var timeDisplay = new Date();
            x.get_element().value = dateselect.format("M/d/yyyy") + " " + timeDisplay.format("hh:mm:ss tt");
        }
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
            <td colspan="4">
                <asp:Label ID="lblMess" runat="server" ForeColor="Red"></asp:Label>
                </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style11"><strong>
                <asp:Label ID="Label1" runat="server" Text="OrderID"></asp:Label>
                </strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtOrderID" CssClass="textBox" runat="server" Width="110px" Height="23px" BackColor="#99CCFF"></asp:TextBox>
            </td>
            <td class="auto-style10"><strong>
                <asp:Label ID="Label8" runat="server" Text="Customer Name"></asp:Label>
                </strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="txtCusName" CssClass="textCusName" runat="server" Width="110px" Height="23px" BackColor="#99CCFF"></asp:TextBox>
            </td>
            <td style="width:5%">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style11"><strong>
                <asp:Label ID="Label2" runat="server" Text="CarID"></asp:Label>
                </strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtCarID" CssClass="textBox" runat="server" Width="110px" Height="23px" BackColor="#99CCFF"></asp:TextBox>
            </td>
            <td class="auto-style10"><strong>
                <asp:Label ID="Label3" runat="server" Text="Time"></asp:Label>
                </strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="txtOD" CssClass="textCusName" runat="server" Width="30px" Height="23px" BackColor="#99CCFF" style="margin-left: 0px"></asp:TextBox>
                <asp:TextBox ID="txtCT" CssClass="textCusName" runat="server" Width="72px" Height="23px" BackColor="#99CCFF" style="margin-left: 0px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style11"><strong>
                <asp:Label ID="Label4" runat="server" Text="Plan Start"></asp:Label>
                </strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtPSDTG" CssClass="textBox" runat="server" Width="170px" Height="23px" BackColor="#99CCFF" ReadOnly="True"></asp:TextBox>
                
            </td>
            <td class="auto-style10"><strong>
                <asp:Label ID="Label5" runat="server" Text="Plan End"></asp:Label>
                </strong></td>
            <td class="auto-style7">
                <asp:TextBox ID="txtPEDTG" CssClass="textBox" runat="server" Width="170px" Height="23px" BackColor="#99CCFF" ReadOnly="True"></asp:TextBox>
                
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style11"><strong>
                <asp:Label ID="Label6" runat="server" Text="Actual Start"></asp:Label>
                </strong></td>
            <td class="auto-style4">
            <sm:DatePicker ID="dpTimeStart" runat="server" CssClass="selector"  />
            </td>
            <td class="auto-style10"><strong>
                <asp:Label ID="Label7" runat="server" Text="Actual End"></asp:Label>
                </strong></td>
            <td class="auto-style7">
                <sm:DatePicker ID="dpTimeEnd" runat="server" CssClass="selector" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style4">
            <sm:TimePicker ID="tpStar" runat="server"/>
            </td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style7">
            <sm:TimePicker ID="tpEnd" runat="server"/>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style8"><strong>
                <asp:Label ID="Label9" runat="server" Text="Mô tả"></asp:Label>
                </strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtDes" CssClass="textBox" runat="server" Width="170px" Height="69px" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style8"><strong>
                <asp:Label ID="Label10" runat="server" Text="Người tạo"></asp:Label>
                </strong></td>
            <td class="auto-style4">
                <asp:Label ID="lblCrBy" runat="server"></asp:Label>
                </td>
            <td class="auto-style6"><strong>
                <asp:Label ID="Label11" runat="server" Text="Thời gian tạo"></asp:Label>
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
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style4">
                <asp:Button ID="btnConfirm" runat="server" BackColor="#CCFFFF" Font-Bold="True" ForeColor="Red" Text="Confirm" CssClass="btn-Search" Height="38px" Width="107px" OnClick="btnConfirm_Click" />
            </td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style7">
                <asp:Button ID="btnCancle" runat="server" BackColor="#CCFFFF" Font-Bold="True" ForeColor="Red" Text="Back" CssClass="btn-Search" Height="38px" Width="107px" OnClick="btnCancle_Click" />
            </td>
            <td>&nbsp;</td>
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
