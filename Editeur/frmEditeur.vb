'Propriétés de la zone de saisie du texte : 
'                 Anchor :top, bottom, right, left
'                 Multiline = True
'                 ScrollBars = Both
'                 Location = 0;0
'                 WordWrap = False (texte non ajusté à la dimension de la fenêtre)
'JE CHANGE UNE LIGNE ICI
Imports System.IO   'Classe IO doit être ajoutée au projet pour 
                    'utiliser les classes StreamWriter (enregistrer un fichier texte)
                    'et StreamReader (lire un fichier texte)  

Public Class frmEditeur
  Dim mstrChaineRech As String      'Chaine recherchée dans le texte
  Dim mblnTexteModifie As Boolean   'Le texte a été modifié ou non
  Dim mdrReponse As DialogResult    'Réponse au message de modifications à enregistrer
  Dim mblnAnnulerEnreg As Boolean   'Bouton Annuler sélectionné dans la boite de dialogue Enregistrer
  Dim mstrNomFichier As String      'Nom du fichier sous lequel le texte est enregistré

  'A chaque fois que le texte est modifié la variable mblnTexteModifie devient vraie.
  'Elle redeviendra fausse quand le texte aura été enregistré.
  'Cette variable permet d'aviser l'utilisateur qu'une modification 
  'apportée au texte n'a pas été enregistrée.
  Private Sub txtTexte_TextChanged(ByVal sender As Object,
                                  ByVal e As System.EventArgs) Handles txtTexte.TextChanged
    mblnTexteModifie = True
  End Sub

  'gestionnaire commun aux choix Nouveau, Ouvrir et Quitter :
  'Dans les 3 cas, il faut s'assurer que les dernières modifications
  'apportées au texte ont été enregistrées.
  'Prendre note que le code qui suit ne tient pas compte de la
  'situation où l'utilisateur ferme le formulaire par le
  'bouton Fermer (X) de la barre de titre.
  Private Sub NouveauOuvrirQuitter(ByVal sender As System.Object,
                                    ByVal e As System.EventArgs) Handles miFichierNouveau.Click,
                                                                         miFichierOuvrir.Click,
                                                                         miFichierQuitter.Click

    If mblnTexteModifie = True Then       'Si des modifications n'ont pas été enregistrées
      mdrReponse = MessageModification()  'Affichage d'un message
      Select Case mdrReponse
        Case Windows.Forms.DialogResult.Yes     'Enregistrement si oui
          EnregistrerClick(sender, e)
          If mblnAnnulerEnreg = True Then   'Si l'utilisateur a annulé l'enregistrement par le bouton Annuler
            Exit Sub                        'dans la boite de dialogue Enregistrer, sortie de la procédure.
          End If
        Case Windows.Forms.DialogResult.Cancel            'aucun enregistrement si non
          Exit Sub
      End Select
    End If

    If sender Is miFichierNouveau Then      'Choix Nouveau
      txtTexte.Clear()
      Me.Text = "Éditeur de texte"
    ElseIf sender Is miFichierQuitter Then  'Choix Quitter
      Me.Close()
    Else                                    'Choix Ouvrir
      With dlgOuvrir
        .CheckFileExists = True             'avertissement si le fichier n'existe pas
        '2 choix affichés dnas la zone Type de la boîte de dialogue (*.txt et *.*)
        .Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"
        Try
          If .ShowDialog = Windows.Forms.DialogResult.OK Then
            'OUVERTURE D'UN FICHIER DE TYPE TEXTE (NON FORMATÉ)
            Dim srFichier As New StreamReader(.FileName)
            txtTexte.Text = srFichier.ReadToEnd() 'Chargement du fichier dans la zone de texte
            srFichier.Close()                     'Fermeture du fichier
            mstrNomFichier = .FileName            'nom du fichier conservé
            Me.Text = mstrNomFichier              'texte de la barre de titre du formulaire
          End If
        Catch ex As Exception
          MessageBox.Show("Le fichier spécifié n'a pu être ouvert." & ControlChars.NewLine &
                          "Message d'erreur du système : " & ControlChars.NewLine & ex.Message,
                          "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
      End With

      dlgEnregistrer.FileName = mstrNomFichier
    End If

    mblnTexteModifie = False  'aucune nouvelle modification
  End Sub

  'Procédure commune aux choix Enregistrer et Enregistrer sous 
  Private Sub EnregistrerClick(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles miFichierEnregistrer.Click,
                                                                    miFichierEnregSous.Click
    With dlgEnregistrer
      'Si le texte n'a jamais été enregistré, il faut demander le nom et 
      'chemin du fichier dans la boite de dialogue.  Si le choix est Enregistrer sous,
      'il faut aussi afficher la boite de dialogue.
      If Me.Text <> mstrNomFichier Or sender Is miFichierEnregSous Then
        .Title = "Enregistrer un fichier texte"         'titre de la boîte de dialogue
        .DefaultExt = "txt"                             'extension par défaut 
        .Filter = "Fichier texte (*.txt)|*.txt"         'contenu de la case Type de la boîte de dialogue
        .OverwritePrompt = True                         'avertissement si le fichier existe déjà
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Enregistrement()
          mstrNomFichier = .FileName
          Me.Text = mstrNomFichier        'nom du fichier dans la barre de titre de l'éditeur
          mblnAnnulerEnreg = False        'Bouton Annuler n'a pas été sélectionné
        Else
          mblnAnnulerEnreg = True         'Bouton Annuler a été sélectionné
        End If
      Else
        'Si le texte a déjà été enregistré, inutile de demander le nom et le chemin dans la boite de dialogue Enregistrer
        Enregistrement()
      End If
    End With
  End Sub

  Sub Enregistrement()
    'ENREGISTREMENT D'UN FICHIER DE TYPE TEXTE (NON FORMATÉ)
    Dim swFichier As New StreamWriter(dlgEnregistrer.FileName) 'requiert la ligne de code Imports System.IO au début du module

    Try
      swFichier.Write(txtTexte.Text)          'enregistrement de tout le texte dans le fichier
      swFichier.Close()                       'fermeture du fichier
    Catch ex As Exception
      MessageBox.Show("Le fichier de type texte n'a pas été enregistré." & ControlChars.NewLine &
                      "Message d'erreur du système : " & ControlChars.NewLine & ex.Message,
                      "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Try

    mblnTexteModifie = False                'aucune nouvelle modification
    txtTexte.SelectionLength = 0            'désélectionner le texte
  End Sub

  Function MessageModification() As DialogResult
    Return MessageBox.Show("Le texte actuel a été modifié." & ControlChars.NewLine &
                           ControlChars.NewLine & "Désirez-vous enregistrer les modifications ?",
                           "Éditeur de texte", MessageBoxButtons.YesNoCancel,
                           MessageBoxIcon.Exclamation)
    'Ici, une fonction a été utilisée au lieu d'une procédure générale.
    'La principale différence entre une procédure générale et une fonction
    'est qu'une fonction retourne obligatoirement une valeur.  
    'Dans le cas présent, la valeur retournée est de type DialogResult 
    '(réponse de l'utilisateur au message affiché, Yes, No ou Cancel).

    'Une fonction débute par la ligne Function et se termine par la ligne End Function. 
    'La ligne Function est constituée du nom de la fonction suivi de ses arguments 
    'facultatifs (aucun dans le cas présent) et du type de données de la valeur
    'retournée (cas présent : DialogResult). 
    'L'instruction Return retourne à la procédure appelante (NouveauOuvrirQuitter),
    'la valeur qui sera affectée à mdrReponse dans la procédure appelante.
  End Function

  Private Sub mmEditionRech_Click(ByVal sender As System.Object,
                                  ByVal e As System.EventArgs) Handles miEditionRechercher.Click

    Dim intPosition As Integer    'Position de la chaine trouvée dans le texte

    mstrChaineRech = InputBox("Chaine recherchée :", "Recherche d'une chaine de caractères dans le texte")
    If mstrChaineRech = "" Then    'Si Annuler a été pressé ou rien n'a été tapé,
      Exit Sub                     'une chaine vide est retournée
    End If

    'La méthode IndexOf de la classe String recherche à partir de la position 0 
    'dans txtTexte.Text, la chaine mstrChaineRech et retourne la première position
    'où la chaîne a été trouvée. 
    intPosition = txtTexte.Text.IndexOf(mstrChaineRech)
    If intPosition = -1 Then  'La valeur -1 est retournée si aucune occurence de la chaîne n'a été trouvée
      MessageBox.Show("Recherche infructueuse !", "Recherche")
    Else
      'Sélectionne tous les caractères (Length) de la chaine trouvée dans le texte 
      'à partir de sa position de départ.
      txtTexte.Select(intPosition, mstrChaineRech.Length)
      'Active le choix Rechercher le suivant au menu
      miEditionRechercherSuiv.Enabled = True
    End If
    'Noter que les recherches tiennent compte de la casse (minuscules différentes des majuscules)
    'Pour ne pas en tenir compte, tu peux ajouter la ligne de code qui suit au début
    'du module :  Option Compare Text
  End Sub

  Private Sub mmEditionRechSuiv_Click(ByVal sender As System.Object,
                                      ByVal e As System.EventArgs) Handles miEditionRechercherSuiv.Click

    Dim intPosition As Integer

    'La prochaine recherche doit débuter à la position qui suit le
    'début du texte sélectionné (txtTexte.SelectionStart + 1)
    'Le dernier argument permet d'ignorer la casse lors de la recherche
    intPosition = txtTexte.Text.IndexOf(mstrChaineRech, txtTexte.SelectionStart + 1,
                                        System.StringComparison.CurrentCultureIgnoreCase)
    If intPosition = -1 Then
      MessageBox.Show("La recherche est terminée.", "Rechercher le suivant")
      miEditionRechercherSuiv.Enabled = False
    Else
      'Sélectionne la chaîne suivante dans le texte
      txtTexte.Select(intPosition, mstrChaineRech.Length)
    End If
  End Sub

  Private Sub mmFormatRetourAuto_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) Handles miFormatRetourAutomatique.Click

    'Cocher ou décocher le choix dans le menu
    miFormatRetourAutomatique.Checked = Not miFormatRetourAutomatique.Checked
    'Ajuste ou non la longueur des lignes à la largeur du formulaire
    txtTexte.WordWrap = Not txtTexte.WordWrap
  End Sub

  'Ajout d'un contrôle FontDialog au formulaire nommé dlgPolice
  Private Sub mmFormatPolice_Click(ByVal sender As System.Object,
                                   ByVal e As System.EventArgs) Handles miFormatPolice.Click

    With dlgPolice
      .ShowColor = True                       'ajoute le choix Couleur (peut être fait en Design)
      .Font = txtTexte.Font                   'affecte à la boîte de dialogue la police et la couleur du texte
      .Color = txtTexte.ForeColor
      Try
        If .ShowDialog = Windows.Forms.DialogResult.OK Then   'affichage de la boîte Police
          txtTexte.Font = .Font               'police affectée à tout le texte
          txtTexte.ForeColor = .Color         'couleur affectée à tout le texte
        End If
      Catch ex As Exception
        MessageBox.Show("La police de caractères n'a pu être modifiée." & ControlChars.NewLine &
                        "Message d'erreur du système : " & ControlChars.NewLine & ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      End Try
    End With
  End Sub

  Private Sub mmFichierImprimer_Click(ByVal sender As Object,
                                      ByVal e As System.EventArgs) Handles miFichierImprimer.Click
    'Voir projet BoitesDialogue
  End Sub
End Class