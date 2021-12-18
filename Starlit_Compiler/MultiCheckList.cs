using System;
using System.Windows.Forms;

namespace Starlit_Compiler
{
    public partial class MultiCheckList : UserControl
    {
        public MultiCheckList()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public CheckedListBox.ObjectCollection Items
        {
            get => checkList.Items;
        }

        public bool IsChecked(string item)
        {
            int index = checkList.FindStringExact(item);
            if (index == ListBox.NoMatches)
            {
                return false;
            }
            else
            {
                return checkList.GetItemChecked(index);
            }
        }

        private bool AllChecked
        {
            get
            {
                bool allChecked = true;
                for (int i = 0; i < checkList.Items.Count; i++)
                {
                    allChecked &= checkList.GetItemChecked(i);
                }
                return allChecked;
            }
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            bool targetBool = !AllChecked;
            for (int i = 0; i < checkList.Items.Count; i++)
            {
                checkList.SetItemChecked(i, targetBool);
            }
            btnAll.Text = AllChecked ? "Deselect All" : "Select All";
        }

        private void CheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAll.Text = AllChecked ? "Deselect All" : "Select All";
        }
    }
}
