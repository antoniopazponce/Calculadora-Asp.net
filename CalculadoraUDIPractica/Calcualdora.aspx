<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calcualdora.aspx.cs" Inherits="CalculadoraUDIPractica.Calcualdora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox>
            <asp:TextBox ID="txtSubtotal" runat="server"></asp:TextBox>
            <br /> 
            <asp:Button ID="btnCE" runat="server" Text="CE" OnClick="btnCE_Click" />
            <asp:Button ID="btnSuma" runat="server" Text="+" OnClick="btnSuma_Click" />
            <asp:Button ID="btnResta" runat="server" Text="-" OnClick="btnResta_Click" /><br />
            <asp:Button ID="btn7" runat="server" Text="7" OnClick="btn7_Click" />
            <asp:Button ID="btn8" runat="server" Text="8" OnClick="btn8_Click" style="width: 23px" />
            <asp:Button ID="btn9" runat="server" Text="9" OnClick="btn9_Click" />
            <asp:Button ID="btnMultiplicacion" runat="server" Text="x" OnClick="btnMultiplicacion_Click" /><br />
            <asp:Button ID="btn4" runat="server" Text="4" OnClick="btn4_Click" />
            <asp:Button ID="btn5" runat="server" Text="5" OnClick="btn5_Click" style="width: 23px" />
            <asp:Button ID="btn6" runat="server" Text="6" OnClick="btn6_Click" />
            <asp:Button ID="btnDivicion" runat="server" Text="/" OnClick="btnDivicion_Click" /><br />
            <asp:Button ID="btn1" runat="server" Text="1" OnClick="btn1_Click" />
            <asp:Button ID="btn2" runat="server" Text="2" OnClick="btn2_Click" style="width: 23px" />
            <asp:Button ID="btn3" runat="server" Text="3" OnClick="btn3_Click" />
            <asp:Button ID="btnIgual" runat="server" Text="=" OnClick="btnIgual_Click" /><br />
            <asp:Button ID="btn0" runat="server" Text="0" OnClick="btn0_Click" />
            <asp:Button ID="btnComa" runat="server" Text="," OnClick="btnComa_Click" style="width: 19px" />
        </div>
    </form>
</body>
</html>
