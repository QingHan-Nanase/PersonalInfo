Imports System.IO

Public Class PI
    Private activeUser As person
    Private activeAddress As New ArrayList()
    Private activeAccount As New ArrayList()

    Public Sub initialAdr()
        activeAddress = New ArrayList()
        Dim sr As StreamReader = New StreamReader(activeUser.Username1 + "\address.txt")
        Dim item As address
        While sr.Peek <> -1
            Dim record, records() As String
            record = sr.ReadLine
            records = record.Split(","）
            item = New address(records(0), records(1), records(2), records(3))
            activeAddress.Add(item)
        End While
        sr.Close()
    End Sub

    Public Sub InitialAcc()
        activeAccount = New ArrayList()
        Dim sr As StreamReader = New StreamReader(activeUser.Username1 + "\account.txt")
        Dim item As account
        While sr.Peek <> -1
            Dim record, records() As String
            record = sr.ReadLine
            records = record.Split(","）
            item = New account(records(0), records(1), records(2), records(3))
            activeAccount.Add(item)
        End While
        sr.Close()
    End Sub

    Private Function Loaddairy(selectedDate As String) As Boolean
        Dim di As New DirectoryInfo(activeUser.Username1 + "\dairy")
        If di.Exists = False Then Exit Function
        For Each finfo As FileInfo In di.GetFiles
            If finfo.Name.ToString.Equals(selectedDate + ".txt") Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub PI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginPanel.Visible = True
        registerPanel.Visible = False
        addressBookPanel.Visible = False
        dairyPanel.Visible = False
        accountBookPanel.Visible = False
        通讯录ToolStripMenuItem.Enabled = False
        日记ToolStripMenuItem.Enabled = False
        账本ToolStripMenuItem.Enabled = False
    End Sub


    Private Sub 登录ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 登录ToolStripMenuItem.Click
        loginPanel.Visible = True
        registerPanel.Visible = False
        addressBookPanel.Visible = False
        dairyPanel.Visible = False
        accountBookPanel.Visible = False
    End Sub

    Private Sub 注册ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 注册ToolStripMenuItem.Click
        loginPanel.Visible = False
        registerPanel.Visible = True
        addressBookPanel.Visible = False
        dairyPanel.Visible = False
        accountBookPanel.Visible = False
    End Sub
    Private Sub 注销ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 注销ToolStripMenuItem.Click
        activeUser = New person("", "")
        loginPanel.Visible = True
        registerPanel.Visible = True
        addressBookPanel.Visible = False
        dairyPanel.Visible = False
        accountBookPanel.Visible = False
        登录ToolStripMenuItem.Enabled = True
        注册ToolStripMenuItem.Enabled = True
        LoginPassword.Clear()
    End Sub
    Private Sub 通讯录ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 通讯录ToolStripMenuItem.Click
        loginPanel.Visible = False
        registerPanel.Visible = False
        addressBookPanel.Visible = True
        dairyPanel.Visible = False
        accountBookPanel.Visible = False
        addressBoxListView.Items.Clear()
        initialAdr()
        For Each i In activeAddress
            Dim itemview As ListViewItem
            itemview = New ListViewItem
            itemview.SubItems.Item(0).Text = i.Name1
            itemview.SubItems.Add(i.Tel1)
            itemview.SubItems.Add(i.Email1)
            itemview.SubItems.Add(i.Adr1)
            addressBoxListView.Items.Add(itemview)
        Next
    End Sub

    Private Sub 日记ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 日记ToolStripMenuItem.Click
        loginPanel.Visible = False
        registerPanel.Visible = False
        addressBookPanel.Visible = False
        dairyPanel.Visible = True
        accountBookPanel.Visible = False
        contentTextBox.Text = ""
        Dim selectedDate As String
        selectedDate = DateTimePicker1.Value.Date
        selectedDate = selectedDate.Replace("/", "-")
        If Loaddairy(selectedDate) = False Then
            Dim newdairy As FileStream
            newdairy = New FileStream(activeUser.Username1 + "\dairy\" + selectedDate + ".txt", FileMode.Create)
            newdairy.Close()
        ElseIf Loaddairy(selectedDate) = True Then
            Dim sr = New StreamReader(activeUser.Username1 + "\dairy\" + selectedDate + ".txt")
            contentTextBox.Text = sr.ReadToEnd()
            sr.Close()
        End If

    End Sub

    Private Sub 账本ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 账本ToolStripMenuItem.Click
        loginPanel.Visible = False
        registerPanel.Visible = False
        addressBookPanel.Visible = False
        dairyPanel.Visible = False
        accountBookPanel.Visible = True
        accountBoxListView.Items.Clear()
        InitialAcc()
        For Each i In activeAccount
            Dim itemview As ListViewItem
            itemview = New ListViewItem
            itemview.SubItems.Item(0).Text = i.Item1
            itemview.SubItems.Add(i.Kind1)
            itemview.SubItems.Add(i.Amount1)
            itemview.SubItems.Add(i.ConsumptionDate1)
            accountBoxListView.Items.Add(itemview)
        Next
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim username As String = LoginUsername.Text
        Dim password As String = LoginPassword.Text

        Dim sr As New StreamReader("users.txt")
        Dim exitname, exitpassword As String
        While sr.Peek <> -1
            Dim record, records() As String
            record = sr.ReadLine
            records = record.Split(",")
            exitname = records(0)
            exitpassword = records(1)
            If LoginUsername.Text = exitname And LoginPassword.Text = exitpassword Then
                MessageBox.Show("登录成功！")
                activeUser = New person(exitname, exitpassword)
                'initialAdr()
                'initialAcc()
                登录ToolStripMenuItem.Enabled = False
                注册ToolStripMenuItem.Enabled = False
                通讯录ToolStripMenuItem.Enabled = True
                日记ToolStripMenuItem.Enabled = True
                账本ToolStripMenuItem.Enabled = True
                currentUser.Text = activeUser.Username1
                accCurrentUserLabel.Text = activeUser.Username1
                sr.Close()
                Return
            End If
        End While
        MessageBox.Show("用户名密码错误！请重试!")
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click

        Dim sr As New StreamReader("users.txt")
        Dim exitname, exitpassword As String
        While sr.Peek <> -1
            Dim record, records() As String
            record = sr.ReadLine
            records = record.Split(",")
            exitname = records(0)
            exitpassword = records(1)
            If regUsername.Text = exitname And regPassword.Text = exitpassword Then
                MessageBox.Show("注册成功")
                通讯录ToolStripMenuItem.Enabled = True
                日记ToolStripMenuItem.Enabled = True
                账本ToolStripMenuItem.Enabled = True
                sr.Close()
                Return
            End If
        End While
        sr.Close()
        If regPassword.Text.Equals(regCheckPassword.Text) Then
            Dim sw As StreamWriter = File.AppendText("users.txt")
            sw.WriteLine(regUsername.Text + "," + regPassword.Text)
            sw.Close()
            Dim direct As DirectoryInfo
            Dim dairy As DirectoryInfo
            Dim add As FileStream
            Dim acc As FileStream
            direct = New DirectoryInfo(regUsername.Text)
            If direct.Exists Then
                Exit Sub
            Else
                direct.Create()
            End If

            dairy = New DirectoryInfo(regUsername.Text + "\dairy")
            If dairy.Exists Then
                Exit Sub
            Else
                dairy.Create()
            End If
            add = New FileStream(regUsername.Text + "\address.txt", FileMode.Create)
            acc = New FileStream(regUsername.Text + "\account.txt", FileMode.Create)
            add.Close()
            add.Close()
        End If
    End Sub

    Private Sub AddNewaBButton_Click(sender As Object, e As EventArgs) Handles addNewaBButton.Click
        Dim newAbName As String
        Dim newAbTel As String
        Dim newAbEmail As String
        Dim newAbAddress As String
        newAbName = aBnameTextBox.Text
        newAbTel = aBTelTextBox.Text
        newAbEmail = aBEmailTextBox.Text
        newAbAddress = aBAddressTextBox.Text
        Dim sr As StreamReader = New StreamReader(activeUser.Username1 + "\address.txt")
        While sr.Peek <> -1
            Dim record, records() As String
            record = sr.ReadLine
            records = record.Split(",")
            If records(0).Equals(newAbName) And records(1).Equals(newAbTel) And records(2).Equals(newAbEmail) And records(3).Equals(newAbAddress) Then
                MessageBox.Show("该联系人已存在。")
                sr.Close()
                Return
            End If
        End While
        sr.Close()

        Dim sw As StreamWriter = File.AppendText(activeUser.Username1 + "\address.txt")
        sw.WriteLine(newAbName + "," + newAbTel + "," + newAbEmail + "," + newAbAddress)
        sw.Close()

        Dim itemview As ListViewItem
        itemview = New ListViewItem
        itemview.SubItems.Item(0).Text = newAbName
        itemview.SubItems.Add(newAbTel)
        itemview.SubItems.Add(newAbEmail)
        itemview.SubItems.Add(newAbAddress)
        addressBoxListView.Items.Add(itemview)
        aBnameTextBox.Text = ""
        aBTelTextBox.Text = ""
        aBEmailTextBox.Text = ""
        aBAddressTextBox.Text = ""
    End Sub

    Private Sub ABDelButton_Click(sender As Object, e As EventArgs) Handles aBDelButton.Click
        For Each sl As ListViewItem In addressBoxListView.SelectedItems
            For Each i In activeAddress
                If i.Name1.Equals(addressBoxListView.SelectedItems(0).SubItems(0).Text) Then
                    activeAddress.Remove(i)
                    Return
                End If
            Next
            addressBoxListView.Items.Remove(sl)
        Next

        Call Kill(activeUser.Username1 + "\address.txt")
        Dim sw As StreamWriter = New StreamWriter(activeUser.Username1 + "\address.txt")

        For Each i In activeAddress
            sw.WriteLine(i.Name1 + "," + i.tel1 + "," + i.email1 + "," + i.adr1)
        Next
        sw.Close()
    End Sub

    Private Sub AddnewaccButton_Click(sender As Object, e As EventArgs) Handles addnewaccButton.Click
        Dim newAcItem As String
        Dim newAcAmount As String
        Dim newAcKind As String
        Dim newAbDate As String
        newAcItem = itemTextBox.Text
        newAcAmount = amountTextBox.Text
        newAcKind = inoutComboBox.Text
        newAbDate = dateTextBox.Text
        Dim sr As StreamReader = New StreamReader(activeUser.Username1 + "\account.txt")
        While sr.Peek <> -1
            Dim record, records() As String
            record = sr.ReadLine
            records = record.Split(",")
            If records(0).Equals(newAcItem) And records(1).Equals(newAcAmount) And records(2).Equals(newAcKind) And records(3).Equals(newAbDate) Then
                MessageBox.Show("该条记录已存在，请重新操作。")
                sr.Close()
                Return
            End If
        End While
        sr.Close()

        Dim sw As StreamWriter = File.AppendText(activeUser.Username1 + "\account.txt")
        sw.WriteLine(newAcItem + "," + newAcAmount + "," + newAcKind + "," + newAbDate)
        sw.Close()

        Dim itemview As ListViewItem
        itemview = New ListViewItem
        itemview.SubItems.Item(0).Text = newAcItem
        itemview.SubItems.Add(newAcAmount)
        itemview.SubItems.Add(newAcKind)
        itemview.SubItems.Add(newAbDate)
        accountBoxListView.Items.Add(itemview)
        itemTextBox.Text = ""
        amountTextBox.Text = ""
        inoutComboBox.Text = ""
        dateTextBox.Text = ""
    End Sub

    Private Sub delaccButton_Click(sender As Object, e As EventArgs) Handles delaccButton.Click
        For Each sl As ListViewItem In accountBoxListView.SelectedItems
            For Each i In activeAccount
                If i.Item1.Equals(accountBoxListView.SelectedItems(0).SubItems(0).Text) Then
                    activeAccount.Remove(i)
                    Return
                End If
            Next
            accountBoxListView.Items.Remove(sl)
        Next

        Call Kill(activeUser.Username1 + "\account.txt")
        Dim sw As StreamWriter = New StreamWriter(activeUser.Username1 + "\account.txt")

        For Each i In activeAccount
            sw.WriteLine(i.Name1 + "," + i.tel1 + "," + i.email1 + "," + i.adr1)
        Next
        sw.Close()
    End Sub

    Private Sub DairyRefreshBtn_Click(sender As Object, e As EventArgs) Handles DairyRefreshBtn.Click
        contentTextBox.Text = ""
    End Sub

    Private Sub DairySubmitBtn_Click(sender As Object, e As EventArgs) Handles DairySubmitBtn.Click

        Dim selectedDate As String
        selectedDate = DateTimePicker1.Value.Date
        selectedDate = selectedDate.Replace("/", "-")
        Dim sw As StreamWriter = New StreamWriter(activeUser.Username1 + "\dairy\" + selectedDate + ".txt")
        sw.Write(contentTextBox.Text)
        sw.Close()
        MessageBox.Show("写入成功！")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        '加载日记
        Dim selectedDate As String
        selectedDate = DateTimePicker1.Value.Date
        selectedDate = selectedDate.Replace("/", "-")
        If Loaddairy(selectedDate) = False Then
            Dim newdairy As FileStream
            newdairy = New FileStream(activeUser.Username1 + "\dairy\" + selectedDate + ".txt", FileMode.Create)
            newdairy.Close()
            contentTextBox.Text = ""
        ElseIf Loaddairy(selectedDate) = True Then
            Dim sr1 = New StreamReader(activeUser.Username1 + "\dairy\" + selectedDate + ".txt")
            contentTextBox.Text = ""
            contentTextBox.Text = sr1.ReadToEnd()
            sr1.Close()
        End If
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub accountBoxListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles accountBoxListView.SelectedIndexChanged

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub addressBoxListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles addressBoxListView.SelectedIndexChanged

    End Sub
End Class
