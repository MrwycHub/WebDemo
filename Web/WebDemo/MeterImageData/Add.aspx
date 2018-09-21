<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="WebDemo.Web.WebDemo.MeterImageData.Add" Title="增加页" %>

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
		ReadTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtReadTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Voltage
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtVoltage" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ValveState
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtValveState" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LowVoltage
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkLowVoltage" Text="LowVoltage" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MagneticDisturb
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkMagneticDisturb" Text="MagneticDisturb" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ImageQuality
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtImageQuality" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EnableUpload
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkEnableUpload" Text="EnableUpload" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterImage
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterImage" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InsertDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtInsertDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
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
		LeftMeterImage
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLeftMeterImage" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RightMeterImage
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRightMeterImage" runat="server" Width="200px"></asp:TextBox>
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
