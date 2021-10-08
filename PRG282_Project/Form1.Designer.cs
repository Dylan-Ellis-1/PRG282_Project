
namespace PRG282_Project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNewCourse = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCourseID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 403);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxNewCourse);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnAddNewUser);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.lblLink);
            this.groupBox2.Controls.Add(this.rtbDescription);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxLink);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxCourseID);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(3, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 329);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Description:";
            // 
            // cbxNewCourse
            // 
            this.cbxNewCourse.AutoSize = true;
            this.cbxNewCourse.Location = new System.Drawing.Point(371, 153);
            this.cbxNewCourse.Name = "cbxNewCourse";
            this.cbxNewCourse.Size = new System.Drawing.Size(106, 17);
            this.cbxNewCourse.TabIndex = 13;
            this.cbxNewCourse.Text = "Add New Course";
            this.cbxNewCourse.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(377, 292);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 31);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back To Main";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnAddNewUser.Enabled = false;
            this.btnAddNewUser.Location = new System.Drawing.Point(271, 292);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(100, 31);
            this.btnAddNewUser.TabIndex = 11;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnEdit.Location = new System.Drawing.Point(115, 292);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 31);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Save Changes";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnDelete.Location = new System.Drawing.Point(9, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 31);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Course";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(200)))));
            this.lblLink.Location = new System.Drawing.Point(6, 267);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(124, 13);
            this.lblLink.TabIndex = 8;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "Click Here To Visit Site...";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(237, 184);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(240, 96);
            this.rtbDescription.TabIndex = 7;
            this.rtbDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Link";
            // 
            // tbxLink
            // 
            this.tbxLink.Location = new System.Drawing.Point(9, 244);
            this.tbxLink.Name = "tbxLink";
            this.tbxLink.Size = new System.Drawing.Size(206, 20);
            this.tbxLink.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(9, 205);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(206, 20);
            this.tbxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course ID:";
            // 
            // tbxCourseID
            // 
            this.tbxCourseID.Location = new System.Drawing.Point(9, 166);
            this.tbxCourseID.Name = "tbxCourseID";
            this.tbxCourseID.Size = new System.Drawing.Size(206, 20);
            this.tbxCourseID.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 131);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbxSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(317, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 31);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(137, 16);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Course Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(527, 428);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxNewCourse;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCourseID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label1;
    }
}