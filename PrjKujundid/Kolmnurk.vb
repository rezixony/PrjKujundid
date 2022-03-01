'matemaatikafunktsioonide kaasamine
Imports System.Math
Public Class Kolmnurk
    Inherits Kujund

    Private korgus As Double

    'Konstruktor baasklassi atribuutide vaartustamiseks
    Public Sub New(ByVal alus As Double, ByVal haar As Double)
        'Kutsume valja baasklassi konstruktori
        MyBase.New("Vordhaarne kolmnurk", alus, haar, haar)

        'Kolmnurga korgus
        Me.korgus = Sqrt(haar * haar - (alus * alus / 4))
    End Sub
    'Kolmnurga umbermoodu arvutamine
    Public Overrides Function leiaYmberMoot() As Double
        Return kylgA + kylgB + kylgC
    End Function

    'Kolmnurga pindala arvutamine
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus / 2
    End Function

    'overrides - kirjutame ule baasklassist kujund paritud samanimelise meetodi leiapindala()
End Class
