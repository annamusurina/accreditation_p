using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Аккредитационные_показатели
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Fill();
        }

        private void Fill() //заполнение
        {
            cbLevels.DataSource = DBObjects.Entities.EducationLevels.ToList();
            cbDirection.DataSource = DBObjects.Entities.DirectionTraining.ToList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void изменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Data change = new Change_Data();
            change.ShowDialog();
            this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открытие документа
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if(cbLevels.SelectedItem.ToString() != "" && cbDirection.SelectedItem.ToString() != "")
            {
                string level = cbLevels.SelectedItem.ToString();
                string direct = cbDirection.SelectedItem.ToString();

                Chapter chapter = new Chapter(level, direct);
                chapter.ShowDialog();
                Fill();
                this.Close();
            }
            else
            {
                MessageBox.Show("Выберите или добавьте уровень подготовки и направление.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
