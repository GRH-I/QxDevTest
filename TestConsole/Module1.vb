



Module Module1

    Sub Main()

        Console.WriteLine("Testing QxDataLayer, hit enter to continue........")
        Console.ReadLine()

        'Dim ents As New DataLayerEntities
        'Dim prop As New QxProp

        'prop.id = Guid.NewGuid.ToString
        'prop.Name = "200x75_PFC"
        'prop.Length = 2004
        'ents.QxProps.Add(prop)


        'sp.Id = Guid.NewGuid.ToString
        'sp.Name = "250x90_PFC"
        'ents.SteelProps.Add(sp)

        'sp.Id = Guid.NewGuid.ToString
        'sp.Name = "300x90_PFC"
        'ents.SteelProps.Add(sp)

        'sp.Id = Guid.NewGuid.ToString
        'sp.Name = "380x100_PFC"
        'ents.SteelProps.Add(sp)


        '  ents.SaveChanges()

        Console.WriteLine("prepare to read data back from database.....")

        'For Each prop As SteelProp In ents.SteelProps
        '    Console.WriteLine(String.Format("Db row id: {0}, Name: {1}", prop.Id.ToString, prop.Name.ToString))
        'Next

        Console.ReadLine()

    End Sub

End Module
