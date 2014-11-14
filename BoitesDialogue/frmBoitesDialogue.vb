Public Class frmBoitesDialogue

  'Un contrôle ColorDialog a été ajouté et nommé dlgCouleur.
  'Ce contrôle permet d'afficher la boîte de dialogue Couleurs de Windows.
  Private Sub btnCouleur_Click(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnCouleur.Click

    With dlgCouleur
      .Color = rtfZoneTexte.SelectionColor      'Pour que la couleur du texte soit sélectionnée par défaut dans la boîte des couleurs.
      Try
        If .ShowDialog = Windows.Forms.DialogResult.OK Then     'Méthode ShowDialog affiche la boîte de dialogue
          rtfZoneTexte.SelectionColor = .Color    'si l'utilisateur choisit OK dans la boîte de dialogue, 
        End If                                    'la couleur choisie est affectée au texte sélectionné ou à partir du point d'insertion
      Catch ex As Exception
        MessageBox.Show("La couleur n'a pu être modifiée." & ControlChars.NewLine &
                        "Message d'erreur du système : " & ControlChars.NewLine & ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      End Try
    End With

    rtfZoneTexte.Focus()
  End Sub

  'Un contrôle FontDialog a été ajouté et nommé dlgPolice.
  'Ce contrôle permet d'afficher la boîte de dialogue Police de Windows.
  Private Sub btnPolice_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles btnPolice.Click

    With dlgPolice
      .Font = rtfZoneTexte.SelectionFont      'Pour que la police actuelle soit sélectionnée par défaut dans la boîte Police.
      Try
        If .ShowDialog = Windows.Forms.DialogResult.OK Then   'Affichage de la boîte Police
          rtfZoneTexte.SelectionFont = .Font    'police affectée au texte sélectionné ou à partir du point d'insertion
        End If
      Catch ex As Exception
        MessageBox.Show("La police de caractères n'a pu être modifiée." & ControlChars.NewLine &
                        "Message d'erreur du système : " & ControlChars.NewLine & ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      End Try
    End With

    rtfZoneTexte.Focus()
  End Sub

  'Un contrôle SaveFileDialog a été ajouté et nommé dlgEnregSous.
  'Ce contrôle permet d'afficher la boîte de dialogue Enregistrer sous de Windows.
  Private Sub btnEnrSous_Click(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnEnrSous.Click

    With dlgEnregSous
      .FileName = "Fichier"                          'nom du fichier par défaut
      .Title = "Enregistrer un fichier de type Rtf"  'texte dans la barre de titre de la boîte de dialogue
      .DefaultExt = "rtf"                            'extension par défaut 
      .Filter = "Fichier Rtf (*.rtf)|*.rtf"          'contenu de la liste Type de la boîte de dialogue
      .OverwritePrompt = True                        'avertissement si ce fichier existe déjà
      Try
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          rtfZoneTexte.SaveFile(.FileName)            'méthode SaveFile pour enregistrer le contenu de la zone de texte
          Me.Text = "Fichier enregistré " & .FileName 'texte de la barre de titre du formulaire
        End If
      Catch ex As Exception
        MessageBox.Show("Le fichier n'a pu être enregistré." & ControlChars.NewLine &
                        "Message d'erreur du système : " & ControlChars.NewLine & ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      End Try
    End With

    rtfZoneTexte.Focus()
  End Sub

  'Un contrôle OpenFileDialog a été ajouté et nommé dlgOuvrir 
  'Ce contrôle permet d'afficher la boîte de dialogue Ouvrir de Windows.
  Private Sub btnOuvrir_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles btnOuvrir.Click

    With dlgOuvrir
      .CheckFileExists = True                   'avertissement si le fichier n'existe pas
      '3 choix affichés dans la liste Type à droite de la zone Nom de fichier (*.rtf, *.txt et *.*)
      .Filter = "Texte mis en forme (*.rtf)|*.rtf|Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"
      Try
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          rtfZoneTexte.LoadFile(.FileName)        'méthode LoadFile pour charger le contenu du fichier dans la zone de texte
          Me.Text = "Fichier chargé " & .FileName 'texte de la barre de titre du formulaire après l'ouverture du fichier
        End If
      Catch ex As Exception
        MessageBox.Show("Impossible d'ouvrir le fichier spécifié." & ControlChars.NewLine &
                        "Message d'erreur du système : " & ControlChars.NewLine & ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      End Try
    End With

    rtfZoneTexte.Focus()
  End Sub

  'Un contrôle Printdocument a été ajouté et nommé prtDocument. 
  'Un contrôle PrintDialog a été ajouté et nommé dlgImprimer. Sa propriété UseEXDialog = True permet 
  'l'affichage de la boite de dialogue sous des versions ultérieures à Windows XP, comme Windows 7
  'PrintDocument représente le document et PrintDialog permet 
  'd'afficher la boîte de dialogue Imprimer de Windows.
  Private Sub btnImprimer_Click(ByVal sender As System.Object,
                                ByVal e As System.EventArgs) Handles btnImprimer.Click

    'un objet de type PrintDocument doit être affecté à la propriété .Document du contrôle PrintDialog
    dlgImprimer.Document = prtDocument
    Try
      If dlgImprimer.ShowDialog = Windows.Forms.DialogResult.OK Then
        prtDocument.Print()   'Méthode qui déclenche l'évènement PrintPage qui suit
      End If
    Catch ex As Exception
      MessageBox.Show("Le document n'a pu être imprimé." & ControlChars.NewLine &
                      "Message d'erreur du système : " & ControlChars.NewLine & ex.Message,
                      "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Try

    rtfZoneTexte.Focus()
  End Sub

  Private Sub prtDocument_PrintPage(ByVal sender As Object,
                              ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prtDocument.PrintPage

    'La méthode DrawString permet d'imprimer un texte non formaté.
    'La propriété Text du contrôle RichTextBox retourne le texte non formaté
    'tandis que la propriété .rtf retourne le texte formaté.
    'Note : Imprimer correctement un texte formaté est passablement complexe
            'et ne fait pas partie du cours.
    e.Graphics.DrawString(rtfZoneTexte.Text,
                          New Font("courier new", 10, FontStyle.Regular),
                          Brushes.Black, 50, 75)  'texte avec une police Courier new, taille 10, aucun style particulier
                                                  'couleur = noire, marge de gauche : 50, marge du haut : 75

  End Sub

  'Un contrôle PrintPreviewDialog a été ajouté et nommé dlgApercu.
  'Il permet d'afficher la boîte de dialogue Aperçu avant impression de Windows.
  'Prendre note que le texte n'est pas formaté dans la boîte de dialogue
  Private Sub btnApercu_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles btnapercu.Click

    'un objet de type PrintDocument doit être affecté à la propriété .Document du contrôle PrintPreviewDialog
    dlgApercu.Document = prtDocument
    Try
      dlgApercu.ShowDialog()
    Catch ex As Exception
      MessageBox.Show("La boite de dialogue Apercu avant impression n'a pu être affichée." & ControlChars.NewLine &
                      "Message d'erreur du système : " & ControlChars.NewLine & ex.Message,
                      "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Try

    rtfZoneTexte.Focus()
  End Sub

  'Un contrôle PageSetupDialog a été ajouté et nommé dlgMiseEnPage. 
  'Il permet d'afficher la boîte de dialogue Mise en page.
  Private Sub btnMiseEnPage_Click(ByVal sender As System.Object,
                                  ByVal e As System.EventArgs) Handles btnMiseEnPage.Click

    'un objet de type PrintDocument doit être affecté à la propriété 
    'Document du contrôle PageSetupDialog
    dlgMiseEnPage.Document = prtDocument
    Try
      dlgMiseEnPage.ShowDialog()
    Catch ex As Exception
      MessageBox.Show("La boite de dialogue Mise en page n'a pu être affichée." & ControlChars.NewLine &
                      "Message d'erreur du système : " & ControlChars.NewLine & ex.Message,
                      "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Try

    rtfZoneTexte.Focus()
  End Sub

  Private Sub btnQuitter_Click(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles btnQuitter.Click
    Me.Close()
  End Sub
End Class