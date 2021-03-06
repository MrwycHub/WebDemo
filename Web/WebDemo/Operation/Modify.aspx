﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="WebDemo.Web.WebDemo.Operation.Modify" Title="修改页" %>
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
		<asp:label id="lblOperID" runat="server"></asp:label>
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
		缴费ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPayID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		起始月份
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBeginMonth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		起始读数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBeginNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		终止月份
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEndMonth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		终止读数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEndNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		周期用量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUseNumber" runat="server" Width="200px"></asp:TextBox>
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
		单价
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		单价
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		费用
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFareMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		缴费标志
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPayMark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务类型(1-抄表结算；2-换表结算
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOperType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务日期
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblOperDate" runat="server"></asp:label>
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
		opermonth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtopermonth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceUnit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceUnit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Derateid
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDerateid" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FareName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFareName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperationName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOperationName" runat="server" Width="200px"></asp:TextBox>
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
		DerateReason
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDerateReason" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AdditionNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAdditionNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FareID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFareID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

