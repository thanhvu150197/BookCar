<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="AddNew.aspx.cs" Inherits="BookCar2.Admin.Categories.AddNew" %>
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

        .auto-style7 {
            height: 55px;
        }
        .auto-style8 {
            height: 46px;
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
            <td class="auto-style7"></td>
            <td colspan="4" class="auto-style7">
                <asp:Label ID="Label7" runat="server" Font-Size="X-Large" ForeColor="Red" Text="THÊM DANH MỤC XE"></asp:Label>
            </td>
            <td class="auto-style7"></td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style8" colspan="3">
                <asp:Label ID="lblMess" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
            </td>
            <td class="auto-style8"></td>
            <td class="auto-style8"></td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2"><strong>
                <asp:Label ID="Label1" runat="server" Text="Tên Hãng Xe"></asp:Label>
                </strong></td>
            <td class="auto-style4" colspan="2">
                <asp:TextBox ID="txtName" CssClass="textBox" runat="server" Width="218px" Height="23px"></asp:TextBox>
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
                <asp:TextBox ID="txtDes" CssClass="auto-style3" runat="server" Height="52px" TextMode="MultiLine" Width="218px"></asp:TextBox>
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
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td>
                &nbsp;</td>
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
                <asp:Button ID="btnInsert" runat="server" BackColor="#FFFF99" Font-Bold="True" Height="32px" OnClick="btnInsert_Click" Text="Thêm" Width="103px" />
&nbsp;
                </td>
            <td>
                <asp:Button ID="btnUpdate0" runat="server" BackColor="#FFFF99" Font-Bold="True" Height="32px" PostBackUrl="~/Admin/Categories/Default.aspx" Text="Quay lại" Width="105px" />
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
    </table>
</asp:Content>
