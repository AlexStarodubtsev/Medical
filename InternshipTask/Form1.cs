using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Data.Entity;
//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections;

namespace InternshipTask
{
    public class Department
    {
        public Guid Id { get;  set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Nullable<Guid> ParentDepartmentId { get; set; }
    }
    public class empoyee
    {
        public decimal ID { get; set; }
        public Guid DepartmentID { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DocSeries { get; set;}
         public string DocNumber { get; set;}
        public string Position { get; set;}
    }
    public class TestDBContext : DbContext
    {
        
        public TestDBContext()

        :base("TestDB")
        { }
        
        public DbSet<Department> Departments { get; set; }
        public DbSet<empoyee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    

    public partial class Form1 : Form
    {
       // SqlConnection SqlConnect;
        public Form1()
        {
            InitializeComponent();
        }



        private async void Form1_Load(object sender, EventArgs e)
        {
            Database.SetInitializer<TestDBContext>(null);
            using (TestDBContext db = new TestDBContext())
            {
                var deps = from dep in db.Departments where dep.ParentDepartmentId== null select dep;
                
                foreach (Department dep in deps)
                {
                    
                        treeView1.Nodes.Add(dep.Name);
                        int k = treeView1.Nodes.Count - 1;

                    
                       
                        getTree(treeView1.Nodes[k], dep);
                    


                }

              //  for (int i=0; i<treeView1.Nodes.Count; i++)
                
                listBox1.Items.Add(treeView1.Nodes.Count);
                listBox1.Items.Add(treeView1.Nodes[0].Nodes.Count);

                
                
            }


          
        }
        private void getTree(TreeNode Node, Department depr)
        {


            using (TestDBContext db = new TestDBContext())
            {
                var deps = from dep in db.Departments where dep.ParentDepartmentId == depr.Id select dep;
                foreach (Department dep in deps)
                {
                    Node.Nodes.Add(dep.Name);
                    int k = Node.Nodes.Count - 1;
                     getTree(Node.Nodes[k], dep);
                }
            }
               
        }
       
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
