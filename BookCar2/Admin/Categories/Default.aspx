<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BookCar2.Admin.Categories.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .button {
            transition-duration: 0.4s;
        }

            .button:hover {
                background-color: darkblue; /* Green */
                color: Red;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="color: darkseagreen">CATEGORY</h1>
    <div class="DisplayList" style="padding-left: 2%; width: 100%">
      <asp:DataGrid ID="grvData" runat="server" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnItemDataBound="grdData_ItemDataBound" PageSize="5" Width="96%" AllowCustomPaging="True" AllowPaging="True" OnItemCommand="grvData_ItemCommand" OnPageIndexChanged="grvData_PageIndexChanged">
          <AlternatingItemStyle BackColor="White" />
          <Columns>
               <asp:TemplateColumn  HeaderText="CarCartegoryID" Visible="False">
                    <ItemTemplate>
                        <asp:Literal ID="ltrCarCategoryID" runat="server" Visible="False"></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn  HeaderText="Name">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbName" runat="server" CommandName="ViewItems"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateColumn>
                <asp:TemplateColumn  HeaderText="CreatedBy">
                    <ItemTemplate>
                        <asp:Literal ID="ltrCreatedBy" runat="server"></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateColumn>
              <asp:TemplateColumn  HeaderText="Edit">
                    <ItemTemplate>
                        <asp:Button ID="btnView" runat="server" Text="Edit" CommandName="EditItems" />
                    </ItemTemplate>
                </asp:TemplateColumn>
               <asp:TemplateColumn  HeaderText="Delete">
                    <ItemTemplate>
                        <asp:Button ID="btnDeleted" runat="server" Text="Delete" CommandName="DeleteItems" />
                    </ItemTemplate>
                </asp:TemplateColumn>
          </Columns>
          <EditItemStyle HorizontalAlign="Center" />
          <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
          <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
          <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" HorizontalAlign="Center" />
          <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" Mode="NumericPages" />
          <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />

      </asp:DataGrid>
    </div>
    <div class="btn" style="padding: 16px">
        <asp:Button ID="btnAddCar" runat="server" CssClass="button" Text="Add New Category" BackColor="#CCFFFF" Font-Bold="True" Height="42px" Width="138px" PostBackUrl="~/Admin/Categories/AddNew.aspx" OnClick="btnAddCar_Click" />
    </div>
</asp:Content>
