<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditor))
        Me.rtfRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerSousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MiseEnPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FermerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnulerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnulerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RétablirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CouperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SélectionnerToutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateEtHeureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AffichageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNouveau = New System.Windows.Forms.Button()
        Me.btnOuvrir = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.btnImprimer = New System.Windows.Forms.Button()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.BtnZoomMin = New System.Windows.Forms.Button()
        Me.btnZoomMax = New System.Windows.Forms.Button()
        Me.btnCouper = New System.Windows.Forms.Button()
        Me.BtnCopier = New System.Windows.Forms.Button()
        Me.btnColler = New System.Windows.Forms.Button()
        Me.btnPrecedent = New System.Windows.Forms.Button()
        Me.btnSuivant = New System.Windows.Forms.Button()
        Me.btnAjouterDate = New System.Windows.Forms.Button()
        Me.btnAjouterHeure = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtfRichTextBox
        '
        Me.rtfRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtfRichTextBox.EnableAutoDragDrop = True
        Me.rtfRichTextBox.Location = New System.Drawing.Point(12, 70)
        Me.rtfRichTextBox.Name = "rtfRichTextBox"
        Me.rtfRichTextBox.Size = New System.Drawing.Size(865, 459)
        Me.rtfRichTextBox.TabIndex = 0
        Me.rtfRichTextBox.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.AnnulerToolStripMenuItem, Me.AffichageToolStripMenuItem, Me.InsertionToolStripMenuItem, Me.FormatToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(889, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.OuvrirToolStripMenuItem, Me.ToolStripSeparator1, Me.EnregistrerToolStripMenuItem, Me.EnregistrerSousToolStripMenuItem, Me.ToolStripSeparator2, Me.MiseEnPageToolStripMenuItem, Me.ImprimerToolStripMenuItem, Me.FermerToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "&Fichier"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NouveauToolStripMenuItem.Text = "&Nouveau"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.OuvrirToolStripMenuItem.Text = "&Ouvrir..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.EnregistrerToolStripMenuItem.Text = "&Enregistrer"
        '
        'EnregistrerSousToolStripMenuItem
        '
        Me.EnregistrerSousToolStripMenuItem.Name = "EnregistrerSousToolStripMenuItem"
        Me.EnregistrerSousToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.EnregistrerSousToolStripMenuItem.Text = "En&registrer sous..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(163, 6)
        '
        'MiseEnPageToolStripMenuItem
        '
        Me.MiseEnPageToolStripMenuItem.Name = "MiseEnPageToolStripMenuItem"
        Me.MiseEnPageToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.MiseEnPageToolStripMenuItem.Text = "&Mise en page"
        '
        'ImprimerToolStripMenuItem
        '
        Me.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
        Me.ImprimerToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ImprimerToolStripMenuItem.Text = "&Imprimer"
        '
        'FermerToolStripMenuItem
        '
        Me.FermerToolStripMenuItem.Name = "FermerToolStripMenuItem"
        Me.FermerToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.FermerToolStripMenuItem.Text = "&Fermer"
        '
        'AnnulerToolStripMenuItem
        '
        Me.AnnulerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnnulerToolStripMenuItem1, Me.RétablirToolStripMenuItem, Me.ToolStripSeparator3, Me.CouperToolStripMenuItem, Me.CopierToolStripMenuItem, Me.CollerToolStripMenuItem, Me.ToolStripSeparator4, Me.SélectionnerToutToolStripMenuItem, Me.DateEtHeureToolStripMenuItem})
        Me.AnnulerToolStripMenuItem.Name = "AnnulerToolStripMenuItem"
        Me.AnnulerToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.AnnulerToolStripMenuItem.Text = "&Édition"
        '
        'AnnulerToolStripMenuItem1
        '
        Me.AnnulerToolStripMenuItem1.Name = "AnnulerToolStripMenuItem1"
        Me.AnnulerToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.AnnulerToolStripMenuItem1.Text = "&Annuler"
        '
        'RétablirToolStripMenuItem
        '
        Me.RétablirToolStripMenuItem.Name = "RétablirToolStripMenuItem"
        Me.RétablirToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RétablirToolStripMenuItem.Text = "&Rétablir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(161, 6)
        '
        'CouperToolStripMenuItem
        '
        Me.CouperToolStripMenuItem.Name = "CouperToolStripMenuItem"
        Me.CouperToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CouperToolStripMenuItem.Text = "Cou&per"
        '
        'CopierToolStripMenuItem
        '
        Me.CopierToolStripMenuItem.Name = "CopierToolStripMenuItem"
        Me.CopierToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CopierToolStripMenuItem.Text = "&Copier"
        '
        'CollerToolStripMenuItem
        '
        Me.CollerToolStripMenuItem.Name = "CollerToolStripMenuItem"
        Me.CollerToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CollerToolStripMenuItem.Text = "C&oller"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(161, 6)
        '
        'SélectionnerToutToolStripMenuItem
        '
        Me.SélectionnerToutToolStripMenuItem.Name = "SélectionnerToutToolStripMenuItem"
        Me.SélectionnerToutToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SélectionnerToutToolStripMenuItem.Text = "&Sélectionner tout"
        '
        'DateEtHeureToolStripMenuItem
        '
        Me.DateEtHeureToolStripMenuItem.Name = "DateEtHeureToolStripMenuItem"
        Me.DateEtHeureToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DateEtHeureToolStripMenuItem.Text = "&Date et heure"
        '
        'AffichageToolStripMenuItem
        '
        Me.AffichageToolStripMenuItem.Name = "AffichageToolStripMenuItem"
        Me.AffichageToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.AffichageToolStripMenuItem.Text = "&Affichage"
        '
        'InsertionToolStripMenuItem
        '
        Me.InsertionToolStripMenuItem.Name = "InsertionToolStripMenuItem"
        Me.InsertionToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.InsertionToolStripMenuItem.Text = "&Insertion"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "F&ormat"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "&?"
        '
        'btnNouveau
        '
        Me.btnNouveau.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNouveau.Image = CType(resources.GetObject("btnNouveau.Image"), System.Drawing.Image)
        Me.btnNouveau.Location = New System.Drawing.Point(12, 38)
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(31, 26)
        Me.btnNouveau.TabIndex = 2
        Me.btnNouveau.UseVisualStyleBackColor = True
        '
        'btnOuvrir
        '
        Me.btnOuvrir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOuvrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOuvrir.Image = CType(resources.GetObject("btnOuvrir.Image"), System.Drawing.Image)
        Me.btnOuvrir.Location = New System.Drawing.Point(50, 38)
        Me.btnOuvrir.Name = "btnOuvrir"
        Me.btnOuvrir.Size = New System.Drawing.Size(31, 26)
        Me.btnOuvrir.TabIndex = 3
        Me.btnOuvrir.UseVisualStyleBackColor = True
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrer.Image = CType(resources.GetObject("btnEnregistrer.Image"), System.Drawing.Image)
        Me.btnEnregistrer.Location = New System.Drawing.Point(87, 38)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(31, 26)
        Me.btnEnregistrer.TabIndex = 4
        Me.btnEnregistrer.UseVisualStyleBackColor = True
        '
        'btnImprimer
        '
        Me.btnImprimer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimer.Image = CType(resources.GetObject("btnImprimer.Image"), System.Drawing.Image)
        Me.btnImprimer.Location = New System.Drawing.Point(123, 38)
        Me.btnImprimer.Name = "btnImprimer"
        Me.btnImprimer.Size = New System.Drawing.Size(31, 26)
        Me.btnImprimer.TabIndex = 5
        Me.btnImprimer.UseVisualStyleBackColor = True
        '
        'btnRechercher
        '
        Me.btnRechercher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRechercher.Image = CType(resources.GetObject("btnRechercher.Image"), System.Drawing.Image)
        Me.btnRechercher.Location = New System.Drawing.Point(161, 38)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(31, 26)
        Me.btnRechercher.TabIndex = 6
        Me.btnRechercher.UseVisualStyleBackColor = True
        '
        'BtnZoomMin
        '
        Me.BtnZoomMin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnZoomMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZoomMin.Image = CType(resources.GetObject("BtnZoomMin.Image"), System.Drawing.Image)
        Me.BtnZoomMin.Location = New System.Drawing.Point(199, 38)
        Me.BtnZoomMin.Name = "BtnZoomMin"
        Me.BtnZoomMin.Size = New System.Drawing.Size(31, 26)
        Me.BtnZoomMin.TabIndex = 7
        Me.BtnZoomMin.UseVisualStyleBackColor = True
        '
        'btnZoomMax
        '
        Me.btnZoomMax.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZoomMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomMax.Image = CType(resources.GetObject("btnZoomMax.Image"), System.Drawing.Image)
        Me.btnZoomMax.Location = New System.Drawing.Point(236, 38)
        Me.btnZoomMax.Name = "btnZoomMax"
        Me.btnZoomMax.Size = New System.Drawing.Size(31, 26)
        Me.btnZoomMax.TabIndex = 8
        Me.btnZoomMax.UseVisualStyleBackColor = True
        '
        'btnCouper
        '
        Me.btnCouper.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCouper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCouper.Image = CType(resources.GetObject("btnCouper.Image"), System.Drawing.Image)
        Me.btnCouper.Location = New System.Drawing.Point(274, 38)
        Me.btnCouper.Name = "btnCouper"
        Me.btnCouper.Size = New System.Drawing.Size(31, 26)
        Me.btnCouper.TabIndex = 10
        Me.btnCouper.UseVisualStyleBackColor = True
        '
        'BtnCopier
        '
        Me.BtnCopier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCopier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopier.Image = CType(resources.GetObject("BtnCopier.Image"), System.Drawing.Image)
        Me.BtnCopier.Location = New System.Drawing.Point(311, 38)
        Me.BtnCopier.Name = "BtnCopier"
        Me.BtnCopier.Size = New System.Drawing.Size(31, 26)
        Me.BtnCopier.TabIndex = 11
        Me.BtnCopier.UseVisualStyleBackColor = True
        '
        'btnColler
        '
        Me.btnColler.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnColler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColler.Image = CType(resources.GetObject("btnColler.Image"), System.Drawing.Image)
        Me.btnColler.Location = New System.Drawing.Point(348, 38)
        Me.btnColler.Name = "btnColler"
        Me.btnColler.Size = New System.Drawing.Size(31, 26)
        Me.btnColler.TabIndex = 12
        Me.btnColler.UseVisualStyleBackColor = True
        '
        'btnPrecedent
        '
        Me.btnPrecedent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrecedent.Image = CType(resources.GetObject("btnPrecedent.Image"), System.Drawing.Image)
        Me.btnPrecedent.Location = New System.Drawing.Point(385, 38)
        Me.btnPrecedent.Name = "btnPrecedent"
        Me.btnPrecedent.Size = New System.Drawing.Size(31, 26)
        Me.btnPrecedent.TabIndex = 13
        Me.btnPrecedent.UseVisualStyleBackColor = True
        '
        'btnSuivant
        '
        Me.btnSuivant.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSuivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuivant.Image = CType(resources.GetObject("btnSuivant.Image"), System.Drawing.Image)
        Me.btnSuivant.Location = New System.Drawing.Point(422, 38)
        Me.btnSuivant.Name = "btnSuivant"
        Me.btnSuivant.Size = New System.Drawing.Size(31, 26)
        Me.btnSuivant.TabIndex = 14
        Me.btnSuivant.UseVisualStyleBackColor = True
        '
        'btnAjouterDate
        '
        Me.btnAjouterDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjouterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouterDate.Image = CType(resources.GetObject("btnAjouterDate.Image"), System.Drawing.Image)
        Me.btnAjouterDate.Location = New System.Drawing.Point(459, 38)
        Me.btnAjouterDate.Name = "btnAjouterDate"
        Me.btnAjouterDate.Size = New System.Drawing.Size(31, 26)
        Me.btnAjouterDate.TabIndex = 15
        Me.btnAjouterDate.UseVisualStyleBackColor = True
        '
        'btnAjouterHeure
        '
        Me.btnAjouterHeure.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjouterHeure.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouterHeure.Image = CType(resources.GetObject("btnAjouterHeure.Image"), System.Drawing.Image)
        Me.btnAjouterHeure.Location = New System.Drawing.Point(496, 38)
        Me.btnAjouterHeure.Name = "btnAjouterHeure"
        Me.btnAjouterHeure.Size = New System.Drawing.Size(31, 26)
        Me.btnAjouterHeure.TabIndex = 16
        Me.btnAjouterHeure.UseVisualStyleBackColor = True
        '
        'frmEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 541)
        Me.Controls.Add(Me.btnAjouterHeure)
        Me.Controls.Add(Me.btnAjouterDate)
        Me.Controls.Add(Me.btnSuivant)
        Me.Controls.Add(Me.btnPrecedent)
        Me.Controls.Add(Me.btnColler)
        Me.Controls.Add(Me.BtnCopier)
        Me.Controls.Add(Me.btnCouper)
        Me.Controls.Add(Me.btnZoomMax)
        Me.Controls.Add(Me.BtnZoomMin)
        Me.Controls.Add(Me.btnRechercher)
        Me.Controls.Add(Me.btnImprimer)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.btnOuvrir)
        Me.Controls.Add(Me.btnNouveau)
        Me.Controls.Add(Me.rtfRichTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEditor"
        Me.Text = "Basic Horse Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtfRichTextBox As System.Windows.Forms.RichTextBox

    Private Sub frmWordPad_Load(sender As Object,
                                e As EventArgs) Handles MyBase.Load

        rtfRichTextBox.Focus()


    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AnnulerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private Sub AnnulerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnulerToolStripMenuItem.Click

    End Sub
    Friend WithEvents AnnulerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RétablirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CouperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CollerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SélectionnerToutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateEtHeureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private Sub FormatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatToolStripMenuItem.Click

    End Sub
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EnregistrerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrerSousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MiseEnPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FermerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AffichageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnNouveau As System.Windows.Forms.Button
    Friend WithEvents btnOuvrir As System.Windows.Forms.Button
    Friend WithEvents btnEnregistrer As System.Windows.Forms.Button
    Friend WithEvents btnImprimer As System.Windows.Forms.Button
    Friend WithEvents btnRechercher As System.Windows.Forms.Button
    Friend WithEvents BtnZoomMin As System.Windows.Forms.Button
    Friend WithEvents btnZoomMax As System.Windows.Forms.Button
    Friend WithEvents btnCouper As System.Windows.Forms.Button
    Friend WithEvents BtnCopier As System.Windows.Forms.Button
    Friend WithEvents btnColler As System.Windows.Forms.Button
    Friend WithEvents btnPrecedent As System.Windows.Forms.Button
    Friend WithEvents btnSuivant As System.Windows.Forms.Button
    Friend WithEvents btnAjouterDate As System.Windows.Forms.Button
    Friend WithEvents btnAjouterHeure As System.Windows.Forms.Button

    Private Sub AnnulerToolStripMenuItem1_Click(sender As Object,
                                                e As EventArgs) Handles AnnulerToolStripMenuItem1.Click

        rtfRichTextBox.Undo()



    End Sub

    Private Sub RétablirToolStripMenuItem_Click(sender As Object,
                                                e As EventArgs) Handles RétablirToolStripMenuItem.Click

        rtfRichTextBox.Redo()

    End Sub

    Private Sub CouperToolStripMenuItem_Click(sender As Object,
                                              e As EventArgs) Handles CouperToolStripMenuItem.Click

        rtfRichTextBox.Cut()

    End Sub

    Private Sub CopierToolStripMenuItem_Click(sender As Object,
                                              e As EventArgs) Handles CopierToolStripMenuItem.Click

        rtfRichTextBox.Copy()

    End Sub

    Private Sub CollerToolStripMenuItem_Click(sender As Object,
                                              e As EventArgs) Handles CollerToolStripMenuItem.Click

        rtfRichTextBox.Paste()

    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object,
                                                 e As EventArgs)



    End Sub

    Private Sub SélectionnerToutToolStripMenuItem_Click(sender As Object,
                                                        e As EventArgs) Handles SélectionnerToutToolStripMenuItem.Click

        rtfRichTextBox.SelectAll()

    End Sub

    Private Sub DateEtHeureToolStripMenuItem_Click(sender As Object,
                                                   e As EventArgs) Handles DateEtHeureToolStripMenuItem.Click

        rtfRichTextBox.Text += Now.ToString + Environment.NewLine

    End Sub

    Private Sub btnNouveau_Click(sender As Object,
                                 e As EventArgs) Handles btnNouveau.Click

        If rtfRichTextBox.Text = "" Then

        End If

    End Sub
End Class
