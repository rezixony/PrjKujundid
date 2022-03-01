Public Class Ristkylik
    Inherits Nelinurk

    'konstruktor baasklassi atribuutide algvaartustamiseks
    Public Sub New(ByVal alus As Double, ByVal korgus As Double)
        'Baasklassi konstruktori valjakutse
        MyBase.New("Ristkulik", alus, korgus, alus, korgus)
    End Sub

    ' Funktsioon arvutab ja tagastab ristküliku pindala
    Public Overrides Function leiaPindala() As Double
        Return kylgA * kylgB
    End Function

End Class
