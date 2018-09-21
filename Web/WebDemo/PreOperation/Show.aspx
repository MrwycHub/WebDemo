<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.PreOperation.Show" Title="显示页" %>
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
		一卡通卡号(卡号+卡区号不能重
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCardID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		卡区号(一卡通卡区号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCardSector" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		价格名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		单价
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务量
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperInt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务字数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperZS" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		实收金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFactMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		上次余额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastBalance" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		本次余额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCurrentBalance" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总购买金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTotalMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总购买量
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTotalInt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总购买字数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTotalBase" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务类型(1-开户；2-充值；
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		充值类型(1-远程充值；2-写
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		发票号码
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvoiceCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		表编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		操作员
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperatorID" runat="server"></asp:Label>
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
		FactoryNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFactoryNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RedOperId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRedOperId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDivid1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDivid2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseNumber1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUseNumber1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseNumber2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUseNumber2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseNumber3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUseNumber3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CurTotalBuyNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCurTotalBuyNumber" runat="server"></asp:Label>
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
		WriteCardFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWriteCardFlag" runat="server"></asp:Label>
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
		PayWay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayWay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OutTradeNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOutTradeNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DepositDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDepositDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DiscountsNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDiscountsNum" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




