Imports System.IO
Public Class FrmDATA
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        If e.Node.Parent IsNot Nothing Then
            Dim fileName As String = e.Node.Text.Split("-"c)(0).Trim()
            Dim filepath As String = Application.StartupPath + "\Data\" + fileName
            Process.Start(filepath)
        End If
    End Sub
    Private Sub buatreport()
        TreeView1.Nodes.Clear()
        Dim path As String = Application.StartupPath + "\Data"
        Dim rootNode As New TreeNode($"DATA")

        TreeView1.Nodes.Add(rootNode)
        PopulateTreeView(path, rootNode)
    End Sub

    Private Sub PopulateTreeView(directoryPath As String, parentNode As TreeNode)
        Dim directories As String() = Directory.GetDirectories(directoryPath)
        Dim directoriesCopy As New List(Of String)(directories)
        For Each directory As String In directoriesCopy
            Dim directoryNode As New TreeNode(Path.GetFileName(directory))
            parentNode.Nodes.Add(directoryNode)
            PopulateTreeView(directory, directoryNode)
        Next
        Dim sqlFiles As String() = Directory.GetFiles(directoryPath, "SQL_*.txt")
        Dim sqlFilesCopy As New List(Of String)(sqlFiles)
        Dim today As DateTime = DateTime.Now.Date
        Dim currentHour As Integer = DateTime.Now.Hour
        For Each sqlFile As String In sqlFilesCopy
            Dim fileInfo As New FileInfo(sqlFile)
            If fileInfo.CreationTime.Date = today AndAlso fileInfo.CreationTime.Hour = currentHour Then
                Dim fileNode As New TreeNode($"{Path.GetFileName(sqlFile)} - {fileInfo.CreationTime.ToString("yyyy-MM-dd HH:mm:ss")}")
                parentNode.Nodes.Add(fileNode)
            End If
        Next
    End Sub


    Private Sub FrmDATA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buatreport()
    End Sub

End Class