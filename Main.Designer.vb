<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuRegister = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewPatient = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsListAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlsFindPatient = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterationSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BillingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BilledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.menuRegister, Me.PatientToolStripMenuItem, Me.BillingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(311, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'menuRegister
        '
        Me.menuRegister.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewPatient})
        Me.menuRegister.Name = "menuRegister"
        Me.menuRegister.Size = New System.Drawing.Size(61, 20)
        Me.menuRegister.Text = "Register"
        '
        'AddNewPatient
        '
        Me.AddNewPatient.Name = "AddNewPatient"
        Me.AddNewPatient.Size = New System.Drawing.Size(152, 22)
        Me.AddNewPatient.Text = "Patient"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsListAll, Me.tlsFindPatient, Me.RegisterationSlipToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.PatientToolStripMenuItem.Text = "patient"
        '
        'tlsListAll
        '
        Me.tlsListAll.Name = "tlsListAll"
        Me.tlsListAll.Size = New System.Drawing.Size(162, 22)
        Me.tlsListAll.Text = "List all"
        '
        'tlsFindPatient
        '
        Me.tlsFindPatient.Name = "tlsFindPatient"
        Me.tlsFindPatient.Size = New System.Drawing.Size(162, 22)
        Me.tlsFindPatient.Text = "Find patient"
        '
        'RegisterationSlipToolStripMenuItem
        '
        Me.RegisterationSlipToolStripMenuItem.Name = "RegisterationSlipToolStripMenuItem"
        Me.RegisterationSlipToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RegisterationSlipToolStripMenuItem.Text = "RegisterationSlip"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 147)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'BillingToolStripMenuItem
        '
        Me.BillingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillToolStripMenuItem, Me.BilledToolStripMenuItem})
        Me.BillingToolStripMenuItem.Name = "BillingToolStripMenuItem"
        Me.BillingToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.BillingToolStripMenuItem.Text = "Billing"
        '
        'BillToolStripMenuItem
        '
        Me.BillToolStripMenuItem.Name = "BillToolStripMenuItem"
        Me.BillToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BillToolStripMenuItem.Text = "Bill"
        '
        'BilledToolStripMenuItem
        '
        Me.BilledToolStripMenuItem.Name = "BilledToolStripMenuItem"
        Me.BilledToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BilledToolStripMenuItem.Text = "Billed"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 289)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuRegister As ToolStripMenuItem
    Friend WithEvents AddNewPatient As ToolStripMenuItem
    Friend WithEvents PatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tlsListAll As ToolStripMenuItem
    Friend WithEvents tlsFindPatient As ToolStripMenuItem
    Friend WithEvents RegisterationSlipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BillingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BillToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BilledToolStripMenuItem As ToolStripMenuItem
End Class
