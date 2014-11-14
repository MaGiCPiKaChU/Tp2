'Propri�t�s de la zone de saisie du texte : 
'                 Anchor :top, bottom, right, left
'                 Multiline = True
'                 ScrollBars = Both
'                 Location = 0;0
'                 WordWrap = False (texte non ajust� � la dimension de la fen�tre)
'JE CHANGE UNE LIGNE ICI
Imports System.IO   'Classe IO doit �tre ajout�e au projet pour 
                    'utiliser les classes StreamWriter (enregistrer un fichier texte)
                    'et StreamReader (lire un fichier texte)  

Public Class frmEditeur
  Dim mstrChaineRech As String      'Chaine recherch�e dans le texte
  Dim mblnTexteModifie As Boolean   'Le texte a �t� modifi� ou non
  Dim mdrReponse As DialogResult    'R�ponse au message de modifications � enregistrer
  Dim mblnAnnulerEnreg As Boolean   'Bouton Annuler s�lectionn� dans la boite de dialogue Enregistrer
  Dim mstrNomFichier As String      'Nom du fichier sous lequel le texte est enregistr�

  'A chaque fois que le texte est modifi� la variable mblnTexteModifie devient vraie.
  'Elle redeviendra fausse quand le texte aura �t� enregistr�.
  'Cette variable permet d'aviser l'utilisateur qu'une modification 
  'apport�e au texte n'a pas �t� enregistr�e.
  Private Sub txtTexte_TextChanged(ByVal sender As Object,
                                  ByVal e As System.EventArgs) Handles txtTexte.TextChanged
    mblnTexteModifie = True
  End Sub

  'gestionnaire commun aux choix Nouveau, Ouvrir et Quitter :
  'Dans les 3 cas, il faut s'assurer que les derni�res modifications
  'apport�es au texte ont �t� enregistr�es.
  'Prendre note que le code qui suit ne tient pas compte de la
  'situation o� l'utilisateur ferme le formulaire par le
  'bouton Fermer (X) de la barre de titre.
  Private Sub NouveauOuvrirQuitter(ByVal sender As System.Object,
                                    ByVal e As System.EventArgs) Handles miFichierNouveau.Click,
                                                                         miFichierOuvrir.Click,
                                                                         miFichierQuitter.Click

    If mblnTexteModifie = True Then       'Si des modifications n'ont pas �t� enregistr�es
      mdrReponse = MessageModification()  'Affichage d'un message
      Select Case mdrReponse
        Case Windows.Forms.DialogResult.Yes     'Enregistrement si oui
          EnregistrerClick(sender, e)
          If mblnAnnulerEnreg = True Then   'Si l'utilisateur a annul� l'enregistrement par le bouton Annuler
            Exit Sub                        'dans la boite de dialogue Enregistrer, sortie de la proc�dure.
          End If
        Case Windows.Forms.DialogResult.Cancel            'aucun enregistrement si non
          Exit Sub
      End Select
    End If

    If sender Is miFichierNouveau Then      'Choix Nouveau
      txtTexte.Clear()
      Me.Text = "�diteur de texte"
    ElseIf sender Is miFichierQuitter Then  'Choix Quitter
      Me.Close()
    Else                                    'Choix Ouvrir
      With dlgOuvrir
        .CheckFileExists = True             'avertissement si le fichier n'existe pas
        '2 choix affich�s dnas la zone Type de la bo�te de dialogue (*.txt et *.*)
        .Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"
        Try
          If .ShowDialog = Windows.Forms.DialogResult.OK Then
            'OUVERTURE D'UN FICHIER DE TYPE TEXTE (NON FORMAT�)
            Dim srFichier As New StreamReader(.FileName)
            txtTexte.Text = srFichier.ReadToEnd() 'Chargement du fichier dans la zone de texte
            srFichier.Close()                     'Fermeture du fichier
            mstrNomFichier = .FileName            'nom du fichier conserv�
            Me.Text = mstrNomFichier              'texte de la barre de titre du formulaire
          End If
        Catch ex As Exception
          MessageBox.Show("Le fichier sp�cifi� n'a pu �tre ouvert." & ControlChars.NewLine &
                          "Message d'erreur du syst�me : " & ControlChars.NewLine & ex.Message,
                          "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
      End With

      dlgEnregistrer.FileName = mstrNomFichier
    End If

    mblnTexteModifie = False  'aucune nouvelle modification
  End Sub

  'Proc�dure commune aux choix Enregistrer et Enregistrer sous 
  Private Sub EnregistrerClick(ByVal sender As System.Object,
                               ByVal e As System.EventArgs) Handles miFichierEnregistrer.Click,
                                                                    miFichierEnregSous.Click
    With dlgEnregistrer
      'Si le texte n'a jamais �t� enregistr�, il faut demander le nom et 
      'chemin du fichier dans la boite de dialogue.  Si le choix est Enregistrer sous,
      'il faut aussi afficher la boite de dialogue.
      If Me.Text <> mstrNomFichier Or sender Is miFichierEnregSous Then
        .Title = "Enregistrer un fichier texte"         'titre de la bo�te de dialogue
        .DefaultExt = "txt"                             'extension par d�faut 
        .Filter = "Fichier texte (*.txt)|*.txt"         'contenu de la case Type de la bo�te de dialogue
        .OverwritePrompt = True                         'avertissement si le fichier existe d�j�
        If .ShowDialog = Windows.Forms.DialogResult.OK Then
          Enregistrement()
          mstrNomFichier = .FileName
          Me.Text = mstrNomFichier        'nom du fichier dans la barre de titre de l'�diteur
          mblnAnnulerEnreg = False        'Bouton Annuler n'a pas �t� s�lectionn�
        Else
          mblnAnnulerEnreg = True         'Bouton Annuler a �t� s�lectionn�
        End If
      Else
        'Si le texte a d�j� �t� enregistr�, inutile de demander le nom et le chemin dans la boite de dialogue Enregistrer
        Enregistrement()
      End If
    End With
  End Sub

  Sub Enregistrement()
    'ENREGISTREMENT D'UN FICHIER DE TYPE TEXTE (NON FORMAT�)
    Dim swFichier As New StreamWriter(dlgEnregistrer.FileName) 'requiert la ligne de code Imports System.IO au d�but du module

    Try
      swFichier.Write(txtTexte.Text)          'enregistrement de tout le texte dans le fichier
      swFichier.Close()                       'fermeture du fichier
    Catch ex As Exception
      MessageBox.Show("Le fichier de type texte n'a pas �t� enregistr�." & ControlChars.NewLine &
                      "Message d'erreur du syst�me : " & ControlChars.NewLine & ex.Message,
                      "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Try

    mblnTexteModifie = False                'aucune nouvelle modification
    txtTexte.SelectionLength = 0            'd�s�lectionner le texte
  End Sub

  Function MessageModification() As DialogResult
    Return MessageBox.Show("Le texte actuel a �t� modifi�." & ControlChars.NewLine &
                           ControlChars.NewLine & "D�sirez-vous enregistrer les modifications ?",
                           "�diteur de texte", MessageBoxButtons.YesNoCancel,
                           MessageBoxIcon.Exclamation)
    'Ici, une fonction a �t� utilis�e au lieu d'une proc�dure g�n�rale.
    'La principale diff�rence entre une proc�dure g�n�rale et une fonction
    'est qu'une fonction retourne obligatoirement une valeur.  
    'Dans le cas pr�sent, la valeur retourn�e est de type DialogResult 
    '(r�ponse de l'utilisateur au message affich�, Yes, No ou Cancel).

    'Une fonction d�bute par la ligne Function et se termine par la ligne End Function. 
    'La ligne Function est constitu�e du nom de la fonction suivi de ses arguments 
    'facultatifs (aucun dans le cas pr�sent) et du type de donn�es de la valeur
    'retourn�e (cas pr�sent : DialogResult). 
    'L'instruction Return retourne � la proc�dure appelante (NouveauOuvrirQuitter),
    'la valeur qui sera affect�e � mdrReponse dans la proc�dure appelante.
  End Function

  Private Sub mmEditionRech_Click(ByVal sender As System.Object,
                                  ByVal e As System.EventArgs) Handles miEditionRechercher.Click

    Dim intPosition As Integer    'Position de la chaine trouv�e dans le texte

    mstrChaineRech = InputBox("Chaine recherch�e :", "Recherche d'une chaine de caract�res dans le texte")
    If mstrChaineRech = "" Then    'Si Annuler a �t� press� ou rien n'a �t� tap�,
      Exit Sub                     'une chaine vide est retourn�e
    End If

    'La m�thode IndexOf de la classe String recherche � partir de la position 0 
    'dans txtTexte.Text, la chaine mstrChaineRech et retourne la premi�re position
    'o� la cha�ne a �t� trouv�e. 
    intPosition = txtTexte.Text.IndexOf(mstrChaineRech)
    If intPosition = -1 Then  'La valeur -1 est retourn�e si aucune occurence de la cha�ne n'a �t� trouv�e
      MessageBox.Show("Recherche infructueuse !", "Recherche")
    Else
      'S�lectionne tous les caract�res (Length) de la chaine trouv�e dans le texte 
      '� partir de sa position de d�part.
      txtTexte.Select(intPosition, mstrChaineRech.Length)
      'Active le choix Rechercher le suivant au menu
      miEditionRechercherSuiv.Enabled = True
    End If
    'Noter que les recherches tiennent compte de la casse (minuscules diff�rentes des majuscules)
    'Pour ne pas en tenir compte, tu peux ajouter la ligne de code qui suit au d�but
    'du module :  Option Compare Text
  End Sub

  Private Sub mmEditionRechSuiv_Click(ByVal sender As System.Object,
                                      ByVal e As System.EventArgs) Handles miEditionRechercherSuiv.Click

    Dim intPosition As Integer

    'La prochaine recherche doit d�buter � la position qui suit le
    'd�but du texte s�lectionn� (txtTexte.SelectionStart + 1)
    'Le dernier argument permet d'ignorer la casse lors de la recherche
    intPosition = txtTexte.Text.IndexOf(mstrChaineRech, txtTexte.SelectionStart + 1,
                                        System.StringComparison.CurrentCultureIgnoreCase)
    If intPosition = -1 Then
      MessageBox.Show("La recherche est termin�e.", "Rechercher le suivant")
      miEditionRechercherSuiv.Enabled = False
    Else
      'S�lectionne la cha�ne suivante dans le texte
      txtTexte.Select(intPosition, mstrChaineRech.Length)
    End If
  End Sub

  Private Sub mmFormatRetourAuto_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) Handles miFormatRetourAutomatique.Click

    'Cocher ou d�cocher le choix dans le menu
    miFormatRetourAutomatique.Checked = Not miFormatRetourAutomatique.Checked
    'Ajuste ou non la longueur des lignes � la largeur du formulaire
    txtTexte.WordWrap = Not txtTexte.WordWrap
  End Sub

  'Ajout d'un contr�le FontDialog au formulaire nomm� dlgPolice
  Private Sub mmFormatPolice_Click(ByVal sender As System.Object,
                                   ByVal e As System.EventArgs) Handles miFormatPolice.Click

    With dlgPolice
      .ShowColor = True                       'ajoute le choix Couleur (peut �tre fait en Design)
      .Font = txtTexte.Font                   'affecte � la bo�te de dialogue la police et la couleur du texte
      .Color = txtTexte.ForeColor
      Try
        If .ShowDialog = Windows.Forms.DialogResult.OK Then   'affichage de la bo�te Police
          txtTexte.Font = .Font               'police affect�e � tout le texte
          txtTexte.ForeColor = .Color         'couleur affect�e � tout le texte
        End If
      Catch ex As Exception
        MessageBox.Show("La police de caract�res n'a pu �tre modifi�e." & ControlChars.NewLine &
                        "Message d'erreur du syst�me : " & ControlChars.NewLine & ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
      End Try
    End With
  End Sub

  Private Sub mmFichierImprimer_Click(ByVal sender As Object,
                                      ByVal e As System.EventArgs) Handles miFichierImprimer.Click
    'Voir projet BoitesDialogue
  End Sub
End Class