Module Module1

    Sub Main()
        ' Entrada de datos
        Console.Write("Ingresa el promedio mensual de infracciones (N): ")
        Dim promedioMensual As Integer = Integer.Parse(Console.ReadLine())

        ' Cálculos
        Dim infraccionesManana As Integer = CInt(promedioMensual * 0.2)
        Dim infraccionesTarde As Integer = CInt(promedioMensual * 0.35)
        Dim infraccionesNoche As Integer = CInt(promedioMensual * 0.45)

        ' Promedios diarios
        Dim diasEnElMes As Integer = 30 ' Suponiendo un mes de 30 días
        Dim promedioDiarioManana As Double = infraccionesManana / diasEnElMes
        Dim promedioDiarioTarde As Double = infraccionesTarde / diasEnElMes
        Dim promedioDiarioNoche As Double = infraccionesNoche / diasEnElMes

        ' Salida de resultados
        Console.WriteLine("Promedio diario de infracciones:")
        Console.WriteLine("Mañana: " & promedioDiarioManana.ToString("F2"))
        Console.WriteLine("Tarde: " & promedioDiarioTarde.ToString("F2"))
        Console.WriteLine("Noche: " & promedioDiarioNoche.ToString("F2"))
        Console.WriteLine("Guia Didactica 01 de Programacion 2 Ing. Jonathan Carballo")
        Console.WriteLine("Desarrollado por Mario Enrique Menjivar Abarca .")
        Console.WriteLine("Fecha 28/09/2023")
    End Sub

End Module
