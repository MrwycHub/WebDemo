<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.FreezeDay.Show" Title="显示页" %>
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
		冻结日
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFreezeDate" runat="server"></asp:Label>
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
		抄表时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblReadDate" runat="server"></asp:Label>
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
		ValveState
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblValveState" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UploadFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUploadFlag" runat="server"></asp:Label>
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
		MeterStatusString
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterStatusString" runat="server"></asp:Label>
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
		ReadMode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblReadMode" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




