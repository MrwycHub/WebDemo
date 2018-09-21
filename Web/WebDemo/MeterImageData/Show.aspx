<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.MeterImageData.Show" Title="显示页" %>
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
		MeterID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ReadTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblReadTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Voltage
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVoltage" runat="server"></asp:Label>
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
		LowVoltage
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLowVoltage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MagneticDisturb
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMagneticDisturb" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ImageQuality
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblImageQuality" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EnableUpload
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEnableUpload" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterImage
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterImage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InsertDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInsertDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FreezeNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFreezeNumber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LeftMeterImage
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLeftMeterImage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RightMeterImage
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRightMeterImage" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




