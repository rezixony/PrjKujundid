Public Class Ruut
    Inherits Nelinurk

    'konstruktor baasklassi atribuutide vaartustamiseks
    Public Sub New(ByVal kylg As Double)
        'baasklassi konstruktori valkakutse
        MyBase.New("Ruut", kylg, kylg, kylg, kylg)
    End Sub

    'funktsioon arvutab ja tagastab ruudu pindala
    Public Overrides Function leiaPindala() As Double
        Return kylgA * kylgB
    End Function
End Class
