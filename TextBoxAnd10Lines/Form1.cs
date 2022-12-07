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
            Output10LinesLimitedTbx.AppendLine(GetSumOfPrioritiesOfItemsGroup(InsertionTbx.Text).ToString());
            InsertionTbx.ResetText();
            InsertionTbx.Focus();
        }


        private static long GetSumOfPrioritiesOfItemsGroup(string Text)
        {
            if (string.IsNullOrEmpty(Text) || string.IsNullOrWhiteSpace(Text))
            {
                throw new ArgumentNullException($"{nameof(Text)} can not be empty");
            }

            var rucksacks = Text.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            if (rucksacks.Length == 0) return 0;

            var lowerCasePriorities = new Dictionary<char, int>() { { 'a', 1 }, { 'b', 2 }, { 'c', 3 }, { 'd', 4 }, { 'e', 5 }, { 'f', 6 },
                { 'g', 7 }, { 'h', 8 }, { 'i', 9 }, { 'j', 10 }, { 'k', 11 }, { 'l', 12 }, { 'm', 13 }, { 'n', 14 }, { 'o', 15 }, { 'p', 16 },
            { 'q', 17 }, { 'r', 18 }, { 's', 19 }, { 't', 20 }, { 'u', 21 }, { 'v', 22 }, { 'w', 23 }, { 'x', 24 }, { 'y', 25 }, { 'z', 26 }};
            
            var upperCasePriorities = new Dictionary<char, int>() { { 'A', 27 }, { 'B', 28 }, { 'C', 29 }, { 'D', 30 }, { 'E', 31 }, { 'F', 32 },
                { 'G', 33 }, { 'H', 34 }, { 'I', 35 }, { 'J', 36 }, { 'K', 37 }, { 'L', 38 }, { 'M', 39 }, { 'N', 40 }, { 'O', 41 }, { 'P', 42 },
            { 'Q', 43 }, { 'R', 44 }, { 'S', 45 }, { 'T', 46 }, { 'U', 47 }, { 'V', 48 }, { 'W', 49 }, { 'X', 50 }, { 'Y', 51 }, { 'Z', 52 }};

            int sumOfPriority = 0;
            int NumberOfRuckSacksPerGroup = 3;
            int numberOfGroups = rucksacks.Length / NumberOfRuckSacksPerGroup;
            for (int i = 0; i < numberOfGroups; i++)
            {
                int key = i * NumberOfRuckSacksPerGroup;
                var gpRucksack1 = rucksacks[key];
                var gpRucksack2 = rucksacks[key+1];
                var gpRucksack3 = rucksacks[key+2];
                var gpBadgeItem = gpRucksack1.FirstOrDefault(c=>gpRucksack2.Contains(c) && gpRucksack3.Contains(c));
                sumOfPriority += GetCharacterPriority(gpBadgeItem, lowerCasePriorities, upperCasePriorities);
            }                                                                                     

            return sumOfPriority;
        }

        private static long GetSumOfPrioritiesOfItems(string Text)
        {
            if (string.IsNullOrEmpty(Text) || string.IsNullOrWhiteSpace(Text))
            {
                throw new ArgumentNullException($"{nameof(Text)} can not be empty");
            }

            var rucksacks = Text.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            if (rucksacks.Length == 0) return 0;

            var lowerCasePriorities = new Dictionary<char, int>() { { 'a', 1 }, { 'b', 2 }, { 'c', 3 }, { 'd', 4 }, { 'e', 5 }, { 'f', 6 },
                { 'g', 7 }, { 'h', 8 }, { 'i', 9 }, { 'j', 10 }, { 'k', 11 }, { 'l', 12 }, { 'm', 13 }, { 'n', 14 }, { 'o', 15 }, { 'p', 16 },
            { 'q', 17 }, { 'r', 18 }, { 's', 19 }, { 't', 20 }, { 'u', 21 }, { 'v', 22 }, { 'w', 23 }, { 'x', 24 }, { 'y', 25 }, { 'z', 26 }};

            var upperCasePriorities = new Dictionary<char, int>() { { 'A', 27 }, { 'B', 28 }, { 'C', 29 }, { 'D', 30 }, { 'E', 31 }, { 'F', 32 },
                { 'G', 33 }, { 'H', 34 }, { 'I', 35 }, { 'J', 36 }, { 'K', 37 }, { 'L', 38 }, { 'M', 39 }, { 'N', 40 }, { 'O', 41 }, { 'P', 42 },
            { 'Q', 43 }, { 'R', 44 }, { 'S', 45 }, { 'T', 46 }, { 'U', 47 }, { 'V', 48 }, { 'W', 49 }, { 'X', 50 }, { 'Y', 51 }, { 'Z', 52 }};

            int sumOfPriority = 0;
            foreach (var rucksack in rucksacks)
            {
                if (string.IsNullOrEmpty(rucksack) || string.IsNullOrWhiteSpace(rucksack)) continue;

                int numberOfItems = rucksack.Length;
                var leftCompartment = rucksack[..(numberOfItems / 2)];
                var rightCompartment = rucksack[(numberOfItems / 2)..];
                var itemInBoth = leftCompartment.FirstOrDefault(c => rightCompartment.Contains(c));
                sumOfPriority += GetCharacterPriority(itemInBoth, lowerCasePriorities, upperCasePriorities);
                            
            }

            return sumOfPriority;
        }

        private static int GetCharacterPriority(char character, Dictionary<char, int> lowerCasePriorities, Dictionary<char, int> upperCasePriorities)
        {            
            if(lowerCasePriorities.ContainsKey(character))
                return lowerCasePriorities[character];
            if(upperCasePriorities.ContainsKey(character))
                return upperCasePriorities[character];
         return 0;
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