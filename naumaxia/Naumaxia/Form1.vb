Public Class form
    'Ο Πίνακας Game υλοποιεί όλη τη λογική του παιχνιδιού της Ναυμαχίας
    Dim Game(10, 10) As SByte, plia As String
    'Ο Πίνακας btnGame περιλαμβάνει τα αντικείμενα τύπου Button 
    'που "οπτικοποιούν" τον πίνακα Game του παιχνιδιού στη φόρμα
    Dim btnGame(10, 10) As Button
    Dim voles As Byte 'Ο αριθμός των βολών 
    Dim score, trials As Byte 'H 1η μεταβλητή κρατά το σκορ ενώ η 2η τις προσπάθειες
    Dim btn As Button
    Dim bi, bi1 As Boolean


    Private Sub generateButton(ByVal x As Byte, ByVal y As Byte)

        'Δημιουργούμε ένα αντικείμενο τύπου button στη θέση btnGame(x, y) του πίνακα btnGame
        btnGame(x, y) = New Button
        'Δίνουμε (αυθαίρετα) πλάτος και ύψος 50 pixels
        btnGame(x, y).Width = 30
        btnGame(x, y).Height = 30
        btnGame(x, y).Enabled = True
        btnGame(x, y).BackColor = Color.LightCyan
        'Το TabIndex δίνει τη σειρά που θα έχει το button οταν θα πατάμε το tab
        'Με αυτό τον τρόπο κρατάμε την y συντεταγμένη στο ίδιο το button
        btnGame(x, y).TabIndex = y
        'Αν πρόκειται για το 1ο button της 1ης γραμμής του δίνουμε απόσταση από Top=0
        'Αν πρόκειται για το 1ο button άλλης γραμμής του δίνουμε Top 
        ' όσο το Top του button που βρίσκεται από πάνω του + το ύψος του από πάνω του 
        'Από αριστερά η απόσταση φυσικά θα είναι 0
        If y = 0 Then
            If x = 0 Then btnGame(x, 0).Top = 0 Else btnGame(x, 0).Top = btnGame(x - 1, 0).Top + btnGame(x - 1, 0).Height
            btnGame(x, 0).Left = 0
        Else
            'Τα υπόλοιπα buttons θα έχουν Left όσο και το διπλανό τους + το πλάτος του διπλανού τους
            btnGame(x, y).Left = btnGame(x, y - 1).Left + btnGame(x, y - 1).Width
            'θα απέχουν δε από την κορυφή (top) το ίδιο με το διπλανό τους
            btnGame(x, y).Top = btnGame(x, y - 1).Top
        End If
        'Εδώ ζητάμε με τη μέθοδο Add της κλάσης Controls να δημιουργήσει το button btnGame(x, y)
        Me.Controls.Add(btnGame(x, y))
        'ΠΟΛΥ ΣΗΜΑΝΤΙΚΟ!! Εδώ ορίζουμε με ΔΥΝΑΜΙΚΟ ΤΡΟΠΟ τον χειριστή click για το νέο αυτό button
        ' που δημιουργήσαμε. Ορίζουμε τον "MyClickHandler" ως τέτοιο χειριστή.
        ' ΑΡΑ ολα τα btnGame(x, y) θα έχουν τον ίδιο χειριστή click με όνομα MyClickHandler
        AddHandler btnGame(x, y).Click, AddressOf MyClickHandler
    End Sub

    Private Sub MyClickHandler(ByVal sender As System.Object, ByVal b As System.EventArgs)
        Dim btn As Button
        btn = CType(sender, Button)
        If btn.Tag < 0 Then
            btn.Tag = -4
            sender.BackColor = Color.Red 'δείχνουμε με κόκκινο τις εύστοχες βολές
            btn.Enabled = False
            hit.Visible = True
            miss.Visible = False
            txt1.Text = txt1.Text + 10
        Else
            txt.Text = txt.Text - 1
            If txt.Text = 0 Then
                For i = 0 To 10
                    For j = 0 To 10
                        If btnGame(i, j).Tag = -1 Then
                            btnGame(i, j).BackColor = Color.Yellow

                        End If
                    Next
                Next
                MsgBox("Δυστυχώς έχασες :( ", vbYes)
                If vbYes Then
                    End
                Else
                    End
                End If
            End If
            btn.Enabled = False
            sender.BackColor = Color.Blue 'δείχνουμε με Blue τις άστοχες βολές
            hit.Visible = False
            miss.Visible = True
        End If
    End Sub

    Sub putPloia()

        Dim i, x, y, t, z, rnd, zi As Byte, rndObject As New Random(), randomslots As New Random

        For i = 1 To plia
            Do
                x = rndObject.Next(0, 10) 'παράγει έναν τυχαίο αριθμό στο διάστημα [0,11] για το x
                y = rndObject.Next(0, 10) 'παράγει έναν τυχαίο αριθμό στο διάστημα [0,11] για το y
            Loop Until Game(x, y) <> -1
            Game(x, y) = -1
            z = x
            zi = y
            rnd = randomslots.Next(1, 5)
            If i Mod 2 = 0 Then
                For t = 1 To rnd
                    If x < 10 Then
                        Game(x + 1, y) = -1
                        x += 1
                    Else

                        Game(z - 1, y) = -1
                        z = z - 1

                    End If
                Next
            Else
                For t = 1 To rnd
                    If y < 10 Then
                        Game(x, y + 1) = -1
                        y += 1
                    Else
                        Game(z, zi - 1) = -1
                        zi = zi - 1

                    End If

                Next
            End If

        Next
        For i = 0 To 10
            For z = 0 To 10
                If Game(i, z) < 0 Then
                    btnGame(i, z).Tag = -1
                End If
            Next
        Next

    End Sub


    Private Sub b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click, b2.Click, b3.Click, b4.Click, _
                                                                                                b5.Click, b6.Click, b7.Click, _
                                                                                                b8.Click
        plia = sender.text
        b1.Enabled = False
        b2.Enabled = False
        b3.Enabled = False
        b4.Enabled = False
        b5.Enabled = False
        b6.Enabled = False
        b7.Enabled = False
        b8.Enabled = False
        bi = True
        IsNumeric(plia)
        sender = False
        If bi1 And bi Then
            For i = 0 To 10
                Call generateButton(i, 0) 'Δημιουργεί το 1o button κάθε γραμμής - btnGame(i,0)
                For j = 1 To 10
                    Call generateButton(i, j) 'Δημιουργεί τα υπόλοιπα button κάθε γραμμής btnGame(i,j)
                Next
            Next

            'Οι παρακάτω 3 μικρορυθμίσεις εξασφαλίζουν το σωστό πλάτος & ύψος της φόρμας
            Me.Width = btnGame(0, 10).Left + btnGame(0, 10).Width + 150
            Me.Height = btnGame(10, 0).Top + btnGame(10, 0).Height + 70
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle

            'Τώρα τοποθετείστε τα πλοία σας στον πίνακα Game σύμφωνα με το δικό σας αλγόριθμο
            Call putPloia()
        End If

    End Sub


    Private Sub d_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d1.Click, d2.Click, d3.Click, _
                                                                                                d4.Click, d5.Click, d6.Click, _
                                                                                                   d7.Click, d8.Click, d9.Click, d10.Click, d11.Click, d12.Click
        txt.Text = sender.text
        bi1 = True
        d1.Enabled = False
        d2.Enabled = False
        d3.Enabled = False
        d4.Enabled = False
        d5.Enabled = False
        d6.Enabled = False
        d7.Enabled = False
        d8.Enabled = False
        d9.Enabled = False
        d10.Enabled = False
        d11.Enabled = False
        d12.Enabled = False
        txt.Enabled = False
        If bi And bi1 Then
            For i = 0 To 10
                Call generateButton(i, 0) 'Δημιουργεί το 1o button κάθε γραμμής - btnGame(i,0)
                For j = 1 To 10
                    Call generateButton(i, j) 'Δημιουργεί τα υπόλοιπα button κάθε γραμμής btnGame(i,j)
                Next
            Next

            'Οι παρακάτω 3 μικρορυθμίσεις εξασφαλίζουν το σωστό πλάτος & ύψος της φόρμας
            Me.Width = btnGame(0, 10).Left + btnGame(0, 10).Width + 150
            Me.Height = btnGame(10, 0).Top + btnGame(10, 0).Height + 70
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle

            'Τώρα τοποθετείστε τα πλοία σας στον πίνακα Game σύμφωνα με το δικό σας αλγόριθμο
            Call putPloia()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()

    End Sub

End Class