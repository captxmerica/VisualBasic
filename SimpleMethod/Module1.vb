Module Module1

    Sub Main()

        Console.WriteLine("The Name Game")

        Console.Write("What's your first name? ")
        Dim firstName As String = Console.ReadLine()

        Console.Write("What's your last name? ")
        Dim lastName As String = Console.ReadLine()

        Console.Write("In what city were you born? ")
        Dim city As String = Console.ReadLine()

        Dim firstNameArray As Char() = firstName.ToCharArray()
        Array.Reverse(firstNameArray)

        Dim lastNameArray As Char() = lastName.ToCharArray()
        Array.Reverse(lastNameArray)

        Dim cityArray As Char() = city.ToCharArray()
        Array.Reverse(cityArray)

        DisplayResult(firstNameArray, lastNameArray, cityArray)


        Console.ReadLine()

    End Sub


    Sub DisplayResult(reversedFirstName As String,
                      reversedLastName As String,
                      reversedCity As String)

        Console.Write("Results: ")
        Console.Write("{0} {1} {2}",
                      reversedFirstName,
                      reversedLastName,
                      reversedCity)


    End Sub


End Module
