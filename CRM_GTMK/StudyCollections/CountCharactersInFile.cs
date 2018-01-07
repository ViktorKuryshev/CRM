using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Async_and_Await
{
    public partial class CountCharactersInFile : Form
    {
        public CountCharactersInFile()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\Users\\Vladimir\\Documents\\Visual Studio 2015\\" + 
                                                          "LearningTask\\Testing_Async_and_Await\\Testing_async_await.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        private async void buttonProcess_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();
            labelResult.Text = "Processing File. Please wait...";
            int count = await task;
            labelResult.Text = count.ToString() + " characters in the file";
        }
    }
}
