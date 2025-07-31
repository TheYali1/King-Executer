using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WeAreDevs_API
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();

        [DllImport("wearedevs_exploit_api.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte initialize();

        [DllImport("wearedevs_exploit_api.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool isAttached();

        [DllImport("wearedevs_exploit_api.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void execute([MarshalAs(UnmanagedType.LPStr)] string script);


        public Form1()
        {
            InitializeComponent();
            AllocConsole();
            initialize();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string script = txtScript.Text;
            execute(script);
        }

        private void timerAttachChecker_Tick(object sender, EventArgs e)
        {
            bool attached = isAttached();
            if (attached)
            {
                labelStatus.Text = "Status: Attached (injected!)";
                labelStatus.ForeColor = Color.Green;
            }
            else
            {
                labelStatus.Text = "Status: Not attached (Join a game)";
                labelStatus.ForeColor = Color.Red;
            }
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtScript.Text = "";
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Luau Files (*.luau)|*.luau|" +
                                        "Lua Files (*.lua)|*.lua|" +
                                        "Text Files (*.txt)|*.txt|" +
                                        "All Files (*.*)|*.*";

                openFileDialog.FilterIndex = 3;

                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = openFileDialog.FileName;

                        string fileExtension = Path.GetExtension(filePath).ToLower();

                        if (fileExtension == ".txt")
                        {
                            txtScript.Text = File.ReadAllText(filePath);
                            MessageBox.Show("Text file loaded successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"A {fileExtension} file was selected. It will not be loaded into 'txtScript' as it's not a text file.", "Heads Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtScript.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading the file: {ex.Message}", "File Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtScript.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("No file was selected.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtScript.Text = "";
                }
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtScript.Text))
            {
                MessageBox.Show("No text to save in txtScript.", "Nothing to Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".lua";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;
            saveFileDialog.Filter = "Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
            saveFileDialog.DefaultExt = "lua";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, txtScript.Text);
                    MessageBox.Show($"File saved successfully to:\n{filePath}", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the file: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File save canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ScriptHub_Click(object sender, EventArgs e)
        {
            string url = "https://scriptblox.com/";

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Couldn't open the link: {ex.Message}", "Link Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}