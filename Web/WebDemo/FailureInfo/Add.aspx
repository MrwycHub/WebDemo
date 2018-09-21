<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="WebDemo.Web.WebDemo.FailureInfo.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		MeterID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailurePhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFailurePhone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureMan
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFailureMan" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureMemo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFailureMemo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFailureType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureRegTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtFailureRegTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureRegType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFailureRegType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DisposeMan
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDisposeMan" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DisposeMemo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDisposeMemo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DisposeStatus
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDisposeStatus" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DisposeTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtDisposeTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		sel
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chksel" Text="sel" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFailureCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AppointMan
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAppointMan" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AppointManPhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAppointManPhone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FailureSort
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFailureSort" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UsersID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUsersID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUserCode" runat="server" Width="200px"></asp:TextBox>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
