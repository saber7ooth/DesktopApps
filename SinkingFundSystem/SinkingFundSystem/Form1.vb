Imports System.Data.OleDb

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SinkingfundDataSet.Loans' table. You can move, or remove it, as needed.
        Me.LoansTableAdapter.Fill(Me.SinkingfundDataSet.Loans)
        'TODO: This line of code loads data into the 'SinkingfundDataSet.Contributions' table. You can move, or remove it, as needed.
        Me.ContributionsTableAdapter.Fill(Me.SinkingfundDataSet.Contributions)

        

    End Sub

End Class
