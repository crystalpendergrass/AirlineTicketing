Imports System.Data.OleDb

Public Class frmTicketSearch
    Dim intTicketID As Integer
    Dim intCustomerID As Integer
    Dim intFlightID As Integer

    Dim dr As OleDbDataReader
    Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=care.accdb")

    '****************************************************************************** 
    'Closes windows and returns user to main application
    '******************************************************************************
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Hide()
    End Sub

    '****************************************************************************** 
    'Returns integer that unique identifies a ticket
    '******************************************************************************
    Private Function getTicketID() As Integer
        Dim str As String
        Dim int As Integer

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        str = "SELECT * FROM TICKETHOLDER WHERE (TH_FIRSTNAME = '" & txtFName.Text & "' AND TH_LASTNAME = '" & txtLName.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(str, cnn)
        dr = cmd.ExecuteReader
        While dr.Read()
            int = dr("ID")
        End While
        cnn.Close()

        Return int
    End Function

    '****************************************************************************** 
    'Returns the name of ticket holder
    '******************************************************************************
    Private Function getTicketHolderName() As String
        Dim strQuery As String
        Dim strFirstName As String = ""
        Dim strLastName As String = ""

        If intTicketID = 0 Then
            btnReturn.Location = New Point(25, 175)
            'btnReturn.Size = New Size(115, 23)
            btnReturn.Visible = True
            Return "TICKET NOT FOUND"
        Else
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If
            strQuery = "SELECT * FROM TICKETHOLDER WHERE (ID = " & intTicketID & ")"
            Dim cmd As OleDbCommand = New OleDbCommand(strQuery, cnn)
            dr = cmd.ExecuteReader
            While dr.Read()
                strFirstName = dr("TH_FIRSTNAME")
                strLastName = dr("TH_LASTNAME")
            End While
            cnn.Close()
        End If

        Return strFirstName & " " & strLastName
    End Function

    '****************************************************************************** 
    'Returns the ticket holders seat selection
    '******************************************************************************
    Private Function getTicketHolderSeat() As String
        Dim strQuery As String
        Dim strSeat As String = ""
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
            strQuery = "SELECT * FROM TICKETHOLDER WHERE (ID = " & intTicketID & ")"
            Dim cmd As OleDbCommand = New OleDbCommand(strQuery, cnn)
            dr = cmd.ExecuteReader
            While dr.Read()
            strSeat = dr("TH_SEAT")
        End While
            cnn.Close()

        Return strSeat
    End Function

    '****************************************************************************** 
    'Returns integer that unique identifies a customer
    '******************************************************************************
    Private Function getCustomerID() As Integer
        Dim str As String
        Dim int As Integer

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        str = "SELECT * FROM TICKETHOLDER WHERE (ID = " & intTicketID & ")"
        Dim cmd As OleDbCommand = New OleDbCommand(str, cnn)
        dr = cmd.ExecuteReader
        While dr.Read()
            int = dr("CUS_ID")
        End While
        cnn.Close()

        Return int
    End Function

    '****************************************************************************** 
    'Returns the name of the customer who purchased the ticket
    '******************************************************************************
    Private Function getCustomerName() As String
        Dim strQuery As String
        Dim strFirstName As String = ""
        Dim strLastName As String = ""

        If intCustomerID = 0 Then
            Return "CUSTOMER NOT FOUND"
        Else
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If
            strQuery = "SELECT * FROM CUSTOMER WHERE (ID = " & intCustomerID & ")"
            Dim cmd As OleDbCommand = New OleDbCommand(strQuery, cnn)
            dr = cmd.ExecuteReader
            While dr.Read()
                strFirstName = dr("CUS_FIRSTNAME")
                strLastName = dr("CUS_LASTNAME")
            End While
            cnn.Close()
        End If

        Return strFirstName & " " & strLastName
    End Function

    '****************************************************************************** 
    'Returns integer that unique identifies a flight
    '******************************************************************************
    Private Function getFlightID() As Integer
        Dim str As String
        Dim int As Integer

        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        str = "SELECT * FROM CUSTOMER WHERE (ID = " & intCustomerID & ")"
        Dim cmd As OleDbCommand = New OleDbCommand(str, cnn)
        dr = cmd.ExecuteReader
        While dr.Read()
            int = dr("FLIGHT_ID")
        End While
        cnn.Close()

        Return int
    End Function

    '****************************************************************************** 
    'Returns a description of the flight
    '******************************************************************************
    Private Function getFlightInfo() As String
        Dim strQuery As String
        Dim strOriginCity As String = ""
        Dim strDestinationCity As String = ""
        Dim strDate As String = ""
        If intCustomerID = 0 Then
            Return "FLIGHT NOT FOUND"
        Else
            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If
            strQuery = "SELECT * FROM FLIGHT WHERE (ID = " & intFlightID & ")"
            Dim cmd As OleDbCommand = New OleDbCommand(strQuery, cnn)
            dr = cmd.ExecuteReader
            While dr.Read()
                strOriginCity = dr("FLIGHT_ORIGIN")
                strDestinationCity = dr("FLIGHT_DESTINATION")
                strDate = dr("FLIGHT_DEPARTURE")
            End While
            cnn.Close()
        End If

        Return strOriginCity & " to " & strDestinationCity & " on " & strDate
    End Function

    Private Sub rdoName_CheckedChanged(sender As Object, e As EventArgs) Handles rdoName.CheckedChanged
        If (rdoName.Checked) Then
            txtTicketNo.Visible = False
            txtFName.Visible = True
            txtLName.Visible = True
        Else
            txtTicketNo.Visible = True
            txtFName.Visible = False
            txtLName.Visible = False
        End If
    End Sub

    Private Sub rdoTicketNumber_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTicketNumber.CheckedChanged
        If (rdoTicketNumber.Checked) Then
            txtTicketNo.Visible = True
            txtFName.Visible = False
            txtLName.Visible = False
        Else
            txtTicketNo.Visible = False
            txtFName.Visible = True
            txtLName.Visible = True
        End If
    End Sub

    '****************************************************************************** 
    'Searches for a user and return information if ticket is found.  Also indicates 
    'if user is not found
    '******************************************************************************
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If (rdoTicketNumber.Checked) Then
            intTicketID = txtTicketNo.Text
        Else
            intTicketID = getTicketID()
        End If

        lblTHName.Text = getTicketHolderName()
        lblTHName.Visible = True

        If intTicketID > 0 Then
            lblTicketNumber.Text = "Ticket Number: " & intTicketID
            lblTicketNumber.Visible = True

            intCustomerID = getCustomerID()
            lblCustomer.Text = "Purchased by: " & getCustomerName()
            lblCustomer.Visible = True

            intFlightID = getFlightID()
            lblFlight.Text = getFlightInfo()
            lblFlight.Visible = True
            lblSearchResults.Visible = True

            btnDelete.Visible = True
            'btnReturn.Location = New Point(23, 269)
            btnReturn.Visible = True
        End If

    End Sub

    '****************************************************************************** 
    'Deletes the ticket holder from the database.  User must confirm deletion with
    'message box
    '******************************************************************************
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim okToDelete As MsgBoxResult = MsgBox("Are you sure you want to delete this ticket?", MsgBoxStyle.YesNo)
        If okToDelete = MsgBoxResult.Yes Then
            updateSeatAvailibilty()

            If Not cnn.State = ConnectionState.Open Then
                cnn.Open()
            End If
            Dim str As String

            str = "DELETE from TICKETHOLDER WHERE ID = " & intTicketID
            Dim cmd As OleDbCommand = New OleDbCommand(str, cnn)
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                cnn.Close()

                lblMessage.Text = "TICKET " & intTicketID & " for " & lblTHName.Text & " DELETED"
                lblMessage.Visible = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf okToDelete = MsgBoxResult.No Then
        End If

    End Sub

    Private Sub updateSeatAvailibilty()
        Dim strSeatSelected As String = getTicketHolderSeat()
        Dim strSeatColumn As String

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

        cmd.CommandText = "UPDATE SEATING SET " & strSeatColumn & " = 0 WHERE FLIGHT_ID = " & intFlightID
            cmd.ExecuteNonQuery()
            cnn.Close()         
    End Sub
End Class