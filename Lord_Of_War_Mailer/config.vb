Imports System.Data.OleDb
Module config


    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\LOW_DB.accdb")
    Public ds As New DataTable
    Public da As New OleDbDataAdapter

End Module
