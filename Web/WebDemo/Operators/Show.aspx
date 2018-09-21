<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.Operators.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		OperatorID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperatorID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperatorCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperatorCode" runat="server"></asp:Label>
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
		RoleID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRoleID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperPassword
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperPassword" runat="server"></asp:Label>
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
		1-正常 2锁定
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFlag" runat="server"></asp:Label>
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
		LastLoginDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastLoginDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		每页显示行数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPageRowCounts" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperLevel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperLevel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TemplateID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTemplateID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PaymentTemplateID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPaymentTemplateID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ICTemplateID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblICTemplateID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Phone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SelfSetting
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSelfSetting" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AutoRead
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAutoRead" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PhoneSerialNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPhoneSerialNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsBinding
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsBinding" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RoleLevel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRoleLevel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExpiryDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExpiryDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Skin
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSkin" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




