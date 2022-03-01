Public Class Nelinurk
    Inherits Kujund

    Protected kylgD As Double

    'Konstruktor baasklassi atribuutide vaartustamiseks
    'ning klassi atribuudi kylgD vaartustamiseks

    Public Sub New(ByVal tyyp As String, ByVal kylgA As Double, ByVal kylgB As Double, ByVal kylgC As Double,
                    ByVal kylgD As Double)
        'baasklassi konstruktori valjakutse
        MyBase.New(tyyp, kylgA, kylgB, kylgC)

        'atribuudi kylgD algvaartustamine
        Me.kylgD = kylgD
    End Sub
    'funktsiion arvutab ja tagastab nlinurga umbermoodu
    Public Overrides Function leiaYmberMoot() As Double
        Return kylgA + kylgB + kylgC + kylgD
    End Function

    'funktsiion arvutab ja tagastab nlinurga pindala
    'selle meetodi funktsionaalsuse kiorjutame Nelinurk klassi alamklassis ule
    Public Overrides Function leiaPindala() As Double
        Return 0
    End Function
End Class
