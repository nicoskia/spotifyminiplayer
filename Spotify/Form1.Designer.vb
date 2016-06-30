<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TimerGetTrack = New System.Windows.Forms.Timer(Me.components)
        Me.lblTrack = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.marqueeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.trackRight = New System.Windows.Forms.Label()
        Me.btnOpen = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        Me.scrollBoundRight = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        Me.btnPlay = New System.Windows.Forms.PictureBox()
        Me.btnPrev = New System.Windows.Forms.PictureBox()
        Me.scrollBoundLeft = New System.Windows.Forms.PictureBox()
        Me.MiniPlayer = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.btnOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrollBoundRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrollBoundLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerGetTrack
        '
        Me.TimerGetTrack.Enabled = True
        Me.TimerGetTrack.Interval = 250
        '
        'lblTrack
        '
        Me.lblTrack.AutoSize = True
        Me.lblTrack.BackColor = System.Drawing.Color.Transparent
        Me.lblTrack.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lblTrack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.lblTrack.Location = New System.Drawing.Point(92, 13)
        Me.lblTrack.Name = "lblTrack"
        Me.lblTrack.Size = New System.Drawing.Size(0, 16)
        Me.lblTrack.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 5.5!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(92, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(8, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = " "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'marqueeTimer
        '
        '
        'trackRight
        '
        Me.trackRight.AutoSize = True
        Me.trackRight.BackColor = System.Drawing.Color.Transparent
        Me.trackRight.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.trackRight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.trackRight.Location = New System.Drawing.Point(355, 13)
        Me.trackRight.Name = "trackRight"
        Me.trackRight.Size = New System.Drawing.Size(0, 16)
        Me.trackRight.TabIndex = 11
        '
        'btnOpen
        '
        Me.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOpen.Image = Global.SpotifyMiniPlayer.My.Resources.Resources.spotify__2_
        Me.btnOpen.Location = New System.Drawing.Point(324, 24)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(31, 29)
        Me.btnOpen.TabIndex = 12
        Me.btnOpen.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExit.Location = New System.Drawing.Point(313, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(43, 17)
        Me.btnExit.TabIndex = 8
        Me.btnExit.TabStop = False
        '
        'scrollBoundRight
        '
        Me.scrollBoundRight.Location = New System.Drawing.Point(303, -11)
        Me.scrollBoundRight.Name = "scrollBoundRight"
        Me.scrollBoundRight.Size = New System.Drawing.Size(62, 40)
        Me.scrollBoundRight.TabIndex = 9
        Me.scrollBoundRight.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Image = Global.SpotifyMiniPlayer.My.Resources.Resources.next2
        Me.btnNext.Location = New System.Drawing.Point(71, 22)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(15, 15)
        Me.btnNext.TabIndex = 5
        Me.btnNext.TabStop = False
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(27, 10)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(38, 37)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.TabStop = False
        '
        'btnPrev
        '
        Me.btnPrev.Image = Global.SpotifyMiniPlayer.My.Resources.Resources.prev2
        Me.btnPrev.Location = New System.Drawing.Point(7, 22)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(14, 15)
        Me.btnPrev.TabIndex = 3
        Me.btnPrev.TabStop = False
        '
        'scrollBoundLeft
        '
        Me.scrollBoundLeft.Location = New System.Drawing.Point(-25, 4)
        Me.scrollBoundLeft.Name = "scrollBoundLeft"
        Me.scrollBoundLeft.Size = New System.Drawing.Size(119, 51)
        Me.scrollBoundLeft.TabIndex = 10
        Me.scrollBoundLeft.TabStop = False
        '
        'MiniPlayer
        '
        Me.MiniPlayer.ContextMenuStrip = Me.ContextMenuStrip1
        Me.MiniPlayer.Icon = CType(resources.GetObject("MiniPlayer.Icon"), System.Drawing.Icon)
        Me.MiniPlayer.Text = "Spotify Mini-Player"
        Me.MiniPlayer.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 30)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(108, 26)
        Me.ToolStripMenuItem1.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(359, 56)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.scrollBoundRight)
        Me.Controls.Add(Me.trackRight)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.scrollBoundLeft)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTrack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Mini-Player"
        CType(Me.btnOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scrollBoundRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scrollBoundLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimerGetTrack As Timer
    Friend WithEvents btnPrev As PictureBox
    Friend WithEvents btnPlay As PictureBox
    Friend WithEvents btnNext As PictureBox
    Friend WithEvents lblTrack As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As PictureBox
    Friend WithEvents marqueeTimer As Timer
    Friend WithEvents scrollBoundRight As PictureBox
    Friend WithEvents scrollBoundLeft As PictureBox
    Friend WithEvents trackRight As Label
    Friend WithEvents btnOpen As PictureBox
    Friend WithEvents MiniPlayer As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
