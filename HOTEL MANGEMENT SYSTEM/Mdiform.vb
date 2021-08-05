Imports System.Data.SqlClient
Public Class Mdiform
    Private Sub GuestRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuestRegistrationToolStripMenuItem.Click
        GuestRegistration.Show()
    End Sub
    Private Sub UpdateRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRecordToolStripMenuItem.Click
        updateguest.Show()
    End Sub
    Private Sub DeleteRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRecordToolStripMenuItem.Click
        deleteguest.Show()
    End Sub
    Private Sub GuestCheckoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuestCheckoutToolStripMenuItem.Click
        checkout.Show()
    End Sub
    Private Sub TotalRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalRoomToolStripMenuItem.Click
        Form2.Show()
    End Sub
    Private Sub AvailableRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvailableRoomToolStripMenuItem.Click
        AvailableRoom.Show()
    End Sub
    Private Sub OccupiedRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OccupiedRoomToolStripMenuItem.Click
        Form4.Show()
    End Sub
    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        EmployeeRegistration.Show()
    End Sub
    Private Sub UpdateRecordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateRecordToolStripMenuItem1.Click
        updateemployee.Show()
    End Sub
    Private Sub DeleteRecordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteRecordToolStripMenuItem1.Click
        deleteemployee.Show()
    End Sub
    Private Sub GuestReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuestReportToolStripMenuItem.Click
        SearchbyId.Show()
    End Sub
    Private Sub EmployeeReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeReportToolStripMenuItem.Click
        EmpReport.Show()
    End Sub
    Private Sub BackupAndRecoveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupAndRecoveryToolStripMenuItem.Click
        databackup.Show()
    End Sub
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        form1.Show()
        Me.Close()
    End Sub
    Private Sub AdddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdddUserToolStripMenuItem.Click
        adduser.Show()
    End Sub
    Private Sub BillingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillingReportToolStripMenuItem.Click
        GuestBill.Show()
    End Sub
    Private Sub CloseToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem2.Click
        EmployeeBill.Show()
    End Sub
    Private Sub CloseToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem3.Click
        Searchbyemployeesalary.Show()
    End Sub
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()
    End Sub
End Class