using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using static InternshipTask.Form2;

namespace InternshipTask
{
    public partial class ShowEmployee : Form
    {
        public ShowEmployee()
        {
            InitializeComponent();
        }

        private void ShowEmployee_Load(object sender, EventArgs e)
        {
            Text = "Сотрудники";
            ToolStripMenuItem deleteStaff = new ToolStripMenuItem("Удалить сотрудника");
            ToolStripMenuItem showStuff = new ToolStripMenuItem("Открыть личные данные");

            contextMenuStrip1.Items.AddRange(new[] { showStuff, deleteStaff });
            deleteStaff.Click += deleteStaff_Click;
            showStuff.Click += OpenEmployee;


        }

        public void showEmpl(TreeNode node)
        {
            Database.SetInitializer<TestDBContext>(null);
            using (TestDBContext db = new TestDBContext())
            {
                var Data = db.Employees;
                departName.Text = node.Text;
                foreach (empoyee man in Data)
                {
                    if (node.Tag.Equals(man.DepartmentID))
                    {
                        
                        listView1.Items.Add(man.FirstName + " " + man.SurName + ": " + man.Position);
                        int k = listView1.Items.Count - 1;
                        listView1.Items[k].Tag = man.ID;
                    }


                }

            }

        }
        
        public void getNewList(empoyee emp, string dep)
        {
            if (departName.Text == dep)
            {
                ListViewItem l1 = new ListViewItem();
                l1.Text = emp.FirstName + " " + emp.SurName + ": " + emp.Position;
                l1.Tag = emp.ID;


                listView1.Items.Add(l1);
            }
        }
        public void updateList(empoyee emp, string dep)
        {
            if (departName.Text == dep)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Tag.Equals(emp.ID))
                    {
                        listView1.Items[i].Text = emp.FirstName + " " + emp.SurName + ": " + emp.Position;
                        break;
                    }
                }
            
            }
        }

        public ListViewItem global_employee;
        public void deleteStaff_Click(object sender, EventArgs e)
        {
            if (global_employee != null)
            {
                Database.SetInitializer<TestDBContext>(null);
                using (TestDBContext db = new TestDBContext())
                {
                    decimal id = Convert.ToDecimal(global_employee.Tag);
                    empoyee man = db.Employees.Where(c => id == c.ID).First();
                    db.Employees.Remove(man);
                    db.SaveChanges();
                    listView1.Items.Remove(global_employee);
                    MessageBox.Show("Данные удалены");


                }
            }
        }

       private void OpenEmployee(object sender, EventArgs e)
        {
            if (global_employee != null)
            {
                Employee em = new Employee();
                em.Show();
                em.getShow(this);


                em.LoadEmployee(global_employee);
            }
        }

        private void OpenEmployee(object sender, MouseEventArgs e)
        {
            if (global_employee != null)
            {
                ListViewItem Employ = listView1.GetItemAt(e.Location.X, e.Location.Y);
                Employee em = new Employee();
                em.Show();
                em.getShow(this);

                em.LoadEmployee(Employ);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Show();
            em.getShow(this);
            em.newEmployee(departName.Text);
           
        }

        private void getMenu(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {


                
                ListViewItem Employ = listView1.GetItemAt(e.Location.X, e.Location.Y);

                listView1.ContextMenuStrip = contextMenuStrip1;
                global_employee = Employ;

            }
            
            }
    }
}
