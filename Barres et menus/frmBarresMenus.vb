Public Class frmBarresMenus
 'Affichage de la date du jour sur la barre d'�tat
  Private Sub frmBarres_Load(ByVal sender As Object,
                             ByVal e As System.EventArgs) Handles MyBase.Load

    ssDate.Text = Date.Now.ToLongDateString
    rtfTexte.Focus()
  End Sub

 Private Sub SelectionChoix(ByVal sender As System.Object, _
                            ByVal e As System.EventArgs) Handles miRefaire.Click, miAnnuler.Click,
                                                                 miCouper.Click, cmCouper.Click, tsbCouper.Click,
                                                                 miCopier.Click, cmCopier.Click, tsbCopier.Click,
                                                                 miColler.Click, cmColler.Click, tsbColler.Click
    Select Case sender.name.ToString
      Case "miRefaire"
        rtfTexte.Redo()
      Case "miAnnuler"
        rtfTexte.Undo()
      Case "miCouper", "cmCouper", "tsbCouper"
        rtfTexte.Cut()
      Case "miCopier", "cmCopier", "tsbCopier"
        rtfTexte.Copy()
      Case Else   'choix Coller
        rtfTexte.Paste()
    End Select
  End Sub

  Private Sub SelectionStyle(ByVal sender As System.Object,
                             ByVal e As System.EventArgs) Handles miGras.Click, miItalique.Click,
                                                                  cmGras.Click, cmItalique.Click,
                                                                  tsbGras.Click, tsbItalique.Click
    Dim fsStyle As FontStyle

    sender.Checked = Not sender.checked

    Select Case sender.name.ToString
      Case "miGras", "miItalique"
        fsStyle = ((1 * miGras.Checked) + (2 * miItalique.Checked)) * -1
      Case "cmGras", "cmItalique"
        fsStyle = ((1 * cmGras.Checked) + (2 * cmItalique.Checked)) * -1
      Case Else    'Barre d'outils
        fsStyle = ((1 * tsbGras.Checked) + (2 * tsbItalique.Checked)) * -1
    End Select
    rtfTexte.SelectionFont = New Font(rtfTexte.Font, fsStyle)
    SynchroniserChoixSemblables(Nothing, Nothing)
  End Sub

  'Lorsque la s�lection change ou que le point d'insertion est d�plac�,
  'on doit resynchroniser l'acc�s des choix semblables.
  Private Sub SynchroniserChoixSemblables(ByVal sender As Object,
                                          ByVal e As System.EventArgs) Handles rtfTexte.SelectionChanged
    '*************************************************************************
    'Dans le cas o� une s�lection de texte compte plusieurs styles,
    'chacun des styles prend la valeur False. Ainsi lors d'une s�lection
    'de plusieurs styles, aucun des choix de menu ne seront coch�s et 
    'les boutons de la barre d'outils ne seront pas enfonc�s.

    miGras.Checked = rtfTexte.SelectionFont.Bold  'Si Bold = False, Checked = False et idem pour True
    cmGras.Checked = rtfTexte.SelectionFont.Bold
    tsbGras.Checked = rtfTexte.SelectionFont.Bold

    miItalique.Checked = rtfTexte.SelectionFont.Italic
    cmItalique.Checked = rtfTexte.SelectionFont.Italic
    tsbItalique.Checked = rtfTexte.SelectionFont.Italic

    'Lorsque la s�lection d'un texte compte plus d'une police, la propri�t�
    'SelectionFont prend la valeur Nothing, ce qui cause un plantage.
    'Assurez-vous de tester la s�lection de plusieurs polices.
  End Sub

  'Acc�s des choix Annuler et Refaire
  'Prendre note que le contr�le RichTextBox peut r�cup�rer plusieurs annulations
  'contrairement au contr�le TextBox
  Private Sub miEdition_DropDownOpened(ByVal sender As Object,
                                       ByVal e As System.EventArgs) Handles miEdition.DropDownOpened

    miAnnuler.Enabled = rtfTexte.CanUndo
    miRefaire.Enabled = rtfTexte.CanRedo
  End Sub

  Private Sub rtfTexte_TextChanged(ByVal sender As Object,
                                   ByVal e As System.EventArgs) Handles rtfTexte.TextChanged

    'A chaque fois que le texte est modifi�, la taille du texte est affich�e dans la barre d'�tat
    ssTaille.Text = "Taille : " & rtfTexte.TextLength & " octet"
    If rtfTexte.TextLength > 1 Then
      ssTaille.Text &= "s"
    End If
  End Sub
End Class