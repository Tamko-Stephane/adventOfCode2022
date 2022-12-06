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
            Output10LinesLimitedTbx.AppendLine(GetTheMaximumScoreRockPaperScissorsWithGuidePrt2(InsertionTbx.Text).ToString());
            InsertionTbx.ResetText();
            InsertionTbx.Focus();
        }


        private static long GetTheMaximumScoreRockPaperScissorsWithGuidePrt2(string Text)
        {
            if (string.IsNullOrEmpty(Text) || string.IsNullOrWhiteSpace(Text))
            {
                throw new ArgumentNullException($"{nameof(Text)} can not be empty");
            }

            var roundsPredictions = Text.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            if (roundsPredictions.Length == 0) return 0;

            var winningGuide = new Dictionary<string, string>() { { "C", "X" }, {"B", "Z" }, { "A", "Y" } };
            var losingGuide = new Dictionary<string, string>() { { "C", "Y" }, {"B", "X" }, { "A", "Z" } };
            var drawGuide = new Dictionary<string, string>() { { "A", "X"}, {"B", "Y" }, { "C", "Z" } };
            var valuesShapeSelected = new Dictionary<string, int>() { {"X", 1}, {"Y", 2}, { "Z", 3 }};
            long finalScore = 0;
            foreach (var round in roundsPredictions)
            {
                var leftRightRoundPlay = round.Split(" ");
                if(leftRightRoundPlay.Length >= 2)
                {
                    var key = leftRightRoundPlay[1].ToUpper();
                    var opponentHand = leftRightRoundPlay[0].ToUpper();

                    //shape selected
                    //finalScore += valuesShapeSelected[key];

                    switch (key)
                    {
                        //win
                        case "Z":
                            finalScore+=6;
                            finalScore += valuesShapeSelected[winningGuide[opponentHand]];
                            break;
                        //draw
                        case "Y":
                            finalScore+=3;
                            finalScore += valuesShapeSelected[drawGuide[opponentHand]];
                            break;
                        case "X":                            
                            finalScore += valuesShapeSelected[losingGuide[opponentHand]];
                            break;
                    }          
                }
            }                                                                           

            return finalScore;
        }
        private static long GetTheMaximumScoreRockPaperScissorsWithGuide(string Text)
        {
            if (string.IsNullOrEmpty(Text) || string.IsNullOrWhiteSpace(Text))
            {
                throw new ArgumentNullException($"{nameof(Text)} can not be empty");
            }

            var roundsPredictions = Text.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            if (roundsPredictions.Length == 0) return 0;

            var winningGuide = new Dictionary<string, string>() { {"X", "C"}, {"Z", "B"}, { "Y", "A" }};
            var drawGuide = new Dictionary<string, string>() { {"X", "A"}, {"Y", "B"}, { "Z", "C" }};
            var valuesShapeSelected = new Dictionary<string, int>() { {"X", 1}, {"Y", 2}, { "Z", 3 }};
            long finalScore = 0;
            foreach (var round in roundsPredictions)
            {
                var leftRightRoundPlay = round.Split(" ");
                if(leftRightRoundPlay.Length >= 2)
                {
                    var key = leftRightRoundPlay[1].ToUpper();
                    var opponentHand = leftRightRoundPlay[0].ToUpper();

                    //shape selected
                    finalScore += valuesShapeSelected[key];
                    //win
                    if (winningGuide.Keys.Contains(key) && winningGuide[key] == opponentHand)
                    {
                        finalScore+=6;
                    }
                    //draw
                    if (drawGuide.Keys.Contains(key) && drawGuide[key] == opponentHand)
                    {
                        finalScore += 3;
                    }
                    //lose, 0 added, no operation

                }
            }                                                                           

            return finalScore;
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