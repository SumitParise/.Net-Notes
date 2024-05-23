using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button button1 =new Button();
            button1.Text = "Click Me";

            //inbuilt delegate . A special Class .. whose object 
            //always points to a method which needs to be executed 
            // by CLR at runtime when some Event Happens.
            //We are binding refernce of Method to the delegate white declaring it.
            EventHandler eventHandler = new EventHandler(GreetClient);

            //Click is a event of button class. A special type 
            //whose tells CLR at Runtime what happened.
            button1.Click += eventHandler;
            //You coule Event with Delegate -using coupling operator.(+=)
            // To decouple - use -= : decoupling operator.
             
            this.Controls.Add(button1);
        }
        public void GreetClient(object sender, EventArgs e)
        {
            MessageBox.Show("Hi there !!!");
        }
        public void SayGoodBye(object sender, EventArgs e)
        {
            MessageBox.Show("Bye bye !!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("See you later!!");
        }
    }
}
