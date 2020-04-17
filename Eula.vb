﻿Imports System.IO

Public Class Eula
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkEULA.LinkClicked
        Process.Start("https://account.mojang.com/documents/minecraft_eula")
    End Sub

    Private Sub CheckEULA_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEULA.CheckedChanged
        If CheckEULA.Checked Then
            NextBtn.Enabled = True
        Else
            NextBtn.Enabled = False
        End If
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        'TODO: Créer le fichier eula.txt
        Dim EulaFile As StreamWriter = File.CreateText(Informations.ServerDir + "\eula.txt")
        EulaFile.WriteLine("# Generated by MCCustomServerCreator")
        EulaFile.WriteLine("# https://github.com/petittitouan/MCCustomServerCreator")
        EulaFile.WriteLine("eula=true")
        EulaFile.Close()
    End Sub
End Class