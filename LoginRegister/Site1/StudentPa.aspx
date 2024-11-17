<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPa.aspx.cs" Inherits="Site1.StudentPa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
    <style>
        h1{
            text-align:center; color:burlywood; font-size:40px;
        }
        .mydatagrid
{
width: 80%;
border: solid 2px black;
min-width: 80%;
align-self:center;
margin-left:75px;
}
.header
{
background-color: #646464;
font-family: Arial;
color: White;
border: none 0px transparent;
height: 25px;
text-align: center;
font-size: 16px;
}

.rows
{
background-color: #fff;
font-family: Arial;
font-size: 14px;
color: #000;
min-height: 25px;
text-align: left;
border: none 0px transparent;
}
.rows:hover
{
background-color: #ff8000;
font-family: Arial;
color: #fff;
text-align: left;
}
.selectedrow
{
background-color: #ff8000;
font-family: Arial;
color: #fff;
font-weight: bold;
text-align: left;
}
.mydatagrid a /** FOR THE PAGING ICONS **/
{
background-color: Transparent;
padding: 5px 5px 5px 5px;
color: #fff;
text-decoration: none;
font-weight: bold;
}

.mydatagrid a:hover /** FOR THE PAGING ICONS HOVER STYLES**/
{
background-color: #000;
color: #fff;
}
.mydatagrid span /** FOR THE PAGING ICONS CURRENT PAGE INDICATOR **/
{
background-color: #c9c9c9;
color: #000;
padding: 5px 5px 5px 5px;
}
.pager
{
background-color: #646464;
font-family: Arial;
color: White;
height: 30px;
text-align: left;
}
.button1
{
    align-items:center;
        margin-top:100px;
        margin-left:50%;

}

.mydatagrid td
{
padding: 5px;
}
.mydatagrid th
{
padding: 5px;
}

        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1   > Hi <%=n %></h1>

            <asp:gridview CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows" id="CGridView2" autogeneratecolumns="False"  emptydatatext="No data available."   
                                      runat="server"  >
          <Columns>
            <asp:BoundField DataField="Classs.ClassName" HeaderText="Class Name" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
              <asp:BoundField DataField="Student.FirstName" HeaderText="Student Name" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
              <asp:BoundField DataField="Tools.ToolName.ToolName1" HeaderText="Tool Name" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
              <asp:BoundField DataField="Description" HeaderText="Description" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
              <asp:BoundField DataField="Id" HeaderText="Problem Id" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
              <asp:BoundField DataField="SolvingTime" HeaderText="Solving Time" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
              <asp:BoundField DataField="Issolved" HeaderText="Is Solved" InsertVisible="False" ReadOnly="True" SortExpression="ID" />


           <%-- <asp:BoundField DataField="FirstName" HeaderText=" F-Name"  SortExpression="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="L-Name"  SortExpression="LastName" />
            <asp:BoundField DataField="PhoneNumber" HeaderText="cell"    />--%>
          </Columns>
        </asp:gridview> 

        </div>
        <div>
              <asp:button CssClass="button1" Font-Size="20px" BackColor="Red" color="white" margin="8px 0" border="none"  cursor="pointer" width="250px"  runat="server" OnClick="Unnamed_Click" Text="LogOut" type="submit" ></asp:button>
        </div>
    </form>
</body>
</html>
