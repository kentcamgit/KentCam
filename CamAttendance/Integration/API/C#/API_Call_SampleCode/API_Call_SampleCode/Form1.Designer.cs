namespace API_Call_SampleCode
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DateFrom = new System.Windows.Forms.Label();
            this.btn_GetTransactionLog = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_EmpInfo = new System.Windows.Forms.Button();
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_DateFrom);
            this.groupBox1.Controls.Add(this.btn_GetTransactionLog);
            this.groupBox1.Location = new System.Drawing.Point(25, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get_Transaction_Data";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(113, 103);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.Value = new System.DateTime(2021, 1, 21, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 21, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date To";
            // 
            // lbl_DateFrom
            // 
            this.lbl_DateFrom.AutoSize = true;
            this.lbl_DateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateFrom.Location = new System.Drawing.Point(24, 69);
            this.lbl_DateFrom.Name = "lbl_DateFrom";
            this.lbl_DateFrom.Size = new System.Drawing.Size(65, 15);
            this.lbl_DateFrom.TabIndex = 1;
            this.lbl_DateFrom.Text = "Date From";
            // 
            // btn_GetTransactionLog
            // 
            this.btn_GetTransactionLog.Location = new System.Drawing.Point(113, 157);
            this.btn_GetTransactionLog.Name = "btn_GetTransactionLog";
            this.btn_GetTransactionLog.Size = new System.Drawing.Size(144, 55);
            this.btn_GetTransactionLog.TabIndex = 0;
            this.btn_GetTransactionLog.Text = "Get Transaction Log";
            this.btn_GetTransactionLog.UseVisualStyleBackColor = true;
            this.btn_GetTransactionLog.Click += new System.EventHandler(this.btn_GetTransactionLog_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_EmpInfo);
            this.groupBox2.Controls.Add(this.btn_AddEmployee);
            this.groupBox2.Location = new System.Drawing.Point(408, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_EmpInfo
            // 
            this.btn_EmpInfo.Location = new System.Drawing.Point(58, 69);
            this.btn_EmpInfo.Name = "btn_EmpInfo";
            this.btn_EmpInfo.Size = new System.Drawing.Size(144, 55);
            this.btn_EmpInfo.TabIndex = 2;
            this.btn_EmpInfo.Text = "Get Emp Info";
            this.btn_EmpInfo.UseVisualStyleBackColor = true;
            this.btn_EmpInfo.Click += new System.EventHandler(this.btn_EmpInfo_Click);
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.Location = new System.Drawing.Point(58, 147);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Size = new System.Drawing.Size(144, 55);
            this.btn_AddEmployee.TabIndex = 1;
            this.btn_AddEmployee.Text = "Add Employee";
            this.btn_AddEmployee.UseVisualStyleBackColor = true;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DateFrom;
        private System.Windows.Forms.Button btn_GetTransactionLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_GetEmpInfo;
        private System.Windows.Forms.Button btn_EmpInfo;
    }
}

