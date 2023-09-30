
namespace Аккредитационные_показатели
{
    partial class Disciplines
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
            this.btnAddDisciplines = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDisciplines = new System.Windows.Forms.DataGridView();
            this.btnSearchDisciplines = new System.Windows.Forms.Button();
            this.txtSearchDisciplines = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объемToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наборстудентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddDisciplines
            // 
            this.btnAddDisciplines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnAddDisciplines.Location = new System.Drawing.Point(655, 119);
            this.btnAddDisciplines.Name = "btnAddDisciplines";
            this.btnAddDisciplines.Size = new System.Drawing.Size(116, 52);
            this.btnAddDisciplines.TabIndex = 40;
            this.btnAddDisciplines.Text = "Добавить";
            this.btnAddDisciplines.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(43, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 28);
            this.label3.TabIndex = 39;
            this.label3.Text = "Дисциплины";
            // 
            // dgvDisciplines
            // 
            this.dgvDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplines.Location = new System.Drawing.Point(12, 119);
            this.dgvDisciplines.Name = "dgvDisciplines";
            this.dgvDisciplines.RowHeadersWidth = 51;
            this.dgvDisciplines.RowTemplate.Height = 24;
            this.dgvDisciplines.Size = new System.Drawing.Size(637, 286);
            this.dgvDisciplines.TabIndex = 38;
            // 
            // btnSearchDisciplines
            // 
            this.btnSearchDisciplines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnSearchDisciplines.Location = new System.Drawing.Point(527, 78);
            this.btnSearchDisciplines.Name = "btnSearchDisciplines";
            this.btnSearchDisciplines.Size = new System.Drawing.Size(80, 35);
            this.btnSearchDisciplines.TabIndex = 37;
            this.btnSearchDisciplines.Text = "Поиск";
            this.btnSearchDisciplines.UseVisualStyleBackColor = true;
            // 
            // txtSearchDisciplines
            // 
            this.txtSearchDisciplines.Location = new System.Drawing.Point(59, 84);
            this.txtSearchDisciplines.Name = "txtSearchDisciplines";
            this.txtSearchDisciplines.Size = new System.Drawing.Size(440, 22);
            this.txtSearchDisciplines.TabIndex = 36;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяToolStripMenuItem,
            this.объемToolStripMenuItem,
            this.наборстудентовToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться назад";
            // 
            // объемToolStripMenuItem
            // 
            this.объемToolStripMenuItem.Name = "объемToolStripMenuItem";
            this.объемToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.объемToolStripMenuItem.Text = "Объем учебной нагрузки";
            // 
            // наборстудентовToolStripMenuItem
            // 
            this.наборстудентовToolStripMenuItem.Name = "наборстудентовToolStripMenuItem";
            this.наборстудентовToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.наборстудентовToolStripMenuItem.Text = "Набор студентов";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // Disciplines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.btnAddDisciplines);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDisciplines);
            this.Controls.Add(this.btnSearchDisciplines);
            this.Controls.Add(this.txtSearchDisciplines);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Disciplines";
            this.Text = " Дисциплины";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddDisciplines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDisciplines;
        private System.Windows.Forms.Button btnSearchDisciplines;
        private System.Windows.Forms.TextBox txtSearchDisciplines;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объемToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наборстудентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}