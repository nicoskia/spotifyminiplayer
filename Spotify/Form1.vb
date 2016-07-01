Public Class Form1
    Dim MySpotify As New spotify 'for api
    Public Form1WindowState As Integer '0 for small, 1 for large, 2 for increasing, 3 for decreasing
    Public ShrinkHeight As Integer 'height of window in idle state
    Dim MouseHovering As Boolean 'true if mouse is hovering over title
    Dim Artist As String
    Dim TrackName As String
    Dim WelcomeMessage(2) As String 'startup message
    Dim HoverLockEnterTimer As Integer
    Dim HoverLockLeaveTimer As Integer
    Dim HoverLockThreshold As Integer
    Dim HoverMsg(2) As String 'message on hovering
    Dim JustClickedOpenSpotify As Boolean 'true if the user has just requested that spotify is opened
    Dim MouseButtonDown As Boolean 'true if mouse button is being held down
    Dim DoNotPerformClick As Boolean 'used when a button has been held to drag the form, rather than for the button's actual purpose
    Dim StartForm1WindowState As Integer

    Dim tempval As Integer
    Dim tempstring As String

    Public trackLLoc As Point = New Point(92, 11)
    Public trackRLoc As Point = New Point(355, 13)

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private w As Long
    Public Const SW_SHOW As Integer = 5
    Public Declare Function ShowWindow Lib "user32.dll" (ByVal w As Integer, ByVal nCmdShow As Integer) As Integer
    Private Declare Auto Function FindWindow Lib "user32" (ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    Public Declare Function IsWindowVisible Lib "user32.dll" (ByVal hwnd As IntPtr) As Boolean
    Public Declare Function IsIconic Lib "user32.dll" (ByVal hwnd As Integer) As Boolean

    'dropshadow
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Const DROPSHADOW = &H20000
            Dim cParam As CreateParams = MyBase.CreateParams
            cParam.ClassStyle = cParam.ClassStyle Or DROPSHADOW
            Return cParam
        End Get
    End Property

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TopMost = True

        HoverLockEnterTimer = 0
        HoverLockThreshold = 3
        JustClickedOpenSpotify = False

        WelcomeMessage(1) = "Welcome"
        WelcomeMessage(2) = "Please play a track from Spotify"
        HoverMsg(1) = "Open Spotify"
        HoverMsg(2) = "Click here to open Spotify"

        If MySpotify.IsSpotifyRunning = False Then MySpotify.ShowSpotify()

    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = MyBase.Location.X + (e.X - MouseDownX)
            temp.Y = MyBase.Location.Y + (e.Y - MouseDownY)
            MyBase.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub TimerGetTrack_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGetTrack.Tick

        w = FindWindow("SpotifyMainWindow", vbNullString)

        tempstring = MySpotify.Nowplaying
        'MsgBox(tempstring)

        'find location of hyphen ! bad for artists with a hyphen in their name - think it's fixed by adding space
        If MySpotify.Paused = False Then
            tempval = tempstring.IndexOf("- ")
        End If

        'detect artist and track name, and assign to labels
        'if hovering
        If MousePosition.X > Me.Left + lblTrack.Left And MousePosition.X < Me.Left + lblTrack.Left + Math.Max(lblTrack.Width, Label1.Width) And MousePosition.Y > Me.Top + lblTrack.Top And MousePosition.Y < Me.Top + ShrinkHeight Then
            MouseHovering = True
            If HoverLockEnterTimer <> HoverLockThreshold Then HoverLockEnterTimer += 1
        Else
            MouseHovering = False
            HoverLockEnterTimer = 0
            JustClickedOpenSpotify = False
        End If

        If JustClickedOpenSpotify = False And MySpotify.IsSpotifyRunning <> 0 And MouseHovering = True And DoNotPerformClick = False And HoverLockEnterTimer = HoverLockThreshold Then
            Label1.Text = HoverMsg(2)
            lblTrack.Text = HoverMsg(1)
            'ifplaying
        ElseIf MySpotify.Paused = False Then
            Artist = tempstring.Substring(0, tempval - 1)
            TrackName = tempstring.Substring(tempval + 2, Len(tempstring) - tempval - 2)
            If Label1.Text IsNot Artist Then Label1.Text = Artist
            If lblTrack.Text IsNot TrackName Then lblTrack.Text = TrackName
            If trackRight.Text IsNot TrackName Then trackRight.Text = TrackName
        ElseIf Artist Is Nothing And lblTrack.Text IsNot WelcomeMessage(1) Then
            lblTrack.Text = WelcomeMessage(1)
            Label1.Text = WelcomeMessage(2)
            'normal paused
        ElseIf MySpotify.Paused = True And MySpotify.IsSpotifyRunning > 0 Then
            If Artist IsNot WelcomeMessage(2) Then
                If Label1.Text IsNot Artist & " (Paused)" Then Label1.Text = Artist & " (Paused)"
            Else : Label1.Text = WelcomeMessage(2)
            End If
            lblTrack.Text = TrackName
            trackRight.Text = TrackName
            'main program is closed while toolbar still open
        ElseIf MySpotify.IsSpotifyRunning = 0 Then
            Label1.Text = "Attempting to re-open Spotify"
            lblTrack.Text = "Oops!"
            TrackName = WelcomeMessage(1)
            Artist = WelcomeMessage(2)
            MySpotify.ShowSpotify()
        End If

        If lblTrack.Width > 260 Then
            trackRight.Visible = True
        Else
            trackRight.Visible = False
        End If

        MySpotify.RefreshConnection()

        'updates play/pause button
        If MouseButtonDown = False Then
            If MySpotify.Paused = True Then
                If btnPlay.Image IsNot My.Resources.play1 Then btnPlay.Image = My.Resources.play1
            ElseIf MySpotify.Paused = False Then
                If btnPlay.Image IsNot My.Resources.pause1 Then btnPlay.Image = My.Resources.pause1
            End If
        End If
    End Sub
    Private Sub btnPlay_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.MouseDown
        If MySpotify.Paused = True Then btnPlay.Image = My.Resources.play1
        If MySpotify.Paused = False Then btnPlay.Image = My.Resources.pause1
    End Sub
    Private Sub btnPlay_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.MouseUp
        MySpotify.PlayPause()
        If MySpotify.Paused = True Then btnPlay.Image = My.Resources.pause2
        If MySpotify.Paused = False Then btnPlay.Image = My.Resources.play2
    End Sub
    Private Sub btnPlay_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlay.DoubleClick
        Call btnPlay_MouseUp(Me, System.EventArgs.Empty)
    End Sub
    Private Sub btnPlay_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.MouseEnter
        If MySpotify.Paused = True Then btnPlay.Image = My.Resources.play2
        If MySpotify.Paused = False Then btnPlay.Image = My.Resources.pause2
        MouseButtonDown = True
    End Sub
    Private Sub btnPlay_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.MouseLeave
        If MySpotify.Paused = True Then btnPlay.Image = My.Resources.play1
        If MySpotify.Paused = False Then btnPlay.Image = My.Resources.pause1
        MouseButtonDown = True
    End Sub
    Private Sub btnNext_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNext.MouseUp
        marqueeTimer.Enabled = False
        If lblTrack.Location <> trackLLoc Then
            lblTrack.Visible = False
            lblTrack.Location = trackLLoc
            lblTrack.Visible = True
            trackRight.Visible = False
            trackRight.Location = trackRLoc
            trackRight.Visible = True
        End If
        MySpotify.PlayNext()
    End Sub
    Private Sub btnPrev_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPrev.MouseUp
        marqueeTimer.Enabled = False
        lblTrack.Location = trackLLoc
        trackRight.Location = trackRLoc
        If lblTrack.Location <> trackLLoc Then
            lblTrack.Visible = False
            lblTrack.Location = trackLLoc
            lblTrack.Visible = True
            trackRight.Visible = False
            trackRight.Location = trackRLoc
            trackRight.Visible = True
        End If
        MySpotify.PlayPrev()
    End Sub
    Private Sub volDown_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles volDown.MouseDown
        MySpotify.VolumeDown()
    End Sub
    Private Sub volUp_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles volUp.MouseDown
        MySpotify.VolumeUp()
    End Sub

    Private Sub btnNext_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnNext.MouseDown
        btnNext.Image = My.Resources.next1
    End Sub
    Private Sub btnPrev_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnPrev.MouseDown
        btnPrev.Image = My.Resources.prev1
    End Sub

    Private Sub btnExit_MouseDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.MouseDown
        btnExit.Image = My.Resources._exit
    End Sub

    Private Sub btnOpen_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.MouseUp
        MySpotify.ShowSpotify()
        If IsIconic(w) Then
            btnOpen.Image = My.Resources.resize1
        ElseIf Not IsWindowVisible(w) Then
            btnOpen.Image = My.Resources.resize2
        Else
            btnOpen.Image = My.Resources.resize2
        End If
    End Sub

    Private Sub btnExit_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnExit.MouseUp
        Me.Close()
    End Sub

    Private Sub btnExit_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.MouseEnter
        btnExit.Image = My.Resources.exit2
    End Sub

    Private Sub btnExit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.MouseLeave
        btnExit.Image = My.Resources._exit
    End Sub

    Private Sub btnPrev_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.MouseEnter
        btnPrev.Image = My.Resources.prev2
    End Sub

    Private Sub btnPrev_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.MouseLeave
        btnPrev.Image = My.Resources.prev1
    End Sub

    Private Sub btnNext_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.MouseEnter
        btnNext.Image = My.Resources.next2
    End Sub

    Private Sub btnNext_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.MouseLeave
        btnNext.Image = My.Resources.next1
    End Sub

    Private Sub volDown_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volDown.MouseEnter
        volDown.Image = My.Resources.minus2
    End Sub

    Private Sub volDown_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volDown.MouseLeave
        volDown.Image = My.Resources.minus
    End Sub

    Private Sub volUp_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volUp.MouseEnter
        volUp.Image = My.Resources.plus2
    End Sub

    Private Sub volUp_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volUp.MouseLeave
        volUp.Image = My.Resources.plus
    End Sub

    Private Sub lblTrack_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTrack.MouseEnter
        'can we only scroll on hover?
        marqueeTimer.Enabled = True
    End Sub

    Private Sub marqueeTimer_Tick(sender As Object, e As EventArgs) Handles marqueeTimer.Tick
        If lblTrack.Width > 260 Then 'if text width is larger than mini-player, was 270 now 245 now 260
            lblTrack.Location = New Point(lblTrack.Location.X - 1, lblTrack.Location.Y) 'start scrolling
            If lblTrack.Right <= 325 Then 'when right edge of text moves far enough, start scrolling new text
                trackRight.Location = New Point(trackRight.Location.X - 1, trackRight.Location.Y)
                If trackRight.Left <= 93 Then
                    marqueeTimer.Enabled = False
                    lblTrack.Location = trackLLoc
                    trackRight.Location = trackRLoc
                End If
            End If
        Else 'if text fits, quit
            marqueeTimer.Enabled = False

        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
    End Sub
End Class
