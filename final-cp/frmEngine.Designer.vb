<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEngine
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCAREHeader = New System.Windows.Forms.Label()
        Me.cboOriginCity = New System.Windows.Forms.ComboBox()
        Me.cboDestinationCity = New System.Windows.Forms.ComboBox()
        Me.cboFlightTime = New System.Windows.Forms.ComboBox()
        Me.cboNumberOfTickets = New System.Windows.Forms.ComboBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtCustomerFirstName = New System.Windows.Forms.TextBox()
        Me.txtCustomerStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerLastName = New System.Windows.Forms.TextBox()
        Me.txtCustomerCity = New System.Windows.Forms.TextBox()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.lblTHFirstName = New System.Windows.Forms.Label()
        Me.cboCustomerState = New System.Windows.Forms.ComboBox()
        Me.txtCustomerEmail = New System.Windows.Forms.TextBox()
        Me.lblTicketHolder = New System.Windows.Forms.Label()
        Me.lblTHLastName = New System.Windows.Forms.Label()
        Me.lblTHSeat = New System.Windows.Forms.Label()
        Me.lblCustomerInfo = New System.Windows.Forms.Label()
        Me.lblFlightSelection = New System.Windows.Forms.Label()
        Me.chkPurchaserIsTH = New System.Windows.Forms.CheckBox()
        Me.lblFLightInfo = New System.Windows.Forms.Label()
        Me.lblTEST = New System.Windows.Forms.Label()
        Me.lblTEST2 = New System.Windows.Forms.Label()
        Me.txtCustomerPhone = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(834, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSearch, Me.mnuClear, Me.mnuExit})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'mnuSearch
        '
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.Size = New System.Drawing.Size(186, 22)
        Me.mnuSearch.Text = "&Search"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(186, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(186, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'lblCAREHeader
        '
        Me.lblCAREHeader.AutoSize = True
        Me.lblCAREHeader.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCAREHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblCAREHeader.Location = New System.Drawing.Point(23, 21)
        Me.lblCAREHeader.Name = "lblCAREHeader"
        Me.lblCAREHeader.Size = New System.Drawing.Size(332, 78)
        Me.lblCAREHeader.TabIndex = 2
        Me.lblCAREHeader.Text = "Crystal's Airline " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Registration Engine"
        Me.lblCAREHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboOriginCity
        '
        Me.cboOriginCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOriginCity.FormattingEnabled = True
        Me.cboOriginCity.Location = New System.Drawing.Point(13, 141)
        Me.cboOriginCity.Name = "cboOriginCity"
        Me.cboOriginCity.Size = New System.Drawing.Size(155, 24)
        Me.cboOriginCity.TabIndex = 3
        Me.cboOriginCity.Text = "Select Origin City"
        '
        'cboDestinationCity
        '
        Me.cboDestinationCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDestinationCity.FormattingEnabled = True
        Me.cboDestinationCity.Location = New System.Drawing.Point(201, 140)
        Me.cboDestinationCity.Name = "cboDestinationCity"
        Me.cboDestinationCity.Size = New System.Drawing.Size(155, 24)
        Me.cboDestinationCity.TabIndex = 4
        Me.cboDestinationCity.Text = "Select Destination City"
        Me.cboDestinationCity.Visible = False
        '
        'cboFlightTime
        '
        Me.cboFlightTime.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFlightTime.FormattingEnabled = True
        Me.cboFlightTime.Location = New System.Drawing.Point(13, 178)
        Me.cboFlightTime.Name = "cboFlightTime"
        Me.cboFlightTime.Size = New System.Drawing.Size(155, 24)
        Me.cboFlightTime.TabIndex = 5
        Me.cboFlightTime.Text = "Select Flight Date"
        Me.cboFlightTime.Visible = False
        '
        'cboNumberOfTickets
        '
        Me.cboNumberOfTickets.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNumberOfTickets.FormattingEnabled = True
        Me.cboNumberOfTickets.Location = New System.Drawing.Point(201, 178)
        Me.cboNumberOfTickets.Name = "cboNumberOfTickets"
        Me.cboNumberOfTickets.Size = New System.Drawing.Size(75, 24)
        Me.cboNumberOfTickets.TabIndex = 6
        Me.cboNumberOfTickets.Text = "Ticket #"
        Me.cboNumberOfTickets.Visible = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnSelect.Location = New System.Drawing.Point(13, 221)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(100, 30)
        Me.btnSelect.TabIndex = 7
        Me.btnSelect.Text = "Select Flight"
        Me.btnSelect.UseVisualStyleBackColor = False
        Me.btnSelect.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(201, 221)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 30)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear Selection"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtCustomerFirstName
        '
        Me.txtCustomerFirstName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerFirstName.Location = New System.Drawing.Point(13, 296)
        Me.txtCustomerFirstName.Name = "txtCustomerFirstName"
        Me.txtCustomerFirstName.Size = New System.Drawing.Size(120, 23)
        Me.txtCustomerFirstName.TabIndex = 9
        Me.txtCustomerFirstName.Text = "First Name"
        Me.txtCustomerFirstName.Visible = False
        '
        'txtCustomerStreetAddress
        '
        Me.txtCustomerStreetAddress.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerStreetAddress.Location = New System.Drawing.Point(13, 329)
        Me.txtCustomerStreetAddress.Name = "txtCustomerStreetAddress"
        Me.txtCustomerStreetAddress.Size = New System.Drawing.Size(240, 23)
        Me.txtCustomerStreetAddress.TabIndex = 10
        Me.txtCustomerStreetAddress.Text = "Street Address"
        Me.txtCustomerStreetAddress.Visible = False
        '
        'txtCustomerLastName
        '
        Me.txtCustomerLastName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerLastName.Location = New System.Drawing.Point(150, 296)
        Me.txtCustomerLastName.Name = "txtCustomerLastName"
        Me.txtCustomerLastName.Size = New System.Drawing.Size(186, 23)
        Me.txtCustomerLastName.TabIndex = 11
        Me.txtCustomerLastName.Tag = ""
        Me.txtCustomerLastName.Text = "Last Name"
        Me.txtCustomerLastName.Visible = False
        '
        'txtCustomerCity
        '
        Me.txtCustomerCity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerCity.Location = New System.Drawing.Point(13, 363)
        Me.txtCustomerCity.Name = "txtCustomerCity"
        Me.txtCustomerCity.Size = New System.Drawing.Size(155, 23)
        Me.txtCustomerCity.TabIndex = 12
        Me.txtCustomerCity.Text = "City"
        Me.txtCustomerCity.Visible = False
        '
        'btnPurchase
        '
        Me.btnPurchase.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPurchase.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnPurchase.Location = New System.Drawing.Point(317, 468)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(145, 30)
        Me.btnPurchase.TabIndex = 13
        Me.btnPurchase.Text = "Purchase Ticket(s)"
        Me.btnPurchase.UseVisualStyleBackColor = False
        Me.btnPurchase.Visible = False
        '
        'lblTHFirstName
        '
        Me.lblTHFirstName.AutoSize = True
        Me.lblTHFirstName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTHFirstName.Location = New System.Drawing.Point(400, 275)
        Me.lblTHFirstName.Name = "lblTHFirstName"
        Me.lblTHFirstName.Size = New System.Drawing.Size(75, 16)
        Me.lblTHFirstName.TabIndex = 14
        Me.lblTHFirstName.Text = "First Name"
        Me.lblTHFirstName.Visible = False
        '
        'cboCustomerState
        '
        Me.cboCustomerState.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomerState.FormattingEnabled = True
        Me.cboCustomerState.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.cboCustomerState.Location = New System.Drawing.Point(186, 362)
        Me.cboCustomerState.Name = "cboCustomerState"
        Me.cboCustomerState.Size = New System.Drawing.Size(121, 24)
        Me.cboCustomerState.TabIndex = 17
        Me.cboCustomerState.Text = "State"
        Me.cboCustomerState.Visible = False
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerEmail.Location = New System.Drawing.Point(13, 428)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.Size = New System.Drawing.Size(309, 23)
        Me.txtCustomerEmail.TabIndex = 19
        Me.txtCustomerEmail.Text = "your@email.com"
        Me.txtCustomerEmail.Visible = False
        '
        'lblTicketHolder
        '
        Me.lblTicketHolder.AutoSize = True
        Me.lblTicketHolder.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketHolder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblTicketHolder.Location = New System.Drawing.Point(399, 224)
        Me.lblTicketHolder.Name = "lblTicketHolder"
        Me.lblTicketHolder.Size = New System.Drawing.Size(141, 19)
        Me.lblTicketHolder.TabIndex = 20
        Me.lblTicketHolder.Text = "Ticket Holder(s)"
        Me.lblTicketHolder.Visible = False
        '
        'lblTHLastName
        '
        Me.lblTHLastName.AutoSize = True
        Me.lblTHLastName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTHLastName.Location = New System.Drawing.Point(564, 275)
        Me.lblTHLastName.Name = "lblTHLastName"
        Me.lblTHLastName.Size = New System.Drawing.Size(75, 16)
        Me.lblTHLastName.TabIndex = 21
        Me.lblTHLastName.Text = "Last Name"
        Me.lblTHLastName.Visible = False
        '
        'lblTHSeat
        '
        Me.lblTHSeat.AutoSize = True
        Me.lblTHSeat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTHSeat.Location = New System.Drawing.Point(729, 275)
        Me.lblTHSeat.Name = "lblTHSeat"
        Me.lblTHSeat.Size = New System.Drawing.Size(38, 16)
        Me.lblTHSeat.TabIndex = 22
        Me.lblTHSeat.Text = "Seat"
        Me.lblTHSeat.Visible = False
        '
        'lblCustomerInfo
        '
        Me.lblCustomerInfo.AutoSize = True
        Me.lblCustomerInfo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblCustomerInfo.Location = New System.Drawing.Point(13, 267)
        Me.lblCustomerInfo.Name = "lblCustomerInfo"
        Me.lblCustomerInfo.Size = New System.Drawing.Size(189, 19)
        Me.lblCustomerInfo.TabIndex = 23
        Me.lblCustomerInfo.Text = "Customer Information"
        Me.lblCustomerInfo.Visible = False
        '
        'lblFlightSelection
        '
        Me.lblFlightSelection.AutoSize = True
        Me.lblFlightSelection.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlightSelection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblFlightSelection.Location = New System.Drawing.Point(10, 112)
        Me.lblFlightSelection.Name = "lblFlightSelection"
        Me.lblFlightSelection.Size = New System.Drawing.Size(135, 19)
        Me.lblFlightSelection.TabIndex = 24
        Me.lblFlightSelection.Text = "Flight Selection"
        '
        'chkPurchaserIsTH
        '
        Me.chkPurchaserIsTH.AutoSize = True
        Me.chkPurchaserIsTH.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPurchaserIsTH.Location = New System.Drawing.Point(403, 249)
        Me.chkPurchaserIsTH.Name = "chkPurchaserIsTH"
        Me.chkPurchaserIsTH.Size = New System.Drawing.Size(257, 20)
        Me.chkPurchaserIsTH.TabIndex = 30
        Me.chkPurchaserIsTH.Text = "Are you purchasing a ticket for yourself?"
        Me.chkPurchaserIsTH.UseVisualStyleBackColor = True
        Me.chkPurchaserIsTH.Visible = False
        '
        'lblFLightInfo
        '
        Me.lblFLightInfo.AutoSize = True
        Me.lblFLightInfo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFLightInfo.ForeColor = System.Drawing.Color.SkyBlue
        Me.lblFLightInfo.Location = New System.Drawing.Point(402, 117)
        Me.lblFLightInfo.Name = "lblFLightInfo"
        Me.lblFLightInfo.Size = New System.Drawing.Size(63, 19)
        Me.lblFLightInfo.TabIndex = 31
        Me.lblFLightInfo.Text = "Label1"
        Me.lblFLightInfo.Visible = False
        '
        'lblTEST
        '
        Me.lblTEST.AutoSize = True
        Me.lblTEST.Location = New System.Drawing.Point(403, 140)
        Me.lblTEST.Name = "lblTEST"
        Me.lblTEST.Size = New System.Drawing.Size(39, 13)
        Me.lblTEST.TabIndex = 32
        Me.lblTEST.Text = "Label1"
        '
        'lblTEST2
        '
        Me.lblTEST2.AutoSize = True
        Me.lblTEST2.Location = New System.Drawing.Point(403, 178)
        Me.lblTEST2.Name = "lblTEST2"
        Me.lblTEST2.Size = New System.Drawing.Size(39, 13)
        Me.lblTEST2.TabIndex = 33
        Me.lblTEST2.Text = "Label1"
        '
        'txtCustomerPhone
        '
        Me.txtCustomerPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerPhone.Location = New System.Drawing.Point(14, 396)
        Me.txtCustomerPhone.Mask = "(999) 000-0000"
        Me.txtCustomerPhone.Name = "txtCustomerPhone"
        Me.txtCustomerPhone.Size = New System.Drawing.Size(100, 22)
        Me.txtCustomerPhone.TabIndex = 34
        Me.txtCustomerPhone.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.final_cp.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(406, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(428, 181)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblMessage.Location = New System.Drawing.Point(316, 506)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(50, 16)
        Me.lblMessage.TabIndex = 36
        Me.lblMessage.Text = "Label1"
        Me.lblMessage.Visible = False
        '
        'frmEngine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(834, 536)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtCustomerPhone)
        Me.Controls.Add(Me.lblTEST2)
        Me.Controls.Add(Me.lblTEST)
        Me.Controls.Add(Me.lblFLightInfo)
        Me.Controls.Add(Me.chkPurchaserIsTH)
        Me.Controls.Add(Me.lblFlightSelection)
        Me.Controls.Add(Me.lblCustomerInfo)
        Me.Controls.Add(Me.lblTHSeat)
        Me.Controls.Add(Me.lblTHLastName)
        Me.Controls.Add(Me.lblTicketHolder)
        Me.Controls.Add(Me.txtCustomerEmail)
        Me.Controls.Add(Me.cboCustomerState)
        Me.Controls.Add(Me.lblTHFirstName)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.txtCustomerCity)
        Me.Controls.Add(Me.txtCustomerLastName)
        Me.Controls.Add(Me.txtCustomerStreetAddress)
        Me.Controls.Add(Me.txtCustomerFirstName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.cboNumberOfTickets)
        Me.Controls.Add(Me.cboFlightTime)
        Me.Controls.Add(Me.cboDestinationCity)
        Me.Controls.Add(Me.cboOriginCity)
        Me.Controls.Add(Me.lblCAREHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEngine"
        Me.Text = "CARE System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCAREHeader As System.Windows.Forms.Label
    Friend WithEvents cboOriginCity As System.Windows.Forms.ComboBox
    Friend WithEvents cboDestinationCity As System.Windows.Forms.ComboBox
    Friend WithEvents cboFlightTime As System.Windows.Forms.ComboBox
    Friend WithEvents cboNumberOfTickets As System.Windows.Forms.ComboBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtCustomerFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerStreetAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerCity As System.Windows.Forms.TextBox
    Friend WithEvents btnPurchase As System.Windows.Forms.Button
    Friend WithEvents mnuSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTHFirstName As System.Windows.Forms.Label
    Friend WithEvents cboCustomerState As System.Windows.Forms.ComboBox
    Friend WithEvents txtCustomerEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblTicketHolder As System.Windows.Forms.Label
    Friend WithEvents lblTHLastName As System.Windows.Forms.Label
    Friend WithEvents lblTHSeat As System.Windows.Forms.Label
    Friend WithEvents lblCustomerInfo As System.Windows.Forms.Label
    Friend WithEvents lblFlightSelection As System.Windows.Forms.Label
    Friend WithEvents chkPurchaserIsTH As System.Windows.Forms.CheckBox
    Friend WithEvents lblFLightInfo As System.Windows.Forms.Label
    Friend WithEvents lblTEST As System.Windows.Forms.Label
    Friend WithEvents lblTEST2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
