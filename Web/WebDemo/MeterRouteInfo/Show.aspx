<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.MeterRouteInfo.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		MeterAddr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterAddr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Node1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNode1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Depth1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDepth1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Node2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNode2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Depth2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDepth2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Node3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNode3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Depth3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDepth3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Node4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNode4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Depth4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDepth4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Result
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblResult" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CollectorId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ReadTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblReadTime" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




