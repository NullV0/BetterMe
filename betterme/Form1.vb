Public Class BetterMe
    Public Sub appPather()
        Dim appPath As String = Application.StartupPath()
    End Sub
    Public Sub SelectQuest()
        Dim l As String() = IO.Directory.GetFiles(Application.StartupPath + "\txttest\Quests", "*.txt")
        Dim r As New Random
        Dim RandomFile As String = l(r.Next(l.Length))
        Form2.Label1.Text = IO.File.ReadAllText(RandomFile)
    End Sub
    Public Sub labelTextChange(a)

        Label1.Text = a
    End Sub
    Public Sub deleteQuests()
        Dim appPath As String = Application.StartupPath

        Dim directoryName As String = appPath + "\txttest\Quests\*txt"
        On Error Resume Next
        Kill(directoryName)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim appPath As String = Application.StartupPath()
        Label1.Text = My.Computer.FileSystem.ReadAllText(appPath + "\txttest\QuestCount\QuestCount.txt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NewQuest.Click
        Me.Hide()
        Form2.Show()
        SelectQuest()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddQuest.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim appPath As String = Application.StartupPath()

        deleteQuests()
        My.Computer.FileSystem.WriteAllText(appPath + "\txttest\QuestCount\QuestCount.txt", 0, False)
        labelTextChange(0)
        My.Computer.FileSystem.WriteAllText(appPath + "\txttest\QuestCount\CompletedQuests.txt", 0, False)

    End Sub

End Class
