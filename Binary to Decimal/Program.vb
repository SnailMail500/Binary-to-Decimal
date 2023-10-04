Imports System

Module Program
    Sub Main(args As String())
        Dim decEntry As Integer
        Dim temp As Integer
        Dim tempMod As Integer
        Dim digits() As Integer = (0, 0, 0, 0, 0, 0, 0, 0) 'what in the name of all that is unholy is this- also how fix?
        Dim loopCounter As Integer
        Dim valid As Boolean = False
        Do Until valid = True
            Console.WriteLine("Enter a natural decimal number up to 255: ")
            decEntry = Console.ReadLine()
            If decEntry > 255 Then
                Console.WriteLine("Oops, that number was too high! Please try again...")
            ElseIf decEntry < 0 Then
                Console.WriteLine("Oops, that number was too low! Please try again...")
            ElseIf decEntry = 0 Then
                Console.WriteLine(decEntry & " in binary = 0000 0000")
                valid = True
            Else
                Do Until decEntry = 0 Or decEntry = 1 Or loopCounter = 7 ' this is all sorts of horrible
                    temp = decEntry / 2
                    decEntry = temp
                    tempMod = temp Mod 2
                    tempMod = digits(loopCounter)
                    loopCounter += 1
                    If loopCounter = 7 And decEntry = 1 Then
                        digits(7) = 1
                    End If
                Loop
                Console.WriteLine(digits)
            End If
        Loop
    End Sub
End Module



