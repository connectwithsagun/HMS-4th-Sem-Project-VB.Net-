Public Class Help
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If e.Node.Name = "Node1" Then
            RichTextBox1.Text = "Hotel Management Syatem,is a software where we can keep the all kinds of record in a systematic way with proper security and backup & recovery facility of the database.  " +
                "It is very helpfull for the hotel where many records are occurred and they need to keep it safely.It is very user friendly system."
        ElseIf e.Node.Name = "Node2" Then
            RichTextBox1.Text = "   Form1,it is a login form where a person who have the authority(username and password) they access the program or software "
        ElseIf e.Node.Name = "Node3" Then
            RichTextBox1.Text = " This is a mdiparent form where all of other form are connected and there was many menuscripts which are taken different" +
                "   different components of the software."
        ElseIf e.Node.Name = "Node4" Then
            RichTextBox1.Text = "This is a form where the overall details of guest is recorded."
        ElseIf e.Node.Name = "Node10" Then
            RichTextBox1.Text = "In this form we can easily added the record of the guest in a proper way with lots of detailness."
        ElseIf e.Node.Name = "Node11" Then
            RichTextBox1.Text = "In this form we can easily manupulate the record of the guest like if we wants to update any field of detail of guest" +
                "here we do it,First of all we choose the guest  from datagridview which we wants to update then we update the required field ." +
                "Also if we wants to delete the record of any guest we can do it in this section by clicking on the record of the guest and click on the delete record tab "
        ElseIf e.Node.Name = "Node12" Then
            RichTextBox1.Text = "This form is used for chekout the guest.While the guest is leaved the hotel then we changed the gueststatus field by writing Leaved" +
                "Here only 3 fields are changeable that is RoomStatus,GuestStatus and CheckOutDate"
        ElseIf e.Node.Name = "Node5" Then
            RichTextBox1.Text = "In this form we can see the overall details of the room "
        ElseIf e.Node.Name = "Node13" Then
            RichTextBox1.Text = "In this section we can see the overall details of the total room"
        ElseIf e.Node.Name = "Node14" Then
            RichTextBox1.Text = "In this form we can see the details of available room in the hotel"
        ElseIf e.Node.Name = "Node15" Then
            RichTextBox1.Text = "In this form we can see the details of reserved or occupied room in the hotel"
        ElseIf e.Node.Name = "Node6" Then
            RichTextBox1.Text = "In this section we can see the overall details of the employee who have worked in this hotel"
        ElseIf e.Node.Name = "Node16" Then
            RichTextBox1.Text = "In this form we can easily added the record of the employee in a proper way with lots of detailness. "
        ElseIf e.Node.Name = "Node17" Then
            RichTextBox1.Text = "In this form we can easily update the record of the employee.First of all we choose the employee from datagridview which we wants to update " +
                "then we update the required field ."
        ElseIf e.Node.Name = "Node18" Then
            RichTextBox1.Text = "In this form we can easily delete the record of the employee.If we wants to delete the record of any employee we can do it in this section by clicking on the record of the employee and click on the delete record tab "
        ElseIf e.Node.Name = "Node19" Then
            RichTextBox1.Text = "In this form we can setup salary for employee by only inserting the employeeid then all of other components(like post,salary per month,allowances,due month etc) is calculated automatically"
        ElseIf e.Node.Name = "Node7" Then
            RichTextBox1.Text = "In this section we can see the all kinds of report(employee report,guest report,bill report)."
        ElseIf e.Node.Name = "Node20" Then
            RichTextBox1.Text = "In this form we make a bill for guest.In this form if we insert the guestid then it automatically calculate the overall transaction of the guest with including VAT,Discount etc"
        ElseIf e.Node.Name = "Node21" Then
            RichTextBox1.Text = "In this form we can easily search the record of the guest by using guestid,first name,Arrival date"
        ElseIf e.Node.Name = "Node22" Then
            RichTextBox1.Text = "In this form we can easily search the record of the employee by using guestid,first name,Join date"
        ElseIf e.Node.Name = "Node23" Then
            RichTextBox1.Text = "In this form we can easily search the record of the employee by using the salary of the employee."
        ElseIf e.Node.Name = "Node24" Then
            RichTextBox1.Text = "In this form we can easily backup and recovery the database."
        ElseIf e.Node.Name = "Node9" Then
            RichTextBox1.Text = "In this section we can logout the session and also we can add the user for accessing the system."
        ElseIf e.Node.Name = "Node25" Then
            RichTextBox1.Text = "If we click on the logout option then the  session will be logged out and appears a login form."
        ElseIf e.Node.Name = "Node26" Then
            RichTextBox1.Text = "In this form we can add the new user for accessing the system with their username and password."
        End If
    End Sub

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class