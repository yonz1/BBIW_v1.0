using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_cs
{
    public partial class FormPre_defined : Form
    {
        public FormPre_defined()
        {
            InitializeComponent();
        }

        private void Fastbtn_Click(object sender, EventArgs e)
        {

        }

        private void Longbtn_Click(object sender, EventArgs e)
        {
            listBox_result_predef.Items.Clear();
            System.DateTime Date_S = DateTime.Now;
            listBox_result_predef.Items.Add("Scan started at :" + Date_S);
            object command = "python3 ..\\..\\Scan.py  --predefined";
            run_cmd(command);
            //readdb();
            using (StreamReader file = new StreamReader("../../scan_pr.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    listBox_result_predef.Items.Add(ln);
                    counter++;
                }
                file.Close();
            }
            System.DateTime Date_F = DateTime.Now;
            listBox_result_predef.Items.Add("Scan finished at :" + Date_F);
            
        }
        public void run_cmd(object command)
        {
            System.Diagnostics.ProcessStartInfo procstatinfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + command);
            procstatinfo.UseShellExecute = false;
            procstatinfo.CreateNoWindow = true;
            procstatinfo.RedirectStandardOutput = true;
            procstatinfo.RedirectStandardInput = true;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procstatinfo;
            proc.Start();
            proc.WaitForExit();

            /*using (StreamReader file = new StreamReader("../../scan.txt"))
                try
                {
                    Thread objthread = new Thread(new ParameterizedThreadStart(run_cmd));
                    objthread.IsBackground = true;
                    objthread.Priority = ThreadPriority.AboveNormal;
                    objthread.Start(command);
                    if (objthread.ThreadState == System.Threading.ThreadState.Stopped) {
                        int counter = 0;
                        string ln;
                        while ((ln = file.ReadLine()) != null)
                        {
                            listbox_result.Items.Add(ln);
                            counter++;
                        }
                        file.Close();
                        System.DateTime Date_F = DateTime.Now;
                        listbox_result.Items.Add("Scan finished at :" + Date_F);
                    }
            }
            catch (ThreadStartException objexception){ 
            }
            */


        }

        private void listBox_result_predef_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
