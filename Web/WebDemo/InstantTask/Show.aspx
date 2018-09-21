<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.InstantTask.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		TaskID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaskID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TaskType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTaskType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CollectorID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterAddr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterAddr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HostAddr
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHostAddr" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterData
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterData" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		本次购买量
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总量
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTotalPayMoney" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




