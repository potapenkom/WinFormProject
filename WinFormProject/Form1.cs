using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.Models;

namespace WinFormProject
{
    public partial class Form1 : Form
    {
        int id = 0;
        Employee model = new Employee();

        public Form1()
        {
            InitializeComponent();
            bindGridView();
        }

       void bindGridView()
        {
            using (EmployeeDBEntities db = new EmployeeDBEntities())
            {
                DataField.DataSource = db.Employee.ToList<Employee>();
            }
            
        }

        void resetControls()
        {
            using (EmployeeDBEntities db = new EmployeeDBEntities())
            {
                forName.Clear();
                forSurname.Clear();
                forAge.Clear();
                forGender.SelectedItem = null;
                forDivision.Clear();
            }
           
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            using (EmployeeDBEntities db = new EmployeeDBEntities())
            {
                model.name = forName.Text.Trim();
                model.surname = forSurname.Text.Trim();
                model.age = Convert.ToInt32(forAge.Text.Trim());
                model.gender = forGender.SelectedItem.ToString();
                model.devision = forDivision.Text.Trim();
                db.Employee.Add(model);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    MessageBox.Show("Data Inserted Sussesfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindGridView();
                    resetControls();
                }
                else
                {
                    MessageBox.Show("Data Insertion failed!!!", "Failued", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
         
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            resetControls();
        }


        private void DataField_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (EmployeeDBEntities db = new EmployeeDBEntities())
            {
                id = Convert.ToInt32(DataField.SelectedRows[0].Cells[0].Value);
                model = db.Employee.Where(x => x.id == id).FirstOrDefault();
                forName.Text = model.name;
                forSurname.Text = model.surname;
                forAge.Text = model.age.ToString();
                forGender.SelectedItem = model.gender;
                forDivision.Text = model.devision;
            }
           
        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (EmployeeDBEntities db = new EmployeeDBEntities())
            {
                model.id = id;
                model.name = forName.Text.Trim();
                model.surname = forSurname.Text.Trim();
                model.age = Convert.ToInt32(forAge.Text.Trim());
                model.gender = forGender.SelectedItem.ToString();
                model.devision = forDivision.Text.Trim();
                db.Entry(model).State = EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    MessageBox.Show("Data Updated Sussesfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindGridView();
                    resetControls();
                }
                else
                {
                    MessageBox.Show("Data Updation failed!!!", "Failued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }  
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (EmployeeDBEntities db = new EmployeeDBEntities())
            {
                DialogResult dr = MessageBox.Show("Are you sure???", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    model = db.Employee.Where(x => x.id == id).FirstOrDefault();
                    db.Entry(model).State = EntityState.Deleted;
                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        MessageBox.Show("Data Deleted Sussesfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindGridView();
                        resetControls();
                    }
                    else
                    {
                        MessageBox.Show("Data Deletion failed!!!", "Failued", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("You have cancelled this operation");
                }

            }
        }

        private void forSearch_TextChanged(object sender, EventArgs e)
        {
            using (EmployeeDBEntities db = new EmployeeDBEntities())
            {
                if (forSearch.Text != string.Empty)
                {
                    var items = db.Employee.Where(x => x.name.Contains(forSearch.Text) || x.surname.Contains(forSearch.Text) || x.gender.Contains(forSearch.Text) || x.devision.Contains(forSearch.Text));
                    DataField.DataSource = items.ToList<Employee>();
                }
                else
                {
                    bindGridView();
                }
            }
        }
    }
}
