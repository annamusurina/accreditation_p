
namespace Аккредитационные_показатели
{
    partial class Teacher
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
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            this.txtSearchTeacher = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.магистратураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnAddTeacher.Location = new System.Drawing.Point(655, 116);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(116, 52);
            this.btnAddTeacher.TabIndex = 34;
            this.btnAddTeacher.Text = "Добавить";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(43, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Преподаватели";
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(12, 116);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.RowHeadersWidth = 51;
            this.dgvTeacher.RowTemplate.Height = 24;
            this.dgvTeacher.Size = new System.Drawing.Size(637, 286);
            this.dgvTeacher.TabIndex = 32;
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnSearchTeacher.Location = new System.Drawing.Point(527, 75);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.btnSearchTeacher.Size = new System.Drawing.Size(80, 35);
            this.btnSearchTeacher.TabIndex = 31;
            this.btnSearchTeacher.Text = "Поиск";
            this.btnSearchTeacher.UseVisualStyleBackColor = true;
            // 
            // txtSearchTeacher
            // 
            this.txtSearchTeacher.Location = new System.Drawing.Point(59, 81);
            this.txtSearchTeacher.Name = "txtSearchTeacher";
            this.txtSearchTeacher.Size = new System.Drawing.Size(440, 22);
            this.txtSearchTeacher.TabIndex = 30;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяToolStripMenuItem,
            this.объемToolStripMenuItem,
            this.магистратураToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться назад";
            // 
            // объемToolStripMenuItem
            // 
            this.объемToolStripMenuItem.Name = "объемToolStripMenuItem";
            this.объемToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.объемToolStripMenuItem.Text = "Объем учебной нагрузки";
            // 
            // магистратураToolStripMenuItem
            // 
            this.магистратураToolStripMenuItem.Name = "магистратураToolStripMenuItem";
            this.магистратураToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.магистратураToolStripMenuItem.Text = "Руководство программы магистратуры";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTeacher);
            this.Controls.Add(this.btnSearchTeacher);
            this.Controls.Add(this.txtSearchTeacher);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Teacher";
            this.Text = "Преподаватели";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.TextBox txtSearchTeacher;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem магистратураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}