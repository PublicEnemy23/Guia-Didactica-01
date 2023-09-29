Module Module1

    Sub Main()  ' Entrada de datos
        Console.Write("Ingresa el primer número entero (N1): ")
        Dim N1 As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Ingresa el segundo número entero (N2): ")
        Dim N2 As Integer = Integer.Parse(Console.ReadLine())

        ' Comprobar si N1 es divisor de N2
        If N2 Mod N1 = 0 Then
            Console.WriteLine($"{N1} es divisor de {N2}.")
        Else
            Console.WriteLine($"{N1} no es divisor de {N2}.")
        End If
        Console.WriteLine("Guia Didactica 01 de Programacion 2 Ing. Jonathan Carballo")
        Console.WriteLine("Desarrollado por Mario Enrique Menjivar Abarca .")
        Console.WriteLine("Fecha 28/09/2023")

    End Sub

End Module
