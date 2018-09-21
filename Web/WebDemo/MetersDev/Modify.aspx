<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="WebDemo.Web.WebDemo.MetersDev.Modify" Title="修改页" %>
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
		<asp:label id="lblMeterID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DisenableDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtDisenableDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SiteDir
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSiteDir" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InsureCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInsureCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InsureDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtInsureDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InsureEndDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtInsureEndDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GasDir
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtGasDir" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstallPos
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInstallPos" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstallWorkerID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInstallWorkerID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstallDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtInstallDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FireWorkerID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFireWorkerID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FireDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtFireDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FirstCheckDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtFirstCheckDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FirstCheckMark
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFirstCheckMark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CheckCyc
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCheckCyc" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BoilerFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBoilerFlag" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SelfFlag
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSelfFlag" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BookID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBookID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstallID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInstallID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FirstCheckInfo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFirstCheckInfo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FirstCheckWorkerID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFirstCheckWorkerID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CurrValveState
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCurrValveState" runat="server" Width="200px"></asp:TextBox>
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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

