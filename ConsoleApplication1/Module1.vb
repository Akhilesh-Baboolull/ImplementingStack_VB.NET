Module Module1

    Structure stack
        Dim item As Integer
        Dim pointer As Integer
    End Structure

    Dim top As Integer
    Dim freecell As Integer


    '===================================================================
    Function IsEmpty() As Boolean
        If top = 0 Then
            IsEmpty = True
        Else
            IsEmpty = False
        End If
    End Function
    '=======================================================================
    Function IsFull() As Boolean

        If top = 10 Then
            IsFull = True
        Else
            IsFull = False
        End If

    End Function
    '=============================================================================
    Sub Push(ByVal ParamArray rec() As stack)

        If IsFull() = True Then
            Console.WriteLine("The Stack is full!")
        Else
            Console.WriteLine("Enter item: ")
            rec(freecell).item = Console.ReadLine()
            top = freecell
            freecell = freecell + 1
        End If

    End Sub
    '=======================================================================================
    Sub Pop(ByVal ParamArray rec() As stack)

        If IsEmpty() = True Then
            Console.WriteLine("The Stack is already empty!")
        Else

            top = top - 1
        End If

    End Sub

    '=============================================================================================

    Sub Main()

        Dim rec(10) As stack
        Dim i As Integer
        Dim choice As Integer

        top = 0
        freecell = 1

        Do

            Do
                Console.WriteLine("Menu:")
                Console.WriteLine("Press 1 to enter a item")
                Console.WriteLine("Press 2 to remove the last item added")
                Console.WriteLine("Press 3 to check whether the stack is full or empty")
                Console.WriteLine("Press 4 to display the Stack")
                Console.WriteLine("Press 0 to exit")
                Console.WriteLine()

                Console.Write("Choose from the above menu: ")
                choice = Console.ReadLine()

                If choice < 0 Or choice > 4 Then
                    Console.WriteLine("Invalid choice! Please Re-Enter!")
                    Console.WriteLine()
                End If

            Loop Until (choice >= 0 And choice <= 4)

            If choice = 1 Then
                Call Push(rec)
            Else
                If choice = 2 Then
                    Call Pop(rec)
                Else
                    If choice = 3 Then
                        Console.WriteLine("The stack is empty: " & IsEmpty())
                        Console.WriteLine("The stack is full: " & IsFull())
                    Else
                        If choice = 4 Then
                            For i = top To 1 Step -1
                                Console.WriteLine(rec(i).item)
                            Next
                        Else
                            If choice = 0 Then
                                Console.WriteLine("Press any key to exit!")
                            End If
                        End If
                    End If
                End If
            End If

            Console.WriteLine()
        Loop Until (choice = 0)


        Console.ReadKey()
    End Sub

End Module
