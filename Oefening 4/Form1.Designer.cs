namespace Oefening_4
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
            this.cbVoornamen = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbVoornamen
            // 
            this.cbVoornamen.FormattingEnabled = true;
            this.cbVoornamen.Location = new System.Drawing.Point(72, 73);
            this.cbVoornamen.Name = "cbVoornamen";
            this.cbVoornamen.Size = new System.Drawing.Size(121, 28);
            this.cbVoornamen.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(304, 65);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 42);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "keuzen";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Enabled = false;
            this.txtVoornaam.Location = new System.Drawing.Point(72, 155);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(100, 26);
            this.txtVoornaam.TabIndex = 2;
            this.txtVoornaam.Text = "Voornaam";
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Enabled = false;
            this.txtAchternaam.Location = new System.Drawing.Point(293, 155);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(100, 26);
            this.txtAchternaam.TabIndex = 3;
            this.txtAchternaam.Text = "Achternaam";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbVoornamen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVoornamen;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
    }
}

