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
        cmb_Search = New ComboBox()
        btn_Search = New Button()
        pic_Pokemon = New PictureBox()
        rtxt_Description = New RichTextBox()
        lbl_HP = New Label()
        lbl_Attack = New Label()
        lbl_Defence = New Label()
        lbl_SpAttack = New Label()
        lbl_SpDefence = New Label()
        lbl_Speed = New Label()
        panel_Stats = New Panel()
        lbl_Generation = New Label()
        lbl_CatchRate = New Label()
        PictureBox1 = New PictureBox()
        pic_Type1 = New PictureBox()
        lbl_Class = New Label()
        lbl_Height = New Label()
        lbl_Weight = New Label()
        DataGridView1 = New DataGridView()
        CType(pic_Pokemon, ComponentModel.ISupportInitialize).BeginInit()
        panel_Stats.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pic_Type1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmb_Search
        ' 
        cmb_Search.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cmb_Search.AutoCompleteSource = AutoCompleteSource.ListItems
        cmb_Search.FormattingEnabled = True
        cmb_Search.Location = New Point(8, 7)
        cmb_Search.Margin = New Padding(2)
        cmb_Search.Name = "cmb_Search"
        cmb_Search.RightToLeft = RightToLeft.No
        cmb_Search.Size = New Size(452, 23)
        cmb_Search.TabIndex = 0
        cmb_Search.Text = "Search..."
        ' 
        ' btn_Search
        ' 
        btn_Search.Location = New Point(463, 7)
        btn_Search.Margin = New Padding(2)
        btn_Search.Name = "btn_Search"
        btn_Search.Size = New Size(157, 20)
        btn_Search.TabIndex = 1
        btn_Search.Text = "Go!"
        btn_Search.UseVisualStyleBackColor = True
        ' 
        ' pic_Pokemon
        ' 
        pic_Pokemon.Location = New Point(8, 31)
        pic_Pokemon.Margin = New Padding(2)
        pic_Pokemon.Name = "pic_Pokemon"
        pic_Pokemon.Size = New Size(363, 227)
        pic_Pokemon.TabIndex = 2
        pic_Pokemon.TabStop = False
        ' 
        ' rtxt_Description
        ' 
        rtxt_Description.Location = New Point(8, 262)
        rtxt_Description.Margin = New Padding(2)
        rtxt_Description.Name = "rtxt_Description"
        rtxt_Description.Size = New Size(364, 117)
        rtxt_Description.TabIndex = 4
        rtxt_Description.Text = ""
        ' 
        ' lbl_HP
        ' 
        lbl_HP.AutoSize = True
        lbl_HP.Location = New Point(2, 137)
        lbl_HP.Margin = New Padding(2, 0, 2, 0)
        lbl_HP.Name = "lbl_HP"
        lbl_HP.Size = New Size(23, 15)
        lbl_HP.TabIndex = 5
        lbl_HP.Text = "HP"
        ' 
        ' lbl_Attack
        ' 
        lbl_Attack.AutoSize = True
        lbl_Attack.Location = New Point(2, 152)
        lbl_Attack.Margin = New Padding(2, 0, 2, 0)
        lbl_Attack.Name = "lbl_Attack"
        lbl_Attack.Size = New Size(41, 15)
        lbl_Attack.TabIndex = 6
        lbl_Attack.Text = "Attack"
        ' 
        ' lbl_Defence
        ' 
        lbl_Defence.AutoSize = True
        lbl_Defence.Location = New Point(2, 167)
        lbl_Defence.Margin = New Padding(2, 0, 2, 0)
        lbl_Defence.Name = "lbl_Defence"
        lbl_Defence.Size = New Size(50, 15)
        lbl_Defence.TabIndex = 7
        lbl_Defence.Text = "Defence"
        ' 
        ' lbl_SpAttack
        ' 
        lbl_SpAttack.AutoSize = True
        lbl_SpAttack.Location = New Point(2, 182)
        lbl_SpAttack.Margin = New Padding(2, 0, 2, 0)
        lbl_SpAttack.Name = "lbl_SpAttack"
        lbl_SpAttack.Size = New Size(60, 15)
        lbl_SpAttack.TabIndex = 8
        lbl_SpAttack.Text = "Sp. Attack"
        ' 
        ' lbl_SpDefence
        ' 
        lbl_SpDefence.AutoSize = True
        lbl_SpDefence.Location = New Point(2, 197)
        lbl_SpDefence.Margin = New Padding(2, 0, 2, 0)
        lbl_SpDefence.Name = "lbl_SpDefence"
        lbl_SpDefence.Size = New Size(69, 15)
        lbl_SpDefence.TabIndex = 9
        lbl_SpDefence.Text = "Sp. Defence"
        ' 
        ' lbl_Speed
        ' 
        lbl_Speed.AutoSize = True
        lbl_Speed.Location = New Point(2, 212)
        lbl_Speed.Margin = New Padding(2, 0, 2, 0)
        lbl_Speed.Name = "lbl_Speed"
        lbl_Speed.Size = New Size(39, 15)
        lbl_Speed.TabIndex = 10
        lbl_Speed.Text = "Speed"
        ' 
        ' panel_Stats
        ' 
        panel_Stats.Controls.Add(lbl_Generation)
        panel_Stats.Controls.Add(lbl_CatchRate)
        panel_Stats.Controls.Add(PictureBox1)
        panel_Stats.Controls.Add(pic_Type1)
        panel_Stats.Controls.Add(lbl_Class)
        panel_Stats.Controls.Add(lbl_Height)
        panel_Stats.Controls.Add(lbl_Weight)
        panel_Stats.Controls.Add(lbl_HP)
        panel_Stats.Controls.Add(lbl_Attack)
        panel_Stats.Controls.Add(lbl_Defence)
        panel_Stats.Controls.Add(lbl_SpAttack)
        panel_Stats.Controls.Add(lbl_SpDefence)
        panel_Stats.Controls.Add(lbl_Speed)
        panel_Stats.Controls.Add(DataGridView1)
        panel_Stats.Enabled = False
        panel_Stats.Location = New Point(376, 31)
        panel_Stats.Margin = New Padding(2)
        panel_Stats.Name = "panel_Stats"
        panel_Stats.Size = New Size(244, 227)
        panel_Stats.TabIndex = 11
        ' 
        ' lbl_Generation
        ' 
        lbl_Generation.AutoSize = True
        lbl_Generation.Location = New Point(2, 60)
        lbl_Generation.Margin = New Padding(2, 0, 2, 0)
        lbl_Generation.Name = "lbl_Generation"
        lbl_Generation.Size = New Size(65, 15)
        lbl_Generation.TabIndex = 20
        lbl_Generation.Text = "Generation"
        ' 
        ' lbl_CatchRate
        ' 
        lbl_CatchRate.AutoSize = True
        lbl_CatchRate.Location = New Point(2, 120)
        lbl_CatchRate.Margin = New Padding(2, 0, 2, 0)
        lbl_CatchRate.Name = "lbl_CatchRate"
        lbl_CatchRate.Size = New Size(64, 15)
        lbl_CatchRate.TabIndex = 19
        lbl_CatchRate.Text = "Catch Rate"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(-1, 32)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(239, 28)
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' pic_Type1
        ' 
        pic_Type1.Location = New Point(2, 0)
        pic_Type1.Margin = New Padding(2)
        pic_Type1.Name = "pic_Type1"
        pic_Type1.Size = New Size(239, 28)
        pic_Type1.TabIndex = 17
        pic_Type1.TabStop = False
        ' 
        ' lbl_Class
        ' 
        lbl_Class.AutoSize = True
        lbl_Class.Location = New Point(2, 75)
        lbl_Class.Margin = New Padding(2, 0, 2, 0)
        lbl_Class.Name = "lbl_Class"
        lbl_Class.Size = New Size(77, 15)
        lbl_Class.TabIndex = 16
        lbl_Class.Text = "Classification"
        ' 
        ' lbl_Height
        ' 
        lbl_Height.AutoSize = True
        lbl_Height.Location = New Point(2, 90)
        lbl_Height.Margin = New Padding(2, 0, 2, 0)
        lbl_Height.Name = "lbl_Height"
        lbl_Height.Size = New Size(43, 15)
        lbl_Height.TabIndex = 15
        lbl_Height.Text = "Height"
        ' 
        ' lbl_Weight
        ' 
        lbl_Weight.AutoSize = True
        lbl_Weight.Location = New Point(2, 105)
        lbl_Weight.Margin = New Padding(2, 0, 2, 0)
        lbl_Weight.Name = "lbl_Weight"
        lbl_Weight.Size = New Size(45, 15)
        lbl_Weight.TabIndex = 14
        lbl_Weight.Text = "Weight"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLight
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(78, 137)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(166, 90)
        DataGridView1.TabIndex = 13
        ' 
        ' Pokedex
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(626, 384)
        Controls.Add(rtxt_Description)
        Controls.Add(pic_Pokemon)
        Controls.Add(btn_Search)
        Controls.Add(cmb_Search)
        Controls.Add(panel_Stats)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Margin = New Padding(2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Pokedex"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pokedex"
        CType(pic_Pokemon, ComponentModel.ISupportInitialize).EndInit()
        panel_Stats.ResumeLayout(False)
        panel_Stats.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pic_Type1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmb_Search As ComboBox
    Friend WithEvents btn_Search As Button
    Friend WithEvents pic_Pokemon As PictureBox
    Friend WithEvents rtxt_Description As RichTextBox
    Friend WithEvents lbl_HP As Label
    Friend WithEvents lbl_Attack As Label
    Friend WithEvents lbl_Defence As Label
    Friend WithEvents lbl_SpAttack As Label
    Friend WithEvents lbl_SpDefence As Label
    Friend WithEvents lbl_Speed As Label
    Friend WithEvents panel_Stats As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_Class As Label
    Friend WithEvents lbl_Height As Label
    Friend WithEvents lbl_Weight As Label
    Friend WithEvents pic_Type1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_CatchRate As Label
    Friend WithEvents lbl_Generation As Label

End Class
