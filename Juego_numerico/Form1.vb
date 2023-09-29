Imports System.Configuration
Imports System.Reflection.Emit
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
'Imports org.mariuszgroma.math.mxparse
Public Class Form1
    Dim contador As Integer
    Private Sub BtnInicio_Click(sender As Object, e As EventArgs) Handles BtnInicio.Click
        'bloqueo()
        BtnBorrar.Enabled = True
        BtnBorrarTodo.Enabled = True
        BtnResolver.Enabled = True
        TmrReloj.Enabled = True
        contador = 60
        TxtTiempo.Text = contador
        LlenarNumeros() ' se llama a la cuncion llenar
        BtnNum01.Enabled = True 'habilita botonRam01 1
        BtnNum02.Enabled = True 'habilita botonRam02 2
        BtnNum03.Enabled = True 'habilita botonRam03 3
        BtnNum04.Enabled = True 'habilita botonRam04 4
        BtnInicio.Enabled = False 'deshabilita el boton inicio
    End Sub
    Dim indice As Integer
    Dim indice_01 As Integer

    Private Sub LlenarNumeros()
        Dim value1 As Integer = CInt(Math.Floor(10 * Rnd())) ' Genera un número aleatorio del 0 al 9 y se asigna a label 1
        Dim value2 As Integer = CInt(Math.Floor(10 * Rnd())) ' Genera un número aleatorio del 0 al 9 y se asigna a label 2
        Dim value3 As Integer = CInt(Math.Floor(10 * Rnd())) ' Genera un número aleatorio del 0 al 9 y se asigna a label 3
        Dim value4 As Integer = CInt(Math.Floor(10 * Rnd())) ' Genera un número aleatorio del 0 al 9 y se asigna a label 4


        BtnNum01.Text = value1 'pasa la variable ramdom al label01
        BtnNum02.Text = value2 'pasa la variable ramdom al label02
        BtnNum03.Text = value3 'pasa la variable ramdom al label03
        BtnNum04.Text = value4 'pasa la variable ramdom al label04

        Dim primera_posicion As String = GenerarPosicion()
        If primera_posicion = 1 Then
            BtnNum04.Location = New Point(117, 114)
            BtnNum02.Location = New Point(176, 114)
            BtnNum03.Location = New Point(250, 114)
            BtnNum01.Location = New Point(327, 114)
        End If
        If primera_posicion = 2 Then
            BtnNum03.Location = New Point(117, 114)
            BtnNum04.Location = New Point(176, 114)
            BtnNum02.Location = New Point(250, 114)
            BtnNum01.Location = New Point(327, 114)
        End If
        If primera_posicion = 3 Then
            BtnNum02.Location = New Point(117, 114)
            BtnNum03.Location = New Point(176, 114)
            BtnNum01.Location = New Point(250, 114)
            BtnNum04.Location = New Point(327, 114)
        End If
        If primera_posicion = 4 Then
            BtnNum02.Location = New Point(117, 114)
            BtnNum04.Location = New Point(176, 114)
            BtnNum03.Location = New Point(250, 114)
            BtnNum01.Location = New Point(327, 114)
        End If

        Dim signo01 As String = GenerarSigno() ' captura en ramdom el primer signo
        Dim signo02 As String = GenerarSigno() ' captura en ramdom el segudo signo
        Dim signo03 As String = GenerarSigno() ' captura en ramdom el tercer signo

        Dim equation As String = value1 & signo01 & value2 & signo02 & value3 & signo03 & value4 ' ejecuta la operacion de evaluacion
        Dim result = New DataTable().Compute(equation, Nothing) 'entrega el resultado y se lo asigna a la variable resultado

        TxtReslDet.Text = value1 & signo01 & value2 & signo02 & value3 & signo03 & value4 'detalla lo calculado solo para pruebas
        TxtResultado.Text = result ' se asigna al valor resultado
        TextBox1.Text = TxtReslDet.Text
    End Sub
    Function GenerarSigno() '
        indice = 0
        Dim longitud As Integer = 1 'variable de cantidad de valores a elegir en este caso solo es uno
        Dim contante As String = "*+-/" ' valores que quiero tomar en ramdom
        Dim Rnd As New Random()
        For i As Integer = 0 To longitud - 1
            indice = Rnd.[Next](contante.Length)
        Next
        Return contante(indice)
    End Function
    Function GenerarPosicion() '
        indice_01 = 0
        Dim longitud_01 As Integer = 1 'variable de cantidad de valores a elegir en este caso solo es uno
        Dim contante_01 As String = "1234" ' valores que quiero tomar en ramdom
        Dim Rnd_01 As New Random()
        For j As Integer = 0 To longitud_01 - 1
            indice_01 = Rnd_01.[Next](contante_01.Length)
            'MsgBox(indice_01)
        Next
        Return contante_01(indice_01)
    End Function
    Private Sub BtnOper01_Click(sender As Object, e As EventArgs) Handles BtnOper01.Click

        If TxtNum01.Text <> "" And TxtNum02.Text = "" And TxtNum03.Text = "" And TxtNum04.Text = "" Then
            LblOperador01.Text = BtnOper01.Text
        ElseIf TxtNum01.Text <> "" And TxtNum02.Text <> "" And TxtNum03.Text = "" And TxtNum04.Text = "" Then
            LblOperador02.Text = BtnOper01.Text
        ElseIf TxtNum01.Text <> "" And TxtNum02.Text <> "" And TxtNum03.Text <> "" And TxtNum04.Text = "" Then
            LblOperador03.Text = BtnOper01.Text
        End If
    End Sub
    Private Sub BtnOper02_Click(sender As Object, e As EventArgs) Handles BtnOper02.Click
        If TxtNum01.Text <> "" And TxtNum02.Text = "" And TxtNum03.Text = "" And TxtNum04.Text = "" Then
            LblOperador01.Text = BtnOper02.Text
        ElseIf TxtNum01.Text <> "" And TxtNum02.Text <> "" And TxtNum03.Text = "" And TxtNum04.Text = "" Then
            LblOperador02.Text = BtnOper02.Text
        ElseIf TxtNum01.Text <> "" And TxtNum02.Text <> "" And TxtNum03.Text <> "" And TxtNum04.Text = "" Then
            LblOperador03.Text = BtnOper02.Text
        End If
    End Sub
    Private Sub BtnOper03_Click(sender As Object, e As EventArgs) Handles BtnOper03.Click
        If TxtNum01.Text <> "" And TxtNum02.Text = "" And TxtNum03.Text = "" And TxtNum04.Text = "" Then
            LblOperador01.Text = BtnOper03.Text
        ElseIf TxtNum01.Text <> "" And TxtNum02.Text <> "" And TxtNum03.Text = "" And TxtNum04.Text = "" Then
            LblOperador02.Text = BtnOper03.Text
        ElseIf TxtNum01.Text <> "" And TxtNum02.Text <> "" And TxtNum03.Text <> "" And TxtNum04.Text = "" Then
            LblOperador03.Text = BtnOper03.Text
        End If

    End Sub
    Private Sub BtnOper04_Click(sender As Object, e As EventArgs) Handles BtnOper04.Click
        If TxtNum01.Text <> "" And TxtNum02.Text = "" And TxtNum03.Text = "" And TxtNum04.Text = "" Then
            LblOperador01.Text = BtnOper04.Text
        ElseIf TxtNum01.Text <> "" And TxtNum02.Text <> "" And TxtNum03.Text = "" And TxtNum04.Text = "" Then
            LblOperador02.Text = BtnOper04.Text
        ElseIf TxtNum01.Text <> "" And TxtNum02.Text <> "" And TxtNum03.Text <> "" And TxtNum04.Text = "" Then
            LblOperador03.Text = BtnOper04.Text
        End If
    End Sub
    Private Sub TmrContador_Tick(sender As Object, e As EventArgs) Handles TmrReloj.Tick
        contador -= 1
        If bandera = 1 Then
            contador = contador + 15
            bandera = 0
        End If

        TxtTiempo.Text = contador

        If contador <= 0 Then
            ' Detener el temporizador cuando el contador llega a 0 o menos
            TmrReloj.Enabled = False
            MsgBox("Su marcador Total Fue de: " & marcador)
            Me.Close()
        End If
    End Sub

    Dim marcador As Integer = 0
    'Private Sub TxtNum01_TextChanged(sender As Object, e As EventArgs) Handles TxtNum01.TextChanged
    'TxtResParcial.Text = TxtNum01.Text
    'End Sub

    Private Sub TxtNum02_TextChanged(sender As Object, e As EventArgs) Handles TxtNum02.TextChanged
        Try
            Dim equation2 As String = TxtNum01.Text & LblOperador01.Text & TxtNum02.Text ' ejecuta la operacion de evaluacion
            Dim result2 = New DataTable().Compute(equation2, Nothing) 'entrega el resultado y se lo asigna a la variable resultado
            TxtResParcial.Text = result2
            'LblRamdom02.Enabled = False
        Catch ex As Exception
        End Try


    End Sub

    Private Sub TxtNum03_TextChanged(sender As Object, e As EventArgs) Handles TxtNum03.TextChanged
        Try
            Dim equation3 As String = TxtNum01.Text & LblOperador01.Text & TxtNum02.Text & LblOperador02.Text & TxtNum03.Text ' ejecuta la operacion de evaluacion
            Dim result3 = New DataTable().Compute(equation3, Nothing) 'entrega el resultado y se lo asigna a la variable resultado
            TxtResParcial.Text = result3
            'LblRamdom03.Enabled = False
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxtNum04_TextChanged(sender As Object, e As EventArgs) Handles TxtNum04.TextChanged

        Try
            Dim equation4 As String = TxtNum01.Text & LblOperador01.Text & TxtNum02.Text & LblOperador02.Text & TxtNum03.Text & LblOperador03.Text & TxtNum04.Text ' ejecuta la operacion de evaluacion
            Dim result4 = New DataTable().Compute(equation4, Nothing) 'entrega el resultado y se lo asigna a la variable resultado
            TxtResParcial.Text = result4
            BtnSiguiente.Visible = True
            TmrReloj.Stop()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Desbloqueo()
        TxtResultado.Text = ""
        TxtReslDet.Text = ""
        TxtResParcial.Text = ""

        TxtNum01.Text = ""
        TxtNum02.Text = ""
        TxtNum03.Text = ""
        TxtNum04.Text = ""
        BtnNum01.Enabled = True 'habilita botonRam01 1
        BtnNum02.Enabled = True 'habilita botonRam02 2
        BtnNum03.Enabled = True 'habilita botonRam03 3
        BtnNum04.Enabled = True 'habilita botonRam04 4
        LblOperador01.Text = "O"
        LblOperador02.Text = "O"
        LblOperador03.Text = "O"
        BtnOper01.Enabled = False
        BtnOper02.Enabled = False
        BtnOper03.Enabled = False
        BtnOper04.Enabled = False
        'BtnInicio.Enabled = False 'deshabilita el boton inicio

    End Sub

    Private Sub BtnNum01_Click(sender As Object, e As EventArgs) Handles BtnNum01.Click

        If TxtNum01.Text = "" Then
            TxtNum01.Text = BtnNum01.Text
            BtnNum01.Enabled = False
        ElseIf TxtNum02.Text = "" And LblOperador01.Text <> "O" Then
            TxtNum02.Text = BtnNum01.Text
            BtnNum01.Enabled = False
        ElseIf TxtNum03.Text = "" And LblOperador01.Text <> "O" And LblOperador02.Text <> "O" Then
            TxtNum03.Text = BtnNum01.Text
            BtnNum01.Enabled = False
        ElseIf TxtNum04.Text = "" And LblOperador01.Text <> "O" And LblOperador02.Text <> "O" And LblOperador03.Text <> "O" Then
            TxtNum04.Text = BtnNum01.Text
            BtnNum01.Enabled = False
        Else
            MsgBox("Debe colocar un Operador")
        End If

        BtnOper01.Enabled = True
        BtnOper02.Enabled = True
        BtnOper03.Enabled = True
        BtnOper04.Enabled = True


    End Sub

    Private Sub BtnNum02_Click(sender As Object, e As EventArgs) Handles BtnNum02.Click

        If TxtNum01.Text = "" Then
            TxtNum01.Text = BtnNum02.Text
            BtnNum02.Enabled = False
        ElseIf TxtNum02.Text = "" And LblOperador01.Text <> "O" Then
            TxtNum02.Text = BtnNum02.Text
            BtnNum02.Enabled = False
        ElseIf TxtNum03.Text = "" And LblOperador01.Text <> "O" And LblOperador02.Text <> "O" Then
            TxtNum03.Text = BtnNum02.Text
            BtnNum02.Enabled = False
        ElseIf TxtNum04.Text = "" And LblOperador01.Text <> "O" And LblOperador02.Text <> "O" And LblOperador03.Text <> "O" Then
            TxtNum04.Text = BtnNum02.Text
            BtnNum02.Enabled = False
        Else
            MsgBox("Debe colocar un Operador")
        End If

        BtnOper01.Enabled = True
        BtnOper02.Enabled = True
        BtnOper03.Enabled = True
        BtnOper04.Enabled = True

    End Sub

    Private Sub BtnNum03_Click(sender As Object, e As EventArgs) Handles BtnNum03.Click

        If TxtNum01.Text = "" Then
            TxtNum01.Text = BtnNum03.Text
            BtnNum03.Enabled = False
        ElseIf TxtNum02.Text = "" And LblOperador01.Text <> "O" Then
            TxtNum02.Text = BtnNum03.Text
            BtnNum03.Enabled = False
        ElseIf TxtNum03.Text = "" And LblOperador01.Text <> "O" And LblOperador02.Text <> "O" Then
            TxtNum03.Text = BtnNum03.Text
            BtnNum03.Enabled = False
        ElseIf TxtNum04.Text = "" And LblOperador01.Text <> "O" And LblOperador02.Text <> "O" And LblOperador03.Text <> "O" Then
            TxtNum04.Text = BtnNum03.Text
            BtnNum03.Enabled = False
        Else
            MsgBox("Debe colocar un Operador")

        End If

        BtnOper01.Enabled = True
        BtnOper02.Enabled = True
        BtnOper03.Enabled = True
        BtnOper04.Enabled = True

    End Sub

    Private Sub BtnNum04_Click(sender As Object, e As EventArgs) Handles BtnNum04.Click

        If TxtNum01.Text = "" Then
            TxtNum01.Text = BtnNum04.Text
            BtnNum04.Enabled = False
        ElseIf TxtNum02.Text = "" And LblOperador01.Text <> "O" Then
            TxtNum02.Text = BtnNum04.Text
            BtnNum04.Enabled = False
        ElseIf TxtNum03.Text = "" And LblOperador01.Text <> "O" And LblOperador02.Text <> "O" Then
            TxtNum03.Text = BtnNum04.Text
            BtnNum04.Enabled = False
        ElseIf TxtNum04.Text = "" And LblOperador01.Text <> "O" And LblOperador02.Text <> "O" And LblOperador03.Text <> "O" Then
            TxtNum04.Text = BtnNum04.Text
            BtnNum04.Enabled = False
        Else
            MsgBox("Debe colocar un Operador")

        End If
        '
        BtnOper01.Enabled = True
        BtnOper02.Enabled = True
        BtnOper03.Enabled = True
        BtnOper04.Enabled = True


    End Sub



    Private Sub TxtResultado_TextChanged(sender As Object, e As EventArgs) Handles TxtResultado.TextChanged
        Dim textoResultado As String = TxtResultado.Text
        Dim resultadoSinDecimal As String = ""

        ' Comprueba si el texto contiene un punto decimal
        If textoResultado.Contains(".") Then
            resultadoSinDecimal = textoResultado.Split("."c)(0)
        Else
            resultadoSinDecimal = textoResultado
        End If

        Dim resultadoEntero As Integer
        If Integer.TryParse(resultadoSinDecimal, resultadoEntero) Then

            If resultadoEntero >= 0 Then
                TxtResultado.Text = resultadoEntero.ToString()
            Else

                TxtResultado.Text = ""
            End If
        Else
            TxtResultado.Text = ""
        End If
    End Sub

    Private borrando As Boolean = False

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim b1 As String = TxtNum01.Text
        Dim b2 As String = LblOperador01.Text
        Dim b3 As String = TxtNum02.Text
        Dim b4 As String = LblOperador02.Text
        Dim b5 As String = TxtNum03.Text
        Dim b6 As String = LblOperador03.Text
        Dim b7 As String = TxtNum04.Text

        ' Establece la bandera de borrado en verdadero
        borrando = True

        If b7 <> "" And b6 <> "O" And b5 <> "" And b4 <> "O" And b3 <> "" And b2 <> "O" And b1 <> "" Then
            TxtNum04.Text = ""
            BtnNum04.Enabled = True
        ElseIf b7 = "" And b6 <> "O" And b5 <> "" And b4 <> "O" And b3 <> "" And b2 <> "O" And b1 <> "" Then
            LblOperador03.Text = "O"
        ElseIf b7 = "" And b6 = "O" And b5 <> "" And b4 <> "O" And b3 <> "" And b2 <> "O" And b1 <> "" Then
            TxtNum03.Text = ""
            BtnNum03.Enabled = True
        ElseIf b7 = "" And b6 = "O" And b5 = "" And b4 <> "O" And b3 <> "" And b2 <> "O" And b1 <> "" Then
            LblOperador02.Text = "O"
        ElseIf b7 = "" And b6 = "O" And b5 = "" And b4 = "O" And b3 <> "" And b2 <> "O" And b1 <> "" Then
            TxtNum02.Text = ""
            BtnNum02.Enabled = True
        ElseIf b7 = "" And b6 = "O" And b5 = "" And b4 = "O" And b3 = "" And b2 <> "O" And b1 <> "" Then
            LblOperador01.Text = "O"
        ElseIf b7 = "" And b6 = "O" And b5 = "" And b4 = "O" And b3 = "" And b2 = "O" And b1 <> "" Then
            TxtNum01.Text = ""
            BtnNum01.Enabled = True
        End If

        ' Restablece la bandera de borrado a falso
        borrando = False

        BtnSiguiente.Visible = False
        TmrReloj.Start()
    End Sub

    Private Sub TxtNum01_TextChanged(sender As Object, e As EventArgs) Handles TxtNum01.TextChanged
        ' Verifica si el texto se está modificando debido a una acción de borrado
        If Not borrando Then
            ' Puedes realizar otras acciones aquí si es necesario
        End If
    End Sub


    Private Sub BtnBorrarTodo_Click(sender As Object, e As EventArgs) Handles BtnBorrarTodo.Click
        TxtNum04.Text = ""
        BtnNum04.Enabled = True
        LblOperador03.Text = "O"
        TxtNum03.Text = ""
        BtnNum03.Enabled = True
        LblOperador02.Text = "O"
        TxtNum02.Text = ""
        BtnNum02.Enabled = True
        LblOperador01.Text = "O"
        TxtNum01.Text = ""
        BtnNum01.Enabled = True
        BtnSiguiente.Visible = False
        TmrReloj.Start()
    End Sub


    Dim contarbuenas As Integer
    Dim contartodas As Integer
    Dim bandera As String
    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles BtnSiguiente.Click
        LblSolucion.Visible = False
        TxtReslDet.Visible = False
        If TxtReslDet.Text = TxtNum01.Text & LblOperador01.Text & TxtNum02.Text & LblOperador02.Text & TxtNum03.Text & LblOperador03.Text & TxtNum04.Text Then
            If TxtReslDet.Visible = False Then
                contarbuenas = contarbuenas + 1
                contartodas = contartodas + 1
                bandera = 1
                'TxtTiempo.Text = TxtTiempo.Text + 40
            Else
                bandera = 0
            End If

        Else

            contartodas = contartodas + 1
        End If

        LblContIntentos.Text = contartodas
        TmrReloj.Start()
        LlenarNumeros() ' se llama a la cuncion llenar
        TxtNum04.Text = ""
        BtnNum04.Enabled = True
        LblOperador03.Text = "O"
        TxtNum03.Text = ""
        BtnNum03.Enabled = True
        LblOperador02.Text = "O"
        TxtNum02.Text = ""
        BtnNum02.Enabled = True
        LblOperador01.Text = "O"
        TxtNum01.Text = ""
        BtnNum01.Enabled = True
        BtnSiguiente.Visible = False
        BtnNum01.Enabled = True 'habilita botonRam01 1
        BtnNum02.Enabled = True 'habilita botonRam02 2
        BtnNum03.Enabled = True 'habilita botonRam03 3
        BtnNum04.Enabled = True 'habilita botonRam04 4
        BtnBorrar.Enabled = True
        BtnBorrarTodo.Enabled = True
    End Sub

    Private Sub BtnResolver_Click(sender As Object, e As EventArgs) Handles BtnResolver.Click
        ' Deshabilita los botones de los números
        BtnNum01.Enabled = False
        BtnNum02.Enabled = False
        BtnNum03.Enabled = False
        BtnNum04.Enabled = False
        BtnOper01.Enabled = False
        BtnOper02.Enabled = False
        BtnOper03.Enabled = False
        BtnOper04.Enabled = False

        ' Deshabilita el botón "Borrar" solo si se ha presionado el botón "Resolver"
        BtnBorrar.Enabled = False
        BtnBorrarTodo.Enabled = False

        LblSolucion.Visible = True
        TxtReslDet.Visible = True
        BtnSiguiente.Visible = True
    End Sub

End Class
