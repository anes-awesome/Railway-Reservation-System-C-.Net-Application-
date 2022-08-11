
namespace Railway_System
{
    partial class ViewTrain
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
            this.TrainView = new System.Windows.Forms.DataGridView();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.deleteTrainbtn = new System.Windows.Forms.Button();
            this.updateTrainbtn = new System.Windows.Forms.Button();
            this.avilSeatsV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.destiBoxV = new System.Windows.Forms.ComboBox();
            this.sourceBoxV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trainNumbV = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trainNameV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrainView)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TrainView
            // 
            this.TrainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainView.Location = new System.Drawing.Point(11, 198);
            this.TrainView.Name = "TrainView";
            this.TrainView.Size = new System.Drawing.Size(776, 150);
            this.TrainView.TabIndex = 25;
            this.TrainView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TrainView_CellClick);
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.Resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resetbtn.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbtn.ForeColor = System.Drawing.Color.White;
            this.Resetbtn.Location = new System.Drawing.Point(429, 369);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(150, 35);
            this.Resetbtn.TabIndex = 23;
            this.Resetbtn.Text = "RESET";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // deleteTrainbtn
            // 
            this.deleteTrainbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.deleteTrainbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTrainbtn.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTrainbtn.ForeColor = System.Drawing.Color.White;
            this.deleteTrainbtn.Location = new System.Drawing.Point(215, 369);
            this.deleteTrainbtn.Name = "deleteTrainbtn";
            this.deleteTrainbtn.Size = new System.Drawing.Size(150, 35);
            this.deleteTrainbtn.TabIndex = 22;
            this.deleteTrainbtn.Text = "DELETE TRAIN";
            this.deleteTrainbtn.UseVisualStyleBackColor = false;
            this.deleteTrainbtn.Click += new System.EventHandler(this.deleteTrainbtn_Click);
            // 
            // updateTrainbtn
            // 
            this.updateTrainbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.updateTrainbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateTrainbtn.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTrainbtn.ForeColor = System.Drawing.Color.White;
            this.updateTrainbtn.Location = new System.Drawing.Point(11, 369);
            this.updateTrainbtn.Name = "updateTrainbtn";
            this.updateTrainbtn.Size = new System.Drawing.Size(150, 35);
            this.updateTrainbtn.TabIndex = 21;
            this.updateTrainbtn.Text = "UPDATE TRAIN";
            this.updateTrainbtn.UseVisualStyleBackColor = false;
            this.updateTrainbtn.Click += new System.EventHandler(this.updateTrainbtn_Click);
            // 
            // avilSeatsV
            // 
            this.avilSeatsV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avilSeatsV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avilSeatsV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.avilSeatsV.Location = new System.Drawing.Point(613, 10);
            this.avilSeatsV.Name = "avilSeatsV";
            this.avilSeatsV.Size = new System.Drawing.Size(143, 20);
            this.avilSeatsV.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(480, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Available Seats";
            // 
            // destiBoxV
            // 
            this.destiBoxV.FormattingEnabled = true;
            this.destiBoxV.Items.AddRange(new object[] {
            "CENNAI",
            "PUDUCHERRY",
            "KARAIKAL",
            "MAYILADUTHURAI",
            "COIMBATORE",
            "KANYAKUMARI",
            "ERNAKULAM",
            "MUMBAI",
            "THIRUVANANDAPURAM",
            "TRICHY",
            "TANJORE",
            "MADURAI",
            "DINDUGAL"});
            this.destiBoxV.Location = new System.Drawing.Point(333, 10);
            this.destiBoxV.Name = "destiBoxV";
            this.destiBoxV.Size = new System.Drawing.Size(141, 21);
            this.destiBoxV.TabIndex = 6;
            // 
            // sourceBoxV
            // 
            this.sourceBoxV.FormattingEnabled = true;
            this.sourceBoxV.Items.AddRange(new object[] {
            "CENNAI",
            "PUDUCHERRY",
            "KARAIKAL",
            "MAYILADUTHURAI",
            "COIMBATORE",
            "KANYAKUMARI",
            "ERNAKULAM",
            "MUMBAI",
            "THIRUVANANDAPURAM",
            "TRICHY",
            "TANJORE",
            "MADURAI",
            "DINDUGAL"});
            this.sourceBoxV.Location = new System.Drawing.Point(87, 10);
            this.sourceBoxV.Name = "sourceBoxV";
            this.sourceBoxV.Size = new System.Drawing.Size(141, 21);
            this.sourceBoxV.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Destination";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Source";
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.Color.White;
            this.Backbtn.Location = new System.Drawing.Point(637, 369);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(150, 35);
            this.Backbtn.TabIndex = 24;
            this.Backbtn.Text = "BACK";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.avilSeatsV);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.destiBoxV);
            this.panel4.Controls.Add(this.sourceBoxV);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(11, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 40);
            this.panel4.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Train Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Train Number";
            // 
            // trainNumbV
            // 
            this.trainNumbV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trainNumbV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainNumbV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.trainNumbV.Location = new System.Drawing.Point(147, 10);
            this.trainNumbV.Name = "trainNumbV";
            this.trainNumbV.Size = new System.Drawing.Size(163, 20);
            this.trainNumbV.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.trainNameV);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.trainNumbV);
            this.panel3.Location = new System.Drawing.Point(11, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 40);
            this.panel3.TabIndex = 19;
            // 
            // trainNameV
            // 
            this.trainNameV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trainNameV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainNameV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.trainNameV.Location = new System.Drawing.Point(455, 10);
            this.trainNameV.Name = "trainNameV";
            this.trainNameV.Size = new System.Drawing.Size(301, 20);
            this.trainNameV.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.panel2.Location = new System.Drawing.Point(-1, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 21);
            this.panel2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.label5.Location = new System.Drawing.Point(345, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "VIEW TRAINS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(262, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "RAILWAY RESERVATION SYSTEM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 40);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Railway_System.Properties.Resources.railway3;
            this.pictureBox1.Location = new System.Drawing.Point(216, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ViewTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrainView);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.deleteTrainbtn);
            this.Controls.Add(this.updateTrainbtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewTrain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTrain";
            this.Load += new System.EventHandler(this.ViewTrain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrainView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TrainView;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.Button deleteTrainbtn;
        private System.Windows.Forms.Button updateTrainbtn;
        private System.Windows.Forms.TextBox avilSeatsV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox destiBoxV;
        private System.Windows.Forms.ComboBox sourceBoxV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox trainNumbV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox trainNameV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}