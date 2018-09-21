<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.AdjustPriceLog.Show" Title="显示页" %>
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
		PriceTypeID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPriceTypeID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExeDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExeDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Mark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDivid1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDivid2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDivid3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDivid4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDivid5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FareID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFareID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FareTypeName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFareTypeName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrice6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FareNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFareNo" runat="server"></asp:Label>
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
		PreFareTypeName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPreFareTypeName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrePrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrePrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrePrice2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrePrice2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrePrice3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrePrice3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrePrice4
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrePrice4" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrePrice5
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrePrice5" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrePrice6
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrePrice6" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PreFareNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPreFareNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PreRemark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPreRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SetNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSetNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FreezeDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFreezeDay" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




