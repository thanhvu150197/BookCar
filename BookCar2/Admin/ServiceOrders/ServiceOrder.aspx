﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="ServiceOrder.aspx.cs" Inherits="BookCar2.Admin.ServiceOrders.ListRequire" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="color: darkseagreen">ServiceOrder</h1>
    <div class="Status-order" style="height:40px;padding-left:2%">
        <asp:DropDownList ID="ddlStatus" runat="server" Height="29px" Width="111px" AutoPostBack="True" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
        </asp:DropDownList>
    </div>
    <div class="list-require" style="padding-left: 2%; width: 100%">
     <asp:DataGrid runat="server" ID="grvListRequire" CellPadding="4" ForeColor="#333333" GridLines="None" Width="96%" AllowPaging="True"
            AllowCustomPaging="True" FirstPageText="<<" LastPageText=">>" OnPageIndexChanged="grvListRequire_PageIndexChanged" PageSize="5" AutoGenerateColumns="False" DataKeyField="OrderID" OnItemCommand="grvListRequire_ItemCommand" OnItemDataBound="grvListRequire_ItemDataBound">
            <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateColumn  HeaderText="OrderID" Visible="False">
                    <ItemTemplate>
                        <asp:Literal ID="ltrOrderID" runat="server" Visible="False"></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn  HeaderText="CarID" >
                    <ItemTemplate>
                        <asp:LinkButton ID="lbCarID" runat="server" CommandName="ViewCar"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn  HeaderText="PlanStartDTG" >
                    <ItemTemplate>
                        <asp:Literal ID="ltrPlanStartDTG" runat="server"></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn  HeaderText="PlanEndDTG">
                    <ItemTemplate>
                        <asp:Literal ID="ltrPlanEndDTG" runat="server"></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn  HeaderText="Time Order">
                    <ItemTemplate>
                        <asp:Literal ID="ltrTime" runat="server"></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn  HeaderText="Order Detail">
                    <ItemTemplate>
                        <asp:ImageButton ID="btnView" runat="server" CommandName="ViewOrder" Text="View" ImageUrl="~/Image/download.png" Height="30px" Width="30px"></asp:ImageButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn  HeaderText="Confirm">
                    <ItemTemplate>
                        <asp:ImageButton ID="btnConfirm" runat="server" CommandName="Confirm" Text="Ok" ImageUrl="~/Image/icontick.png" Height="30px" Width="30px"></asp:ImageButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn  HeaderText="Cancle">
                    <ItemTemplate>
                        <asp:ImageButton ID="btnCancle" runat="server" CommandName="Cancle" Text="X" Height="30px" Width="30px" ImageUrl="~/Image/iconcancle.png"></asp:ImageButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:ButtonColumn CommandName="View" HeaderText="Detail" Text="Ok" Visible="False"></asp:ButtonColumn>               
            </Columns>
            <EditItemStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
            <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" BorderStyle="None" NextPageText="Next >" PrevPageText="< Previous" VerticalAlign="Middle" Font-Names="Century" Font-Size="Medium" Mode="NumericPages" />
            <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        </asp:DataGrid>
    </div>
</asp:Content>
