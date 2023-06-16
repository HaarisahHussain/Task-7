Imports System
Imports System.ComponentModel.Design
Imports System.Net.Sockets
Imports System.Reflection.Metadata.Ecma335
Imports System.Security.Cryptography
Imports System.Threading
Imports System.Transactions

'This program provides a conversion utility 
'Press the enter key until the program tells user to exit

Module Program
    Sub Main()

        'Outputting a menu and the conversions that are taking place, which are then being called
        Console.WriteLine("You can choose from CM, Inches, Kilogram, Pounds, Grams and Ounces.")
        Console.WriteLine("The first conversion is CM to Inch: ")
        Call ConversionCmToInch()
        Console.ReadLine()
        Console.WriteLine("The Second conversion is KG to Pounds: ")
        Call ConversionKGToPounds()
        Console.ReadLine()
        Console.WriteLine("The Third conversion is Grams to Ounces: ")
        Call ConversionGramToOunces()
        Console.ReadLine()
        Console.WriteLine("You may exit the program now.")
        Console.ReadLine()

    End Sub
End Module
'CM to inches = divide by 2.54 to get to cm & multiply by 2.54 to get CM
Module CMtoInches
    Public Function ConversionCmToInch() As Decimal
        'delcaring variables
        Dim value As Decimal
        Console.Write("Enter your value to convert")
        value = Console.ReadLine
        'declaring variables & assigning formulas 
        Dim conversionToInch As Decimal = value / 2.54
        Dim conversionToCM As Decimal = value * 2.54
        'Outputs the values 
        Console.Write("Your value in inches is: " & conversionToInch & "'")
        Console.ReadLine()
        Console.Write("Your value in CM is: " & conversionToCM & "CM")
        Console.ReadLine()

        Return conversionToInch
        Return conversionToCM


    End Function


End Module
'kilogram to pounds = multiply kg by 2.205, divide pound by 2.205
Module KGToPounds
    Public Function ConversionKGToPounds() As Decimal
        'Delcares the variables
        Dim value As Decimal
        Console.Write("Enter your value to convert")
        value = Console.ReadLine
        'Delcaring variables and assinging formulas 
        Dim conversionToKG As Decimal = value / 2.205
        Dim conversionToCPounds As Decimal = value * 2.205
        Console.Write("Your value in KG is: " & conversionToKG & " KG")
        Console.ReadLine()
        Console.Write("Your value in Pounds is: " & conversionToCPounds & " lb")
        Console.ReadLine()

        Return conversionToKG
        Return conversionToCPounds


    End Function

End Module
'gram to ounces =  divide gram by  0.035 amd multiply ounces by 0.035
Module GramToOunces
    Public Function ConversionGramToOunces() As Decimal

        Dim value As Decimal
        Console.Write("Enter your value to convert")
        value = Console.ReadLine

        Dim conversionToGram As Decimal = value * 0.035
        Dim conversionToOunces As Decimal = value / 0.035
        Console.Write("Your value in grams is:  " & conversionToGram & " g")
        Console.ReadLine()
        Console.Write("Your value in ounces is: " & conversionToOunces & " oz")
        Console.ReadLine()
        Return conversionToGram
        Return conversionToOunces



    End Function

End Module

