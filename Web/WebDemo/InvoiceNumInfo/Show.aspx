﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.InvoiceNumInfo.Show" Title="显示页" %>
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
		DisId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDisId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BatchId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBatchId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InvoiceNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInvoiceNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OrderNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOrderNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Mark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SubFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSubFlag" runat="server"></asp:Label>
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
		AssignOperator
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAssignOperator" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AssignDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAssignDate" runat="server"></asp:Label>
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
		Remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




