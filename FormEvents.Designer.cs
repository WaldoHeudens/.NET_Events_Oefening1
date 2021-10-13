namespace Events_Oefening1
{
    partial class FormEvents
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
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btToevoegen = new System.Windows.Forms.Button();
            this.btLeegmaken = new System.Windows.Forms.Button();
            this.btVerwijderen = new System.Windows.Forms.Button();
            this.btToon = new System.Windows.Forms.Button();
            this.cbTekstveld = new System.Windows.Forms.CheckBox();
            this.cbMessageBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbMessage
            // 
            this.tbMessage.Enabled = false;
            this.tbMessage.Location = new System.Drawing.Point(12, 191);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(589, 23);
            this.tbMessage.TabIndex = 0;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(107, 36);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(216, 23);
            this.tbInput.TabIndex = 1;
            // 
            // btToevoegen
            // 
            this.btToevoegen.Location = new System.Drawing.Point(107, 90);
            this.btToevoegen.Name = "btToevoegen";
            this.btToevoegen.Size = new System.Drawing.Size(97, 23);
            this.btToevoegen.TabIndex = 2;
            this.btToevoegen.Text = "Toevoegen";
            this.btToevoegen.UseVisualStyleBackColor = true;
            this.btToevoegen.Click += new System.EventHandler(this.btToevoegen_Click);
            // 
            // btLeegmaken
            // 
            this.btLeegmaken.Location = new System.Drawing.Point(226, 90);
            this.btLeegmaken.Name = "btLeegmaken";
            this.btLeegmaken.Size = new System.Drawing.Size(97, 23);
            this.btLeegmaken.TabIndex = 3;
            this.btLeegmaken.Text = "Leegmaken";
            this.btLeegmaken.UseVisualStyleBackColor = true;
            this.btLeegmaken.Click += new System.EventHandler(this.btLeegmaken_Click);
            // 
            // btVerwijderen
            // 
            this.btVerwijderen.Location = new System.Drawing.Point(107, 137);
            this.btVerwijderen.Name = "btVerwijderen";
            this.btVerwijderen.Size = new System.Drawing.Size(97, 23);
            this.btVerwijderen.TabIndex = 4;
            this.btVerwijderen.Text = "Verwijderen";
            this.btVerwijderen.UseVisualStyleBackColor = true;
            this.btVerwijderen.Click += new System.EventHandler(this.btVerwijderen_Click);
            // 
            // btToon
            // 
            this.btToon.Location = new System.Drawing.Point(226, 137);
            this.btToon.Name = "btToon";
            this.btToon.Size = new System.Drawing.Size(97, 23);
            this.btToon.TabIndex = 5;
            this.btToon.Text = "Toon Inhoud";
            this.btToon.UseVisualStyleBackColor = true;
            this.btToon.Click += new System.EventHandler(this.btToon_Click);
            // 
            // cbTekstveld
            // 
            this.cbTekstveld.AutoSize = true;
            this.cbTekstveld.Location = new System.Drawing.Point(444, 93);
            this.cbTekstveld.Name = "cbTekstveld";
            this.cbTekstveld.Size = new System.Drawing.Size(157, 19);
            this.cbTekstveld.TabIndex = 6;
            this.cbTekstveld.Text = "Toon volgende (textveld)";
            this.cbTekstveld.UseVisualStyleBackColor = true;
            this.cbTekstveld.Click += new System.EventHandler(this.cbTekstveld_Click);
            // 
            // cbMessageBox
            // 
            this.cbMessageBox.AutoSize = true;
            this.cbMessageBox.Location = new System.Drawing.Point(444, 139);
            this.cbMessageBox.Name = "cbMessageBox";
            this.cbMessageBox.Size = new System.Drawing.Size(161, 19);
            this.cbMessageBox.TabIndex = 7;
            this.cbMessageBox.Text = "Toon volgende (message)";
            this.cbMessageBox.UseVisualStyleBackColor = true;
            this.cbMessageBox.Click += new System.EventHandler(this.cbMessageBox_Click);
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 225);
            this.Controls.Add(this.cbMessageBox);
            this.Controls.Add(this.cbTekstveld);
            this.Controls.Add(this.btToon);
            this.Controls.Add(this.btVerwijderen);
            this.Controls.Add(this.btLeegmaken);
            this.Controls.Add(this.btToevoegen);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.tbMessage);
            this.Name = "FormEvents";
            this.Text = "Spelen met events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btToevoegen;
        private System.Windows.Forms.Button btLeegmaken;
        private System.Windows.Forms.Button btVerwijderen;
        private System.Windows.Forms.Button btToon;
        private System.Windows.Forms.CheckBox cbTekstveld;
        private System.Windows.Forms.CheckBox cbMessageBox;
    }
}