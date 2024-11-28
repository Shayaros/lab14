Public Class fTown
    ' Поле для зберігання даних про місто
    Public Property TheTown As Town

    ' Конструктор форми
    Public Sub New(t As Town)
        InitializeComponent()
        TheTown = t
    End Sub

    ' Завантаження даних у форму
    Private Sub fTown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TheTown IsNot Nothing Then
            tbName.Text = TheTown.Name
            tbCountry.Text = TheTown.Country
            tbRegion.Text = TheTown.Region
            tbPopulation.Text = TheTown.Population.ToString()
            tbYearIncome.Text = TheTown.YearIncome.ToString("0.00")
            tbSquare.Text = TheTown.Square.ToString("0.000")
            chbHasPort.Checked = TheTown.HasPort
            chbHasAirport.Checked = TheTown.HasAirport
        End If
    End Sub

    ' Обробник кнопки OK
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        TheTown.Name = tbName.Text.Trim()
        TheTown.Country = tbCountry.Text.Trim()
        TheTown.Region = tbRegion.Text.Trim()
        TheTown.Population = Integer.Parse(tbPopulation.Text.Trim())
        TheTown.YearIncome = Double.Parse(tbYearIncome.Text.Trim())
        TheTown.Square = Double.Parse(tbSquare.Text.Trim())
        TheTown.HasPort = chbHasPort.Checked
        TheTown.HasAirport = chbHasAirport.Checked
        DialogResult = DialogResult.OK
    End Sub

    ' Обробник кнопки Cancel
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class