//using TH = FormMain.ThreadNumberTask;
using System;
using System.Numerics;

namespace FormMain
{
    public partial class Form1 : Form
    {
        event EventHandler<EventCreatorEventArgs>? CreatorListBoxSimple;
        event EventHandler<EventCreatorEventArgs>? CreatorListBoxFibbonacchi;
        Thread fibbonachiThread;
        Thread simpleThread;
        public Form1()
        {
            InitializeComponent();
            CreatorListBoxSimple += OnRandCreatedSimple;
            CreatorListBoxFibbonacchi += OnRandCreatedFibbonachi;
        }

        public static long? ConvertTxt(string text)
        {
            if (long.TryParse(text, out var result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        private void startSimpleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                simpleThread = new Thread(() =>
                {

                    long start = ConvertTxt(minTb.Text) ?? 2;
                    long? end = ConvertTxt(maxTb.Text);
                    ThreadNumberTask.GenerateNumbers(ThreadNumberTask.IsSimple(), CreatorListBoxSimple, start, end);
                }
                );
                simpleThread.IsBackground = true;
                simpleThread.Start();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startFibbonachiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                fibbonachiThread = new Thread(() =>
                {

                    long start = ConvertTxt(minTb.Text) ?? 2;
                    long end = ConvertTxt(maxTb.Text) ?? long.MaxValue;
                    ThreadNumberTask.GenerateFibonacci(CreatorListBoxFibbonacchi, start, end);
                }
                );
                fibbonachiThread.IsBackground = true;
                fibbonachiThread.Start();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OnRandCreatedSimple(object? sender, EventCreatorEventArgs e)
        {

            BeginInvoke(new Action(() =>
            {
                simpleListBox.Items.Add(e.Number);
            }));

        }

        private void OnRandCreatedFibbonachi(object? sender, EventCreatorEventArgs e)
        {

            BeginInvoke(new Action(() =>
            {
                fibbListBox.Items.Add(e.Number);
            }));

        }


        private void pauseSimpl_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
        }

        private void simpleStop_Click(object sender, EventArgs e)
        {
            if (simpleThread != null && simpleThread.IsAlive)
            {
                //simpleThread.Abort(); не работает на этой версии 
            }
        }
    }
}
