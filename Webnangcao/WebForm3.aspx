<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Webnangcao.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Template\vendor\bootstrap\css\bootstrap.min.css"/>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
      <div class="container">
        <a class="navbar-brand" href="#">Học Nhóm</a>

        <ul class="nav justify-content-end">
          <li class="nav-item">
            <a class="nav-link " href="#">Câu hỏi</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Thảo luận</a>
          </li>
          <li class="nav-item">
            <a class="nav-link " href="#">About</a>
          </li>
        </ul>
        <form class="form-inline my-2 my-lg-0">
          <input class="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search" />
          <button class="btn btn-outline-success my-2 my-sm-0" type="submit">Search</button>
        </form>
        <a class="nav-link" href="WebForm2.aspx">Đăngkí/Đăngnhập</a>
      </div>
    </nav>
    <div class="container">
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button1_Click2" />

        </div>
    </form>
    </div>
</body>
</html>
