using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace TASS
{
    public partial class MainWindow : Form
    {
        enum Status
        {
            Nothing,
            Working,
            Done,
            Error,
            Unknown
        };

        WoWDataParser wdp;
        

        public MainWindow()
        {
            InitializeComponent();
            GetConfig();

            wdp = new WoWDataParser();
        }


        private void GetConfig()
        {
        }

        private void ChangeStatus(Status status)
        {
            String text = "";
            System.Drawing.Color color = System.Drawing.Color.Black;

            switch(status)
            {
                case Status.Nothing:
                    text = "";
                    color = System.Drawing.Color.Black;
                    break;
                case Status.Working:
                    text = "Getting data...";
                    color = System.Drawing.Color.Orange;
                    break;
                case Status.Done:
                    text = "Done!";
                    color = System.Drawing.Color.Green;
                    break;
                case Status.Error:
                    text = "Error!";
                    color = System.Drawing.Color.Red;
                    break;

            }


            if(L_Status.InvokeRequired)
            {
                L_Status.Invoke(new Action(() => { L_Status.Text = text; L_Status.ForeColor = color; }));
            }
            else
            {
                L_Status.Text = text; 
                L_Status.ForeColor = color;
            }
            

        }

        private void BT_Run_Click(object sender, EventArgs e)
        {
            wdp.SetKey(TB_Key.Text);
            MethodInvoker asynTask = new MethodInvoker(GetData);
            asynTask.BeginInvoke(null, null);
        }

        private void GetData()
        {
            WorkingState(true);

            GetCharactersLists();
            
            PrintResults();

            WorkingState(false);
        }

        void GetCharactersLists()
        {
            TB_Logs.Invoke(new Action(() => TB_Logs.AppendText("Getting characters...\n")));
            String[] guilds = null;
            TB_Guilds.Invoke(new Action(() => guilds = TB_Guilds.Lines));

            foreach(String guild in guilds)
            {
                wdp.getMembersItemLevel(TB_RealmName.Text, guild);
                TB_Logs.Invoke(new Action(() => TB_Logs.AppendText("\tGet " + guild + " characters\n")));
            }
        }

        private void GetGuildsList()
        {
            WorkingState(true);

            String[] guilds = WoWScrapper.GetGuildNames(TB_ScrapAddress.Text);
            TB_Guilds.Invoke(new Action(() => TB_Guilds.Lines = guilds));
            
            WorkingState(false);
        }


        private void PrintResults()
        {
            TB_Logs.Invoke(new Action(() => TB_Logs.AppendText("\nRESULTS:\n")));

            wdp.dictionary.GuildCount();

        }


        private void BT_GetGuilds_Click(object sender, EventArgs e)
        {

            MethodInvoker asynTask = new MethodInvoker(GetGuildsList);
            asynTask.BeginInvoke(null, null);
        }

        private void TB_Key_TextChanged(object sender, EventArgs e)
        {
            if (TB_Key.Text == "" || TB_Key.Text == String.Empty)
                BT_Run.Enabled = false;
            else
                BT_Run.Enabled = true;
        }

        private void WorkingState(bool isWorking)
        {
            if(isWorking)
                ChangeStatus(Status.Working);
            else
                ChangeStatus(Status.Done);

            BT_Run.Invoke(new Action(() => BT_Run.Enabled = !isWorking));
            BT_GetGuilds.Invoke(new Action(() => BT_GetGuilds.Enabled = !isWorking));
            TB_Guilds.Invoke(new Action(() => TB_Guilds.Enabled = !isWorking));
            TB_Key.Invoke(new Action(() => TB_Key.Enabled = !isWorking));
            TB_RealmName.Invoke(new Action(() => TB_RealmName.Enabled = !isWorking));
            TB_ScrapAddress.Invoke(new Action(() => TB_ScrapAddress.Enabled = !isWorking));
            TB_RealmName2.Invoke(new Action(() => TB_RealmName2.Enabled = !isWorking));
            TB_Result.Invoke(new Action(() => TB_Result.Enabled = !isWorking));
        }

        private void TB_ScrapAddress_TextChanged(object sender, EventArgs e)
        {
            if (TB_ScrapAddress.Text == "" || TB_ScrapAddress.Text == String.Empty)
                BT_GetGuilds.Enabled = false;
            else
                BT_GetGuilds.Enabled = true;
        }

        private void BT_ComputeIL_Click(object sender, EventArgs e)
        {
            MethodInvoker asynTask = new MethodInvoker(GetGuildsList);
            asynTask.BeginInvoke(null, null);
        }

        private void Compute()
        {
            WorkingState(true);

            String name = TB_RealmName2.Text;
            String [] result = wdp.ComputeGuildsItemLevel(name);

            TB_Result.Invoke(new Action(() => TB_Result.Lines = result));

            WorkingState(false);
        }

    }
}
