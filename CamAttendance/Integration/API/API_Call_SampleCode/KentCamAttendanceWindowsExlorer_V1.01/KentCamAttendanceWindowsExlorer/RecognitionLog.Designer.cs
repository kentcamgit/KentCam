namespace KentCamAttendanceWindowsExlorer
{
    partial class RecognitionLog
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_To = new System.Windows.Forms.Label();
            this.btn_GetLog = new System.Windows.Forms.Button();
            this.btn_PostData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(401, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.Location = new System.Drawing.Point(58, 58);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(36, 15);
            this.lbl_From.TabIndex = 2;
            this.lbl_From.Text = "From";
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To.Location = new System.Drawing.Point(374, 58);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(21, 15);
            this.lbl_To.TabIndex = 3;
            this.lbl_To.Text = "To";
            // 
            // btn_GetLog
            // 
            this.btn_GetLog.Location = new System.Drawing.Point(124, 147);
            this.btn_GetLog.Name = "btn_GetLog";
            this.btn_GetLog.Size = new System.Drawing.Size(158, 43);
            this.btn_GetLog.TabIndex = 4;
            this.btn_GetLog.Text = "Get Log";
            this.btn_GetLog.UseVisualStyleBackColor = true;
            this.btn_GetLog.Click += new System.EventHandler(this.btn_GetLog_Click);
            // 
            // btn_PostData
            // 
            this.btn_PostData.Location = new System.Drawing.Point(401, 147);
            this.btn_PostData.Name = "btn_PostData";
            this.btn_PostData.Size = new System.Drawing.Size(163, 43);
            this.btn_PostData.TabIndex = 5;
            this.btn_PostData.Text = "Post Data";
            this.btn_PostData.UseVisualStyleBackColor = true;
            this.btn_PostData.Click += new System.EventHandler(this.btn_PostData_Click);
            // 
            // RecognitionLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_PostData);
            this.Controls.Add(this.btn_GetLog);
            this.Controls.Add(this.lbl_To);
            this.Controls.Add(this.lbl_From);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "RecognitionLog";
            this.Text = "RecognitionLog";
            this.Load += new System.EventHandler(this.RecognitionLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_To;
        private System.Windows.Forms.Button btn_GetLog;
        private System.Windows.Forms.Button btn_PostData;
    }
}