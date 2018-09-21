<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.PaymentList.Show" Title="显示页" %>
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
		UsersID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUsersID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		发票号码
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvoiceNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		上次余额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastbalance" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		本次应交
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblThisMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		本次实交
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFactMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		本次余额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblThisBalance" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		操作员编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperatorID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayMode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayMode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		误收费恢复后
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFlag" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SiteID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSiteID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperInt
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperInt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvoiceID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvoiceID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvoiceType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvoiceType" runat="server"></asp:Label>
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
		PayWay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayWay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TransactionId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTransactionId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OutTradeNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOutTradeNo" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




