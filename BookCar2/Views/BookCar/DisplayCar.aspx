<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage/Default.Master" AutoEventWireup="true" CodeBehind="DisplayCar.aspx.cs" Inherits="BookCar2.Views.BookCar.DisplayCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .textBox {
            border-radius: 4px;
        }

        .ddlCar {
            border-radius: 3px;
        }

        .auto-style2 {
            text-align: center;
        }

        .auto-style3 {
            width: 53px;
        }

        .auto-style5 {
            width: 213px;
        }

        .auto-style7 {
            width: 213px;
            text-align: right;
        }

        .auto-style8 {
            width: 52px;
        }

        .auto-style9 {
            text-align: center;
        }

        .auto-style10 {
            width: 192px;
        }

        .auto-style11 {
            width: 206px;
        }

        .auto-style12 {
            width: 206px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td class="auto-style2" colspan="7">
                <h2 style="color: darkseagreen">Car Detail</h2>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style12"><strong>
                <asp:Label ID="Label2" runat="server" Text="Plate Number"></asp:Label>
            </strong></td>
            <td class="auto-style10">
                <asp:TextBox ID="txtPlateNumber" CssClass="textBox" runat="server" Width="110px" Height="23px" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style7"><strong>
                <asp:Label ID="Label4" runat="server" Text="Car Category"></asp:Label>
            </strong></td>
            <td>
                <asp:TextBox ID="txtCategoryName" CssClass="textBox" runat="server" Width="110px" Height="23px" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style12"><strong>
                <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label>
            </strong></td>
            <td class="auto-style10">
                <asp:TextBox ID="txtPrice" CssClass="textBox" runat="server" Width="110px" Height="23px" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style7"><strong>
                <asp:Label ID="Label6" runat="server" Text="Color"></asp:Label>
            </strong></td>
            <td>
                <asp:TextBox ID="txtColor" CssClass="textBox" runat="server" Width="110px" Height="23px" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style12"><strong>
                <asp:Label ID="Label3" runat="server" Text="Mô Tả"></asp:Label>
            </strong></td>
            <td class="auto-style10">
                <asp:TextBox ID="txtDes" CssClass="textBox" runat="server" Width="204px" Height="69px" TextMode="MultiLine" BackColor="#CCCCFF" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td colspan="3">
                <asp:Label ID="Label7" runat="server" Text="List Order Of Car" Font-Bold="True" Font-Size="X-Large" ForeColor="Red"></asp:Label>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td colspan="6">
                  <asp:DataGrid runat="server" ID="grdData" CellPadding="4" ForeColor="#333333" GridLines="None" Width="96%" AllowPaging="True" OnItemDataBound="grdData_ItemDataBound"
            AllowCustomPaging="True" FirstPageText="<<" LastPageText=">>" OnPageIndexChanged="grdData_PageIndexChanged" PageSize="5" AutoGenerateColumns="False" DataKeyField="CarID">
            <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateColumn  HeaderText="CarID" Visible="False">
                    <ItemTemplate>
                        <asp:Literal ID="ltrCarID" runat="server" Visible="False"></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateColumn>
                 <asp:TemplateColumn  HeaderText="Plan Start">
                    <ItemTemplate>
                        <asp:Literal ID="ltrPlanStart" runat="server"></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateColumn>
                 <asp:TemplateColumn  HeaderText="Plan End">
                    <ItemTemplate>
                        <asp:Literal ID="ltrPlanEnd" runat="server"></asp:Literal>
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
        </asp:DataGrid></td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="7">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9" colspan="7">
                <asp:Button ID="btnBack" runat="server" BackColor="#FFFF99" Font-Bold="True" Height="32px" Text="Back" Width="103px" OnClick="btnBack_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 280px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
