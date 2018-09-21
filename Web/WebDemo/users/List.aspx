<%@ Page Title="users" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.users.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="UsersID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="UsersID" HeaderText="UsersID" SortExpression="UsersID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UserCode" HeaderText="用户编号,不能重复" SortExpression="UserCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Doorplate" HeaderText="Doorplate" SortExpression="Doorplate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PaperType" HeaderText="PaperType" SortExpression="PaperType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PaperNo" HeaderText="PaperNo" SortExpression="PaperNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Tel" HeaderText="Tel" SortExpression="Tel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Acreage" HeaderText="住房面积" SortExpression="Acreage" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ChargeAcreage" HeaderText="收费面积" SortExpression="ChargeAcreage" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Reserve" HeaderText="余额" SortExpression="Reserve" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sex" HeaderText="性别" SortExpression="Sex" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Populace" HeaderText="人口" SortExpression="Populace" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remark" HeaderText="Remark" SortExpression="Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Mark" HeaderText="状态 1正常 2销户" SortExpression="Mark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DeptID" HeaderText="DeptID" SortExpression="DeptID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UserFloor" HeaderText="UserFloor" SortExpression="UserFloor" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="HouseDir" HeaderText="HouseDir" SortExpression="HouseDir" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UserType" HeaderText="UserType" SortExpression="UserType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ClientId" HeaderText="ClientId" SortExpression="ClientId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remnant" HeaderText="Remnant" SortExpression="Remnant" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remnant2" HeaderText="Remnant2" SortExpression="Remnant2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remnant3" HeaderText="Remnant3" SortExpression="Remnant3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UpdateTime" HeaderText="UpdateTime" SortExpression="UpdateTime" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="RegistPhone" HeaderText="RegistPhone" SortExpression="RegistPhone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EInvoiceType" HeaderText="EInvoiceType" SortExpression="EInvoiceType" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="UsersID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="UsersID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
