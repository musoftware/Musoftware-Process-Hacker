using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using GetObjectX;

namespace Musoftware_Process_Hacker
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void ProList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InLoad(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Loading";
            backgroundWorker1.RunWorkerAsync();
            button1.Enabled = false;
        }

        MusoftwareGetobject Processing = new MusoftwareGetobject();

        private void InWork(object sender, DoWorkEventArgs e)
        {
            Processing.GetX(ImageList2);

 
        }

        private void AfterDone(object sender, RunWorkerCompletedEventArgs e)
        {
            ProList.Items.Clear();

            foreach(ListViewItem item in Processing.lvitemCollection)
            {
                ProList.Items.Add(item);
            }
            ProList.Refresh();
            ProList.Sorting = SortOrder.Ascending;
            ProList.Sorting = SortOrder.None;
            toolStripStatusLabel2.Text = "Loaded";
            ProList.Enabled = true;
            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = Convert.ToInt32(Processing.PressValue);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            ProList.Enabled = false;
            button1.Enabled = false;
            backgroundWorker1.RunWorkerAsync();

        }
        Main2 mn = new Main2();

        private void KillCheckedProcess_Click(object sender, EventArgs e)
        {
            if ((ProList.CheckedItems.Count <= 0)) {
                MessageBox.Show("Mark CheckBox of process to Terminate.");
                return;
            }
            ArrayList Eventlist;
            Eventlist = new ArrayList();
            Eventlist.Clear();
            ArrayList TerminatedID = new ArrayList();
            try {
                //  Sending each id to kill process
                foreach (int content in ProList.CheckedIndices) {
                    Eventlist.AddRange(mn.killProcessById(Convert.ToInt32(ProList.Items[content].SubItems[1].Text.ToString()), true));
                    TerminatedID.Add(content);
                }
            }
            catch (Exception ex) {
                Eventlist.Add("Error at termination Refresh list then Terminate");
                MessageBox.Show("Error at termination Refresh list then Terminate", "Termination Error.");
            }
            // removing terminated process
            TerminatedID.Reverse();
            foreach (Int32 item in TerminatedID) {
                // MsgBox(item.ToString)
                ProList.Items[item].Remove();
            }

 
    
 
        }
    }
}
