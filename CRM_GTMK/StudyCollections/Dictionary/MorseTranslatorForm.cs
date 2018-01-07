using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyCollections.Dictionary
{
	public partial class MorseTranslatorForm : Form
	{
		public MorseTranslatorForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			morseCodeBox.Text = MorseTranslator.ToMorse(stringInputBox.Text);
		}
	}
}
