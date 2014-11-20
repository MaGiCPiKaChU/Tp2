Imports System.Threading
Imports System.Globalization

Public Class frmDateHeure

    Private Sub frmDateHeure_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Ajoute tous les formats de date à la ListBox
        Dim dateTime As DateTime = New  _
        DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, Now.Second)
        Thread.CurrentThread.CurrentCulture = New CultureInfo("fr-CA")
        Dim strDateFormats() As String = Nothing

        strDateFormats = dateTime.GetDateTimeFormats()

        lbDateHeure.Items.AddRange(strDateFormats)

        lbDateHeure.SelectedIndex = 0 'Sélectionne par défaut le premier item au démarrage


    End Sub

    Private Sub btnAccept_Click(sender As Object,
                                e As EventArgs) Handles BtnAccept.Click

        'Lorsque je sélectionne le format voulu, il est paste dans le RichTextBox
        Dim s As String

        s = lbDateHeure.SelectedItem

        frmEditeur.rtfZoneTexte.SelectedText = s

        MyBase.Close()


    End Sub



End Class