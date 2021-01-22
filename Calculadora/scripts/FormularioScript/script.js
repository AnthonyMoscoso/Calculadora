var n1 ,n2,result=0;


function GetResult(operador) {
    switch (operador) {
        case "+":
            result = parseFloat(n1 + n2)

            break;
        case "-":
            result = parseFloat(n1 - n2)
            break;
        case "x":
            result = parseFloat(n1 * n2);
            break;
        case "%":
            result = parseFloat(n1 % n2);
            break;
        case "/":
            result = parseFloat(n1 / n2);
            break;
    }

    return result;
}

function Calcular() {

    var txt1 = document.getElementById("TxtNum1").value;
    var txt2 = document.getElementById("TxtNum2").value
    if (txt1 && txt2) {
        var patern = /^[+-]?\d+(\.\d+)?$/;
        if (!patern.test(txt1) || !patern.test(txt2)) {
            alert("Only Digits");
        }
        else {
            n1 = parseFloat(txt1);
            n2 = parseFloat(txt2);
            result = 0;
            var radioButtons = document.getElementsByName("c1");
            var operador;
            for (var x = 0; x < radioButtons.length; x++) {
                if (radioButtons[x].checked) {
                    operador = radioButtons[x].value;
                    break;
                }
            }
            var result = GetResult(operador).toString()
            alert("Result to " + txt1 + operador + txt2 + "=" + result);     
        }
    }
    else {
        alert("No puede dejar valores nulos");
    }
};

window.onload=function(){
    document.getElementById("BtnCalcular").onclick=Calcular;

};
