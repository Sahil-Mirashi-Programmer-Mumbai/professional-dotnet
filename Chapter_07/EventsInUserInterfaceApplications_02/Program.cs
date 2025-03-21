// Program to demonstrate Events in User Interface Applications in C# with Visual Studio
// Programmer: Sahil Mirashi

namespace EventsInUserInterfaceApplications_02
{
    public class Program : Form
    {
        private Button myButton;

        public Program()
        {
            myButton = new Button
            {
                Text = "Click Me!",
                Location = new System.Drawing.Point(100, 100)
            };

            // Subscribing to the Click event of the button
            myButton.Click += MyButton_Click;

            Controls.Add(myButton);
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }

        [STAThread]
        public static void Main()
        {
            Application.Run(new Program());
        }
    }
}