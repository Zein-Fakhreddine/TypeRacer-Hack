using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EreflectTrainer
{
    public partial class Form1 : Form
    {

        private Boolean runOnce = true;
        private int i = 0;
        private System.Timers.Timer timer;
        private String[] answers;
        private int time = 500;
        public Form1()
        {
            InitializeComponent();

            timer = new System.Timers.Timer(time);
            txtTime.Text = time.ToString();
            wbTypeRacer.ScriptErrorsSuppressed = true;
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            runOnce = false;
            var links = wbTypeRacer.Document.GetElementsByTagName("div");

            foreach(HtmlElement link in links)
            {
                if (link.GetAttribute("className") == "nonHideableWords unselectable")
                    txtData.Text = link.InnerText;
            }
            answers = txtData.Text.Split(' ');
            i = 0;
        }

        private void wbTypeRacer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (runOnce) 
                return;

            runOnce = true;
            timer.Enabled = true;
            timer.AutoReset = true;
            timer.Elapsed += (s_, e_) => OnTimerElapsed(answers[i]);
      
            return;
        }

        private void OnTimerElapsed(string receiver)
        {
            SendKeys.SendWait(receiver);
            SendKeys.SendWait(" ");
            if (i != (answers.Length - 1))
                i++;
            else
                timer.Enabled = false;
        }

        private void wbTypeRacer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtUrl.Text = wbTypeRacer.Url.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setTime(time + 100);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            setTime(time - 100);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setTime(500);
        }

        private void setTime(int newTime)
        {
            time = newTime;
            if (time < 100)
                time = 100;
            timer = new System.Timers.Timer(time);
            txtTime.Text = time.ToString();
            if (time < 500)
                lblWarning.Text = "*Time under 500ms is discouraged  \n as it makes you susceptible to being \n caught as a cheater and causes unwanted glithces";
            else if (time >= 500)
                lblWarning.Text = "";
        }

    }
}
