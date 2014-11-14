Public Class frmBarresMenus
 'Affichage de la date du jour sur la barre d'état
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

  'Lorsque la sélection change ou que le point d'insertion est déplacé,
  'on doit resynchroniser l'accès des choix semblables.
  Private Sub SynchroniserChoixSemblables(ByVal sender As Object,
                                          ByVal e As System.EventArgs) Handles rtfTexte.SelectionChanged
    '*************************************************************************
    'Dans le cas où une sélection de texte compte plusieurs styles,
    'chacun des styles prend la valeur False. Ainsi lors d'une sélection
    'de plusieurs styles, aucun des choix de menu ne seront cochés et 
    'les boutons de la barre d'outils ne seront pas enfoncés.

    miGras.Checked = rtfTexte.SelectionFont.Bold  'Si Bold = False, Checked = False et idem pour True
    cmGras.Checked = rtfTexte.SelectionFont.Bold
    tsbGras.Checked = rtfTexte.SelectionFont.Bold

    miItalique.Checked = rtfTexte.SelectionFont.Italic
    cmItalique.Checked = rtfTexte.SelectionFont.Italic
    tsbItalique.Checked = rtfTexte.SelectionFont.Italic

    'Lorsque la sélection d'un texte compte plus d'une police, la propriété
    'SelectionFont prend la valeur Nothing, ce qui cause un plantage.
    'Assurez-vous de tester la sélection de plusieurs polices.
  End Sub

  'Accès des choix Annuler et Refaire
  'Prendre note que le contrôle RichTextBox peut récupérer plusieurs annulations
  'contrairement au contrôle TextBox
  Private Sub miEdition_DropDownOpened(ByVal sender As Object,
                                       ByVal e As System.EventArgs) Handles miEdition.DropDownOpened

    miAnnuler.Enabled = rtfTexte.CanUndo
    miRefaire.Enabled = rtfTexte.CanRedo
  End Sub

  Private Sub rtfTexte_TextChanged(ByVal sender As Object,
                                   ByVal e As System.EventArgs) Handles rtfTexte.TextChanged

    'A chaque fois que le texte est modifié, la taille du texte est affichée dans la barre d'état
    ssTaille.Text = "Taille : " & rtfTexte.TextLength & " octet"
    If rtfTexte.TextLength > 1 Then
      ssTaille.Text &= "s"
    End If
  End Sub
End Class