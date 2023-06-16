Imports System
'This program calculates the VAT and outputs it in the main code
Module Program
    Sub Main(args As String())
        'Calling the function so that it runs in the main code
        Call calculateVAT()
        Console.ReadLine()

    End Sub
End Module
Module myFunction
    'Creating a function which is specfically targeted to calculate the VAT
    Public Function calculateVAT() As Integer
        'Delcaring the variables
        Dim price As Integer
        Console.Write("Please enter the price of your item")
        price = Console.ReadLine
        Console.WriteLine("The price of your item is:£" & price)
        'Assigning a constant to percentage - which is the VAT percentage
        Dim percentage As Decimal = 0.2
        'FormulaVAT calculates the VAT added on and then VATadded shows the amount added
        Dim formulaVAT As Integer = price + (price * percentage)
        Dim VATadded As Integer = formulaVAT - price
        'Outputs a result to the user
        Console.WriteLine("The vat added is:£" & VATadded)
        'causes program flow to leave the function and return to the calling program
        Return formulaVAT
    End Function
End Module
