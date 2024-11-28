<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        tbTownsInfo = New TextBox()
        btnAddTown = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' tbTownsInfo
        ' 
        tbTownsInfo.Location = New Point(170, 12)
        tbTownsInfo.Multiline = True
        tbTownsInfo.Name = "tbTownsInfo"
        tbTownsInfo.ReadOnly = True
        tbTownsInfo.Size = New Size(483, 192)
        tbTownsInfo.TabIndex = 0
        ' 
        ' btnAddTown
        ' 
        btnAddTown.Location = New Point(232, 236)
        btnAddTown.Name = "btnAddTown"
        btnAddTown.Size = New Size(118, 82)
        btnAddTown.TabIndex = 1
        btnAddTown.Text = "Додати місто"
        btnAddTown.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(460, 236)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(118, 82)
        btnClose.TabIndex = 2
        btnClose.Text = "Закрити"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' FMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnAddTown)
        Controls.Add(tbTownsInfo)
        MaximizeBox = False
        Name = "FMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Лабораторна робота 14"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbTownsInfo As TextBox
    Friend WithEvents btnAddTown As Button
    Friend WithEvents btnClose As Button

End Class
