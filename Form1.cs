using System.Data.SQLite;
namespace PM_App;

public partial class Form1 : Form
{
    private string filePath = "";
    private string filePathImg = "";
    public Form1()
    {
        InitializeComponent();
    }

    public void btnAddUsers_Click(object sender, EventArgs e)
    {
        var EmployeeID = this.textBoxID.Text;
        var EmployeeUser = this.textBoxUsername.Text;
        var EmployeePW = this.textBoxPW.Text;


        if (EmployeeID == "" || EmployeeUser == "" || EmployeePW == "")
        {
            MessageBox.Show("Please Input Data into All Fields and Submit Again", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        else
        {
            // Connection string to SQLite database file
            string connectionString = "Data Source=Users.db;Version=3;";

            // Create a new connection object
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            // INSERT INTO TMANUAL, id, info, bytes SQL
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO TUSER (PID, NAME, PW, USER) VALUES (@PID, @NAME, @PW, 0)";
                cmd.Parameters.Add(new SQLiteParameter("@PID", EmployeeID));
                cmd.Parameters.Add(new SQLiteParameter("@NAME", EmployeeUser));
                cmd.Parameters.Add(new SQLiteParameter("@PW", EmployeePW));
                cmd.ExecuteNonQuery();
            }

            connection.Close();

            textBoxID.Text = "";
            textBoxPW.Text = "";
            textBoxUsername.Text = "";
        }

    }

    public void selectfile_Click(object sender, EventArgs e)
    {
        var fileContent = string.Empty;
        filePath = string.Empty;

        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
        }

        this.textBoxManualPATH.Text = filePath;
    }

    public void selectImg_Click(object sender, EventArgs e)
    {
        var fileContent = string.Empty;
        filePathImg = string.Empty;

        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePathImg = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
        }

        this.textBoxManualImg.Text = filePathImg;
    }

    public void btnAddPDF_Click(object sender, EventArgs e)
    {
        var ManualName = this.textBoxManualName.Text;
        var ManualID = this.textBoxManualID.Text;

        if (ManualName == "" || ManualID == "" || filePath == "" || filePathImg == "")
        {

            MessageBox.Show("Please Input Data into All Fields and Submit Again", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        else
        {

            using (FileStream f = new FileStream(filePath, FileMode.Open))
            {
                using (FileStream fi = new FileStream(filePathImg, FileMode.Open))
                {

                    BinaryReader binaryReader = new BinaryReader(f);
                    var ImageData = binaryReader.ReadBytes((int)f.Length);
                    BinaryReader binaryReaderimg = new BinaryReader(fi);
                    var ImageDataImg = binaryReaderimg.ReadBytes((int)fi.Length);
                    // Connection string to SQLite database file
                    string connectionString = "Data Source=Manuals.db;Version=3;";

                    // Create a new connection object
                    SQLiteConnection connection = new SQLiteConnection(connectionString);

                    // Open the connection to the database
                    connection.Open();

                    // INSERT INTO TMANUAL, id, info, bytes SQL
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO TMANUAL (PID, NAME, DATA, IMAGE) VALUES (@PID, @NAME, @DATA, @IMAGE)";
                        cmd.Parameters.Add(new SQLiteParameter("@PID", ManualID));
                        cmd.Parameters.Add(new SQLiteParameter("@NAME", ManualName));
                        cmd.Parameters.Add(new SQLiteParameter("@DATA", ImageData));
                        cmd.Parameters.Add(new SQLiteParameter("@IMAGE", ImageDataImg));
                        cmd.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }

            textBoxManualID.Text = "";
            textBoxManualImg.Text = "";
            textBoxManualPATH.Text = "";
            textBoxManualName.Text = "";

        }

    }

    public void btnDeletePDF_Click(object sender, EventArgs e)
    {
        if (textBoxManualID.Text == "" && textBoxManualName.Text == "")
        {
            MessageBox.Show("Please Input Data into ID or Name and Submit Again", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        else
        {
            string connectionString = "Data Source=Manuals.db;Version=3;";

            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM TMANUAL WHERE PID = @PID OR NAME = @NAME";
                cmd.Parameters.AddWithValue("@PID", textBoxManualID.Text);
                cmd.Parameters.AddWithValue("@NAME", textBoxManualName.Text);
                cmd.ExecuteNonQuery();
            }

            connection.Close();

            textBoxManualID.Text = "";
            textBoxManualImg.Text = "";
            textBoxManualPATH.Text = "";
            textBoxManualName.Text = "";
        }



    }

    public void btnDeleteUsers_Click(object sender, EventArgs e)
    {
        if (textBoxID.Text == "" && textBoxUsername.Text == "")
        {
            MessageBox.Show("Please Input Data into ID or Username and Submit Again", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        else
        {
            string connectionString = "Data Source=Users.db;Version=3;";

            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM TUSER WHERE NAME = @NAME OR PID = @PID";
                cmd.Parameters.AddWithValue("@PID", textBoxID.Text);
                cmd.Parameters.AddWithValue("@NAME", textBoxUsername.Text);
                cmd.ExecuteNonQuery();
            }

            connection.Close();

            textBoxID.Text = "";
            textBoxPW.Text = "";
            textBoxUsername.Text = "";
        }

    }

    public void btnModUsers_Click(object sender, EventArgs e)
    {
        string connectionString = "Data Source=Users.db;Version=3;";
        var EmployeeID = this.textBoxID.Text;
        var EmployeeUser = this.textBoxUsername.Text;
        var EmployeePW = this.textBoxPW.Text;

        if (EmployeeID == "" || EmployeeUser == "" || EmployeePW == "")
        {
            MessageBox.Show("Please Input Data into All Fields and Submit Again", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        else
        {

            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM TUSER WHERE NAME = @NAME OR PID = @PID";
                cmd.Parameters.AddWithValue("@PID", textBoxID.Text);
                cmd.Parameters.AddWithValue("@NAME", textBoxUsername.Text);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO TUSER (PID, NAME, PW) VALUES (@PID, @NAME, @PW)";
                cmd.Parameters.Add(new SQLiteParameter("@PID", EmployeeID));
                cmd.Parameters.Add(new SQLiteParameter("@NAME", EmployeeUser));
                cmd.Parameters.Add(new SQLiteParameter("@PW", EmployeePW));
                cmd.ExecuteNonQuery();
            }

            connection.Close();

            textBoxID.Text = "";
            textBoxPW.Text = "";
            textBoxUsername.Text = "";
        }

    }

    public void btnModPDF_Click(object sender, EventArgs e)
    {
        var ManualName = this.textBoxManualName.Text;
        var ManualID = this.textBoxManualID.Text;

        if (ManualName == "" || ManualID == "" || filePath == "" || filePathImg == "")
        {

            MessageBox.Show("Please Input Data into All Fields and Submit Again", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        else
        {

            using (FileStream f = new FileStream(filePath, FileMode.Open))
            {
                using (FileStream fi = new FileStream(filePathImg, FileMode.Open))
                {
                    BinaryReader binaryReader = new BinaryReader(f);
                    var ImageData = binaryReader.ReadBytes((int)f.Length);
                    BinaryReader binaryReaderimg = new BinaryReader(fi);
                    var ImageDataImg = binaryReaderimg.ReadBytes((int)fi.Length);
                    string connectionString = "Data Source=Manuals.db;Version=3;";


                    SQLiteConnection connection = new SQLiteConnection(connectionString);

                    // Open the connection to the database
                    connection.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "DELETE FROM TMANUAL WHERE PID = @PID OR NAME = @NAME";
                        cmd.Parameters.AddWithValue("@PID", textBoxManualID.Text);
                        cmd.Parameters.AddWithValue("@NAME", textBoxManualName.Text);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "INSERT INTO TMANUAL (PID, NAME, DATA, IMAGE) VALUES (@PID, @NAME, @DATA, @IMAGE)";
                        cmd.Parameters.Add(new SQLiteParameter("@PID", ManualID));
                        cmd.Parameters.Add(new SQLiteParameter("@NAME", ManualName));
                        cmd.Parameters.Add(new SQLiteParameter("@DATA", ImageData));
                        cmd.Parameters.Add(new SQLiteParameter("@IMAGE", ImageDataImg));
                        cmd.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }

            textBoxManualID.Text = "";
            textBoxManualImg.Text = "";
            textBoxManualPATH.Text = "";
            textBoxManualName.Text = "";


        }

    }


    public void btnDeleteTask_Click(object sender, EventArgs e) {

        var EmployeeUser = this.textBoxIDTASK.Text;
        var TID = this.textBoxTID.Text;

        if (EmployeeUser == "" || TID == "")
        {
            MessageBox.Show("Please Input Data into All Fields and Submit Again", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        else
        {
            // Connection string to SQLite database file
            string connectionString = "Data Source=tasks.db;Version=3;";

            // Create a new connection object
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            // INSERT INTO TMANUAL, id, info, bytes SQL
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM task_list WHERE USERNAME = @NAME AND PID = @TID";
                cmd.Parameters.Add(new SQLiteParameter("@NAME", EmployeeUser));
                cmd.Parameters.Add(new SQLiteParameter("@TID", TID));
                cmd.ExecuteNonQuery();
            }

            connection.Close();

            textBoxIDTASK.Text = "";
            textBoxTASK.Text = "";
            textBoxDUEDATE.Text = "";
            textBoxTID.Text = "";
        }
    }

    public void btnAddTask_Click(object sender, EventArgs e) {

        var EmployeeUser = this.textBoxIDTASK.Text;
        var EmployeeTask = this.textBoxTASK.Text;
        var DueDate = this.textBoxDUEDATE.Text;
        var TID = this.textBoxTID.Text;

        if (EmployeeTask == "" || EmployeeUser == "" || DueDate == "" || TID == "")
        {
            MessageBox.Show("Please Input Data into All Fields and Submit Again", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        else
        {
            // Connection string to SQLite database file
            string connectionString = "Data Source=tasks.db;Version=3;";

            // Create a new connection object
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            // INSERT INTO TMANUAL, id, info, bytes SQL
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO task_list (PID, USERNAME, TASK, DUE_DATE) VALUES (@TID, @NAME, @TASK, @DATE)";
                cmd.Parameters.Add(new SQLiteParameter("@TID", TID));
                cmd.Parameters.Add(new SQLiteParameter("@NAME", EmployeeUser));
                cmd.Parameters.Add(new SQLiteParameter("@TASK", EmployeeTask));
                cmd.Parameters.Add(new SQLiteParameter("@DATE", DueDate));
                cmd.ExecuteNonQuery();
            }

            connection.Close();

            textBoxIDTASK.Text = "";
            textBoxTASK.Text = "";
            textBoxDUEDATE.Text = "";
            textBoxTID.Text = "";
        }
    }

    public void btnModifyTask_Click(object sender, EventArgs e) {

        var EmployeeUser = this.textBoxIDTASK.Text;
        var EmployeeTask = this.textBoxTASK.Text;
        var DueDate = this.textBoxDUEDATE.Text;
        var TID = this.textBoxTID.Text;

        if (EmployeeUser == "" || TID == "")
        {
            MessageBox.Show("Please Input TID/Task ID and Employee NAME into All Fields and Submit Again", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        else
        {
            // Connection string to SQLite database file
            string connectionString = "Data Source=tasks.db;Version=3;";

            // Create a new connection object
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            // INSERT INTO TMANUAL, id, info, bytes SQL
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM task_list WHERE USERNAME = @NAME AND PID = @TID";
                cmd.Parameters.Add(new SQLiteParameter("@NAME", EmployeeUser));
                cmd.Parameters.Add(new SQLiteParameter("@TID", TID));
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO task_list (PID, USERNAME, TASK, DUE_DATE) VALUES (@TID, @NAME, @TASK, @DATE)";
                cmd.Parameters.Add(new SQLiteParameter("@TID", TID));
                cmd.Parameters.Add(new SQLiteParameter("@NAME", EmployeeUser));
                cmd.Parameters.Add(new SQLiteParameter("@TASK", EmployeeTask));
                cmd.Parameters.Add(new SQLiteParameter("@DATE", DueDate));
                cmd.ExecuteNonQuery();
            }

            connection.Close();

            textBoxIDTASK.Text = "";
            textBoxTASK.Text = "";
            textBoxDUEDATE.Text = "";
            textBoxTID.Text = "";
        }
    }



    private void DatabaseMenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == userDatabaseMenu)
        {
            // Show component 1
            btnAddUser.Visible = true;
            btnModUser.Visible = true;
            btnDeleteUser.Visible = true;
            textBoxID.Visible = true;
            textBoxUsername.Visible = true;
            textBoxPW.Visible = true;
            lblAddUser.Visible = true;

            // Hide other components if needed
            btnAddPDF.Visible = false;
            btnModPDF.Visible = false;
            btnDeletePDF.Visible = false;
            btnSelectPDF.Visible = false;
            btnSelectImg.Visible = false;
            textBoxManualName.Visible = false;
            textBoxManualID.Visible = false;
            textBoxManualImg.Visible = false;
            textBoxManualPATH.Visible = false;
            lblAddFile.Visible = false;
            lblHome.Visible = false;
            textBoxInstruct.Visible = false;
            lblAddTask.Visible = false;
            btnAddTask.Visible = false;
            textBoxDUEDATE.Visible = false;
            textBoxIDTASK.Visible = false;
            textBoxTASK.Visible = false;
            btnDeleteTask.Visible = false;
            textBoxTID.Visible = false;
            btnModifyTask.Visible = false;


        }
        else if (e.ClickedItem == manualDatabaseMenu)
        {
            // Show component 2
            btnAddPDF.Visible = true;
            btnModPDF.Visible = true;
            btnDeletePDF.Visible = true;
            btnSelectPDF.Visible = true;
            btnSelectImg.Visible = true;
            textBoxManualName.Visible = true;
            textBoxManualID.Visible = true;
            textBoxManualImg.Visible = true;
            textBoxManualPATH.Visible = true;
            lblAddFile.Visible = true;

            // Hide other components if needed
            btnAddUser.Visible = false;
            btnModUser.Visible = false;
            btnDeleteUser.Visible = false;
            textBoxID.Visible = false;
            textBoxUsername.Visible = false;
            textBoxPW.Visible = false;
            lblAddUser.Visible = false;
            lblHome.Visible = false;
            textBoxInstruct.Visible = false;
            lblAddTask.Visible = false;
            btnAddTask.Visible = false;
            textBoxDUEDATE.Visible = false;
            textBoxIDTASK.Visible = false;
            textBoxTASK.Visible = false;
            btnDeleteTask.Visible = false;
            textBoxTID.Visible = false;
            btnModifyTask.Visible = false;

        }

        else if (e.ClickedItem == homeMenu)
        {
            btnAddUser.Visible = false;
            btnModUser.Visible = false;
            btnDeleteUser.Visible = false;
            textBoxID.Visible = false;
            textBoxUsername.Visible = false;
            textBoxPW.Visible = false;
            lblAddUser.Visible = false;

            btnAddPDF.Visible = false;
            btnModPDF.Visible = false;
            btnDeletePDF.Visible = false;
            btnSelectPDF.Visible = false;
            btnSelectImg.Visible = false;
            textBoxManualName.Visible = false;
            textBoxManualID.Visible = false;
            textBoxManualImg.Visible = false;
            textBoxManualPATH.Visible = false;
            lblAddFile.Visible = false;
            lblAddTask.Visible = false;
            btnAddTask.Visible = false;
            textBoxDUEDATE.Visible = false;
            textBoxIDTASK.Visible = false;
            textBoxTASK.Visible = false;
            btnDeleteTask.Visible = false;
            textBoxTID.Visible = false;
            btnModifyTask.Visible = false;

            lblHome.Visible = true;
            this.textBoxInstruct.Visible = true;
        }

        else if (e.ClickedItem == tasksDatabaseMenu) {

            btnAddUser.Visible = false;
            btnModUser.Visible = false;
            btnDeleteUser.Visible = false;
            textBoxID.Visible = false;
            textBoxUsername.Visible = false;
            textBoxPW.Visible = false;
            lblAddUser.Visible = false;

            btnAddPDF.Visible = false;
            btnModPDF.Visible = false;
            btnDeletePDF.Visible = false;
            btnSelectPDF.Visible = false;
            btnSelectImg.Visible = false;
            textBoxManualName.Visible = false;
            textBoxManualID.Visible = false;
            textBoxManualImg.Visible = false;
            textBoxManualPATH.Visible = false;
            lblAddFile.Visible = false;

            lblHome.Visible = false;
            this.textBoxInstruct.Visible = false;

            lblAddTask.Visible = true;
            btnAddTask.Visible = true;
            textBoxDUEDATE.Visible = true;
            textBoxIDTASK.Visible = true;
            textBoxTASK.Visible = true;
            btnDeleteTask.Visible = true;
            textBoxTID.Visible = true;
            btnModifyTask.Visible = true;
        }
    }
    
}
