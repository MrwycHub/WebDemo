<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.MultiOperation.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		OperID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MultiUserID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMultiUserID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CardID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCardID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CardSector
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCardSector" runat="server"></asp:Label>
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
		LastBalance
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastBalance" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CurrentBalance
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCurrentBalance" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TotalMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTotalMoney" runat="server"></asp:Label>
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
		InvoiceCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvoiceCode" runat="server"></asp:Label>
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
		OperatorID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperatorID" runat="server"></asp:Label>
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
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




