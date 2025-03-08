using System.Data;

namespace EasyNotes_using_C_
{
    public partial class easyNotes : Form
    {
        public easyNotes()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        bool editing = false;
        private void easyNotes_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Title");
            dt.Columns.Add("Notes");

            pastNotes.DataSource = dt;
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt.Rows.Count > 0)
                {
                    newNotesTitle.Text = dt.Rows[pastNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
                    newNotesBox.Text = dt.Rows[pastNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
                    editing = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No notes to load");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                dt.Rows[pastNotes.CurrentCell.RowIndex]["Title"] = newNotesTitle.Text;
                dt.Rows[pastNotes.CurrentCell.RowIndex]["Notes"] = newNotesBox.Text;
                editing = true;
            }
            else
            {
                dt.Rows.Add(newNotesTitle.Text,newNotesBox.Text);
            }
            newNotesTitle.Text = "";
            newNotesBox.Text = "";
            editing = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Rows[pastNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not a valid notes");
            }
        }
    }
}
