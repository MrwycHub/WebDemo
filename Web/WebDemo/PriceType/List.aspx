<%@ Page Title="PriceType" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.PriceType.List" %>
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
                    BorderWidth="1px" DataKeyNames="PriceTypeID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="PriceTypeName" HeaderText="价格名称" SortExpression="PriceTypeName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterTypeID" HeaderText="表类型编号" SortExpression="MeterTypeID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceNo" HeaderText="程序控制" SortExpression="PriceNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price" HeaderText="单价" SortExpression="Price" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price2" HeaderText="单价2" SortExpression="Price2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price3" HeaderText="单价3" SortExpression="Price3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid1" HeaderText="分界点1" SortExpression="Divid1" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid2" HeaderText="分界点2" SortExpression="Divid2" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceUnit" HeaderText="PriceUnit" SortExpression="PriceUnit" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remark" HeaderText="备注信息" SortExpression="Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price4" HeaderText="Price4" SortExpression="Price4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price5" HeaderText="Price5" SortExpression="Price5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price6" HeaderText="Price6" SortExpression="Price6" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid3" HeaderText="Divid3" SortExpression="Divid3" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid4" HeaderText="Divid4" SortExpression="Divid4" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Divid5" HeaderText="Divid5" SortExpression="Divid5" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExeDate" HeaderText="ExeDate" SortExpression="ExeDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SetNo" HeaderText="SetNo" SortExpression="SetNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SuiteNo" HeaderText="SuiteNo" SortExpression="SuiteNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="GroupPriceNo" HeaderText="GroupPriceNo" SortExpression="GroupPriceNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeCode" HeaderText="PriceTypeCode" SortExpression="PriceTypeCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsStartStar" HeaderText="IsStartStar" SortExpression="IsStartStar" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsStartPeople" HeaderText="IsStartPeople" SortExpression="IsStartPeople" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PeopleCheck" HeaderText="PeopleCheck" SortExpression="PeopleCheck" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MaxPeople" HeaderText="MaxPeople" SortExpression="MaxPeople" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AddUseNumber" HeaderText="AddUseNumber" SortExpression="AddUseNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StarsLevel" HeaderText="StarsLevel" SortExpression="StarsLevel" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StarsPeriod" HeaderText="StarsPeriod" SortExpression="StarsPeriod" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StarsCorrected" HeaderText="StarsCorrected" SortExpression="StarsCorrected" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsStartArea" HeaderText="IsStartArea" SortExpression="IsStartArea" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Coefficient" HeaderText="Coefficient" SortExpression="Coefficient" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CalculateDay" HeaderText="CalculateDay" SortExpression="CalculateDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StarsAreaWay" HeaderText="StarsAreaWay" SortExpression="StarsAreaWay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="StarsByUser" HeaderText="StarsByUser" SortExpression="StarsByUser" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="PriceTypeID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="PriceTypeID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
