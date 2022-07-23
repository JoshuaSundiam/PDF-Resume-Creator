namespace PDF_Resume_Creator
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EducBgBox = new System.Windows.Forms.RichTextBox();
            this.PersonalInfoBox = new System.Windows.Forms.RichTextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ContactBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.SaveJsonFilebtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(104, 36);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(50, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Educational Background:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personal Information:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact No.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email Address:";
            // 
            // EducBgBox
            // 
            this.EducBgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EducBgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EducBgBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EducBgBox.Location = new System.Drawing.Point(575, 69);
            this.EducBgBox.Name = "EducBgBox";
            this.EducBgBox.Size = new System.Drawing.Size(372, 168);
            this.EducBgBox.TabIndex = 14;
            this.EducBgBox.Text = "Tertiary:\n\n\nSecondary:\n\n\nPrimary:\n";
            this.EducBgBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // PersonalInfoBox
            // 
            this.PersonalInfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PersonalInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonalInfoBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInfoBox.Location = new System.Drawing.Point(85, 169);
            this.PersonalInfoBox.Name = "PersonalInfoBox";
            this.PersonalInfoBox.Size = new System.Drawing.Size(372, 267);
            this.PersonalInfoBox.TabIndex = 15;
            this.PersonalInfoBox.Text = "Birthday:\n\nPlace of Birth:\n\nCivil Status:\n\nReligion:\n\nCitizenship:\n\nMother\'s Name" +
    ":\nOccupation:\n\nFathers Name:\nOccupation:\'";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(160, 34);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(236, 22);
            this.NameBox.TabIndex = 16;
            // 
            // ContactBox
            // 
            this.ContactBox.Location = new System.Drawing.Point(160, 67);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(236, 22);
            this.ContactBox.TabIndex = 17;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(160, 99);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(236, 22);
            this.EmailBox.TabIndex = 18;
            // 
            // SaveJsonFilebtn
            // 
            this.SaveJsonFilebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveJsonFilebtn.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveJsonFilebtn.Location = new System.Drawing.Point(658, 387);
            this.SaveJsonFilebtn.Name = "SaveJsonFilebtn";
            this.SaveJsonFilebtn.Size = new System.Drawing.Size(190, 49);
            this.SaveJsonFilebtn.TabIndex = 19;
            this.SaveJsonFilebtn.Text = "Save";
            this.SaveJsonFilebtn.UseVisualStyleBackColor = false;
            this.SaveJsonFilebtn.Click += new System.EventHandler(this.SaveJsonFilebtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(658, 456);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 49);
            this.button2.TabIndex = 20;
            this.button2.Text = "Create PDF file";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PDF_Resume_Creator.Properties.Resources.fve;
            this.ClientSize = new System.Drawing.Size(999, 564);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SaveJsonFilebtn);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PersonalInfoBox);
            this.Controls.Add(this.EducBgBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Name = "Form1";
            this.Text = "JSON file Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox EducBgBox;
        private System.Windows.Forms.RichTextBox PersonalInfoBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox ContactBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Button SaveJsonFilebtn;
        private System.Windows.Forms.Button button2;
    }
}

