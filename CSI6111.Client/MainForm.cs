using System;
using System.Linq;
using System.Windows.Forms;

namespace CSI6111.Client
{
    public partial class MainForm : Form
    {
        Connection _connection = new Connection();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Connection 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (_connection.Active && _connection.LoggedIn)
            {
                _connection.Logoff();
                _connection.Disconnect();
                SetMainFormField();
                return;
            }
            if (!_connection.Connect(tbxHost.Text, tbxPort.Text))
                MessageBox.Show("There was a problem connecting, please chech the settings and try again.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (!_connection.Login(tbxUsername.Text, tbxPassword.Text))
                MessageBox.Show("Username / Password is not correct.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);

            SetMainFormField();
        }

        /// <summary>
        /// Set up the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetMainFormField();
        }

        /// <summary>
        /// Set the fields active or not
        /// </summary>
        private void SetMainFormField()
        {
            btnConnect.Text = "Connect";
            gbxConnection.Enabled = !(_connection.Active && _connection.LoggedIn);
            gbxCourse.Enabled = _connection.Active && _connection.LoggedIn;
            if (_connection.Active && _connection.LoggedIn) {
                btnConnect.Text = "Disconnect";
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Evaluate the results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click_1(object sender, EventArgs e)
        {
            var results = tbxResults.Text.Split('\n').Select(x => int.Parse(x)).ToArray();
            var result = _connection.Evaluate(tbxStudentId.Text, results);
            tbxEvaluationResult.Text = result;
        }
    }
}
