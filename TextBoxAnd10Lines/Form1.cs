namespace TextBoxAnd10Lines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InsertTextInto10LinesTbx(object sender, MouseEventArgs e)
        {
            InsertNewText();
        }

        private void InsertNewText()
        {
            InsertBtn.Enabled = false;
            Output10LinesLimitedTbx.AppendLine(GetTheMaximumElfCalories(InsertionTbx.Text).ToString());
            InsertionTbx.ResetText();
            InsertionTbx.Focus();
        }


        private static long GetTheMaximumElfCalories(string Text)
        {
            if (string.IsNullOrEmpty(Text) || string.IsNullOrWhiteSpace(Text))
            {
                throw new ArgumentNullException($"{nameof(Text)} can not be empty");
            }

            var maxElfCaloriesTop3 = Text.Split("\r\n\r\n", StringSplitOptions.RemoveEmptyEntries).Select(c => c.Split("\r\n").Select(cal => long.Parse(cal)).Sum())
                                .OrderByDescending(a => a).Take(3);
                                
            var sumCaloriesTop3 = maxElfCaloriesTop3.Sum();


            return sumCaloriesTop3;
        }

        private void ChangeInsertBtnState(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InsertionTbx.Text) &&
                !string.IsNullOrWhiteSpace(InsertionTbx.Text))
            {
                InsertBtn.Enabled = true;
                return;
            }
            InsertBtn.Enabled = false;
        }
      

        private void OnEnterHit(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrEmpty(InsertionTbx.Text) &&
                            !string.IsNullOrWhiteSpace(InsertionTbx.Text))
                {
                    InsertNewText();
                }
            }
        }
    }
}