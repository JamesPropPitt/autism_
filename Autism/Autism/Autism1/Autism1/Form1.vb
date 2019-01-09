Imports System.Threading

Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        response = True
        changePicture()
        stage1(response)
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Anger = 0
        Label1.Text = "Hello! My name is Taylor"
        Button1.Text = "Hello"
        Button2.Text = "Go away!"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        response = False
        changePicture()
        stage1(response)
        angerCheck()
    End Sub

    Private Sub stage1(response)
        Select Case response

            Case True
                Label1.Text = "How are you?"
                Button1.Text = "Fine thanks, you?"
                Button2.Text = "What's it to you?"
            Case False
                Label1.Text = "That wasn't very polite, how are you?"
                Button1.Text = "Fine thanks, you?"
                Button2.Text = "What's it to you?"
        End Select
    End Sub
    Private Sub angerCheck()
        If Anger >= 3 Then
            Finish()
        End If
        Anger += 1
    End Sub
    Private Sub Finish()
        Label1.Text = "Go away, I don't wanna talk to you anymore."
        Button1.Enabled = False
        Button2.Enabled = False
        System.Threading.Thread.Sleep(3000)
        Dim f As New Form
        f = gameOver
        f.Show()
                     
    End Sub
    Private Sub changePicture()
        Emotion = GenRandomInt(1, 20)

        Select Case Emotion
            Case 1
                PictureBox1.Image = Image.FromFile("images/face1.PNG")
            Case 2
                PictureBox1.Image = Image.FromFile("images/face2.PNG")
            Case 3
                PictureBox1.Image = Image.FromFile("images/face3.PNG")
            Case 3
                PictureBox1.Image = Image.FromFile("images/face4.PNG")
            Case 4
                PictureBox1.Image = Image.FromFile("images/face5.PNG")
            Case 5
                PictureBox1.Image = Image.FromFile("images/face6.PNG")
            Case 6
                PictureBox1.Image = Image.FromFile("images/face3.PNG")
            Case 7
                PictureBox1.Image = Image.FromFile("images/face7.PNG")
            Case 8
                PictureBox1.Image = Image.FromFile("images/face8.PNG")
            Case 9
                PictureBox1.Image = Image.FromFile("images/face9.PNG")
            Case 10
                PictureBox1.Image = Image.FromFile("images/face10.PNG")
            Case 11
                PictureBox1.Image = Image.FromFile("images/face11.PNG")
            Case 12
                PictureBox1.Image = Image.FromFile("images/face12.PNG")
            Case 13
                PictureBox1.Image = Image.FromFile("images/face13.PNG")
            Case 14
                PictureBox1.Image = Image.FromFile("images/face14.PNG")
            Case 15
                PictureBox1.Image = Image.FromFile("images/face15.PNG")
            Case 16
                PictureBox1.Image = Image.FromFile("images/face16.PNG")
            Case 17
                PictureBox1.Image = Image.FromFile("images/face17.PNG")
            Case 18
                PictureBox1.Image = Image.FromFile("images/face18.PNG")
            Case 19
                PictureBox1.Image = Image.FromFile("images/face19.PNG")
            Case 20
                PictureBox1.Image = Image.FromFile("images/face20.PNG")





        End Select
    End Sub
    Private Function GenRandomInt(inMin As Int32, inMax As Int32) As Int32
        Static staticRandomGenerator As New System.Random
        If inMin > inMax Then Dim t = inMin : inMin = inMax : inMax = t
        If inMax < Int32.MaxValue Then Return staticRandomGenerator.Next(inMin, inMax + 1)
        ' now max = Int32.MaxValue, so we need to work around Microsoft's quirk of an exclusive max parameter.
        If inMin > Int32.MinValue Then Return staticRandomGenerator.Next(inMin - 1, inMax) + 1 ' okay, this was the easy one.
        ' now min and max give full range of integer, but Random.Next() does not give us an option for the full range of integer.
        ' so we need to use Random.NextBytes() to give us 4 random bytes, then convert that to our random int.
        Dim bytes(3) As Byte ' 4 bytes, 0 to 3
        staticRandomGenerator.NextBytes(bytes) ' 4 random bytes
        Return BitConverter.ToInt32(bytes, 0) ' return bytes converted to a random Int32
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
