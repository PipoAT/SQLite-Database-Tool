namespace PM_App;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.menuStrip = new MenuStrip();
        this.lblAddUser = new System.Windows.Forms.Label();
        this.lblAddFile = new System.Windows.Forms.Label();
        this.lblAddTask = new System.Windows.Forms.Label();
        this.lblHome = new System.Windows.Forms.Label();
        this.lblUpdate = new System.Windows.Forms.Label();
        this.textBoxID = new System.Windows.Forms.TextBox();
        this.textBoxInstruct = new System.Windows.Forms.RichTextBox();
        this.textBoxUsername = new System.Windows.Forms.TextBox();
        this.textBoxPW = new System.Windows.Forms.TextBox();
        this.textBoxManualPATH = new System.Windows.Forms.TextBox();
        this.textBoxManualImg = new System.Windows.Forms.TextBox();
        this.textBoxManualName = new System.Windows.Forms.TextBox();
        this.textBoxManualID = new System.Windows.Forms.TextBox();
        this.textBoxIDTASK = new System.Windows.Forms.TextBox();
        this.textBoxTASK = new System.Windows.Forms.TextBox();
        this.textBoxDUEDATE = new System.Windows.Forms.TextBox();
        this.textBoxTID = new System.Windows.Forms.TextBox();
        this.textBoxUID = new System.Windows.Forms.TextBox();
        this.textBoxUpdateText = new System.Windows.Forms.TextBox();
        this.btnAddPDF = new System.Windows.Forms.Button();
        this.btnSelectImg = new System.Windows.Forms.Button();
        this.btnSelectPDF = new System.Windows.Forms.Button();
        this.btnDeletePDF = new System.Windows.Forms.Button();
        this.btnModPDF = new System.Windows.Forms.Button();
        this.btnAddUser = new System.Windows.Forms.Button();
        this.btnModUser = new System.Windows.Forms.Button();
        this.btnDeleteUser = new System.Windows.Forms.Button();
        this.btnAddTask = new System.Windows.Forms.Button();
        this.btnDeleteTask = new System.Windows.Forms.Button();
        this.btnModifyTask = new System.Windows.Forms.Button();
        this.btnAddUpdate = new System.Windows.Forms.Button();
        this.btnDeleteUpdate = new System.Windows.Forms.Button();
        this.btnModUpdate = new System.Windows.Forms.Button();
        this.SuspendLayout();

        this.homeMenu = new ToolStripMenuItem("&Home");
        this.userDatabaseMenu = new ToolStripMenuItem("&Users");
        this.manualDatabaseMenu = new ToolStripMenuItem("&Manuals");
        this.tasksDatabaseMenu = new ToolStripMenuItem("&Tasks");
        this.updateDatabaseMenu = new ToolStripMenuItem("&Updates");

        this.textBoxInstruct.AutoSize = true;
        this.textBoxInstruct.Location = new System.Drawing.Point(150, 75);
        this.textBoxInstruct.Visible = true;
        this.textBoxInstruct.ReadOnly = true;
        this.textBoxInstruct.Text = "Developed by Andrew Pipo\nVersion 1.0.0\n\nPlease select from any of the available databases to modify.";
        this.textBoxInstruct.SelectAll();
        this.textBoxInstruct.SelectionAlignment = HorizontalAlignment.Center;
        this.textBoxInstruct.DeselectAll();
        this.textBoxInstruct.Height = 100;
        this.textBoxInstruct.Width = 210;

        SetupTextBox(textBoxID, "EMPLOYEE ID", 20, 75, 325, false);
        SetupTextBox(textBoxUsername, "EMPLOYEE USERNAME/NAME", 20, 100, 325, false);
        SetupTextBox(textBoxPW, "EMPLOYEE Password", 20, 125, 325, false);
        SetupTextBox(textBoxManualPATH, "Manual PATH", 20, 75, 325, false);
        SetupTextBox(textBoxManualName, "Manual Name", 20, 125, 325, false);
        SetupTextBox(textBoxManualID, "Manual ID", 20, 150, 325, false);
        SetupTextBox(textBoxManualImg, "Manual Image PATH", 20, 100, 325, false);
        SetupTextBox(textBoxTID, "TID/TASK ID", 20, 75, 325, false);
        SetupTextBox(textBoxIDTASK, "USERNAME TO APPLY TASK", 20, 100, 325, false);
        SetupTextBox(textBoxTASK, "TASK", 20, 125, 325, false);
        SetupTextBox(textBoxDUEDATE, "DUE DATE (YYYY-MM-DD)", 20, 150, 325, false);
        SetupTextBox(textBoxUID, "UPDATE ID", 20, 75, 325, false);
        SetupTextBox(textBoxUpdateText, "UPDATE TEXT", 20, 100, 325, false);


        SetLabelProperties(lblHome, "Database Management Tool", true);
        SetLabelProperties(lblAddUser, "Modify User Database", false);
        SetLabelProperties(lblAddFile, "Modify Manual Database", false);
        SetLabelProperties(lblAddTask, "Modify Tasks Database", false);
        SetLabelProperties(lblUpdate, "Modify Update Database", false);

        
        SetButton(btnSelectPDF, 75, selectfile_Click, "Select PDF");
        SetButton(btnSelectImg, 100, selectImg_Click, "Select Image");
        SetButton(btnAddPDF, 125, btnAddPDF_Click, "Add PDF");
        SetButton(btnDeletePDF, 175, btnDeletePDF_Click, "Delete PDF");
        SetButton(btnModPDF, 150, btnModPDF_Click, "Modify PDF");
        SetButton(btnAddUser, 75, btnAddUsers_Click, "Add User");
        SetButton(btnModUser, 100, btnModUsers_Click, "Modify User");
        SetButton(btnDeleteUser, 125, btnDeleteUsers_Click, "Delete User");
        SetButton(btnAddTask, 75, btnAddTask_Click, "Add Task");
        SetButton(btnModifyTask, 100, btnModifyTask_Click, "Modify Task");
        SetButton(btnDeleteTask, 125, btnDeleteTask_Click, "Delete Task");
        SetButton(btnAddUpdate, 75, btnAddUpdate_Click, "Add Update");
        SetButton(btnModUpdate, 100, btnModUpdate_Click, "Modify Update");
        SetButton(btnDeleteUpdate, 125, btnDeleteUpdate_Click, "Delete Update");

        // 
        // Form1
        // 
        menuStrip.Parent = this;
        this.menuStrip.Items.AddRange(new ToolStripItem[] { homeMenu, userDatabaseMenu, manualDatabaseMenu, tasksDatabaseMenu, updateDatabaseMenu });
        this.MainMenuStrip = menuStrip;

        this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.DatabaseMenu_DropDownItemClicked);



        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.ColorTranslator.FromHtml("#00457c");
        this.ClientSize = new System.Drawing.Size(510, 225);
        this.Controls.Add(this.lblAddFile);
        this.Controls.Add(this.lblAddUser);
        this.Controls.Add(this.lblHome);
        this.Controls.Add(this.lblAddTask);
        this.Controls.Add(this.lblUpdate);
        this.Controls.Add(this.textBoxInstruct);
        this.Controls.Add(this.textBoxID);
        this.Controls.Add(this.textBoxUsername);
        this.Controls.Add(this.textBoxPW);
        this.Controls.Add(this.textBoxManualPATH);
        this.Controls.Add(this.textBoxManualID);
        this.Controls.Add(this.textBoxManualName);
        this.Controls.Add(this.textBoxManualImg);
        this.Controls.Add(this.btnAddPDF);
        this.Controls.Add(this.btnAddUser);
        this.Controls.Add(this.btnModUser);
        this.Controls.Add(this.btnSelectPDF);
        this.Controls.Add(this.btnDeletePDF);
        this.Controls.Add(this.btnModPDF);
        this.Controls.Add(this.btnDeleteUser);
        this.Controls.Add(this.btnSelectImg);
        this.Controls.Add(this.btnAddTask);
        this.Controls.Add(this.btnDeleteTask);
        this.Controls.Add(this.btnModifyTask);
        this.Controls.Add(this.btnAddUpdate);
        this.Controls.Add(this.btnDeleteUpdate);
        this.Controls.Add(this.textBoxIDTASK);
        this.Controls.Add(this.textBoxTASK);
        this.Controls.Add(this.textBoxDUEDATE);
        this.Controls.Add(this.textBoxTID);
        this.Controls.Add(this.textBoxUID);
        this.Controls.Add(this.textBoxUpdateText);
        this.Controls.Add(this.btnModUpdate);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        this.MaximizeBox = false;
        this.MinimizeBox = true;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "SQLite Database Management Tool";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private MenuStrip menuStrip;
    private ToolStripMenuItem homeMenu;
    private ToolStripMenuItem userDatabaseMenu;
    private ToolStripMenuItem manualDatabaseMenu;
    private ToolStripMenuItem tasksDatabaseMenu;
    private ToolStripMenuItem updateDatabaseMenu;
    private System.Windows.Forms.Label lblAddFile;
    private System.Windows.Forms.Label lblHome;
    private System.Windows.Forms.Label lblAddUser;
    private System.Windows.Forms.Label lblAddTask;
    private System.Windows.Forms.Label lblUpdate;
    private System.Windows.Forms.RichTextBox textBoxInstruct;
    private System.Windows.Forms.TextBox textBoxID;
    private System.Windows.Forms.TextBox textBoxUsername;
    private System.Windows.Forms.TextBox textBoxPW;
    private System.Windows.Forms.TextBox textBoxManualName;
    private System.Windows.Forms.TextBox textBoxManualID;
    private System.Windows.Forms.TextBox textBoxManualPATH;
    private System.Windows.Forms.TextBox textBoxManualImg;
    private System.Windows.Forms.TextBox textBoxIDTASK;
    private System.Windows.Forms.TextBox textBoxTASK;
    private System.Windows.Forms.TextBox textBoxDUEDATE;
    private System.Windows.Forms.TextBox textBoxTID;
    private System.Windows.Forms.TextBox textBoxUID;
    private System.Windows.Forms.TextBox textBoxUpdateText;
    private System.Windows.Forms.Button btnAddPDF;
    private System.Windows.Forms.Button btnSelectImg;
    private System.Windows.Forms.Button btnAddUser;
    private System.Windows.Forms.Button btnModUser;
    private System.Windows.Forms.Button btnSelectPDF;
    private System.Windows.Forms.Button btnDeletePDF;
    private System.Windows.Forms.Button btnModPDF;
    private System.Windows.Forms.Button btnDeleteUser;
    private System.Windows.Forms.Button btnAddTask;
    private System.Windows.Forms.Button btnDeleteTask;
    private System.Windows.Forms.Button btnModifyTask;
    private System.Windows.Forms.Button btnAddUpdate;
    private System.Windows.Forms.Button btnDeleteUpdate;
    private System.Windows.Forms.Button btnModUpdate;
}
