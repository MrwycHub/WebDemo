<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="WebDemo.Web.WebDemo.PriceType.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		价格编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblPriceTypeID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		价格名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		表类型编号
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMeterTypeID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		程序控制
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		单价
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		单价2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		单价3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		分界点1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDivid1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		分界点2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDivid2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceUnit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceUnit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注信息
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRemark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Price6
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrice6" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid3
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDivid3" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid4
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDivid4" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Divid5
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDivid5" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ExeDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtExeDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SetNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSetNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SuiteNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSuiteNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GroupPriceNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtGroupPriceNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PriceTypeCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPriceTypeCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsStartStar
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsStartStar" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsStartPeople
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsStartPeople" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PeopleCheck
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPeopleCheck" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MaxPeople
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMaxPeople" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AddUseNumber
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAddUseNumber" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StarsLevel
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStarsLevel" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StarsPeriod
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStarsPeriod" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StarsCorrected
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStarsCorrected" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsStartArea
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsStartArea" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Coefficient
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCoefficient" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CalculateDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCalculateDay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StarsAreaWay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStarsAreaWay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StarsByUser
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStarsByUser" runat="server" Width="200px"></asp:TextBox>
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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

