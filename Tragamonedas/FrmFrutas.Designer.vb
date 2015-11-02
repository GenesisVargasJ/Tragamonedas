<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFrutas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFrutas))
        Me.LblCreditos = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblApuesta = New System.Windows.Forms.Label()
        Me.LblGanancia = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblWeb = New System.Windows.Forms.LinkLabel()
        Me.BtnCreditos = New System.Windows.Forms.PictureBox()
        Me.BtnSalir = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnJugar = New System.Windows.Forms.PictureBox()
        Me.BtnApuesta = New System.Windows.Forms.PictureBox()
        Me.BtnApuestaMax = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        CType(Me.BtnCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnJugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnApuesta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnApuestaMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCreditos
        '
        Me.LblCreditos.AutoSize = True
        Me.LblCreditos.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.LblCreditos.Font = New System.Drawing.Font("Segoe WP Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCreditos.Location = New System.Drawing.Point(110, 31)
        Me.LblCreditos.Name = "LblCreditos"
        Me.LblCreditos.Size = New System.Drawing.Size(18, 20)
        Me.LblCreditos.TabIndex = 5
        Me.LblCreditos.Text = "0"
        '
        'Timer1
        '
        '
        'LblApuesta
        '
        Me.LblApuesta.AutoSize = True
        Me.LblApuesta.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.LblApuesta.Font = New System.Drawing.Font("Segoe WP Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApuesta.Location = New System.Drawing.Point(110, 83)
        Me.LblApuesta.Name = "LblApuesta"
        Me.LblApuesta.Size = New System.Drawing.Size(16, 20)
        Me.LblApuesta.TabIndex = 10
        Me.LblApuesta.Text = "1"
        '
        'LblGanancia
        '
        Me.LblGanancia.AutoSize = True
        Me.LblGanancia.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.LblGanancia.Font = New System.Drawing.Font("Segoe WP Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGanancia.Location = New System.Drawing.Point(126, 133)
        Me.LblGanancia.Name = "LblGanancia"
        Me.LblGanancia.Size = New System.Drawing.Size(18, 20)
        Me.LblGanancia.TabIndex = 11
        Me.LblGanancia.Text = "0"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe WP Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(458, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 130)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "SI TE QUE QUEDAS SIN CRÉDITOS PUEDES HACER CLICK Y OBTENER 20 MÁS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Segoe WP Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(453, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 42)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "By: Genesis Vargas J"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWeb
        '
        Me.LblWeb.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblWeb.AutoSize = True
        Me.LblWeb.Font = New System.Drawing.Font("Segoe WP Black", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LblWeb.LinkColor = System.Drawing.Color.White
        Me.LblWeb.Location = New System.Drawing.Point(454, 353)
        Me.LblWeb.Name = "LblWeb"
        Me.LblWeb.Size = New System.Drawing.Size(199, 20)
        Me.LblWeb.TabIndex = 22
        Me.LblWeb.TabStop = True
        Me.LblWeb.Text = "www.genesisvargasj.com"
        Me.LblWeb.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'BtnCreditos
        '
        Me.BtnCreditos.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BtnCreditos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCreditos.Image = Global.Tragamonedas.My.Resources.Resources.btn5
        Me.BtnCreditos.Location = New System.Drawing.Point(585, 237)
        Me.BtnCreditos.Name = "BtnCreditos"
        Me.BtnCreditos.Size = New System.Drawing.Size(59, 55)
        Me.BtnCreditos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCreditos.TabIndex = 19
        Me.BtnCreditos.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Transparent
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Image = Global.Tragamonedas.My.Resources.Resources.btn41
        Me.BtnSalir.Location = New System.Drawing.Point(678, 321)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(100, 55)
        Me.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSalir.TabIndex = 17
        Me.BtnSalir.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.Tragamonedas.My.Resources.Resources.info
        Me.PictureBox9.Location = New System.Drawing.Point(211, 22)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(177, 141)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 16
        Me.PictureBox9.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Tragamonedas.My.Resources.Resources.ima2
        Me.PictureBox7.Location = New System.Drawing.Point(22, 122)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(146, 41)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 14
        Me.PictureBox7.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(67, 192)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(161, 192)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(86, 86)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Black
        Me.PictureBox3.Location = New System.Drawing.Point(255, 192)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(86, 86)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'BtnJugar
        '
        Me.BtnJugar.BackColor = System.Drawing.Color.Transparent
        Me.BtnJugar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnJugar.Image = CType(resources.GetObject("BtnJugar.Image"), System.Drawing.Image)
        Me.BtnJugar.Location = New System.Drawing.Point(293, 311)
        Me.BtnJugar.Name = "BtnJugar"
        Me.BtnJugar.Size = New System.Drawing.Size(95, 65)
        Me.BtnJugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnJugar.TabIndex = 9
        Me.BtnJugar.TabStop = False
        '
        'BtnApuesta
        '
        Me.BtnApuesta.BackColor = System.Drawing.Color.Transparent
        Me.BtnApuesta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnApuesta.Image = CType(resources.GetObject("BtnApuesta.Image"), System.Drawing.Image)
        Me.BtnApuesta.Location = New System.Drawing.Point(22, 311)
        Me.BtnApuesta.Name = "BtnApuesta"
        Me.BtnApuesta.Size = New System.Drawing.Size(95, 65)
        Me.BtnApuesta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnApuesta.TabIndex = 8
        Me.BtnApuesta.TabStop = False
        '
        'BtnApuestaMax
        '
        Me.BtnApuestaMax.BackColor = System.Drawing.Color.Transparent
        Me.BtnApuestaMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnApuestaMax.Image = CType(resources.GetObject("BtnApuestaMax.Image"), System.Drawing.Image)
        Me.BtnApuestaMax.Location = New System.Drawing.Point(123, 311)
        Me.BtnApuestaMax.Name = "BtnApuestaMax"
        Me.BtnApuestaMax.Size = New System.Drawing.Size(95, 65)
        Me.BtnApuestaMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnApuestaMax.TabIndex = 7
        Me.BtnApuestaMax.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Tragamonedas.My.Resources.Resources.logo
        Me.PictureBox4.Location = New System.Drawing.Point(458, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(320, 157)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(22, 180)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(366, 111)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Tragamonedas.My.Resources.Resources.ima1
        Me.PictureBox6.Location = New System.Drawing.Point(22, 22)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(171, 41)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 13
        Me.PictureBox6.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Tragamonedas.My.Resources.Resources.ima3
        Me.PictureBox8.Location = New System.Drawing.Point(22, 72)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(138, 41)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 15
        Me.PictureBox8.TabStop = False
        '
        'FrmFrutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.LblWeb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCreditos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.LblGanancia)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.LblApuesta)
        Me.Controls.Add(Me.BtnJugar)
        Me.Controls.Add(Me.BtnApuesta)
        Me.Controls.Add(Me.BtnApuestaMax)
        Me.Controls.Add(Me.LblCreditos)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox8)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFrutas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmFrutas"
        CType(Me.BtnCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnJugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnApuesta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnApuestaMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblCreditos As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnJugar As PictureBox
    Friend WithEvents BtnApuesta As PictureBox
    Friend WithEvents BtnApuestaMax As PictureBox
    Friend WithEvents LblApuesta As Label
    Friend WithEvents LblGanancia As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents BtnSalir As PictureBox
    Friend WithEvents BtnCreditos As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblWeb As LinkLabel
End Class
