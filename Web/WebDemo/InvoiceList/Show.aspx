<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.InvoiceList.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		InID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInID" runat="server"></asp:Label>
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
		InNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInNumber" runat="server"></asp:Label>
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
		OperatorName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperatorName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GetDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGetDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrintDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrintDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InMark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInMark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SendMark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSendMark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SendDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSendDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		printMan
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblprintMan" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		zfDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblzfDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		zfInCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblzfInCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		zfInNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblzfInNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUName" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




