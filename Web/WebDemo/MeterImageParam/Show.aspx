<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.MeterImageParam.Show" Title="显示页" %>
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
		<asp:Label id="lblId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CameraNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCameraNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NumberCount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNumberCount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CaptureStartPixs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCaptureStartPixs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpClipPixs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpClipPixs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DownClipPixs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDownClipPixs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LeftClipPixs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLeftClipPixs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RightClipPixs
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRightClipPixs" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CircumgyrateDegree
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCircumgyrateDegree" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InclineDegree
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInclineDegree" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModelHeight
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModelHeight" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModelWidth
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModelWidth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ModelOneWidth
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModelOneWidth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NumberSpace
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNumberSpace" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BitValueLimen
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBitValueLimen" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BitValueRadius
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBitValueRadius" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BitValueBlackProportion
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBitValueBlackProportion" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MorphologicFilterParam
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMorphologicFilterParam" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SearchlimitParam
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSearchlimitParam" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WindowHeight
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWindowHeight" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastOperDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastOperDate" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




