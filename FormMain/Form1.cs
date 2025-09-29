
using System.Numerics;

namespace FormMain
{
    public partial class Form1 : Form
    {
        event EventHandler<EventCreatorEventArgs>? CreatorListBoxSimple;
        event EventHandler<EventCreatorEventArgs>? CreatorListBoxFibbonacchi;
        private Thread? SimpleThread;
        private Thread? FibbonachiThread;
        /// <summary>
        /// CancellationToken — это структура в .NET, которая используется для управления отменой работы асинхронных или длительных операций, например, задач (Task) или потоков (Thread).
        /// </summary>

        ControlTokens? ForSimple = null;
        ControlTokens? ForFibbonachi = null;

        private BigInteger tempSimpleNumberStart;
        private BigInteger? tempSimpleNumberEnd;
        private BigInteger tempFibNumberStart;
        private BigInteger? tempFibNumberEnd;

        public Form1()
        {
            InitializeComponent();
            CreatorListBoxSimple += OnRandCreatedSimple;
            CreatorListBoxFibbonacchi += OnRandCreatedFibbonachi;
        }

        public static BigInteger? ConvertTxt(string text)
        {
            if (BigInteger.TryParse(text, out var result))
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
            simpleListBox.Items.Clear();

            tempSimpleNumberStart = ConvertTxt(minTb.Text) ?? 2;
            tempSimpleNumberEnd = ConvertTxt(maxTb.Text);

            try
            {
                StartSimple(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startFibbonachiBtn_Click(object sender, EventArgs e)
        {
            fibbListBox.Items.Clear();

            tempFibNumberStart = ConvertTxt(fbMinTb.Text) ?? 2;
            tempFibNumberEnd = ConvertTxt(fbMaxTb.Text);
  
            try
            {
                StartFibbonachi(sender, e);
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
        private void simpleStop_Click(object sender, EventArgs e)
        {
            // 1. Останавливаем токен
            ForSimple?.Stop();

            // 2. Ждём завершения потока
            SimpleThread?.Join();

            // 3. Удаляем токен
            ForSimple?.Dispose();
            ForSimple = null;
        }

        private void pauseSimpl_Click(object sender, EventArgs e)
        {
            ForSimple?.Pause();
        }

        private void simpleContinue_Click(object sender, EventArgs e)
        {
            ForSimple?.Continue();
        }
        private void simpleRestart_Click(object sender, EventArgs e)
        {
            // 1. Остановить старый поток и дождаться завершения
            ForSimple?.Stop();
            SimpleThread?.Join();
            ForSimple?.Dispose();

            // 2. Создать новый токен
            ForSimple = new ControlTokens();

            // 3. Очистка списка
            simpleListBox.Items.Clear();

            // 4. Запустить поток заново
            StartSimple(sender, e);
        }


        private void StartSimple(object sender, EventArgs e)
        {
            if (ForSimple == null)
                ForSimple = new ControlTokens();

            SimpleThread = new Thread(() =>
            {
                try
                {
                    ThreadNumberTask.GenerateNumbers(ThreadNumberTask.IsSimple(), CreatorListBoxSimple, tempSimpleNumberStart, tempSimpleNumberEnd, ForSimple);
                }
                catch (OperationCanceledException) { }
                catch (Exception ex)
                {
                    BeginInvoke(new Action(() =>
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ));
                }
                finally
                {
                    SimpleThread = null; // безопасно очищаем
                }
            });
            SimpleThread.IsBackground = true;
            SimpleThread.Start();
        }

        private void StartFibbonachi(object sender, EventArgs e)
        {
            if (ForFibbonachi == null)
                ForFibbonachi = new ControlTokens();
            {
                FibbonachiThread = new Thread(() =>
                {
                    try
                    {
                        ThreadNumberTask.GenerateFibonacci(CreatorListBoxFibbonacchi, tempFibNumberStart, tempFibNumberEnd, ForFibbonachi);
                    }
                    catch (OperationCanceledException)
                    {
                        //можно игнорировать, оно тут просто что бы не мешало
                    }
                    catch (Exception ex)
                    {
                        BeginInvoke(new Action(() =>
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ));
                    }
                    finally
                    {
                        FibbonachiThread = null; // безопасно очищаем
                    }

                });

                FibbonachiThread.IsBackground = true;
                FibbonachiThread.Start();
            }
        }

        private void fibbStop_Click(object sender, EventArgs e)
        {
            ForFibbonachi?.Stop();
            FibbonachiThread?.Join();
            ForFibbonachi?.Dispose();
            ForFibbonachi = null;
        }


        private void fibbPause_Click(object sender, EventArgs e)
        {
            ForFibbonachi?.Pause();
        }

        private void fibbContinue_Click(object sender, EventArgs e)
        {
            ForFibbonachi?.Continue();
        }
        private void fibbRestart_Click(object sender, EventArgs e)
        {
            ForFibbonachi?.Stop();
            FibbonachiThread?.Join();
            ForFibbonachi?.Dispose();

            ForFibbonachi = new ControlTokens();
            fibbListBox.Items.Clear();
            StartFibbonachi(sender, e);
        }

    }
}
