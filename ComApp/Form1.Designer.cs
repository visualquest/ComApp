using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ComApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zodiacOptionsOne = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zodiacTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zodiacOptionsTwo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.myersTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.myersOptionTwo = new System.Windows.Forms.ComboBox();
            this.myersOptionOne = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ennTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ennOptionTwo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ennOptionOne = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.bigTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.titleText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titleText.Location = new System.Drawing.Point(41, 9);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(557, 43);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Cas\'s Hopefully Helpful Compatibility App!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(89, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ever don\'t want to do the math yourself? Now you don\'t have to!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sign of Person One:";
            // 
            // zodiacOptionsOne
            // 
            this.zodiacOptionsOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zodiacOptionsOne.FormattingEnabled = true;
            this.zodiacOptionsOne.Items.AddRange(new object[] {
            "Aries",
            "Taurus",
            "Gemini",
            "Cancer",
            "Leo",
            "Virgo",
            "Libra",
            "Scorpio",
            "Sagittarius",
            "Capricorn",
            "Aquarius",
            "Pisces"});
            this.zodiacOptionsOne.Location = new System.Drawing.Point(215, 38);
            this.zodiacOptionsOne.Name = "zodiacOptionsOne";
            this.zodiacOptionsOne.Size = new System.Drawing.Size(191, 33);
            this.zodiacOptionsOne.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zodiacTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.zodiacOptionsTwo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.zodiacOptionsOne);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(27, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zodiac Information";
            // 
            // zodiacTotal
            // 
            this.zodiacTotal.AutoSize = true;
            this.zodiacTotal.Location = new System.Drawing.Point(438, 112);
            this.zodiacTotal.Name = "zodiacTotal";
            this.zodiacTotal.Size = new System.Drawing.Size(131, 25);
            this.zodiacTotal.TabIndex = 7;
            this.zodiacTotal.Text = "None (for now!)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total:";
            // 
            // zodiacOptionsTwo
            // 
            this.zodiacOptionsTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.zodiacOptionsTwo.FormattingEnabled = true;
            this.zodiacOptionsTwo.Items.AddRange(new object[] {
            "Aries",
            "Taurus",
            "Gemini",
            "Cancer",
            "Leo",
            "Virgo",
            "Libra",
            "Scorpio",
            "Sagittarius",
            "Capricorn",
            "Aquarius",
            "Pisces"});
            this.zodiacOptionsTwo.Location = new System.Drawing.Point(215, 95);
            this.zodiacOptionsTwo.Name = "zodiacOptionsTwo";
            this.zodiacOptionsTwo.Size = new System.Drawing.Size(191, 33);
            this.zodiacOptionsTwo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sign of Person Two:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.myersTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.myersOptionTwo);
            this.groupBox2.Controls.Add(this.myersOptionOne);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(27, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 148);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Myer\'s Briggs Information";
            // 
            // myersTotal
            // 
            this.myersTotal.AutoSize = true;
            this.myersTotal.Location = new System.Drawing.Point(438, 110);
            this.myersTotal.Name = "myersTotal";
            this.myersTotal.Size = new System.Drawing.Size(131, 25);
            this.myersTotal.TabIndex = 8;
            this.myersTotal.Text = "None (for now!)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total:";
            // 
            // myersOptionTwo
            // 
            this.myersOptionTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myersOptionTwo.FormattingEnabled = true;
            this.myersOptionTwo.Items.AddRange(new object[] {
            "INFJ",
            "INTJ",
            "ENTJ",
            "ENFJ",
            "ENFP",
            "ENTP",
            "INTP",
            "INFP",
            "ISFJ",
            "ISTJ",
            "ESTJ",
            "ESFJ",
            "ESFP",
            "ESTP",
            "ISTP",
            "ISFP"});
            this.myersOptionTwo.Location = new System.Drawing.Point(244, 96);
            this.myersOptionTwo.Name = "myersOptionTwo";
            this.myersOptionTwo.Size = new System.Drawing.Size(162, 33);
            this.myersOptionTwo.TabIndex = 8;
            // 
            // myersOptionOne
            // 
            this.myersOptionOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myersOptionOne.FormattingEnabled = true;
            this.myersOptionOne.Items.AddRange(new object[] {
            "INFJ",
            "INTJ",
            "ENTJ",
            "ENFJ",
            "ENFP",
            "ENTP",
            "INTP",
            "INFP",
            "ISFJ",
            "ISTJ",
            "ESTJ",
            "ESFJ",
            "ESFP",
            "ESTP",
            "ISTP",
            "ISFP"});
            this.myersOptionOne.Location = new System.Drawing.Point(244, 44);
            this.myersOptionOne.Name = "myersOptionOne";
            this.myersOptionOne.Size = new System.Drawing.Size(162, 33);
            this.myersOptionOne.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "MBTI of Person Two:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "MBTI of Person One:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ennTotal);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.ennOptionTwo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ennOptionOne);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(27, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 150);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enneagram Information (Optional, Only Matches Main Type)";
            // 
            // ennTotal
            // 
            this.ennTotal.AutoSize = true;
            this.ennTotal.Location = new System.Drawing.Point(438, 113);
            this.ennTotal.Name = "ennTotal";
            this.ennTotal.Size = new System.Drawing.Size(131, 25);
            this.ennTotal.TabIndex = 14;
            this.ennTotal.Text = "None (for now!)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Total:";
            // 
            // ennOptionTwo
            // 
            this.ennOptionTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ennOptionTwo.FormattingEnabled = true;
            this.ennOptionTwo.Items.AddRange(new object[] {
            "Skip",
            "Type One",
            "Type Two",
            "Type Three",
            "Type Four",
            "Type Five",
            "Type Six",
            "Type Seven",
            "Type Eight",
            "Type Nine"});
            this.ennOptionTwo.Location = new System.Drawing.Point(285, 89);
            this.ennOptionTwo.Name = "ennOptionTwo";
            this.ennOptionTwo.Size = new System.Drawing.Size(121, 33);
            this.ennOptionTwo.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(14, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 33);
            this.label9.TabIndex = 11;
            this.label9.Text = "Enneagram of Person Two:";
            // 
            // ennOptionOne
            // 
            this.ennOptionOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ennOptionOne.FormattingEnabled = true;
            this.ennOptionOne.Items.AddRange(new object[] {
            "Skip",
            "Type One",
            "Type Two",
            "Type Three",
            "Type Four",
            "Type Five",
            "Type Six",
            "Type Seven",
            "Type Eight",
            "Type Nine"});
            this.ennOptionOne.Location = new System.Drawing.Point(285, 39);
            this.ennOptionOne.Name = "ennOptionOne";
            this.ennOptionOne.Size = new System.Drawing.Size(121, 33);
            this.ennOptionOne.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(14, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 33);
            this.label8.TabIndex = 9;
            this.label8.Text = "Enneagram of Person One:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(219, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate Now!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(191, 540);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(247, 39);
            this.label11.TabIndex = 14;
            this.label11.Text = "Total Compatibility:";
            // 
            // bigTotal
            // 
            this.bigTotal.AutoSize = true;
            this.bigTotal.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.bigTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bigTotal.Location = new System.Drawing.Point(248, 579);
            this.bigTotal.Name = "bigTotal";
            this.bigTotal.Size = new System.Drawing.Size(133, 39);
            this.bigTotal.TabIndex = 8;
            this.bigTotal.Text = "Find Out!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 676);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 171);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(625, 859);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bigTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleText;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox zodiacOptionsTwo;
        private Label label3;
        private GroupBox groupBox2;
        private Label label7;
        private ComboBox myersOptionTwo;
        private ComboBox myersOptionOne;
        private Label label6;
        private Label label5;
        private GroupBox groupBox3;
        private Label label10;
        private ComboBox ennOptionTwo;
        private Label label9;
        private ComboBox ennOptionOne;
        private Label label8;
        private Button button1;
        private Label label11;
        private ComboBox zodiacOptionsOne;
        private Label zodiacTotal;
        private Label myersTotal;
        private Label ennTotal;
        private Label bigTotal;
        private PictureBox pictureBox1;
    }
}