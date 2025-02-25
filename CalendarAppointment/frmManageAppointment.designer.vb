<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageAppointment
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpAppdate = New System.Windows.Forms.DateTimePicker()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtresponse = New System.Windows.Forms.TextBox()
        Me.txtCasetype = New System.Windows.Forms.TextBox()
        Me.txtPname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtregid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpacampus = New System.Windows.Forms.TextBox()
        Me.btncont = New System.Windows.Forms.Button()
        Me.txtboxremark = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnendappont = New System.Windows.Forms.Button()
        Me.btnSaveappont = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorProviderMngeApp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProviderMngeApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(322, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(322, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Response / Work done"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(322, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(322, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Case Type / Comment"
        '
        'dtpAppdate
        '
        Me.dtpAppdate.Location = New System.Drawing.Point(455, 48)
        Me.dtpAppdate.Name = "dtpAppdate"
        Me.dtpAppdate.Size = New System.Drawing.Size(200, 20)
        Me.dtpAppdate.TabIndex = 4
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(455, 77)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(200, 20)
        Me.txtTime.TabIndex = 5
        '
        'txtresponse
        '
        Me.txtresponse.Location = New System.Drawing.Point(443, 168)
        Me.txtresponse.Multiline = True
        Me.txtresponse.Name = "txtresponse"
        Me.txtresponse.Size = New System.Drawing.Size(306, 78)
        Me.txtresponse.TabIndex = 6
        '
        'txtCasetype
        '
        Me.txtCasetype.Location = New System.Drawing.Point(443, 97)
        Me.txtCasetype.Multiline = True
        Me.txtCasetype.Name = "txtCasetype"
        Me.txtCasetype.Size = New System.Drawing.Size(306, 65)
        Me.txtCasetype.TabIndex = 7
        '
        'txtPname
        '
        Me.txtPname.Location = New System.Drawing.Point(111, 110)
        Me.txtPname.Name = "txtPname"
        Me.txtPname.ReadOnly = True
        Me.txtPname.Size = New System.Drawing.Size(200, 20)
        Me.txtPname.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Gainsboro
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(45, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Name"
        '
        'txtregid
        '
        Me.txtregid.Location = New System.Drawing.Point(111, 51)
        Me.txtregid.Name = "txtregid"
        Me.txtregid.Size = New System.Drawing.Size(130, 20)
        Me.txtregid.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(21, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Card Number"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtpacampus)
        Me.GroupBox1.Controls.Add(Me.btncont)
        Me.GroupBox1.Controls.Add(Me.txtboxremark)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnendappont)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnSaveappont)
        Me.GroupBox1.Controls.Add(Me.txtresponse)
        Me.GroupBox1.Controls.Add(Me.txtCasetype)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(755, 396)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New / Continue / End patient appointment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(45, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Branch"
        '
        'txtpacampus
        '
        Me.txtpacampus.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpacampus.Location = New System.Drawing.Point(99, 128)
        Me.txtpacampus.Name = "txtpacampus"
        Me.txtpacampus.ReadOnly = True
        Me.txtpacampus.Size = New System.Drawing.Size(200, 22)
        Me.txtpacampus.TabIndex = 20
        '
        'btncont
        '
        Me.btncont.BackColor = System.Drawing.Color.Transparent
        Me.btncont.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncont.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btncont.Location = New System.Drawing.Point(556, 351)
        Me.btncont.Name = "btncont"
        Me.btncont.Size = New System.Drawing.Size(100, 39)
        Me.btncont.TabIndex = 22
        Me.btncont.Text = "Continue Appointment"
        Me.btncont.UseVisualStyleBackColor = False
        '
        'txtboxremark
        '
        Me.txtboxremark.Location = New System.Drawing.Point(443, 252)
        Me.txtboxremark.Multiline = True
        Me.txtboxremark.Name = "txtboxremark"
        Me.txtboxremark.Size = New System.Drawing.Size(306, 78)
        Me.txtboxremark.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(322, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Remark / Other"
        '
        'btnendappont
        '
        Me.btnendappont.BackColor = System.Drawing.Color.Transparent
        Me.btnendappont.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnendappont.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnendappont.Location = New System.Drawing.Point(662, 351)
        Me.btnendappont.Name = "btnendappont"
        Me.btnendappont.Size = New System.Drawing.Size(87, 39)
        Me.btnendappont.TabIndex = 19
        Me.btnendappont.Text = "End  Appointment"
        Me.btnendappont.UseVisualStyleBackColor = False
        '
        'btnSaveappont
        '
        Me.btnSaveappont.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveappont.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveappont.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaveappont.Location = New System.Drawing.Point(443, 351)
        Me.btnSaveappont.Name = "btnSaveappont"
        Me.btnSaveappont.Size = New System.Drawing.Size(107, 39)
        Me.btnSaveappont.TabIndex = 18
        Me.btnSaveappont.Text = "Save New Appointment"
        Me.btnSaveappont.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(241, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ErrorProviderMngeApp
        '
        Me.ErrorProviderMngeApp.ContainerControl = Me
        '
        'frmManageAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(779, 420)
        Me.Controls.Add(Me.txtregid)
        Me.Controls.Add(Me.txtPname)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.dtpAppdate)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManageAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Patient Appointment / Emergency / Injection - Clinic System"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProviderMngeApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpAppdate As DateTimePicker
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtresponse As TextBox
    Friend WithEvents txtCasetype As TextBox
    Friend WithEvents txtPname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtregid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSaveappont As Button
    Friend WithEvents ErrorProviderMngeApp As ErrorProvider
    Friend WithEvents btnendappont As Button
    Friend WithEvents txtboxremark As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btncont As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpacampus As TextBox
End Class
