<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="WebDemo.Web.WebDemo.DataExportCodeInfo.Modify" Title="修改页" %>
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
		<asp:label id="lblID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Name
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StrSql
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStrSql" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShowDeptCondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkShowDeptCondition" Text="ShowDeptCondition" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InfoCondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInfoCondition" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DateCondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDateCondition" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExtCondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExtCondition" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AscString
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAscString" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GridViewWidth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtGridViewWidth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExportType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExportType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShowHeader
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkShowHeader" Text="ShowHeader" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SplitChar
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSplitChar" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CreateDbfSql
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCreateDbfSql" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DbfFileName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDbfFileName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRemark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EndDateCondition
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEndDateCondition" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ShowOtherHeader
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtShowOtherHeader" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExportCols
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExportCols" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

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

