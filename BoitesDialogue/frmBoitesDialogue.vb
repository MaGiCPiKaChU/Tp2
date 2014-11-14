Public Class frmBoitesDialogue

  'Un contr�le ColorDialog a �t� ajout� et nomm� dlgCouleur.
  'Ce contr�le permet d'afficher la bo�te de dialogue Couleurs de Windows.
  Private Sub btnCouleur_Click(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnCouleur.Click

    With dlgCouleur
      .Color = rtfZoneTexte.SelectionColor      'Pour que la couleur du texte soit s�lectionn�e par d�faut dans la bo�te des couleurs.
      Try
        If .ShowDialog = Windows.Forms.DialogResult.OK Then     'M�thode ShowDialog affiche la bo�te de dialogue
          rtfZoneTexte.SelectionColor = .Color    'si l'utilisateur choisit OK dans la bo�te de dialogue, 
        End If                                    'la couleur choisie est affect�e au texte s�lectionn� ou � partir du point d'insertion
      Catch ex As Exception
        MessageBox.Show("La couleur n'a pu �tre modifi�e." & ControlChars.NewLine &
                        "Message d'erreur du syst�me : " & ControlChars.NewLine & ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      End Try
    End With

    rtfZoneTexte.Focus()
  End Sub

  'Un contr�le FontDialog a �t� ajout� et nomm� dlgPolice.
  'Ce contr�le permet d'afficher la bo�te de dialogue Police de Windows.
  Private Sub btnPolice_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles btnPolice.Click

    With dlgPolice
      .Font = rtfZoneTexte.SelectionFont      'Pour que la police actuelle soit s�lectionn�e par d�faut dans la bo�te Police.
      Try
        If .ShowDialog = Windows.Forms.DialogResult.OK Then   'Affichage de la bo�te Police
          rtfZoneTexte.SelectionFont = .Font    'police affect�e au texte s�lectionn� ou � partir du point d'insertion
        End If
      Catch ex As Exception
        MessageBox.Show("La police de caract�res n'a pu �tre modifi�e." & ControlChars.NewLine &
                        "Message d'erreur du syst�me : " & ControlChars.NewLine & ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      End Try
    End With

    rtfZoneTexte.Focus()
  End Sub

  'Un contr�le SaveFileDialog a �t� ajout� et nomm� dlgEnregSous.
  'Ce contr�le permet d'afficher la bo�te de dialogue Enregistrer sous de Windows.
  Private Sub btnEnrSous_Click(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnEnrSous.Click

    With dlgEnregSous
      .FileName = "Fichier"                          'nom du fichier par d�faut
      .Title = "Enregistrer un fichier de type Rtf"  'texte dans la barre de titre de la bo�te de dialogue
      .DefaultExt = "rtf"                            'extension par d�faut 
      .Filter = "Fichier Rtf (*.rtf)|*.rtf"          'contenu de la liste Type de la bo�te de dialogue
      .OverwritePrompt = True                        'avertissement si ce fichier existe d�j�
      Try
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          rtfZoneTexte.SaveFile(.FileName)            'm�thode SaveFile pour enregistrer le contenu de la zone de texte
          Me.Text = "Fichier enregistr� " & .FileName 'texte de la barre de titre du formulaire
        End If
      Catch ex As Exception
        MessageBox.Show("Le fichier n'a pu �tre enregistr�." & ControlChars.NewLine &
                        "Message d'erreur du syst�me : " & ControlChars.NewLine & ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      End Try
    End With

    rtfZoneTexte.Focus()
  End Sub

  'Un contr�le OpenFileDialog a �t� ajout� et nomm� dlgOuvrir 
  'Ce contr�le permet d'afficher la bo�te de dialogue Ouvrir de Windows.
  Private Sub btnOuvrir_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles btnOuvrir.Click

    With dlgOuvrir
      .CheckFileExists = True                   'avertissement si le fichier n'existe pas
      '3 choix affich�s dans la liste Type � droite de la zone Nom de fichier (*.rtf, *.txt et *.*)
      .Filter = "Texte mis en forme (*.rtf)|*.rtf|Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"
      Try
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          rtfZoneTexte.LoadFile(.FileName)        'm�thode LoadFile pour charger le contenu du fichier dans la zone de texte
          Me.Text = "Fichier charg� " & .FileName 'texte de la barre de titre du formulaire apr�s l'ouverture du fichier
        End If
      Catch ex As Exception
        MessageBox.Show("Impossible d'ouvrir le fichier sp�cifi�." & ControlChars.NewLine &
                        "Message d'erreur du syst�me : " & ControlChars.NewLine & ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      End Try
    End With

    rtfZoneTexte.Focus()
  End Sub

  'Un contr�le Printdocument a �t� ajout� et nomm� prtDocument. 
  'Un contr�le PrintDialog a �t� ajout� et nomm� dlgImprimer. Sa propri�t� UseEXDialog = True permet 
  'l'affichage de la boite de dialogue sous des versions ult�rieures � Windows XP, comme Windows 7
  'PrintDocument repr�sente le document et PrintDialog permet 
  'd'afficher la bo�te de dialogue Imprimer de Windows.
  Private Sub btnImprimer_Click(ByVal sender As System.Object,
                                ByVal e As System.EventArgs) Handles btnImprimer.Click

    'un objet de type PrintDocument doit �tre affect� � la propri�t� .Document du contr�le PrintDialog
    dlgImprimer.Document = prtDocument
    Try
      If dlgImprimer.ShowDialog = Windows.Forms.DialogResult.OK Then
        prtDocument.Print()   'M�thode qui d�clenche l'�v�nement PrintPage qui suit
      End If
    Catch ex As Exception
      MessageBox.Show("Le document n'a pu �tre imprim�." & ControlChars.NewLine &
                      "Message d'erreur du syst�me : " & ControlChars.NewLine & ex.Message,
                      "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Try

    rtfZoneTexte.Focus()
  End Sub

  Private Sub prtDocument_PrintPage(ByVal sender As Object,
                              ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prtDocument.PrintPage

    'La m�thode DrawString permet d'imprimer un texte non format�.
    'La propri�t� Text du contr�le RichTextBox retourne le texte non format�
    'tandis que la propri�t� .rtf retourne le texte format�.
    'Note : Imprimer correctement un texte format� est passablement complexe
            'et ne fait pas partie du cours.
    e.Graphics.DrawString(rtfZoneTexte.Text,
                          New Font("courier new", 10, FontStyle.Regular),
                          Brushes.Black, 50, 75)  'texte avec une police Courier new, taille 10, aucun style particulier
                                                  'couleur = noire, marge de gauche : 50, marge du haut : 75

  End Sub

  'Un contr�le PrintPreviewDialog a �t� ajout� et nomm� dlgApercu.
  'Il permet d'afficher la bo�te de dialogue Aper�u avant impression de Windows.
  'Prendre note que le texte n'est pas format� dans la bo�te de dialogue
  Private Sub btnApercu_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles btnapercu.Click

    'un objet de type PrintDocument doit �tre affect� � la propri�t� .Document du contr�le PrintPreviewDialog
    dlgApercu.Document = prtDocument
    Try
      dlgApercu.ShowDialog()
    Catch ex As Exception
      MessageBox.Show("La boite de dialogue Apercu avant impression n'a pu �tre affich�e." & ControlChars.NewLine &
                      "Message d'erreur du syst�me : " & ControlChars.NewLine & ex.Message,
                      "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Try

    rtfZoneTexte.Focus()
  End Sub

  'Un contr�le PageSetupDialog a �t� ajout� et nomm� dlgMiseEnPage. 
  'Il permet d'afficher la bo�te de dialogue Mise en page.
  Private Sub btnMiseEnPage_Click(ByVal sender As System.Object,
                                  ByVal e As System.EventArgs) Handles btnMiseEnPage.Click

    'un objet de type PrintDocument doit �tre affect� � la propri�t� 
    'Document du contr�le PageSetupDialog
    dlgMiseEnPage.Document = prtDocument
    Try
      dlgMiseEnPage.ShowDialog()
    Catch ex As Exception
      MessageBox.Show("La boite de dialogue Mise en page n'a pu �tre affich�e." & ControlChars.NewLine &
                      "Message d'erreur du syst�me : " & ControlChars.NewLine & ex.Message,
                      "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Try

    rtfZoneTexte.Focus()
  End Sub

  Private Sub btnQuitter_Click(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnQuitter.Click
    Me.Close()
  End Sub
End Class