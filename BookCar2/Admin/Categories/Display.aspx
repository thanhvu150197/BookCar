<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="BookCar2.Admin.Categories.Display" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 117px;
        }
        .textBox{
            border-radius:4px;
        }
        .auto-style3 {
            border-radius: 4px;
            margin-right: 0px;
        }
        .auto-style4 {
            width: 228px;
        }
        .auto-style5 {
            width: 176px;
        }
        .auto-style6 {
            width: 172px;
        }

    </style>
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4" colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="4">
                <asp:Label ID="Label7" runat="server" Font-Size="X-Large" ForeColor="Red" Text="CHI TIẾT DANH MỤC XE"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4" colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2"><strong>
                <asp:Label ID="Label1" runat="server" Text="Tên Hãng Xe"></asp:Label>
                </strong></td>
            <td class="auto-style4" colspan="2">
                <asp:TextBox ID="txtName" CssClass="textBox" runat="server" Width="218px" Height="23px" ReadOnly="True" BackColor="#99CCFF"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4" colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2"><strong>
                <asp:Label ID="Label2" runat="server" Text="Mô Tả"></asp:Label>
                </strong></td>
            <td class="auto-style4" colspan="2">
                <asp:TextBox ID="txtDes" CssClass="auto-style3" runat="server" Height="52px" TextMode="MultiLine" Width="218px" ReadOnly="True" BackColor="#99CCFF"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4" colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2"><strong>
                <asp:Label ID="Label3" runat="server" Text="Người tạo:"></asp:Label>
                </strong></td>
            <td class="auto-style5">
                <asp:Label ID="lblCreatedBy" runat="server"></asp:Label>
            </td>
            <td class="auto-style6"><strong>
                <asp:Label ID="Label4" runat="server" Text="Thời gian tạo:"></asp:Label>
                </strong></td>
            <td>
                <asp:Label ID="lblCreatedDTG" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4" colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2"><strong>
                <asp:Label ID="Label5" runat="server" Text="Người cập nhật :"></asp:Label>
                </strong></td>
            <td class="auto-style5">
                <asp:Label ID="lblUpdatedBy" runat="server"></asp:Label>
            </td>
            <td class="auto-style6"><strong>
                <asp:Label ID="Label6" runat="server" Text="Thời gian cập nhật:"></asp:Label>
                </strong></td>
            <td>
                <asp:Label ID="lblUpdatedDTG" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4" colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td colspan="3">
&nbsp;
                <asp:Button ID="btnUpdate0" runat="server" BackColor="#FFFF99" Font-Bold="True" Height="32px" PostBackUrl="~/Admin/Categories/Default.aspx" Text="Quay lại" Width="105px" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4" colspan="2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
