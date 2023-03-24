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
                cmd.CommandText = "INSERT INTO TUSER (PID, NAME, PW) VALUES (@PID, @NAME, @PW)";
                cmd.Parameters.Add(new SQLiteParameter("@PID", EmployeeID));
                cmd.Parameters.Add(new SQLiteParameter("@NAME", EmployeeUser));
                cmd.Parameters.Add(new SQLiteParameter("@PW", EmployeePW));
                cmd.ExecuteNonQuery();
            }

            connection.Close();
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
        }

    }


}
