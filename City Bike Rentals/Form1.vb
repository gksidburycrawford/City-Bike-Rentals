' Program:  City Bike Rental
' Author:   Geterry Sidbury-Crawford
' Date:     Oct 11, 2017
' Purpose:  This application calculates and displays the total cost
'           of renting multiple bikes for a 24 hour period.

Option Strict On


Public Class frmBikes

    ' Class level constant used in multiple modules
    Const _cdecPricePerBike As Decimal = 9.95D

    Private Sub btnCalculateCost_Click(sender As Object, e As EventArgs) Handles btnCalculateCost.Click
        ' This event handler calculates and displays the cost of the bikes
        ' rented (number of bikes times the cost per bike).

        'Dim strNumberofBikes As String
        'Dim intNumberofBikes As Integer
        'Dim DecTotalCost As Decimal



        'strNumberofBikes = txtNumberOfBikes.Text
        'intNumberofBikes = Convert.ToInt32(strNumberofBikes)
        'DecTotalCost = intNumberofBikes * _cdecPricePerBike

        'lblTotalCost.Text = DecTotalCost.ToString("C")

        'Input variables
        Dim strHeightInInches As String
        Dim intHeightInInches As Integer

        Dim intHeightInFeet As Integer
        Dim intRemainderInches As Integer

        'Output varibles
        strHeightInInches = txtNumberOfBikes.Text       'Memorize this!!
        intHeightInInches = Convert.ToInt32(strHeightInInches) 'MEMORIZE THIS TOO!!!

        intHeightInFeet = intHeightInInches \ 12
        intRemainderInches = intHeightInInches Mod 12

        lblTotalCost.Text = "you are " & intHeightInFeet.ToString() & " feet and " _
            & intRemainderInches.ToString() & " inches "


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'this event handler clear the number of bikes and clears the
        'total cost

        lblTotalCost.Text = ""
        txtNumberOfBikes.Clear()
        txtNumberOfBikes.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This event handler closes the form and exits the program.

        Close()

    End Sub

    Private Sub frmBikes_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' this event handler sets the price per bike in the cost heading,
        ' clears the total cost label, and sets the focus to the number of
        ' bikes textbox.

        lblTotalCost.Text = ""
        lblCostHeading.Text = _cdecPricePerBike.ToString("C") & " per Bike for 24 hours"


        txtNumberOfBikes.Focus()

    End Sub
End Class
