<%@ Page Title="TaskPlan" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebDemo.Web.WebDemo.TaskPlan.List" %>
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
                    BorderWidth="1px" DataKeyNames="ID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="TaskID" HeaderText="任务编号" SortExpression="TaskID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CollectorID" HeaderText="集中器编号" SortExpression="CollectorID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TaskName" HeaderText="任务名称" SortExpression="TaskName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CommandID" HeaderText="指令编号" SortExpression="CommandID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CommandInfo" HeaderText="CommandInfo" SortExpression="CommandInfo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterAddr" HeaderText="MeterAddr" SortExpression="MeterAddr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterType" HeaderText="MeterType" SortExpression="MeterType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterItem" HeaderText="抄表数据项" SortExpression="MeterItem" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FreezeDate" HeaderText="冻结日" SortExpression="FreezeDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TaskMonth" HeaderText="执行月份(0表示每个月)" SortExpression="TaskMonth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TaskDay" HeaderText="执行日期(0表示每天)" SortExpression="TaskDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TaskHour" HeaderText="执行时" SortExpression="TaskHour" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TaskMinute" HeaderText="执行分" SortExpression="TaskMinute" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExeMark" HeaderText="执行标志(1-未执行；2-已执" SortExpression="ExeMark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExeDate" HeaderText="执行时间" SortExpression="ExeDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExeError" HeaderText="重试次数" SortExpression="ExeError" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TaskMark" HeaderText="启动任务(1-启动 2 不启动" SortExpression="TaskMark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TaskType" HeaderText="任务类型" SortExpression="TaskType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TaskError" HeaderText="TaskError" SortExpression="TaskError" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TryNum" HeaderText="重试次数" SortExpression="TryNum" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="HostAddr" HeaderText="采集器地址" SortExpression="HostAddr" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="InsDate" HeaderText="InsDate" SortExpression="InsDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MeterID" HeaderText="MeterID" SortExpression="MeterID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TaskFrequency" HeaderText="任务类型" SortExpression="TaskFrequency" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExeInfo" HeaderText="ExeInfo" SortExpression="ExeInfo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OperatorID" HeaderText="OperatorID" SortExpression="OperatorID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DeptID" HeaderText="DeptID" SortExpression="DeptID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TaskWeek" HeaderText="TaskWeek" SortExpression="TaskWeek" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PriceTypeID" HeaderText="PriceTypeID" SortExpression="PriceTypeID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ServerId" HeaderText="ServerId" SortExpression="ServerId" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ExeType" HeaderText="ExeType" SortExpression="ExeType" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
