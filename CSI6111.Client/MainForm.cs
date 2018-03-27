using System;
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

        private void btnSend_Click(object sender, EventArgs e)
        {
        }

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
    }
}
