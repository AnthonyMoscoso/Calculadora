<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario1.aspx.cs" Inherits="Calculadora.Forms.Formulario1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <script src="../scripts/FormularioScript/script.js" type="text/javascript"></script>
     <link href="css/Style1.css"
      rel="stylesheet" type="text/css"/>
    <title>Calculadora Anthony Moscoso</title>
</head>
<body>

    <form id="f" runat="server">
        <section class="Formulario">

        
        <section class="Calculadora">
            <h1>CALCULADORA</h1>
                <div class="DataBox">
                    <asp:Label ID="Label1" runat="server" Text="Insert Num 1"></asp:Label>
                    <asp:TextBox ID="TxtNum1" runat="server"></asp:TextBox>  
                   
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Format Error ,Only number pls" ControlToValidate="TxtNum1" ValidationExpression='[-+]?[0-9]*\.?[0-9]*'></asp:RegularExpressionValidator>
               </div>
               <div class="DataBox">
                    <asp:Label ID="Label2" runat="server" Text="Insert Num 2"></asp:Label>
                     <asp:TextBox ID="TxtNum2" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Format Error ,Only number pls" ControlToValidate="TxtNum2" ValidationExpression="[-+]?[0-9]*\.?[0-9]*"></asp:RegularExpressionValidator>
               </div>
                <div class="SelectOperador">
                    <h2>Seleccione la operacion :
                    </h2>
                    <asp:RadioButtonList ID="c1" runat="server">
                        <asp:ListItem Value="+" Text="+" Selected="True"></asp:ListItem>
                        <asp:ListItem Value="-" Text="-"></asp:ListItem>
                        <asp:ListItem Value="x" Text="x"></asp:ListItem>
                        <asp:ListItem Value="%" Text="%"></asp:ListItem>
                        <asp:ListItem Value="/" Text="/"></asp:ListItem>       
                    </asp:RadioButtonList>
                </div>
      
                 <asp:Button ID="BtnCalcular" runat="server" Text="Calcular" CssClass="Button" />
            <asp:Button ID="BtnLastOperation" runat="server" Text="Last Operation" CssClass="Button"  />
            <asp:Button ID="BtnClear" runat="server" Text="Clear" CssClass="Button" />
            <asp:Button ID="BtnRegisters" runat="server" Text="Get Registers" CssClass="Button"  />
        </section>
        <section class="History">
            <div id="HeadHistory">
                <h2 id="TittleHistorial">Historial</h2>
                <asp:Button ID="BtnClearHistory" runat="server" Text="Clear History" CssClass="Button"  />
            </div>          
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        </section>
       </section>
        <section class="DataView">
            <asp:GridView ID="GridView1" runat="server" ></asp:GridView>
        </section>
         
    </form>
    
</body>
</html>
