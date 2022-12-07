Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DrawRectangle()
        Dim canvas As RectangleShape = New RectangleShape
        Dim rect1 As ShapeContainer = New ShapeContainer
        ' Set the form as the parent of the ShapeContainer.
        canvas.Parent = Me
        ' Set the ShapeContainer as the parent of the RectangleShape.
        rect1.Parent = canvas
        ' Set the location and size of the rectangle.
        rect1.Left = 10
        rect1.Top = 10
        rect1.Width = 300
        rect1.Height = 100
    End Sub
End Class
