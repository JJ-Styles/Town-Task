Imports System.IO
Module Module1
    Structure Town
        Dim Name As String
        Dim County As String
        Dim Population As Integer
        Dim Area As Integer
    End Structure
    Sub Main()
        Dim Towns As Town
        Dim Filename As String = "C:\Users\User\Documents\Visual Studio 2019\Github\Town task\Town task\bin\Debug\town.bin"
        Dim CurrentFileName As New FileStream(Filename, FileMode.Open)
        Dim CurrentBinaryReader As New BinaryReader(CurrentFileName)

        Console.WriteLine("Town".PadRight(20) & "County".PadRight(15) & "Population".PadRight(18) & "Area".PadRight(7))
        Do While CurrentFileName.Position < CurrentFileName.Length
            Towns.Name = CurrentBinaryReader.ReadString
            Towns.County = CurrentBinaryReader.ReadString
            Towns.Population = CurrentBinaryReader.ReadInt32
            Towns.Area = CurrentBinaryReader.ReadInt32
            Console.WriteLine(Towns.Name.PadRight(20) & Towns.County.PadRight(15) & Towns.Population.ToString.PadRight(18) & Towns.Area.ToString.PadRight(7))
        Loop
            Console.ReadLine()
    End Sub
    Private Function AddingTowns()
        Dim Newtown As Town
        Dim filename As String = "C:\Users\User\Documents\Visual Studio 2019\Github\Town task\Town task\bin\Debug\town.bin"
        Dim currentfilename As New FileStream(filename, FileMode.Open)
        Dim currentbinarywriter As New BinaryWriter(currentfilename)
        Dim AnotherTown As String = "YES"

        Do Until AnotherTown <> "YES"
            Console.WriteLine("Please Enter The Name Of The New Town.")
            Newtown.Name = Console.ReadLine
        Loop

        Return Newtown
    End Function
End Module
