using System.Diagnostics;

namespace Search_algorithms
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        public Form1()
        {
            InitializeComponent();
            InicializarComboBox();
        }
        private void InicializarComboBox()
        {
            cmbMethods.Items.Add("Linear Search");
            cmbMethods.Items.Add("Binary Search");
            cmbMethods.SelectedIndex = 0;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            numbers.Clear();
            lstbNumber.Items.Clear();

            for (int i = 0; i < 100; i++)
            {
                int number = random.Next(1, 1000); 
                numbers.Add(number);
                lstbNumber.Items.Add(number);
            }

           labelResultado.Text = "Correctly generated numbers.";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0)
            {
                MessageBox.Show("First generate the list of numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBoxBuscar.Text))
            {
                MessageBox.Show("please, enter a number search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int valueSearch;
            if (!int.TryParse(textBoxBuscar.Text, out valueSearch))
            {
                MessageBox.Show("Enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string methodSelected = cmbMethods.SelectedItem.ToString();
            int result = -1;
            Stopwatch sw = new Stopwatch();
    
            if (methodSelected == "Linear Search")
            {
                sw.Start();
                result = LinealSearch(numbers, valueSearch);
                sw.Stop();
            }
            else if (methodSelected == "Binary Search")
            {
               
                numbers.Sort();
                lstbNumber.Items.Clear();
                foreach (var num in numbers)
                    lstbNumber.Items.Add(num);

                sw.Start();
                result = BinarySearch(numbers, valueSearch);
                sw.Stop();
            }

          
            if (result != -1)
            {
                labelResultado.Text = $"Number found at position {result}. Time: {sw.ElapsedMilliseconds} ms.";
            }
            else
            {
                labelResultado.Text = $"Number not found. Time: {sw.ElapsedMilliseconds} ms.";
            }
        }

        private int LinealSearch(List<int> list, int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                    return i;
            }
            return -1;
        }

       
        private int BinarySearch(List<int> list, int value)
        {
            int left = 0, right = list.Count - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (list[middle] == value)
                    return middle;
                else if (list[middle] < value)
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            return -1; // No encontrado
        } 
    }
}
