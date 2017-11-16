Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Math
Public Class DoggoForm
    Dim MoveRight As Boolean = False
    Dim MoveLeft As Boolean = False
    Dim StayRight As Boolean = True
    Dim StayLeft As Boolean = False
    Dim JumpLeft As Boolean = False
    Dim JumpRight As Boolean = False
    Dim Counter As Integer = 0
    Dim sinval As Double

    Private Sub DoggoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0 = Me.Width, My.Computer.Screen.WorkingArea.Bottom - Me.Height + 19)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim x As Integer = Me.Location.X
        Dim y As Integer = Me.Location.Y
        '
        If MoveRight = True Then
            y = My.Computer.Screen.WorkingArea.Bottom - Me.Height + 19
            If Me.Location.X <= My.Computer.Screen.WorkingArea.Width Then
                x = x + 2
                Me.Location = New Point(x, y)
            Else
                Me.Location = New Point(0 - Me.Width, y)
            End If
        ElseIf MoveLeft = True Then
            y = My.Computer.Screen.WorkingArea.Bottom - Me.Height + 19
            If Me.Location.X >= 1 - Me.Width Then
                x = x - 2
                Me.Location = New Point(x, y)
            Else
                Me.Location = New Point(My.Computer.Screen.WorkingArea.Width - 1, y)
            End If
        End If
        '
        If StayLeft = True Or StayRight = True Then
            y = My.Computer.Screen.WorkingArea.Bottom - Me.Height + 19
            If Me.Location.X >= 1 - Me.Width Then
                x = x
                Me.Location = New Point(x, y)
            Else
                Me.Location = New Point(My.Computer.Screen.WorkingArea.Width - 1, y)
            End If
        End If
        '
        If JumpLeft = True Then
            x = x - 3
            Counter = Counter + 1
            sinval = Sin((Counter * PI) / 180)
            y = (My.Computer.Screen.WorkingArea.Bottom - Me.Height + 15) - Int(sinval * 150)
            Me.Location = New Point(x, y)
            If Counter > 180 Then
                JumpLeft = False
                MoveLeft = True
                Dog.Image = My.Resources.Dog_Walk
            End If
        End If
        If JumpRight = True Then
            x = x + 3
            Counter = Counter + 1
            sinval = Sin((Counter * PI) / 180)
            y = (My.Computer.Screen.WorkingArea.Bottom - Me.Height + 15) - Int(sinval * 150)
            Me.Location = New Point(x, y)
            If Counter > 180 Then
                JumpRight = False
                MoveRight = True
                Dog.Image = My.Resources.Dog_Walk_2
            End If
        End If

    End Sub
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles Dog.MouseHover
        'Form2.Show()
        'Will delete below things for other peeps
        If MoveLeft = True Or StayLeft = True Then
            JumpLeft = True
            Dog.Image = My.Resources.Dog_Jump
            MoveRight = False
            MoveLeft = False
            StayRight = False
            StayLeft = False
            JumpRight = False
            Counter = 0
        ElseIf MoveRight = True Or StayRight = True Then
            JumpRight = True
            Dog.Image = My.Resources.Dog_Jump_2
            MoveRight = False
            MoveLeft = False
            StayLeft = False
            StayRight = False
            JumpLeft = False
            Counter = 0
        End If
    End Sub
    Private Sub Yes(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Left Then
            If JumpLeft = False And JumpRight = False Then
                Dog.Image = My.Resources.Dog_Walk
                MoveRight = False
                MoveLeft = True
                StayRight = False
                StayLeft = False
                JumpRight = False
                JumpLeft = False
            End If
        End If

        If e.KeyCode = Keys.Right Then
            If JumpLeft = False And JumpRight = False Then
                Dog.Image = My.Resources.Dog_Walk_2
                MoveLeft = False
                MoveRight = True
                StayRight = False
                StayLeft = False
                JumpRight = False
                JumpLeft = False
            End If
        End If

        If e.KeyCode = Keys.Down Then
            If JumpLeft Or JumpRight = False Then
                If MoveLeft = True Then
                    StayLeft = True
                    Dog.Image = My.Resources.Dog_Idle
                    MoveRight = False
                    MoveLeft = False
                    StayRight = False
                    JumpRight = False
                    JumpLeft = False
                ElseIf MoveRight = True Then
                    StayRight = True
                    Dog.Image = My.Resources.Dog_Idle_2
                    MoveRight = False
                    MoveLeft = False
                    StayLeft = False
                    JumpRight = False
                    JumpLeft = False
                End If
            End If
        End If

        If e.KeyCode = Keys.Up Then
            If MoveLeft = True Or StayLeft = True Then
                JumpLeft = True
                Dog.Image = My.Resources.Dog_Jump
                MoveRight = False
                MoveLeft = False
                StayRight = False
                StayLeft = False
                JumpRight = False
                Counter = 0
            ElseIf MoveRight = True Or StayRight = True Then
                JumpRight = True
                Dog.Image = My.Resources.Dog_Jump_2
                MoveRight = False
                MoveLeft = False
                StayLeft = False
                StayRight = False
                JumpLeft = False
                Counter = 0
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            End
        End If
    End Sub
End Class
