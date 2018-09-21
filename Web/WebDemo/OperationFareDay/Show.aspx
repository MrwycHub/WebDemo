<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.OperationFareDay.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		OperID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOperID" runat="server"></asp:Label>
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
		FarePrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFarePrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FareMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFareMoney" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FarePrice2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFarePrice2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FarePrice3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFarePrice3" runat="server"></asp:Label>
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
		UseNumber1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUseNumber1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseNumber2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUseNumber2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseNumber3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUseNumber3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExtData1
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExtData1" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExtData2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExtData2" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




