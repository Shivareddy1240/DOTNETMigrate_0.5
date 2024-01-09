using System.Diagnostics;
using System.Windows.Forms;

namespace DOTNETMigrate_0._5
{
    public partial class Upgrade : Form
    {
        private Label errorSummaryLabel;
        public Upgrade()
        {
            InitializeComponent();
            InitializeErrorSummaryLabel();
            ddlTemplate.SelectedIndex = 0;
            ddlTargetFramework.SelectedIndex = 0;
        }
        private void InitializeErrorSummaryLabel()
        {
            errorSummaryLabel = new Label
            {
                ForeColor = Color.Red,
                AutoSize = true,
                Visible = false,
                Location = new Point(10, 10)
            };
            this.Controls.Add(errorSummaryLabel);
        }
        private List<string> ValidateRequiredFields()
        {
            List<string> errorMessages = new List<string>();

            if (IsTextBoxEmpty(txtUpgradeAssistantPath))
            {
                errorMessages.Add("Upgrade assistant path is required!");
            }
            if (IsTextBoxEmpty(txtSolutionPath))
            {
                errorMessages.Add("Solution path is required!");
            }
            if (IsComboBoxEmpty(ddlTemplate))
            {
                errorMessages.Add("Please select a template!");
            }
            if (IsComboBoxEmpty(ddlTargetFramework))
            {
                errorMessages.Add("Please select a target framework!");
            }
            if (IsTextBoxEmpty(txtUpgradedProjectName))
            {
                errorMessages.Add("Please provide a name to new project!");
            }

            if (ddlTemplate.Text is null)
            {
                errorMessages.Add("Template is required!");
            }
            return errorMessages;
        }

        private bool IsTextBoxEmpty(TextBox textBox)
        {
            bool isEmpty = string.IsNullOrWhiteSpace(textBox.Text);
            if (isEmpty)
            {
                errProvider.SetError(textBox, "This field is required!");
            }
            return isEmpty;
        }
        private bool IsComboBoxEmpty(ComboBox comboBox)
        {
            bool isEmpty = comboBox.SelectedIndex == 0;
            if (isEmpty)
            {
                errProvider.SetError(comboBox, "This field is required!");
            }
            return isEmpty;
        }
        private void ShowErrorSummary(List<string> errorMessages)
        {
            errorSummaryLabel.Visible = true;
            string summaryMessage = string.Join(Environment.NewLine, errorMessages);
            MessageBox.Show(summaryMessage, "Error Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpgAssPath_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgUpgAsstPath.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtUpgradeAssistantPath.Text = dlgUpgAsstPath.FileName;
            }
        }

        private void btnSolutionPath_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSoluPath.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSolutionPath.Text = dlgSoluPath.FileName;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            errorSummaryLabel.Visible=false;
            txtSolutionPath.Clear();
            txtUpgradedProjectName.Clear();
            ddlTargetFramework.SelectedIndex = 0;
            ddlTemplate.SelectedIndex = 0;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errProvider.Clear();
            List<string> errorMessages = ValidateRequiredFields();
            if (errorMessages.Count > 0)
            {
                ShowErrorSummary(errorMessages);
            }
            else
            {
                string executablePath = txtUpgradeAssistantPath.Text;
                string solutionPath = txtSolutionPath.Text;
                string operation = "SideBySide";
                string template = ddlTemplate.Text;
                string targetFramework = ddlTargetFramework.Text;

                string destination = txtUpgradedProjectName.Text;


                string arguments = $"upgrade \"{solutionPath}\" --operation \"{operation}\" --template \"{template}\" --targetFramework \"{targetFramework}\" --destination \"{destination}\"";

                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = executablePath,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    CreateNoWindow = false
                };
                try
                {
                    MessageBox.Show("Upgrade Started");
                    using (Process process = new Process())
                    {
                        process.StartInfo = processStartInfo;
                        process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);
                        process.ErrorDataReceived += (sender, e) => Console.WriteLine(e.Data);
                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();
                        process.WaitForExit();
                        MessageBox.Show("Analysis Completed");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}