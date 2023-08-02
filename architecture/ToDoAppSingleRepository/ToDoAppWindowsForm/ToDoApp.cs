using Infrastructure;

namespace ToDoAppWindowsForm
{
    public partial class ToDoApp : Form
    {

        private WondersquadRepository _appRepository = new WondersquadRepository();

        public ToDoApp()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            ToDoTask task = new ToDoTask();
            task.TaskId = int.Parse(taskId_TextBox.Text);
            task.UserId = int.Parse(userId_TextBox.Text);
            task.CharacterId = int.Parse(charId_TextBox.Text);
            task.CharacterName = charName_TextBox.Text;
            task.TaskName = taskName_TextBox.Text;
            task.Description = desc_TextBox.Text;
            task.EstimatedCompletionDate = estCompDate_DateTimePicker.Value;
            task.IsCompleted = isCompleted_CheckBox.Checked;
            task.Notes = notes_TextBox.Text;
            InsertToDoTask(task);
        }

        public string InsertToDoTask(ToDoTask entity)
        {
            var result = _appRepository.InsertToDoTask(entity);
            return result > 0 ? "Succesfully inserted a record into the database. " : "Failed to INSERT into the database.";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}