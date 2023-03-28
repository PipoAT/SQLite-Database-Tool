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

        this.textBoxID.AutoSize = true;
        this.textBoxID.Location = new System.Drawing.Point(20, 75);
        this.textBoxID.PlaceholderText = "EMPLOYEE ID";
        this.textBoxID.Visible = false;
        this.textBoxID.Width = 325;


        this.textBoxUsername.AutoSize = true;
        this.textBoxUsername.Location = new System.Drawing.Point(20, 100);
        this.textBoxUsername.PlaceholderText = "EMPLOYEE USERNAME/NAME";
        this.textBoxUsername.Visible = false;
        this.textBoxUsername.Width = 325;

        this.textBoxPW.AutoSize = true;
        this.textBoxPW.Location = new System.Drawing.Point(20, 125);
        this.textBoxPW.PlaceholderText = "EMPLOYEE Password";
        this.textBoxPW.Visible = false;
        this.textBoxPW.Width = 325;

        this.textBoxManualPATH.AutoSize = true;
        this.textBoxManualPATH.Location = new System.Drawing.Point(20, 75);
        this.textBoxManualPATH.PlaceholderText = "Manual PATH";
        this.textBoxManualPATH.Visible = false;
        this.textBoxManualPATH.Width = 325;

        this.textBoxManualName.AutoSize = true;
        this.textBoxManualName.Location = new System.Drawing.Point(20, 125);
        this.textBoxManualName.PlaceholderText = "Manual Name";
        this.textBoxManualName.Visible = false;
        this.textBoxManualName.Width = 325;

        this.textBoxManualID.AutoSize = true;
        this.textBoxManualID.Location = new System.Drawing.Point(20, 150);
        this.textBoxManualID.PlaceholderText = "Manual ID";
        this.textBoxManualID.Visible = false;
        this.textBoxManualID.Width = 325;

        this.textBoxManualImg.AutoSize = true;
        this.textBoxManualImg.Location = new System.Drawing.Point(20, 100);
        this.textBoxManualImg.PlaceholderText = "Manual Image PATH";
        this.textBoxManualImg.Visible = false;
        this.textBoxManualImg.Width = 325;

        this.textBoxTID.AutoSize = true;
        this.textBoxTID.Location = new System.Drawing.Point(20, 75);
        this.textBoxTID.PlaceholderText = "TID/TASK ID";
        this.textBoxTID.Visible = false;
        this.textBoxTID.Width = 325;

        this.textBoxIDTASK.AutoSize = true;
        this.textBoxIDTASK.Location = new System.Drawing.Point(20, 100);
        this.textBoxIDTASK.PlaceholderText = "USERNAME TO APPLY TASK";
        this.textBoxIDTASK.Visible = false;
        this.textBoxIDTASK.Width = 325;

        this.textBoxTASK.AutoSize = true;
        this.textBoxTASK.Location = new System.Drawing.Point(20, 125);
        this.textBoxTASK.PlaceholderText = "TASK";
        this.textBoxTASK.Visible = false;
        this.textBoxTASK.Width = 325;

        this.textBoxDUEDATE.AutoSize = true;
        this.textBoxDUEDATE.Location = new System.Drawing.Point(20, 150);
        this.textBoxDUEDATE.PlaceholderText = "DUE DATE (YYYY-MM-DD)";
        this.textBoxDUEDATE.Visible = false;
        this.textBoxDUEDATE.Width = 325;

        this.textBoxUID.AutoSize = true;
        this.textBoxUID.Location = new System.Drawing.Point(20, 75);
        this.textBoxUID.PlaceholderText = "UPDATE ID";
        this.textBoxUID.Visible = false;
        this.textBoxUID.Width = 325;

        this.textBoxUpdateText.AutoSize = true;
        this.textBoxUpdateText.Location = new System.Drawing.Point(20, 100);
        this.textBoxUpdateText.PlaceholderText = "UPDATE TEXT";
        this.textBoxUpdateText.Visible = false;
        this.textBoxUpdateText.Width = 325;


        this.lblHome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblHome.BackColor = Color.White;
        this.lblHome.Location = new System.Drawing.Point(0, 20);
        this.lblHome.Name = "lblHome";
        this.lblHome.Size = new System.Drawing.Size(510, 35);
        this.lblHome.TabIndex = 8;
        this.lblHome.Text = "Database Management Tool";
        this.lblHome.TextAlign = ContentAlignment.MiddleCenter;
        this.lblHome.Visible = true;



        this.lblAddUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblAddUser.BackColor = Color.White;
        this.lblAddUser.Location = new System.Drawing.Point(0, 20);
        this.lblAddUser.Name = "lblAddUser";
        this.lblAddUser.Size = new System.Drawing.Size(510, 35);
        this.lblAddUser.TabIndex = 8;
        this.lblAddUser.Text = "Modify User Database";
        this.lblAddUser.TextAlign = ContentAlignment.MiddleCenter;
        this.lblAddUser.Visible = false;

        this.lblAddFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblAddFile.BackColor = Color.White;
        this.lblAddFile.Location = new System.Drawing.Point(0, 20);
        this.lblAddFile.Name = "lblAddFile";
        this.lblAddFile.Size = new System.Drawing.Size(510, 35);
        this.lblAddFile.TabIndex = 8;
        this.lblAddFile.Text = "Modify Manual Database";
        this.lblAddFile.TextAlign = ContentAlignment.MiddleCenter;
        this.lblAddFile.Visible = false;

        this.lblAddTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblAddTask.BackColor = Color.White;
        this.lblAddTask.Location = new System.Drawing.Point(0, 20);
        this.lblAddTask.Name = "lblAddTask";
        this.lblAddTask.Size = new System.Drawing.Size(510, 35);
        this.lblAddTask.TabIndex = 8;
        this.lblAddTask.Text = "Modify Tasks Database";
        this.lblAddTask.TextAlign = ContentAlignment.MiddleCenter;
        this.lblAddTask.Visible = false;

        this.lblUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblUpdate.BackColor = Color.White;
        this.lblUpdate.Location = new System.Drawing.Point(0, 20);
        this.lblUpdate.Name = "lblUpdate";
        this.lblUpdate.Size = new System.Drawing.Size(510, 35);
        this.lblUpdate.TabIndex = 8;
        this.lblUpdate.Text = "Modify Update Database";
        this.lblUpdate.TextAlign = ContentAlignment.MiddleCenter;
        this.lblUpdate.Visible = false;

        this.btnSelectPDF.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnSelectPDF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnSelectPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnSelectPDF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnSelectPDF.Location = new System.Drawing.Point(350, 75);
        this.btnSelectPDF.Name = "btnSelectPDF";
        this.btnSelectPDF.Size = new System.Drawing.Size(137, 20);
        this.btnSelectPDF.TabIndex = 3;
        this.btnSelectPDF.Text = "Select PDF";
        this.btnSelectPDF.Visible = false;
        this.btnSelectPDF.Click += new System.EventHandler(this.selectfile_Click);

        this.btnSelectImg.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnSelectImg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnSelectImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnSelectImg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnSelectImg.Location = new System.Drawing.Point(350, 100);
        this.btnSelectImg.Name = "btnSelectImg";
        this.btnSelectImg.Size = new System.Drawing.Size(137, 20);
        this.btnSelectImg.TabIndex = 3;
        this.btnSelectImg.Text = "Select Image";
        this.btnSelectImg.UseVisualStyleBackColor = false;
        this.btnSelectImg.Visible = false;
        this.btnSelectImg.Click += new System.EventHandler(this.selectImg_Click);

        this.btnAddPDF.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnAddPDF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnAddPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnAddPDF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnAddPDF.Location = new System.Drawing.Point(350, 125);
        this.btnAddPDF.Name = "btnAddPDF";
        this.btnAddPDF.Size = new System.Drawing.Size(137, 20);
        this.btnAddPDF.TabIndex = 3;
        this.btnAddPDF.Text = "Add PDF";
        this.btnAddPDF.UseVisualStyleBackColor = false;
        this.btnAddPDF.Visible = false;
        this.btnAddPDF.Click += new System.EventHandler(this.btnAddPDF_Click);

        this.btnDeletePDF.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnDeletePDF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnDeletePDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnDeletePDF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnDeletePDF.Location = new System.Drawing.Point(350, 175);
        this.btnDeletePDF.Name = "btnDeletePDF";
        this.btnDeletePDF.Size = new System.Drawing.Size(137, 20);
        this.btnDeletePDF.TabIndex = 3;
        this.btnDeletePDF.Text = "Delete PDF";
        this.btnDeletePDF.UseVisualStyleBackColor = false;
        this.btnDeletePDF.Visible = false;
        this.btnDeletePDF.Click += new System.EventHandler(this.btnDeletePDF_Click);

        this.btnModPDF.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnModPDF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnModPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnModPDF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnModPDF.Location = new System.Drawing.Point(350, 150);
        this.btnModPDF.Name = "btnModPDF";
        this.btnModPDF.Size = new System.Drawing.Size(137, 20);
        this.btnModPDF.TabIndex = 3;
        this.btnModPDF.Text = "Modify PDF";
        this.btnModPDF.UseVisualStyleBackColor = false;
        this.btnModPDF.Visible = false;
        this.btnModPDF.Click += new System.EventHandler(this.btnModPDF_Click);

        this.btnAddUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnAddUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnAddUser.Location = new System.Drawing.Point(350, 75);
        this.btnAddUser.Name = "btnAddUser";
        this.btnAddUser.Size = new System.Drawing.Size(137, 20);
        this.btnAddUser.TabIndex = 3;
        this.btnAddUser.Text = "Add User(s)";
        this.btnAddUser.UseVisualStyleBackColor = false;
        this.btnAddUser.Visible = false;
        this.btnAddUser.Click += new System.EventHandler(this.btnAddUsers_Click);

        this.btnModUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnModUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnModUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnModUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnModUser.Location = new System.Drawing.Point(350, 100);
        this.btnModUser.Name = "btnModUser";
        this.btnModUser.Size = new System.Drawing.Size(137, 20);
        this.btnModUser.TabIndex = 3;
        this.btnModUser.Text = "Modify User(s)";
        this.btnModUser.UseVisualStyleBackColor = false;
        this.btnModUser.Visible = false;
        this.btnModUser.Click += new System.EventHandler(this.btnModUsers_Click);

        this.btnDeleteUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnDeleteUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnDeleteUser.Location = new System.Drawing.Point(350, 125);
        this.btnDeleteUser.Name = "btnDeleteUser";
        this.btnDeleteUser.Size = new System.Drawing.Size(137, 20);
        this.btnDeleteUser.TabIndex = 3;
        this.btnDeleteUser.Text = "Delete User(s)";
        this.btnDeleteUser.UseVisualStyleBackColor = false;
        this.btnDeleteUser.Visible = false;
        this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUsers_Click);

        this.btnAddTask.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnAddTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnAddTask.Location = new System.Drawing.Point(350, 75);
        this.btnAddTask.Name = "btnAddTask";
        this.btnAddTask.Size = new System.Drawing.Size(137, 20);
        this.btnAddTask.TabIndex = 3;
        this.btnAddTask.Text = "Add Task";
        this.btnAddTask.UseVisualStyleBackColor = false;
        this.btnAddTask.Visible = false;
        this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);

        this.btnModifyTask.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnModifyTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnModifyTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnModifyTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnModifyTask.Location = new System.Drawing.Point(350, 100);
        this.btnModifyTask.Name = "btnModifyTask";
        this.btnModifyTask.Size = new System.Drawing.Size(137, 20);
        this.btnModifyTask.TabIndex = 3;
        this.btnModifyTask.Text = "Modify Task";
        this.btnModifyTask.UseVisualStyleBackColor = false;
        this.btnModifyTask.Visible = false;
        this.btnModifyTask.Click += new System.EventHandler(this.btnModifyTask_Click);

        this.btnDeleteTask.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnDeleteTask.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnDeleteTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnDeleteTask.Location = new System.Drawing.Point(350, 125);
        this.btnDeleteTask.Name = "btnDeleteTask";
        this.btnDeleteTask.Size = new System.Drawing.Size(137, 20);
        this.btnDeleteTask.TabIndex = 3;
        this.btnDeleteTask.Text = "Delete Task";
        this.btnDeleteTask.UseVisualStyleBackColor = false;
        this.btnDeleteTask.Visible = false;
        this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);

        this.btnAddUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnAddUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnAddUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnAddUpdate.Location = new System.Drawing.Point(350, 75);
        this.btnAddUpdate.Name = "btnAddUpdate";
        this.btnAddUpdate.Size = new System.Drawing.Size(137, 20);
        this.btnAddUpdate.TabIndex = 3;
        this.btnAddUpdate.Text = "Add Update";
        this.btnAddUpdate.UseVisualStyleBackColor = false;
        this.btnAddUpdate.Visible = false;
        this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);

        this.btnDeleteUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnDeleteUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnDeleteUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnDeleteUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnDeleteUpdate.Location = new System.Drawing.Point(350, 125);
        this.btnDeleteUpdate.Name = "btnDeleteUpdate";
        this.btnDeleteUpdate.Size = new System.Drawing.Size(137, 20);
        this.btnDeleteUpdate.TabIndex = 3;
        this.btnDeleteUpdate.Text = "Delete Update";
        this.btnDeleteUpdate.UseVisualStyleBackColor = false;
        this.btnDeleteUpdate.Visible = false;
        this.btnDeleteUpdate.Click += new System.EventHandler(this.btnDeleteUpdate_Click);

        this.btnModUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnModUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnModUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnModUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnModUpdate.Location = new System.Drawing.Point(350, 100);
        this.btnModUpdate.Name = "btnModUpdate";
        this.btnModUpdate.Size = new System.Drawing.Size(137, 20);
        this.btnModUpdate.TabIndex = 3;
        this.btnModUpdate.Text = "Modify Update";
        this.btnModUpdate.UseVisualStyleBackColor = false;
        this.btnModUpdate.Visible = false;
        this.btnModUpdate.Click += new System.EventHandler(this.btnModUpdate_Click);

        // 
        // Form1
        // 
        menuStrip.Parent = this;
        this.menuStrip.Items.AddRange(new ToolStripItem[] { homeMenu, userDatabaseMenu, manualDatabaseMenu, tasksDatabaseMenu, updateDatabaseMenu});
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
