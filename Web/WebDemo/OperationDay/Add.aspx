<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="WebDemo.Web.WebDemo.OperationDay.Add" Title="增加页" %>

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
		BeginMonth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBeginMonth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BeginNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBeginNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EndMonth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEndMonth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EndNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEndNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUseNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FareMoney
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFareMoney" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayMark
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPayMark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOperType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		业务时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtOperDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OperatorID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtOperatorID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		opermonth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtopermonth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeterNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDivid1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDivid2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseNumber1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUseNumber1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseNumber2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUseNumber2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UseNumber3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUseNumber3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExtData1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExtData1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExtData2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtExtData2" runat="server" Width="200px"></asp:TextBox>
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
