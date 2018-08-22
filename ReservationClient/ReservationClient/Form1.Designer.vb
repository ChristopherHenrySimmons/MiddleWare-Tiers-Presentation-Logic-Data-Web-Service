<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.seatType = New System.Windows.Forms.ComboBox()
        Me.classType = New System.Windows.Forms.ComboBox()
        Me.LabelDeleteEmployee = New System.Windows.Forms.Label()
        Me.TextBoxEmployeeID = New System.Windows.Forms.TextBox()
        Me.LabelEmployeeID = New System.Windows.Forms.Label()
        Me.ButtonDeleteEmployee = New System.Windows.Forms.Button()
        Me.LabelInsertCustomer = New System.Windows.Forms.Label()
        Me.LabelFullName = New System.Windows.Forms.Label()
        Me.TextBoxFullName = New System.Windows.Forms.TextBox()
        Me.LabelBillingAddress = New System.Windows.Forms.Label()
        Me.TextBoxBillingAddress = New System.Windows.Forms.TextBox()
        Me.LabelBillingCity = New System.Windows.Forms.Label()
        Me.TextBoxBillingCity = New System.Windows.Forms.TextBox()
        Me.LabelBillingState = New System.Windows.Forms.Label()
        Me.TextBoxBillingState = New System.Windows.Forms.TextBox()
        Me.LabelBillingZIPCide = New System.Windows.Forms.Label()
        Me.TextBoxBillingZIPCide = New System.Windows.Forms.TextBox()
        Me.LabelEmailAddress = New System.Windows.Forms.Label()
        Me.TextBoxEmailAddress = New System.Windows.Forms.TextBox()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.TextBoxDeleteEmployeeReturn = New System.Windows.Forms.TextBox()
        Me.TextBoxInsertCustomerReturn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(817, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(817, 422)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 20)
        Me.TextBox1.TabIndex = 1
        '
        'seatType
        '
        Me.seatType.FormattingEnabled = True
        Me.seatType.Items.AddRange(New Object() {"Window", "Middle", "Aisle"})
        Me.seatType.Location = New System.Drawing.Point(817, 339)
        Me.seatType.Name = "seatType"
        Me.seatType.Size = New System.Drawing.Size(121, 21)
        Me.seatType.TabIndex = 2
        '
        'classType
        '
        Me.classType.FormattingEnabled = True
        Me.classType.Items.AddRange(New Object() {"Economy", "First"})
        Me.classType.Location = New System.Drawing.Point(817, 366)
        Me.classType.Name = "classType"
        Me.classType.Size = New System.Drawing.Size(121, 21)
        Me.classType.TabIndex = 3
        '
        'LabelDeleteEmployee
        '
        Me.LabelDeleteEmployee.AutoSize = True
        Me.LabelDeleteEmployee.Font = New System.Drawing.Font("OCR A Std", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeleteEmployee.Location = New System.Drawing.Point(13, 9)
        Me.LabelDeleteEmployee.Name = "LabelDeleteEmployee"
        Me.LabelDeleteEmployee.Size = New System.Drawing.Size(250, 22)
        Me.LabelDeleteEmployee.TabIndex = 4
        Me.LabelDeleteEmployee.Text = "Delete Employee"
        '
        'TextBoxEmployeeID
        '
        Me.TextBoxEmployeeID.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmployeeID.Location = New System.Drawing.Point(17, 73)
        Me.TextBoxEmployeeID.Name = "TextBoxEmployeeID"
        Me.TextBoxEmployeeID.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxEmployeeID.TabIndex = 5
        '
        'LabelEmployeeID
        '
        Me.LabelEmployeeID.AutoSize = True
        Me.LabelEmployeeID.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmployeeID.Location = New System.Drawing.Point(14, 56)
        Me.LabelEmployeeID.Name = "LabelEmployeeID"
        Me.LabelEmployeeID.Size = New System.Drawing.Size(106, 14)
        Me.LabelEmployeeID.TabIndex = 6
        Me.LabelEmployeeID.Text = "Employee ID"
        '
        'ButtonDeleteEmployee
        '
        Me.ButtonDeleteEmployee.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeleteEmployee.Location = New System.Drawing.Point(123, 72)
        Me.ButtonDeleteEmployee.Name = "ButtonDeleteEmployee"
        Me.ButtonDeleteEmployee.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDeleteEmployee.TabIndex = 7
        Me.ButtonDeleteEmployee.Text = "DELETE"
        Me.ButtonDeleteEmployee.UseVisualStyleBackColor = True
        '
        'LabelInsertCustomer
        '
        Me.LabelInsertCustomer.AutoSize = True
        Me.LabelInsertCustomer.Font = New System.Drawing.Font("OCR A Std", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInsertCustomer.Location = New System.Drawing.Point(321, 9)
        Me.LabelInsertCustomer.Name = "LabelInsertCustomer"
        Me.LabelInsertCustomer.Size = New System.Drawing.Size(234, 22)
        Me.LabelInsertCustomer.TabIndex = 8
        Me.LabelInsertCustomer.Text = "InsertCustomer"
        '
        'LabelFullName
        '
        Me.LabelFullName.AutoSize = True
        Me.LabelFullName.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFullName.Location = New System.Drawing.Point(322, 56)
        Me.LabelFullName.Name = "LabelFullName"
        Me.LabelFullName.Size = New System.Drawing.Size(88, 14)
        Me.LabelFullName.TabIndex = 10
        Me.LabelFullName.Text = "Full Name"
        '
        'TextBoxFullName
        '
        Me.TextBoxFullName.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFullName.Location = New System.Drawing.Point(325, 73)
        Me.TextBoxFullName.Name = "TextBoxFullName"
        Me.TextBoxFullName.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxFullName.TabIndex = 9
        '
        'LabelBillingAddress
        '
        Me.LabelBillingAddress.AutoSize = True
        Me.LabelBillingAddress.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBillingAddress.Location = New System.Drawing.Point(322, 99)
        Me.LabelBillingAddress.Name = "LabelBillingAddress"
        Me.LabelBillingAddress.Size = New System.Drawing.Size(142, 14)
        Me.LabelBillingAddress.TabIndex = 12
        Me.LabelBillingAddress.Text = "Billing Address"
        '
        'TextBoxBillingAddress
        '
        Me.TextBoxBillingAddress.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBillingAddress.Location = New System.Drawing.Point(325, 116)
        Me.TextBoxBillingAddress.Name = "TextBoxBillingAddress"
        Me.TextBoxBillingAddress.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxBillingAddress.TabIndex = 11
        '
        'LabelBillingCity
        '
        Me.LabelBillingCity.AutoSize = True
        Me.LabelBillingCity.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBillingCity.Location = New System.Drawing.Point(322, 146)
        Me.LabelBillingCity.Name = "LabelBillingCity"
        Me.LabelBillingCity.Size = New System.Drawing.Size(115, 14)
        Me.LabelBillingCity.TabIndex = 14
        Me.LabelBillingCity.Text = "Billing City"
        '
        'TextBoxBillingCity
        '
        Me.TextBoxBillingCity.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBillingCity.Location = New System.Drawing.Point(325, 163)
        Me.TextBoxBillingCity.Name = "TextBoxBillingCity"
        Me.TextBoxBillingCity.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxBillingCity.TabIndex = 13
        '
        'LabelBillingState
        '
        Me.LabelBillingState.AutoSize = True
        Me.LabelBillingState.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBillingState.Location = New System.Drawing.Point(322, 189)
        Me.LabelBillingState.Name = "LabelBillingState"
        Me.LabelBillingState.Size = New System.Drawing.Size(124, 14)
        Me.LabelBillingState.TabIndex = 16
        Me.LabelBillingState.Text = "Billing State"
        '
        'TextBoxBillingState
        '
        Me.TextBoxBillingState.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBillingState.Location = New System.Drawing.Point(325, 206)
        Me.TextBoxBillingState.Name = "TextBoxBillingState"
        Me.TextBoxBillingState.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxBillingState.TabIndex = 15
        '
        'LabelBillingZIPCide
        '
        Me.LabelBillingZIPCide.AutoSize = True
        Me.LabelBillingZIPCide.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBillingZIPCide.Location = New System.Drawing.Point(322, 232)
        Me.LabelBillingZIPCide.Name = "LabelBillingZIPCide"
        Me.LabelBillingZIPCide.Size = New System.Drawing.Size(142, 14)
        Me.LabelBillingZIPCide.TabIndex = 18
        Me.LabelBillingZIPCide.Text = "Billing ZIPCide"
        '
        'TextBoxBillingZIPCide
        '
        Me.TextBoxBillingZIPCide.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBillingZIPCide.Location = New System.Drawing.Point(325, 249)
        Me.TextBoxBillingZIPCide.Name = "TextBoxBillingZIPCide"
        Me.TextBoxBillingZIPCide.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxBillingZIPCide.TabIndex = 17
        '
        'LabelEmailAddress
        '
        Me.LabelEmailAddress.AutoSize = True
        Me.LabelEmailAddress.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmailAddress.Location = New System.Drawing.Point(322, 278)
        Me.LabelEmailAddress.Name = "LabelEmailAddress"
        Me.LabelEmailAddress.Size = New System.Drawing.Size(124, 14)
        Me.LabelEmailAddress.TabIndex = 20
        Me.LabelEmailAddress.Text = "Email Address"
        '
        'TextBoxEmailAddress
        '
        Me.TextBoxEmailAddress.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmailAddress.Location = New System.Drawing.Point(325, 295)
        Me.TextBoxEmailAddress.Name = "TextBoxEmailAddress"
        Me.TextBoxEmailAddress.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxEmailAddress.TabIndex = 19
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInsert.Location = New System.Drawing.Point(480, 295)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInsert.TabIndex = 21
        Me.ButtonInsert.Text = "INSERT"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'TextBoxDeleteEmployeeReturn
        '
        Me.TextBoxDeleteEmployeeReturn.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDeleteEmployeeReturn.Location = New System.Drawing.Point(61, 102)
        Me.TextBoxDeleteEmployeeReturn.Name = "TextBoxDeleteEmployeeReturn"
        Me.TextBoxDeleteEmployeeReturn.Size = New System.Drawing.Size(56, 23)
        Me.TextBoxDeleteEmployeeReturn.TabIndex = 22
        '
        'TextBoxInsertCustomerReturn
        '
        Me.TextBoxInsertCustomerReturn.Font = New System.Drawing.Font("OCR A Std", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInsertCustomerReturn.Location = New System.Drawing.Point(393, 324)
        Me.TextBoxInsertCustomerReturn.Name = "TextBoxInsertCustomerReturn"
        Me.TextBoxInsertCustomerReturn.Size = New System.Drawing.Size(32, 23)
        Me.TextBoxInsertCustomerReturn.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 465)
        Me.Controls.Add(Me.TextBoxInsertCustomerReturn)
        Me.Controls.Add(Me.TextBoxDeleteEmployeeReturn)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.LabelEmailAddress)
        Me.Controls.Add(Me.TextBoxEmailAddress)
        Me.Controls.Add(Me.LabelBillingZIPCide)
        Me.Controls.Add(Me.TextBoxBillingZIPCide)
        Me.Controls.Add(Me.LabelBillingState)
        Me.Controls.Add(Me.TextBoxBillingState)
        Me.Controls.Add(Me.LabelBillingCity)
        Me.Controls.Add(Me.TextBoxBillingCity)
        Me.Controls.Add(Me.LabelBillingAddress)
        Me.Controls.Add(Me.TextBoxBillingAddress)
        Me.Controls.Add(Me.LabelFullName)
        Me.Controls.Add(Me.TextBoxFullName)
        Me.Controls.Add(Me.LabelInsertCustomer)
        Me.Controls.Add(Me.ButtonDeleteEmployee)
        Me.Controls.Add(Me.LabelEmployeeID)
        Me.Controls.Add(Me.TextBoxEmployeeID)
        Me.Controls.Add(Me.LabelDeleteEmployee)
        Me.Controls.Add(Me.classType)
        Me.Controls.Add(Me.seatType)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents seatType As ComboBox
    Friend WithEvents classType As ComboBox
    Friend WithEvents LabelDeleteEmployee As Label
    Friend WithEvents TextBoxEmployeeID As TextBox
    Friend WithEvents LabelEmployeeID As Label
    Friend WithEvents ButtonDeleteEmployee As Button
    Friend WithEvents LabelInsertCustomer As Label
    Friend WithEvents LabelFullName As Label
    Friend WithEvents TextBoxFullName As TextBox
    Friend WithEvents LabelBillingAddress As Label
    Friend WithEvents TextBoxBillingAddress As TextBox
    Friend WithEvents LabelBillingCity As Label
    Friend WithEvents TextBoxBillingCity As TextBox
    Friend WithEvents LabelBillingState As Label
    Friend WithEvents TextBoxBillingState As TextBox
    Friend WithEvents LabelBillingZIPCide As Label
    Friend WithEvents TextBoxBillingZIPCide As TextBox
    Friend WithEvents LabelEmailAddress As Label
    Friend WithEvents TextBoxEmailAddress As TextBox
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents TextBoxDeleteEmployeeReturn As TextBox
    Friend WithEvents TextBoxInsertCustomerReturn As TextBox
End Class
