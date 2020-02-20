<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BookCar2.Admin.Cars.Default" %>
<%@ Register Assembly="SMCUI" Namespace="SoftMart.Core.UIControls" TagPrefix="sm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .button {
            transition-duration: 0.4s;
        }

            .button:hover {
                background-color: darkblue; /* Green */
                color: Red;
            }
        .auto-style2 {
            width: 19%;
        }
        .auto-style3 {
            text-align: right;
        }
        .auto-style4 {
            width: 20%;
            height: 22px;
        }
        .auto-style5 {
            width: 19%;
            height: 22px;
        }
        .auto-style6 {
            transition-duration: 0.4s;
            margin-left: 0px;
        }
        .auto-style7 {
            width: 2%;
            height: 22px;
        }
        .auto-style8 {
            width: 2%;
        }
        .auto-style9 {
            text-align: right;
            height: 5px;
        }
        .auto-style10 {
            width: 19%;
            height: 5px;
        }
        .auto-style11 {
            width: 2%;
            height: 5px;
        }
        .auto-style12 {
            height: 5px;
        }
        .auto-style13 {
            text-align: right;
            width: 15%;
        }
        .auto-style14 {
            text-align: right;
            height: 5px;
            width: 15%;
        }
        .auto-style15 {
            width: 15%;
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="color: darkseagreen">LIST CAR</h1>

    <div class="DisplayList" style="padding-left: 2%; width: 100%">
        <table class="" style="width:100%">
            <tr>
                <td class="auto-style15"></td>
                <td class="auto-style5"></td>
                <td class="auto-style7"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style13"><strong>
                    <asp:Label ID="Color" runat="server" Text="Color"></asp:Label>
                    </strong></td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtColor" runat="server" Height="23px"></asp:TextBox>
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtPlateNumber" runat="server" Height="23px"></asp:TextBox>
                </td>
                <td><strong>
                    <asp:Label ID="Color0" runat="server" Text="Plate Number"></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style10"></td>
                <td class="auto-style11"></td>
                <td class="auto-style9"></td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style13"><strong>
                    <asp:Label ID="Label2" runat="server" Text="Min Price"></asp:Label>
                    </strong></td>
                <td class="auto-style2">
                    <sm:NumericTextBox ID="txtMinPrice" runat="server" Height="23px" AllowThousandDigit="True"></sm:NumericTextBox> 
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style3">
                <asp:DropDownList ID="ddlCategory" DataTextField="Name" DataValueField="CarCategoryID" runat="server" BackColor="#99FF66" CssClass="ddlCar" Font-Bold="True" Height="23px" Width="110px">
                </asp:DropDownList>
                </td>
                <td><strong>
                    <asp:Label ID="Color1" runat="server" Text="Category"></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style10"></td>
                <td class="auto-style11"></td>
                <td class="auto-style9"></td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style13"><strong>
                    <asp:Label ID="Label3" runat="server" Text="Max Price"></asp:Label>
                    </strong></td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtMaxPrice" runat="server" Height="23px"></asp:TextBox>
                    
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style10"></td>
                <td class="auto-style11"></td>
                <td class="auto-style9"></td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style2">
        <asp:Button ID="Search" runat="server" CssClass="auto-style6" Text="Search" BackColor="#99FF99" Font-Bold="True" Height="31px" Width="77px" OnClick="Search_Click" />
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:DataGrid runat="server" ID="grdData" CellPadding="4" ForeColor="#333333" GridLines="None" Width="96%" AllowPaging="True" OnItemDataBound="grdData_ItemDataBound"
            AllowCustomPaging="True" FirstPageText="<<" LastPageText=">>" OnPageIndexChanged="grdData_PageIndexChanged" PageSize="5" AutoGenerateColumns="False" DataKeyField="CarID" OnItemCommand="grdData_ItemCommand">
            <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateColumn  HeaderText="CarID" Visible="False">
                    <ItemTemplate>
                        <asp:Literal ID="ltrCarID" runat="server" Visible="False"></asp:Literal>
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
                <asp:TemplateColumn  HeaderText="Edit">
                 <ItemTemplate>
                        <asp:ImageButton ID="btnEdit" runat="server" CommandName="EditItems" ImageUrl="~/Image/edit.jpg" Height="30px" Width="30px"></asp:ImageButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
                 <asp:TemplateColumn  HeaderText="Delete">
                 <ItemTemplate>
                        <asp:ImageButton ID="btnDelete" runat="server" CommandName="DeleteItems" ImageUrl="~/Image/632_img1.jpg" Height="30px" Width="30px"></asp:ImageButton>
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
    </div>
    <div class="btn" style="padding: 16px">
        <asp:Button ID="btnAddCar" runat="server" CssClass="button" Text="Add New Car" BackColor="#CCFFFF" Font-Bold="True" Height="42px" Width="138px" PostBackUrl="~/Admin/Cars/AddNew.aspx" OnClick="btnAddCar_Click" />
    </div>
</asp:Content>
