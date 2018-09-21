<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.EInvoices.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvoiceNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvoiceNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OrderNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOrderNo" runat="server"></asp:Label>
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
		OperMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FactMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFactMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvoiceState
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvoiceState" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		URL
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblURL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreateDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCreateDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperatorID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperatorID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvoiceCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvoiceCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RtnInvoiceNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRtnInvoiceNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ManualRegist
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblManualRegist" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RedSaleURL
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRedSaleURL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RSInvoiceNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRSInvoiceNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RegistDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRegistDate" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




