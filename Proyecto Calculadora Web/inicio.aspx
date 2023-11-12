<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="Proyecto_Calculadora_Web.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculadora Web</title>
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style type="text/css">
      .auto-style1 {
          font-size: xx-large;
          text-align: center;
      }
      .set{
          margin-left:350px;
          margin-right:350px;
          padding:20px; 
      }
      .auto-style2{
          font-size: x-large;
          font-weight: bold;
      }
      .auto-style3{
          font-size: large;
          font-weight: bold;
      }
  </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>Calculadora Web</strong></div>
        <div class="container m-4 p-4">
            <center class="set" style="background-color:aquamarine;">
                <asp:TextBox ID="TextBox1" runat="server" Height="42px" Width="242px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                <br />
                <br />
                <strong>
                    <asp:Button ID="btnOne" runat="server" CssClass="autostyle2" Height="46px" Text="1" Width="49px" OnClick="btnOne_Click" />
                    <asp:Button ID="btnTwo" runat="server" CssClass="autostyle2" Height="46px" Text="2" Width="49px" OnClick="btnTwo_Click" />
                    <asp:Button ID="btnThree" runat="server" CssClass="autostyle2" Height="46px" Text="3" Width="49px" OnClick="btnThree_Click" />
                    <asp:Button ID="btnAdd" runat="server" CssClass="autostyle2" Height="46px" Text="+" Width="49px" OnClick="btnAdd_Click" />
                    <br />
                    <br />
                    <asp:Button ID="btnFour" runat="server" CssClass="autostyle2" Height="46px" Text="4" Width="49px" OnClick="btnFour_Click" />
                    <asp:Button ID="btnFive" runat="server" CssClass="autostyle2" Height="46px" Text="5" Width="49px" OnClick="btnFive_Click" />
                    <asp:Button ID="btnSix" runat="server" CssClass="autostyle2" Height="46px" Text="6" Width="49px" OnClick="btnSix_Click" />
                    <asp:Button ID="btnSub" runat="server" CssClass="autostyle2" Height="46px" Text="-" Width="49px" OnClick="btnSub_Click" />
                    <br />
                    <br /> 
                    <asp:Button ID="btnSeven" runat="server" CssClass="autostyle2" Height="46px" Text="7" Width="49px" OnClick="btnSeven_Click" />
                    <asp:Button ID="btnEight" runat="server" CssClass="autostyle2" Height="46px" Text="8" Width="49px" OnClick="btnEight_Click" />
                    <asp:Button ID="btnNine" runat="server" CssClass="autostyle2" Height="46px" Text="9" Width="49px" OnClick="btnNine_Click" />
                    <asp:Button ID="btnMul" runat="server" CssClass="autostyle2" Height="46px" Text="*" Width="49px" OnClick="btnMul_Click" />
                    <br />
                    <br />
                    <asp:Button ID="btnZero" runat="server" CssClass="autostyle2" Height="46px" Text="0" Width="49px" OnClick="btnZero_Click" />
                    <asp:Button ID="btnClear" runat="server" CssClass="autostyle2" Height="46px" Text="CLR" Width="49px" OnClick="btnClear_Click" />
                    <asp:Button ID="btnEqual" runat="server" CssClass="autostyle2" Height="46px" Text="=" Width="49px" OnClick="btnEqual_Click" />
                    <asp:Button ID="btnDiv" runat="server" CssClass="autostyle2" Height="46px" Text="/" Width="49px" OnClick="btnDiv_Click" />
                </strong>
            </center>
        </div>
     </form>
</body>
</html>
