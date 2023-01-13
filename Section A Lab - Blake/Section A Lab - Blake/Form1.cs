namespace Section_A_Lab___Blake
{
    public partial class Form1 : Form
    {

        const int ARRAYSIZE = 30;
        int[] myArray = new int[ARRAYSIZE];

        public Form1()
        {
            InitializeComponent();  
        }

        void Clear()
        {
            lstOutput.Items.Clear();
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            Clear();
            //Fills array with random numbers between 1-100 inclusive. display in listbox with do-while loop.
            Random rand = new Random();
            for (int i = 0; i < myArray.Length; i++)
                    myArray[i] = rand.Next(0, 101);
            do
            {
                

                for (int i = 0; i < myArray.Length; i++)
                    lstOutput.Items.Add(myArray[i]);
            }
            while (false);
 
        }

        
        private void btnLoopArray_Click(object sender, EventArgs e)
        {
           
            //loop through array and add up all values and display sum in listbox.
            decimal sum = 0;
            for (int i = 0; i < myArray.Length; i++)
                sum += Convert.ToDecimal(lstOutput.Items[i]);
            lstOutput.Items.Clear();
            lstOutput.Items.Add("The Sum of all of the values is: " + sum.ToString());

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //displays amount of Values based on what user inputs into value textbox
            //select which subscript to start on.
            Random rand = new Random();
            try
            {
                lstOutput.Items.Clear();
                int ValArray = 0;
                int Script = 0;
                int SubScript = 0;


                Script = int.Parse(txtStrt.Text);
                SubScript = int.Parse(txtVal.Text);

                int[] subArray = new int[SubScript];

                for (int i = Script; i < SubScript; i++)
                {
                    subArray[i] = rand.Next(0, 101);
                    ValArray = subArray[i];
                    lstOutput.Items.Add($"Subscript {Script}: [" + subArray[i] + "]");
                    Script++;
                }

            }
            catch
            {
                MessageBox.Show("Input not accepted, try again with new value");
            }
            
        }
    }
}