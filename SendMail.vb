Imports Microsoft.Office.Interop
Module SendMail
    Dim Employee, Cuti As Object
    Public Sub setObj(emp, cut)
        Employee = emp
        Cuti = cut
    End Sub

    Public Sub sendMail(tos, cc)
        ' Create an Outlook application.
        Dim oApp As Outlook.Application
        oApp = New Outlook.Application()

        ' Create a new MailItem.
        Dim oMsg As Outlook.MailItem
        oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
        oMsg.Subject = "Send Mail Using OOM in Visual Basic .NET"
        oMsg.Body = "Hello World" & vbCr & vbCr

        ' TODO: Replace with a valid e-mail address.
        oMsg.To = "darishazim.murtadho@mattel.com"
        oMsg.CC = "putrarizki.pradana@mattel.com"

        ' Add an attachment
        ' TODO: Replace with a valid attachment path.
        'Dim sSource As String = "C:\Temp\Hello.txt"
        ' TODO: Replace with attachment name
        'Dim sDisplayName As String = "Hello.txt"

        Dim sBodyLen As String = oMsg.Body.Length
        'Dim oAttachs As Outlook.Attachments = oMsg.Attachments
        'Dim oAttach As Outlook.Attachment
        'oAttach = oAttachs.Add(sSource, , sBodyLen + 1, sDisplayName)

        ' Send
        oMsg.Send()

        ' Clean up
        oApp = Nothing
        oMsg = Nothing
        'oAttach = Nothing
        'oAttachs = Nothing
    End Sub
End Module
