﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.FreezeMonth.Show" Title="显示页" %>
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
		表编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		冻结月
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFreezeMonth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		日冻结读数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFreezeNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ReadDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblReadDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		结算标志
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCalMark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstantNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInstantNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PileNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPileNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Watertemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWatertemp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BackWatertemp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBackWatertemp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWorkDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FactDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFactDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BatteryState
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBatteryState" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Warning
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWarning" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		抄表方式 1 自动抄表 2 手
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblReadType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OldFreezeNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOldFreezeNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Megabit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMegabit" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AdditionNum
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAdditionNum" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SmallImagePath
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSmallImagePath" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BigImagePath
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBigImagePath" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LocationX
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLocationX" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LocationY
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLocationY" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TakePhotoDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTakePhotoDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SyncFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSyncFlag" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceSetNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceSetNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CollectorReadDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCollectorReadDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ActiveSharp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActiveSharp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ActivePeak
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActivePeak" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ActiveShoulder
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActiveShoulder" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ActiveOffPeak
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActiveOffPeak" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterStatusString
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterStatusString" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		VerifyValue
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVerifyValue" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remnant
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemnant" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ValveState
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblValveState" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




