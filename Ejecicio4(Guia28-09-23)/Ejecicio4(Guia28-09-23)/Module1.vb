Module Module1

    Sub Main()
        ' Entrada de datos
        Console.Write("Ingresa el primer número entero: ")
        Dim numero1 As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Ingresa el segundo número entero: ")
        Dim numero2 As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Ingresa el tercer número entero: ")
        Dim numero3 As Integer = Integer.Parse(Console.ReadLine())

        ' Cálculos
        Dim mayor, medio, menor As Integer

        ' Encontrar el mayor número
        mayor = Math.Max(Math.Max(numero1, numero2), numero3)

        ' Encontrar el menor número
        menor = Math.Min(Math.Min(numero1, numero2), numero3)

        ' Encontrar el número medio
        medio = numero1 + numero2 + numero3 - mayor - menor

        ' Salida de resultados
        Console.WriteLine("El mayor número es: " & mayor)
        Console.WriteLine("El número medio es: " & medio)
        Console.WriteLine("El menor número es: " & menor)
        '
        Console.WriteLine("Guia Didactica 01 de Programacion 2 Ing. Jonathan Carballo")
        Console.WriteLine("Desarrollado por Mario Enrique Menjivar Abarca .")
        Console.WriteLine("Fecha 28/09/2023")
    End Sub

End Module
