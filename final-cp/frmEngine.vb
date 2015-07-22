'****************************************************************************** 
' PROGRAM: Crystal's Airline Registration Engine
' AUTHOR: Crystal Pendergrass
' DATE: 4 May 2015
' PURPOSE: Crystal's Airline Registration Engine allows the user to select a
' a flight and enter personal details and ticket holder details.  This 
' information is added to a database.  The user can also search for a ticket holder
' and view the ticket holder details.  The user can also delete a ticket holder,
' freeing the ticket holder's seat
'******************************************************************************

Imports System.Data
Imports System.Data.OleDb
Public Class frmEngine
    Dim theTextBoxesFirstName As List(Of TextBox)
    Dim theTextBoxesLastName As List(Of TextBox)
    Dim theSeatComboBoxes As List(Of ComboBox)

    Dim intNumberOfTickets As Integer
    Dim intFlightID As Integer
    Dim intCustomerID As Integer

    Public dr As OleDbDataReader
    Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=care.accdb")

    '****************************************************************************** 
    'When the form is loaded the combobox to select the origin city is visible
    '******************************************************************************
    Private Sub frmEngine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOriginCbo(cboOriginCity, "FLIGHT", "FLIGHT_ORIGIN")
    End Sub

    '****************************************************************************** 
    'When the origin city is selected, the combobox for the destination city is 
    'displayed
    '******************************************************************************
    Private Sub cboOriginCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOriginCity.SelectedIndexChanged
        Dim str As String = cboOriginCity.SelectedItem
        LoadDestinationCbo(cboDestinationCity, "FLIGHT", "FLIGHT_DESTINATION", "FLIGHT_ORIGIN", str)
        cboDestinationCity.Visible = True
    End Sub

    '****************************************************************************** 
    'When the destination city is selected, the combobox for the flight dates is
    'displayed
    '******************************************************************************
    Private Sub cboDestinationCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDestinationCity.SelectedIndexChanged

        Dim objCmd As New Data.OleDb.OleDbCommand
        Dim objRdr As Data.OleDb.OleDbDataReader
        Dim TableName As String = ""
        Dim query As String = ""
        Dim cbo As ComboBox = Nothing
        Dim origin As String = cboOriginCity.SelectedItem
        Dim destination As String = cboDestinationCity.SelectedItem
        Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=care.accdb")
            con.Open()
            query = "SELECT DISTINCT FLIGHT_DEPARTURE FROM FLIGHT WHERE FLIGHT_ORIGIN = '" & origin & "' AND FLIGHT_DESTINATION = '" & destination & "'"
            TableName = "FLIGHT_DEPARTURE"
            cbo = cboFlightTime
            objCmd.Connection = con
            objCmd.CommandText = query
            objRdr = objCmd.ExecuteReader
            cbo.Items.Clear()
            If objRdr.HasRows Then
                Do While objRdr.Read
                    cbo.Items.Add(objRdr.GetValue(0))
                Loop
            End If
            objRdr.Close()
        End Using
        cboFlightTime.Visible = True
    End Sub

    '****************************************************************************** 
    'When the flight time is selected, the combobox for the number of tickets 
    'the user would like to purchase is displayed
    'Also the id of the flight is determined
    '******************************************************************************
    Private Sub cboFlightTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFlightTime.SelectedIndexChanged
        intFlightID = getFlightID()
        Dim intFlightSeatsOpen As Integer = getSeatsAvailable(intFlightID)

        If intFlightSeatsOpen > 5 Then
            cboNumberOfTickets.Items.Add(1)
            cboNumberOfTickets.Items.Add(2)
            cboNumberOfTickets.Items.Add(3)
            cboNumberOfTickets.Items.Add(4)
            cboNumberOfTickets.Items.Add(5)
        Else
            For intCounter = 1 To intFlightSeatsOpen
                cboNumberOfTickets.Items.Add(intCounter)
            Next
        End If

        cboNumberOfTickets.Visible = True
    End Sub

    '****************************************************************************** 
    'When the number of tickets is selected the button to select the flight is 
    'displayed
    '******************************************************************************
    Private Sub cboNumberOfTickets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNumberOfTickets.SelectedIndexChanged
        btnSelect.Visible = True
    End Sub


    '****************************************************************************** 
    'When the user pressed the select flight button, the reminder of the form
    'which allows the user to enter personal information (name, address, etc) 
    'and the names and seat choice to associated with each ticket.
    'the select flight and clear selection and all flight details are disabled
    'and cannot be changed
    '******************************************************************************
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If (IsNothing(cboOriginCity.SelectedItem) Or IsNothing(cboDestinationCity.SelectedItem) Or IsNothing(cboFlightTime.SelectedItem) Or IsNothing(cboNumberOfTickets.SelectedItem)) Then
            MsgBox("One of your flight selections is invalid.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Invalid Flight Detail(s)")
        Else
            txtCustomerFirstName.Visible = True
            txtCustomerLastName.Visible = True
            txtCustomerStreetAddress.Visible = True
            txtCustomerCity.Visible = True
            cboCustomerState.Visible = True
            txtCustomerPhone.Visible = True
            txtCustomerEmail.Visible = True

            lblFLightInfo.Visible = True
            lblCustomerInfo.Visible = True
            lblTicketHolder.Visible = True
            lblTHFirstName.Visible = True
            lblTHLastName.Visible = True
            lblTHSeat.Visible = True

            chkPurchaserIsTH.Visible = True

            cboOriginCity.Enabled = False
            cboDestinationCity.Enabled = False
            cboFlightTime.Enabled = False
            cboNumberOfTickets.Enabled = False

            btnSelect.Enabled = False
            btnPurchase.Visible = True

            intNumberOfTickets = cboNumberOfTickets.SelectedItem
            SetUpTextBoxesFirstName()
            SetUpTextBoxesLastName()
            SetUpSeatSelection()

        End If
    End Sub

    '****************************************************************************** 
    'The following are methods to populate the origin city, destination city and
    'flight date comboboxes.
    'It was my intention to generalize these methods so I could use them in 
    'greater situations, but that didn't work out
    'modified from https://social.msdn.microsoft.com/Forums/vstudio/en-US/0ab83f60-7482-4746-aeae-525e894f3de3/populating-combobox-from-ms-access?forum=vbgeneral
    '******************************************************************************
    Private Sub LoadOriginCbo(ByRef cb As ComboBox, ByVal strTableName As String, ByVal strColumnName As String)
        Dim objCmd As New Data.OleDb.OleDbCommand
        Dim objRdr As Data.OleDb.OleDbDataReader
        Dim TableName As String = ""
        Dim query As String = ""
        Dim cbo As ComboBox = Nothing

        Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=care.accdb")
            con.Open()
            query = "SELECT DISTINCT " & strColumnName & " FROM " & strTableName & " WHERE " & strColumnName & " IS NOT NULL ORDER BY " & strColumnName
            TableName = strColumnName
            cbo = cb
            objCmd.Connection = con
            objCmd.CommandText = query
            objRdr = objCmd.ExecuteReader
            cbo.Items.Clear()
            If objRdr.HasRows Then
                Do While objRdr.Read
                    cbo.Items.Add(objRdr.GetValue(0))
                Loop
            End If
            objRdr.Close()
        End Using
    End Sub

    Private Sub LoadDestinationCbo(ByRef cb As ComboBox, ByVal strTableName As String, ByVal strColumnName As String, ByVal strColumnName1 As String, ByVal strColumnName1Value As String)
        Dim objCmd As New Data.OleDb.OleDbCommand
        Dim objRdr As Data.OleDb.OleDbDataReader
        Dim TableName As String = ""
        Dim query As String = ""
        Dim cbo As ComboBox = Nothing

        Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=care.accdb")
            con.Open()
            query = "SELECT DISTINCT " & strColumnName & " FROM " & strTableName & " WHERE " & strColumnName1 & " = '" & strColumnName1Value & "'"
            TableName = strColumnName
            cbo = cb
            objCmd.Connection = con
            objCmd.CommandText = query
            objRdr = objCmd.ExecuteReader
            cbo.Items.Clear()
            If objRdr.HasRows Then
                Do While objRdr.Read
                    cbo.Items.Add(objRdr.GetValue(0))
                Loop
            End If
            objRdr.Close()
        End Using
    End Sub

    '****************************************************************************** 
    'Returns an integer that uniquely identifies a flight
    '******************************************************************************
    Private Function getFlightID() As Integer
        Dim strQuery As String
        Dim int As Integer
        Dim strSelection As Date = Me.cboFlightTime.SelectedItem
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        strQuery = "SELECT * FROM FLIGHT WHERE (FLIGHT_ORIGIN = '" & Me.cboOriginCity.SelectedItem & "' AND FLIGHT_DESTINATION = '" & Me.cboDestinationCity.SelectedItem & "' AND FLIGHT_DEPARTURE = #" & strSelection & "#)"
        Dim cmd As OleDbCommand = New OleDbCommand(strQuery, cnn)
        dr = cmd.ExecuteReader
        While dr.Read()
            int = dr("ID")
        End While
        cnn.Close()
        Return int
    End Function


    Private Sub TextBox_TextChanged(sender As System.Object, e As System.EventArgs)
        'When you modify the contents of any textbox, the name of that textbox
        'and its current contents will be displayed in the title bar

        Dim box As TextBox = DirectCast(sender, TextBox)
        Me.Text = box.Name & ": " & box.Text
    End Sub

    '****************************************************************************** 
    'Creates a list of textboxes or comboboxes to gather the names and seat selection
    'associated with a ticket.
    'Code modified from:
    'http://stackoverflow.com/questions/28529715/array-of-checkboxes-vb-net
    '******************************************************************************
    Sub SetUpTextBoxesFirstName()
        theTextBoxesFirstName = New List(Of TextBox)
        Dim offset = 300
        For intCounter = 0 To (intNumberOfTickets - 1)
            Dim tb = New TextBox()
            tb.Location = New Point(400, offset)
            tb.Name = "txtTicketHolderFirstName" & intCounter
            tb.Size = New Size(150, 25)
            tb.Font = New Font("Tahoma", 10)
            'tb.Visible = False
            Controls.Add(tb)
            theTextBoxesFirstName.Add(tb)
            offset = offset + 35
        Next
    End Sub

    Sub SetUpTextBoxesLastName()
        theTextBoxesLastName = New List(Of TextBox)
        Dim offset = 300
        For intCounter = 0 To (intNumberOfTickets - 1)
            Dim tb = New TextBox()
            tb.Location = New Point(565, offset)
            tb.Name = "txtTicketHolderLastName" & intCounter
            tb.Size = New Size(150, 25)
            tb.Font = New Font("Tahoma", 10)
            'tb.Visible = False
            Controls.Add(tb)
            theTextBoxesLastName.Add(tb)
            offset = offset + 35
        Next
    End Sub

    Sub SetUpSeatSelection()
        Dim intFakeBoolean As Integer = 0
        theSeatComboBoxes = New List(Of ComboBox)
        Dim offset = 300
        For intCounter = 0 To (intNumberOfTickets - 1)
            Dim cbo = New ComboBox()
            Dim idx As Integer
            cbo.Location = New Point(730, offset)
            cbo.Name = "cboSeatSelection" & intCounter
            cbo.Text = "Seat #"
            cbo.Size = New Size(70, 25)
            cbo.Font = New Font("Tahoma", 10)

            intFakeBoolean = isSeatOpen("SEAT_A1")
            If intFakeBoolean = 0 Then
                idx = cbo.Items.Add("A1")
            End If

            intFakeBoolean = isSeatOpen("SEAT_A2")
            If intFakeBoolean = 0 Then
                idx = cbo.Items.Add("A2")
            End If

            intFakeBoolean = isSeatOpen("SEAT_A3")
            If intFakeBoolean = 0 Then
                idx = cbo.Items.Add("A3")
            End If

            intFakeBoolean = isSeatOpen("SEAT_A4")
            If intFakeBoolean = 0 Then
                idx = cbo.Items.Add("A4")
            End If

            intFakeBoolean = isSeatOpen("SEAT_B1")
            If intFakeBoolean = 0 Then
                idx = cbo.Items.Add("B1")
            End If

            intFakeBoolean = isSeatOpen("SEAT_B2")
            If intFakeBoolean = 0 Then
                idx = cbo.Items.Add("B2")
            End If

            intFakeBoolean = isSeatOpen("SEAT_B3")
            If intFakeBoolean = 0 Then
                idx = cbo.Items.Add("B3")
            End If

            intFakeBoolean = isSeatOpen("SEAT_B4")
            If intFakeBoolean = 0 Then
                idx = cbo.Items.Add("B4")
            End If

            intFakeBoolean = isSeatOpen("SEAT_C1")
            If intFakeBoolean = 0 Then
                idx = cbo.Items.Add("C1")
            End If

            intFakeBoolean = isSeatOpen("SEAT_C2")
            If intFakeBoolean = 0 Then
                idx = cbo.Items.Add("C2")
            End If

            intFakeBoolean = isSeatOpen("SEAT_C3")
            If intFakeBoolean = 0 Then
                idx = cbo.Items.Add("C3")
            End If

            intFakeBoolean = isSeatOpen("SEAT_C4")
            If intFakeBoolean = 0 Then
                idx = cbo.Items.Add("C4")
            End If
            AddHandler cbo.SelectedIndexChanged, AddressOf theSeatComboBoxes_SelectedIndexChanged
            'cbo.Visible = False
            Controls.Add(cbo)
            theSeatComboBoxes.Add(cbo)
            offset = offset + 35
        Next
    End Sub

    '****************************************************************************** 
    'When a user selects a seat the seat is no longer available to be associated
    'with another ticket.  Once selected the seat combobox is disabled.  
    '******************************************************************************
    Private Sub theSeatComboBoxes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TypeOf sender Is ComboBox Then
            Dim cb As ComboBox = DirectCast(sender, ComboBox)
            Dim strSeatSelected As String = cb.SelectedItem
            Dim strSeatColumn As String
            Dim intFakeBoolean As Integer = 0

            Select Case strSeatSelected
                Case "A1"
                    strSeatColumn = "SEAT_A1"
                Case "A2"
                    strSeatColumn = "SEAT_A2"
                Case "A3"
                    strSeatColumn = "SEAT_A3"
                Case "A4"
                    strSeatColumn = "SEAT_A4"
                Case "B1"
                    strSeatColumn = "SEAT_B1"
                Case "B2"
                    strSeatColumn = "SEAT_B2"
                Case "B3"
                    strSeatColumn = "SEAT_B3"
                Case "B4"
                    strSeatColumn = "SEAT_B4"
                Case "C1"
                    strSeatColumn = "SEAT_C1"
                Case "C2"
                    strSeatColumn = "SEAT_C2"
                Case "C3"
                    strSeatColumn = "SEAT_C3"
                Case "C4"
                    strSeatColumn = "SEAT_C4"
                Case Else
                    strSeatColumn = ""
            End Select

            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If
            Dim cmd As New OleDb.OleDbCommand

            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If
            cmd.Connection = cnn

            cmd.CommandText = "UPDATE SEATING SET " & strSeatColumn & " = -1 WHERE FLIGHT_ID = " & intFlightID
            cmd.ExecuteNonQuery()
            cnn.Close()
            cb.Enabled = False

            For Each cbo In theSeatComboBoxes
                Dim idx As Integer
                If cbo.Enabled = True Then
                    cbo.Items.Clear()
                    cbo.Text = "Seat #"

                    intFakeBoolean = isSeatOpen("SEAT_A1")
                    If intFakeBoolean = 0 Then
                        idx = cbo.Items.Add("A1")
                    End If

                    intFakeBoolean = isSeatOpen("SEAT_A2")
                    If intFakeBoolean = 0 Then
                        idx = cbo.Items.Add("A2")
                    End If

                    intFakeBoolean = isSeatOpen("SEAT_A3")
                    If intFakeBoolean = 0 Then
                        idx = cbo.Items.Add("A3")
                    End If

                    intFakeBoolean = isSeatOpen("SEAT_A4")
                    If intFakeBoolean = 0 Then
                        idx = cbo.Items.Add("A4")
                    End If

                    intFakeBoolean = isSeatOpen("SEAT_B1")
                    If intFakeBoolean = 0 Then
                        idx = cbo.Items.Add("B1")
                    End If

                    intFakeBoolean = isSeatOpen("SEAT_B2")
                    If intFakeBoolean = 0 Then
                        idx = cbo.Items.Add("B2")
                    End If

                    intFakeBoolean = isSeatOpen("SEAT_B3")
                    If intFakeBoolean = 0 Then
                        idx = cbo.Items.Add("B3")
                    End If

                    intFakeBoolean = isSeatOpen("SEAT_B4")
                    If intFakeBoolean = 0 Then
                        idx = cbo.Items.Add("B4")
                    End If

                    intFakeBoolean = isSeatOpen("SEAT_C1")
                    If intFakeBoolean = 0 Then
                        idx = cbo.Items.Add("C1")
                    End If

                    intFakeBoolean = isSeatOpen("SEAT_C2")
                    If intFakeBoolean = 0 Then
                        idx = cbo.Items.Add("C2")
                    End If

                    intFakeBoolean = isSeatOpen("SEAT_C3")
                    If intFakeBoolean = 0 Then
                        idx = cbo.Items.Add("C3")
                    End If

                    intFakeBoolean = isSeatOpen("SEAT_C4")
                    If intFakeBoolean = 0 Then
                        idx = cbo.Items.Add("C4")
                    End If
                End If
            Next
        End If
    End Sub

    '****************************************************************************** 
    'Helper function that queries the database to determine if a seat is available. 
    '******************************************************************************
    Private Function isSeatOpen(ByVal strSeatColumn As String) As Integer
        Dim str As String
        Dim int As Integer

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        str = "SELECT * FROM SEATING WHERE (FLIGHT_ID = " & intFlightID & ")"
        Dim cmd As OleDbCommand = New OleDbCommand(str, cnn)
        dr = cmd.ExecuteReader
        While dr.Read()
            int = dr(strSeatColumn)
        End While
        cnn.Close()

        Return int
    End Function

    '****************************************************************************** 
    'Erases text that is already entered in a text.  Allows the use of hints so
    'user knows what data to enter in textbook instead of using a space consuming
    'label
    'http://stackoverflow.com/questions/16755281/function-or-sub-that-clears-the-text-box-when-it-gets-focus
    '******************************************************************************
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        'array by type
        Dim tbs = Me.Controls.OfType(Of TextBox)()
        'loop thru and add the delegate 
        Array.ForEach(Of TextBox)(tbs.ToArray, Sub(tb) AddHandler tb.GotFocus, AddressOf got_Focus)
    End Sub

    Private Sub got_Focus(sender As Object, e As System.EventArgs)
        'cast our sender object to textbox and clear it's content
        DirectCast(sender, TextBox).Clear()
    End Sub

    '****************************************************************************** 
    'Adds the customer and ticketholder(s) to the database and verifies the 
    'correctness of the user's email address, 
    '******************************************************************************
    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        If IsValidEmailAddress(txtCustomerEmail.Text) Then
            AddCustomer()
            intCustomerID = getCustomerID()
            AddTicketHolders()
            lblMessage.Text = "TICKET PURCHASE SUCCESSFUL"
            lblMessage.Visible = True
        Else
            MsgBox(txtCustomerEmail.Text & " is an invalid email address", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "INVALID EMAIL")
            txtCustomerEmail.Text = "your@email.com"
        End If

    End Sub

    '****************************************************************************** 
    'Helper method to add customer to database
    '******************************************************************************
    Private Sub AddCustomer()
        Dim cmd As New OleDb.OleDbCommand

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        cmd.Connection = cnn
        cmd.CommandText = "INSERT INTO CUSTOMER (CUS_FIRSTNAME, CUS_LASTNAME, CUS_STREETADDRESS, CUS_CITY, CUS_STATE, CUS_PHONE, CUS_EMAIL, FLIGHT_ID) " & "VALUES ('" & txtCustomerFirstName.Text & "','" & txtCustomerLastName.Text & "','" & txtCustomerStreetAddress.Text & "','" & txtCustomerCity.Text & "','" & cboCustomerState.SelectedItem & "','" & txtCustomerPhone.Text & "','" & txtCustomerEmail.Text & "','" & intFlightID & "')"
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub

    '****************************************************************************** 
    'Helper method which returns the customer id as an integer
    '******************************************************************************
    Private Function getCustomerID() As Integer
        Dim str As String
        Dim int As Integer

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        str = "SELECT * FROM CUSTOMER WHERE (CUS_LASTNAME = '" & txtCustomerLastName.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, cnn)
        dr = cmd.ExecuteReader
        While dr.Read()
            int = dr("ID")
        End While
        cnn.Close()

        Return int

    End Function

    '****************************************************************************** 
    'Helper method to add ticketholder to database
    '******************************************************************************
    Private Sub AddTicketHolders()
        Dim cmd As New OleDb.OleDbCommand

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        cmd.Connection = cnn
        For intCounter = 0 To (intNumberOfTickets - 1)
            cmd.CommandText = "INSERT INTO TICKETHOLDER (TH_FIRSTNAME, TH_LASTNAME, TH_SEAT, CUS_ID) " & "VALUES ('" & theTextBoxesFirstName(intCounter).Text & "','" & theTextBoxesLastName(intCounter).Text & "','" & theSeatComboBoxes(intCounter).SelectedItem & "','" & intCustomerID & "')"
            cmd.ExecuteNonQuery()
        Next

        cnn.Close()
    End Sub

    '****************************************************************************** 
    'Helper method to return the number of seats that are available on a flight
    '******************************************************************************
    Private Function getSeatsAvailable(ByVal intFlightID As Integer) As Integer
        Dim strQuery As String
        Dim int As Integer
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        strQuery = "SELECT SEAT_OPEN FROM SEATING WHERE (FLIGHT_ID = " & intFlightID & ")"
        Dim cmd As OleDbCommand = New OleDbCommand(strQuery, cnn)
        dr = cmd.ExecuteReader
        While dr.Read()
            int = dr("SEAT_OPEN")
        End While
        cnn.Close()
        Return int
    End Function

    '****************************************************************************** 
    'Helper method to verify email is in correct format
    '******************************************************************************
    Function IsValidEmailAddress(ByVal emailAddress As String) As Boolean
        Dim valid As Boolean = True
        Try
            Dim a = New System.Net.Mail.MailAddress(emailAddress)
        Catch ex As FormatException
            valid = False
        End Try
        Return valid
    End Function

    '****************************************************************************** 
    'If selected will automatically enter the customer as a ticket holder and
    'disable those textboxes
    '******************************************************************************
    Private Sub chkPurchaserIsTH_CheckedChanged(sender As Object, e As EventArgs) Handles chkPurchaserIsTH.CheckedChanged
        If chkPurchaserIsTH.Checked = True Then
            theTextBoxesFirstName(0).Text = txtCustomerFirstName.Text
            theTextBoxesLastName(0).Text = txtCustomerLastName.Text
            theTextBoxesFirstName(0).Enabled = False
            theTextBoxesLastName(0).Enabled = False
        Else
            theTextBoxesFirstName(0).Text = ""
            theTextBoxesLastName(0).Text = ""
            theTextBoxesFirstName(0).Enabled = True
            theTextBoxesLastName(0).Enabled = True
        End If
    End Sub

    '****************************************************************************** 
    'Opens second form that allows user to search for a ticket holder
    '******************************************************************************
    Private Sub mnuSearch_Click(sender As Object, e As EventArgs) Handles mnuSearch.Click
        Dim frmSecond As New frmTicketSearch
        frmSecond.ShowDialog()
    End Sub

    '****************************************************************************** 
    'Clears flight selections
    '******************************************************************************
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboOriginCity.Text = "Select Origin City"
        cboDestinationCity.Text = "Select Destination City"
        cboFlightTime.Text = "Select Flight Date"
        cboNumberOfTickets.Text = "Ticket #"

        txtCustomerFirstName.Visible = False
        txtCustomerLastName.Visible = False
        txtCustomerStreetAddress.Visible = False
        txtCustomerCity.Visible = False
        cboCustomerState.Visible = False
        txtCustomerPhone.Visible = False
        txtCustomerEmail.Visible = False

        lblFLightInfo.Visible = False
        lblCustomerInfo.Visible = False
        lblTicketHolder.Visible = False
        lblTHFirstName.Visible = False
        lblTHLastName.Visible = False
        lblTHSeat.Visible = False
        lblMessage.Visible = False

        'For Each tb In theTextBoxesFirstName
        '    tb.Visible = False
        'Next

        'For Each tb In theTextBoxesLastName
        '    tb.Visible = False
        'Next

        'For Each cb In theSeatComboBoxes
        '    cb.Items.Clear()
        '    cb.Text = "Seat #"
        '    cb.Visible = False
        'Next

        cboOriginCity.Enabled = True
        cboDestinationCity.Enabled = True
        cboFlightTime.Enabled = True
        cboNumberOfTickets.Enabled = True
        cboDestinationCity.Visible = False
        cboFlightTime.Visible = False
        'Corrected error from class
        cboNumberOfTickets.Items.Clear()
        cboNumberOfTickets.Text = "Ticket #"
        cboNumberOfTickets.Visible = False

        btnSelect.Enabled = True
        btnSelect.Visible = False
        btnPurchase.Visible = False

    End Sub

    '****************************************************************************** 
    'Clears form and returns it to it's original value
    '******************************************************************************
    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        cboOriginCity.Text = "Select Origin City"
        cboDestinationCity.Text = "Select Destination City"
        cboFlightTime.Text = "Select Flight Date"
        cboNumberOfTickets.Text = "Ticket #"

        txtCustomerFirstName.Visible = False
        txtCustomerLastName.Visible = False
        txtCustomerStreetAddress.Visible = False
        txtCustomerCity.Visible = False
        cboCustomerState.Visible = False
        txtCustomerPhone.Visible = False
        txtCustomerEmail.Visible = False

        lblFLightInfo.Visible = False
        lblCustomerInfo.Visible = False
        lblTicketHolder.Visible = False
        lblTHFirstName.Visible = False
        lblTHLastName.Visible = False
        lblTHSeat.Visible = False
        lblMessage.Visible = False

        chkPurchaserIsTH.Visible = False

        For Each tb In theTextBoxesFirstName
            tb.Visible = False
        Next

        For Each tb In theTextBoxesLastName
            tb.Visible = False
        Next

        For Each cb In theSeatComboBoxes
            cb.Items.Clear()
            cb.Text = "Seat #"
            cb.Visible = False
        Next

        cboOriginCity.Enabled = True
        cboDestinationCity.Enabled = True
        cboFlightTime.Enabled = True
        cboNumberOfTickets.Enabled = True
        cboDestinationCity.Visible = False
        cboFlightTime.Visible = False
        'Corrected error from class
        cboNumberOfTickets.Items.Clear()
        cboNumberOfTickets.Text = "Ticket #"
        cboNumberOfTickets.Visible = False

        btnSelect.Enabled = True
        btnSelect.Visible = False
        btnPurchase.Visible = False

    End Sub

    '****************************************************************************** 
    'Exits window and closes application
    '******************************************************************************
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub

End Class
