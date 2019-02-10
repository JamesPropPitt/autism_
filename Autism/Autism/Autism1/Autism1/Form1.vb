Imports System.Threading

Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        response = True
        'Button 1 has been pressed
        changePicture()
        'Call the change picture function to change the image
        stage((response)
        buttonPress += 1
        'This was an interesting and probably inefficient workaround for a bug I encountered where the game would skip through itself
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        response = False
        'Button 2 has been pressed
        changePicture()
        'Call the change picture function to change the image
        If buttonPress = 0 Then
            stage1(response)
            buttonPress = 1
        End If
        'This was an interesting and probably inefficient workaround for a bug I encountered where the game would skip through itself
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Anger = 0
        'Set the anger value to 0
        EmotionNumber = GenRandomInt(1, 4)
        'Get a value between 1 and 4
        Select Case Emotions
            Case 1
                Emotions = "Neutral"
                'Set the emotion to Neutral
            Case 2
                Emotions = "Happy"
                'Set the emotion to Happy
            Case 3
                Emotions = "Sad"
                'Set the emotion to Sad
            Case 4
                Emotions = "Angry"
                'Set the emotion to Angry
        End Select

        If EmotionNumber = 1 Then
            PictureBox1.Image = Image.FromFile("..\..\images\face19.PNG")
            'Happy start
            Label1.Text = "Hello! My name is Taylor"
            'Taylor's speech
        End If

        If EmotionNumber = 2 Then
            PictureBox1.Image = Image.FromFile("..\..\images\face1.PNG")
            'Neutral start
            Label1.Text = "Hey, my name is Taylor"
            'Taylor's speech
        End If

        If EmotionNumber = 3 Then
            PictureBox1.Image = Image.FromFile("..\..\images\face5.PNG")
            'Sad start
            Label1.Text = "Hi, I'm Taylor"
            'Taylor's speech
        End If

        If EmotionNumber = 4 Then
            PictureBox1.Image = Image.FromFile("..\..\images\face11.PNG")
            'Angry start
            Label1.Text = "What's up, I'm Taylor"
            'Taylor's speech
        End If

        Button1.Text = "Hello"
        Button2.Text = "Go away!"
        'The 2 options displayed to the user

    End Sub


    Private Sub stage(1)(response)
        Select Case response
            Case True
                'If button 1 was pressed
                Label1.Text = "How are you?"
                'Taylor's speech
                Button1.Text = "Fine thanks, you?"
                Button2.Text = "What's it to you?"
                'Options for the player
            Case False
                'If button 2 was pressed
                Label1.Text = "That wasn't very polite, how are you?"
                'Taylor's speech
                Button1.Text = "Fine thanks, you?"
                Button2.Text = "What's it to you?"
                'Options for the player

        End Select
    End Sub

    Private Sub stage2(response)
        Select Case response
            Case True
                'If button 1 was pressed
                Label1.Text = "That's good! I'm feeling well, thank you."
                'Taylor's speech
                Button1.Text = "Good, you seem like a nice person."
                Button2.Text = "What have you been up to today?"
                'Options for the player

            Case False
                'If button 2 was pressed
                Label1.Text = "What's the matter with you!?"
                'Taylor's speech
                Button1.Text = "I'm sorry, I'm not feeling great."
                Button2.Text = "Nothing."
                'Options for the player
        End Select
    End Sub
    Private Sub sadCheck()
        'This checks to see if Taylor is upset and if she continues to be upset, this turns into anger
        If Sadness >= 2 Then
            angerCheck()
            'If the player has scored 2 sad strikes, then anger increments
            Sadness = 0
            'Also reset Sadness to 0
        End If
        Sadness += 1
        'If the player has not scored 2 sad strikes then increment sadness
    End Sub
    Private Sub angerCheck()
        'This checks to see if the game is over, if it isn't then the player moves 1 step closer to losing.
        If Anger >= 3 Then
            Finish()
            'If the player has scored 3 anger strikes then the game ends.
        End If
        Anger += 1
        'If the player has not scored 3 anger strikes, then add an anger strike.
    End Sub
    Private Sub Finish()
        Label1.Text = "Go away, I don't wanna talk to you anymore."
        'Taylor's speech
        Button1.Enabled = False
        Button2.Enabled = False
        'Disable all the options for the player.
        Dim f As New Form
        'Create new window
        f = gameOver
        'Window displays gameover form
        f.Show()
        'Show the window

    End Sub
    Private Sub changePicture()
        Emotion = GenRandomInt(1, 18)
        'Emotional roulette wheel!
        'Pick a number between 1 and 18, then thats the emotion you get!
        Select Case Emotion

            'Happy emotions
            Case 1
                PictureBox1.Image = Image.FromFile("..\..\images\face1.PNG")
                'Content
                EmotionNumber = 2
            Case 8
                PictureBox1.Image = Image.FromFile("..\..\images\face9.PNG")
                'Laughing
                EmotionNumber = 2
            Case 15
                PictureBox1.Image = Image.FromFile("..\..\images\face16.PNG")
                'Enamored
                EmotionNumber = 2

            'Sad emotions
            Case 4
                PictureBox1.Image = Image.FromFile("..\..\images\face5.PNG")
                'Bored
                EmotionNumber = 3
                sadCheck()
                'Increment Sadness
            Case 5
                PictureBox1.Image = Image.FromFile("..\..\images\face6.PNG")
                'Suspicious
                EmotionNumber = 3
                sadCheck()
                'Increment Sadness
            Case 7
                PictureBox1.Image = Image.FromFile("..\..\images\face8.PNG")
                'Crying
                EmotionNumber = 3
                sadCheck()
                'Increment Sadness
            Case 11
                PictureBox1.Image = Image.FromFile("..\..\images\face12.PNG")
                'Embarrassed
                EmotionNumber = 3
                sadCheck()
                'Increment Sadness

            'Angry emotions
            Case 9
                PictureBox1.Image = Image.FromFile("..\..\images\face10.PNG")
                'Irritated
                EmotionNumber = 4
                angerCheck()
                'Increment Anger
            Case 10
                PictureBox1.Image = Image.FromFile("..\..\images\face11.PNG")
                'Sly
                EmotionNumber = 4
                angerCheck()
                'Increment Anger
            Case 14
                PictureBox1.Image = Image.FromFile("..\..\images\face15.PNG")
                'Peturbed
                EmotionNumber = 4
                angerCheck()
                'Increment Anger
            Case 6
                PictureBox1.Image = Image.FromFile("..\..\images\face7.PNG")
                'Provocative
                EmotionNumber = 4
                angerCheck()
                'Increment Anger

            'Neutral emotions
            Case 16
                PictureBox1.Image = Image.FromFile("..\..\images\face17.PNG")
                'Tired
                EmotionNumber = 1
            Case 17
                PictureBox1.Image = Image.FromFile("..\..\images\face18.PNG")
                'Lost
                EmotionNumber = 1
            Case 18
                PictureBox1.Image = Image.FromFile("..\..\images\face19.PNG")
                'Alright
                EmotionNumber = 1
            Case 3
                PictureBox1.Image = Image.FromFile("..\..\images\face4.PNG")
                'Intrigued
                EmotionNumber = 1
            Case 2
                PictureBox1.Image = Image.FromFile("..\..\images\face2.PNG")
                'Surprised
                EmotionNumber = 1
            Case 13
                PictureBox1.Image = Image.FromFile("..\..\images\face14.PNG")
                'Fine
                EmotionNumber = 1
            Case 12
                PictureBox1.Image = Image.FromFile("..\..\images\face13.PNG")
                'Thoughtful
                EmotionNumber = 1

                'Three happy emotions
                'Seven neutral emotions
                'Four angry emotions
                'Four sad emotions
                '18 emotions total
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
