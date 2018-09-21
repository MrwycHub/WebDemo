<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="WebDemo.Web.WebDemo.MeterImageParam.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterId
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblMeterId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CameraNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblCameraNo" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NumberCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtNumberCount" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CaptureStartPixs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCaptureStartPixs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpClipPixs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUpClipPixs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DownClipPixs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDownClipPixs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LeftClipPixs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLeftClipPixs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RightClipPixs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRightClipPixs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CircumgyrateDegree
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCircumgyrateDegree" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InclineDegree
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInclineDegree" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModelHeight
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtModelHeight" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModelWidth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtModelWidth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModelOneWidth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtModelOneWidth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NumberSpace
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtNumberSpace" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BitValueLimen
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBitValueLimen" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BitValueRadius
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBitValueRadius" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BitValueBlackProportion
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBitValueBlackProportion" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MorphologicFilterParam
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMorphologicFilterParam" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SearchlimitParam
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSearchlimitParam" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WindowHeight
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWindowHeight" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastOperDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtLastOperDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
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

