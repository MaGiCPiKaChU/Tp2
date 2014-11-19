<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditeur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditeur))
        Me.dlgOuvrir = New System.Windows.Forms.OpenFileDialog()
        Me.prtDocument = New System.Drawing.Printing.PrintDocument()
        Me.dlgImprimer = New System.Windows.Forms.PrintDialog()
        Me.dlgPolice = New System.Windows.Forms.FontDialog()
        Me.dlgEnregistrer = New System.Windows.Forms.SaveFileDialog()
        Me.msBarreMenu = New System.Windows.Forms.MenuStrip()
        Me.miFichier = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFichierNouveau = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFichierOuvrir = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFichierEnregistrer = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFichierEnregSous = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.miFichierImprimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.miFichierQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEdition = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEditionAnnuler = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEditionRefaire = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.miEditionCouper = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEditionCopier = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEditionColler = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.miEditionRechercher = New System.Windows.Forms.ToolStripMenuItem()
        Me.miEditionRechercherSuiv = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.miEditionHeureDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.miFormatRetourAutomatique = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFormat = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFormatStyle = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFormatStyleGras = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFormatStyleIta = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFormatStyleSous = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFormatPolice = New System.Windows.Forms.ToolStripMenuItem()
        Me.miFormatCouleur = New System.Windows.Forms.ToolStripMenuItem()
        Me.rtfZoneTexte = New System.Windows.Forms.RichTextBox()
        Me.dlgCouleur = New System.Windows.Forms.ColorDialog()
        Me.dlgApercu = New System.Windows.Forms.PrintPreviewDialog()
        Me.dlgMiseEnPage = New System.Windows.Forms.PageSetupDialog()
        Me.ssBarreEtat = New System.Windows.Forms.StatusStrip()
        Me.ssTaille = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ssDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsBarreOutils = New System.Windows.Forms.ToolStrip()
        Me.btnNouveau = New System.Windows.Forms.ToolStripButton()
        Me.btnOuvrir = New System.Windows.Forms.ToolStripButton()
        Me.btnEnregistrer = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimer = New System.Windows.Forms.ToolStripButton()
        Me.btnRechercher = New System.Windows.Forms.ToolStripButton()
        Me.btnCouper = New System.Windows.Forms.ToolStripButton()
        Me.btnCopier = New System.Windows.Forms.ToolStripButton()
        Me.btnColler = New System.Windows.Forms.ToolStripButton()
        Me.btnRetourLigne = New System.Windows.Forms.ToolStripButton()
        Me.btnAnnuler = New System.Windows.Forms.ToolStripButton()
        Me.btnRefaire = New System.Windows.Forms.ToolStripButton()
        Me.btnGras = New System.Windows.Forms.ToolStripButton()
        Me.btnItalic = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.msBarreMenu.SuspendLayout()
        Me.ssBarreEtat.SuspendLayout()
        Me.tsBarreOutils.SuspendLayout()
        Me.SuspendLayout()
        '
        'prtDocument
        '
        '
        'msBarreMenu
        '
        Me.msBarreMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFichier, Me.miEdition, Me.miFormat})
        Me.msBarreMenu.Location = New System.Drawing.Point(0, 0)
        Me.msBarreMenu.Name = "msBarreMenu"
        Me.msBarreMenu.Size = New System.Drawing.Size(647, 24)
        Me.msBarreMenu.TabIndex = 2
        Me.msBarreMenu.Text = "MenuStrip1"
        '
        'miFichier
        '
        Me.miFichier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFichierNouveau, Me.miFichierOuvrir, Me.miFichierEnregistrer, Me.miFichierEnregSous, Me.ToolStripMenuItem1, Me.miFichierImprimer, Me.ToolStripMenuItem3, Me.miFichierQuitter})
        Me.miFichier.Name = "miFichier"
        Me.miFichier.Size = New System.Drawing.Size(54, 20)
        Me.miFichier.Text = "&Fichier"
        '
        'miFichierNouveau
        '
        Me.miFichierNouveau.Name = "miFichierNouveau"
        Me.miFichierNouveau.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.miFichierNouveau.Size = New System.Drawing.Size(229, 22)
        Me.miFichierNouveau.Text = "&Nouveau"
        '
        'miFichierOuvrir
        '
        Me.miFichierOuvrir.Name = "miFichierOuvrir"
        Me.miFichierOuvrir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.miFichierOuvrir.Size = New System.Drawing.Size(229, 22)
        Me.miFichierOuvrir.Text = "&Ouvrir"
        '
        'miFichierEnregistrer
        '
        Me.miFichierEnregistrer.Name = "miFichierEnregistrer"
        Me.miFichierEnregistrer.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.miFichierEnregistrer.Size = New System.Drawing.Size(229, 22)
        Me.miFichierEnregistrer.Text = "&Enregistrer"
        '
        'miFichierEnregSous
        '
        Me.miFichierEnregSous.Name = "miFichierEnregSous"
        Me.miFichierEnregSous.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.miFichierEnregSous.Size = New System.Drawing.Size(229, 22)
        Me.miFichierEnregSous.Text = "En&registrer sous..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(226, 6)
        '
        'miFichierImprimer
        '
        Me.miFichierImprimer.Name = "miFichierImprimer"
        Me.miFichierImprimer.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.miFichierImprimer.Size = New System.Drawing.Size(229, 22)
        Me.miFichierImprimer.Text = "&Imprimer..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(226, 6)
        '
        'miFichierQuitter
        '
        Me.miFichierQuitter.Name = "miFichierQuitter"
        Me.miFichierQuitter.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.miFichierQuitter.Size = New System.Drawing.Size(229, 22)
        Me.miFichierQuitter.Text = "&Quitter"
        '
        'miEdition
        '
        Me.miEdition.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miEditionAnnuler, Me.miEditionRefaire, Me.ToolStripSeparator1, Me.miEditionCouper, Me.miEditionCopier, Me.miEditionColler, Me.ToolStripSeparator2, Me.miEditionRechercher, Me.miEditionRechercherSuiv, Me.ToolStripSeparator3, Me.miEditionHeureDate, Me.ToolStripSeparator4, Me.miFormatRetourAutomatique})
        Me.miEdition.Name = "miEdition"
        Me.miEdition.Size = New System.Drawing.Size(56, 20)
        Me.miEdition.Text = "&Edition"
        '
        'miEditionAnnuler
        '
        Me.miEditionAnnuler.Name = "miEditionAnnuler"
        Me.miEditionAnnuler.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.miEditionAnnuler.Size = New System.Drawing.Size(230, 22)
        Me.miEditionAnnuler.Text = "&Annuler"
        '
        'miEditionRefaire
        '
        Me.miEditionRefaire.Name = "miEditionRefaire"
        Me.miEditionRefaire.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.miEditionRefaire.Size = New System.Drawing.Size(230, 22)
        Me.miEditionRefaire.Text = "Re&faire"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(227, 6)
        '
        'miEditionCouper
        '
        Me.miEditionCouper.Name = "miEditionCouper"
        Me.miEditionCouper.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.miEditionCouper.Size = New System.Drawing.Size(230, 22)
        Me.miEditionCouper.Text = "&Couper"
        '
        'miEditionCopier
        '
        Me.miEditionCopier.Name = "miEditionCopier"
        Me.miEditionCopier.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.miEditionCopier.Size = New System.Drawing.Size(230, 22)
        Me.miEditionCopier.Text = "Co&pier"
        '
        'miEditionColler
        '
        Me.miEditionColler.Name = "miEditionColler"
        Me.miEditionColler.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.miEditionColler.Size = New System.Drawing.Size(230, 22)
        Me.miEditionColler.Text = "C&oller"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(227, 6)
        '
        'miEditionRechercher
        '
        Me.miEditionRechercher.Name = "miEditionRechercher"
        Me.miEditionRechercher.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.miEditionRechercher.Size = New System.Drawing.Size(230, 22)
        Me.miEditionRechercher.Text = "&Rechercher..."
        '
        'miEditionRechercherSuiv
        '
        Me.miEditionRechercherSuiv.Name = "miEditionRechercherSuiv"
        Me.miEditionRechercherSuiv.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.miEditionRechercherSuiv.Size = New System.Drawing.Size(230, 22)
        Me.miEditionRechercherSuiv.Text = "Rechercher le sui&vant"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(227, 6)
        '
        'miEditionHeureDate
        '
        Me.miEditionHeureDate.Name = "miEditionHeureDate"
        Me.miEditionHeureDate.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.miEditionHeureDate.Size = New System.Drawing.Size(230, 22)
        Me.miEditionHeureDate.Text = "Heure/&Date"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(227, 6)
        '
        'miFormatRetourAutomatique
        '
        Me.miFormatRetourAutomatique.Checked = True
        Me.miFormatRetourAutomatique.CheckState = System.Windows.Forms.CheckState.Checked
        Me.miFormatRetourAutomatique.Name = "miFormatRetourAutomatique"
        Me.miFormatRetourAutomatique.Size = New System.Drawing.Size(230, 22)
        Me.miFormatRetourAutomatique.Text = "Retour automatique à la &ligne"
        '
        'miFormat
        '
        Me.miFormat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFormatStyle, Me.miFormatPolice, Me.miFormatCouleur})
        Me.miFormat.Name = "miFormat"
        Me.miFormat.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.miFormat.Size = New System.Drawing.Size(57, 20)
        Me.miFormat.Text = "F&ormat"
        '
        'miFormatStyle
        '
        Me.miFormatStyle.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.miFormatStyleGras, Me.miFormatStyleIta, Me.miFormatStyleSous})
        Me.miFormatStyle.Name = "miFormatStyle"
        Me.miFormatStyle.Size = New System.Drawing.Size(125, 22)
        Me.miFormatStyle.Text = "&Style"
        '
        'miFormatStyleGras
        '
        Me.miFormatStyleGras.Name = "miFormatStyleGras"
        Me.miFormatStyleGras.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.miFormatStyleGras.Size = New System.Drawing.Size(162, 22)
        Me.miFormatStyleGras.Text = "&Gras"
        '
        'miFormatStyleIta
        '
        Me.miFormatStyleIta.Name = "miFormatStyleIta"
        Me.miFormatStyleIta.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.miFormatStyleIta.Size = New System.Drawing.Size(162, 22)
        Me.miFormatStyleIta.Text = "&Italique"
        '
        'miFormatStyleSous
        '
        Me.miFormatStyleSous.Name = "miFormatStyleSous"
        Me.miFormatStyleSous.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.miFormatStyleSous.Size = New System.Drawing.Size(162, 22)
        Me.miFormatStyleSous.Text = "&Souligne"
        '
        'miFormatPolice
        '
        Me.miFormatPolice.Name = "miFormatPolice"
        Me.miFormatPolice.ShortcutKeyDisplayString = ""
        Me.miFormatPolice.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.miFormatPolice.Size = New System.Drawing.Size(152, 22)
        Me.miFormatPolice.Text = "&Police..."
        '
        'miFormatCouleur
        '
        Me.miFormatCouleur.Name = "miFormatCouleur"
        Me.miFormatCouleur.ShortcutKeyDisplayString = ""
        Me.miFormatCouleur.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.miFormatCouleur.Size = New System.Drawing.Size(152, 22)
        Me.miFormatCouleur.Text = "&Couleur..."
        '
        'rtfZoneTexte
        '
        Me.rtfZoneTexte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtfZoneTexte.Location = New System.Drawing.Point(0, 52)
        Me.rtfZoneTexte.Name = "rtfZoneTexte"
        Me.rtfZoneTexte.Size = New System.Drawing.Size(647, 324)
        Me.rtfZoneTexte.TabIndex = 30
        Me.rtfZoneTexte.Text = ""
        Me.rtfZoneTexte.WordWrap = False
        '
        'dlgApercu
        '
        Me.dlgApercu.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgApercu.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgApercu.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgApercu.Enabled = True
        Me.dlgApercu.Icon = CType(resources.GetObject("dlgApercu.Icon"), System.Drawing.Icon)
        Me.dlgApercu.Name = "dlgApercu"
        Me.dlgApercu.Visible = False
        '
        'ssBarreEtat
        '
        Me.ssBarreEtat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssTaille, Me.ssDate})
        Me.ssBarreEtat.Location = New System.Drawing.Point(0, 379)
        Me.ssBarreEtat.Name = "ssBarreEtat"
        Me.ssBarreEtat.Size = New System.Drawing.Size(647, 22)
        Me.ssBarreEtat.TabIndex = 0
        Me.ssBarreEtat.Text = "StatusStrip1"
        '
        'ssTaille
        '
        Me.ssTaille.Name = "ssTaille"
        Me.ssTaille.Size = New System.Drawing.Size(538, 17)
        Me.ssTaille.Spring = True
        Me.ssTaille.Text = "Taille : 0 octet"
        '
        'ssDate
        '
        Me.ssDate.Name = "ssDate"
        Me.ssDate.Size = New System.Drawing.Size(94, 17)
        Me.ssDate.Text = "Date du système"
        '
        'tsBarreOutils
        '
        Me.tsBarreOutils.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNouveau, Me.btnOuvrir, Me.btnEnregistrer, Me.btnImprimer, Me.ToolStripSeparator5, Me.btnRechercher, Me.btnCouper, Me.btnCopier, Me.btnColler, Me.ToolStripSeparator6, Me.btnAnnuler, Me.btnRefaire, Me.ToolStripSeparator7, Me.btnRetourLigne, Me.btnGras, Me.btnItalic})
        Me.tsBarreOutils.Location = New System.Drawing.Point(0, 24)
        Me.tsBarreOutils.Name = "tsBarreOutils"
        Me.tsBarreOutils.Size = New System.Drawing.Size(647, 25)
        Me.tsBarreOutils.TabIndex = 33
        Me.tsBarreOutils.Text = "ToolStrip1"
        '
        'btnNouveau
        '
        Me.btnNouveau.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNouveau.Image = CType(resources.GetObject("btnNouveau.Image"), System.Drawing.Image)
        Me.btnNouveau.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNouveau.Name = "btnNouveau"
        Me.btnNouveau.Size = New System.Drawing.Size(23, 22)
        '
        'btnOuvrir
        '
        Me.btnOuvrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnOuvrir.Image = CType(resources.GetObject("btnOuvrir.Image"), System.Drawing.Image)
        Me.btnOuvrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnOuvrir.Name = "btnOuvrir"
        Me.btnOuvrir.Size = New System.Drawing.Size(23, 22)
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEnregistrer.Image = CType(resources.GetObject("btnEnregistrer.Image"), System.Drawing.Image)
        Me.btnEnregistrer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(23, 22)
        '
        'btnImprimer
        '
        Me.btnImprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimer.Image = CType(resources.GetObject("btnImprimer.Image"), System.Drawing.Image)
        Me.btnImprimer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimer.Name = "btnImprimer"
        Me.btnImprimer.Size = New System.Drawing.Size(23, 22)
        '
        'btnRechercher
        '
        Me.btnRechercher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRechercher.Image = CType(resources.GetObject("btnRechercher.Image"), System.Drawing.Image)
        Me.btnRechercher.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(23, 22)
        '
        'btnCouper
        '
        Me.btnCouper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCouper.Image = CType(resources.GetObject("btnCouper.Image"), System.Drawing.Image)
        Me.btnCouper.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCouper.Name = "btnCouper"
        Me.btnCouper.Size = New System.Drawing.Size(23, 22)
        '
        'btnCopier
        '
        Me.btnCopier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopier.Image = CType(resources.GetObject("btnCopier.Image"), System.Drawing.Image)
        Me.btnCopier.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopier.Name = "btnCopier"
        Me.btnCopier.Size = New System.Drawing.Size(23, 22)
        '
        'btnColler
        '
        Me.btnColler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnColler.Image = CType(resources.GetObject("btnColler.Image"), System.Drawing.Image)
        Me.btnColler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnColler.Name = "btnColler"
        Me.btnColler.Size = New System.Drawing.Size(23, 22)
        '
        'btnRetourLigne
        '
        Me.btnRetourLigne.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRetourLigne.Image = CType(resources.GetObject("btnRetourLigne.Image"), System.Drawing.Image)
        Me.btnRetourLigne.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRetourLigne.Name = "btnRetourLigne"
        Me.btnRetourLigne.Size = New System.Drawing.Size(23, 22)
        '
        'btnAnnuler
        '
        Me.btnAnnuler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAnnuler.Image = CType(resources.GetObject("btnAnnuler.Image"), System.Drawing.Image)
        Me.btnAnnuler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(23, 22)
        '
        'btnRefaire
        '
        Me.btnRefaire.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefaire.Image = CType(resources.GetObject("btnRefaire.Image"), System.Drawing.Image)
        Me.btnRefaire.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefaire.Name = "btnRefaire"
        Me.btnRefaire.Size = New System.Drawing.Size(23, 22)
        '
        'btnGras
        '
        Me.btnGras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGras.Image = CType(resources.GetObject("btnGras.Image"), System.Drawing.Image)
        Me.btnGras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGras.Name = "btnGras"
        Me.btnGras.Size = New System.Drawing.Size(23, 22)
        '
        'btnItalic
        '
        Me.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnItalic.Image = CType(resources.GetObject("btnItalic.Image"), System.Drawing.Image)
        Me.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnItalic.Name = "btnItalic"
        Me.btnItalic.Size = New System.Drawing.Size(23, 22)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'frmEditeur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 401)
        Me.Controls.Add(Me.tsBarreOutils)
        Me.Controls.Add(Me.ssBarreEtat)
        Me.Controls.Add(Me.rtfZoneTexte)
        Me.Controls.Add(Me.msBarreMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msBarreMenu
        Me.Name = "frmEditeur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Éditeur de texte style Bloc-Notes"
        Me.msBarreMenu.ResumeLayout(False)
        Me.msBarreMenu.PerformLayout()
        Me.ssBarreEtat.ResumeLayout(False)
        Me.ssBarreEtat.PerformLayout()
        Me.tsBarreOutils.ResumeLayout(False)
        Me.tsBarreOutils.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dlgOuvrir As System.Windows.Forms.OpenFileDialog
    Friend WithEvents prtDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents dlgImprimer As System.Windows.Forms.PrintDialog
    Friend WithEvents dlgPolice As System.Windows.Forms.FontDialog
    Friend WithEvents dlgEnregistrer As System.Windows.Forms.SaveFileDialog
    Friend WithEvents msBarreMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents miFichier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFichierNouveau As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFichierOuvrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miFichierEnregistrer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFichierEnregSous As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFichierImprimer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miFichierQuitter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miEdition As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miEditionRechercher As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miEditionRechercherSuiv As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFormat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFormatPolice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtfZoneTexte As System.Windows.Forms.RichTextBox
    Friend WithEvents miFormatCouleur As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgCouleur As System.Windows.Forms.ColorDialog
    Friend WithEvents dlgApercu As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents dlgMiseEnPage As System.Windows.Forms.PageSetupDialog
    Friend WithEvents ssBarreEtat As System.Windows.Forms.StatusStrip
    Friend WithEvents ssTaille As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ssDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsBarreOutils As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNouveau As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnOuvrir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEnregistrer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCouper As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCopier As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnColler As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRetourLigne As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAnnuler As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefaire As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGras As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnItalic As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRechercher As System.Windows.Forms.ToolStripButton
    Friend WithEvents miEditionAnnuler As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miEditionRefaire As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miEditionCouper As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miEditionCopier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miEditionColler As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miEditionHeureDate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents miFormatRetourAutomatique As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFormatStyle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFormatStyleGras As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFormatStyleIta As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents miFormatStyleSous As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
End Class
