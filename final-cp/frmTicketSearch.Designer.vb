<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSearchBy = New System.Windows.Forms.Label()
        Me.rdoName = New System.Windows.Forms.RadioButton()
        Me.rdoTicketNumber = New System.Windows.Forms.RadioButton()
        Me.txtTicketNo = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblTHName = New System.Windows.Forms.Label()
        Me.lblTicketNumber = New System.Windows.Forms.Label()
        Me.lblFlight = New System.Windows.Forms.Label()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblSearchResults = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSearchBy
        '
        Me.lblSearchBy.AutoSize = True
        Me.lblSearchBy.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblSearchBy.Location = New System.Drawing.Point(13, 13)
        Me.lblSearchBy.Name = "lblSearchBy"
        Me.lblSearchBy.Size = New System.Drawing.Size(88, 18)
        Me.lblSearchBy.TabIndex = 0
        Me.lblSearchBy.Text = "Search By:"
        '
        'rdoName
        '
        Me.rdoName.AutoSize = True
        Me.rdoName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoName.Location = New System.Drawing.Point(16, 41)
        Me.rdoName.Name = "rdoName"
        Me.rdoName.Size = New System.Drawing.Size(59, 20)
        Me.rdoName.TabIndex = 1
        Me.rdoName.TabStop = True
        Me.rdoName.Text = "Name"
        Me.rdoName.UseVisualStyleBackColor = True
        '
        'rdoTicketNumber
        '
        Me.rdoTicketNumber.AutoSize = True
        Me.rdoTicketNumber.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoTicketNumber.Location = New System.Drawing.Point(105, 41)
        Me.rdoTicketNumber.Name = "rdoTicketNumber"
        Me.rdoTicketNumber.Size = New System.Drawing.Size(109, 20)
        Me.rdoTicketNumber.TabIndex = 2
        Me.rdoTicketNumber.TabStop = True
        Me.rdoTicketNumber.Text = "Ticket Number"
        Me.rdoTicketNumber.UseVisualStyleBackColor = True
        '
        'txtTicketNo
        '
        Me.txtTicketNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTicketNo.Location = New System.Drawing.Point(15, 75)
        Me.txtTicketNo.Name = "txtTicketNo"
        Me.txtTicketNo.Size = New System.Drawing.Size(207, 23)
        Me.txtTicketNo.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(256, 75)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblTHName
        '
        Me.lblTHName.AutoSize = True
        Me.lblTHName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTHName.Location = New System.Drawing.Point(25, 145)
        Me.lblTHName.Name = "lblTHName"
        Me.lblTHName.Size = New System.Drawing.Size(45, 16)
        Me.lblTHName.TabIndex = 5
        Me.lblTHName.Text = "Label1"
        Me.lblTHName.Visible = False
        '
        'lblTicketNumber
        '
        Me.lblTicketNumber.AutoSize = True
        Me.lblTicketNumber.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketNumber.Location = New System.Drawing.Point(25, 174)
        Me.lblTicketNumber.Name = "lblTicketNumber"
        Me.lblTicketNumber.Size = New System.Drawing.Size(45, 16)
        Me.lblTicketNumber.TabIndex = 6
        Me.lblTicketNumber.Text = "Label2"
        Me.lblTicketNumber.Visible = False
        '
        'lblFlight
        '
        Me.lblFlight.AutoSize = True
        Me.lblFlight.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlight.Location = New System.Drawing.Point(25, 203)
        Me.lblFlight.Name = "lblFlight"
        Me.lblFlight.Size = New System.Drawing.Size(45, 16)
        Me.lblFlight.TabIndex = 7
        Me.lblFlight.Text = "Label3"
        Me.lblFlight.Visible = False
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(25, 232)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(45, 16)
        Me.lblCustomer.TabIndex = 8
        Me.lblCustomer.Text = "Label4"
        Me.lblCustomer.Visible = False
        '
        'lblSearchResults
        '
        Me.lblSearchResults.AutoSize = True
        Me.lblSearchResults.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblSearchResults.Location = New System.Drawing.Point(13, 117)
        Me.lblSearchResults.Name = "lblSearchResults"
        Me.lblSearchResults.Size = New System.Drawing.Size(120, 18)
        Me.lblSearchResults.TabIndex = 9
        Me.lblSearchResults.Text = "Search Results"
        Me.lblSearchResults.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(23, 269)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(153, 23)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete Ticket Holder"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnReturn
        '
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnReturn.Location = New System.Drawing.Point(206, 269)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(155, 23)
        Me.btnReturn.TabIndex = 11
        Me.btnReturn.Text = "Return to Main Screen"
        Me.btnReturn.UseVisualStyleBackColor = True
        Me.btnReturn.Visible = False
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(15, 75)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(100, 23)
        Me.txtFName.TabIndex = 12
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(122, 75)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(116, 23)
        Me.txtLName.TabIndex = 13
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(18, 307)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(348, 16)
        Me.lblMessage.TabIndex = 14
        Me.lblMessage.Text = "TICKET [number] for [firstname] [lastname] DELETED"
        Me.lblMessage.Visible = False
        '
        'frmTicketSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 336)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblSearchResults)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.lblFlight)
        Me.Controls.Add(Me.lblTicketNumber)
        Me.Controls.Add(Me.lblTHName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtTicketNo)
        Me.Controls.Add(Me.rdoTicketNumber)
        Me.Controls.Add(Me.rdoName)
        Me.Controls.Add(Me.lblSearchBy)
        Me.Name = "frmTicketSearch"
        Me.Text = "Ticket Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSearchBy As System.Windows.Forms.Label
    Friend WithEvents rdoName As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTicketNumber As System.Windows.Forms.RadioButton
    Friend WithEvents txtTicketNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblTHName As System.Windows.Forms.Label
    Friend WithEvents lblTicketNumber As System.Windows.Forms.Label
    Friend WithEvents lblFlight As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblSearchResults As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
End Class
