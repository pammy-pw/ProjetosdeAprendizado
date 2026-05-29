namespace SistemaLogin
{
    partial class FormLogin
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
            label1 = new Label();
            label2 = new Label();
            btnBeta = new Button();
            txtUsername = new TextBox();
            lblusername = new Label();
            txtSenha = new TextBox();
            lblpassword = new Label();
            btnAccessSystem = new Button();
            label3 = new Label();
            label5 = new Label();
            btnNewClone = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MingLiU-ExtB", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(31, 111);
            label1.Name = "label1";
            label1.Size = new Size(243, 35);
            label1.TabIndex = 0;
            label1.Text = "MATRIX LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(79, 146);
            label2.Name = "label2";
            label2.Size = new Size(263, 12);
            label2.TabIndex = 1;
            label2.Text = "Reality is just a layer. Access the system.";
            // 
            // btnBeta
            // 
            btnBeta.FlatStyle = FlatStyle.Popup;
            btnBeta.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBeta.ForeColor = Color.Green;
            btnBeta.Location = new Point(264, 97);
            btnBeta.Name = "btnBeta";
            btnBeta.Size = new Size(45, 32);
            btnBeta.TabIndex = 2;
            btnBeta.Text = "Beta";
            btnBeta.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(64, 64, 64);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(404, 194);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(238, 27);
            txtUsername.TabIndex = 3;
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Cambria", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.ForeColor = Color.White;
            lblusername.Location = new Point(404, 174);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(68, 15);
            lblusername.TabIndex = 4;
            lblusername.Text = "username";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(64, 64, 64);
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.White;
            txtSenha.Location = new Point(404, 260);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(238, 27);
            txtSenha.TabIndex = 5;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.ForeColor = Color.White;
            lblpassword.Location = new Point(404, 243);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(62, 14);
            lblpassword.TabIndex = 6;
            lblpassword.Text = "password";
            // 
            // btnAccessSystem
            // 
            btnAccessSystem.BackColor = Color.Black;
            btnAccessSystem.FlatStyle = FlatStyle.Flat;
            btnAccessSystem.ForeColor = Color.Green;
            btnAccessSystem.Location = new Point(446, 331);
            btnAccessSystem.Name = "btnAccessSystem";
            btnAccessSystem.Size = new Size(153, 23);
            btnAccessSystem.TabIndex = 7;
            btnAccessSystem.Text = "ACCESS SYSTEM";
            btnAccessSystem.UseVisualStyleBackColor = false;
            btnAccessSystem.Click += btnAccessSystem_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(304, 471);
            label3.Name = "label3";
            label3.Size = new Size(189, 16);
            label3.TabIndex = 8;
            label3.Text = "v1.0 | dev: Pamela Everett";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Green;
            label5.Location = new Point(515, 290);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 10;
            label5.Text = "Forgot your password?";
            // 
            // btnNewClone
            // 
            btnNewClone.FlatStyle = FlatStyle.Flat;
            btnNewClone.ForeColor = Color.Green;
            btnNewClone.Location = new Point(470, 360);
            btnNewClone.Name = "btnNewClone";
            btnNewClone.Size = new Size(116, 23);
            btnNewClone.TabIndex = 11;
            btnNewClone.Text = "NEW CLONE";
            btnNewClone.UseVisualStyleBackColor = true;
            btnNewClone.Click += btnNewClone_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(793, 496);
            Controls.Add(btnNewClone);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnAccessSystem);
            Controls.Add(lblpassword);
            Controls.Add(txtSenha);
            Controls.Add(lblusername);
            Controls.Add(txtUsername);
            Controls.Add(btnBeta);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBeta;
        private TextBox txtUsername;
        private Label lblusername;
        private TextBox txtSenha;
        private Label lblpassword;
        private Button btnAccessSystem;
        private Label label3;
        private Label label5;
        private Button btnNewClone;
    }
}
