using System.Drawing.Text;

namespace Capstone_Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnParseAnswer_Click(object sender, EventArgs e)
        {
            // Get answer from text box
            string studentAnswer = txtStudentAnswer.Text;

            // Call parsing function
            string parsedResult = ParseAnswer(studentAnswer);

            // Result in label
            lblResult.Text = parsedResult;
        }

            // Parse function that counts number of words
            private string ParseAnswer(string answer){
                var words = answer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return $"Answer contains {words.Length} words";
            }
        }
    }
