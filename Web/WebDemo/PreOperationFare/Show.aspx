<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.PreOperationFare.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		业务编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FareID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFareID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		费用名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFareTypeName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		单价
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFarePrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFareMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FareMoney1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFareMoney1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FarePrice2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFarePrice2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FareMoney2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFareMoney2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FarePrice3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFarePrice3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FareMoney3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFareMoney3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TaxRate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaxRate" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




