<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.MetersDev.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		MeterID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DisenableDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDisenableDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SiteDir
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSiteDir" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InsureCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInsureCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InsureDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInsureDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InsureEndDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInsureEndDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GasDir
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGasDir" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstallPos
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInstallPos" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstallWorkerID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInstallWorkerID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstallDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInstallDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FireWorkerID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFireWorkerID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FireDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFireDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FirstCheckDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFirstCheckDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FirstCheckMark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFirstCheckMark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CheckCyc
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCheckCyc" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BoilerFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBoilerFlag" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SelfFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSelfFlag" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BookID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBookID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstallID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInstallID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FirstCheckInfo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFirstCheckInfo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FirstCheckWorkerID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFirstCheckWorkerID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CurrValveState
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCurrValveState" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




