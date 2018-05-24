Imports System.Text

Public Class Form3
    Dim Cuti As New Cuti
    Dim submit, awal, akhir As DateTime
    Dim totalhari As Integer
    Dim remarks, KPK, Nama, Dept, Section As String



    Private Sub FlowLayoutPanel1_Click(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.Click
        Dim ID As String = ""
        Dim count As Integer = 1
        Do While count = 1
            Dim r As New Random
            ID = RandomString(r)
            count = PersonelActionTableAdapter.CheckID(ID)
        Loop
        submit = Now()
        awal = DateTimePicker1.Value
        akhir = DateTimePicker2.Value
        totalhari = akhir.Subtract(awal).Days + 1
        remarks = TextBox1.Text

        PersonelActionTableAdapter.InsertBonus(ID, submit, KPK, Nama, Dept, Section, awal.Date, akhir.Date, totalhari, remarks)
        MsgBox("BONUS LEAVE HAS BEEN ADDED")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Select()
        'TODO: This line of code loads data into the 'EmployeeDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.EmployeeDataSet.Employee)
        'TODO: This line of code loads data into the 'Personel_ActionDataSet.personelAction' table. You can move, or remove it, as needed.
        Me.PersonelActionTableAdapter.Fill(Me.Personel_ActionDataSet.personelAction)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        On Error Resume Next
        KPK = TextBox2.Text
        EmployeeBindingSource.Filter = "ID = " & KPK
        If EmployeeBindingSource.Count() = 1 Then
            Nama = Trim(EmployeeBindingSource.Current("EMNAME"))
            Dept = Trim(EmployeeBindingSource.Current("EMDEPT"))
            Section = Trim(EmployeeBindingSource.Current("EMLOC#"))
            TextBox3.Text = Nama
        Else
            TextBox3.Text = ""
        End If
    End Sub

    'String randomizer
    Function RandomString(r As Random)
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = 8
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function

End Class