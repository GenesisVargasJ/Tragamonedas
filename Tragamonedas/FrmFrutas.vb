Imports System.IO

Public Class FrmFrutas
    'variables enteras para guardar los numeros aleatorios de las 3 imágenes, el falso tiempo, los créditos, la apuesta y la ganancia
    Dim img1, img2, img3, time, points, bet, win As Integer
    'array que va a guardar temporalmente los nombres de las imágenes de frutas
    Dim imagen(5) As String

    'en el método constructor
    Sub New()
        InitializeComponent()
        'colocar los 4 lados extremos del form en curvos para una mejor apariencia (40 es el "border radius")
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), -90, 90)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.CloseFigure()
        Me.Region = New Region(p)
        'llenamos el array
        SetArray()
        'asignar 15 créditos
        points = 15
        'asignar 0 en la apuesta
        bet = 1
        'colocar los créditos en el label
        LblCreditos.Text = points
    End Sub

    'al hacer click en el botón jugar
    Private Sub BtnGirar_Click(sender As Object, e As EventArgs) Handles BtnJugar.Click
        'verificar si la apuesta es diferente de cero
        If (bet <> 0) Then
            'verificar si los créditos son diferente de cero
            If (points > 0) Then
                'asignar 17 al "falso tiempo"
                time = 17
                'reproducir sonido jugar
                My.Computer.Audio.Play(My.Resources.play, AudioPlayMode.Background)
                'iniciar timer
                Timer1.Start()
            End If
        End If
    End Sub

    'al hacer click en el botón de apuesta 1
    Private Sub BtnApuesta_Click(sender As Object, e As EventArgs) Handles BtnApuesta.Click
        'asignar 1 en la apuesta
        bet = 1
        'colocar la apuesta en el label
        LblApuesta.Text = bet
    End Sub

    'al hacer click en el botón de apuesta máxima
    Private Sub BtnApuestaMax_Click(sender As Object, e As EventArgs) Handles BtnApuestaMax.Click
        'asignar 10 en la apuesta
        bet = 10
        'colocar la apuesta en el label
        LblApuesta.Text = bet
    End Sub

    'al hacer click en el botón de créditos extras
    Private Sub BtnCreditos_Click(sender As Object, e As EventArgs) Handles BtnCreditos.Click
        'verificar si los créditos son igual a cero
        If (points = 0) Then
            'asignar 20 créditos
            points = 20
            'reproducir sonido coin
            My.Computer.Audio.Play(My.Resources.coin, AudioPlayMode.Background)
            'colocar los créditos en el label
            LblCreditos.Text = points
        End If
    End Sub

    'al hacer click en el botón de salir
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        'finalizar programa
        End
    End Sub

    'al hacer click en el link
    Private Sub LblWeb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblWeb.LinkClicked
        'abrir página web
        Process.Start("http://" & LblWeb.Text)
    End Sub

    Sub GenerateImages()
        'asignar a las variables imgs un número aleatorio de 0 a 5 (son 6 imágenes posibles)
        img1 = Int(5 * Rnd())
        img2 = Int(5 * Rnd())
        img3 = Int(5 * Rnd())
        'asignar la función GetImage con el parámetro img correspondiente a cada picturebox
        PictureBox1.Image = GetImage(img1)
        PictureBox2.Image = GetImage(img2)
        PictureBox3.Image = GetImage(img3)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'verificar si el "tiempo falso" es mayor o igual que cero
        If time >= 0 Then
            'llamar el método GenerateImages para mostrar las imágenes aleatorias
            GenerateImages()
            'descontar el "tiempo falso" 
            time -= 1
        Else
            'parar el timer
            Timer1.Stop()
            'llamar el método GetPoints para mostrar puntaje
            GetPoints()
        End If
    End Sub

    Sub GetPoints()
        'verificar si las tres imágenes son iguales
        If (img1 = img2 And img1 = img3) Then
            'verificar si las imágenes son rojas (éstas en su nombre archivo terminan así: xxxxx-rojo.png)
            If (GetNameImage(img1).Contains("-rojo")) Then
                'asignar lo que se aposto por 5 a la ganancia
                win = (bet * 5)
            Else
                'asignar lo que se aposto por 3 a la ganancia
                win = (bet * 3)
            End If
            'aumentar los créditos con el valor de la ganancia
            points += win
            'reproducir sonido win
            My.Computer.Audio.Play(My.Resources.win, AudioPlayMode.Background)
            'verificar si dos de las tres imágenes estan juntas y son del mismo tipo
        ElseIf ((img1 = img2 And img1 <> img3) Or (img2 = img3 And img1 <> img3)) Then
            'asignar 2 a la ganancia
            win = 2
            'aumentar los créditos con el valor de la ganancia
            points += win
            'reproducir sonido win
            My.Computer.Audio.Play(My.Resources.win, AudioPlayMode.Background)
        Else
            'verificar si los créditos son menores que la apuesta
            If (points < bet) Then
                'asignar 0 a la ganancia
                win = 0
                'asignar 0 a los créditos
                points = 0
            Else
                'asignar 0 a la ganancia
                win = 0
                'disminuir los créditos con el valor de la ganancia
                points -= bet
            End If
        End If
        'colocar los créditos en el label
        LblCreditos.Text = points
        'colocar la ganancia en el label
        LblGanancia.Text = win
    End Sub

    'función que recibe como parámetro el índice para colocar al array y retorna una imagen desde el archivo en la carpeta: Frutas
    Function GetImage(index As Integer) As Image
        GetImage = Image.FromFile(Application.StartupPath & "\Frutas\" & imagen(index))
    End Function

    'función que recibe como parámetro el índice para colocar al array y retorna el nombre la imagen
    Function GetNameImage(index As Integer) As String
        GetNameImage = imagen(index)
    End Function

    'método que recorre todas las imágenes png de la carpeta Frutas y las asigna cada una al array cambiando el índica, claro está
    Sub SetArray()
        Dim di As New DirectoryInfo(Application.StartupPath & "\Frutas")
        Dim aryFi As FileInfo() = di.GetFiles("*.png")
        Dim fi As FileInfo
        Dim i As Integer = 0
        For Each fi In aryFi
            imagen(i) = fi.Name
            i += 1
        Next
    End Sub
End Class