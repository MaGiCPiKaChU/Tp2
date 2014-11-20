Public Class frmDateHeure

    Private Sub frmDateHeure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dateTime As DateTime = New  _
        DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, Now.Second)

        Dim d() As String = Nothing

        d = dateTime.GetDateTimeFormats()

        lbDateHeure.Items.AddRange(d)


    End Sub

    Public Sub RemoveListBoxDuplicates(pobjLB As ListBox)


        Dim i, j As Integer

        For i = 0 To lbDateHeure.Items.Count - 2
            For j = i To lbDateHeure.Items.Count - 1
                If (lbDateHeure.Items.Item(i) = lbDateHeure.Items.Item(j)) Then
                    lbDateHeure.Items.RemoveAt(j)
                End If
            Next
        Next

    End Sub

    Private Sub BtnAccept_Click(sender As Object,
                                e As EventArgs) Handles BtnAccept.Click

        Dim Items As String
        From s As String In lbDateHeure.Items()

        frmEditeur.rtfZoneTexte.Text = String.Join(Environment.NewLine, Items)


    End Sub
End Class