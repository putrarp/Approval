Imports Microsoft.Office.Interop
Module SendMail

    Public Sub sendMail(tos, tosn, cc, eName, eKpk, tglMulai, tglAkhir, sName, remarks)
        ' Create an Outlook application.
        Dim oApp As Outlook.Application
        oApp = New Outlook.Application()

        ' Create a new MailItem.
        Dim oMsg As Outlook.MailItem
        oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
        oMsg.Subject = "LEAVE REQUEST - " & eName
        oMsg.HTMLBody = "<html>Dear " & tosn & ",<br><br>" &
                    "I have approve the Leave Request, please review the Request below for next approval by clicking <a href='\\apckrm06a\Public\NEW KIOSK\APPROVAL\Approval.application'>THIS LINK</a><br><br>" &
                    "<table bgcolor=""#d9d9d9"" style=""border-style:inset;font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;font-size:25px;color: #808080;border-width: thin"">" &
                        "<tr>" &
                            "<td colspan=""4"" bgcolor=""#92d050""><center>LEAVE REQUEST</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""4"" style=""font-size: 15px""><center>KPK</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td colspan=""4""><center>" & eKpk & "</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""4"" style=""font-size: 15px""><center>NAME</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td colspan=""4""><center>" & eName & "</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""4"" style=""font-size: 15px""><center>REMARKS</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td colspan=""4""><center>" & remarks & "</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""2"" style=""font-size: 15px""><center>START</center></td>" &
                            "<td colspan=""2"" style=""font-size: 15px""><center>END</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td><center>" & tglMulai & "</center></td>" &
                            "<td></td><td></td>" &
                            "<td><center>" & tglAkhir & "</center></td>" &
                        "</tr>" &
                    "</table><br>" &
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
        oMsg.Send()

        ' Clean up
        oApp = Nothing
        oMsg = Nothing
        'oAttach = Nothing
        'oAttachs = Nothing
    End Sub

    Public Sub sendMail1(tos, tosn, cc, eName, eKpk, tglMulai, tglAkhir, sName, remarks)
        ' Create an Outlook application.
        Dim oApp As Outlook.Application
        oApp = New Outlook.Application()

        ' Create a new MailItem.
        Dim oMsg As Outlook.MailItem
        oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
        oMsg.Subject = "LEAVE REQUEST - " & eName
        oMsg.HTMLBody = "<html>Dear " & tosn & ",<br><br>" &
                    "Your Leave Request has been approved<br><br>" &
                    "<table bgcolor=""#d9d9d9"" style=""border-style:inset;font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;font-size:25px;color: #808080;border-width: thin"">" &
                        "<tr>" &
                            "<td colspan=""4"" bgcolor=""#92d050""><center>LEAVE REQUEST</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""4"" style=""font-size: 15px""><center>KPK</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td colspan=""4""><center>" & eKpk & "</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""4"" style=""font-size: 15px""><center>NAME</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td colspan=""4""><center>" & eName & "</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""4"" style=""font-size: 15px""><center>REMARKS</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td colspan=""4""><center>" & remarks & "</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""2"" style=""font-size: 15px""><center>START</center></td>" &
                            "<td colspan=""2"" style=""font-size: 15px""><center>END</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td><center>" & tglMulai & "</center></td>" &
                            "<td></td><td></td>" &
                            "<td><center>" & tglAkhir & "</center></td>" &
                        "</tr>" &
                    "</table><br>" &
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
        oMsg.Send()

        ' Clean up
        oApp = Nothing
        oMsg = Nothing
        'oAttach = Nothing
        'oAttachs = Nothing
    End Sub

    Public Sub sendMail2(tos, tosn, cc, eName, eKpk, tglMulai, tglAkhir, sName, remarks)
        ' Create an Outlook application.
        Dim oApp As Outlook.Application
        oApp = New Outlook.Application()

        ' Create a new MailItem.
        Dim oMsg As Outlook.MailItem
        oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
        oMsg.Subject = "LEAVE REQUEST - " & eName
        oMsg.HTMLBody = "<html>Dear " & tosn & ",<br><br>" &
                    "Your Leave Request has been declined<br><br>" &
                    "<table bgcolor=""#d9d9d9"" style=""border-style:inset;font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;font-size:25px;color: #808080;border-width: thin"">" &
                        "<tr>" &
                            "<td colspan=""4"" bgcolor=""#92d050""><center>LEAVE REQUEST</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""4"" style=""font-size: 15px""><center>KPK</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td colspan=""4""><center>" & eKpk & "</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""4"" style=""font-size: 15px""><center>NAME</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td colspan=""4""><center>" & eName & "</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""4"" style=""font-size: 15px""><center>REMARKS</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td colspan=""4""><center>" & remarks & "</center></td>" &
                        "</tr>" &
                        "<tr height=""10px""></tr>" &
                        "<tr>" &
                            "<td colspan=""2"" style=""font-size: 15px""><center>START</center></td>" &
                            "<td colspan=""2"" style=""font-size: 15px""><center>END</center></td>" &
                        "</tr>" &
                        "<tr>" &
                            "<td><center>" & tglMulai & "</center></td>" &
                            "<td></td><td></td>" &
                            "<td><center>" & tglAkhir & "</center></td>" &
                        "</tr>" &
                    "</table><br>" &
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
        oMsg.Send()

        ' Clean up
        oApp = Nothing
        oMsg = Nothing
        'oAttach = Nothing
        'oAttachs = Nothing
    End Sub
End Module
