namespace WindowsFormCars
{
    partial class FormCarConfig
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
            this.groupBoxKindOfBoat = new System.Windows.Forms.GroupBox();
            this.labelConteynerovoz = new System.Windows.Forms.Label();
            this.labelBoat = new System.Windows.Forms.Label();
            this.pictureBoxBoat = new System.Windows.Forms.PictureBox();
            this.panelBoat = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.groupBoxKindOfBoat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).BeginInit();
            this.panelBoat.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKindOfBoat
            // 
            this.groupBoxKindOfBoat.Controls.Add(this.labelConteynerovoz);
            this.groupBoxKindOfBoat.Controls.Add(this.labelBoat);
            this.groupBoxKindOfBoat.Location = new System.Drawing.Point(38, 31);
            this.groupBoxKindOfBoat.Name = "groupBoxKindOfBoat";
            this.groupBoxKindOfBoat.Size = new System.Drawing.Size(203, 199);
            this.groupBoxKindOfBoat.TabIndex = 0;
            this.groupBoxKindOfBoat.TabStop = false;
            this.groupBoxKindOfBoat.Text = "тип кузова";
            // 
            // labelConteynerovoz
            // 
            this.labelConteynerovoz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelConteynerovoz.Location = new System.Drawing.Point(20, 106);
            this.labelConteynerovoz.Name = "labelConteynerovoz";
            this.labelConteynerovoz.Size = new System.Drawing.Size(144, 54);
            this.labelConteynerovoz.TabIndex = 1;
            this.labelConteynerovoz.Text = "контейнеровоз";
            this.labelConteynerovoz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSportCar_MouseDown);
            // 
            // labelBoat
            // 
            this.labelBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBoat.Location = new System.Drawing.Point(20, 25);
            this.labelBoat.Name = "labelBoat";
            this.labelBoat.Size = new System.Drawing.Size(144, 57);
            this.labelBoat.TabIndex = 0;
            this.labelBoat.Text = "судно";
            this.labelBoat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCar_MouseDown);
            // 
            // pictureBoxBoat
            // 
            this.pictureBoxBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBoat.Location = new System.Drawing.Point(23, 21);
            this.pictureBoxBoat.Name = "pictureBoxBoat";
            this.pictureBoxBoat.Size = new System.Drawing.Size(279, 196);
            this.pictureBoxBoat.TabIndex = 1;
            this.pictureBoxBoat.TabStop = false;
            this.pictureBoxBoat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCar_MouseDown);
            // 
            // panelBoat
            // 
            this.panelBoat.AllowDrop = true;
            this.panelBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBoat.Controls.Add(this.labelDopColor);
            this.panelBoat.Controls.Add(this.labelBaseColor);
            this.panelBoat.Controls.Add(this.pictureBoxBoat);
            this.panelBoat.Location = new System.Drawing.Point(257, 13);
            this.panelBoat.Name = "panelBoat";
            this.panelBoat.Size = new System.Drawing.Size(323, 357);
            this.panelBoat.TabIndex = 2;
            this.panelBoat.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.panelBoat.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(181, 242);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(120, 87);
            this.labelDopColor.TabIndex = 3;
            this.labelDopColor.Text = "доп цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            this.labelDopColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(32, 243);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(124, 87);
            this.labelBaseColor.TabIndex = 2;
            this.labelBaseColor.Text = "основной цвет";
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            this.labelBaseColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(12, 11);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(50, 50);
            this.panelRed.TabIndex = 3;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(12, 67);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(50, 50);
            this.panelGray.TabIndex = 4;
            this.panelGray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(12, 124);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(50, 50);
            this.panelYellow.TabIndex = 5;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(12, 180);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(50, 50);
            this.panelGreen.TabIndex = 6;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Fuchsia;
            this.panelPink.Location = new System.Drawing.Point(68, 11);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(50, 50);
            this.panelPink.TabIndex = 7;
            this.panelPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(68, 67);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(50, 50);
            this.panelBlue.TabIndex = 8;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelAqua
            // 
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.Location = new System.Drawing.Point(68, 124);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(50, 50);
            this.panelAqua.TabIndex = 9;
            this.panelAqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(68, 180);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(50, 50);
            this.panelBlack.TabIndex = 10;
            this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(86, 252);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 31);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(88, 305);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 36);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelColor
            // 
            this.panelColor.Controls.Add(this.panelBlack);
            this.panelColor.Controls.Add(this.panelAqua);
            this.panelColor.Controls.Add(this.panelBlue);
            this.panelColor.Controls.Add(this.panelPink);
            this.panelColor.Controls.Add(this.panelGreen);
            this.panelColor.Controls.Add(this.panelYellow);
            this.panelColor.Controls.Add(this.panelGray);
            this.panelColor.Controls.Add(this.panelRed);
            this.panelColor.Location = new System.Drawing.Point(601, 27);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(133, 255);
            this.panelColor.TabIndex = 13;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 392);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelBoat);
            this.Controls.Add(this.groupBoxKindOfBoat);
            this.Name = "FormCarConfig";
            this.Text = "FormCarConfig";
            this.groupBoxKindOfBoat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).EndInit();
            this.panelBoat.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKindOfBoat;
        private System.Windows.Forms.Label labelBoat;
        private System.Windows.Forms.Label labelConteynerovoz;
        private System.Windows.Forms.PictureBox pictureBoxBoat;
        private System.Windows.Forms.Panel panelBoat;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelColor;
    }
}