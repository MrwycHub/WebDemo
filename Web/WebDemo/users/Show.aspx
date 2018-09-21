<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.users.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		UsersID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUsersID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		用户编号,不能重复
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Doorplate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDoorplate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PaperType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPaperType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PaperNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPaperNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Address
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Phone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Tel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		住房面积
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAcreage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		收费面积
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblChargeAcreage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		余额
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblReserve" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		性别
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSex" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		人口
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPopulace" runat="server"></asp:Label>
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
		状态 1正常 2销户
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DeptID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDeptID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserFloor
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserFloor" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HouseDir
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHouseDir" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ClientId
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblClientId" runat="server"></asp:Label>
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
		Remnant2
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemnant2" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remnant3
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemnant3" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UpdateTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUpdateTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RegistPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRegistPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EInvoiceType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEInvoiceType" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




