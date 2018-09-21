<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.PriceTypeDev.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LateFeeRate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLateFeeRate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LateFeeDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLateFeeDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LateFeeBase
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLateFeeBase" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ICMonth
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblICMonth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ICMaxBuy
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblICMaxBuy" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ICAmount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblICAmount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ICMonthBuy
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblICMonthBuy" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ICDayAvg
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblICDayAvg" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




