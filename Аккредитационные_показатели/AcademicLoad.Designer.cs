
namespace Аккредитационные_показатели
{
    partial class AcademicLoad
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
            this.btnAddAcademic = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAcademicLoad = new System.Windows.Forms.DataGridView();
            this.btnSearchAcademic = new System.Windows.Forms.Button();
            this.txtSearchAcademic = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вернутьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисциплиныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.документомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicLoad)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAcademic
            // 
            this.btnAddAcademic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnAddAcademic.Location = new System.Drawing.Point(655, 124);
            this.btnAddAcademic.Name = "btnAddAcademic";
            this.btnAddAcademic.Size = new System.Drawing.Size(114, 57);
            this.btnAddAcademic.TabIndex = 16;
            this.btnAddAcademic.Text = "Добавить";
            this.btnAddAcademic.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(43, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Объем учебной нагрузки";
            // 
            // dgvAcademicLoad
            // 
            this.dgvAcademicLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcademicLoad.Location = new System.Drawing.Point(12, 124);
            this.dgvAcademicLoad.Name = "dgvAcademicLoad";
            this.dgvAcademicLoad.RowHeadersWidth = 51;
            this.dgvAcademicLoad.RowTemplate.Height = 24;
            this.dgvAcademicLoad.Size = new System.Drawing.Size(637, 286);
            this.dgvAcademicLoad.TabIndex = 13;
            // 
            // btnSearchAcademic
            // 
            this.btnSearchAcademic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnSearchAcademic.Location = new System.Drawing.Point(527, 83);
            this.btnSearchAcademic.Name = "btnSearchAcademic";
            this.btnSearchAcademic.Size = new System.Drawing.Size(80, 35);
            this.btnSearchAcademic.TabIndex = 12;
            this.btnSearchAcademic.Text = "Поиск";
            this.btnSearchAcademic.UseVisualStyleBackColor = true;
            // 
            // txtSearchAcademic
            // 
            this.txtSearchAcademic.Location = new System.Drawing.Point(59, 89);
            this.txtSearchAcademic.Name = "txtSearchAcademic";
            this.txtSearchAcademic.Size = new System.Drawing.Size(440, 22);
            this.txtSearchAcademic.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяToolStripMenuItem,
            this.преподавателиToolStripMenuItem,
            this.дисциплиныToolStripMenuItem,
            this.сохранениеToolStripMenuItem,
            this.справкаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вернутьсяToolStripMenuItem
            // 
            this.вернутьсяToolStripMenuItem.Name = "вернутьсяToolStripMenuItem";
            this.вернутьсяToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.вернутьсяToolStripMenuItem.Text = "Вернуться назад";
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.преподавателиToolStripMenuItem.Text = "Преподаватели";
            // 
            // дисциплиныToolStripMenuItem
            // 
            this.дисциплиныToolStripMenuItem.Name = "дисциплиныToolStripMenuItem";
            this.дисциплиныToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.дисциплиныToolStripMenuItem.Text = "Дисциплины";
            // 
            // сохранениеToolStripMenuItem
            // 
            this.сохранениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.документомToolStripMenuItem,
            this.таблицейToolStripMenuItem});
            this.сохранениеToolStripMenuItem.Name = "сохранениеToolStripMenuItem";
            this.сохранениеToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.сохранениеToolStripMenuItem.Text = "Сохранение";
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(81, 26);
            this.справкаToolStripMenuItem1.Text = "Справка";
            // 
            // документомToolStripMenuItem
            // 
            this.документомToolStripMenuItem.Name = "документомToolStripMenuItem";
            this.документомToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.документомToolStripMenuItem.Text = "Документом";
            // 
            // таблицейToolStripMenuItem
            // 
            this.таблицейToolStripMenuItem.Name = "таблицейToolStripMenuItem";
            this.таблицейToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.таблицейToolStripMenuItem.Text = "Таблицей";
            // 
            // AcademicLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 429);
            this.Controls.Add(this.btnAddAcademic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAcademicLoad);
            this.Controls.Add(this.btnSearchAcademic);
            this.Controls.Add(this.txtSearchAcademic);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AcademicLoad";
            this.Text = "Объем учебной нагрузки";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademicLoad)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAcademic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAcademicLoad;
        private System.Windows.Forms.Button btnSearchAcademic;
        private System.Windows.Forms.TextBox txtSearchAcademic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дисциплиныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem документомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
    }
}