<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TxtNum01 = New TextBox()
        TxtNum02 = New TextBox()
        TxtNum03 = New TextBox()
        TxtNum04 = New TextBox()
        BtnInicio = New Button()
        LblOperador01 = New Label()
        LblOperador02 = New Label()
        LblOperador03 = New Label()
        TxtResultado = New TextBox()
        LblIgual = New Label()
        BtnOper01 = New Button()
        BtnOper02 = New Button()
        BtnOper03 = New Button()
        BtnOper04 = New Button()
        TxtReslDet = New TextBox()
        TmrReloj = New Timer(components)
        TxtTiempo = New Label()
        TxtResParcial = New TextBox()
        LblResPar = New Label()
        LblSeg = New Label()
        BtnNum01 = New Button()
        BtnNum02 = New Button()
        BtnNum03 = New Button()
        BtnNum04 = New Button()
        BtnBorrar = New Button()
        BtnBorrarTodo = New Button()
        BtnResolver = New Button()
        BtnSiguiente = New Button()
        LblSolucion = New Label()
        LblIntentos = New Label()
        LblContIntentos = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' TxtNum01
        ' 
        TxtNum01.Enabled = False
        TxtNum01.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TxtNum01.Location = New Point(22, 21)
        TxtNum01.Name = "TxtNum01"
        TxtNum01.Size = New Size(76, 39)
        TxtNum01.TabIndex = 0
        ' 
        ' TxtNum02
        ' 
        TxtNum02.Enabled = False
        TxtNum02.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TxtNum02.Location = New Point(142, 21)
        TxtNum02.Name = "TxtNum02"
        TxtNum02.Size = New Size(76, 39)
        TxtNum02.TabIndex = 1
        ' 
        ' TxtNum03
        ' 
        TxtNum03.Enabled = False
        TxtNum03.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TxtNum03.Location = New Point(262, 21)
        TxtNum03.Name = "TxtNum03"
        TxtNum03.Size = New Size(76, 39)
        TxtNum03.TabIndex = 2
        ' 
        ' TxtNum04
        ' 
        TxtNum04.Enabled = False
        TxtNum04.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TxtNum04.Location = New Point(382, 21)
        TxtNum04.Name = "TxtNum04"
        TxtNum04.Size = New Size(76, 39)
        TxtNum04.TabIndex = 3
        ' 
        ' BtnInicio
        ' 
        BtnInicio.Location = New Point(12, 297)
        BtnInicio.Name = "BtnInicio"
        BtnInicio.Size = New Size(696, 43)
        BtnInicio.TabIndex = 4
        BtnInicio.Text = "Iniciar"
        BtnInicio.UseVisualStyleBackColor = True
        ' 
        ' LblOperador01
        ' 
        LblOperador01.AutoSize = True
        LblOperador01.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblOperador01.Location = New Point(104, 24)
        LblOperador01.Name = "LblOperador01"
        LblOperador01.Size = New Size(32, 32)
        LblOperador01.TabIndex = 5
        LblOperador01.Text = "O"
        ' 
        ' LblOperador02
        ' 
        LblOperador02.AutoSize = True
        LblOperador02.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblOperador02.Location = New Point(224, 24)
        LblOperador02.Name = "LblOperador02"
        LblOperador02.Size = New Size(32, 32)
        LblOperador02.TabIndex = 6
        LblOperador02.Text = "O"
        ' 
        ' LblOperador03
        ' 
        LblOperador03.AutoSize = True
        LblOperador03.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblOperador03.Location = New Point(344, 24)
        LblOperador03.Name = "LblOperador03"
        LblOperador03.Size = New Size(32, 32)
        LblOperador03.TabIndex = 7
        LblOperador03.Text = "O"
        ' 
        ' TxtResultado
        ' 
        TxtResultado.Enabled = False
        TxtResultado.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TxtResultado.Location = New Point(494, 21)
        TxtResultado.Name = "TxtResultado"
        TxtResultado.Size = New Size(214, 39)
        TxtResultado.TabIndex = 8
        ' 
        ' LblIgual
        ' 
        LblIgual.AutoSize = True
        LblIgual.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblIgual.Location = New Point(464, 24)
        LblIgual.Name = "LblIgual"
        LblIgual.Size = New Size(31, 32)
        LblIgual.TabIndex = 9
        LblIgual.Text = "="
        ' 
        ' BtnOper01
        ' 
        BtnOper01.Enabled = False
        BtnOper01.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnOper01.Location = New Point(117, 168)
        BtnOper01.Name = "BtnOper01"
        BtnOper01.Size = New Size(53, 47)
        BtnOper01.TabIndex = 14
        BtnOper01.Text = "+"
        BtnOper01.UseVisualStyleBackColor = True
        ' 
        ' BtnOper02
        ' 
        BtnOper02.Enabled = False
        BtnOper02.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnOper02.Location = New Point(179, 168)
        BtnOper02.Name = "BtnOper02"
        BtnOper02.Size = New Size(53, 47)
        BtnOper02.TabIndex = 15
        BtnOper02.Text = "-"
        BtnOper02.UseVisualStyleBackColor = True
        ' 
        ' BtnOper03
        ' 
        BtnOper03.Enabled = False
        BtnOper03.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnOper03.Location = New Point(250, 168)
        BtnOper03.Name = "BtnOper03"
        BtnOper03.Size = New Size(53, 47)
        BtnOper03.TabIndex = 16
        BtnOper03.Text = "*"
        BtnOper03.UseVisualStyleBackColor = True
        ' 
        ' BtnOper04
        ' 
        BtnOper04.Enabled = False
        BtnOper04.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnOper04.Location = New Point(327, 168)
        BtnOper04.Name = "BtnOper04"
        BtnOper04.Size = New Size(53, 47)
        BtnOper04.TabIndex = 17
        BtnOper04.Text = "/"
        BtnOper04.UseVisualStyleBackColor = True
        ' 
        ' TxtReslDet
        ' 
        TxtReslDet.Enabled = False
        TxtReslDet.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TxtReslDet.Location = New Point(269, 69)
        TxtReslDet.Name = "TxtReslDet"
        TxtReslDet.Size = New Size(439, 39)
        TxtReslDet.TabIndex = 19
        TxtReslDet.Visible = False
        ' 
        ' TmrReloj
        ' 
        TmrReloj.Interval = 1000
        ' 
        ' TxtTiempo
        ' 
        TxtTiempo.AutoSize = True
        TxtTiempo.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TxtTiempo.Location = New Point(427, 202)
        TxtTiempo.Name = "TxtTiempo"
        TxtTiempo.Size = New Size(42, 32)
        TxtTiempo.TabIndex = 25
        TxtTiempo.Text = "00"
        ' 
        ' TxtResParcial
        ' 
        TxtResParcial.Enabled = False
        TxtResParcial.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TxtResParcial.Location = New Point(494, 157)
        TxtResParcial.Name = "TxtResParcial"
        TxtResParcial.Size = New Size(214, 39)
        TxtResParcial.TabIndex = 26
        ' 
        ' LblResPar
        ' 
        LblResPar.AutoSize = True
        LblResPar.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblResPar.Location = New Point(401, 119)
        LblResPar.Name = "LblResPar"
        LblResPar.Size = New Size(210, 32)
        LblResPar.TabIndex = 27
        LblResPar.Text = "Resultado Parcial"
        ' 
        ' LblSeg
        ' 
        LblSeg.AutoSize = True
        LblSeg.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblSeg.Location = New Point(473, 201)
        LblSeg.Name = "LblSeg"
        LblSeg.Size = New Size(126, 32)
        LblSeg.TabIndex = 28
        LblSeg.Text = "Segundos"
        ' 
        ' BtnNum01
        ' 
        BtnNum01.Enabled = False
        BtnNum01.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnNum01.Location = New Point(118, 114)
        BtnNum01.Name = "BtnNum01"
        BtnNum01.Size = New Size(52, 48)
        BtnNum01.TabIndex = 29
        BtnNum01.Text = "0"
        BtnNum01.UseVisualStyleBackColor = True
        ' 
        ' BtnNum02
        ' 
        BtnNum02.Enabled = False
        BtnNum02.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnNum02.Location = New Point(179, 114)
        BtnNum02.Name = "BtnNum02"
        BtnNum02.Size = New Size(52, 48)
        BtnNum02.TabIndex = 30
        BtnNum02.Text = "0"
        BtnNum02.UseVisualStyleBackColor = True
        ' 
        ' BtnNum03
        ' 
        BtnNum03.Enabled = False
        BtnNum03.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnNum03.Location = New Point(251, 114)
        BtnNum03.Name = "BtnNum03"
        BtnNum03.Size = New Size(52, 48)
        BtnNum03.TabIndex = 31
        BtnNum03.Text = "0"
        BtnNum03.UseVisualStyleBackColor = True
        ' 
        ' BtnNum04
        ' 
        BtnNum04.Enabled = False
        BtnNum04.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        BtnNum04.Location = New Point(328, 114)
        BtnNum04.Name = "BtnNum04"
        BtnNum04.Size = New Size(52, 48)
        BtnNum04.TabIndex = 32
        BtnNum04.Text = "0"
        BtnNum04.UseVisualStyleBackColor = True
        ' 
        ' BtnBorrar
        ' 
        BtnBorrar.Enabled = False
        BtnBorrar.Location = New Point(12, 237)
        BtnBorrar.Name = "BtnBorrar"
        BtnBorrar.Size = New Size(75, 54)
        BtnBorrar.TabIndex = 33
        BtnBorrar.Text = "Borrar Ultimo Valor"
        BtnBorrar.UseVisualStyleBackColor = True
        ' 
        ' BtnBorrarTodo
        ' 
        BtnBorrarTodo.Enabled = False
        BtnBorrarTodo.Location = New Point(95, 237)
        BtnBorrarTodo.Name = "BtnBorrarTodo"
        BtnBorrarTodo.Size = New Size(75, 54)
        BtnBorrarTodo.TabIndex = 34
        BtnBorrarTodo.Text = "Borrar Todo"
        BtnBorrarTodo.UseVisualStyleBackColor = True
        ' 
        ' BtnResolver
        ' 
        BtnResolver.Enabled = False
        BtnResolver.Location = New Point(188, 237)
        BtnResolver.Name = "BtnResolver"
        BtnResolver.Size = New Size(75, 54)
        BtnResolver.TabIndex = 35
        BtnResolver.Text = "Resolver"
        BtnResolver.UseVisualStyleBackColor = True
        ' 
        ' BtnSiguiente
        ' 
        BtnSiguiente.Location = New Point(269, 237)
        BtnSiguiente.Name = "BtnSiguiente"
        BtnSiguiente.Size = New Size(75, 54)
        BtnSiguiente.TabIndex = 36
        BtnSiguiente.Text = "Siguiente"
        BtnSiguiente.UseVisualStyleBackColor = True
        BtnSiguiente.Visible = False
        ' 
        ' LblSolucion
        ' 
        LblSolucion.AutoSize = True
        LblSolucion.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblSolucion.Location = New Point(150, 72)
        LblSolucion.Name = "LblSolucion"
        LblSolucion.Size = New Size(120, 32)
        LblSolucion.TabIndex = 37
        LblSolucion.Text = "Solucion:"
        LblSolucion.Visible = False
        ' 
        ' LblIntentos
        ' 
        LblIntentos.AutoSize = True
        LblIntentos.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblIntentos.Location = New Point(418, 243)
        LblIntentos.Name = "LblIntentos"
        LblIntentos.Size = New Size(116, 32)
        LblIntentos.TabIndex = 38
        LblIntentos.Text = "Intentos:"
        ' 
        ' LblContIntentos
        ' 
        LblContIntentos.AutoSize = True
        LblContIntentos.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblContIntentos.Location = New Point(540, 243)
        LblContIntentos.Name = "LblContIntentos"
        LblContIntentos.Size = New Size(28, 32)
        LblContIntentos.TabIndex = 39
        LblContIntentos.Text = "0"
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(363, 252)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(345, 39)
        TextBox1.TabIndex = 40
        TextBox1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(720, 348)
        Controls.Add(LblContIntentos)
        Controls.Add(LblIntentos)
        Controls.Add(LblSolucion)
        Controls.Add(BtnSiguiente)
        Controls.Add(BtnResolver)
        Controls.Add(BtnBorrarTodo)
        Controls.Add(BtnBorrar)
        Controls.Add(BtnNum04)
        Controls.Add(BtnNum03)
        Controls.Add(BtnNum02)
        Controls.Add(BtnNum01)
        Controls.Add(LblSeg)
        Controls.Add(TxtResParcial)
        Controls.Add(TxtTiempo)
        Controls.Add(TxtReslDet)
        Controls.Add(BtnOper04)
        Controls.Add(BtnOper03)
        Controls.Add(BtnOper02)
        Controls.Add(BtnOper01)
        Controls.Add(LblIgual)
        Controls.Add(TxtResultado)
        Controls.Add(LblOperador03)
        Controls.Add(LblOperador02)
        Controls.Add(LblOperador01)
        Controls.Add(BtnInicio)
        Controls.Add(TxtNum04)
        Controls.Add(TxtNum03)
        Controls.Add(TxtNum02)
        Controls.Add(TxtNum01)
        Controls.Add(LblResPar)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtNum01 As TextBox
    Friend WithEvents TxtNum02 As TextBox
    Friend WithEvents TxtNum03 As TextBox
    Friend WithEvents TxtNum04 As TextBox
    Friend WithEvents BtnInicio As Button
    Friend WithEvents LblOperador01 As Label
    Friend WithEvents LblOperador02 As Label
    Friend WithEvents LblOperador03 As Label
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents LblIgual As Label
    Friend WithEvents BtnOper01 As Button
    Friend WithEvents BtnOper02 As Button
    Friend WithEvents BtnOper03 As Button
    Friend WithEvents BtnOper04 As Button
    Friend WithEvents TxtReslDet As TextBox
    Friend WithEvents TmrReloj As Timer
    Friend WithEvents TxtTiempo As Label
    Friend WithEvents TxtResParcial As TextBox
    Friend WithEvents LblResPar As Label
    Friend WithEvents LblSeg As Label
    Friend WithEvents BtnNum01 As Button
    Friend WithEvents BtnNum02 As Button
    Friend WithEvents BtnNum03 As Button
    Friend WithEvents BtnNum04 As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnBorrarTodo As Button
    Friend WithEvents BtnResolver As Button
    Friend WithEvents BtnSiguiente As Button
    Friend WithEvents LblSolucion As Label
    Friend WithEvents LblIntentos As Label
    Friend WithEvents LblContIntentos As Label
    Friend WithEvents TextBox1 As TextBox
End Class
