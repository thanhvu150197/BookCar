<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BookCar2.Views.BookCar.BookCar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style3 {
            width: 23px;
        }
    .auto-style4 {
        width: 261px;
    }
    .auto-style5 {
            width: 23px;
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
            <asp:DataGrid runat="server" ID="grdData" CellPadding="4" ForeColor="#333333" GridLines="None" Width="96%" OnItemDataBound="grdData_ItemDataBound" FirstPageText="<<" LastPageText=">>" OnPageIndexChanged="grdData_PageIndexChanged" PageSize="5" AutoGenerateColumns="False" DataKeyField="CarID" OnItemCommand="grdData_ItemCommand">
            <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateColumn  HeaderText="CarID">
                    <ItemTemplate>
                        <asp:Literal ID="ltrCarID" runat="server"></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateColumn>
                 <asp:TemplateColumn  HeaderText="Color">
                    <ItemTemplate>
                        <asp:Literal ID="ltrColor" runat="server"></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateColumn>
                 <asp:TemplateColumn  HeaderText="Price">
                    <ItemTemplate>
                        <asp:Literal ID="ltrPrice" runat="server"></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateColumn>
                 <asp:TemplateColumn  HeaderText="PlateNumber">
                    <ItemTemplate>
                        <asp:LinkButton ID="ltrPlateNumber" runat="server" CommandName="ViewItems"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:ButtonColumn CommandName="View" HeaderText="Detail" Text="View" Visible="False"></asp:ButtonColumn>
            </Columns>
            <EditItemStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
            <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" BorderStyle="None" NextPageText="Next >" PrevPageText="< Previous" VerticalAlign="Middle" Font-Names="Century" Font-Size="Medium" Mode="NumericPages" />
            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:DataGrid>
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

