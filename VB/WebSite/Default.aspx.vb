﻿Imports DevExpress.Web
Imports System

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Protected Sub tbConfirmedPassword_Validation(ByVal sender As Object, ByVal e As ValidationEventArgs)
        If e.IsValid AndAlso tbPassword.Text <> tbConfirmedPassword.Text Then
            e.ErrorText = "Passwords do not match"
            e.IsValid = False
        End If

        If e.IsValid Then
            Response.Redirect("Complete.aspx")
        End If
    End Sub
End Class
