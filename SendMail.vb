Imports Microsoft.Office.Interop
Module SendMail

    Public Sub sendMail(tos, tosn, cc, eName, eKpk, tglMulai, tglAkhir, sName)
        ' Create an Outlook application.
        Dim oApp As Outlook.Application
        oApp = New Outlook.Application()

        ' Create a new MailItem.
        Dim oMsg As Outlook.MailItem
        oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
        oMsg.Subject = "LEAVE REQUEST - " & eName
        oMsg.Body = "Dear " & tosn & ",<br><br>" &
                    "<html>I have approve the Leave Request, please review the Request below for next approval by clicking <a href='\\apckrm06a\Public\NEW KIOSK\APPROVAL\Approval.application'>THIS LINK</a><br><br>" &
                    "KPK = " & eKpk & "<br>" &
                    "Name = " & eName & "<br>" &
                    "Effective Date = " & tglMulai & "<br>" &
                    "End Date = " & tglAkhir & "<br>" & "<br>" &
                    "Thanks & Regards,<br>" &
                    sName & "</html>"

        ' TODO: Replace with a valid e-mail address.
        oMsg.To = tos
        oMsg.CC = cc

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
        oMsg.Display()

        ' Clean up
        oApp = Nothing
        oMsg = Nothing
        'oAttach = Nothing
        'oAttachs = Nothing
    End Sub

    Public Sub sendMail1(tos, tosn, cc, eName, eKpk, tglMulai, tglAkhir, sName)
        ' Create an Outlook application.
        Dim oApp As Outlook.Application
        oApp = New Outlook.Application()

        ' Create a new MailItem.
        Dim oMsg As Outlook.MailItem
        oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
        oMsg.Subject = "LEAVE REQUEST - " & eName
        oMsg.Body = "DEAR " & tosn & "," & vbNewLine & vbNewLine &
                    "Your Leave Request has been approved" & vbNewLine & vbNewLine &
                    "KPK = " & eKpk & vbNewLine &
                    "Name = " & eName & vbNewLine &
                    "Effective Date = " & tglMulai & vbNewLine &
                    "End Date = " & tglAkhir & vbNewLine & vbNewLine &
                    "Thanks & Regards," & vbNewLine &
                    sName

        ' TODO: Replace with a valid e-mail address.
        oMsg.To = tos
        oMsg.CC = cc

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
        oMsg.Display()

        ' Clean up
        oApp = Nothing
        oMsg = Nothing
        'oAttach = Nothing
        'oAttachs = Nothing
    End Sub
End Module
