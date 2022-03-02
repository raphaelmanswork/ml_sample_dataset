
namespace MCL_Stroke
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
            this.createNn_btn = new System.Windows.Forms.Button();
            this.trainNn_btn = new System.Windows.Forms.Button();
            this.cmbx_gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_Age = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_heartDisease = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Hypertension = new System.Windows.Forms.TextBox();
            this.txtbox_Result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_GlucoseLevel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createNn_btn
            // 
            this.createNn_btn.Location = new System.Drawing.Point(42, 134);
            this.createNn_btn.Name = "createNn_btn";
            this.createNn_btn.Size = new System.Drawing.Size(151, 23);
            this.createNn_btn.TabIndex = 0;
            this.createNn_btn.Text = "Create Neural Network";
            this.createNn_btn.UseVisualStyleBackColor = true;
            this.createNn_btn.Click += new System.EventHandler(this.init_Nn);
            // 
            // trainNn_btn
            // 
            this.trainNn_btn.Location = new System.Drawing.Point(42, 177);
            this.trainNn_btn.Name = "trainNn_btn";
            this.trainNn_btn.Size = new System.Drawing.Size(151, 23);
            this.trainNn_btn.TabIndex = 1;
            this.trainNn_btn.Text = "Train Neural Network";
            this.trainNn_btn.UseVisualStyleBackColor = true;
            this.trainNn_btn.Click += new System.EventHandler(this.train_Nn);
            // 
            // cmbx_gender
            // 
            this.cmbx_gender.FormattingEnabled = true;
            this.cmbx_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbx_gender.Location = new System.Drawing.Point(263, 134);
            this.cmbx_gender.Name = "cmbx_gender";
            this.cmbx_gender.Size = new System.Drawing.Size(121, 21);
            this.cmbx_gender.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gender";
            // 
            // txtbox_Age
            // 
            this.txtbox_Age.Location = new System.Drawing.Point(414, 134);
            this.txtbox_Age.Name = "txtbox_Age";
            this.txtbox_Age.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Age.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age";
            // 
            // txtbox_heartDisease
            // 
            this.txtbox_heartDisease.Location = new System.Drawing.Point(555, 134);
            this.txtbox_heartDisease.Name = "txtbox_heartDisease";
            this.txtbox_heartDisease.Size = new System.Drawing.Size(100, 20);
            this.txtbox_heartDisease.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Heart Disease";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(552, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hypertension";
            // 
            // txtBox_Hypertension
            // 
            this.txtBox_Hypertension.Location = new System.Drawing.Point(555, 193);
            this.txtBox_Hypertension.Name = "txtBox_Hypertension";
            this.txtBox_Hypertension.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Hypertension.TabIndex = 9;
            // 
            // txtbox_Result
            // 
            this.txtbox_Result.Location = new System.Drawing.Point(414, 309);
            this.txtbox_Result.Name = "txtbox_Result";
            this.txtbox_Result.ReadOnly = true;
            this.txtbox_Result.Size = new System.Drawing.Size(139, 20);
            this.txtbox_Result.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Probability of Getting Stroke (%)";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Get Result";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_GlucoseLevel
            // 
            this.txt_GlucoseLevel.Location = new System.Drawing.Point(414, 193);
            this.txt_GlucoseLevel.Name = "txt_GlucoseLevel";
            this.txt_GlucoseLevel.Size = new System.Drawing.Size(100, 20);
            this.txt_GlucoseLevel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Glucose Level";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_GlucoseLevel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbox_Result);
            this.Controls.Add(this.txtBox_Hypertension);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_heartDisease);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_Age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbx_gender);
            this.Controls.Add(this.trainNn_btn);
            this.Controls.Add(this.createNn_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNn_btn;
        private System.Windows.Forms.Button trainNn_btn;
        private System.Windows.Forms.ComboBox cmbx_gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_Age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_heartDisease;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_Hypertension;
        private System.Windows.Forms.TextBox txtbox_Result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_GlucoseLevel;
        private System.Windows.Forms.Label label6;
    }
}

