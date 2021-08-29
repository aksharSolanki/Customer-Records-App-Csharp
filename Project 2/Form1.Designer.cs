
namespace Project_2
{
    partial class Form1
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
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.clbMailing = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(145, 81);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(148, 22);
            this.txtLName.TabIndex = 47;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(145, 129);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.ReadOnly = true;
            this.txtAdd.Size = new System.Drawing.Size(268, 22);
            this.txtAdd.TabIndex = 46;
            this.txtAdd.TabStop = false;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(145, 27);
            this.txtFName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtFName.Multiline = true;
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(148, 30);
            this.txtFName.TabIndex = 45;
            this.txtFName.TabStop = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(31, 81);
            this.Label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(76, 16);
            this.Label6.TabIndex = 44;
            this.Label6.Text = "Last Name:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(31, 129);
            this.Label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(62, 16);
            this.Label3.TabIndex = 43;
            this.Label3.Text = "Address:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(31, 31);
            this.Label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 16);
            this.Label2.TabIndex = 42;
            this.Label2.Text = "First Name:";
            // 
            // clbMailing
            // 
            this.clbMailing.FormattingEnabled = true;
            this.clbMailing.Items.AddRange(new object[] {
            "ePost",
            "Events",
            "InfoAlerts"});
            this.clbMailing.Location = new System.Drawing.Point(36, 225);
            this.clbMailing.Margin = new System.Windows.Forms.Padding(4);
            this.clbMailing.Name = "clbMailing";
            this.clbMailing.Size = new System.Drawing.Size(135, 55);
            this.clbMailing.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Here is what you are interested in:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(311, 225);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 57);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update Address";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(349, 81);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 43);
            this.btnExit.TabIndex = 52;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(349, 27);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(65, 42);
            this.btnView.TabIndex = 51;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 300);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.clbMailing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read&Update";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLName;
        internal System.Windows.Forms.TextBox txtAdd;
        internal System.Windows.Forms.TextBox txtFName;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.CheckedListBox clbMailing;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnView;
    }
}

