namespace Names
{
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
            lblNames = new Label();
            txtName = new TextBox();
            lstNames = new ListBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lblNames
            // 
            lblNames.AutoSize = true;
            lblNames.Location = new Point(36, 31);
            lblNames.Name = "lblNames";
            lblNames.Size = new Size(67, 25);
            lblNames.TabIndex = 0;
            lblNames.Text = "Names";
            // 
            // txtName
            // 
            txtName.Location = new Point(237, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 1;
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 25;
            lstNames.Location = new Point(36, 59);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(180, 154);
            lstNames.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(237, 96);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 304);
            Controls.Add(btnAdd);
            Controls.Add(lstNames);
            Controls.Add(txtName);
            Controls.Add(lblNames);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNames;
        private TextBox txtName;
        private ListBox lstNames;
        private Button btnAdd;
    }
}
