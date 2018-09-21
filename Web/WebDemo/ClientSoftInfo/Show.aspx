<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.ClientSoftInfo.Show" Title="显示页" %>
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
		DanWeiName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDanWeiName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JiQiMa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJiQiMa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RenZhengMa
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRenZhengMa" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SoftName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSoftName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SoftHao
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSoftHao" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UsePassword
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUsePassword" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		JieTiCalDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblJieTiCalDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SqlVersion
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSqlVersion" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterTypes
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterTypes" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CardTypes
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCardTypes" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayTypes
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayTypes" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpdateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpdateTime" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




