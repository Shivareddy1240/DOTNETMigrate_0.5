namespace DOTNETMigrate_0._5
{
    partial class Upgrade
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
            components = new System.ComponentModel.Container();
            lblUpgradeAssistantPath = new Label();
            lblheadingAnalysis = new Label();
            btnUpgAssPath = new Button();
            txtUpgradeAssistantPath = new TextBox();
            lblSolutionPath = new Label();
            btnSolutionPath = new Button();
            txtSolutionPath = new TextBox();
            btnClear = new Button();
            btnSubmit = new Button();
            dlgUpgAsstPath = new OpenFileDialog();
            dlgSoluPath = new OpenFileDialog();
            errProvider = new ErrorProvider(components);
            fldrBrowseDestination = new FolderBrowserDialog();
            label2 = new Label();
            ddlTemplate = new ComboBox();
            lblTrgetFrmWrk = new Label();
            ddlTargetFramework = new ComboBox();
            label1 = new Label();
            txtUpgradedProjectName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // lblUpgradeAssistantPath
            // 
            lblUpgradeAssistantPath.AutoSize = true;
            lblUpgradeAssistantPath.Location = new Point(27, 58);
            lblUpgradeAssistantPath.Name = "lblUpgradeAssistantPath";
            lblUpgradeAssistantPath.Size = new Size(163, 15);
            lblUpgradeAssistantPath.TabIndex = 1;
            lblUpgradeAssistantPath.Text = "Upgrade Assistant Path(.exe)*";
            // 
            // lblheadingAnalysis
            // 
            lblheadingAnalysis.AutoSize = true;
            lblheadingAnalysis.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblheadingAnalysis.Location = new Point(27, 20);
            lblheadingAnalysis.Name = "lblheadingAnalysis";
            lblheadingAnalysis.Size = new Size(92, 26);
            lblheadingAnalysis.TabIndex = 26;
            lblheadingAnalysis.Text = "Upgrade";
            // 
            // btnUpgAssPath
            // 
            btnUpgAssPath.Location = new Point(211, 54);
            btnUpgAssPath.Name = "btnUpgAssPath";
            btnUpgAssPath.Size = new Size(75, 23);
            btnUpgAssPath.TabIndex = 27;
            btnUpgAssPath.Text = "Browse";
            btnUpgAssPath.UseVisualStyleBackColor = true;
            btnUpgAssPath.Click += btnUpgAssPath_Click;
            // 
            // txtUpgradeAssistantPath
            // 
            txtUpgradeAssistantPath.Location = new Point(313, 54);
            txtUpgradeAssistantPath.Name = "txtUpgradeAssistantPath";
            txtUpgradeAssistantPath.Size = new Size(257, 23);
            txtUpgradeAssistantPath.TabIndex = 28;
            // 
            // lblSolutionPath
            // 
            lblSolutionPath.AutoSize = true;
            lblSolutionPath.Location = new Point(27, 96);
            lblSolutionPath.Name = "lblSolutionPath";
            lblSolutionPath.Size = new Size(112, 15);
            lblSolutionPath.TabIndex = 29;
            lblSolutionPath.Text = "Solution Path (.sln)*";
            // 
            // btnSolutionPath
            // 
            btnSolutionPath.Location = new Point(211, 92);
            btnSolutionPath.Name = "btnSolutionPath";
            btnSolutionPath.Size = new Size(75, 23);
            btnSolutionPath.TabIndex = 30;
            btnSolutionPath.Text = "Browse";
            btnSolutionPath.UseVisualStyleBackColor = true;
            btnSolutionPath.Click += btnSolutionPath_Click;
            // 
            // txtSolutionPath
            // 
            txtSolutionPath.Location = new Point(313, 92);
            txtSolutionPath.Name = "txtSolutionPath";
            txtSolutionPath.Size = new Size(257, 23);
            txtSolutionPath.TabIndex = 31;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(399, 338);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 32;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(495, 338);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 33;
            btnSubmit.Text = "Upgrade";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dlgUpgAsstPath
            // 
            dlgUpgAsstPath.FileName = "dlgUpgradeAssistantFile";
            // 
            // dlgSoluPath
            // 
            dlgSoluPath.FileName = "dlgSolutionPath";
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 135);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 39;
            label2.Text = "Template";
            // 
            // ddlTemplate
            // 
            ddlTemplate.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlTemplate.FormattingEnabled = true;
            ddlTemplate.Items.AddRange(new object[] { "--Select Type--", "ASP.NET  Core MVC", "ASP.NET Core API" });
            ddlTemplate.Location = new Point(211, 132);
            ddlTemplate.Name = "ddlTemplate";
            ddlTemplate.Size = new Size(224, 23);
            ddlTemplate.TabIndex = 40;
            // 
            // lblTrgetFrmWrk
            // 
            lblTrgetFrmWrk.AutoSize = true;
            lblTrgetFrmWrk.Location = new Point(27, 178);
            lblTrgetFrmWrk.Name = "lblTrgetFrmWrk";
            lblTrgetFrmWrk.Size = new Size(101, 15);
            lblTrgetFrmWrk.TabIndex = 41;
            lblTrgetFrmWrk.Text = "Target Framework";
            // 
            // ddlTargetFramework
            // 
            ddlTargetFramework.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlTargetFramework.FormattingEnabled = true;
            ddlTargetFramework.Items.AddRange(new object[] { "--Select Target Framework--", "net6.0", "net7.0", "net8.0" });
            ddlTargetFramework.Location = new Point(211, 170);
            ddlTargetFramework.Name = "ddlTargetFramework";
            ddlTargetFramework.Size = new Size(224, 23);
            ddlTargetFramework.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 218);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 43;
            label1.Text = "Upgraded Project Name";
            // 
            // txtUpgradedProjectName
            // 
            txtUpgradedProjectName.Location = new Point(211, 216);
            txtUpgradedProjectName.Name = "txtUpgradedProjectName";
            txtUpgradedProjectName.Size = new Size(224, 23);
            txtUpgradedProjectName.TabIndex = 44;
            // 
            // Upgrade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUpgradedProjectName);
            Controls.Add(label1);
            Controls.Add(ddlTargetFramework);
            Controls.Add(lblTrgetFrmWrk);
            Controls.Add(ddlTemplate);
            Controls.Add(label2);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(txtSolutionPath);
            Controls.Add(btnSolutionPath);
            Controls.Add(lblSolutionPath);
            Controls.Add(txtUpgradeAssistantPath);
            Controls.Add(btnUpgAssPath);
            Controls.Add(lblheadingAnalysis);
            Controls.Add(lblUpgradeAssistantPath);
            Name = "Upgrade";
            Text = ".NET Migrate Tool";
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpgradeAssistantPath;
        private Label lblheadingAnalysis;
        private Button btnUpgAssPath;
        public TextBox txtUpgradeAssistantPath;
        private Label lblSolutionPath;
        private Button btnSolutionPath;
        public TextBox txtSolutionPath;
        private Button btnClear;
        private Button btnSubmit;
        private OpenFileDialog dlgUpgAsstPath;
        private OpenFileDialog dlgSoluPath;
        private ErrorProvider errProvider;
        private FolderBrowserDialog fldrBrowseDestination;
        private Label label2;
        private ComboBox ddlTemplate;
        private Label lblTrgetFrmWrk;
        private ComboBox ddlTargetFramework;
        private Label label1;
        private TextBox txtUpgradedProjectName;
    }
}