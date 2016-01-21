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

        String key;
        WoWDataParser wdp;
        

        public MainWindow()
        {
            InitializeComponent();
            GetConfig();

            wdp = new WoWDataParser(key);
        }


        private void GetConfig()
        {
            key = "p8tpyrde4q9angm2zbvgqccxycaw6jsz";
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
            MethodInvoker asynTask = new MethodInvoker(GetData);
            asynTask.BeginInvoke(null, null);
        }

        private void GetData()
        {
            BT_Run.Invoke(new Action(() => BT_Run.Enabled = false));
            ChangeStatus(Status.Working);

            GetGuildsList();
            GetCharactersLists();
            GetUsefulData();
            
            PrintResults();

            ChangeStatus(Status.Done);
            BT_Run.Invoke(new Action(() => BT_Run.Enabled = true));
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


        }


        private void PrintResults()
        {
            TB_Logs.Invoke(new Action(() => TB_Logs.AppendText("\nRESULTS:\n")));

            wdp.dictionary.GuildCount();

        }


        private void GetUsefulData()
        {


        }

        private void BT_GetGuilds_Click(object sender, EventArgs e)
        {

        }


    }
}
