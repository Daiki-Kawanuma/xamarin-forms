﻿Imports Xamarin.Forms

Public Class App
    Inherits Application

    Public Sub New()
        Dim navi = New NavigationPage(New Page1)
        navi.BarBackgroundColor = Color.FromHex("3498db")
        navi.BarTextColor = Color.White
        MainPage = navi
    End Sub
    'Public Sub New()
    '    Dim label = New Label With {.XAlign = TextAlignment.Center,
    '                                .FontSize = Device.GetNamedSize(NamedSize.Medium, GetType(Label)),
    '                                .Text = "Welcome to Xamarin.Forms with Visual Basic.NET"}

    '    Dim stack = New StackLayout With {
    '        .VerticalOptions = LayoutOptions.Center
    '    }
    '    stack.Children.Add(label)

    '    Dim page = New ContentPage
    '    page.Content = stack
    '    MainPage = page

    'End Sub

End Class
