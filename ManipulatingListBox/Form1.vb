Public Class Form1
    Dim composers() As String = IO.File.ReadAllLines("C:\Users\angel\Desktop\VS\ManipulatingListBox\ManipulatingListBox\bin\Debug\composer.txt")


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ListBox1.Items.AddRange(composers)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Integer = 0
        For i As Integer = 0 To (ListBox1.Items.Count - 1)
            If CStr(ListBox1.Items(i)).Length = 6 Then
                total += 1
            End If
        Next
        TextBox1.Text = CStr(total)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim highestIndex As Integer = ListBox1.Items.Count - 1
        Dim composers(highestIndex) As String
        For i As Integer = 0 To highestIndex
            composers(i) = CStr(ListBox1.Items(i))
        Next
        ListBox1.Items.Clear()
        ListBox1.Sorted = False
        For i As Integer = highestIndex To 0 Step -1
            ListBox1.Items.Add(composers(i))
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim highestIndex As Integer = ListBox1.Items.Count - 1
        Dim composers(highestIndex) As String
        For i As Integer = 0 To highestIndex
            composers(i) = CStr(ListBox1.Items(highestIndex - i))
        Next
        ListBox1.Sorted = False
        ListBox1.DataSource = composers
    End Sub

End Class
