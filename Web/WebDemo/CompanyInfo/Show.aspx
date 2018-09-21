<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.CompanyInfo.Show" Title="显示页" %>
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
		CompanyName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCompanyName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CompanyNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCompanyNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Pwd
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPwd" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AuthorizationCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAuthorizationCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IDCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIDCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EFileCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEFileCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TaxAgencyCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaxAgencyCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AgentMark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAgentMark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProjectName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProjectName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProjectCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblProjectCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AccountBank
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAccountBank" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AccountNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAccountNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CompanyAddress
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCompanyAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CompanyPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCompanyPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SleepTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSleepTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpdateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpdateTime" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




