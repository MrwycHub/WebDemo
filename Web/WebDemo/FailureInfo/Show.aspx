<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebDemo.Web.WebDemo.FailureInfo.Show" Title="显示页" %>
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
		MeterID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeterID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailurePhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFailurePhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureMan
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFailureMan" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureMemo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFailureMemo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFailureType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureRegTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFailureRegTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureRegType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFailureRegType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DisposeMan
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDisposeMan" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DisposeMemo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDisposeMemo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DisposeStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDisposeStatus" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DisposeTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDisposeTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFailureCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AppointMan
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAppointMan" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AppointManPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAppointManPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureSort
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFailureSort" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UsersID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUsersID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserCode" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




