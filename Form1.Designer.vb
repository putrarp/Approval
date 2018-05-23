<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbLogin = New System.Windows.Forms.TextBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeData = New Approval.EmployeeDataSet()
        Me.LoginPanel = New System.Windows.Forms.Panel()
        Me.AdminApproval = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbScan = New System.Windows.Forms.TextBox()
        Me.btnApprove = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnDecline = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmployeeTable = New Approval.EmployeeDataSetTableAdapters.EmployeeTableAdapter()
        Me.SupApproval = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PersonelActionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Personel_ActionDataSet = New Approval.Personel_ActionDataSet()
        Me.PersonelActionTableAdapter = New Approval.Personel_ActionDataSetTableAdapters.personelActionTableAdapter()
        Me.FindApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Personel_ActionDataSet1 = New Approval.Personel_ActionDataSet()
        Me.FindApprovalTableAdapter = New Approval.Personel_ActionDataSetTableAdapters.FindApprovalTableAdapter()
        Me.ApprovalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApprovalTableAdapter = New Approval.Personel_ActionDataSetTableAdapters.approvalTableAdapter()
        Me.EmailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmailTableAdapter = New Approval.EmployeeDataSetTableAdapters.emailTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddMandatoryLeaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDMANDATORYLEAVEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADDBONUSLEAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoginPanel.SuspendLayout()
        Me.AdminApproval.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupApproval.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonelActionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Personel_ActionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FindApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Personel_ActionDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApprovalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(371, 487)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tbLogin, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(40, 51)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.78531!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.474576!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.58192!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.72316!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(290, 383)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FlowLayoutPanel1.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel1.BackgroundImage"), System.Drawing.Image)
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 201)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(284, 34)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MASUKAN KPK ANDA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbLogin
        '
        Me.tbLogin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tbLogin.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLogin.Location = New System.Drawing.Point(3, 172)
        Me.tbLogin.Name = "tbLogin"
        Me.tbLogin.Size = New System.Drawing.Size(284, 23)
        Me.tbLogin.TabIndex = 1
        Me.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbLogin.UseSystemPasswordChar = True
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.EmployeeData
        '
        'EmployeeData
        '
        Me.EmployeeData.DataSetName = "EmployeeDataSet"
        Me.EmployeeData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginPanel
        '
        Me.LoginPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.LoginPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginPanel.Location = New System.Drawing.Point(0, 24)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(371, 487)
        Me.LoginPanel.TabIndex = 1
        '
        'AdminApproval
        '
        Me.AdminApproval.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AdminApproval.Controls.Add(Me.TableLayoutPanel3)
        Me.AdminApproval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminApproval.Location = New System.Drawing.Point(0, 24)
        Me.AdminApproval.Name = "AdminApproval"
        Me.AdminApproval.Size = New System.Drawing.Size(371, 487)
        Me.AdminApproval.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(371, 487)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.tbScan, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnApprove, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.btnDecline, 1, 2)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(40, 51)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.049536!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.95046!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(290, 383)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.EmName})
        Me.TableLayoutPanel4.SetColumnSpan(Me.DataGridView1, 2)
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(284, 309)
        Me.DataGridView1.TabIndex = 1
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        '
        'EmName
        '
        Me.EmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmName.HeaderText = "Name"
        Me.EmName.Name = "EmName"
        '
        'tbScan
        '
        Me.TableLayoutPanel4.SetColumnSpan(Me.tbScan, 2)
        Me.tbScan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbScan.Location = New System.Drawing.Point(3, 3)
        Me.tbScan.Name = "tbScan"
        Me.tbScan.Size = New System.Drawing.Size(284, 20)
        Me.tbScan.TabIndex = 0
        Me.tbScan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnApprove.BackgroundImage = CType(resources.GetObject("btnApprove.BackgroundImage"), System.Drawing.Image)
        Me.btnApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnApprove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnApprove.Location = New System.Drawing.Point(3, 345)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(139, 35)
        Me.btnApprove.TabIndex = 2
        '
        'btnDecline
        '
        Me.btnDecline.BackColor = System.Drawing.Color.Red
        Me.btnDecline.BackgroundImage = CType(resources.GetObject("btnDecline.BackgroundImage"), System.Drawing.Image)
        Me.btnDecline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDecline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDecline.Location = New System.Drawing.Point(148, 345)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(139, 35)
        Me.btnDecline.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Scan Barcode"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmployeeTable
        '
        Me.EmployeeTable.ClearBeforeFill = True
        '
        'SupApproval
        '
        Me.SupApproval.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SupApproval.Controls.Add(Me.TableLayoutPanel5)
        Me.SupApproval.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SupApproval.Location = New System.Drawing.Point(0, 24)
        Me.SupApproval.Name = "SupApproval"
        Me.SupApproval.Size = New System.Drawing.Size(371, 487)
        Me.SupApproval.TabIndex = 2
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(371, 487)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.DataGridView2, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.TextBox1, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.FlowLayoutPanel2, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.FlowLayoutPanel3, 1, 2)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(40, 51)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.049536!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.95046!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(290, 383)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TableLayoutPanel6.SetColumnSpan(Me.DataGridView2, 2)
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 30)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(284, 309)
        Me.DataGridView2.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'TextBox1
        '
        Me.TableLayoutPanel6.SetColumnSpan(Me.TextBox1, 2)
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(284, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.Visible = False
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FlowLayoutPanel2.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel2.BackgroundImage"), System.Drawing.Image)
        Me.FlowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 345)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(139, 35)
        Me.FlowLayoutPanel2.TabIndex = 2
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.BackColor = System.Drawing.Color.Red
        Me.FlowLayoutPanel3.BackgroundImage = CType(resources.GetObject("FlowLayoutPanel3.BackgroundImage"), System.Drawing.Image)
        Me.FlowLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(148, 345)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(139, 35)
        Me.FlowLayoutPanel3.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(290, 27)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Scan Barcode"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PersonelActionBindingSource
        '
        Me.PersonelActionBindingSource.DataMember = "personelAction"
        Me.PersonelActionBindingSource.DataSource = Me.Personel_ActionDataSet
        '
        'Personel_ActionDataSet
        '
        Me.Personel_ActionDataSet.DataSetName = "Personel_ActionDataSet"
        Me.Personel_ActionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonelActionTableAdapter
        '
        Me.PersonelActionTableAdapter.ClearBeforeFill = True
        '
        'FindApprovalBindingSource
        '
        Me.FindApprovalBindingSource.DataMember = "FindApproval"
        Me.FindApprovalBindingSource.DataSource = Me.Personel_ActionDataSet1
        '
        'Personel_ActionDataSet1
        '
        Me.Personel_ActionDataSet1.DataSetName = "Personel_ActionDataSet"
        Me.Personel_ActionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FindApprovalTableAdapter
        '
        Me.FindApprovalTableAdapter.ClearBeforeFill = True
        '
        'ApprovalBindingSource
        '
        Me.ApprovalBindingSource.DataMember = "approval"
        Me.ApprovalBindingSource.DataSource = Me.Personel_ActionDataSet
        '
        'ApprovalTableAdapter
        '
        Me.ApprovalTableAdapter.ClearBeforeFill = True
        '
        'EmailBindingSource
        '
        Me.EmailBindingSource.DataMember = "email"
        Me.EmailBindingSource.DataSource = Me.EmployeeData
        '
        'EmailTableAdapter
        '
        Me.EmailTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMandatoryLeaveToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(371, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddMandatoryLeaveToolStripMenuItem
        '
        Me.AddMandatoryLeaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADDMANDATORYLEAVEToolStripMenuItem1, Me.ADDBONUSLEAVEToolStripMenuItem})
        Me.AddMandatoryLeaveToolStripMenuItem.Name = "AddMandatoryLeaveToolStripMenuItem"
        Me.AddMandatoryLeaveToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.AddMandatoryLeaveToolStripMenuItem.Text = "SETTING"
        '
        'ADDMANDATORYLEAVEToolStripMenuItem1
        '
        Me.ADDMANDATORYLEAVEToolStripMenuItem1.Name = "ADDMANDATORYLEAVEToolStripMenuItem1"
        Me.ADDMANDATORYLEAVEToolStripMenuItem1.Size = New System.Drawing.Size(211, 22)
        Me.ADDMANDATORYLEAVEToolStripMenuItem1.Text = "ADD MANDATORY LEAVE"
        '
        'ADDBONUSLEAVEToolStripMenuItem
        '
        Me.ADDBONUSLEAVEToolStripMenuItem.Name = "ADDBONUSLEAVEToolStripMenuItem"
        Me.ADDBONUSLEAVEToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ADDBONUSLEAVEToolStripMenuItem.Text = "ADD BONUS LEAVE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(371, 511)
        Me.Controls.Add(Me.SupApproval)
        Me.Controls.Add(Me.LoginPanel)
        Me.Controls.Add(Me.AdminApproval)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoginPanel.ResumeLayout(False)
        Me.AdminApproval.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupApproval.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonelActionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Personel_ActionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FindApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Personel_ActionDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApprovalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents tbLogin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeDataSet As EmployeeDataSet
    Friend WithEvents EmployeeTableAdapter As EmployeeDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents LoginPanel As Panel
    Friend WithEvents AdminApproval As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents tbScan As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnApprove As FlowLayoutPanel
    Friend WithEvents btnDecline As FlowLayoutPanel
    Friend WithEvents EmployeeData As EmployeeDataSet
    Friend WithEvents EmployeeTable As EmployeeDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents PersonelActionBindingSource As BindingSource
    Friend WithEvents Personel_ActionDataSet As Personel_ActionDataSet
    Friend WithEvents PersonelActionTableAdapter As Personel_ActionDataSetTableAdapters.personelActionTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents EmName As DataGridViewTextBoxColumn
    Friend WithEvents SupApproval As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents FindApprovalBindingSource As BindingSource
    Friend WithEvents Personel_ActionDataSet1 As Personel_ActionDataSet
    Friend WithEvents FindApprovalTableAdapter As Personel_ActionDataSetTableAdapters.FindApprovalTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents ApprovalBindingSource As BindingSource
    Friend WithEvents ApprovalTableAdapter As Personel_ActionDataSetTableAdapters.approvalTableAdapter
    Friend WithEvents EmailBindingSource As BindingSource
    Friend WithEvents EmailTableAdapter As EmployeeDataSetTableAdapters.emailTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AddMandatoryLeaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ADDMANDATORYLEAVEToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ADDBONUSLEAVEToolStripMenuItem As ToolStripMenuItem
End Class
