Public Class Form3
    Private sayi As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim appPath As String = Application.StartupPath()
        Dim questcount As Integer
        questcount = My.Computer.FileSystem.ReadAllText(AppPath + "\txttest\QuestCount\QuestCount.txt")
        Convert.ToInt32(questcount)
        questcount += 1

        My.Computer.FileSystem.WriteAllText(appPath + "\txttest\Quests\quest.txt", TextBox1.Text, False)
        If My.Computer.FileSystem.FileExists(appPath + "\txttest\Quests\" + "Quest" + questcount.ToString() + ".txt") Then
            For questcount = 1 To 9999
                My.Computer.FileSystem.WriteAllText(appPath + "\txttest\Quests\" + "Quest" + questcount.ToString() + ".txt", TextBox1.Text, False)
            Next
        Else
            My.Computer.FileSystem.RenameFile(appPath + "\txttest\Quests\quest.txt", "Quest" + questcount.ToString() + ".txt")
        End If

        My.Computer.FileSystem.WriteAllText(appPath + "\txttest\QuestCount\QuestCount.txt", questcount, False)
        Me.Close()
        BetterMe.Show()

    End Sub


End Class