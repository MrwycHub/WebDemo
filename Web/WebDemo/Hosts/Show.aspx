<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.Hosts.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		集中器编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		楼宇主机编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHostID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		楼宇主机名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHostName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHostAddr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注信息
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flag
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblflag" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LimitNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLimitNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HostComType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHostComType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HostType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHostType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HostRDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHostRDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DownloadFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDownloadFlag" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PowerType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPowerType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HostNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHostNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HostLimitNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHostLimitNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsRelay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsRelay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsDownMeterType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsDownMeterType" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




