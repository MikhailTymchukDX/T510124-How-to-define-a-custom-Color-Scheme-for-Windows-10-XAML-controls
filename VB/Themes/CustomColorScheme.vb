Imports DevExpress.Themes.ColorKeys
Imports DevExpress.Themes.Generic
Imports Windows.UI

Public Class CustomColorScheme
    Inherits GenericColorScheme
    Public Sub New(name As String)
        MyBase.New(name)
    End Sub
    Protected Overrides Sub Initialize()
        MyBase.Initialize()
        AllScopes.RibbonControlColors(RibbonControlColorKeys.HeaderBackground) = New DevExpress.Themes.ColorSet(Color.FromArgb(&HFF, &H41, &H83, &H66), Color.FromArgb(&HFF, &H16, &H4B, &H2F))
        AllScopes.RibbonControlColors(RibbonControlColorKeys.TitleForeground) = New DevExpress.Themes.ColorSet(Colors.Yellow, Colors.Orange)
    End Sub
End Class