﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="WebDemo.Web.WebDemo.InstantTask.Add" Title="增加页" %>

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
		<asp:TextBox id="txtTaskID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TaskType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTaskType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CollectorID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCollectorID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterAddr
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterAddr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HostAddr
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHostAddr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterStatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterData
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterData" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		本次购买量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPayMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		总量
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTotalPayMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
