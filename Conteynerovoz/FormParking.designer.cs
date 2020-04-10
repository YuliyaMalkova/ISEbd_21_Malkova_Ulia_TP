namespace WindowsFormCars
{
    partial class FormParking
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
            this.buttonSetBoat = new System.Windows.Forms.Button();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetConteynerovoz = new System.Windows.Forms.Button();
            this.groupBoxTakeBoat = new System.Windows.Forms.GroupBox();
            this.pictureBoxtakeboat = new System.Windows.Forms.PictureBox();
            this.labelConteynerovoz = new System.Windows.Forms.Label();
            this.buttonTakeBoat = new System.Windows.Forms.Button();
            this.maskedTextBoxMesto = new System.Windows.Forms.MaskedTextBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakeBoat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtakeboat)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetBoat
            // 
            this.buttonSetBoat.Location = new System.Drawing.Point(919, 12);
            this.buttonSetBoat.Name = "buttonSetBoat";
            this.buttonSetBoat.Size = new System.Drawing.Size(97, 44);
            this.buttonSetBoat.TabIndex = 0;
            this.buttonSetBoat.Text = "припарковать корабль";
            this.buttonSetBoat.UseVisualStyleBackColor = true;
            this.buttonSetBoat.Click += new System.EventHandler(this.buttonSetBoat_Click);
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(884, 618);
            this.pictureBoxParking.TabIndex = 1;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetConteynerovoz
            // 
            this.buttonSetConteynerovoz.Location = new System.Drawing.Point(919, 62);
            this.buttonSetConteynerovoz.Name = "buttonSetConteynerovoz";
            this.buttonSetConteynerovoz.Size = new System.Drawing.Size(98, 50);
            this.buttonSetConteynerovoz.TabIndex = 2;
            this.buttonSetConteynerovoz.Text = "припарковать контейнеровоз";
            this.buttonSetConteynerovoz.UseVisualStyleBackColor = true;
            // 
            // groupBoxTakeBoat
            // 
            this.groupBoxTakeBoat.Controls.Add(this.pictureBoxtakeboat);
            this.groupBoxTakeBoat.Controls.Add(this.labelConteynerovoz);
            this.groupBoxTakeBoat.Controls.Add(this.buttonTakeBoat);
            this.groupBoxTakeBoat.Controls.Add(this.maskedTextBoxMesto);
            this.groupBoxTakeBoat.Location = new System.Drawing.Point(890, 274);
            this.groupBoxTakeBoat.Name = "groupBoxTakeBoat";
            this.groupBoxTakeBoat.Size = new System.Drawing.Size(315, 344);
            this.groupBoxTakeBoat.TabIndex = 3;
            this.groupBoxTakeBoat.TabStop = false;
            this.groupBoxTakeBoat.Text = "забрать судно";
            // 
            // pictureBoxtakeboat
            // 
            this.pictureBoxtakeboat.Location = new System.Drawing.Point(0, 92);
            this.pictureBoxtakeboat.Name = "pictureBoxtakeboat";
            this.pictureBoxtakeboat.Size = new System.Drawing.Size(309, 214);
            this.pictureBoxtakeboat.TabIndex = 3;
            this.pictureBoxtakeboat.TabStop = false;
            // 
            // labelConteynerovoz
            // 
            this.labelConteynerovoz.AutoSize = true;
            this.labelConteynerovoz.Location = new System.Drawing.Point(100, 16);
            this.labelConteynerovoz.Name = "labelConteynerovoz";
            this.labelConteynerovoz.Size = new System.Drawing.Size(41, 13);
            this.labelConteynerovoz.TabIndex = 2;
            this.labelConteynerovoz.Text = "место:";
            // 
            // buttonTakeBoat
            // 
            this.buttonTakeBoat.Location = new System.Drawing.Point(78, 42);
            this.buttonTakeBoat.Name = "buttonTakeBoat";
            this.buttonTakeBoat.Size = new System.Drawing.Size(135, 31);
            this.buttonTakeBoat.TabIndex = 1;
            this.buttonTakeBoat.Text = "забрать";
            this.buttonTakeBoat.UseVisualStyleBackColor = true;
            this.buttonTakeBoat.Click += new System.EventHandler(this.buttonTakeBoat_Click);
            // 
            // maskedTextBoxMesto
            // 
            this.maskedTextBoxMesto.Location = new System.Drawing.Point(147, 16);
            this.maskedTextBoxMesto.Name = "maskedTextBoxMesto";
            this.maskedTextBoxMesto.Size = new System.Drawing.Size(38, 20);
            this.maskedTextBoxMesto.TabIndex = 0;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(928, 120);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(109, 147);
            this.listBoxLevels.TabIndex = 4;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 618);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBoxTakeBoat);
            this.Controls.Add(this.buttonSetConteynerovoz);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.buttonSetBoat);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakeBoat.ResumeLayout(false);
            this.groupBoxTakeBoat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtakeboat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSetBoat;
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetConteynerovoz;
        private System.Windows.Forms.GroupBox groupBoxTakeBoat;
        private System.Windows.Forms.Label labelConteynerovoz;
        private System.Windows.Forms.Button buttonTakeBoat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMesto;
        private System.Windows.Forms.PictureBox pictureBoxtakeboat;
        private System.Windows.Forms.ListBox listBoxLevels;
    }
}