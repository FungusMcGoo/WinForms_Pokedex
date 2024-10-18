<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pokedex
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        cmb_Search = New ComboBox()
        btn_Search = New Button()
        pic_Pokemon = New PictureBox()
        rtxt_Description = New RichTextBox()
        panel_Stats = New Panel()
        PictureBox1 = New PictureBox()
        pic_Type1 = New PictureBox()
        dgv_Stats = New DataGridView()
        statName = New DataGridViewTextBoxColumn()
        statValue = New DataGridViewTextBoxColumn()
        CType(pic_Pokemon, ComponentModel.ISupportInitialize).BeginInit()
        panel_Stats.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Type1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_Stats, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmb_Search
        ' 
        cmb_Search.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmb_Search.AutoCompleteSource = AutoCompleteSource.ListItems
        cmb_Search.FormattingEnabled = True
        cmb_Search.Location = New Point(11, 12)
        cmb_Search.Name = "cmb_Search"
        cmb_Search.RightToLeft = RightToLeft.No
        cmb_Search.Size = New Size(644, 33)
        cmb_Search.TabIndex = 0
        cmb_Search.Text = "Search..."
        ' 
        ' btn_Search
        ' 
        btn_Search.Location = New Point(661, 12)
        btn_Search.Name = "btn_Search"
        btn_Search.Size = New Size(224, 33)
        btn_Search.TabIndex = 1
        btn_Search.Text = "Go!"
        btn_Search.UseVisualStyleBackColor = True
        ' 
        ' pic_Pokemon
        ' 
        pic_Pokemon.Location = New Point(11, 52)
        pic_Pokemon.Name = "pic_Pokemon"
        pic_Pokemon.Size = New Size(519, 378)
        pic_Pokemon.TabIndex = 2
        pic_Pokemon.TabStop = False
        ' 
        ' rtxt_Description
        ' 
        rtxt_Description.Location = New Point(11, 437)
        rtxt_Description.Name = "rtxt_Description"
        rtxt_Description.Size = New Size(518, 192)
        rtxt_Description.TabIndex = 4
        rtxt_Description.Text = ""
        ' 
        ' panel_Stats
        ' 
        panel_Stats.Controls.Add(PictureBox1)
        panel_Stats.Controls.Add(pic_Type1)
        panel_Stats.Controls.Add(dgv_Stats)
        panel_Stats.Enabled = False
        panel_Stats.Location = New Point(537, 52)
        panel_Stats.Name = "panel_Stats"
        panel_Stats.Size = New Size(349, 576)
        panel_Stats.TabIndex = 11
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(-1, 53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(341, 47)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' pic_Type1
        ' 
        pic_Type1.Location = New Point(3, 0)
        pic_Type1.Name = "pic_Type1"
        pic_Type1.Size = New Size(341, 47)
        pic_Type1.TabIndex = 17
        pic_Type1.TabStop = False
        ' 
        ' dgv_Stats
        ' 
        dgv_Stats.AllowUserToAddRows = False
        dgv_Stats.AllowUserToDeleteRows = False
        dgv_Stats.BackgroundColor = SystemColors.Control
        dgv_Stats.BorderStyle = BorderStyle.None
        dgv_Stats.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgv_Stats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_Stats.ColumnHeadersVisible = False
        dgv_Stats.Columns.AddRange(New DataGridViewColumn() {statName, statValue})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgv_Stats.DefaultCellStyle = DataGridViewCellStyle1
        dgv_Stats.GridColor = SystemColors.Control
        dgv_Stats.Location = New Point(1, 210)
        dgv_Stats.Name = "dgv_Stats"
        dgv_Stats.ReadOnly = True
        dgv_Stats.RowHeadersVisible = False
        dgv_Stats.RowHeadersWidth = 62
        dgv_Stats.ScrollBars = ScrollBars.None
        dgv_Stats.Size = New Size(341, 369)
        dgv_Stats.TabIndex = 13
        ' 
        ' statName
        ' 
        statName.HeaderText = "statName"
        statName.MinimumWidth = 8
        statName.Name = "statName"
        statName.ReadOnly = True
        statName.Resizable = DataGridViewTriState.True
        statName.Width = 150
        ' 
        ' statValue
        ' 
        statValue.HeaderText = "statValue"
        statValue.MinimumWidth = 8
        statValue.Name = "statValue"
        statValue.ReadOnly = True
        statValue.Width = 240
        ' 
        ' Pokedex
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(894, 640)
        Controls.Add(rtxt_Description)
        Controls.Add(pic_Pokemon)
        Controls.Add(btn_Search)
        Controls.Add(cmb_Search)
        Controls.Add(panel_Stats)
        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False
        MinimizeBox = False
        Name = "Pokedex"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pokedex"
        CType(pic_Pokemon, ComponentModel.ISupportInitialize).EndInit()
        panel_Stats.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Type1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_Stats, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmb_Search As ComboBox
    Friend WithEvents btn_Search As Button
    Friend WithEvents pic_Pokemon As PictureBox
    Friend WithEvents rtxt_Description As RichTextBox
    Friend WithEvents panel_Stats As Panel
    Friend WithEvents pic_Type1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgv_Stats As DataGridView
    Friend WithEvents statName As DataGridViewTextBoxColumn
    Friend WithEvents statValue As DataGridViewTextBoxColumn

End Class
