Public Class SortWords

    Private Sub SortWords_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim line As String = "in oreder to create a more perfect"
        Dim words() As String = line.Split(" ")
        Dim numquery = From word In words
                       Order By word Descending
                       Select word
        For Each n As String In numquery
            ListBox1.Items.Add(n)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'gets text from file
        Dim query = From name In IO.File.ReadAllLines("babynames.txt")
                    Order By name Ascending 're-organize by alphabet
                    Select name
        'writes names in listbox
        For Each babyname As String In query
            ListBox1.Items.Add(babyname)
        Next
        'writes new document with names organized
        IO.File.WriteAllLines("NewFile.txt", query)
    End Sub
End Class