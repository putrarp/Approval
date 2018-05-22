Public Class Form1
    Dim stage As Integer
    Dim kpk, birthdate As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeData.email' table. You can move, or remove it, as needed.
        Me.EmailTableAdapter.Fill(Me.EmployeeData.email)
        'TODO: This line of code loads data into the 'Personel_ActionDataSet.approval' table. You can move, or remove it, as needed.
        Me.ApprovalTableAdapter.Fill(Me.Personel_ActionDataSet.approval)
        'TODO: This line of code loads data into the 'Personel_ActionDataSet1.FindApproval' table. You can move, or remove it, as needed.
        Me.FindApprovalTableAdapter.Fill(Me.Personel_ActionDataSet1.FindApproval)
        'TODO: This line of code loads data into the 'Personel_ActionDataSet.personelAction' table. You can move, or remove it, as needed.
        Me.PersonelActionTableAdapter.Fill(Me.Personel_ActionDataSet.personelAction)
        'TODO: This line of code loads data into the 'EmployeeDataSet1.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTable.Fill(Me.EmployeeData.Employee)

        LoginPanel.Visible = True
        AdminApproval.Visible = False
        SupApproval.Visible = False
        stage = 1
    End Sub

    Private Sub FlowLayoutPanel1_Click(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.Click
        If stage = 1 Then
            kpk = tbLogin.Text
            Dim Count = EmployeeTable.LoginQuery(kpk)
            If Count = 1 Then
                Label1.Text = "MASUKAN TANGGAL LAHIR ANDA (YYYYMMDD)"
                EmployeeBindingSource.Filter = "ID = " & kpk
                birthdate = EmployeeBindingSource.Current("EMBIRT")
                stage = 2
                tbLogin.Clear()
            ElseIf kpk = My.Settings.User Then
                Label1.Text = "MASUKAN PASSWORD"
                birthdate = My.Settings.Pass
                stage = 3
                tbLogin.Clear()
            End If
        ElseIf stage = 2 Then
            Dim birt = tbLogin.Text
            If True Then
                'If birthdate = birt Then
                MsgBox("Login Success")
                stage = 1
                LoginPanel.Visible = False
                AdminApproval.Visible = False
                SupApproval.Visible = True
                findApproval()
            Else
                MsgBox("Login Gagal")
                stage = 2
            End If
        ElseIf stage = 3 Then
            Dim birt = tbLogin.Text
            If birthdate = birt Then
                MsgBox("Login Success")
                stage = 1
                LoginPanel.Visible = False
                AdminApproval.Visible = True
                SupApproval.Visible = False
            Else
                MsgBox("Login Gagal")
                stage = 2
            End If
        End If
    End Sub

    Private Sub tbLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles tbLogin.KeyDown
        If e.KeyCode = Keys.Enter Then
            FlowLayoutPanel1_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub tbScan_KeyDown(sender As Object, e As KeyEventArgs) Handles tbScan.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim ID = tbScan.Text
            Dim count = PersonelActionTableAdapter.ScanQuery(ID)
            If count = 1 Then
                PersonelActionBindingSource.Filter = "ID = '" & ID.ToString & "'"
                DataGridView1.Rows.Add(ID, PersonelActionBindingSource.Current("emName"))
            End If
            tbScan.Clear()
        End If
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Dim count = DataGridView1.Rows.Count - 2
        Dim ans = MsgBox("APAKAH ANDA YAKIN INGIN MENERIMA " & DataGridView1.Rows.Count - 1 & " REQUEST CUTI?", vbYesNo, "TERIMA?")
        If ans = 6 Then
            For i = 0 To count
                PersonelActionTableAdapter.AcceptQuery(DataGridView1.Rows(i).Cells(0).Value)
            Next
            MsgBox(DataGridView1.Rows.Count - 1 & " request telah di terima")
            DataGridView1.Rows.Clear()
        End If
    End Sub

    Private Sub btnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        Dim count = DataGridView1.Rows.Count - 2
        Dim ans = MsgBox("APAKAH ANDA YAKIN INGIN MENOLAK " & DataGridView1.Rows.Count - 1 & " REQUEST CUTI?", vbYesNo, "TOLAK?")
        If ans = 6 Then
            For i = 0 To count
                PersonelActionTableAdapter.DeclineQuery(DataGridView1.Rows(i).Cells(0).Value)
            Next
            MsgBox(DataGridView1.Rows.Count - 1 & " request telah di tolak")
            DataGridView1.Rows.Clear()
        End If
    End Sub

    Private Sub findApproval()
        Dim ID(999), EmName(999) As String
        FindApprovalBindingSource.Filter = "KPK = " & kpk & " and status = 2"
        For i = 0 To FindApprovalBindingSource.Count - 1
            ID(i) = FindApprovalBindingSource.Current("ID")
            EmName(i) = FindApprovalBindingSource.Current("emName")
            'MsgBox(ID(i) & " " & EmName(i))
            DataGridView2.Rows.Add(New String() {ID(i), EmName(i)})
            FindApprovalBindingSource.MoveNext()
        Next
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        'Dim ID = DataGridView2.Item(0, e.RowIndex).Value
        'Dim NAMA = DataGridView2.Item(1, e.RowIndex).Value
        'MsgBox("APAKAH ANDA YAKIN INGIN MENERIMA REQUEST CUTI" & vbNewLine & ID & " - " & NAMA, vbYesNo, "TERIMA?")
    End Sub

    Private Sub FlowLayoutPanel3_Click(sender As Object, e As EventArgs) Handles FlowLayoutPanel3.Click
        Dim index = DataGridView2.CurrentCell.RowIndex
        Dim ID = DataGridView2.Item(0, index).Value
        Dim NAMA = DataGridView2.Item(1, index).Value
        MsgBox("APAKAH ANDA YAKIN INGIN MENOLAK REQUEST CUTI" & vbNewLine & ID & " - " & NAMA, vbYesNo, "TOLAK?")
        FindApprovalBindingSource.Filter = "KPK = " & kpk & " and ID = '" & ID & "'"
        Dim no = FindApprovalBindingSource.Current("no")
        ApprovalTableAdapter.UpdateApproval(99, ID, no)
        PersonelActionTableAdapter.DeclineQuery(ID)
    End Sub

    Private Sub FlowLayoutPanel2_Click(sender As Object, e As EventArgs) Handles FlowLayoutPanel2.Click
        Dim index = DataGridView2.CurrentCell.RowIndex
        Dim ID = DataGridView2.Item(0, index).Value.ToString
        Dim NAMA = DataGridView2.Item(1, index).Value
        MsgBox("APAKAH ANDA YAKIN INGIN MENERIMA REQUEST CUTI" & vbNewLine & ID & " - " & NAMA, vbYesNo, "TERIMA?")
        FindApprovalBindingSource.Filter = "KPK = " & kpk & " and ID = '" & ID & "'"
        Dim no = FindApprovalBindingSource.Current("no")
        Dim nexta = no + 1
        Dim nextnum = ApprovalTableAdapter.CountNext(ID, nexta)
        If nextnum = 1 Then
            'ApprovalTableAdapter.UpdateApproval(1, ID, no)
            'ApprovalTableAdapter.UpdateApproval(2, ID, nexta)
            Dim tos, cc As String
            FindApprovalBindingSource.Filter = "no = " & nexta & " and ID = '" & ID & "'"
            Dim tokpk = FindApprovalBindingSource.Current("kpk")
            EmailBindingSource.Filter = "ID = " & tokpk
            tos = EmailBindingSource.Current("email")


        ElseIf nextnum = 0 Then
            ApprovalTableAdapter.UpdateApproval(1, ID, no)
            PersonelActionTableAdapter.AcceptQuery(ID)
        End If
    End Sub
End Class
