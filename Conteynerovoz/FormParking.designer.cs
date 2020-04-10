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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxTakeBoat = new System.Windows.Forms.GroupBox();
            this.pictureBoxtakeboat = new System.Windows.Forms.PictureBox();
            this.labelConteynerovoz = new System.Windows.Forms.Label();
            this.buttonTakeBoat = new System.Windows.Forms.Button();
            this.maskedTextBoxMesto = new System.Windows.Forms.MaskedTextBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonSetBoat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakeBoat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtakeboat)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(895, 594);
            this.pictureBoxParking.TabIndex = 1;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxTakeBoat
            // 
            this.groupBoxTakeBoat.Controls.Add(this.pictureBoxtakeboat);
            this.groupBoxTakeBoat.Controls.Add(this.labelConteynerovoz);
            this.groupBoxTakeBoat.Controls.Add(this.buttonTakeBoat);
            this.groupBoxTakeBoat.Controls.Add(this.maskedTextBoxMesto);
            this.groupBoxTakeBoat.Location = new System.Drawing.Point(901, 312);
            this.groupBoxTakeBoat.Name = "groupBoxTakeBoat";
            this.groupBoxTakeBoat.Size = new System.Drawing.Size(304, 306);
            this.groupBoxTakeBoat.TabIndex = 3;
            this.groupBoxTakeBoat.TabStop = false;
            this.groupBoxTakeBoat.Text = "забрать судно";
            // 
            // pictureBoxtakeboat
            // 
            this.pictureBoxtakeboat.Location = new System.Drawing.Point(0, 92);
            this.pictureBoxtakeboat.Name = "pictureBoxtakeboat";
            this.pictureBoxtakeboat.Size = new System.Drawing.Size(298, 214);
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
            this.buttonTakeBoat.Click += new System.EventHandler(this.buttonTakeCar_Click);
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
            this.listBoxLevels.Location = new System.Drawing.Point(933, 124);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(194, 121);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonSetBoat
            // 
            this.buttonSetBoat.Location = new System.Drawing.Point(942, 29);
            this.buttonSetBoat.Name = "buttonSetBoat";
            this.buttonSetBoat.Size = new System.Drawing.Size(118, 56);
            this.buttonSetBoat.TabIndex = 5;
            this.buttonSetBoat.Text = "заказать судно";
            this.buttonSetBoat.UseVisualStyleBackColor = true;
            this.buttonSetBoat.Click += new System.EventHandler(this.buttonSetCar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click_1);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt file | *.txt";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt file | *.txt";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 618);
            this.Controls.Add(this.buttonSetBoat);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBoxTakeBoat);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakeBoat.ResumeLayout(false);
            this.groupBoxTakeBoat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtakeboat)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBoxTakeBoat;
        private System.Windows.Forms.Label labelConteynerovoz;
        private System.Windows.Forms.Button buttonTakeBoat;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMesto;
        private System.Windows.Forms.PictureBox pictureBoxtakeboat;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonSetBoat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}