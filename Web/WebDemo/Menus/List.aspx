﻿<%@ Page Title="Menus" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.Menus.List" %>
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
                    BorderWidth="1px" DataKeyNames="MenuID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="MenuID" HeaderText="菜单编号" SortExpression="MenuID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UpperID" HeaderText="UpperID" SortExpression="UpperID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MenuName" HeaderText="菜单名称" SortExpression="MenuName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UrlAddr" HeaderText="UrlAddr" SortExpression="UrlAddr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UrlTarget" HeaderText="UrlTarget" SortExpression="UrlTarget" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ImageUrl" HeaderText="ImageUrl" SortExpression="ImageUrl" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Flag" HeaderText="Flag" SortExpression="Flag" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Ordernum" HeaderText="排序字段" SortExpression="Ordernum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SystemNum" HeaderText="系统编号 1 BS管理端 2 " SortExpression="SystemNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayType" HeaderText="PayType" SortExpression="PayType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ReMark" HeaderText="ReMark" SortExpression="ReMark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayTypeBak" HeaderText="PayTypeBak" SortExpression="PayTypeBak" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="MenuID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="MenuID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
