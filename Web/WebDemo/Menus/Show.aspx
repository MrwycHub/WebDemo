﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.Menus.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		菜单编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMenuID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpperID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpperID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		菜单名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMenuName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UrlAddr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUrlAddr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UrlTarget
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUrlTarget" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ImageUrl
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblImageUrl" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Flag
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFlag" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		排序字段
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOrdernum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		系统编号 1 BS管理端 2 
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSystemNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ReMark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblReMark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayTypeBak
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayTypeBak" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




