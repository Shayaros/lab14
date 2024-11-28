' Головна форма програми
Public Class FMain
    ' Обробник кнопки "Додати місто"
    Private Sub btnAddTown_Click(sender As Object, e As EventArgs) Handles btnAddTown.Click
        ' Створюємо новий об'єкт міста
        Dim town As New Town()

        ' Відкриваємо форму для введення даних про місто
        Dim ft As New fTown(town)

        ' Якщо користувач натиснув OK, додаємо місто до списку
        If ft.ShowDialog() = DialogResult.OK Then
            tbTownsInfo.Text &= String.Format("{0}, {1}, {2}, Мешканців: {3}, Річний дохід: {4} грн.{5}",
                                              town.Name, town.Country, town.Region, town.Population,
                                              town.YearIncome.ToString("0.00"), Environment.NewLine)
        End If
    End Sub

    ' Обробник кнопки "Закрити"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub

    ' Обробник завантаження головної форми
    Private Sub FMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ініціалізація, якщо потрібна
    End Sub
End Class

' Клас "Місто"
Public Class Town
    Public Property Name As String
    Public Property Country As String
    Public Property Region As String
    Public Property Population As Integer
    Public Property YearIncome As Double
    Public Property Square As Double
    Public Property HasPort As Boolean
    Public Property HasAirport As Boolean

    ' Метод для розрахунку річного доходу на мешканця
    Public Function GetYearIncomePerInhabitant() As Double
        If Population > 0 Then
            Return YearIncome / Population
        Else
            Return 0
        End If
    End Function
End Class