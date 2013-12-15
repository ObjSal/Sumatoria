Option Strict Off
Option Explicit On
Friend Class Form1
	Inherits System.Windows.Forms.Form
	Dim longI As Double
	Dim sumaT As Double
	Private Sub cmdAgregar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAgregar.Click
		Agregar()
	End Sub
	Public Function getCar(ByRef i As Double) As String
        If i > Len(txtTemp.Text) Then Return ""
        If i <= 0 Then Return ""
		txtTemp.SelectionStart = i - 1
		txtTemp.SelectionLength = 1
		getCar = txtTemp.SelectedText
	End Function
	
	Private Sub cmdCalcular_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalcular.Click
		cAlcular()
	End Sub
	
	Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Top = 0
		Me.Left = 0
		Me.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
		Me.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height
		
		Picture1.Height = VB6.TwipsToPixelsY(15)
		Picture2.Height = VB6.TwipsToPixelsY(15)
		Picture1.Visible = False
		Picture2.Visible = False
		
		Dim i As Double
		For i = 1 To 12
			List.Columns.Add("", "", CInt(VB6.TwipsToPixelsX(350)))
		Next i
		icons.LargeImageList = imageS
		'UPGRADE_WARNING: Lower bound of collection icons.ListItems.ImageList has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        icons.Items.Add("Nuevo", 0)
		icons.Items.Add("")
		'UPGRADE_WARNING: Lower bound of collection icons.ListItems.ImageList has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        icons.Items.Add("Acerca De...", 1)
		icons.Items.Add("")
		'UPGRADE_WARNING: Lower bound of collection icons.ListItems.ImageList has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        icons.Items.Add("Salir", 2)
	End Sub
	
	'UPGRADE_WARNING: Event Form1.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Form1_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		icons.Left = VB6.TwipsToPixelsX(100)
		List.Left = VB6.TwipsToPixelsX(100)
		icons.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.ClientRectangle.Width) - 200)
		List.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.ClientRectangle.Width) - 200)
		List.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.ClientRectangle.Height) - VB6.PixelsToTwipsY(List.Top) - 100)
	End Sub
	
	Private Sub icons_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles icons.DoubleClick
		If icons.FocusedItem.Text = "Salir" Then End
		If icons.FocusedItem.Text = "Acerca De..." Then mensaJe()
		If icons.FocusedItem.Text = "Nuevo" Then Limpiar()
	End Sub
	
	
	Private Sub txtNum_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNum.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then Agregar()
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Public Sub Agregar()
		If cmdCalcular.Enabled = False Then Exit Sub
		Dim i As Double
		If IsNumeric(txtNum.Text) Then
			If List.Items.Count = 10 Then
				MsgBox("Ya llego al limite", MsgBoxStyle.Exclamation, "Errorsillo")
				txtNum.Text = ""
				Exit Sub
			End If
			If longI <> 0 And Len(txtNum.Text) > longI Then
				MsgBox("Debe ser de menor o igual longitud", MsgBoxStyle.Exclamation, "Errorsillo")
				txtNum.Text = ""
				txtNum.Focus()
				Exit Sub
			End If
			If longI = 0 Then longI = Len(txtNum.Text)
			sumaT = sumaT + Val(txtNum.Text)
			List.Items.Add("")
			'UPGRADE_WARNING: Lower bound of collection List.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            List.Items.Item(List.Items.Count - 1).SubItems.Add("")
			
			i = 1
			While i <= (longI - Len(txtNum.Text))
				'UPGRADE_WARNING: Lower bound of collection List.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                List.Items.Item(List.Items.Count - 1).SubItems.Add("")
				i = i + 1
			End While
			For i = 1 To Len(txtNum.Text)
				'UPGRADE_WARNING: Lower bound of collection List.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                List.Items.Item(List.Items.Count - 1).SubItems.Add(getChar_Renamed(i))
			Next i
			txtNum.Text = ""
		Else
			MsgBox("Escribir Solo Numeros", MsgBoxStyle.Exclamation, "Errorsillo")
		End If
	End Sub
	
	'UPGRADE_NOTE: getChar was upgraded to getChar_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Function getChar_Renamed(ByRef n As Double) As String
		txtNum.SelectionStart = n - 1
		txtNum.SelectionLength = 1
		getChar_Renamed = txtNum.SelectedText
	End Function
	
	
	
	Public Sub Limpiar()
		Picture1.Visible = False
		Picture2.Visible = False
		sumaT = 0
		cmdCalcular.Enabled = True
		longI = 0
		txtNum.Text = ""
		List.Items.Clear()
		txtNum.Focus()
	End Sub
	
	Public Sub cAlcular()
		Dim suma(10) As Double
		Dim longiX As Double
		Dim sum As Double
		Dim countT As Double
		Dim sumax As Double
		Dim x As Double
        Dim longixX As Double
		Dim i As Object
        Dim e As Integer
		If List.Items.Count > 1 Then
			cmdCalcular.Enabled = False
			'sumar columna y acomodar
			longiX = longI
			While longiX > 0
				For i = 1 To List.Items.Count
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: Lower bound of collection List.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
					'UPGRADE_WARNING: Lower bound of collection List.ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    suma(longiX) = suma(longiX) + Val(List.Items.Item(i).SubItems.Item(Convert.ToInt32(longiX + 1)).Text)
				Next i
				longiX = longiX - 1
			End While
			Picture1.Visible = True
			Picture1.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(List.Left) + 500)
			'Picture1.Width = 700 + 100
			sum = 800
			For i = 2 To longI
				sum = sum + 350
			Next i
			Picture1.Width = VB6.TwipsToPixelsX(sum)
			
			sum = VB6.PixelsToTwipsY(List.Top) + 700
			For i = 3 To List.Items.Count
				sum = sum + 300
			Next i
			Picture1.Top = VB6.TwipsToPixelsY(sum)
			
			'para el top de picture 2
			countT = List.Items.Count
			'''''''''''''''''''''''''
			
			List.Items.Add("")
			
			For e = 1 To longI
				List.Items.Add("")
				For i = 1 To longI + 1
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If i = (longI + 1) - e + 1 Then
						sumax = suma(longI - e + 1)
						If sumax > 9 Then
							txtTemp.Text = CStr(sumax)
							'UPGRADE_WARNING: Lower bound of collection List.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
							'UPGRADE_WARNING: Lower bound of collection List.ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                            List.Items.Item(List.Items.Count() - 1).SubItems.Item(Convert.ToInt32(longI - e)).Text = getCar(1)
                            'UPGRADE_WARNING: Lower bound of collection List.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
							List.Items.Item(List.Items.Count).SubItems.Add(getCar(2))
						Else
							'UPGRADE_WARNING: Lower bound of collection List.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
							List.Items.Item(List.Items.Count).SubItems.Add(CStr(sumax))
						End If
						
					Else
						'UPGRADE_WARNING: Lower bound of collection List.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
						List.Items.Item(List.Items.Count).SubItems.Add("")
					End If
				Next i
			Next e
			'calcular y desplegar resultado
			Picture2.Visible = True
			Picture2.Left = Picture1.Left
			Picture2.Width = Picture1.Width
			
			sum = VB6.PixelsToTwipsY(List.Top) + 1250
			For i = 2 To longI
				sum = sum + 300
			Next i
			For i = 3 To countT
				sum = sum + 300
			Next i
			Picture2.Top = VB6.TwipsToPixelsY(sum)
			
			List.Items.Add("")
			List.Items.Add("")
			txtTemp.Text = CStr(sumaT)
			For x = 1 To longI + 1
				'UPGRADE_WARNING: Lower bound of collection List.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				List.Items.Item(List.Items.Count).SubItems.Add("")
			Next x
			longiX = longI + 1
			longixX = Len(txtTemp.Text)
			While longiX > 0
				'UPGRADE_WARNING: Lower bound of collection List.ListItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
				'UPGRADE_WARNING: Lower bound of collection List.ListItems().ListSubItems has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                List.Items.Item(List.Items.Count).SubItems.Item(Convert.ToInt32(longiX)).Text = getCar(longixX)
				longixX = longixX - 1
				longiX = longiX - 1
			End While
		End If
		
	End Sub
	
	Public Sub mensaJe()
		MsgBox("Programadores:" & vbCrLf & "Ing. Javier Mendoza Navarrete" & vbCrLf & "Tec. Salvador Guerrero Varela" & vbCrLf & "" & vbCrLf & "18 de Enero del 2007", MsgBoxStyle.Information, "Sumatoria Fácil")
	End Sub
End Class