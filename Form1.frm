VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Form1 
   Caption         =   "Sumatoria Fácil"
   ClientHeight    =   7350
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   5415
   BeginProperty Font 
      Name            =   "Arial"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   Moveable        =   0   'False
   ScaleHeight     =   7350
   ScaleWidth      =   5415
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture2 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   255
      Left            =   1080
      ScaleHeight     =   225
      ScaleWidth      =   585
      TabIndex        =   8
      Top             =   3240
      Width           =   615
   End
   Begin VB.PictureBox Picture1 
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      ForeColor       =   &H80000008&
      Height          =   15
      Left            =   1320
      ScaleHeight     =   0
      ScaleWidth      =   1305
      TabIndex        =   7
      Top             =   2760
      Width           =   1335
   End
   Begin MSComctlLib.ImageList imageS 
      Left            =   3840
      Top             =   120
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   48
      ImageHeight     =   48
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   3
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":08CA
            Key             =   ""
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":25A4
            Key             =   ""
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "Form1.frx":3D36
            Key             =   ""
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.ListView icons 
      Height          =   1215
      Left            =   120
      TabIndex        =   5
      Top             =   120
      Width           =   5175
      _ExtentX        =   9128
      _ExtentY        =   2143
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      OLEDragMode     =   1
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      OLEDragMode     =   1
      NumItems        =   0
   End
   Begin VB.CommandButton cmdCalcular 
      Caption         =   "Calcular"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4200
      TabIndex        =   4
      Top             =   1440
      Width           =   1095
   End
   Begin MSComctlLib.ListView List 
      Height          =   5295
      Left            =   120
      TabIndex        =   3
      Top             =   1920
      Width           =   5175
      _ExtentX        =   9128
      _ExtentY        =   9340
      View            =   3
      LabelEdit       =   1
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      HideColumnHeaders=   -1  'True
      FullRowSelect   =   -1  'True
      _Version        =   393217
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      NumItems        =   0
   End
   Begin VB.TextBox txtNum 
      Appearance      =   0  'Flat
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   1080
      MaxLength       =   10
      TabIndex        =   0
      Top             =   1440
      Width           =   1815
   End
   Begin VB.CommandButton cmdAgregar 
      Caption         =   "Agregar"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3000
      TabIndex        =   2
      Top             =   1440
      Width           =   1095
   End
   Begin VB.TextBox txtTemp 
      Height          =   315
      Left            =   0
      TabIndex        =   6
      Top             =   0
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.Label Label1 
      Alignment       =   1  'Right Justify
      Appearance      =   0  'Flat
      BackColor       =   &H80000005&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Numero:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000008&
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   1440
      Width           =   975
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Dim longI As Double
Dim sumaT As Double
Private Sub cmdAgregar_Click()
Agregar
End Sub
Public Function getCar(i As Double) As String
    If i > Len(txtTemp) Then Exit Function
    If i <= 0 Then Exit Function
    txtTemp.SelStart = i - 1
    txtTemp.SelLength = 1
    getCar = txtTemp.SelText
End Function

Private Sub cmdCalcular_Click()
cAlcular
End Sub

Private Sub Form_Load()
Me.Top = 0
Me.Left = 0
Me.Width = Screen.Width
Me.Height = Screen.Height

Picture1.Height = 15
Picture2.Height = 15
Picture1.Visible = False
Picture2.Visible = False

Dim i As Double
For i = 1 To 12
    List.ColumnHeaders.Add , , , 350
Next i
icons.icons = imageS
icons.ListItems.Add , , "Nuevo", 1
icons.ListItems.Add
icons.ListItems.Add , , "Acerca De...", 2
icons.ListItems.Add
icons.ListItems.Add , , "Salir", 3
End Sub

Private Sub Form_Resize()
icons.Left = 100
List.Left = 100
icons.Width = Me.ScaleWidth - 200
List.Width = Me.ScaleWidth - 200
List.Height = Me.ScaleHeight - List.Top - 100
End Sub

Private Sub icons_DblClick()
If icons.SelectedItem.Text = "Salir" Then End
If icons.SelectedItem.Text = "Acerca De..." Then mensaJe
If icons.SelectedItem.Text = "Nuevo" Then Limpiar
End Sub


Private Sub txtNum_KeyPress(KeyAscii As Integer)
If KeyAscii = 13 Then Agregar

End Sub

Public Sub Agregar()
If cmdCalcular.Enabled = False Then Exit Sub
If IsNumeric(txtNum) Then
    If List.ListItems.Count = 10 Then
        MsgBox "Ya llego al limite", vbExclamation, "Errorsillo"
        txtNum = ""
        Exit Sub
    End If
    If longI <> 0 And Len(txtNum) > longI Then
        MsgBox "Debe ser de menor o igual longitud", vbExclamation, "Errorsillo"
        txtNum = ""
        txtNum.SetFocus
        Exit Sub
    End If
    If longI = 0 Then longI = Len(txtNum)
    Dim i As Double
    sumaT = sumaT + Val(txtNum)
    List.ListItems.Add , , ""
    List.ListItems(List.ListItems.Count).ListSubItems.Add , , ""
    
    i = 1
    While i <= (longI - Len(txtNum))
        List.ListItems(List.ListItems.Count).ListSubItems.Add , , ""
        i = i + 1
    Wend
    For i = 1 To Len(txtNum)
        List.ListItems(List.ListItems.Count).ListSubItems.Add , , getChar(i)
    Next i
    txtNum = ""
Else
    MsgBox "Escribir Solo Numeros", vbExclamation, "Errorsillo"
End If
End Sub

Public Function getChar(n As Double) As String
    txtNum.SelStart = n - 1
    txtNum.SelLength = 1
    getChar = txtNum.SelText
End Function



Public Sub Limpiar()
Picture1.Visible = False
Picture2.Visible = False
sumaT = 0
cmdCalcular.Enabled = True
longI = 0
txtNum = ""
List.ListItems.Clear
txtNum.SetFocus
End Sub

Public Sub cAlcular()
If List.ListItems.Count > 1 Then
    cmdCalcular.Enabled = False
    Dim i, e As Double
    'sumar columna y acomodar
    Dim suma(10) As Double
    Dim longiX As Double
    longiX = longI
    While longiX > 0
        For i = 1 To List.ListItems.Count
            suma(longiX) = suma(longiX) + Val(List.ListItems(i).ListSubItems(longiX + 1).Text)
        Next i
        longiX = longiX - 1
    Wend
    Picture1.Visible = True
    Picture1.Left = List.Left + 500
    'Picture1.Width = 700 + 100
    Dim sum As Double
    sum = 800
    For i = 2 To longI
        sum = sum + 350
    Next i
    Picture1.Width = sum

    sum = List.Top + 700
    For i = 3 To List.ListItems.Count
        sum = sum + 300
    Next i
    Picture1.Top = sum
    
    'para el top de picture 2
    Dim countT As Double
    countT = List.ListItems.Count
    '''''''''''''''''''''''''
    
    List.ListItems.Add , , ""

    For e = 1 To longI
        List.ListItems.Add , , ""
        For i = 1 To longI + 1
            If i = (longI + 1) - e + 1 Then
                Dim sumax As Double
                sumax = suma(longI - e + 1)
                If sumax > 9 Then
                txtTemp = sumax
                    List.ListItems(List.ListItems.Count).ListSubItems(longI - e + 1).Text = getCar(1)
                    List.ListItems(List.ListItems.Count).ListSubItems.Add , , getCar(2)
                Else
                    List.ListItems(List.ListItems.Count).ListSubItems.Add , , sumax
                End If
                
            Else
                List.ListItems(List.ListItems.Count).ListSubItems.Add , , ""
            End If
        Next i
    Next e
    'calcular y desplegar resultado
    Picture2.Visible = True
    Picture2.Left = Picture1.Left
    Picture2.Width = Picture1.Width
    
    sum = List.Top + 1250
    For i = 2 To longI
        sum = sum + 300
    Next i
    For i = 3 To countT
        sum = sum + 300
    Next i
    Picture2.Top = sum

    List.ListItems.Add , , ""
    List.ListItems.Add , , ""
    txtTemp = sumaT
    Dim x As Double
    For x = 1 To longI + 1
        List.ListItems(List.ListItems.Count).ListSubItems.Add , , ""
    Next x
    longiX = longI + 1
    Dim longixX As Double
    longixX = Len(txtTemp)
    While longiX > 0
        List.ListItems(List.ListItems.Count).ListSubItems(longiX).Text = getCar(longixX)
        longixX = longixX - 1
        longiX = longiX - 1
    Wend
End If

End Sub

Public Sub mensaJe()
MsgBox "Programadores:" & vbCrLf & "Ing. Javier Mendoza Navarrete" & vbCrLf & "Tec. Salvador Guerrero Varela" & vbCrLf & "" & vbCrLf & "18 de Enero del 2007", vbInformation, "Sumatoria Fácil"
End Sub
