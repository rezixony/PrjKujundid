Public Class Romb
    Inherits Nelinurk
    Private korgus As Double
    'konstruktor baasklassi atribuutide algvaartustamiseks
    Public Sub New(ByVal alus As Double, ByVal korgus As Double)
        'Baasklassi konstruktori valjakutse
        MyBase.New("Romb", alus, alus, alus, alus)

        Me.korgus = korgus

    End Sub

    ' Funktsioon arvutab ja tagastab ristküliku pindala
    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus
    End Function

End Class
