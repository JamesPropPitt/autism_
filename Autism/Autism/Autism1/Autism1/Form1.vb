Imports System.Threading

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Anger = 0
        'Set the anger value to 0
        StageNumber = 1
        'set the initial stage
        Label4.Text = StageNumber

        'set the buttonpress to false
        EmotionNumber = GenRandomInt(1, 4)
        'Get a value between 1 and 4
        Select Case EmotionNumber
            Case 1
                Emotions = "Neutral"
                'Set the emotion to Neutral
                PictureBox1.Image = Image.FromFile("..\..\images\face19.PNG")
                PictureBox1.Refresh()
                'Happy start
                Label1.Text = "Hello! My name is Taylor"
            'Taylor's speech
            Case 2
                Emotions = "Happy"
                'Set the emotion to Happy
                PictureBox1.Image = Image.FromFile("..\..\images\face1.PNG")
                PictureBox1.Refresh()
                'Neutral start
                Label1.Text = "Hey, my name is Taylor"
            'Taylor's speech
            Case 3
                Emotions = "Sad"
                'Set the emotion to Sad
                PictureBox1.Image = Image.FromFile("..\..\images\face5.PNG")
                PictureBox1.Refresh()
                'Sad start
                Label1.Text = "Hi, I'm Taylor"
            'Taylor's speech
            Case 4
                Emotions = "Angry"
                'Set the emotion to Angry
                PictureBox1.Image = Image.FromFile("..\..\images\face11.PNG")
                PictureBox1.Refresh()
                'Angry start
                Label1.Text = "What's up, I'm Taylor"
                'Taylor's speech
        End Select
        Button1.Text = "Hello"
        Button2.Text = "Hi"
        Button3.Text = "Hey"
        'The 2 options displayed to the user
        If response <> 0 Then
            stage(StageNumber, response, EmotionNumber)
        End If
        'These lines aren't needed but when you remove them, the code breaks. Go figure.

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        response = 1
        Label5.Text = response
        'Button 1 has been pressed
        changePicture()
        'Call the change picture function to change the image
        buttonPress = True
        stage(StageNumber, response, EmotionNumber)
        StageNumber += 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        response = 2
        Label5.Text = response
        'Button 2 has been pressed
        changePicture()
        'Call the change picture function to change the image
        buttonPress = True
        stage(StageNumber, response, EmotionNumber)
        StageNumber += 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        response = 3
        'Button 3 has been pressed
        Label5.Text = response
        changePicture()
        'Call the change picture function to change the image
        buttonPress = True
        stage(StageNumber, response, EmotionNumber)
        StageNumber += 1
    End Sub

    Private Sub stage(stageNo As Integer, response As Boolean, EmotionNumber As Integer)
        Label4.Text = StageNumber
        Select Case stageNo 'filter the stages
            Case 1  'Stage 1
                Select Case response 'filter true or false
                    Case 1, 3
                        Select Case EmotionNumber 'filter type of emotion
                            Case 1
                                'If button 1 or 3 was pressed and Taylor is happy
                                Label1.Text = "A lovely day today isn't!? How are you feeling?"
                                'Taylor's speech
                                Button1.Text = "Fine thanks, you?"
                                Button2.Text = "I'm feeling well, how are you?"
                                Button3.Text = "Good, you?"
                                'Options for the player

                            Case 2
                                'If button 1 or 3 was pressed and Taylor is neutral
                                Label1.Text = "How are you?"
                                'Taylor's speech
                                Button1.Text = "Fine thanks, you?"
                                Button2.Text = "Fine, you?"
                                Button3.Text = "Good, you?"
                                'Options for the player

                            Case 3
                                'If button 1 or 3 was pressed and Taylor is sad
                                Label1.Text = "*sob* How are you?"
                                'Taylor's speech
                                Button1.Text = "Fine thanks, you?"
                                Button2.Text = "Okay, I guess, you?"
                                Button3.Text = "Good, you?"
                                'Options for the player
                                buttonPress = False
                            Case 4
                                'If button 1 or 3 was pressed and Taylor is angry
                                Label1.Text = "What a terrible day! Something up with you?"
                                'Taylor's speech
                                Button1.Text = "No, I'm fine thanks, you?"
                                Button2.Text = "What's it to you?"
                                Button3.Text = "Good, you?"
                                'Options for the player
                                buttonPress = False
                        End Select

                    Case 2
                        Select Case EmotionNumber
                            Case 1
                                'If button 2 was pressed and Taylor is happy
                                Label1.Text = "Is something wrong? I'm here for you"
                                'Taylor's speech
                                Button1.Text = "No I'm fine thanks, you?"
                                Button2.Text = "Not really, you?"
                                Button3.Text = "Something wrong with you? How are you feeling?"
                                'Options for the player
                                buttonPress = False
                            Case 2
                                'If button 2 was pressed and Taylor is fine
                                Label1.Text = "What's up?"
                                'Taylor's speech
                                Button1.Text = "Nothing, I'm fine, you?"
                                Button2.Text = "Nothing at all, you?"
                                Button3.Text = "Not much, you?"
                                'Options for the player
                                buttonPress = False
                            Case 3
                                'If button 2 was pressed and Taylor is sad
                                Label1.Text = "You okay?"
                                'Taylor's speech
                                Button1.Text = "Yeah, you alright?"
                                Button2.Text = "Pretty much, yourself?"
                                Button3.Text = "I guess, you?"
                                'Options for the player
                                buttonPress = False
                            Case 4
                                'If button 2 was pressed and Taylor is angry
                                Label1.Text = "Whatever. You good?"
                                'Taylor's speech
                                Button1.Text = "Yeah, you alright?"
                                Button2.Text = "What's up?"
                                Button3.Text = "Is something wrong with you? How are you feeling?"
                                'Options for the player
                                buttonPress = False
                        End Select
                End Select
            Case 2  'Stage 2
                Select Case response
                    Case 1, 2
                        Select Case EmotionNumber
                            Case 1
                                'If button 1 or 2 was pressed and Taylor is happy
                                Label1.Text = "I'm fantastic thanks! Never felt better"
                                'Taylor's speech
                                Button1.Text = "That's great news! You seem like a lovely person!"
                                Button2.Text = "What's got you in this mood?"
                                'Options for the player
                                buttonPress = False
                            Case 2
                                'If button 1 or 2 was pressed and Taylor is neutral
                                Label1.Text = "That's good! I'm feeling well, thank you."
                                'Taylor's speech
                                Button1.Text = "Good, you seem like a nice person."
                                Button2.Text = "What have you been up to today?"
                                'Options for the player
                                buttonPress = False
                            Case 3
                                'If button 1 or 2 was pressed and Taylor is sad
                                Label1.Text = "I'm feeling awful!"
                                'Taylor's speech
                                Button1.Text = "Oh no, but you seem like such a nice person"
                                Button2.Text = "What's happened?"
                                'Options for the player
                                buttonPress = False
                            Case 4
                                'If button 1 or 2 was pressed and Taylor is angry
                                Label1.Text = "Everything is out to get me today"
                                'Taylor's speech
                                Button1.Text = "Oh? How can the world be so cruel to someone so lovely"
                                Button2.Text = "What's happened?"
                                'Options for the player
                                buttonPress = False
                        End Select

                    Case 3
                        Select Case EmotionNumber
                            Case 1
                                'If button 3 was pressed and Taylor is feeling happy
                                Label1.Text = "Not even you can ruin this lovely day"
                                'Taylor's speech
                                Button1.Text = "You're right, I'm just not feeling great"
                                Button2.Text = "Hmph"
                                'Options for the player
                                buttonPress = False
                            Case 2
                                'If button 3 was pressed and Taylor is feeling neutral
                                Label1.Text = "What's the matter with you!?"
                                'Taylor's speech
                                Button1.Text = "I'm sorry, I'm not feeling great"
                                Button2.Text = "Nothing"
                                'Options for the player
                                buttonPress = False
                            Case 3
                                'If button 3 was pressed and Taylor is feeling sad
                                Label1.Text = "Why do you pick on me?"
                                'Taylor's speech
                                Button1.Text = "I'm sorry, I'm not feeling great"
                                Button2.Text = "I'm not, stop feeling sorry for yourself"
                                'Options for the player
                                buttonPress = False
                            Case 4
                                'If button 3 was pressed and Taylor is feeling angry
                                Label1.Text = "Screw this"
                                'Taylor's speech
                                Finish()
                        End Select
                End Select
            Case 3  'Stage 3
                Select Case response
                    Case 1
                        'If button 1 was pressed
                        Label1.Text = "Right, haha very funny"
                        'Taylor's speech
                        Button1.Text = "Sorry, I don't feel great"
                        Button2.Text = "I don't care what you think"
                        'Options for the player
                        buttonPress = False
                    Case 2
                        'If button 2 was pressed
                        Label1.Text = "Screw this"
                        'Taylor's speech
                        Finish()
                End Select
            Case 4
                Select Case response
                    Case 1
                'If button 1 was pressed
                    Case 2

                End Select
            Case 5
            Case 6
            Case 7

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
                BackColor = Color.YellowGreen

            Case 8
                PictureBox1.Image = Image.FromFile("..\..\images\face9.PNG")
                'Laughing
                EmotionNumber = 2
                BackColor = Color.YellowGreen
            Case 15
                PictureBox1.Image = Image.FromFile("..\..\images\face16.PNG")
                'Enamored
                EmotionNumber = 2
                BackColor = Color.YellowGreen

            'Sad emotions
            Case 4
                PictureBox1.Image = Image.FromFile("..\..\images\face5.PNG")
                'Bored
                EmotionNumber = 3
                sadCheck()
                'Increment Sadness
                BackColor = Color.DodgerBlue

            Case 5
                PictureBox1.Image = Image.FromFile("..\..\images\face6.PNG")
                'Suspicious
                EmotionNumber = 3
                sadCheck()
                'Increment Sadness
                BackColor = Color.DodgerBlue
            Case 7
                PictureBox1.Image = Image.FromFile("..\..\images\face8.PNG")
                'Crying
                EmotionNumber = 3
                sadCheck()
                'Increment Sadness
                BackColor = Color.DodgerBlue
            Case 11
                PictureBox1.Image = Image.FromFile("..\..\images\face12.PNG")
                'Embarrassed
                EmotionNumber = 3
                sadCheck()
                'Increment Sadness
                BackColor = Color.DodgerBlue

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
                BackColor = Color.Red

            Case 14
                PictureBox1.Image = Image.FromFile("..\..\images\face15.PNG")
                'Peturbed
                EmotionNumber = 4
                angerCheck()
                'Increment Anger
                BackColor = Color.Red
            Case 6
                PictureBox1.Image = Image.FromFile("..\..\images\face7.PNG")
                'Provocative
                EmotionNumber = 4
                angerCheck()
                'Increment Anger
                BackColor = Color.Red

            'Neutral emotions
            Case 16
                PictureBox1.Image = Image.FromFile("..\..\images\face17.PNG")
                'Tired
                EmotionNumber = 1
                BackColor = Color.LightSlateGray


            Case 17
                PictureBox1.Image = Image.FromFile("..\..\images\face18.PNG")
                'Lost
                EmotionNumber = 1
                BackColor = Color.LightSlateGray
            Case 18
                PictureBox1.Image = Image.FromFile("..\..\images\face19.PNG")
                'Alright
                EmotionNumber = 1
                BackColor = Color.LightSlateGray
            Case 3
                PictureBox1.Image = Image.FromFile("..\..\images\face4.PNG")
                'Intrigued
                EmotionNumber = 1
                BackColor = Color.LightSlateGray
            Case 2
                PictureBox1.Image = Image.FromFile("..\..\images\face2.PNG")
                'Surprised
                EmotionNumber = 1
                BackColor = Color.LightSlateGray
            Case 13
                PictureBox1.Image = Image.FromFile("..\..\images\face14.PNG")
                'Fine
                EmotionNumber = 1
                BackColor = Color.LightSlateGray
            Case 12
                PictureBox1.Image = Image.FromFile("..\..\images\face13.PNG")
                'Thoughtful
                EmotionNumber = 1
                BackColor = Color.LightSlateGray

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