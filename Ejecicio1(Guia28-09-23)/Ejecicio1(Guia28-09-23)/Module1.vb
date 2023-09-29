Module Module1

    Sub Main()
        ' Entrada de datos
        Console.Write("Ingresa la distancia recorrida en kilómetros (42.195 Km por defecto): ")
        Dim distanciaKm As Double = Double.Parse(Console.ReadLine())

        Console.Write("Ingresa el tiempo en horas: ")
        Dim horas As Integer = Integer.Parse(Console.ReadLine())

        Console.Write("Ingresa el tiempo en minutos: ")
        Dim minutos As Integer = Integer.Parse(Console.ReadLine())

        ' Cálculos
        Dim tiempoTotalEnHoras As Double = horas + (minutos / 60.0)
        Dim velocidadKmPorHora As Double = distanciaKm / tiempoTotalEnHoras
        Dim velocidadKmPorMinuto As Double = distanciaKm / (tiempoTotalEnHoras * 60)
        Dim velocidadKmPorSegundo As Double = distanciaKm / (tiempoTotalEnHoras * 3600)
        Dim velocidadMPorMinuto As Double = (distanciaKm * 1000) / (tiempoTotalEnHoras * 60)
        Dim velocidadMPorSegundo As Double = (distanciaKm * 1000) / (tiempoTotalEnHoras * 3600)

        ' Salida de resultados
        Console.WriteLine("Velocidad media:")
        Console.WriteLine("Km/h: " & velocidadKmPorHora.ToString("F2"))
        Console.WriteLine("Km/min: " & velocidadKmPorMinuto.ToString("F2"))
        Console.WriteLine("Km/s: " & velocidadKmPorSegundo.ToString("F2"))
        Console.WriteLine("m/min: " & velocidadMPorMinuto.ToString("F2"))
        Console.WriteLine("m/s: " & velocidadMPorSegundo.ToString("F2"))
        Console.WriteLine("Guia Didactica 01 de Programacion 2 Ing. Jonathan Carballo")
        Console.WriteLine("Desarrollado por Mario Enrique Menjivar Abarca .")
        Console.WriteLine("Fecha 28/09/2023")
    End Sub

End Module
