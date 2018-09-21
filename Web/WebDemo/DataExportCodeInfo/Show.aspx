<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.DataExportCodeInfo.Show" Title="显示页" %>
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
		Name
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StrSql
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStrSql" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShowDeptCondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblShowDeptCondition" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InfoCondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInfoCondition" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DateCondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDateCondition" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExtCondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExtCondition" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AscString
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAscString" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GridViewWidth
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGridViewWidth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExportType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExportType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShowHeader
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblShowHeader" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SplitChar
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSplitChar" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreateDbfSql
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCreateDbfSql" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DbfFileName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDbfFileName" runat="server"></asp:Label>
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
		EndDateCondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEndDateCondition" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShowOtherHeader
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblShowOtherHeader" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExportCols
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExportCols" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




