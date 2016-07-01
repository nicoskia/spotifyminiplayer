<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TimerGetTrack = New System.Windows.Forms.Timer(Me.components)
        Me.lblTrack = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.marqueeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.trackRight = New System.Windows.Forms.Label()
        Me.MiniPlayer = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnOpen = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.PictureBox()
        Me.volUp = New System.Windows.Forms.PictureBox()
        Me.volDown = New System.Windows.Forms.PictureBox()
        Me.scrollBoundRight = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.PictureBox()
        Me.btnPlay = New System.Windows.Forms.PictureBox()
        Me.btnPrev = New System.Windows.Forms.PictureBox()
        Me.scrollBoundLeft = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.btnOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.volDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrollBoundRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrollBoundLeft, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTrack.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.lblTrack.Location = New System.Drawing.Point(92, 11)
        Me.lblTrack.Name = "lblTrack"
        Me.lblTrack.Size = New System.Drawing.Size(0, 20)
        Me.lblTrack.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(93, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = " "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'marqueeTimer
        '
        Me.marqueeTimer.Interval = 25
        '
        'trackRight
        '
        Me.trackRight.AutoSize = True
        Me.trackRight.BackColor = System.Drawing.Color.Transparent
        Me.trackRight.Cursor = System.Windows.Forms.Cursors.Cross
        Me.trackRight.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.trackRight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.trackRight.Location = New System.Drawing.Point(355, 13)
        Me.trackRight.Name = "trackRight"
        Me.trackRight.Size = New System.Drawing.Size(0, 20)
        Me.trackRight.TabIndex = 11
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
        'btnOpen
        '
        Me.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOpen.Image = Global.SpotifyMiniPlayer.My.Resources.Resources.resize1
        Me.btnOpen.Location = New System.Drawing.Point(339, 24)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(18, 18)
        Me.btnOpen.TabIndex = 12
        Me.btnOpen.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnOpen, "Show/Hide Spotify")
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExit.Image = Global.SpotifyMiniPlayer.My.Resources.Resources._exit
        Me.btnExit.Location = New System.Drawing.Point(337, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(20, 17)
        Me.btnExit.TabIndex = 8
        Me.btnExit.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnExit, "Close this Mini-Player")
        '
        'volUp
        '
        Me.volUp.Image = Global.SpotifyMiniPlayer.My.Resources.Resources.plus
        Me.volUp.Location = New System.Drawing.Point(71, 5)
        Me.volUp.Name = "volUp"
        Me.volUp.Size = New System.Drawing.Size(14, 13)
        Me.volUp.TabIndex = 15
        Me.volUp.TabStop = False
        '
        'volDown
        '
        Me.volDown.Image = Global.SpotifyMiniPlayer.My.Resources.Resources.minus
        Me.volDown.Location = New System.Drawing.Point(71, 41)
        Me.volDown.Name = "volDown"
        Me.volDown.Size = New System.Drawing.Size(14, 13)
        Me.volDown.TabIndex = 14
        Me.volDown.TabStop = False
        '
        'scrollBoundRight
        '
        Me.scrollBoundRight.Location = New System.Drawing.Point(322, -11)
        Me.scrollBoundRight.Name = "scrollBoundRight"
        Me.scrollBoundRight.Size = New System.Drawing.Size(43, 79)
        Me.scrollBoundRight.TabIndex = 9
        Me.scrollBoundRight.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Image = Global.SpotifyMiniPlayer.My.Resources.Resources.next1
        Me.btnNext.Location = New System.Drawing.Point(71, 23)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(15, 15)
        Me.btnNext.TabIndex = 5
        Me.btnNext.TabStop = False
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(27, 11)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(38, 37)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.TabStop = False
        '
        'btnPrev
        '
        Me.btnPrev.Image = Global.SpotifyMiniPlayer.My.Resources.Resources.prev1
        Me.btnPrev.Location = New System.Drawing.Point(7, 23)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(14, 15)
        Me.btnPrev.TabIndex = 3
        Me.btnPrev.TabStop = False
        '
        'scrollBoundLeft
        '
        Me.scrollBoundLeft.Location = New System.Drawing.Point(-27, 2)
        Me.scrollBoundLeft.Name = "scrollBoundLeft"
        Me.scrollBoundLeft.Size = New System.Drawing.Size(119, 54)
        Me.scrollBoundLeft.TabIndex = 10
        Me.scrollBoundLeft.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(359, 56)
        Me.ControlBox = False
        Me.Controls.Add(Me.volUp)
        Me.Controls.Add(Me.volDown)
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
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.btnOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.volDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scrollBoundRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPlay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scrollBoundLeft, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents volDown As PictureBox
    Friend WithEvents volUp As PictureBox
End Class
