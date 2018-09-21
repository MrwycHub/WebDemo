<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="WebDemo.Web.WebDemo.PreOperation.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		一卡通卡号(卡号+卡区号不能重
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCardID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		卡区号(一卡通卡区号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCardSector" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		价格名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		单价
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOperMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOperInt" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务字数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOperZS" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		实收金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFactMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		上次余额
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastBalance" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		本次余额
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCurrentBalance" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总购买金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTotalMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总购买量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTotalInt" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总购买字数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTotalBase" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务类型(1-开户；2-充值；
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOperType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		充值类型(1-远程充值；2-写
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPayType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		发票号码
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInvoiceCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtOperDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		表编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		操作员
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOperatorID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SiteID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSiteID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FactoryNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFactoryNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRemark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RedOperId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRedOperId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOperNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDivid1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDivid2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseNumber1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUseNumber1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseNumber2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUseNumber2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseNumber3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUseNumber3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CurTotalBuyNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCurTotalBuyNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvoiceID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInvoiceID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvoiceType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInvoiceType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteCardFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWriteCardFlag" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TransactionId
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTransactionId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayWay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPayWay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OutTradeNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOutTradeNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DepositDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtDepositDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DiscountsNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDiscountsNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
