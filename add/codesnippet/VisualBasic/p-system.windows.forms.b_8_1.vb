    Private Sub PrintBindingIsBinding
        Dim c As Control
        Dim b As Binding
        For Each c In Me.Controls
            For Each b in c.DataBindings
                Console.WriteLine (ControlChars.CrLf & c.ToString)
                Console.WriteLine (b.PropertyName & " IsBinding: " & _
                    b.IsBinding)
            Next
        Next
    End Sub