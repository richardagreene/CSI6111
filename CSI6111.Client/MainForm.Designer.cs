namespace CSI6111.Client
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxConnection = new System.Windows.Forms.GroupBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxHost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCourse = new System.Windows.Forms.GroupBox();
            this.tbxStudentId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxEvaluationResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxResults = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbxConnection.SuspendLayout();
            this.gbxCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxConnection
            // 
            this.gbxConnection.Controls.Add(this.tbxPort);
            this.gbxConnection.Controls.Add(this.label4);
            this.gbxConnection.Controls.Add(this.tbxHost);
            this.gbxConnection.Controls.Add(this.label3);
            this.gbxConnection.Controls.Add(this.tbxPassword);
            this.gbxConnection.Controls.Add(this.tbxUsername);
            this.gbxConnection.Controls.Add(this.label2);
            this.gbxConnection.Controls.Add(this.label1);
            this.gbxConnection.Location = new System.Drawing.Point(12, 12);
            this.gbxConnection.Name = "gbxConnection";
            this.gbxConnection.Size = new System.Drawing.Size(420, 102);
            this.gbxConnection.TabIndex = 10;
            this.gbxConnection.TabStop = false;
            this.gbxConnection.Text = "Server connection";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(249, 19);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(44, 20);
            this.tbxPort.TabIndex = 18;
            this.tbxPort.Text = "9000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Port";
            // 
            // tbxHost
            // 
            this.tbxHost.Location = new System.Drawing.Point(80, 19);
            this.tbxHost.Name = "tbxHost";
            this.tbxHost.Size = new System.Drawing.Size(131, 20);
            this.tbxHost.TabIndex = 16;
            this.tbxHost.Text = "localhost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Host";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(79, 63);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(213, 20);
            this.tbxPassword.TabIndex = 13;
            this.tbxPassword.Text = "password1234!";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(79, 42);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(213, 20);
            this.tbxUsername.TabIndex = 12;
            this.tbxUsername.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // gbxCourse
            // 
            this.gbxCourse.Controls.Add(this.tbxStudentId);
            this.gbxCourse.Controls.Add(this.label7);
            this.gbxCourse.Controls.Add(this.tbxEvaluationResult);
            this.gbxCourse.Controls.Add(this.label6);
            this.gbxCourse.Controls.Add(this.label5);
            this.gbxCourse.Controls.Add(this.tbxResults);
            this.gbxCourse.Controls.Add(this.btnSend);
            this.gbxCourse.Location = new System.Drawing.Point(13, 121);
            this.gbxCourse.Name = "gbxCourse";
            this.gbxCourse.Size = new System.Drawing.Size(419, 188);
            this.gbxCourse.TabIndex = 11;
            this.gbxCourse.TabStop = false;
            this.gbxCourse.Text = "Course Information";
            // 
            // tbxStudentId
            // 
            this.tbxStudentId.Location = new System.Drawing.Point(134, 31);
            this.tbxStudentId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxStudentId.Name = "tbxStudentId";
            this.tbxStudentId.Size = new System.Drawing.Size(102, 20);
            this.tbxStudentId.TabIndex = 7;
            this.tbxStudentId.Text = "1234566871";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Student Id";
            // 
            // tbxEvaluationResult
            // 
            this.tbxEvaluationResult.Location = new System.Drawing.Point(134, 147);
            this.tbxEvaluationResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxEvaluationResult.Name = "tbxEvaluationResult";
            this.tbxEvaluationResult.Size = new System.Drawing.Size(258, 20);
            this.tbxEvaluationResult.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Evaluation Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Results (max 30)";
            // 
            // tbxResults
            // 
            this.tbxResults.Location = new System.Drawing.Point(134, 57);
            this.tbxResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxResults.Multiline = true;
            this.tbxResults.Name = "tbxResults";
            this.tbxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxResults.Size = new System.Drawing.Size(102, 86);
            this.tbxResults.TabIndex = 2;
            this.tbxResults.Text = "34\r\n34\r\n45\r\n45\r\n34\r\n34\r\n34\r\n67\r\n78\r\n56\r\n4\r\n56";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(248, 31);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(78, 109);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Evaluate";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(311, 31);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(86, 64);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 319);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.gbxCourse);
            this.Controls.Add(this.gbxConnection);
            this.Name = "MainForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbxConnection.ResumeLayout(false);
            this.gbxConnection.PerformLayout();
            this.gbxCourse.ResumeLayout(false);
            this.gbxCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxConnection;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxHost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxCourse;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbxEvaluationResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxResults;
        private System.Windows.Forms.TextBox tbxStudentId;
        private System.Windows.Forms.Label label7;
    }
}

