<%@ Page Title="PreOperationFare" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.PreOperationFare.List" %>
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
                    BorderWidth="1px" DataKeyNames="OperID,FareTypeName" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="OperID" HeaderText="业务编号" SortExpression="OperID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FareID" HeaderText="FareID" SortExpression="FareID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FareTypeName" HeaderText="费用名称" SortExpression="FareTypeName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FarePrice" HeaderText="单价" SortExpression="FarePrice" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FareMoney" HeaderText="金额" SortExpression="FareMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FareMoney1" HeaderText="FareMoney1" SortExpression="FareMoney1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FarePrice2" HeaderText="FarePrice2" SortExpression="FarePrice2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FareMoney2" HeaderText="FareMoney2" SortExpression="FareMoney2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FarePrice3" HeaderText="FarePrice3" SortExpression="FarePrice3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FareMoney3" HeaderText="FareMoney3" SortExpression="FareMoney3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TaxRate" HeaderText="TaxRate" SortExpression="TaxRate" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="OperID,FareTypeName" DataNavigateUrlFormatString="Show.aspx?id0={0}&id1={1}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="OperID,FareTypeName" DataNavigateUrlFormatString="Modify.aspx?id0={0}&id1={1}"
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
