<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fTown
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        tbName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        tbCountry = New TextBox()
        tbRegion = New TextBox()
        tbPopulation = New TextBox()
        tbYearIncome = New TextBox()
        tbSquare = New TextBox()
        GroupBox2 = New GroupBox()
        chbHasPort = New CheckBox()
        chbHasAirport = New CheckBox()
        btnOk = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(342, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(231, 58)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Загальні дані"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(270, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 1
        Label1.Text = "Назва міста:"
        ' 
        ' tbName
        ' 
        tbName.Location = New Point(350, 126)
        tbName.Name = "tbName"
        tbName.Size = New Size(129, 23)
        tbName.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(288, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 15)
        Label2.TabIndex = 3
        Label2.Text = "Країна:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(288, 187)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 4
        Label3.Text = "Регіон:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(221, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 15)
        Label4.TabIndex = 5
        Label4.Text = "Кількість мешканців:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(265, 239)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 15)
        Label5.TabIndex = 6
        Label5.Text = "Річний дохід:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(294, 263)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 15)
        Label6.TabIndex = 7
        Label6.Text = "Площа:"
        ' 
        ' tbCountry
        ' 
        tbCountry.Location = New Point(350, 155)
        tbCountry.Name = "tbCountry"
        tbCountry.Size = New Size(129, 23)
        tbCountry.TabIndex = 8
        ' 
        ' tbRegion
        ' 
        tbRegion.Location = New Point(350, 184)
        tbRegion.Name = "tbRegion"
        tbRegion.Size = New Size(129, 23)
        tbRegion.TabIndex = 9
        ' 
        ' tbPopulation
        ' 
        tbPopulation.Location = New Point(350, 211)
        tbPopulation.Name = "tbPopulation"
        tbPopulation.Size = New Size(129, 23)
        tbPopulation.TabIndex = 10
        ' 
        ' tbYearIncome
        ' 
        tbYearIncome.Location = New Point(350, 239)
        tbYearIncome.Name = "tbYearIncome"
        tbYearIncome.Size = New Size(129, 23)
        tbYearIncome.TabIndex = 11
        ' 
        ' tbSquare
        ' 
        tbSquare.Location = New Point(350, 263)
        tbSquare.Name = "tbSquare"
        tbSquare.Size = New Size(129, 23)
        tbSquare.TabIndex = 12
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Location = New Point(549, 133)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(136, 74)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Text = "Транспорт"
        ' 
        ' chbHasPort
        ' 
        chbHasPort.AutoSize = True
        chbHasPort.Location = New Point(516, 236)
        chbHasPort.Name = "chbHasPort"
        chbHasPort.Size = New Size(111, 19)
        chbHasPort.TabIndex = 14
        chbHasPort.Text = "Місто має порт"
        chbHasPort.UseVisualStyleBackColor = True
        ' 
        ' chbHasAirport
        ' 
        chbHasAirport.AutoSize = True
        chbHasAirport.Location = New Point(633, 235)
        chbHasAirport.Name = "chbHasAirport"
        chbHasAirport.Size = New Size(137, 19)
        chbHasAirport.TabIndex = 15
        chbHasAirport.Text = "Місто має аеропорт"
        chbHasAirport.UseVisualStyleBackColor = True
        ' 
        ' btnOk
        ' 
        btnOk.Location = New Point(350, 332)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(102, 29)
        btnOk.TabIndex = 16
        btnOk.Text = "OK"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(504, 332)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(102, 29)
        btnCancel.TabIndex = 17
        btnCancel.Text = "Скасувати"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' fTown
        ' 
        AcceptButton = btnOk
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(800, 450)
        Controls.Add(btnCancel)
        Controls.Add(btnOk)
        Controls.Add(chbHasAirport)
        Controls.Add(chbHasPort)
        Controls.Add(GroupBox2)
        Controls.Add(tbSquare)
        Controls.Add(tbYearIncome)
        Controls.Add(tbPopulation)
        Controls.Add(tbRegion)
        Controls.Add(tbCountry)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(tbName)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        MinimizeBox = False
        Name = "fTown"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Дані про нове місто"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCountry As TextBox
    Friend WithEvents tbRegion As TextBox
    Friend WithEvents tbPopulation As TextBox
    Friend WithEvents tbYearIncome As TextBox
    Friend WithEvents tbSquare As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chbHasPort As CheckBox
    Friend WithEvents chbHasAirport As CheckBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
End Class
