Public Class Form1
    ' Variables para almacenar el primer número, segundo número y la operación seleccionada
    Private firstNum As Double  ' Primer número ingresado por el usuario
    Private secondNum As Double ' Segundo número ingresado por el usuario
    Private operation As String ' Operación matemática seleccionada (+, -, *, /, etc.)
    Private isOperationPerformed As Boolean = False ' Indica si una operación ya fue seleccionada

    ' Al cargar el formulario, establecemos el texto inicial de la pantalla en "0"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Display.Text = "0"
    End Sub

    ' **Botones de números**
    ' Cada botón de número llama a la función AppendNumber con el número correspondiente
    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        AppendNumber("0")
    End Sub

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        AppendNumber("1")
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        AppendNumber("2")
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        AppendNumber("3")
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        AppendNumber("4")
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        AppendNumber("5")
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        AppendNumber("6")
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        AppendNumber("7")
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        AppendNumber("8")
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        AppendNumber("9")
    End Sub

    ' Función para agregar números al display
    Private Sub AppendNumber(num As String)
        ' Si el display muestra "0" o si ya se seleccionó una operación, reemplaza el display con el número
        If txt_Display.Text = "0" OrElse isOperationPerformed Then
            txt_Display.Text = num
            isOperationPerformed = False ' Reseteamos el indicador de operación
        Else
            txt_Display.Text &= num ' Concatenamos el número al display
        End If
    End Sub

    ' **Punto decimal**
    Private Sub btn_coma_Click(sender As Object, e As EventArgs) Handles btn_coma.Click
        ' Agrega un punto decimal solo si aún no existe en el display
        If Not txt_Display.Text.Contains(".") Then
            txt_Display.Text &= "."
        End If
    End Sub

    ' **Operaciones**
    ' Cada botón de operación llama a PerformOperation con el símbolo correspondiente
    Private Sub btn_sum_Click(sender As Object, e As EventArgs) Handles btn_sum.Click
        PerformOperation("+")
    End Sub

    Private Sub btn_rest_Click(sender As Object, e As EventArgs) Handles btn_rest.Click
        PerformOperation("-")
    End Sub

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        PerformOperation("*")
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        PerformOperation("/")
    End Sub

    Private Sub btn_pot_Click(sender As Object, e As EventArgs) Handles btn_pot.Click
        PerformOperation("^")
    End Sub

    Private Sub btn_po_Click(sender As Object, e As EventArgs) Handles btn_po.Click
        PerformOperation("%")
    End Sub

    ' Función que se llama cuando se selecciona una operación matemática (+, -, *, /, etc.)
    Private Sub PerformOperation(op As String)
        firstNum = Double.Parse(txt_Display.Text) ' Almacena el número actual en firstNum
        operation = op ' Almacena el tipo de operación seleccionada
        isOperationPerformed = True ' Indica que ya se seleccionó una operación
    End Sub

    ' **Botón igual**
    Private Sub btn_igual_Click(sender As Object, e As EventArgs) Handles btn_igual.Click
        secondNum = Double.Parse(txt_Display.Text) ' Toma el segundo número del display
        Dim result As Double ' Variable para almacenar el resultado

        ' Dependiendo de la operación seleccionada, realiza el cálculo correspondiente
        Select Case operation
            Case "+" ' Suma
                result = firstNum + secondNum
            Case "-" ' Resta
                result = firstNum - secondNum
            Case "*" ' Multiplicación
                result = firstNum * secondNum
            Case "/" ' División
                If secondNum <> 0 Then
                    result = firstNum / secondNum
                Else
                    MessageBox.Show("No se puede dividir por cero")
                    Exit Sub
                End If
            Case "^" ' Potencia
                result = Math.Pow(firstNum, secondNum)
            Case "%" ' Porcentaje
                result = firstNum * (secondNum / 100)
        End Select

        txt_Display.Text = result.ToString() ' Muestra el resultado en el display
        isOperationPerformed = True ' Marca que se ha realizado una operación
    End Sub

    ' **Botón de limpiar (C)**
    Private Sub btn_c_Click(sender As Object, e As EventArgs) Handles btn_c.Click
        txt_Display.Text = "0" ' Resetea el display a "0"
        firstNum = 0 ' Resetea el primer número
        secondNum = 0 ' Resetea el segundo número
        operation = "" ' Resetea la operación seleccionada
        isOperationPerformed = False ' Resetea el indicador de operación realizada
    End Sub

End Class
