
namespace PRG282_Project
{
    partial class Main
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
            this.gbxStudent = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.cbxNewStudent = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.clbCourses = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxImgPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSNumber = new System.Windows.Forms.TextBox();
            this.gbxControl = new System.Windows.Forms.GroupBox();
            this.btnGoToCourses = new System.Windows.Forms.Button();
            this.btnDelStudent = new System.Windows.Forms.Button();
            this.btnDelCourse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.btnNextC = new System.Windows.Forms.Button();
            this.btnLastC = new System.Windows.Forms.Button();
            this.btnPrevC = new System.Windows.Forms.Button();
            this.btnFirstC = new System.Windows.Forms.Button();
            this.gbxViewStudent = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNextS = new System.Windows.Forms.Button();
            this.btnPrevS = new System.Windows.Forms.Button();
            this.btnLastS = new System.Windows.Forms.Button();
            this.btnFirstS = new System.Windows.Forms.Button();
            this.pbxStudent = new System.Windows.Forms.PictureBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.gbxStudent.SuspendLayout();
            this.gbxControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.gbxViewStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxStudent
            // 
            this.gbxStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbxStudent.Controls.Add(this.dtpDOB);
            this.gbxStudent.Controls.Add(this.label8);
            this.gbxStudent.Controls.Add(this.tbxAddress);
            this.gbxStudent.Controls.Add(this.cbxNewStudent);
            this.gbxStudent.Controls.Add(this.btnSave);
            this.gbxStudent.Controls.Add(this.label7);
            this.gbxStudent.Controls.Add(this.clbCourses);
            this.gbxStudent.Controls.Add(this.cmbGender);
            this.gbxStudent.Controls.Add(this.label6);
            this.gbxStudent.Controls.Add(this.label5);
            this.gbxStudent.Controls.Add(this.label4);
            this.gbxStudent.Controls.Add(this.tbxPhone);
            this.gbxStudent.Controls.Add(this.label3);
            this.gbxStudent.Controls.Add(this.tbxImgPath);
            this.gbxStudent.Controls.Add(this.label2);
            this.gbxStudent.Controls.Add(this.tbxName);
            this.gbxStudent.Controls.Add(this.label1);
            this.gbxStudent.Controls.Add(this.tbxSNumber);
            this.gbxStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxStudent.Location = new System.Drawing.Point(794, 12);
            this.gbxStudent.Name = "gbxStudent";
            this.gbxStudent.Size = new System.Drawing.Size(224, 413);
            this.gbxStudent.TabIndex = 8;
            this.gbxStudent.TabStop = false;
            this.gbxStudent.Text = "Student Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Address:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(117, 203);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(100, 20);
            this.tbxAddress.TabIndex = 18;
            // 
            // cbxNewStudent
            // 
            this.cbxNewStudent.AutoSize = true;
            this.cbxNewStudent.Location = new System.Drawing.Point(118, 19);
            this.cbxNewStudent.Name = "cbxNewStudent";
            this.cbxNewStudent.Size = new System.Drawing.Size(88, 17);
            this.cbxNewStudent.TabIndex = 17;
            this.cbxNewStudent.Text = "New Student";
            this.cbxNewStudent.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnSave.Location = new System.Drawing.Point(64, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 48);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Courses";
            // 
            // clbCourses
            // 
            this.clbCourses.FormattingEnabled = true;
            this.clbCourses.Location = new System.Drawing.Point(113, 241);
            this.clbCourses.Name = "clbCourses";
            this.clbCourses.Size = new System.Drawing.Size(104, 64);
            this.clbCourses.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone Number:";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(117, 177);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(100, 20);
            this.tbxPhone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Picture File Path";
            // 
            // tbxImgPath
            // 
            this.tbxImgPath.Location = new System.Drawing.Point(118, 95);
            this.tbxImgPath.Name = "tbxImgPath";
            this.tbxImgPath.Size = new System.Drawing.Size(100, 20);
            this.tbxImgPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name and Surname:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(118, 69);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Number:";
            // 
            // tbxSNumber
            // 
            this.tbxSNumber.Location = new System.Drawing.Point(118, 43);
            this.tbxSNumber.Name = "tbxSNumber";
            this.tbxSNumber.Size = new System.Drawing.Size(100, 20);
            this.tbxSNumber.TabIndex = 0;
            // 
            // gbxControl
            // 
            this.gbxControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbxControl.Controls.Add(this.btnGoToCourses);
            this.gbxControl.Controls.Add(this.btnDelStudent);
            this.gbxControl.Controls.Add(this.btnDelCourse);
            this.gbxControl.Controls.Add(this.btnExit);
            this.gbxControl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxControl.Location = new System.Drawing.Point(417, 260);
            this.gbxControl.Name = "gbxControl";
            this.gbxControl.Size = new System.Drawing.Size(371, 165);
            this.gbxControl.TabIndex = 7;
            this.gbxControl.TabStop = false;
            this.gbxControl.Text = "Control Box";
            // 
            // btnGoToCourses
            // 
            this.btnGoToCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnGoToCourses.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoToCourses.Location = new System.Drawing.Point(238, 19);
            this.btnGoToCourses.Name = "btnGoToCourses";
            this.btnGoToCourses.Size = new System.Drawing.Size(127, 34);
            this.btnGoToCourses.TabIndex = 3;
            this.btnGoToCourses.Text = "Manage Courses";
            this.btnGoToCourses.UseVisualStyleBackColor = false;
            this.btnGoToCourses.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnDelStudent
            // 
            this.btnDelStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnDelStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelStudent.Location = new System.Drawing.Point(6, 19);
            this.btnDelStudent.Name = "btnDelStudent";
            this.btnDelStudent.Size = new System.Drawing.Size(127, 34);
            this.btnDelStudent.TabIndex = 2;
            this.btnDelStudent.Text = "Delete Student";
            this.btnDelStudent.UseVisualStyleBackColor = false;
            this.btnDelStudent.Click += new System.EventHandler(this.btnDelStudent_Click);
            // 
            // btnDelCourse
            // 
            this.btnDelCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnDelCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelCourse.Location = new System.Drawing.Point(6, 68);
            this.btnDelCourse.Name = "btnDelCourse";
            this.btnDelCourse.Size = new System.Drawing.Size(127, 34);
            this.btnDelCourse.TabIndex = 1;
            this.btnDelCourse.Text = "Delete Course For Student";
            this.btnDelCourse.UseVisualStyleBackColor = false;
            this.btnDelCourse.Click += new System.EventHandler(this.btnDelCourse_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(238, 115);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 34);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox1.Controls.Add(this.dgvCourses);
            this.groupBox1.Controls.Add(this.btnNextC);
            this.groupBox1.Controls.Add(this.btnLastC);
            this.groupBox1.Controls.Add(this.btnPrevC);
            this.groupBox1.Controls.Add(this.btnFirstC);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Courses by Student";
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(16, 19);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.Size = new System.Drawing.Size(367, 111);
            this.dgvCourses.TabIndex = 7;
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);
            // 
            // btnNextC
            // 
            this.btnNextC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnNextC.Location = new System.Drawing.Point(227, 137);
            this.btnNextC.Name = "btnNextC";
            this.btnNextC.Size = new System.Drawing.Size(75, 23);
            this.btnNextC.TabIndex = 6;
            this.btnNextC.Text = ">";
            this.btnNextC.UseVisualStyleBackColor = false;
            this.btnNextC.Click += new System.EventHandler(this.btnNextC_Click);
            // 
            // btnLastC
            // 
            this.btnLastC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnLastC.Location = new System.Drawing.Point(308, 136);
            this.btnLastC.Name = "btnLastC";
            this.btnLastC.Size = new System.Drawing.Size(75, 23);
            this.btnLastC.TabIndex = 6;
            this.btnLastC.Text = ">>";
            this.btnLastC.UseVisualStyleBackColor = false;
            this.btnLastC.Click += new System.EventHandler(this.btnLastC_Click);
            // 
            // btnPrevC
            // 
            this.btnPrevC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnPrevC.Location = new System.Drawing.Point(97, 136);
            this.btnPrevC.Name = "btnPrevC";
            this.btnPrevC.Size = new System.Drawing.Size(75, 23);
            this.btnPrevC.TabIndex = 6;
            this.btnPrevC.Text = "<";
            this.btnPrevC.UseVisualStyleBackColor = false;
            this.btnPrevC.Click += new System.EventHandler(this.btnPrevC_Click);
            // 
            // btnFirstC
            // 
            this.btnFirstC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnFirstC.Location = new System.Drawing.Point(16, 136);
            this.btnFirstC.Name = "btnFirstC";
            this.btnFirstC.Size = new System.Drawing.Size(75, 23);
            this.btnFirstC.TabIndex = 6;
            this.btnFirstC.Text = "<<";
            this.btnFirstC.UseVisualStyleBackColor = false;
            this.btnFirstC.Click += new System.EventHandler(this.btnFirstC_Click);
            // 
            // gbxViewStudent
            // 
            this.gbxViewStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbxViewStudent.Controls.Add(this.btnSearch);
            this.gbxViewStudent.Controls.Add(this.tbxSearch);
            this.gbxViewStudent.Controls.Add(this.label9);
            this.gbxViewStudent.Controls.Add(this.btnNextS);
            this.gbxViewStudent.Controls.Add(this.btnPrevS);
            this.gbxViewStudent.Controls.Add(this.btnLastS);
            this.gbxViewStudent.Controls.Add(this.btnFirstS);
            this.gbxViewStudent.Controls.Add(this.pbxStudent);
            this.gbxViewStudent.Controls.Add(this.dgvStudent);
            this.gbxViewStudent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxViewStudent.Location = new System.Drawing.Point(12, 12);
            this.gbxViewStudent.Name = "gbxViewStudent";
            this.gbxViewStudent.Size = new System.Drawing.Size(776, 242);
            this.gbxViewStudent.TabIndex = 5;
            this.gbxViewStudent.TabStop = false;
            this.gbxViewStudent.Text = "View Student Data";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnSearch.Location = new System.Drawing.Point(485, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(270, 13);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(129, 20);
            this.tbxSearch.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Search By Student Number:";
            // 
            // btnNextS
            // 
            this.btnNextS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnNextS.Location = new System.Drawing.Point(404, 208);
            this.btnNextS.Name = "btnNextS";
            this.btnNextS.Size = new System.Drawing.Size(75, 23);
            this.btnNextS.TabIndex = 5;
            this.btnNextS.Text = ">";
            this.btnNextS.UseVisualStyleBackColor = false;
            this.btnNextS.Click += new System.EventHandler(this.btnNextS_Click);
            // 
            // btnPrevS
            // 
            this.btnPrevS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnPrevS.Location = new System.Drawing.Point(87, 208);
            this.btnPrevS.Name = "btnPrevS";
            this.btnPrevS.Size = new System.Drawing.Size(75, 23);
            this.btnPrevS.TabIndex = 4;
            this.btnPrevS.Text = "<";
            this.btnPrevS.UseVisualStyleBackColor = false;
            this.btnPrevS.Click += new System.EventHandler(this.btnPrevS_Click);
            // 
            // btnLastS
            // 
            this.btnLastS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnLastS.Location = new System.Drawing.Point(485, 208);
            this.btnLastS.Name = "btnLastS";
            this.btnLastS.Size = new System.Drawing.Size(75, 23);
            this.btnLastS.TabIndex = 3;
            this.btnLastS.Text = ">>";
            this.btnLastS.UseVisualStyleBackColor = false;
            this.btnLastS.Click += new System.EventHandler(this.btnLastS_Click);
            // 
            // btnFirstS
            // 
            this.btnFirstS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnFirstS.Location = new System.Drawing.Point(6, 208);
            this.btnFirstS.Name = "btnFirstS";
            this.btnFirstS.Size = new System.Drawing.Size(75, 23);
            this.btnFirstS.TabIndex = 2;
            this.btnFirstS.Text = "<<";
            this.btnFirstS.UseVisualStyleBackColor = false;
            this.btnFirstS.Click += new System.EventHandler(this.btnFirstS_Click);
            // 
            // pbxStudent
            // 
            this.pbxStudent.Location = new System.Drawing.Point(566, 39);
            this.pbxStudent.Name = "pbxStudent";
            this.pbxStudent.Size = new System.Drawing.Size(204, 197);
            this.pbxStudent.TabIndex = 1;
            this.pbxStudent.TabStop = false;
            // 
            // dgvStudent
            // 
            this.dgvStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(6, 39);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(554, 163);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(117, 146);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(100, 21);
            this.cmbGender.TabIndex = 13;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(117, 120);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(101, 20);
            this.dtpDOB.TabIndex = 20;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1023, 434);
            this.Controls.Add(this.gbxStudent);
            this.Controls.Add(this.gbxControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxViewStudent);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbxStudent.ResumeLayout(false);
            this.gbxStudent.PerformLayout();
            this.gbxControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.gbxViewStudent.ResumeLayout(false);
            this.gbxViewStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStudent;
        private System.Windows.Forms.CheckBox cbxNewStudent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox clbCourses;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxImgPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSNumber;
        private System.Windows.Forms.GroupBox gbxControl;
        private System.Windows.Forms.Button btnGoToCourses;
        private System.Windows.Forms.Button btnDelStudent;
        private System.Windows.Forms.Button btnDelCourse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNextC;
        private System.Windows.Forms.Button btnLastC;
        private System.Windows.Forms.Button btnPrevC;
        private System.Windows.Forms.Button btnFirstC;
        private System.Windows.Forms.GroupBox gbxViewStudent;
        private System.Windows.Forms.Button btnNextS;
        private System.Windows.Forms.Button btnPrevS;
        private System.Windows.Forms.Button btnLastS;
        private System.Windows.Forms.Button btnFirstS;
        private System.Windows.Forms.PictureBox pbxStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}