Module Module1

    Sub Main()
        Console.WriteLine(CHAR_TO_CODE("a"))
    End Sub
    Function CHAR_TO_CODE(a As String) As Integer 'takes a as a parameter, this will be the users input
        Return Asc(a) 'returns the ASCII value from function
    End Function
End Module
