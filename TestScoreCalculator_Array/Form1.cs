namespace TestScoreCalculator_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] scores = new int[8];
        int count = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                scores[count] = Convert.ToInt32(txtScore.Text);
                count++;
                int total = 0;

                foreach (int s in scores)
                {
                    total += s;
                }

                int avg = total / count;

                txtScoreTotal.Text = total.ToString();
                txtScoreCount.Text = count.ToString();
                txtAverage.Text = avg.ToString();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
            txtScore.Focus();
            txtScore.Text = "";

        }

        private void btnDisplayScores_Click(object sender, EventArgs e)
        {
            string output = "";

            for (int i = 0; i < count; i++)
            {
                output += scores[i].ToString() + " ";
            }

            MessageBox.Show(output);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            txtScore.Text = "";

            scores = new int[10];
            count = 0;

            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}