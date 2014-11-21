'Propriétés de la zone de saisie du texte : 
' ok                 Anchor :top, bottom, right, left
' ok                 Multiline = True
' ok                 ScrollBars = Both
' Louche.            Location = 0;0
' ok                 WordWrap = False (texte non ajusté à la dimension de la fenêtre) <-Renvoi à la ligne automatiquement

Imports System.IO   'Classe IO doit être ajoutée au projet pour 
'utiliser les classes StreamWriter (enregistrer un fichier texte)
'et StreamReader (lire un fichier texte)  

Public Class frmEditeur
    Dim mstrChaineRech As String         'Chaine recherchée dans le texte
    Dim mblnTexteModifie As Boolean      'Le texte a été modifié ou non
    Dim mdrReponse As DialogResult       'Réponse au message de modifications à enregistrer
    Dim mblnAnnulerEnreg As Boolean      'Bouton Annuler sélectionné dans la boite de dialogue Enregistrer
    Dim mstrNomFichier As String         'Nom du fichier sous lequel le texte est enregistré
    Dim mbRetourLigne As Boolean = True  'Propriete retour automatique

    'A chaque fois que le texte est modifié la variable mblnTexteModifie devient vraie.
    'Elle redeviendra fausse quand le texte aura été enregistré.
    'Cette variable permet d'aviser l'utilisateur qu'une modification 
    'apportée au texte n'a pas été enregistrée.

    Private Sub Form_FormClosing(ByVal sender As Object,
                                 ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim response As MsgBoxResult

        If mblnTexteModifie = True Then
            response = MsgBox("Voulez-vous enregistrer?", MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, "Confirm")
            If response = MsgBoxResult.Yes Then
                dlgEnregistrer.FileName = mstrNomFichier
            ElseIf response = MsgBoxResult.No Then
                Me.Close()
            Else
                response = MsgBoxResult.Cancel
                Exit Sub
            End If
        End If
    End Sub
    'Gestionnaire commun aux choix Nouveau, Ouvrir et Quitter :
    'Dans les 3 cas, il faut s'assurer que les dernières modifications
    'apportées au texte ont été enregistrées.
    'Prendre note que le code qui suit ne tient pas compte de la          ******** À FAIRE ******** L24 à 40
    'situation où l'utilisateur ferme le formulaire par le                ******** À FAIRE ********
    'bouton Fermer (X) de la barre de titre.                              ******** À FAIRE ********
    Private Sub NouveauOuvrirQuitter(ByVal sender As System.Object,
                                      ByVal e As System.EventArgs) Handles miFichierNouveau.Click,
                                                                           btnNouveau.Click,
                                                                           miFichierOuvrir.Click,
                                                                           btnOuvrir.Click,
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
            rtfZoneTexte.Clear()
            Me.Text = "Éditeur de texte"
        ElseIf sender Is miFichierQuitter Then  'Choix Quitter
            Me.Close()
        Else                                    'Choix Ouvrir
            With dlgOuvrir
                .CheckFileExists = True             'avertissement si le fichier n'existe pas
                '2 choix affichés dnas la zone Type de la boîte de dialogue (*.txt et *.*)
                .Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*|RTF Files|*.rtf" '****************Caro******************* Ouvrir un fichier RTF 
                Try
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        'OUVERTURE D'UN FICHIER DE TYPE TEXTE (NON FORMATÉ)
                        Dim srFichier As New StreamReader(.FileName)
                        rtfZoneTexte.Text = srFichier.ReadToEnd() 'Chargement du fichier dans la zone de texte
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
        ssModificationSauvegardes.Text = ""
    End Sub

    'Procédure commune aux choix Enregistrer et Enregistrer sous 
    Private Sub EnregistrerClick(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) Handles miFichierEnregistrer.Click,
                                                                      miFichierEnregSous.Click,
                                                                      btnEnregistrer.Click

        With dlgEnregistrer
            'Si le texte n'a jamais été enregistré, il faut demander le nom et 
            'chemin du fichier dans la boite de dialogue.  Si le choix est Enregistrer sous,
            'il faut aussi afficher la boite de dialogue.
            If Me.Text <> mstrNomFichier Or sender Is miFichierEnregSous Then
                .Title = "Enregistrer un fichier texte"         'titre de la boîte de dialogue
                .DefaultExt = "txt"                             'extension par défaut 
                '.Filter = "Fichier texte (*.txt)|*.txt|"         'contenu de la case Type de la boîte de dialogue
                .Filter = "Fichier texte (*.txt;*.rtf)|*.txt;*.rtf" '********************************************************Caro******************* Ouvrir un fichier RTF 
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
            swFichier.Write(rtfZoneTexte.Text)          'enregistrement de tout le texte dans le fichier
            swFichier.Close()                       'fermeture du fichier
        Catch ex As Exception
            MessageBox.Show("Le fichier de type texte n'a pas été enregistré." & ControlChars.NewLine &
                            "Message d'erreur du système : " & ControlChars.NewLine & ex.Message,
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        mblnTexteModifie = False                'aucune nouvelle modification
        ssModificationSauvegardes.Text = ""
        rtfZoneTexte.SelectionLength = 0            'désélectionner le texte
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
                                    ByVal e As System.EventArgs) Handles miEditionRechercher.Click,
                                                                         btnRechercher.Click

        Dim intPosition As Integer    'Position de la chaine trouvée dans le texte

        mstrChaineRech = InputBox("Chaine recherchée :", "Recherche d'une chaine de caractères dans le texte")
        If mstrChaineRech = "" Then    'Si Annuler a été pressé ou rien n'a été tapé,
            Exit Sub                     'une chaine vide est retournée
        End If

        'La méthode IndexOf de la classe String recherche à partir de la position 0 
        'dans txtTexte.Text, la chaine mstrChaineRech et retourne la première position
        'où la chaîne a été trouvée. 
        intPosition = rtfZoneTexte.Text.IndexOf(mstrChaineRech)
        If intPosition = -1 Then  'La valeur -1 est retournée si aucune occurence de la chaîne n'a été trouvée
            MessageBox.Show("Recherche infructueuse !", "Recherche")
        Else
            'Sélectionne tous les caractères (Length) de la chaine trouvée dans le texte 
            'à partir de sa position de départ.
            rtfZoneTexte.Select(intPosition, mstrChaineRech.Length)
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
        intPosition = rtfZoneTexte.Text.IndexOf(mstrChaineRech, rtfZoneTexte.SelectionStart + 1,
                                        System.StringComparison.CurrentCultureIgnoreCase)
        If intPosition = -1 Then
            MessageBox.Show("La recherche est terminée.", "Rechercher le suivant")
            miEditionRechercherSuiv.Enabled = False
        Else
            'Sélectionne la chaîne suivante dans le texte
            rtfZoneTexte.Select(intPosition, mstrChaineRech.Length)
        End If
    End Sub

    'Ajout d'un contrôle FontDialog au formulaire nommé dlgPolice
    Private Sub mmFormatPolice_Click(ByVal sender As System.Object,
                                     ByVal e As System.EventArgs) Handles miFormatPolice.Click

        With dlgPolice
            .ShowColor = True                       'ajoute le choix Couleur (peut être fait en Design)
            .Font = rtfZoneTexte.Font                   'affecte à la boîte de dialogue la police et la couleur du texte
            .Color = rtfZoneTexte.ForeColor
            Try
                If .ShowDialog = Windows.Forms.DialogResult.OK Then   'affichage de la boîte Police
                    rtfZoneTexte.Font = .Font               'police affectée à tout le texte
                    rtfZoneTexte.ForeColor = .Color         'couleur affectée à tout le texte
                End If
            Catch ex As Exception
                MessageBox.Show("La police de caractères n'a pu être modifiée." & ControlChars.NewLine &
                                "Message d'erreur du système : " & ControlChars.NewLine & ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End With
    End Sub

    Private Sub miFormatCouleur_Click(sender As Object,
                                      e As EventArgs) Handles miFormatCouleur.Click

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


    Private Sub Imprimer_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) Handles miFichierImprimer.Click,
                                                                            btnImprimer.Click

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
                                      ByVal e As Printing.PrintPageEventArgs) Handles prtDocument.PrintPage

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

    Private Sub miFichierApercu_Click(ByVal sender As Object,
                                      ByVal e As EventArgs)

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

    Private Sub rtfZoneTexte_TextChanged(ByVal sender As Object,
                                         ByVal e As System.EventArgs) Handles rtfZoneTexte.TextChanged

        'A chaque fois que le texte est modifié, la taille du texte est affichée dans la barre d'état
        ssTaille.Text = "Taille : " & rtfZoneTexte.TextLength & " octet"
        If rtfZoneTexte.TextLength > 1 Then
            ssTaille.Text &= "s"
        End If
        ssModificationSauvegardes.Text = "Le texte a été modifié"
        mblnTexteModifie = True

    End Sub


    'Affichage de la date du jour sur la barre d'état
    Private Sub frmBarres_Load(ByVal sender As Object,
                               ByVal e As System.EventArgs) Handles MyBase.Load

        ssDate.Text = Date.Now.ToLongDateString
        rtfZoneTexte.Focus()

    End Sub

    Private Sub btnGrasItalic_Click(sender As Object,
                              e As EventArgs) Handles btnGras.Click,
                                                      btnItalic.Click
        Dim FontStyle As FontStyle

        FontStyle = (1 * Drawing.FontStyle.Bold)
        FontStyle = (2 * Drawing.FontStyle.Italic)

        'Marche paaaas
    End Sub


    Private Sub btnUndoRedo_Click(sender As Object,
                                e As EventArgs) Handles btnAnnuler.Click


        Select Case sender.name.ToString
            Case "btnAnnuler"
                rtfZoneTexte.Undo()
            Case "btnRefaire"
                rtfZoneTexte.Redo()
        End Select



    End Sub


    Private Sub miEditionHeureDate_Click(sender As Object,
                                         e As EventArgs) Handles miEditionHeureDate.Click

        'Dim frmDateHeure As New frmDateHeure

        'frmDateHeure.Show()

        frmDateHeure.ShowDialog()



    End Sub

    Private Sub btnRetourLigne_Click(sender As Object,
                                     e As EventArgs) Handles btnRetourLigne.Click,
                                                             miFormatRetourAutomatique.Click

        'Renvoi automatiquement à la ligne

            Select Case mbRetourLigne
            Case False
                mbRetourLigne = True
                btnRetourLigne.Checked = True
                miFormatRetourAutomatique.Checked = True
                rtfZoneTexte.WordWrap = True

            Case True
                mbRetourLigne = False
                btnRetourLigne.Checked = False
                miFormatRetourAutomatique.Checked = False
                rtfZoneTexte.WordWrap = False

        End Select

    End Sub


    Private Sub ChoixDeMenu(sender As Object,
                                      e As EventArgs) Handles miEditionCouper.Click, btnCouper.Click,
                                                              miEditionCopier.Click, btnCopier.Click,
                                                              miEditionColler.Click, btnColler.Click,
                                                              miEditionAnnuler.Click, btnAnnuler.Click,
                                                              miEditionRefaire.Click, btnRefaire.click


        Select Case sender.name.ToString
            Case "miEditionCopier", "btnCopier"
                rtfZoneTexte.Copy()
            Case "miEditionColler", "btnColler"
                rtfZoneTexte.Paste()
            Case "miEditionCouper", "btnCouper"
                rtfZoneTexte.Cut()
            Case "miEditionCouper", "btnCouper"
                rtfZoneTexte.Cut()
            Case "miEditionAnnuler", "btnAnnuler"
                rtfZoneTexte.Undo()
                rtfZoneTexte.ClearUndo()
            Case "miEditionRefaire", "btnRefaire"
                rtfZoneTexte.Redo()
        End Select

    End Sub

    Private Sub AfficherChoixMenus(sender As Object,
                                e As EventArgs) Handles rtfZoneTexte.SelectionChanged



        'Si du texte est sélectionné, le bouton Copier est activé
        If rtfZoneTexte.SelectedText <> "" Then

            btnCopier.Enabled = True And miEditionCopier.Enabled = True
            btnCouper.Enabled = True And miEditionCouper.Enabled = True

        ElseIf rtfZoneTexte.SelectedText = "" Then

            btnCopier.Enabled = False And miEditionCopier.Enabled = False
            btnCouper.Enabled = False And miEditionCouper.Enabled = False

        End If

        'btnCopier et Couper doivent être désactivé au démarrage ***À FAIRE

    End Sub
End Class