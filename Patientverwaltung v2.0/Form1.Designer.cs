﻿namespace Patientverwaltung_v2._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnTermine = new System.Windows.Forms.Button();
            this.btnPatienten = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPatient = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.panelTermine = new System.Windows.Forms.Panel();
            this.dataGridViewTermine = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            this.panelTermine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermine)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LeftPanel.Controls.Add(this.SidePanel);
            this.LeftPanel.Controls.Add(this.btnNewPatient);
            this.LeftPanel.Controls.Add(this.btnLogin);
            this.LeftPanel.Controls.Add(this.btnTermine);
            this.LeftPanel.Controls.Add(this.btnPatienten);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(202, 585);
            this.LeftPanel.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.OliveDrab;
            this.SidePanel.Location = new System.Drawing.Point(3, 44);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 57);
            this.SidePanel.TabIndex = 3;
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.FlatAppearance.BorderSize = 0;
            this.btnNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPatient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewPatient.ForeColor = System.Drawing.Color.White;
            this.btnNewPatient.Location = new System.Drawing.Point(12, 233);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(190, 57);
            this.btnNewPatient.TabIndex = 3;
            this.btnNewPatient.Text = "New patient";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            this.btnNewPatient.Click += new System.EventHandler(this.btnNewPatient_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(12, 170);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(190, 57);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Info";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnTermine
            // 
            this.btnTermine.FlatAppearance.BorderSize = 0;
            this.btnTermine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTermine.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTermine.ForeColor = System.Drawing.Color.White;
            this.btnTermine.Location = new System.Drawing.Point(12, 107);
            this.btnTermine.Name = "btnTermine";
            this.btnTermine.Size = new System.Drawing.Size(190, 57);
            this.btnTermine.TabIndex = 1;
            this.btnTermine.Text = "Termine";
            this.btnTermine.UseVisualStyleBackColor = true;
            this.btnTermine.Click += new System.EventHandler(this.btnTermine_Click);
            // 
            // btnPatienten
            // 
            this.btnPatienten.FlatAppearance.BorderSize = 0;
            this.btnPatienten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatienten.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPatienten.ForeColor = System.Drawing.Color.White;
            this.btnPatienten.Location = new System.Drawing.Point(12, 44);
            this.btnPatienten.Name = "btnPatienten";
            this.btnPatienten.Size = new System.Drawing.Size(190, 57);
            this.btnPatienten.TabIndex = 0;
            this.btnPatienten.Text = "Patienten";
            this.btnPatienten.UseVisualStyleBackColor = true;
            this.btnPatienten.Click += new System.EventHandler(this.btnPatienten_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(202, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OliveDrab;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(275, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(106, 94);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(390, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patientenverwaltung";
            // 
            // panelPatient
            // 
            this.panelPatient.Controls.Add(this.button3);
            this.panelPatient.Controls.Add(this.button2);
            this.panelPatient.Controls.Add(this.button1);
            this.panelPatient.Controls.Add(this.dataGridViewPatient);
            this.panelPatient.Location = new System.Drawing.Point(202, 153);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(776, 410);
            this.panelPatient.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bearbeiten";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatient.Location = new System.Drawing.Point(3, 36);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.Size = new System.Drawing.Size(764, 298);
            this.dataGridViewPatient.TabIndex = 0;
            // 
            // panelTermine
            // 
            this.panelTermine.Controls.Add(this.dataGridViewTermine);
            this.panelTermine.Location = new System.Drawing.Point(230, 107);
            this.panelTermine.Name = "panelTermine";
            this.panelTermine.Size = new System.Drawing.Size(776, 407);
            this.panelTermine.TabIndex = 2;
            // 
            // dataGridViewTermine
            // 
            this.dataGridViewTermine.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTermine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTermine.Location = new System.Drawing.Point(3, 52);
            this.dataGridViewTermine.Name = "dataGridViewTermine";
            this.dataGridViewTermine.Size = new System.Drawing.Size(767, 291);
            this.dataGridViewTermine.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(66, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 585);
            this.Controls.Add(this.panelTermine);
            this.Controls.Add(this.panelPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LeftPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LeftPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            this.panelTermine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTermine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPatienten;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnTermine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.Panel panelTermine;
        private System.Windows.Forms.DataGridView dataGridViewTermine;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

