﻿
namespace HospitalMS
{
    partial class ReportForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm1));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PatientReport_btn = new System.Windows.Forms.Button();
            this.Medecines_checkBoxList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Duration_to = new HospitalMS.Custom_Controls.CustomDatePicker();
            this.Duration_From = new HospitalMS.Custom_Controls.CustomDatePicker();
            this.Conditional_Illness_txt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Patient_Id_txt = new System.Windows.Forms.TextBox();
            this.pictureNameBackground = new System.Windows.Forms.PictureBox();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNameBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.PatientReport_btn);
            this.panelContainer.Controls.Add(this.Medecines_checkBoxList);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.Duration_to);
            this.panelContainer.Controls.Add(this.Duration_From);
            this.panelContainer.Controls.Add(this.Conditional_Illness_txt);
            this.panelContainer.Controls.Add(this.pictureBox2);
            this.panelContainer.Controls.Add(this.Patient_Id_txt);
            this.panelContainer.Controls.Add(this.pictureNameBackground);
            this.panelContainer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelContainer.Location = new System.Drawing.Point(150, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(518, 538);
            this.panelContainer.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(183, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 28;
            this.label4.Text = "Medecines";
            // 
            // PatientReport_btn
            // 
            this.PatientReport_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PatientReport_btn.FlatAppearance.BorderSize = 0;
            this.PatientReport_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientReport_btn.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientReport_btn.ForeColor = System.Drawing.Color.White;
            this.PatientReport_btn.Location = new System.Drawing.Point(140, 450);
            this.PatientReport_btn.Name = "PatientReport_btn";
            this.PatientReport_btn.Size = new System.Drawing.Size(248, 35);
            this.PatientReport_btn.TabIndex = 27;
            this.PatientReport_btn.Text = "Add Report";
            this.PatientReport_btn.UseVisualStyleBackColor = false;
            // 
            // Medecines_checkBoxList
            // 
            this.Medecines_checkBoxList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.Medecines_checkBoxList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Medecines_checkBoxList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Medecines_checkBoxList.ForeColor = System.Drawing.Color.White;
            this.Medecines_checkBoxList.FormattingEnabled = true;
            this.Medecines_checkBoxList.Location = new System.Drawing.Point(129, 330);
            this.Medecines_checkBoxList.Name = "Medecines_checkBoxList";
            this.Medecines_checkBoxList.Size = new System.Drawing.Size(241, 75);
            this.Medecines_checkBoxList.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(184, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(261, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "From";
            // 
            // Duration_to
            // 
            this.Duration_to.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Duration_to.BorderSize = 0;
            this.Duration_to.Font = new System.Drawing.Font("Comic Sans MS", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Duration_to.Location = new System.Drawing.Point(298, 223);
            this.Duration_to.MinimumSize = new System.Drawing.Size(4, 35);
            this.Duration_to.Name = "Duration_to";
            this.Duration_to.Size = new System.Drawing.Size(176, 35);
            this.Duration_to.SkinColor = System.Drawing.Color.Tomato;
            this.Duration_to.TabIndex = 22;
            this.Duration_to.TextColor = System.Drawing.Color.White;
            // 
            // Duration_From
            // 
            this.Duration_From.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Duration_From.BorderSize = 0;
            this.Duration_From.Font = new System.Drawing.Font("Comic Sans MS", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Duration_From.Location = new System.Drawing.Point(79, 223);
            this.Duration_From.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.Duration_From.MinimumSize = new System.Drawing.Size(4, 35);
            this.Duration_From.Name = "Duration_From";
            this.Duration_From.Size = new System.Drawing.Size(176, 35);
            this.Duration_From.SkinColor = System.Drawing.Color.Tomato;
            this.Duration_From.TabIndex = 6;
            this.Duration_From.TextColor = System.Drawing.Color.White;
            // 
            // Conditional_Illness_txt
            // 
            this.Conditional_Illness_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.Conditional_Illness_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Conditional_Illness_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Conditional_Illness_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Conditional_Illness_txt.Location = new System.Drawing.Point(140, 112);
            this.Conditional_Illness_txt.Multiline = true;
            this.Conditional_Illness_txt.Name = "Conditional_Illness_txt";
            this.Conditional_Illness_txt.PasswordChar = '*';
            this.Conditional_Illness_txt.Size = new System.Drawing.Size(225, 25);
            this.Conditional_Illness_txt.TabIndex = 17;
            this.Conditional_Illness_txt.Text = "Conditional Illness";
            this.Conditional_Illness_txt.UseSystemPasswordChar = true;
            this.Conditional_Illness_txt.Enter += new System.EventHandler(this.Conditional_Illness_txt_Enter);
            this.Conditional_Illness_txt.Leave += new System.EventHandler(this.Conditional_Illness_txt_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(129, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(243, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // Patient_Id_txt
            // 
            this.Patient_Id_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.Patient_Id_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Patient_Id_txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Patient_Id_txt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Patient_Id_txt.Location = new System.Drawing.Point(140, 51);
            this.Patient_Id_txt.Multiline = true;
            this.Patient_Id_txt.Name = "Patient_Id_txt";
            this.Patient_Id_txt.Size = new System.Drawing.Size(225, 24);
            this.Patient_Id_txt.TabIndex = 7;
            this.Patient_Id_txt.Text = "Patient Id";
            this.Patient_Id_txt.Enter += new System.EventHandler(this.Patient_Id_txt_Enter);
            this.Patient_Id_txt.Leave += new System.EventHandler(this.Patient_Id_txt_Leave);
            // 
            // pictureNameBackground
            // 
            this.pictureNameBackground.BackColor = System.Drawing.Color.Transparent;
            this.pictureNameBackground.Image = ((System.Drawing.Image)(resources.GetObject("pictureNameBackground.Image")));
            this.pictureNameBackground.Location = new System.Drawing.Point(129, 39);
            this.pictureNameBackground.Name = "pictureNameBackground";
            this.pictureNameBackground.Size = new System.Drawing.Size(243, 45);
            this.pictureNameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNameBackground.TabIndex = 5;
            this.pictureNameBackground.TabStop = false;
            // 
            // ReportForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm1";
            this.Text = "ReportForm1";
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNameBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TextBox Conditional_Illness_txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Patient_Id_txt;
        private System.Windows.Forms.PictureBox pictureNameBackground;
        private Custom_Controls.CustomDatePicker Duration_to;
        private Custom_Controls.CustomDatePicker Duration_From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox Medecines_checkBoxList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PatientReport_btn;
    }
}