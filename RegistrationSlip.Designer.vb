﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientsLog
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientsLog))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.RegistrationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LilypadGardensDataSet = New VisualBasicFinalProject.LilypadGardensDataSet()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.RegistrationTableAdapter = New VisualBasicFinalProject.LilypadGardensDataSetTableAdapters.RegistrationTableAdapter()
        Me.txtChamber = New System.Windows.Forms.TextBox()
        Me.txtDrName = New System.Windows.Forms.TextBox()
        Me.RegistrationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CboPatient = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LilypadGardensDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cboCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(246, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dr. Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Chamber:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Patient Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date Of Birth:"
        '
        'txtPatientID
        '
        Me.txtPatientID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "PatientId", True))
        Me.txtPatientID.Enabled = False
        Me.txtPatientID.Location = New System.Drawing.Point(94, 68)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(100, 20)
        Me.txtPatientID.TabIndex = 6
        '
        'RegistrationBindingSource
        '
        Me.RegistrationBindingSource.DataMember = "Registration"
        Me.RegistrationBindingSource.DataSource = Me.LilypadGardensDataSet
        '
        'LilypadGardensDataSet
        '
        Me.LilypadGardensDataSet.DataSetName = "LilypadGardensDataSet"
        Me.LilypadGardensDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPatientName
        '
        Me.txtPatientName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Patient", True))
        Me.txtPatientName.Enabled = False
        Me.txtPatientName.Location = New System.Drawing.Point(94, 104)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(100, 20)
        Me.txtPatientName.TabIndex = 9
        '
        'txtBirthday
        '
        Me.txtBirthday.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Birthday", True))
        Me.txtBirthday.Enabled = False
        Me.txtBirthday.Location = New System.Drawing.Point(94, 145)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.Size = New System.Drawing.Size(100, 20)
        Me.txtBirthday.TabIndex = 10
        '
        'RegistrationTableAdapter
        '
        Me.RegistrationTableAdapter.ClearBeforeFill = True
        '
        'txtChamber
        '
        Me.txtChamber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Chamber", True))
        Me.txtChamber.Enabled = False
        Me.txtChamber.Location = New System.Drawing.Point(308, 105)
        Me.txtChamber.Multiline = True
        Me.txtChamber.Name = "txtChamber"
        Me.txtChamber.Size = New System.Drawing.Size(100, 20)
        Me.txtChamber.TabIndex = 8
        '
        'txtDrName
        '
        Me.txtDrName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Doctores", True))
        Me.txtDrName.Enabled = False
        Me.txtDrName.Location = New System.Drawing.Point(308, 65)
        Me.txtDrName.Multiline = True
        Me.txtDrName.Name = "txtDrName"
        Me.txtDrName.Size = New System.Drawing.Size(100, 20)
        Me.txtDrName.TabIndex = 7
        '
        'RegistrationBindingSource1
        '
        Me.RegistrationBindingSource1.DataMember = "Registration"
        Me.RegistrationBindingSource1.DataSource = Me.LilypadGardensDataSet
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistrationBindingSource, "Symptoms", True))
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(308, 138)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(240, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Symptoms:"
        '
        'cboCustomer
        '
        Me.cboCustomer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.CboPatient, Me.ToolStripSeparator2, Me.btnClose, Me.ToolStripSeparator4})
        Me.cboCustomer.Location = New System.Drawing.Point(0, 0)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(512, 25)
        Me.cboCustomer.TabIndex = 15
        Me.cboCustomer.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel1.Text = "Patients:"
        '
        'CboPatient
        '
        Me.CboPatient.Name = "CboPatient"
        Me.CboPatient.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnClose
        '
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 22)
        Me.btnClose.Text = "Close"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'PatientsLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 206)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtBirthday)
        Me.Controls.Add(Me.txtPatientName)
        Me.Controls.Add(Me.txtChamber)
        Me.Controls.Add(Me.txtDrName)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PatientsLog"
        Me.Text = "Registration Slip"
        CType(Me.RegistrationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LilypadGardensDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cboCustomer.ResumeLayout(False)
        Me.cboCustomer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents RegistrationTableAdapter As LilypadGardensDataSetTableAdapters.RegistrationTableAdapter
    Friend WithEvents LilypadGardensDataSet As LilypadGardensDataSet
    Friend WithEvents RegistrationBindingSource As BindingSource
    Friend WithEvents txtChamber As TextBox
    Friend WithEvents txtDrName As TextBox
    Friend WithEvents DoctoreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegistrationBindingSource1 As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboCustomer As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents CboPatient As ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnClose As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
End Class
