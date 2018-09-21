﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="WebDemo.Web.WebDemo.Hosts.Add" Title="增加页" %>

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
		<asp:TextBox id="txtCollectorID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		楼宇主机编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHostID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		楼宇主机名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHostName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		地址
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHostAddr" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注信息
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRemark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		flag
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtflag" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LimitNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLimitNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HostComType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHostComType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HostType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHostType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HostRDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHostRDate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DownloadFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDownloadFlag" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PowerType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPowerType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HostNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHostNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HostLimitNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHostLimitNum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsRelay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsRelay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsDownMeterType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsDownMeterType" runat="server" Width="200px"></asp:TextBox>
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
