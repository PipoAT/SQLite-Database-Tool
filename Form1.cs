using System.Data.SQLite;
using System.Data;
namespace PM_App;

public partial class Form1 : Form
{
    private string filePath = "";
    private string filePathImg = "";
    private string selectedDatabasePath = "";
    private string selectedTable = "";
    private DataTable? currentTableSchema = null;
    private bool isLoadingData = false; // Flag to prevent event loops

    public static readonly List<string> acceptableFileExtensions = new List<string>()
    {
        ".jpeg", ".jpg", ".bmp", ".doc", ".docx", ".png", ".jfif", ".pdf"
    };


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
        string extension = Path.GetExtension(filePath);

        if (ManualName == "" || ManualID == "" || filePath == "" || filePathImg == "")
        {

            MessageBox.Show("Please Input Data into All Fields and Submit Again", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        else
        {
            if (acceptableFileExtensions.Contains(extension.ToLower()))
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
            else
            {
                MessageBox.Show("INVALID FILE TYPE. This application accepts .jpeg, .jpg, .bmp, .doc, .docx, .png, .jfif, .pdf", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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


    public void btnDeleteTask_Click(object sender, EventArgs e)
    {

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

    public void btnAddTask_Click(object sender, EventArgs e)
    {

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

    public void btnModifyTask_Click(object sender, EventArgs e)
    {

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

    public void btnAddUpdate_Click(object sender, EventArgs e)
    {

        var UID = textBoxUID.Text;
        var UpdateText = textBoxUpdateText.Text;

        if (UID == "" || UpdateText == "")
        {
            MessageBox.Show("Please Input Data into All Fields and Submit Again", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        else
        {
            // Connection string to SQLite database file
            string connectionString = "Data Source=updates.db;Version=3;";

            // Create a new connection object
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            // INSERT INTO TMANUAL, id, info, bytes SQL
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO updates (PID, TEXT) VALUES (@UID, @TEXT)";
                cmd.Parameters.Add(new SQLiteParameter("@UID", UID));
                cmd.Parameters.Add(new SQLiteParameter("@TEXT", UpdateText));
                cmd.ExecuteNonQuery();
            }

            connection.Close();

            textBoxUID.Text = "";
            textBoxUpdateText.Text = "";
        }

    }

    public void btnDeleteUpdate_Click(object sender, EventArgs e)
    {
        var UID = textBoxUID.Text;
        var UpdateText = textBoxUpdateText.Text;

        if (UID == "")
        {
            MessageBox.Show("Please Input Update ID and Submit Again", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        else
        {
            // Connection string to SQLite database file
            string connectionString = "Data Source=updates.db;Version=3;";

            // Create a new connection object
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            // INSERT INTO TMANUAL, id, info, bytes SQL
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM updates WHERE PID = @UID";
                cmd.Parameters.Add(new SQLiteParameter("@UID", UID));
                cmd.ExecuteNonQuery();
            }

            connection.Close();

            textBoxUID.Text = "";
            textBoxUpdateText.Text = "";
        }
    }

    public void btnModUpdate_Click(object sender, EventArgs e)
    {
        var UID = textBoxUID.Text;
        var UpdateText = textBoxUpdateText.Text;

        if (UID == "" || UpdateText == "")
        {
            MessageBox.Show("Please Input Data into All Fields and Submit Again", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        else
        {
            // Connection string to SQLite database file
            string connectionString = "Data Source=updates.db;Version=3;";

            // Create a new connection object
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            // Open the connection to the database
            connection.Open();

            // INSERT INTO TMANUAL, id, info, bytes SQL
            using (SQLiteCommand cmd = new SQLiteCommand())
            {
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM updates WHERE PID = @UID";
                cmd.Parameters.Add(new SQLiteParameter("@UID", UID));
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO updates (PID, TEXT) VALUES (@UID, @TEXT)";
                cmd.Parameters.Add(new SQLiteParameter("@UID", UID));
                cmd.Parameters.Add(new SQLiteParameter("@TEXT", UpdateText));
                cmd.ExecuteNonQuery();
            }

            connection.Close();

            textBoxUID.Text = "";
            textBoxUpdateText.Text = "";
        }
    }

    private void ShowUserControl()
    {
        btnAddUser.Visible = true;
        btnModUser.Visible = true;
        btnDeleteUser.Visible = true;
        textBoxID.Visible = true;
        textBoxUsername.Visible = true;
        textBoxPW.Visible = true;
        lblAddUser.Visible = true;
    }

    private void HideUserControl()
    {
        btnAddUser.Visible = false;
        btnModUser.Visible = false;
        btnDeleteUser.Visible = false;
        textBoxID.Visible = false;
        textBoxUsername.Visible = false;
        textBoxPW.Visible = false;
        lblAddUser.Visible = false;
    }

    private void HidePDFControl()
    {
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
    }

    private void ShowPDFControl()
    {
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
    }

    private void HideTaskControl()
    {

        lblAddTask.Visible = false;
        btnAddTask.Visible = false;
        textBoxDUEDATE.Visible = false;
        textBoxIDTASK.Visible = false;
        textBoxTASK.Visible = false;
        btnDeleteTask.Visible = false;
        textBoxTID.Visible = false;
        btnModifyTask.Visible = false;
    }

    private void ShowTaskControl()
    {
        lblAddTask.Visible = true;
        btnAddTask.Visible = true;
        textBoxDUEDATE.Visible = true;
        textBoxIDTASK.Visible = true;
        textBoxTASK.Visible = true;
        btnDeleteTask.Visible = true;
        textBoxTID.Visible = true;
        btnModifyTask.Visible = true;
    }

    private void ShowHome()
    {
        lblHome.Visible = true;
        textBoxInstruct.Visible = true;
    }

    private void HideHome()
    {
        lblHome.Visible = false;
        textBoxInstruct.Visible = false;
    }

    private void HideUpdateControl()
    {
        btnDeleteUpdate.Visible = false;
        btnAddUpdate.Visible = false;
        textBoxUID.Visible = false;
        lblUpdate.Visible = false;
        textBoxUpdateText.Visible = false;
        btnModUpdate.Visible = false;
    }

    private void ShowUpdateControl()
    {
        btnDeleteUpdate.Visible = false;
        lblUpdate.Visible = true;
        btnDeleteUpdate.Visible = true;
        btnAddUpdate.Visible = true;
        textBoxUID.Visible = true;
        textBoxUpdateText.Visible = true;
        btnModUpdate.Visible = true;
    }

    private void DatabaseMenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (e.ClickedItem == userDatabaseMenu)
        {
            ShowUserControl();
            HidePDFControl();
            HideTaskControl();
            HideHome();
            HideUpdateControl();
            HideUniversalControl();

        }
        else if (e.ClickedItem == manualDatabaseMenu)
        {

            ShowPDFControl();
            HideUserControl();
            HideTaskControl();
            HideHome();
            HideUpdateControl();
            HideUniversalControl();

        }

        else if (e.ClickedItem == homeMenu)
        {
            HideUserControl();
            HidePDFControl();
            HideTaskControl();
            ShowHome();
            HideUpdateControl();
            HideUniversalControl();
        }

        else if (e.ClickedItem == tasksDatabaseMenu)
        {

            HideUserControl();
            HidePDFControl();
            ShowTaskControl();
            HideHome();
            HideUpdateControl();
            HideUniversalControl();

        }

        else if (e.ClickedItem == updateDatabaseMenu)
        {

            HideUserControl();
            HidePDFControl();
            HideTaskControl();
            HideHome();
            ShowUpdateControl();
            HideUniversalControl();

        }

        else if (e.ClickedItem == universalDatabaseMenu)
        {

            HideUserControl();
            HidePDFControl();
            HideTaskControl();
            HideHome();
            HideUpdateControl();
            ShowUniversalControl();

        }
    }

    private void SetupTextBox(TextBox textBox, string placeholderText, int x, int y, int width, bool visible)
    {

        textBox.AutoSize = true;
        textBox.Location = new System.Drawing.Point(x, y);
        textBox.PlaceholderText = placeholderText;
        textBox.Visible = visible;
        textBox.Width = width;
    }

    private void SetLabelProperties(Label label, string text, bool visible)
    {
        label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        label.BackColor = Color.White;
        label.Location = new System.Drawing.Point(0, 20);
        label.Size = new System.Drawing.Size(510, 35);
        label.TabIndex = 8;
        label.Text = text;
        label.TextAlign = ContentAlignment.MiddleCenter;
        label.Visible = visible;
    }

    private void SetButton(Button button, int y, EventHandler clickHandler, string text)
    {
        button.BackColor = System.Drawing.SystemColors.AppWorkspace;
        button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        button.Size = new System.Drawing.Size(137, 20);
        button.UseVisualStyleBackColor = false;
        button.Visible = false;
        button.Location = new System.Drawing.Point(350, y);
        button.Click += clickHandler;
        button.Text = text;
    }

    // Universal Database Methods
    private void btnSelectDatabase_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "SQLite Database Files (*.db)|*.db|All Files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedDatabasePath = openFileDialog.FileName;
                textBoxDatabasePath.Text = selectedDatabasePath;
                LoadTablesFromDatabase();
            }
        }
    }

    private void LoadTablesFromDatabase()
    {
        if (string.IsNullOrEmpty(selectedDatabasePath))
            return;

        try
        {
            isLoadingData = true;
            comboBoxTables.Items.Clear();
            string connectionString = $"Data Source={selectedDatabasePath};Version=3;";
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                DataTable tables = connection.GetSchema("Tables");
                
                foreach (DataRow row in tables.Rows)
                {
                    string? tableName = row["TABLE_NAME"].ToString();
                    if (tableName != null && !tableName.StartsWith("sqlite_"))
                    {
                        comboBoxTables.Items.Add(tableName);
                    }
                }
                
                if (comboBoxTables.Items.Count > 0)
                {
                    comboBoxTables.SelectedIndex = 0;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading tables: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            isLoadingData = false;
        }
    }

    private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (isLoadingData || comboBoxTables.SelectedItem == null)
            return;

        try
        {
            isLoadingData = true;
            selectedTable = comboBoxTables.SelectedItem.ToString() ?? "";
            LoadTableSchema();
            LoadTableData();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            isLoadingData = false;
        }
    }

    private void LoadTableSchema()
    {
        if (string.IsNullOrEmpty(selectedDatabasePath) || string.IsNullOrEmpty(selectedTable))
            return;

        try
        {
            string connectionString = $"Data Source={selectedDatabasePath};Version=3;";
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                // Validate table exists
                if (!IsValidTable(connection, selectedTable))
                {
                    MessageBox.Show("Invalid table name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                string query = $"PRAGMA table_info([{selectedTable}])";
                
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    currentTableSchema = new DataTable();
                    currentTableSchema.Load(reader);
                }
            }
            
            GenerateDynamicFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading schema: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadTableData()
    {
        if (string.IsNullOrEmpty(selectedDatabasePath) || string.IsNullOrEmpty(selectedTable))
            return;

        try
        {
            // Temporarily remove event handler to prevent infinite loop
            dataGridViewUniversal.SelectionChanged -= dataGridViewUniversal_SelectionChanged;
            
            string connectionString = $"Data Source={selectedDatabasePath};Version=3;";
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                // Validate table exists
                if (!IsValidTable(connection, selectedTable))
                {
                    MessageBox.Show("Invalid table name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                string query = $"SELECT * FROM [{selectedTable}]";
                
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewUniversal.DataSource = dataTable;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            // Re-attach event handler
            dataGridViewUniversal.SelectionChanged += dataGridViewUniversal_SelectionChanged;
        }
    }

    private void GenerateDynamicFields()
    {
        panelDynamicFields.Controls.Clear();
        
        if (currentTableSchema == null || currentTableSchema.Rows.Count == 0)
            return;

        int yPosition = 10;
        
        foreach (DataRow row in currentTableSchema.Rows)
        {
            string columnName = row["name"].ToString() ?? "";
            string columnType = row["type"].ToString() ?? "";
            
            Label label = new Label
            {
                Text = columnName,
                Location = new Point(10, yPosition),
                Width = 150,
                AutoSize = false
            };
            
            TextBox textBox = new TextBox
            {
                Name = $"txt_{columnName}",
                PlaceholderText = $"{columnName} ({columnType})",
                Location = new Point(170, yPosition),
                Width = 200
            };
            
            panelDynamicFields.Controls.Add(label);
            panelDynamicFields.Controls.Add(textBox);
            
            yPosition += 30;
        }
    }

    private void btnUniversalAdd_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(selectedDatabasePath) || string.IsNullOrEmpty(selectedTable))
        {
            MessageBox.Show("Please select a database and table first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (isLoadingData)
        {
            MessageBox.Show("Please wait for the current operation to complete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            isLoadingData = true;
            
            List<string> columnNames = new List<string>();
            List<object> values = new List<object>();
            
            foreach (Control control in panelDynamicFields.Controls)
            {
                if (control is TextBox textBox && textBox.Name.StartsWith("txt_"))
                {
                    string columnName = textBox.Name.Substring(4);
                    
                    // Validate column name exists in schema
                    if (!IsValidColumn(columnName))
                    {
                        MessageBox.Show($"Invalid column name: {columnName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    columnNames.Add(columnName);
                    values.Add(textBox.Text);
                }
            }
            
            if (columnNames.Count == 0)
            {
                MessageBox.Show("No fields to insert.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string connectionString = $"Data Source={selectedDatabasePath};Version=3;";
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                // Validate table exists
                if (!IsValidTable(connection, selectedTable))
                {
                    MessageBox.Show("Invalid table name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // Use brackets to safely quote identifiers
                string columns = string.Join(", ", columnNames.Select(c => $"[{c}]"));
                string parameters = string.Join(", ", columnNames.Select(c => "@" + c));
                string query = $"INSERT INTO [{selectedTable}] ({columns}) VALUES ({parameters})";
                
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    for (int i = 0; i < columnNames.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@" + columnNames[i], values[i]);
                    }
                    
                    cmd.ExecuteNonQuery();
                }
            }
            
            MessageBox.Show("Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTableData();
            ClearDynamicFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error adding record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            isLoadingData = false;
        }
    }

    private void btnUniversalUpdate_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(selectedDatabasePath) || string.IsNullOrEmpty(selectedTable))
        {
            MessageBox.Show("Please select a database and table first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (isLoadingData)
        {
            MessageBox.Show("Please wait for the current operation to complete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (dataGridViewUniversal.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            isLoadingData = true;
            
            List<string> setParts = new List<string>();
            List<string> columnNames = new List<string>();
            List<object> values = new List<object>();
            
            foreach (Control control in panelDynamicFields.Controls)
            {
                if (control is TextBox textBox && textBox.Name.StartsWith("txt_") && !string.IsNullOrEmpty(textBox.Text))
                {
                    string columnName = textBox.Name.Substring(4);
                    
                    // Validate column name exists in schema
                    if (!IsValidColumn(columnName))
                    {
                        MessageBox.Show($"Invalid column name: {columnName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    setParts.Add($"[{columnName}] = @{columnName}");
                    columnNames.Add(columnName);
                    values.Add(textBox.Text);
                }
            }
            
            if (setParts.Count == 0)
            {
                MessageBox.Show("No fields to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Get primary key column
            string? pkColumn = GetPrimaryKeyColumn();
            if (pkColumn == null)
            {
                MessageBox.Show("Cannot determine primary key for this table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            DataGridViewRow selectedRow = dataGridViewUniversal.SelectedRows[0];
            if (!dataGridViewUniversal.Columns.Contains(pkColumn))
            {
                MessageBox.Show($"Primary key column '{pkColumn}' not found in data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            object? pkValue = selectedRow.Cells[pkColumn].Value;
            
            string connectionString = $"Data Source={selectedDatabasePath};Version=3;";
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                // Validate table exists
                if (!IsValidTable(connection, selectedTable))
                {
                    MessageBox.Show("Invalid table name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                string setClause = string.Join(", ", setParts);
                string query = $"UPDATE [{selectedTable}] SET {setClause} WHERE [{pkColumn}] = @whereValue";
                
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    for (int i = 0; i < columnNames.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@" + columnNames[i], values[i]);
                    }
                    
                    cmd.Parameters.AddWithValue("@whereValue", pkValue);
                    cmd.ExecuteNonQuery();
                }
            }
            
            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTableData();
            ClearDynamicFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error updating record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            isLoadingData = false;
        }
    }

    private void btnUniversalDelete_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(selectedDatabasePath) || string.IsNullOrEmpty(selectedTable))
        {
            MessageBox.Show("Please select a database and table first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (isLoadingData)
        {
            MessageBox.Show("Please wait for the current operation to complete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (dataGridViewUniversal.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DialogResult result = MessageBox.Show("Are you sure you want to delete the selected record?", 
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
        if (result != DialogResult.Yes)
            return;

        try
        {
            isLoadingData = true;
            
            // Get primary key column
            string? pkColumn = GetPrimaryKeyColumn();
            if (pkColumn == null)
            {
                MessageBox.Show("Cannot determine primary key for this table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            DataGridViewRow selectedRow = dataGridViewUniversal.SelectedRows[0];
            if (!dataGridViewUniversal.Columns.Contains(pkColumn))
            {
                MessageBox.Show($"Primary key column '{pkColumn}' not found in data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            object? pkValue = selectedRow.Cells[pkColumn].Value;
            
            string connectionString = $"Data Source={selectedDatabasePath};Version=3;";
            
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                
                // Validate table exists
                if (!IsValidTable(connection, selectedTable))
                {
                    MessageBox.Show("Invalid table name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                string query = $"DELETE FROM [{selectedTable}] WHERE [{pkColumn}] = @whereValue";
                
                using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@whereValue", pkValue);
                    cmd.ExecuteNonQuery();
                }
            }
            
            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTableData();
            ClearDynamicFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            isLoadingData = false;
        }
    }

    private void dataGridViewUniversal_SelectionChanged(object? sender, EventArgs e)
    {
        // Don't process if we're in the middle of loading data
        if (isLoadingData)
            return;

        // Don't process if no rows or columns available
        if (dataGridViewUniversal.SelectedRows.Count == 0 || 
            dataGridViewUniversal.Columns.Count == 0)
            return;

        try
        {
            DataGridViewRow selectedRow = dataGridViewUniversal.SelectedRows[0];
            
            foreach (Control control in panelDynamicFields.Controls)
            {
                if (control is TextBox textBox && textBox.Name.StartsWith("txt_"))
                {
                    string columnName = textBox.Name.Substring(4);
                    
                    if (dataGridViewUniversal.Columns.Contains(columnName))
                    {
                        object? cellValue = selectedRow.Cells[columnName].Value;
                        textBox.Text = cellValue?.ToString() ?? "";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Silently ignore errors during selection changed to prevent popup spam
            // Log or debug if needed, but don't show to user
            System.Diagnostics.Debug.WriteLine($"Selection changed error: {ex.Message}");
        }
    }

    private void ClearDynamicFields()
    {
        foreach (Control control in panelDynamicFields.Controls)
        {
            if (control is TextBox textBox)
            {
                textBox.Text = "";
            }
        }
    }

    private void btnRefreshData_Click(object sender, EventArgs e)
    {
        LoadTableData();
    }

    private bool IsValidTable(SQLiteConnection connection, string tableName)
    {
        DataTable tables = connection.GetSchema("Tables");
        foreach (DataRow row in tables.Rows)
        {
            string? existingTableName = row["TABLE_NAME"].ToString();
            if (existingTableName != null && existingTableName.Equals(tableName, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    private bool IsValidColumn(string columnName)
    {
        if (currentTableSchema == null)
            return false;
            
        foreach (DataRow row in currentTableSchema.Rows)
        {
            string? schemaColumnName = row["name"].ToString();
            if (schemaColumnName != null && schemaColumnName.Equals(columnName, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    private string? GetPrimaryKeyColumn()
    {
        if (currentTableSchema == null || currentTableSchema.Rows.Count == 0)
            return null;
            
        foreach (DataRow row in currentTableSchema.Rows)
        {
            int pk = Convert.ToInt32(row["pk"]);
            if (pk > 0)
            {
                return row["name"].ToString();
            }
        }
        
        // If no primary key is defined, return the first column as fallback
        return currentTableSchema.Rows[0]["name"].ToString();
    }

    private void HideUniversalControl()
    {
        lblUniversal.Visible = false;
        textBoxDatabasePath.Visible = false;
        btnSelectDatabase.Visible = false;
        comboBoxTables.Visible = false;
        lblTableSelect.Visible = false;
        panelDynamicFields.Visible = false;
        dataGridViewUniversal.Visible = false;
        btnUniversalAdd.Visible = false;
        btnUniversalUpdate.Visible = false;
        btnUniversalDelete.Visible = false;
        btnRefreshData.Visible = false;
    }

    private void ShowUniversalControl()
    {
        lblUniversal.Visible = true;
        textBoxDatabasePath.Visible = true;
        btnSelectDatabase.Visible = true;
        comboBoxTables.Visible = true;
        lblTableSelect.Visible = true;
        panelDynamicFields.Visible = true;
        dataGridViewUniversal.Visible = true;
        btnUniversalAdd.Visible = true;
        btnUniversalUpdate.Visible = true;
        btnUniversalDelete.Visible = true;
        btnRefreshData.Visible = true;
    }
}
