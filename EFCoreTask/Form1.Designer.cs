namespace EFCoreTask
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
            dataGridView1 = new DataGridView();
            txtTask = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cboStatus = new ComboBox();
            cmdCreateTask = new Button();
            groupBox1 = new GroupBox();
            texSearch = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmdCancelTask = new Button();
            cmdDeleteTask = new Button();
            cmdUpdateTask = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(250, 204, 107);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 291);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1092, 286);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtTask
            // 
            txtTask.BackColor = Color.FromArgb(250, 204, 107);
            txtTask.Location = new Point(45, 66);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(301, 23);
            txtTask.TabIndex = 0;
            txtTask.TextChanged += txtTask_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(250, 204, 107);
            dateTimePicker1.Location = new Point(158, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cboStatus
            // 
            cboStatus.BackColor = Color.FromArgb(250, 204, 107);
            cboStatus.ForeColor = Color.FromArgb(35, 2, 46);
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(189, 123);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(156, 23);
            cboStatus.TabIndex = 2;
            cboStatus.Text = "Please Select....";
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // cmdCreateTask
            // 
            cmdCreateTask.BackColor = Color.FromArgb(35, 2, 46);
            cmdCreateTask.FlatStyle = FlatStyle.Flat;
            cmdCreateTask.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmdCreateTask.ForeColor = Color.FromArgb(250, 204, 107);
            cmdCreateTask.Location = new Point(421, 66);
            cmdCreateTask.Name = "cmdCreateTask";
            cmdCreateTask.Size = new Size(107, 74);
            cmdCreateTask.TabIndex = 3;
            cmdCreateTask.Text = "Create";
            cmdCreateTask.UseVisualStyleBackColor = false;
            cmdCreateTask.Click += cmdCreateTask_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(87, 50, 128);
            groupBox1.Controls.Add(texSearch);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmdCancelTask);
            groupBox1.Controls.Add(cmdDeleteTask);
            groupBox1.Controls.Add(cmdUpdateTask);
            groupBox1.Controls.Add(cmdCreateTask);
            groupBox1.Controls.Add(cboStatus);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtTask);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1092, 264);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task";
            // 
            // texSearch
            // 
            texSearch.BackColor = Color.FromArgb(250, 204, 107);
            texSearch.ForeColor = Color.FromArgb(35, 2, 46);
            texSearch.Location = new Point(758, 117);
            texSearch.Name = "texSearch";
            texSearch.Size = new Size(300, 23);
            texSearch.TabIndex = 5;
            texSearch.Text = "Search";
            texSearch.TextChanged += texSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(287, 174);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Due Date:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(758, 95);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Search";
            label4.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(303, 105);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Status:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(313, 48);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 4;
            label1.Text = "Task:";
            label1.Click += label1_Click;
            // 
            // cmdCancelTask
            // 
            cmdCancelTask.BackColor = Color.FromArgb(35, 2, 46);
            cmdCancelTask.BackgroundImageLayout = ImageLayout.None;
            cmdCancelTask.FlatStyle = FlatStyle.Flat;
            cmdCancelTask.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmdCancelTask.ForeColor = Color.FromArgb(250, 204, 107);
            cmdCancelTask.Location = new Point(421, 146);
            cmdCancelTask.Name = "cmdCancelTask";
            cmdCancelTask.Size = new Size(188, 74);
            cmdCancelTask.TabIndex = 3;
            cmdCancelTask.Text = "Cancel";
            cmdCancelTask.UseVisualStyleBackColor = false;
            cmdCancelTask.Click += cmdCancelTask_Click;
            // 
            // cmdDeleteTask
            // 
            cmdDeleteTask.BackColor = Color.FromArgb(35, 2, 46);
            cmdDeleteTask.FlatStyle = FlatStyle.Flat;
            cmdDeleteTask.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmdDeleteTask.ForeColor = Color.FromArgb(250, 204, 107);
            cmdDeleteTask.Location = new Point(615, 146);
            cmdDeleteTask.Name = "cmdDeleteTask";
            cmdDeleteTask.Size = new Size(107, 74);
            cmdDeleteTask.TabIndex = 3;
            cmdDeleteTask.Text = "Delete";
            cmdDeleteTask.UseVisualStyleBackColor = false;
            cmdDeleteTask.Click += cmdDeleteTask_Click;
            // 
            // cmdUpdateTask
            // 
            cmdUpdateTask.BackColor = Color.FromArgb(35, 2, 46);
            cmdUpdateTask.FlatStyle = FlatStyle.Flat;
            cmdUpdateTask.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmdUpdateTask.ForeColor = Color.FromArgb(250, 204, 107);
            cmdUpdateTask.Location = new Point(534, 66);
            cmdUpdateTask.Name = "cmdUpdateTask";
            cmdUpdateTask.Size = new Size(188, 74);
            cmdUpdateTask.TabIndex = 3;
            cmdUpdateTask.Text = "Update";
            cmdUpdateTask.UseVisualStyleBackColor = false;
            cmdUpdateTask.Click += cmdUpdateTask_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 589);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            MaximumSize = new Size(1132, 628);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Master";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtTask;
        private DateTimePicker dateTimePicker1;
        private ComboBox cboStatus;
        private Button cmdCreateTask;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button cmdCancelTask;
        private Button cmdDeleteTask;
        private Button cmdUpdateTask;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TextBox texSearch;
        private Label label4;
    }
}