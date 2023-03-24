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

        this.lblAddUser = new System.Windows.Forms.Label();
        this.lblAddFile = new System.Windows.Forms.Label();
        this.textBoxID = new System.Windows.Forms.TextBox();
        this.textBoxUsername = new System.Windows.Forms.TextBox();
        this.textBoxPW = new System.Windows.Forms.TextBox();
        this.textBoxManualPATH = new System.Windows.Forms.TextBox();
        this.textBoxManualImg = new System.Windows.Forms.TextBox();
        this.textBoxManualName = new System.Windows.Forms.TextBox();
        this.textBoxManualID = new System.Windows.Forms.TextBox();
        this.btnAddPDF = new System.Windows.Forms.Button();
        this.btnSelectImg = new System.Windows.Forms.Button();
        this.btnSelectPDF = new System.Windows.Forms.Button();
        this.btnDeletePDF = new System.Windows.Forms.Button();
        this.btnModPDF = new System.Windows.Forms.Button();
        this.btnAddUser = new System.Windows.Forms.Button();
        this.btnModUser = new System.Windows.Forms.Button();
        this.btnDeleteUser = new System.Windows.Forms.Button();
        this.SuspendLayout();

        this.textBoxID.AutoSize = true;
        this.textBoxID.Location = new System.Drawing.Point(20, 75);
        this.textBoxID.PlaceholderText = "EMPLOYEE ID";
        this.textBoxID.Width = 325;


        this.textBoxUsername.AutoSize = true;
        this.textBoxUsername.Location = new System.Drawing.Point(20, 100);
        this.textBoxUsername.PlaceholderText = "EMPLOYEE USERNAME/NAME";
        this.textBoxUsername.Width = 325;

        this.textBoxPW.AutoSize = true;
        this.textBoxPW.Location = new System.Drawing.Point(20, 125);
        this.textBoxPW.PlaceholderText = "EMPLOYEE Password";
        this.textBoxPW.Width = 325;

        this.textBoxManualPATH.AutoSize = true;
        this.textBoxManualPATH.Location = new System.Drawing.Point(20, 275);
        this.textBoxManualPATH.PlaceholderText = "Manual PATH";
        this.textBoxManualPATH.Width = 325;

        this.textBoxManualName.AutoSize = true;
        this.textBoxManualName.Location = new System.Drawing.Point(20, 300);
        this.textBoxManualName.PlaceholderText = "Manual Name";
        this.textBoxManualName.Width = 325;

        this.textBoxManualID.AutoSize = true;
        this.textBoxManualID.Location = new System.Drawing.Point(20, 325);
        this.textBoxManualID.PlaceholderText = "Manual ID";
        this.textBoxManualID.Width = 325;

        this.textBoxManualImg.AutoSize = true;
        this.textBoxManualImg.Location = new System.Drawing.Point(20, 350);
        this.textBoxManualImg.PlaceholderText = "Manual Image PATH";
        this.textBoxManualImg.Width = 325;




        this.lblAddUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblAddUser.BackColor = Color.White;
        this.lblAddUser.Location = new System.Drawing.Point(0, 20);
        this.lblAddUser.Name = "lblAddUser";
        this.lblAddUser.Size = new System.Drawing.Size(510, 30);
        this.lblAddUser.TabIndex = 8;
        this.lblAddUser.Text = "Find/Create User";
        this.lblAddUser.TextAlign = ContentAlignment.MiddleCenter;

        this.lblAddFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.lblAddFile.BackColor = Color.White;
        this.lblAddFile.Location = new System.Drawing.Point(0, 220);
        this.lblAddFile.Name = "lblAddFile";
        this.lblAddFile.Size = new System.Drawing.Size(510, 30);
        this.lblAddFile.TabIndex = 8;
        this.lblAddFile.Text = "Find/Create Manual";
        this.lblAddFile.TextAlign = ContentAlignment.MiddleCenter;

        this.btnSelectPDF.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnSelectPDF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnSelectPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnSelectPDF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnSelectPDF.Location = new System.Drawing.Point(350, 275);
        this.btnSelectPDF.Name = "btnSelectPDF";
        this.btnSelectPDF.Size = new System.Drawing.Size(137, 23);
        this.btnSelectPDF.TabIndex = 3;
        this.btnSelectPDF.Text = "Select PDF";
        this.btnSelectPDF.UseVisualStyleBackColor = false;
        this.btnSelectPDF.Click += new System.EventHandler(this.selectfile_Click);

        this.btnSelectImg.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnSelectImg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnSelectImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnSelectImg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnSelectImg.Location = new System.Drawing.Point(350, 375);
        this.btnSelectImg.Name = "btnSelectImg";
        this.btnSelectImg.Size = new System.Drawing.Size(137, 23);
        this.btnSelectImg.TabIndex = 3;
        this.btnSelectImg.Text = "Select Image";
        this.btnSelectImg.UseVisualStyleBackColor = false;
        this.btnSelectImg.Click += new System.EventHandler(this.selectImg_Click);

        this.btnAddPDF.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnAddPDF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnAddPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnAddPDF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnAddPDF.Location = new System.Drawing.Point(350, 300);
        this.btnAddPDF.Name = "btnAddPDF";
        this.btnAddPDF.Size = new System.Drawing.Size(137, 23);
        this.btnAddPDF.TabIndex = 3;
        this.btnAddPDF.Text = "Add PDF";
        this.btnAddPDF.UseVisualStyleBackColor = false;
        this.btnAddPDF.Click += new System.EventHandler(this.btnAddPDF_Click);

        this.btnDeletePDF.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnDeletePDF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnDeletePDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnDeletePDF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnDeletePDF.Location = new System.Drawing.Point(350, 325);
        this.btnDeletePDF.Name = "btnDeletePDF";
        this.btnDeletePDF.Size = new System.Drawing.Size(137, 23);
        this.btnDeletePDF.TabIndex = 3;
        this.btnDeletePDF.Text = "Delete PDF";
        this.btnDeletePDF.UseVisualStyleBackColor = false;
        this.btnDeletePDF.Click += new System.EventHandler(this.btnDeletePDF_Click);

        this.btnModPDF.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnModPDF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnModPDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnModPDF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnModPDF.Location = new System.Drawing.Point(350, 350);
        this.btnModPDF.Name = "btnModPDF";
        this.btnModPDF.Size = new System.Drawing.Size(137, 23);
        this.btnModPDF.TabIndex = 3;
        this.btnModPDF.Text = "Modify PDF";
        this.btnModPDF.UseVisualStyleBackColor = false;
        this.btnModPDF.Click += new System.EventHandler(this.btnModPDF_Click);

        this.btnAddUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnAddUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnAddUser.Location = new System.Drawing.Point(350, 75);
        this.btnAddUser.Name = "btnAddUser";
        this.btnAddUser.Size = new System.Drawing.Size(137, 23);
        this.btnAddUser.TabIndex = 3;
        this.btnAddUser.Text = "Add User(s)";
        this.btnAddUser.UseVisualStyleBackColor = false;
        this.btnAddUser.Click += new System.EventHandler(this.btnAddUsers_Click);

        this.btnModUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnModUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnModUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnModUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnModUser.Location = new System.Drawing.Point(350, 100);
        this.btnModUser.Name = "btnModUser";
        this.btnModUser.Size = new System.Drawing.Size(137, 23);
        this.btnModUser.TabIndex = 3;
        this.btnModUser.Text = "Modify User(s)";
        this.btnModUser.UseVisualStyleBackColor = false;
        this.btnModUser.Click += new System.EventHandler(this.btnModUsers_Click);

        this.btnDeleteUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
        this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        this.btnDeleteUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnDeleteUser.Location = new System.Drawing.Point(350, 125);
        this.btnDeleteUser.Name = "btnDeleteUser";
        this.btnDeleteUser.Size = new System.Drawing.Size(137, 23);
        this.btnDeleteUser.TabIndex = 3;
        this.btnDeleteUser.Text = "Delete User(s)";
        this.btnDeleteUser.UseVisualStyleBackColor = false;
        this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUsers_Click);

        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.ColorTranslator.FromHtml("#00457c");
        this.ClientSize = new System.Drawing.Size(510, 450);
        this.Controls.Add(this.lblAddFile);
        this.Controls.Add(this.lblAddUser);
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
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "SQLite Database Management Tool";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblAddFile;
    private System.Windows.Forms.Label lblAddUser;
    private System.Windows.Forms.TextBox textBoxID;
    private System.Windows.Forms.TextBox textBoxUsername;
    private System.Windows.Forms.TextBox textBoxPW;
    private System.Windows.Forms.TextBox textBoxManualName;
    private System.Windows.Forms.TextBox textBoxManualID;
    private System.Windows.Forms.TextBox textBoxManualPATH;
    private System.Windows.Forms.TextBox textBoxManualImg;
    private System.Windows.Forms.Button btnAddPDF;
    private System.Windows.Forms.Button btnSelectImg;
    private System.Windows.Forms.Button btnAddUser;
    private System.Windows.Forms.Button btnModUser;
    private System.Windows.Forms.Button btnSelectPDF;
    private System.Windows.Forms.Button btnDeletePDF;
    private System.Windows.Forms.Button btnModPDF;
    private System.Windows.Forms.Button btnDeleteUser;
}
