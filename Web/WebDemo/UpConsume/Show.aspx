<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.UpConsume.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		UpId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CardId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCardId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LostFreeNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLostFreeNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SurplusMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSurplusMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ConsumeTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblConsumeTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Meterid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUseMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InsDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInsDate" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




