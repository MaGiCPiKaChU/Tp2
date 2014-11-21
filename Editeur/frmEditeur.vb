'Propri�t�s de la zone de saisie du texte : 
' ok                 Anchor :top, bottom, right, left
' ok                 Multiline = True
' ok                 ScrollBars = Both
' Louche.            Location = 0;0
' ok                 WordWrap = False (texte non ajust� � la dimension de la fen�tre) <-Renvoi � la ligne automatiquement

Imports System.IO   'Classe IO doit �tre ajout�e au projet pour 
'utiliser les classes StreamWriter (enregistrer un fichier texte)
'et StreamReader (lire un fichier texte)  

Public Class frmEditeur
    Dim mstrChaineRech As String         'Chaine recherch�e dans le texte
    Dim mblnTexteModifie As Boolean      'Le texte a �t� modifi� ou non
    Dim mdrReponse As DialogResult       'R�ponse au message de modifications � enregistrer
    Dim mblnAnnulerEnreg As Boolean      'Bouton Annuler s�lectionn� dans la boite de dialogue Enregistrer
    Dim mstrNomFichier As String         'Nom du fichier sous lequel le texte est enregistr�
    Dim mbRetourLigne As Boolean = True  'Propriete retour automatique

    'A chaque fois que le texte est modifi� la variable mblnTexteModifie devient vraie.
    'Elle redeviendra fausse quand le texte aura �t� enregistr�.
    'Cette variable permet d'aviser l'utilisateur qu'une modification 
    'apport�e au texte n'a pas �t� enregistr�e.

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
    'Dans les 3 cas, il faut s'assurer que les derni�res modifications
    'apport�es au texte ont �t� enregistr�es.
    'Prendre note que le code qui suit ne tient pas compte de la          ******** � FAIRE ******** L24 � 40
    'situation o� l'utilisateur ferme le formulaire par le                ******** � FAIRE ********
    'bouton Fermer (X) de la barre de titre.                              ******** � FAIRE ********
    Private Sub NouveauOuvrirQuitter(ByVal sender As System.Object,
                                      ByVal e As System.EventArgs) Handles miFichierNouveau.Click,
                                                                           btnNouveau.Click,
                                                                           miFichierOuvrir.Click,
                                                                           btnOuvrir.Click,
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
            rtfZoneTexte.Clear()
            Me.Text = "�diteur de texte"
        ElseIf sender Is miFichierQuitter Then  'Choix Quitter
            Me.Close()
        Else                                    'Choix Ouvrir
            With dlgOuvrir
                .CheckFileExists = True             'avertissement si le fichier n'existe pas
                '2 choix affich�s dnas la zone Type de la bo�te de dialogue (*.txt et *.*)
                .Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*|RTF Files|*.rtf" '****************Caro******************* Ouvrir un fichier RTF 
                Try
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        'OUVERTURE D'UN FICHIER DE TYPE TEXTE (NON FORMAT�)
                        Dim srFichier As New StreamReader(.FileName)
                        rtfZoneTexte.Text = srFichier.ReadToEnd() 'Chargement du fichier dans la zone de texte
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
        ssModificationSauvegardes.Text = ""
    End Sub

    'Proc�dure commune aux choix Enregistrer et Enregistrer sous 
    Private Sub EnregistrerClick(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) Handles miFichierEnregistrer.Click,
                                                                      miFichierEnregSous.Click,
                                                                      btnEnregistrer.Click

        With dlgEnregistrer
            'Si le texte n'a jamais �t� enregistr�, il faut demander le nom et 
            'chemin du fichier dans la boite de dialogue.  Si le choix est Enregistrer sous,
            'il faut aussi afficher la boite de dialogue.
            If Me.Text <> mstrNomFichier Or sender Is miFichierEnregSous Then
                .Title = "Enregistrer un fichier texte"         'titre de la bo�te de dialogue
                .DefaultExt = "txt"                             'extension par d�faut 
                '.Filter = "Fichier texte (*.txt)|*.txt|"         'contenu de la case Type de la bo�te de dialogue
                .Filter = "Fichier texte (*.txt;*.rtf)|*.txt;*.rtf" '********************************************************Caro******************* Ouvrir un fichier RTF 
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
            swFichier.Write(rtfZoneTexte.Text)          'enregistrement de tout le texte dans le fichier
            swFichier.Close()                       'fermeture du fichier
        Catch ex As Exception
            MessageBox.Show("Le fichier de type texte n'a pas �t� enregistr�." & ControlChars.NewLine &
                            "Message d'erreur du syst�me : " & ControlChars.NewLine & ex.Message,
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

        mblnTexteModifie = False                'aucune nouvelle modification
        ssModificationSauvegardes.Text = ""
        rtfZoneTexte.SelectionLength = 0            'd�s�lectionner le texte
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
                                    ByVal e As System.EventArgs) Handles miEditionRechercher.Click,
                                                                         btnRechercher.Click

        Dim intPosition As Integer    'Position de la chaine trouv�e dans le texte

        mstrChaineRech = InputBox("Chaine recherch�e :", "Recherche d'une chaine de caract�res dans le texte")
        If mstrChaineRech = "" Then    'Si Annuler a �t� press� ou rien n'a �t� tap�,
            Exit Sub                     'une chaine vide est retourn�e
        End If

        'La m�thode IndexOf de la classe String recherche � partir de la position 0 
        'dans txtTexte.Text, la chaine mstrChaineRech et retourne la premi�re position
        'o� la cha�ne a �t� trouv�e. 
        intPosition = rtfZoneTexte.Text.IndexOf(mstrChaineRech)
        If intPosition = -1 Then  'La valeur -1 est retourn�e si aucune occurence de la cha�ne n'a �t� trouv�e
            MessageBox.Show("Recherche infructueuse !", "Recherche")
        Else
            'S�lectionne tous les caract�res (Length) de la chaine trouv�e dans le texte 
            '� partir de sa position de d�part.
            rtfZoneTexte.Select(intPosition, mstrChaineRech.Length)
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
        intPosition = rtfZoneTexte.Text.IndexOf(mstrChaineRech, rtfZoneTexte.SelectionStart + 1,
                                        System.StringComparison.CurrentCultureIgnoreCase)
        If intPosition = -1 Then
            MessageBox.Show("La recherche est termin�e.", "Rechercher le suivant")
            miEditionRechercherSuiv.Enabled = False
        Else
            'S�lectionne la cha�ne suivante dans le texte
            rtfZoneTexte.Select(intPosition, mstrChaineRech.Length)
        End If
    End Sub

    'Ajout d'un contr�le FontDialog au formulaire nomm� dlgPolice
    Private Sub mmFormatPolice_Click(ByVal sender As System.Object,
                                     ByVal e As System.EventArgs) Handles miFormatPolice.Click

        With dlgPolice
            .ShowColor = True                       'ajoute le choix Couleur (peut �tre fait en Design)
            .Font = rtfZoneTexte.Font                   'affecte � la bo�te de dialogue la police et la couleur du texte
            .Color = rtfZoneTexte.ForeColor
            Try
                If .ShowDialog = Windows.Forms.DialogResult.OK Then   'affichage de la bo�te Police
                    rtfZoneTexte.Font = .Font               'police affect�e � tout le texte
                    rtfZoneTexte.ForeColor = .Color         'couleur affect�e � tout le texte
                End If
            Catch ex As Exception
                MessageBox.Show("La police de caract�res n'a pu �tre modifi�e." & ControlChars.NewLine &
                                "Message d'erreur du syst�me : " & ControlChars.NewLine & ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try
        End With
    End Sub

    Private Sub miFormatCouleur_Click(sender As Object,
                                      e As EventArgs) Handles miFormatCouleur.Click

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


    Private Sub Imprimer_Click(ByVal sender As System.Object,
                                       ByVal e As System.EventArgs) Handles miFichierImprimer.Click,
                                                                            btnImprimer.Click

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
                                      ByVal e As Printing.PrintPageEventArgs) Handles prtDocument.PrintPage

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

    Private Sub miFichierApercu_Click(ByVal sender As Object,
                                      ByVal e As EventArgs)

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

    Private Sub rtfZoneTexte_TextChanged(ByVal sender As Object,
                                         ByVal e As System.EventArgs) Handles rtfZoneTexte.TextChanged

        'A chaque fois que le texte est modifi�, la taille du texte est affich�e dans la barre d'�tat
        ssTaille.Text = "Taille : " & rtfZoneTexte.TextLength & " octet"
        If rtfZoneTexte.TextLength > 1 Then
            ssTaille.Text &= "s"
        End If
        ssModificationSauvegardes.Text = "Le texte a �t� modifi�"
        mblnTexteModifie = True

    End Sub


    'Affichage de la date du jour sur la barre d'�tat
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

        'Renvoi automatiquement � la ligne

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



        'Si du texte est s�lectionn�, le bouton Copier est activ�
        If rtfZoneTexte.SelectedText <> "" Then

            btnCopier.Enabled = True And miEditionCopier.Enabled = True
            btnCouper.Enabled = True And miEditionCouper.Enabled = True

        ElseIf rtfZoneTexte.SelectedText = "" Then

            btnCopier.Enabled = False And miEditionCopier.Enabled = False
            btnCouper.Enabled = False And miEditionCouper.Enabled = False

        End If

        'btnCopier et Couper doivent �tre d�sactiv� au d�marrage ***� FAIRE

    End Sub
End Class