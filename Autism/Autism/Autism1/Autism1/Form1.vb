Imports System.Threading



Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Anger = 0

        'Set the anger value to 0

        Sadness = 0

        'Set the sadness to 0

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

        'The 3 options displayed to the user



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If EmotionNumber = 3 Then

            sadCheck()

        End If



        If EmotionNumber = 4 Then

            angerCheck()

        End If

        response = 1

        Label5.Text = response

        'Button 1 has been pressed

        changePicture()

        'Call the change picture function to change the image

        buttonPress = True

        stage(StageNumber, response, EmotionNumber)

        If StageNumber < 9 Then

            StageNumber += 1

        Else

            Finish()

        End If

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If EmotionNumber = 3 Then

            sadCheck()

        End If



        If EmotionNumber = 4 Then

            angerCheck()

        End If

        response = 2

        Label5.Text = response

        'Button 2 has been pressed

        changePicture()

        'Call the change picture function to change the image

        buttonPress = True

        stage(StageNumber, response, EmotionNumber)

        If StageNumber < 8 Then

            StageNumber += 1

        Else

            Finish()

        End If

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If EmotionNumber = 3 Then

            sadCheck()

        End If



        If EmotionNumber = 4 Then

            angerCheck()

        End If

        response = 3

        'Button 3 has been pressed

        Label5.Text = response

        changePicture()

        'Call the change picture function to change the image

        buttonPress = True

        stage(StageNumber, response, EmotionNumber)

        If StageNumber < 8 Then

            StageNumber += 1

        Else

            Finish()

        End If

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

                                Button3.Text = "Nope"

                                'Options for the player

                                buttonPress = False

                            Case 2

                                'If button 2 was pressed and Taylor is fine

                                Label1.Text = "What's up?"

                                'Taylor's speech

                                Button1.Text = "Nothing, I'm fine, you?"

                                Button2.Text = "Nothing at all, you?"

                                Button3.Text = "Nothing"

                                'Options for the player

                                buttonPress = False

                            Case 3

                                'If button 2 was pressed and Taylor is sad

                                Label1.Text = "You okay?"

                                'Taylor's speech

                                Button1.Text = "Yeah, you alright?"

                                Button2.Text = "Pretty much, yourself?"

                                Button3.Text = "Yeah"

                                'Options for the player

                                buttonPress = False

                            Case 4

                                'If button 2 was pressed and Taylor is angry

                                Label1.Text = "Whatever. You good?"

                                'Taylor's speech

                                Button1.Text = "Yeah, you alright?"

                                Button2.Text = "What's up?"

                                Button3.Text = "Yeah"

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

                                Button1.Text = "That's great news! What ya doing?"

                                Button2.Text = "Anything good happen?"

                                Button3.Text = "Nice, doing much?"

                                'Options for the player

                                buttonPress = False

                            Case 2

                                'If button 1 or 2 was pressed and Taylor is neutral

                                Label1.Text = "That's good! I'm feeling well, thank you."

                                'Taylor's speech

                                Button1.Text = "Good, What are you up to?"

                                Button2.Text = "How's your day been going?"

                                Button3.Text = "What's new?"

                                'Options for the player

                                buttonPress = False

                            Case 3

                                'If button 1 or 2 was pressed and Taylor is sad

                                Label1.Text = "I'm feeling awful!"

                                'Taylor's speech

                                Button1.Text = "That sucks, doing anything?"

                                Button2.Text = "Why?"

                                Button3.Text = "Guess something terrible happened"

                                'Options for the player

                                buttonPress = False

                            Case 4

                                'If button 1 or 2 was pressed and Taylor is angry

                                Label1.Text = "Everything is out to get me today"

                                'Taylor's speech

                                Button1.Text = "Why do you think that?"

                                Button2.Text = "What's happened?"

                                Button3.Text = "Something happen today?"

                                'Options for the player

                                buttonPress = False

                        End Select



                    Case 3

                        Select Case EmotionNumber

                            Case 1

                                'If button 3 was pressed and Taylor is feeling happy

                                Label1.Text = "Right, well I'm fine, thanks..."

                                'Taylor's speech

                                Button1.Text = "Cool, up to much?"

                                Button2.Text = "Why?"

                                Button3.Text = "Doing much today?"

                                angerCheck()

                                'Options for the player

                                buttonPress = False

                            Case 2

                                'If button 3 was pressed and Taylor is feeling neutral

                                Label1.Text = "I'm okay too, thanks for asking."

                                'Taylor's speech

                                Button1.Text = "Why are you acting this way?"

                                Button2.Text = "Sorry, anything interesting happen recently?"

                                Button3.Text = "Alright, What have you been up to?"

                                angerCheck()

                                'Options for the player

                                buttonPress = False

                            Case 3

                                'If button 3 was pressed and Taylor is feeling sad

                                Label1.Text = "Yeah, I'm fine too"

                                'Taylor's speech

                                Button1.Text = "That's good, any reason why?"

                                Button2.Text = "Oh, I'm sorry, everything okay?"

                                Button3.Text = "Something happen?"

                                angerCheck()

                                'Options for the player

                                buttonPress = False

                            Case 4

                                'If button 3 was pressed and Taylor is feeling angry

                                Label1.Text = "Cool, I'm fine too, not that you care"

                                'Taylor's speech

                                Button1.Text = "Something up with you?"

                                Button2.Text = "Something put you in this mood?"

                                Button3.Text = "Why are you like this?"

                                angerCheck()



                                Finish()

                        End Select

                End Select

            Case 3  'Stage 3

                Select Case response

                    Case 1, 2, 3

                        'If button 1 was pressed

                        Label1.Text = "Well I just finished creating an amazing game that I had been working on for a few months"

                        'Taylor's speech

                        Button1.Text = "Oh yeah?"

                        Button2.Text = "So?"

                        Button3.Text = "Why does that make you feel that way?"

                        'Options for the player

                        buttonPress = False



                End Select

            Case 4 'Stage 4

                Select Case response

                    Case 1, 3

                        'If button 1  or 3 was pressed

                        Label1.Text = "It means I have nothing to do now"

                        'Taylor's speech

                        Button1.Text = "Why is that bad?"

                        Button2.Text = "Why is that good?"

                        Button3.Text = "So what are you gonna do now?"

                        'Options for the player

                        buttonPress = False



                    Case 2

                        'If button 2 was pressed

                        Label1.Text = "It means I have to look forward and think of something else to do"

                        'Taylor's speech

                        Button1.Text = "Like?"

                        Button2.Text = "What?"

                        Button3.Text = "So?"

                        'Options for the player

                        buttonPress = False

                End Select



            Case 5 'Stage 5

                Select Case response

                    Case 1, 3

                        Label1.Text = "Well I guess I'm left to my own devices which can be kinda scary"

                        'Taylor's speech

                        Button1.Text = "Cool"

                        Button2.Text = "Remember, tomorrow is only found in the calendar of fools"

                        Button3.Text = "YOLO"

                        'Options for the player

                        buttonPress = False

                    Case 2

                        Label1.Text = "The future is exciting, don't you think?"

                        'Taylor's speech

                        Button1.Text = "Tomorrow is only found in the calendar of fools"

                        Button2.Text = "Yes, life is full of opportunities every day"

                        Button3.Text = "That's what I like to think"

                        'Options for the player

                        buttonPress = False

                End Select



            Case 6 'Stage 6'

                Select Case response

                    Case 1

                        Label1.Text = "Why have you got to put such a downer on everything?"

                        'Taylor's speech

                        Button1.Text = "Excuse me?"

                        Button2.Text = "I'm just not interested in talking to you"

                        Button3.Text = "I'm tired"

                        'Options for the player

                        buttonPress = False



                    Case 2, 3

                        Label1.Text = "Wow! You're so inspirational, I'm going to put that on my wall from now on"

                        'Taylor's speech

                        Button1.Text = "Really?"

                        Button2.Text = "I got it off the back of a milk carton"

                        Button3.Text = "Sweet"

                        'Options for hte player

                        buttonPress = False

                End Select

            Case 7 'Stage 7

                Select Case response

                    Case 1

                        Label1.Text = "You heard, you're astonishing"

                        'Taylor's speech

                        Button1.Text = "Thanks"

                        Button2.Text = "I appreciate it"

                        Button3.Text = "Happy I could help, to be honest"

                        'Options for the player

                        buttonPress = False



                    Case 2

                        Label1.Text = "How ironic, quite a bold statement coming from something so small"

                        'Taylor's speech

                        Button1.Text = "What's that supposed to mean?"

                        Button2.Text = "I know right"

                        Button3.Text = "I'm confused"

                        'Options for the player

                        buttonPress = False



                    Case 3

                        Label1.Text = "Well, I've gotta get going now but it was nice speaking to you"

                        'Taylor's speech

                        Button1.Text = "Thanks, bye!"

                        Button2.Text = "Cheers, bye!"

                        Button3.Text = "Bye!"

                        'Options for hthe player

                        buttonPress = False

                        Dim f As New Form

                        'create new window

                        f = gameOver

                        f.Show()





                End Select

            Case 8 'Stage 8

                Select Case response

                    Case 1

                        Label1.Text = "Look, this talk was interesting but I've gotta go"

                        'Taylor's speech

                        Button1.Text = "Bye then"

                        Button2.Text = "No worries, see ya!"

                        Button3.Text = "Goodbye"

                        buttonPress = False

                        Dim f As New Form

                        'create new window

                        f = gameOver

                        f.Show()



                    Case 2

                        Label1.Text = "Well, I've gotta dash but I'll talk to you later"

                        'Taylor's speech

                        Button1.Text = "Bye then"

                        Button2.Text = "No worries, see ya!"

                        Button3.Text = "Goodbye"

                        buttonPress = False

                        Dim f As New Form

                        'create new window

                        f = gameOver

                        f.Show()



                    Case 3

                        Label1.Text = "Hey, it doesn't matter, bye"

                        'Taylor's speech

                        Button1.Text = "Bye then"

                        Button2.Text = "What?"

                        Button3.Text = "Goodbye"

                        buttonPress = False

                        Dim f As New Form

                        'create new window

                        f = gameOver

                        f.Show()

                End Select



        End Select

    End Sub



    Private Sub sadCheck()

        'This checks to see if Taylor is upset and if she continues to be upset, this turns into anger

        If Sadness >= 2 Then

            angerCheck()

            'If the player has scored 2 sad strikes, then anger increments

            Sadness = 0

            'Also reset Sadness to 0

        Else

            Sadness += 1

            'If the player has not scored 2 sad strikes then increment sadness

        End If

        Label8.Text = Sadness

        Label8.Refresh()

    End Sub

    Private Sub angerCheck()

        'This checks to see if the game is over

        If Anger >= 4 Then

            Finish()

            'If the player has scored 3 anger strikes then the game ends.

        Else

            Anger += 1

            'If it Then isn't then the player moves 1 step closer to losing.

        End If

        Label9.Text = Anger

        Label9.Refresh()

    End Sub

    Private Sub Finish()

        Label1.Text = "Go away, I don't wanna talk to you anymore."

        'Taylor's speech

        Button1.Enabled = False

        Button2.Enabled = False

        Button3.Enabled = False

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

    Public Function GenRandomInt(inMin As Int32, inMax As Int32) As Int32

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

End Class

