<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/Default.Master" AutoEventWireup="true" CodeBehind="NhanDatXe.aspx.cs" Inherits="BookCar2.Views.NhanDatXe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
        width: 34px;
    }
    .auto-style4 {
        width: 261px;
    }
    .auto-style5 {
        width: 34px;
        height: 22px;
    }
    .auto-style6 {
        width: 261px;
        height: 22px;
    }
    .auto-style7 {
        height: 22px;
    }
    .textBox {
        border-radius:6px;
    }
</style>
    <script>
        $(document).ready(function () {
            $("#<%=btnConfirm.ClientID%>").click(function () {
                 if ($("#<%=txtName.ClientID%>") == "") {
                    alert("Vui lòng nhập thông tin");
                } else {
                    alert("Yêu cầu được tiếp nhận !");

                }
            });

         });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4" colspan="2">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4" colspan="2">
            <asp:Label ID="lblBookCar" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Text="XÁC NHẬN ĐẶT XE"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4" colspan="2">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td colspan="5">
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="Red" GridLines="None" Width="100%" Font-Bold="True">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" VerticalAlign="Middle" />
                <EmptyDataRowStyle VerticalAlign="Middle" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td class="auto-style5"></td>
        <td class="auto-style6">
            &nbsp;</td>
        <td class="auto-style7" colspan="2">
            &nbsp;</td>
        <td class="auto-style7"></td>
        <td class="auto-style7"></td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style6" colspan="2">
            <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" Text="Thời gian thuê:"></asp:Label>
        </td>
        <td class="auto-style7">
            <asp:Label ID="lblOD" runat="server" Font-Bold="True" Font-Size="Medium"></asp:Label>
        </td>
        <td class="auto-style7">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style6" colspan="2">
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Medium" Text="Tính theo:"></asp:Label>
        </td>
        <td class="auto-style7">
            <asp:DropDownList ID="ddlTime" runat="server"
                DataTextField="Name" DataValueField="TimeCategoryID" Width="120px" CausesValidation="True" AutoPostBack="True" BackColor="#99CCFF" Font-Bold="True" Height="23px" OnSelectedIndexChanged="ddlTime_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td class="auto-style7">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style6" colspan="2">&nbsp;</td>
        <td class="auto-style7">
            <asp:Label ID="lblPS" runat="server" Font-Italic="True" Text="Label"></asp:Label>
&nbsp;<strong>đến</strong>
            <asp:Label ID="lblPE" runat="server" Font-Italic="True" Text="Label"></asp:Label>
        </td>
        <td class="auto-style7">&nbsp;</td>
        <td class="auto-style7">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style5"></td>
        <td class="auto-style6" colspan="2">
            <asp:Label ID="lblInfo" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Text="THÔNG TIN KHÁCH HÀNG"></asp:Label>
        </td>
        <td class="auto-style7"></td>
        <td class="auto-style7"></td>
        <td class="auto-style7"></td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4" colspan="2">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4" colspan="2">
            <asp:Label ID="Label1" runat="server" Text="Họ và Tên"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtName" CssClass="textBox" runat="server" Height="22px" Width="288px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4" colspan="2">
            <asp:Label ID="Label3" runat="server" Text="Ngày Sinh"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtBD" CssClass="textBox" runat="server" Height="22px" Width="288px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4" colspan="2">
            <asp:Label ID="Label2" runat="server" Text="Địa Chỉ"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtAddr" CssClass="textBox" runat="server" Height="22px" Width="288px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4" colspan="2">
            <asp:Label ID="Label4" runat="server" Text="Số Điện Thoại"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPhone" CssClass="textBox" runat="server" Height="22px" Width="288px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4" colspan="2">CMND</td>
        <td>
            <asp:TextBox ID="txtCMND" CssClass="textBox" runat="server" Height="22px" Width="288px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4" colspan="2">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4" colspan="2">
            <asp:Button ID="btnConfirm" runat="server" BackColor="#FFFF66" Font-Bold="True" Font-Size="Medium" Text="Xác Nhận Đặt" Width="137px" Height="38px" OnClick="btnConfirm_Click" />
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4" colspan="2">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
