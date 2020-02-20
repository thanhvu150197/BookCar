<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BookCar2.Views.Default" %>
<%@ Register Assembly="SMCUI" Namespace="SoftMart.Core.UIControls" TagPrefix="sm" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
        .auto-style2 {
            text-align: center;
        }
    .auto-style3 {
        width: 181px;
    }
    .auto-style4 {
            width: 181px;
            text-align: center;
        }
    .auto-style5 {
            width: 368px;
        }
        .auto-style7 {
            text-align: left;
        width: 152px;
    }
        .auto-style8 {
            text-align: left;
            width: 108px;
        }
        .auto-style9 {
            text-align: left;
            width: 368px;
        }
        .auto-style12 {
            text-align: left;
            width: 181px;
        }
        .auto-style14 {
            text-align: left;
            width: 67px;
            height: 39px;
        }
        .auto-style15 {
            text-align: left;
            height: 39px;
        width: 152px;
    }
        .auto-style19 {
            width: 31px;
            text-align: center;
        }
        .auto-style21 {
            text-align: left;
            width: 31px;
            height: 54px;
        }
        .auto-style22 {
            text-align: left;
            height: 54px;
        }
        .auto-style24 {
            height: 54px;
            
        }
        .auto-style33 {
        text-align: left;
        width: 178px;
        height: 39px;
    }
    .auto-style35 {
        text-align: left;
        width: 67px;
    }
    .auto-style36 {
        text-align: left;
        width: 178px;
    }
        .auto-style37 {
            width: 31px;
        }
        .auto-style38 {
            text-align: left;
            width: 31px;
        }
        .textBox{
            border-radius:4px;
        }
        .auto-style39 {
            text-align: left;
            height: 39px;
            width: 107px;
        }
        .auto-style40 {
            text-align: left;
            width: 107px;
        }
        .auto-style41 {
            text-align: left;
            width: 73px;
            height: 39px;
        }
        .auto-style42 {
            width: 73px;
        }
        </style>
   <script>
       function getdatetime(x) {
           var dateselect = new Date();
           dateselect = x.get_selectedDate();
           var timeDisplay = new Date();
           x.get_element().value = dateselect.format("dd/MM/yyyy") + " " + timeDisplay.format("hh:mm:ss tt");
       }
          
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style38">
            &nbsp;</td>
        <td colspan="6" class="auto-style2">
            <asp:Label ID="lblBookCar" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Text="BOOK CAR"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style19">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style5" colspan="2">&nbsp;</td>
        <td colspan="3">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style38">&nbsp;</td>
        <td class="auto-style12"><strong>
            <asp:Label ID="Label1" runat="server" Text="Loại Xe"></asp:Label>
            </strong></td>
        <td class="auto-style9" colspan="2"><strong>
            <asp:Label ID="Label2" runat="server" Text="Thời gian đặt"></asp:Label>
            </strong></td>
        <td class="auto-style8" colspan="3">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style38" rowspan="2">
            &nbsp;</td>
        <td class="auto-style12">
            <asp:DropDownList ID="ddlCar" runat="server"
                DataTextField="Name" DataValueField="CarCategoryID" Width="120px" CausesValidation="True" BackColor="#99CCFF" Font-Bold="True" Height="23px">
            </asp:DropDownList>
        </td>
        <td class="auto-style41">
            <sm:DatePicker ID="dpTimeStart" runat="server" CssClass="selector" />
            </td>
        <td class="auto-style39">
            <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Image/thiet-ke-logo-mau-sac-dep-mat13.jpg" Width="55px" />
        </td>
        <td class="auto-style33">
                <sm:DatePicker ID="dpTimeEnd" runat="server" CssClass="selector" />
        </td>
        <td class="auto-style14">
            &nbsp;</td>
        <td class="auto-style15">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style12">
            &nbsp;</td>
        <td class="auto-style42">
            <sm:TimePicker ID="tpStar" runat="server"/></td>
        <td class="auto-style40">
            &nbsp;</td>
        <td class="auto-style36">
            <sm:TimePicker ID="tpEnd" runat="server"/></td>
        <td class="auto-style35">
            &nbsp;</td>
        <td class="auto-style7">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style19">
            &nbsp;</td>
        <td class="auto-style4">
            &nbsp;</td>
        <td class="auto-style5" colspan="2">&nbsp;</td>
        <td colspan="3">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style38">
            &nbsp;</td>
        <td class="auto-style12">
            <asp:Button ID="btnTimKiem" runat="server" Text="Tìm Xe" BackColor="#66CCFF" Font-Bold="True" Font-Names="Arial" ForeColor="White" Height="35px" Width="90px" OnClick="btnTimKiem_Click" />
        </td>
        <td class="auto-style5" colspan="2">&nbsp;</td>
        <td colspan="3">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style21">
        </td>
        <td class="auto-style22" style="border-style: solid none none none" colspan="3">
            <asp:Label ID="lblMess" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="Red"></asp:Label>
        </td>
        <td class="auto-style24" colspan="3" style="border-style: solid none none none"></td>
    </tr>
    <tr>
        <td class="auto-style37">
            &nbsp;</td>
        <td colspan="6">
            <asp:DataGrid ID="grvCar" runat="server" AllowCustomPaging="True" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="5" Width="96%" DataKeyField="CarID" OnItemCommand="grvCar_ItemCommand" OnPageIndexChanged="grvCar_PageIndexChanged" OnItemDataBound="grvCar_ItemDataBound">
                <AlternatingItemStyle BackColor="White" />
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
                <asp:TemplateColumn  HeaderText="Book">
                 <ItemTemplate>
                        <asp:Button ID="btnBook" runat="server" Text="Book Now" CommandName="Book" Height="30px" Width="80px"></asp:Button>
                    </ItemTemplate>
                </asp:TemplateColumn>
                
                <asp:ButtonColumn CommandName="View" HeaderText="Book" Text="Book" Visible="False"></asp:ButtonColumn>
                </Columns>
                <EditItemStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                <ItemStyle BackColor="#E3EAEB" HorizontalAlign="Center" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" Mode="NumericPages" />
                <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            </asp:DataGrid>
            <ajaxToolkit:DropShadowExtender ID="grvCar_DropShadowExtender" runat="server" BehaviorID="grvCar_DropShadowExtender" TargetControlID="grvCar" />
        </td>
    </tr>
    <tr>
        <td class="auto-style37">
            &nbsp;</td>
        <td colspan="6">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style37">&nbsp;</td>
        <td class="auto-style3">
            &nbsp;</td>
        <td class="auto-style5" colspan="2">&nbsp;</td>
        <td colspan="3">&nbsp;</td>
    </tr>
</table>
</asp:Content>
