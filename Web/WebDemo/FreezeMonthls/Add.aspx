﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="WebDemo.Web.WebDemo.FreezeMonthls.Add" Title="增加页" %>

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
		<asp:TextBox id="txtMeterID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FreezeMonth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFreezeMonth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FreezeNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFreezeNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ReadDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtReadDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CalMark
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkCalMark" Text="CalMark" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstantNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInstantNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PileNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPileNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Watertemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWatertemp" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BackWatertemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBackWatertemp" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWorkDate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FactDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFactDate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BatteryState
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBatteryState" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Warning
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWarning" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ReadType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtReadType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OldFreezeNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOldFreezeNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Megabit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMegabit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

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
