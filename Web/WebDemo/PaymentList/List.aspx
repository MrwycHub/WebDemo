<%@ Page Title="PaymentList" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.PaymentList.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="OperID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="OperID" HeaderText="业务编号" SortExpression="OperID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UsersID" HeaderText="UsersID" SortExpression="UsersID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterID" HeaderText="MeterID" SortExpression="MeterID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvoiceNum" HeaderText="发票号码" SortExpression="InvoiceNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Lastbalance" HeaderText="上次余额" SortExpression="Lastbalance" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ThisMoney" HeaderText="本次应交" SortExpression="ThisMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FactMoney" HeaderText="本次实交" SortExpression="FactMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ThisBalance" HeaderText="本次余额" SortExpression="ThisBalance" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayDate" HeaderText="业务日期" SortExpression="PayDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OperatorID" HeaderText="操作员编号" SortExpression="OperatorID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayMode" HeaderText="PayMode" SortExpression="PayMode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Flag" HeaderText="误收费恢复后" SortExpression="Flag" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SiteID" HeaderText="SiteID" SortExpression="SiteID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OperInt" HeaderText="OperInt" SortExpression="OperInt" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvoiceID" HeaderText="InvoiceID" SortExpression="InvoiceID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InvoiceType" HeaderText="InvoiceType" SortExpression="InvoiceType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayType" HeaderText="PayType" SortExpression="PayType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayWay" HeaderText="PayWay" SortExpression="PayWay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TransactionId" HeaderText="TransactionId" SortExpression="TransactionId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OutTradeNo" HeaderText="OutTradeNo" SortExpression="OutTradeNo" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="OperID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="OperID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
