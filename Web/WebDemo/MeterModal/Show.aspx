<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.MeterModal.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		型号编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModalid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		型号名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblModalname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseProtocol
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUseProtocol" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FactoryCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFactoryCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FactoryName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFactoryName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MaxValue
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMaxValue" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MaxYear
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMaxYear" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Caliber
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCaliber" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MaxFlow
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMaxFlow" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterHeaderType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterHeaderType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterStatusCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterStatusCode" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




