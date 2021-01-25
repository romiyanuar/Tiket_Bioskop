Public Class Form1

    Private Sub btnDatamaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatamaster.Click
        If (menu_Datamaster = False) Then
            BikinMenu(cldDatamaster, TabControl1, "frmDatamaster")
            menu_Datamaster = True
        Else
            x = getTabIndex(TabControl1, "frmDatamaster")
            TabControl1.SelectedTabIndex = x
        End If
    End Sub

    Private Sub btnSearchUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaksi.Click
        If (menu_Transaksi = False) Then
            BikinMenu(cldTransaksi, TabControl1, "frmTransaksi")
            menu_Transaksi = True
        Else
            x = getTabIndex(TabControl1, "frmTransaksi")
            TabControl1.SelectedTabIndex = x
        End If
    End Sub

    Private Sub TabControl1_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles TabControl1.ControlAdded
        TabControl1.SelectedTabIndex = TotalTab - 1
    End Sub

    Private Sub TabControl1_TabItemClose(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.TabStripActionEventArgs) Handles TabControl1.TabItemClose
        Dim itemToRemove As DevComponents.DotNetBar.TabItem = TabControl1.SelectedTab
        If (TotalTab > 2) Then
            TotalTab = TotalTab - 1
        Else
            TotalTab = 0
        End If


        TabControl1.Tabs.Remove(itemToRemove)
        TabControl1.Controls.Remove(itemToRemove.AttachedControl)
        TabControl1.RecalcLayout()


        If (itemToRemove.ToString = "User") Then
            menu_Datamaster = False
        ElseIf (itemToRemove.ToString = "Search") Then
            menu_Transaksi = False
        Else

        End If
    End Sub

    Private Sub TabControl1_TabItemOpen(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.TabItemOpen
        If (TotalTab = 0) Then
            TotalTab = TotalTab + 2
        Else
            TotalTab = TotalTab + 1
        End If
    End Sub


End Class