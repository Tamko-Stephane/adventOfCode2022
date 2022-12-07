using System.Text;

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
            Output10LinesLimitedTbx.AppendLine(GetNumberOfAssignementsFullyContainedInAnother(InsertionTbx.Text).ToString());
            InsertionTbx.ResetText();
            InsertionTbx.Focus();
        }


        private static long GetNumberOfAssignementsFullyContainedInAnother(string Text)
        {
            if (string.IsNullOrEmpty(Text) || string.IsNullOrWhiteSpace(Text))
            {
                throw new ArgumentNullException($"{nameof(Text)} can not be empty");
            }

            var pairsOfAssignments = Text.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            if (pairsOfAssignments.Length == 0) return 0;

            int countFullyContained = 0;

            foreach (var pairOfAssignment in pairsOfAssignments)
            {
                var assignments = pairOfAssignment.Split(",", StringSplitOptions.RemoveEmptyEntries);
                var assignmentsElf1 = assignments[0];              
                var assignmentsElf2 = assignments[1];
                if (IsAssignmentsFullyContained(assignmentsElf1, assignmentsElf2))
                    countFullyContained++;
            }                                                                                     

            return countFullyContained;
        }

        private static bool IsAssignmentsFullyContained(string assignmentsElf1, string assignmentsElf2)
        {
            if (assignmentsElf1 == assignmentsElf2) return true;
            string drawingAss1 = GetDrawing(assignmentsElf1);
            string drawingAss2 = GetDrawing(assignmentsElf2);

            if(string.IsNullOrEmpty(drawingAss1) || string.IsNullOrEmpty(drawingAss2)) return false;
            
            if (drawingAss1.Length > drawingAss2.Length)
                return drawingAss1.IndexOf(drawingAss2) > -1;
            else
                return drawingAss2.IndexOf(drawingAss1) > -1;
            
        }

        private static string GetDrawing(string assignments)
        {
            if(string.IsNullOrEmpty(assignments) || string.IsNullOrWhiteSpace(assignments)) return string.Empty;

            var sectionIds = assignments.Split("-", StringSplitOptions.RemoveEmptyEntries);
            var _start = int.Parse(sectionIds[0]);
            var _end = int.Parse(sectionIds[1]);
            //if(_start == _end) return sectionIds[0];
            StringBuilder result=new();
            //if(_start < _end)
            //{
            for (int i = _start; i < _end+1; i++)
            {                
                result.Append("." + i);               
            }
            //}
            //else
            //{
            //    for (int i = 100; i > 0; i--)
            //    {
            //        if (i = _start || i <= _end)
            //            result.Append("." + i);
            //        else
            //            result.Append('.');
            //    }
            //}
            return result.ToString();
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