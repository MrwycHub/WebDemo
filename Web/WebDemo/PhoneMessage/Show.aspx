<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.PhoneMessage.Show" Title="显示页" %>
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
		SoftName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSoftName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Brands
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBrands" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Model
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Version
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVersion" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BlueToothVer
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBlueToothVer" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SDKVer
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSDKVer" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IMEI
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIMEI" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CPU
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCPU" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Memory
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMemory" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Resolution
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblResolution" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FirstLoginDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFirstLoginDate" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




