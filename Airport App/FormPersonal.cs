using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airport_App.Manager;

namespace Airport_App
{
    public partial class FormPersonal : Form
    {
        
        public FormPersonal()
        {
            InitializeComponent();
            PersonalManager.loadData();
            updateDataGrid();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        public void updateDataGrid ()
        {
            dg.Rows.Clear();

            string name_;
            string surname_;
            string patronymic_;
            string hbd_;
            string jobTitle_;
            string password_;

            for (int i = 0; i < PersonalManager.getPersonalCount(); i++)
            {
                int rowId = dg.Rows.Add();
                DataGridViewRow d = dg.Rows[rowId];
                String[] v = PersonalManager.getEmployee(i);               

                name_       = v[0];
                surname_    = v[1];
                patronymic_ = v[2];
                hbd_        = v[3];
                jobTitle_   = v[4];
                password_   = v[5];

                d.Cells["dgName"].Value         = name_;
                d.Cells["dgSurname"].Value      = surname_;
                d.Cells["dgPatronymic"].Value   = patronymic_;
                d.Cells["dgHbd"].Value          = hbd_;
                d.Cells["dgJobTitle"].Value     = jobTitle_;
                d.Cells["dgPassword"].Value     = password_;

            }
        }

        public void addHuman ()
        {
            string name_       = name.Text;
            string surname_    = surname.Text;
            string patronymic_ = patronymic.Text;
            string hbd_        = hbd.Text;
            string jobTitle_   = jobTitle.Text;
            string password_   = password.Text;

            if (String.IsNullOrWhiteSpace(name_) || String.IsNullOrWhiteSpace(surname_) || String.IsNullOrWhiteSpace(patronymic_) || String.IsNullOrWhiteSpace(hbd_) || String.IsNullOrWhiteSpace(jobTitle_))
            {
                MessageBox.Show("Один или несколько строк не было заполнено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PersonalManager.addEmloyee(name_,surname_,patronymic_,hbd_,jobTitle_, password_);

            updateDataGrid();
        }
        public void deleteHuman ()
        {
            if (dg.RowCount == 0) return;
            PersonalManager.removeEmployee(dg.CurrentCell.RowIndex);

            updateDataGrid();
        }

        public void closeForm()
        {
            mainForm.formEnable = false;
        }



        public void saveDB ()
        {
            PersonalManager.saveData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addHuman();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteHuman();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveDB();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                closeForm();
                this.Close();
            }
        }

        private void FormPersonal_FormClosed(object sender, FormClosedEventArgs e)
        {
            closeForm();
        }
    }
}
