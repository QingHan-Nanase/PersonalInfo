<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PI
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.首页ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.登录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.注册ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.注销ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.通讯录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.日记ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.账本ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.registerPanel = New System.Windows.Forms.Panel()
        Me.InnerRegisterPanel = New System.Windows.Forms.Panel()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.regPassword = New System.Windows.Forms.TextBox()
        Me.regCheckPassword = New System.Windows.Forms.TextBox()
        Me.regUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LoginUsername = New System.Windows.Forms.TextBox()
        Me.LoginPassword = New System.Windows.Forms.TextBox()
        Me.InnerLoginPanel = New System.Windows.Forms.Panel()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.loginPanel = New System.Windows.Forms.Panel()
        Me.addressBookPanel = New System.Windows.Forms.Panel()
        Me.aBDelButton = New System.Windows.Forms.Button()
        Me.InnerABPanel = New System.Windows.Forms.Panel()
        Me.aBTelTextBox = New System.Windows.Forms.TextBox()
        Me.aBAddressTextBox = New System.Windows.Forms.TextBox()
        Me.aBEmailTextBox = New System.Windows.Forms.TextBox()
        Me.aBnameTextBox = New System.Windows.Forms.TextBox()
        Me.addNewaBButton = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.addressBoxListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.currentUser = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dairyPanel = New System.Windows.Forms.Panel()
        Me.DairySubmitBtn = New System.Windows.Forms.Button()
        Me.DairyRefreshBtn = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.contentTextBox = New System.Windows.Forms.TextBox()
        Me.accountBookPanel = New System.Windows.Forms.Panel()
        Me.accCurrentUserLabel = New System.Windows.Forms.Label()
        Me.delaccButton = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.accountCurrentUser = New System.Windows.Forms.Label()
        Me.accountBoxListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.inoutComboBox = New System.Windows.Forms.ComboBox()
        Me.amountTextBox = New System.Windows.Forms.TextBox()
        Me.dateTextBox = New System.Windows.Forms.TextBox()
        Me.itemTextBox = New System.Windows.Forms.TextBox()
        Me.addnewaccButton = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.registerPanel.SuspendLayout()
        Me.InnerRegisterPanel.SuspendLayout()
        Me.InnerLoginPanel.SuspendLayout()
        Me.loginPanel.SuspendLayout()
        Me.addressBookPanel.SuspendLayout()
        Me.InnerABPanel.SuspendLayout()
        Me.dairyPanel.SuspendLayout()
        Me.accountBookPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.首页ToolStripMenuItem, Me.通讯录ToolStripMenuItem, Me.日记ToolStripMenuItem, Me.账本ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1169, 39)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '首页ToolStripMenuItem
        '
        Me.首页ToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan
        Me.首页ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.登录ToolStripMenuItem, Me.注册ToolStripMenuItem, Me.注销ToolStripMenuItem})
        Me.首页ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.首页ToolStripMenuItem.Name = "首页ToolStripMenuItem"
        Me.首页ToolStripMenuItem.Size = New System.Drawing.Size(134, 35)
        Me.首页ToolStripMenuItem.Text = "登录/注册"
        '
        '登录ToolStripMenuItem
        '
        Me.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem"
        Me.登录ToolStripMenuItem.Size = New System.Drawing.Size(224, 36)
        Me.登录ToolStripMenuItem.Text = "登录"
        '
        '注册ToolStripMenuItem
        '
        Me.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem"
        Me.注册ToolStripMenuItem.Size = New System.Drawing.Size(224, 36)
        Me.注册ToolStripMenuItem.Text = "注册"
        '
        '注销ToolStripMenuItem
        '
        Me.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem"
        Me.注销ToolStripMenuItem.Size = New System.Drawing.Size(224, 36)
        Me.注销ToolStripMenuItem.Text = "注销"
        '
        '通讯录ToolStripMenuItem
        '
        Me.通讯录ToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan
        Me.通讯录ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.通讯录ToolStripMenuItem.Name = "通讯录ToolStripMenuItem"
        Me.通讯录ToolStripMenuItem.Size = New System.Drawing.Size(100, 35)
        Me.通讯录ToolStripMenuItem.Text = "通讯录"
        '
        '日记ToolStripMenuItem
        '
        Me.日记ToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan
        Me.日记ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.日记ToolStripMenuItem.Name = "日记ToolStripMenuItem"
        Me.日记ToolStripMenuItem.Size = New System.Drawing.Size(76, 35)
        Me.日记ToolStripMenuItem.Text = "日记"
        '
        '账本ToolStripMenuItem
        '
        Me.账本ToolStripMenuItem.BackColor = System.Drawing.Color.LightCyan
        Me.账本ToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.账本ToolStripMenuItem.Name = "账本ToolStripMenuItem"
        Me.账本ToolStripMenuItem.Size = New System.Drawing.Size(76, 35)
        Me.账本ToolStripMenuItem.Text = "账本"
        '
        'registerPanel
        '
        Me.registerPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.registerPanel.BackgroundImage = CType(resources.GetObject("registerPanel.BackgroundImage"), System.Drawing.Image)
        Me.registerPanel.Controls.Add(Me.InnerRegisterPanel)
        Me.registerPanel.Controls.Add(Me.Label4)
        Me.registerPanel.Location = New System.Drawing.Point(20, 38)
        Me.registerPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.registerPanel.Name = "registerPanel"
        Me.registerPanel.Size = New System.Drawing.Size(1049, 480)
        Me.registerPanel.TabIndex = 1
        '
        'InnerRegisterPanel
        '
        Me.InnerRegisterPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.InnerRegisterPanel.Controls.Add(Me.registerButton)
        Me.InnerRegisterPanel.Controls.Add(Me.Label7)
        Me.InnerRegisterPanel.Controls.Add(Me.regPassword)
        Me.InnerRegisterPanel.Controls.Add(Me.regCheckPassword)
        Me.InnerRegisterPanel.Controls.Add(Me.regUsername)
        Me.InnerRegisterPanel.Controls.Add(Me.Label5)
        Me.InnerRegisterPanel.Controls.Add(Me.Label6)
        Me.InnerRegisterPanel.Location = New System.Drawing.Point(272, 159)
        Me.InnerRegisterPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.InnerRegisterPanel.Name = "InnerRegisterPanel"
        Me.InnerRegisterPanel.Size = New System.Drawing.Size(517, 261)
        Me.InnerRegisterPanel.TabIndex = 6
        '
        'registerButton
        '
        Me.registerButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.registerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.registerButton.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.registerButton.Location = New System.Drawing.Point(217, 205)
        Me.registerButton.Margin = New System.Windows.Forms.Padding(4)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(100, 35)
        Me.registerButton.TabIndex = 7
        Me.registerButton.Text = "注册"
        Me.registerButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Menu
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 156)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 29)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "确认密码："
        '
        'regPassword
        '
        Me.regPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.regPassword.Location = New System.Drawing.Point(175, 99)
        Me.regPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.regPassword.Name = "regPassword"
        Me.regPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.regPassword.Size = New System.Drawing.Size(269, 34)
        Me.regPassword.TabIndex = 5
        '
        'regCheckPassword
        '
        Me.regCheckPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.regCheckPassword.Location = New System.Drawing.Point(175, 152)
        Me.regCheckPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.regCheckPassword.Name = "regCheckPassword"
        Me.regCheckPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.regCheckPassword.Size = New System.Drawing.Size(269, 34)
        Me.regCheckPassword.TabIndex = 4
        '
        'regUsername
        '
        Me.regUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.regUsername.Location = New System.Drawing.Point(175, 46)
        Me.regUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.regUsername.Name = "regUsername"
        Me.regUsername.Size = New System.Drawing.Size(269, 34)
        Me.regUsername.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Menu
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 29)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "密码："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Menu
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(48, 51)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 29)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "用户名："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("楷体", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(385, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(265, 60)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "用户注册"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("楷体", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(389, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "用户登录"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "用户名："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "密码："
        '
        'LoginUsername
        '
        Me.LoginUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LoginUsername.Location = New System.Drawing.Point(175, 59)
        Me.LoginUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginUsername.Name = "LoginUsername"
        Me.LoginUsername.Size = New System.Drawing.Size(233, 34)
        Me.LoginUsername.TabIndex = 3
        '
        'LoginPassword
        '
        Me.LoginPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LoginPassword.Location = New System.Drawing.Point(175, 132)
        Me.LoginPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginPassword.Name = "LoginPassword"
        Me.LoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LoginPassword.Size = New System.Drawing.Size(233, 34)
        Me.LoginPassword.TabIndex = 4
        '
        'InnerLoginPanel
        '
        Me.InnerLoginPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.InnerLoginPanel.Controls.Add(Me.loginButton)
        Me.InnerLoginPanel.Controls.Add(Me.LoginPassword)
        Me.InnerLoginPanel.Controls.Add(Me.LoginUsername)
        Me.InnerLoginPanel.Controls.Add(Me.Label3)
        Me.InnerLoginPanel.Controls.Add(Me.Label2)
        Me.InnerLoginPanel.Location = New System.Drawing.Point(276, 162)
        Me.InnerLoginPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.InnerLoginPanel.Name = "InnerLoginPanel"
        Me.InnerLoginPanel.Size = New System.Drawing.Size(517, 258)
        Me.InnerLoginPanel.TabIndex = 5
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.SteelBlue
        Me.loginButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.Location = New System.Drawing.Point(217, 192)
        Me.loginButton.Margin = New System.Windows.Forms.Padding(4)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(100, 40)
        Me.loginButton.TabIndex = 6
        Me.loginButton.Text = "登录"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'loginPanel
        '
        Me.loginPanel.BackgroundImage = CType(resources.GetObject("loginPanel.BackgroundImage"), System.Drawing.Image)
        Me.loginPanel.Controls.Add(Me.InnerLoginPanel)
        Me.loginPanel.Controls.Add(Me.Label1)
        Me.loginPanel.Location = New System.Drawing.Point(16, 38)
        Me.loginPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.Size = New System.Drawing.Size(1075, 470)
        Me.loginPanel.TabIndex = 6
        '
        'addressBookPanel
        '
        Me.addressBookPanel.BackColor = System.Drawing.SystemColors.Info
        Me.addressBookPanel.BackgroundImage = CType(resources.GetObject("addressBookPanel.BackgroundImage"), System.Drawing.Image)
        Me.addressBookPanel.Controls.Add(Me.aBDelButton)
        Me.addressBookPanel.Controls.Add(Me.InnerABPanel)
        Me.addressBookPanel.Controls.Add(Me.addressBoxListView)
        Me.addressBookPanel.Controls.Add(Me.currentUser)
        Me.addressBookPanel.Controls.Add(Me.Label8)
        Me.addressBookPanel.Location = New System.Drawing.Point(4, 38)
        Me.addressBookPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.addressBookPanel.Name = "addressBookPanel"
        Me.addressBookPanel.Size = New System.Drawing.Size(1119, 494)
        Me.addressBookPanel.TabIndex = 7
        '
        'aBDelButton
        '
        Me.aBDelButton.BackColor = System.Drawing.Color.Aquamarine
        Me.aBDelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.aBDelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.aBDelButton.Location = New System.Drawing.Point(121, 372)
        Me.aBDelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.aBDelButton.Name = "aBDelButton"
        Me.aBDelButton.Size = New System.Drawing.Size(236, 45)
        Me.aBDelButton.TabIndex = 14
        Me.aBDelButton.Text = "确认删除"
        Me.aBDelButton.UseVisualStyleBackColor = False
        '
        'InnerABPanel
        '
        Me.InnerABPanel.BackColor = System.Drawing.Color.Transparent
        Me.InnerABPanel.Controls.Add(Me.aBTelTextBox)
        Me.InnerABPanel.Controls.Add(Me.aBAddressTextBox)
        Me.InnerABPanel.Controls.Add(Me.aBEmailTextBox)
        Me.InnerABPanel.Controls.Add(Me.aBnameTextBox)
        Me.InnerABPanel.Controls.Add(Me.addNewaBButton)
        Me.InnerABPanel.Controls.Add(Me.Label12)
        Me.InnerABPanel.Controls.Add(Me.Label11)
        Me.InnerABPanel.Controls.Add(Me.Label10)
        Me.InnerABPanel.Controls.Add(Me.Label9)
        Me.InnerABPanel.Location = New System.Drawing.Point(57, 89)
        Me.InnerABPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.InnerABPanel.Name = "InnerABPanel"
        Me.InnerABPanel.Size = New System.Drawing.Size(363, 278)
        Me.InnerABPanel.TabIndex = 9
        '
        'aBTelTextBox
        '
        Me.aBTelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.aBTelTextBox.Location = New System.Drawing.Point(92, 65)
        Me.aBTelTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.aBTelTextBox.Name = "aBTelTextBox"
        Me.aBTelTextBox.Size = New System.Drawing.Size(235, 30)
        Me.aBTelTextBox.TabIndex = 13
        '
        'aBAddressTextBox
        '
        Me.aBAddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.aBAddressTextBox.Location = New System.Drawing.Point(92, 165)
        Me.aBAddressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.aBAddressTextBox.Name = "aBAddressTextBox"
        Me.aBAddressTextBox.Size = New System.Drawing.Size(235, 30)
        Me.aBAddressTextBox.TabIndex = 12
        '
        'aBEmailTextBox
        '
        Me.aBEmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.aBEmailTextBox.Location = New System.Drawing.Point(92, 115)
        Me.aBEmailTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.aBEmailTextBox.Name = "aBEmailTextBox"
        Me.aBEmailTextBox.Size = New System.Drawing.Size(235, 30)
        Me.aBEmailTextBox.TabIndex = 11
        '
        'aBnameTextBox
        '
        Me.aBnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.aBnameTextBox.Location = New System.Drawing.Point(92, 15)
        Me.aBnameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.aBnameTextBox.Name = "aBnameTextBox"
        Me.aBnameTextBox.Size = New System.Drawing.Size(235, 30)
        Me.aBnameTextBox.TabIndex = 10
        '
        'addNewaBButton
        '
        Me.addNewaBButton.BackColor = System.Drawing.Color.Aquamarine
        Me.addNewaBButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addNewaBButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.addNewaBButton.Location = New System.Drawing.Point(92, 220)
        Me.addNewaBButton.Margin = New System.Windows.Forms.Padding(4)
        Me.addNewaBButton.Name = "addNewaBButton"
        Me.addNewaBButton.Size = New System.Drawing.Size(175, 45)
        Me.addNewaBButton.TabIndex = 9
        Me.addNewaBButton.Text = "确认添加"
        Me.addNewaBButton.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(7, 16)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 31)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "姓名："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(7, 66)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 31)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "电话："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(7, 116)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 31)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "邮箱："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(7, 165)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 31)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "地址："
        '
        'addressBoxListView
        '
        Me.addressBoxListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.addressBoxListView.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressBoxListView.HideSelection = False
        Me.addressBoxListView.Location = New System.Drawing.Point(430, 49)
        Me.addressBoxListView.Margin = New System.Windows.Forms.Padding(4)
        Me.addressBoxListView.Name = "addressBoxListView"
        Me.addressBoxListView.Size = New System.Drawing.Size(641, 390)
        Me.addressBoxListView.TabIndex = 4
        Me.addressBoxListView.UseCompatibleStateImageBehavior = False
        Me.addressBoxListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "姓名"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "电话"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "邮箱"
        Me.ColumnHeader3.Width = 140
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "地址"
        Me.ColumnHeader4.Width = 170
        '
        'currentUser
        '
        Me.currentUser.AutoSize = True
        Me.currentUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.currentUser.Location = New System.Drawing.Point(37, 21)
        Me.currentUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.currentUser.Name = "currentUser"
        Me.currentUser.Size = New System.Drawing.Size(0, 29)
        Me.currentUser.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(133, 21)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 31)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "的通讯录"
        '
        'dairyPanel
        '
        Me.dairyPanel.BackColor = System.Drawing.SystemColors.Info
        Me.dairyPanel.BackgroundImage = CType(resources.GetObject("dairyPanel.BackgroundImage"), System.Drawing.Image)
        Me.dairyPanel.Controls.Add(Me.DairySubmitBtn)
        Me.dairyPanel.Controls.Add(Me.DairyRefreshBtn)
        Me.dairyPanel.Controls.Add(Me.DateTimePicker1)
        Me.dairyPanel.Controls.Add(Me.contentTextBox)
        Me.dairyPanel.Location = New System.Drawing.Point(0, 38)
        Me.dairyPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.dairyPanel.Name = "dairyPanel"
        Me.dairyPanel.Size = New System.Drawing.Size(1127, 521)
        Me.dairyPanel.TabIndex = 15
        '
        'DairySubmitBtn
        '
        Me.DairySubmitBtn.BackColor = System.Drawing.SystemColors.Info
        Me.DairySubmitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DairySubmitBtn.Location = New System.Drawing.Point(825, 421)
        Me.DairySubmitBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DairySubmitBtn.Name = "DairySubmitBtn"
        Me.DairySubmitBtn.Size = New System.Drawing.Size(166, 45)
        Me.DairySubmitBtn.TabIndex = 3
        Me.DairySubmitBtn.Text = "上传本页日记"
        Me.DairySubmitBtn.UseVisualStyleBackColor = False
        '
        'DairyRefreshBtn
        '
        Me.DairyRefreshBtn.BackColor = System.Drawing.SystemColors.Info
        Me.DairyRefreshBtn.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DairyRefreshBtn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.DairyRefreshBtn.Location = New System.Drawing.Point(24, 425)
        Me.DairyRefreshBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DairyRefreshBtn.Name = "DairyRefreshBtn"
        Me.DairyRefreshBtn.Size = New System.Drawing.Size(158, 45)
        Me.DairyRefreshBtn.TabIndex = 2
        Me.DairyRefreshBtn.Text = "清空本页日记"
        Me.DairyRefreshBtn.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft YaHei UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(24, 15)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(287, 27)
        Me.DateTimePicker1.TabIndex = 1
        '
        'contentTextBox
        '
        Me.contentTextBox.BackColor = System.Drawing.SystemColors.HighlightText
        Me.contentTextBox.Location = New System.Drawing.Point(24, 49)
        Me.contentTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.contentTextBox.Multiline = True
        Me.contentTextBox.Name = "contentTextBox"
        Me.contentTextBox.Size = New System.Drawing.Size(967, 252)
        Me.contentTextBox.TabIndex = 0
        '
        'accountBookPanel
        '
        Me.accountBookPanel.BackColor = System.Drawing.SystemColors.Info
        Me.accountBookPanel.BackgroundImage = CType(resources.GetObject("accountBookPanel.BackgroundImage"), System.Drawing.Image)
        Me.accountBookPanel.Controls.Add(Me.accCurrentUserLabel)
        Me.accountBookPanel.Controls.Add(Me.delaccButton)
        Me.accountBookPanel.Controls.Add(Me.Label18)
        Me.accountBookPanel.Controls.Add(Me.accountCurrentUser)
        Me.accountBookPanel.Controls.Add(Me.accountBoxListView)
        Me.accountBookPanel.Controls.Add(Me.Panel1)
        Me.accountBookPanel.Location = New System.Drawing.Point(4, 38)
        Me.accountBookPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.accountBookPanel.Name = "accountBookPanel"
        Me.accountBookPanel.Size = New System.Drawing.Size(1123, 521)
        Me.accountBookPanel.TabIndex = 16
        '
        'accCurrentUserLabel
        '
        Me.accCurrentUserLabel.AutoSize = True
        Me.accCurrentUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.accCurrentUserLabel.Location = New System.Drawing.Point(85, 24)
        Me.accCurrentUserLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.accCurrentUserLabel.Name = "accCurrentUserLabel"
        Me.accCurrentUserLabel.Size = New System.Drawing.Size(0, 29)
        Me.accCurrentUserLabel.TabIndex = 16
        '
        'delaccButton
        '
        Me.delaccButton.BackColor = System.Drawing.SystemColors.HighlightText
        Me.delaccButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.delaccButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.delaccButton.Location = New System.Drawing.Point(105, 355)
        Me.delaccButton.Margin = New System.Windows.Forms.Padding(4)
        Me.delaccButton.Name = "delaccButton"
        Me.delaccButton.Size = New System.Drawing.Size(236, 45)
        Me.delaccButton.TabIndex = 15
        Me.delaccButton.Text = "删除账目"
        Me.delaccButton.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.SeaShell
        Me.Label18.Location = New System.Drawing.Point(169, 22)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 31)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "的账本"
        '
        'accountCurrentUser
        '
        Me.accountCurrentUser.AutoSize = True
        Me.accountCurrentUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.accountCurrentUser.Location = New System.Drawing.Point(77, 24)
        Me.accountCurrentUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.accountCurrentUser.Name = "accountCurrentUser"
        Me.accountCurrentUser.Size = New System.Drawing.Size(0, 29)
        Me.accountCurrentUser.TabIndex = 12
        '
        'accountBoxListView
        '
        Me.accountBoxListView.BackColor = System.Drawing.Color.Black
        Me.accountBoxListView.BackgroundImage = CType(resources.GetObject("accountBoxListView.BackgroundImage"), System.Drawing.Image)
        Me.accountBoxListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.accountBoxListView.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountBoxListView.HideSelection = False
        Me.accountBoxListView.Location = New System.Drawing.Point(490, 52)
        Me.accountBoxListView.Margin = New System.Windows.Forms.Padding(4)
        Me.accountBoxListView.Name = "accountBoxListView"
        Me.accountBoxListView.Size = New System.Drawing.Size(599, 390)
        Me.accountBoxListView.TabIndex = 11
        Me.accountBoxListView.UseCompatibleStateImageBehavior = False
        Me.accountBoxListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "具体内容"
        Me.ColumnHeader5.Width = 138
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "涉及金额"
        Me.ColumnHeader6.Width = 177
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "支出/收入"
        Me.ColumnHeader7.Width = 145
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "日期"
        Me.ColumnHeader8.Width = 150
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.inoutComboBox)
        Me.Panel1.Controls.Add(Me.amountTextBox)
        Me.Panel1.Controls.Add(Me.dateTextBox)
        Me.Panel1.Controls.Add(Me.itemTextBox)
        Me.Panel1.Controls.Add(Me.addnewaccButton)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Location = New System.Drawing.Point(42, 74)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 278)
        Me.Panel1.TabIndex = 10
        '
        'inoutComboBox
        '
        Me.inoutComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.inoutComboBox.FormattingEnabled = True
        Me.inoutComboBox.Items.AddRange(New Object() {"收入", "支出"})
        Me.inoutComboBox.Location = New System.Drawing.Point(127, 116)
        Me.inoutComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.inoutComboBox.Name = "inoutComboBox"
        Me.inoutComboBox.Size = New System.Drawing.Size(200, 33)
        Me.inoutComboBox.TabIndex = 14
        '
        'amountTextBox
        '
        Me.amountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.amountTextBox.Location = New System.Drawing.Point(127, 65)
        Me.amountTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.amountTextBox.Name = "amountTextBox"
        Me.amountTextBox.Size = New System.Drawing.Size(200, 30)
        Me.amountTextBox.TabIndex = 13
        '
        'dateTextBox
        '
        Me.dateTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dateTextBox.Location = New System.Drawing.Point(92, 165)
        Me.dateTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.dateTextBox.Name = "dateTextBox"
        Me.dateTextBox.Size = New System.Drawing.Size(235, 30)
        Me.dateTextBox.TabIndex = 12
        '
        'itemTextBox
        '
        Me.itemTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.itemTextBox.Location = New System.Drawing.Point(127, 15)
        Me.itemTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.itemTextBox.Name = "itemTextBox"
        Me.itemTextBox.Size = New System.Drawing.Size(200, 30)
        Me.itemTextBox.TabIndex = 10
        '
        'addnewaccButton
        '
        Me.addnewaccButton.BackColor = System.Drawing.Color.Transparent
        Me.addnewaccButton.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addnewaccButton.ForeColor = System.Drawing.Color.Black
        Me.addnewaccButton.Location = New System.Drawing.Point(92, 220)
        Me.addnewaccButton.Margin = New System.Windows.Forms.Padding(4)
        Me.addnewaccButton.Name = "addnewaccButton"
        Me.addnewaccButton.Size = New System.Drawing.Size(175, 45)
        Me.addnewaccButton.TabIndex = 9
        Me.addnewaccButton.Text = "记账"
        Me.addnewaccButton.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SeaShell
        Me.Label13.Location = New System.Drawing.Point(7, 14)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 31)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "具体内容："
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SeaShell
        Me.Label14.Location = New System.Drawing.Point(7, 64)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 31)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "涉及金额："
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SeaShell
        Me.Label15.Location = New System.Drawing.Point(7, 116)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 31)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "支出/收入"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.SeaShell
        Me.Label16.Location = New System.Drawing.Point(7, 164)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 31)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "日期："
        '
        'PI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1169, 581)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dairyPanel)
        Me.Controls.Add(Me.addressBookPanel)
        Me.Controls.Add(Me.registerPanel)
        Me.Controls.Add(Me.loginPanel)
        Me.Controls.Add(Me.accountBookPanel)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PI"
        Me.Text = "PersonalInfo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.registerPanel.ResumeLayout(False)
        Me.registerPanel.PerformLayout()
        Me.InnerRegisterPanel.ResumeLayout(False)
        Me.InnerRegisterPanel.PerformLayout()
        Me.InnerLoginPanel.ResumeLayout(False)
        Me.InnerLoginPanel.PerformLayout()
        Me.loginPanel.ResumeLayout(False)
        Me.loginPanel.PerformLayout()
        Me.addressBookPanel.ResumeLayout(False)
        Me.addressBookPanel.PerformLayout()
        Me.InnerABPanel.ResumeLayout(False)
        Me.InnerABPanel.PerformLayout()
        Me.dairyPanel.ResumeLayout(False)
        Me.dairyPanel.PerformLayout()
        Me.accountBookPanel.ResumeLayout(False)
        Me.accountBookPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 首页ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 登录ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 注册ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 通讯录ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 日记ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 账本ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents registerPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents InnerLoginPanel As Panel
    Friend WithEvents LoginPassword As TextBox
    Friend WithEvents LoginUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents loginPanel As Panel
    Friend WithEvents InnerRegisterPanel As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents regPassword As TextBox
    Friend WithEvents regCheckPassword As TextBox
    Friend WithEvents regUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents addressBookPanel As Panel
    Friend WithEvents aBDelButton As Button
    Friend WithEvents InnerABPanel As Panel
    Friend WithEvents aBTelTextBox As TextBox
    Friend WithEvents aBAddressTextBox As TextBox
    Friend WithEvents aBEmailTextBox As TextBox
    Friend WithEvents aBnameTextBox As TextBox
    Friend WithEvents addNewaBButton As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents addressBoxListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents currentUser As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dairyPanel As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents contentTextBox As TextBox
    Friend WithEvents DairySubmitBtn As Button
    Friend WithEvents DairyRefreshBtn As Button
    Friend WithEvents accountBookPanel As Panel
    Friend WithEvents loginButton As Button
    Friend WithEvents registerButton As Button
    Friend WithEvents 注销ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents delaccButton As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents accountCurrentUser As Label
    Friend WithEvents accountBoxListView As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents amountTextBox As TextBox
    Friend WithEvents dateTextBox As TextBox
    Friend WithEvents itemTextBox As TextBox
    Friend WithEvents addnewaccButton As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents inoutComboBox As ComboBox
    Friend WithEvents accCurrentUserLabel As Label
End Class
