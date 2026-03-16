Module Module1

    Sub Main()

        'Mostramos el menú principal
        Console.WriteLine("Bienvenido")
        Console.WriteLine("------------------------------------------")
        Console.WriteLine()
        Console.WriteLine("Menú Principal")
        Console.WriteLine("     1. Consulta de Saldo")
        Console.WriteLine("     2. Ingresar")
        Console.WriteLine("     3. Retirar")
        Console.WriteLine("     4. Salir")

        'Quedamos a la espera
        Dim opcionUsuario As Integer = CInt(Console.ReadLine())

        'If opcionUsuario = 1 Then
        '    Console.WriteLine("Opcion 1")
        '    Console.ReadLine()

        'End If

        'If opcionUsuario = 2 Then
        '    Console.WriteLine("Opcion 2")
        '    Console.ReadLine()

        'End If

        If opcionUsuario = 1 Then
            Console.WriteLine("Opción 1")
            Console.ReadLine()
        ElseIf opcionUsuario = 2 Then
            Console.WriteLine("Opción 2")
            Console.ReadLine()
        ElseIf opcionUsuario = 3 Then
            Console.WriteLine("Opción 3")
            Console.ReadLine()
        ElseIf opcionUsuario = 4 Then
            Console.WriteLine("Seleccionó Salir")
            Console.ReadLine()
        End If

    End Sub

End Module
