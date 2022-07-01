Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        BetterMe.Show()
        Dim appPath As String = Application.StartupPath()
        Dim completedQ As Integer
        completedQ = My.Computer.FileSystem.ReadAllText(apppath + "\txttest\QuestCount\CompletedQuests.txt")
        Convert.ToInt32(completedQ)
        completedQ += 1
        My.Computer.FileSystem.WriteAllText(appPath + "\txttest\QuestCount\CompletedQuests.txt", completedQ, False)
        BetterMe.labelTextChange(My.Computer.FileSystem.ReadAllText(appPath + "\txttest\QuestCount\CompletedQuests.txt"))
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        BetterMe.Show()
    End Sub
End Class