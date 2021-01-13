namespace KentCam_ApiCall_SampleCode
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_GetLog = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.btn_PostData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_GetLog);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lbl_From);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.lbl_To);
            this.groupBox1.Location = new System.Drawing.Point(36, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get_Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_PostData);
            this.groupBox2.Location = new System.Drawing.Point(381, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Post_Data";
            // 
            // btn_GetLog
            // 
            this.btn_GetLog.Location = new System.Drawing.Point(84, 181);
            this.btn_GetLog.Name = "btn_GetLog";
            this.btn_GetLog.Size = new System.Drawing.Size(158, 43);
            this.btn_GetLog.TabIndex = 9;
            this.btn_GetLog.Text = "Get Log";
            this.btn_GetLog.UseVisualStyleBackColor = true;
            this.btn_GetLog.Click += new System.EventHandler(this.btn_GetLog_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(84, 113);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To.Location = new System.Drawing.Point(43, 113);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(21, 15);
            this.lbl_To.TabIndex = 8;
            this.lbl_To.Text = "To";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.Location = new System.Drawing.Point(43, 77);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(36, 15);
            this.lbl_From.TabIndex = 7;
            this.lbl_From.Text = "From";
            // 
            // btn_PostData
            // 
            this.btn_PostData.Location = new System.Drawing.Point(96, 181);
            this.btn_PostData.Name = "btn_PostData";
            this.btn_PostData.Size = new System.Drawing.Size(163, 43);
            this.btn_PostData.TabIndex = 6;
            this.btn_PostData.Text = "Post Data";
            this.btn_PostData.UseVisualStyleBackColor = true;
            this.btn_PostData.Click += new System.EventHandler(this.btn_PostData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 358);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_GetLog;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_PostData;
    }
}

