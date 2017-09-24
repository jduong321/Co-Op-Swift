using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Co_Op_Swift
{
    public partial class assignTask : Form
    {
        string userName,proj;
        public assignTask(string username, string projName)
        {
            InitializeComponent();
            proj = projName;
            userName = username;
            //SQL.getTasks(taskCB, projName); //this doesnt work for sure
            SQL.getUndoneTask(taskCB, username, projName);
            //SQL.getUserTask(currentLB, username, projName);
            SQL.getProjectMembers(memberLB, username, projName); // i think i made the sql for this right

            
        }

        private void assignTask_Load(object sender, EventArgs e)
        {
            if(!SQL.isManager(userName,proj)) // THIS SQL NEEDS TO BE DONE
            {
              MessageBox.Show("Not a manager. Cannot edit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
                Close();
                
            }
        }

        private void memberLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLB.Items.Clear();
            if(memberLB.SelectedItem !=null)
            {
                string s = memberLB.GetItemText(memberLB.SelectedItem);
                string firstname, lastname;
                string[] substrings = s.Split(' ');

                firstname = substrings[0];
                lastname = substrings[1];
                SQL.getUserTask(currentLB, SQL.getUserID(firstname, lastname), proj);
            }
           
        }

        private void Assign_Click_1(object sender, EventArgs e)
        {
            if (memberLB.Text.Equals(""))
            {
                MessageBox.Show("No user selected.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if (taskCB.Text.Equals(""))
            {
                MessageBox.Show("No Task selected.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                string s = memberLB.GetItemText(memberLB.SelectedItem);
                string firstname, lastname;
                string[] substrings = s.Split(' ');
                firstname = substrings[0];
                lastname = substrings[1];
                SQL.ExecuteAssignTask(SQL.getUserID(firstname, lastname), taskCB.Text, proj); // I THINK THIS SQL WORKS
            }
                
        }
        
    }
}
