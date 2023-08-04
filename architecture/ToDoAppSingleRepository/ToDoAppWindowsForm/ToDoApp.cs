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
            task.Description = description_TextBox.Text;
            task.EstimatedCompletionDate = estCompDate_DateTimePicker.Value;
            task.CompletionDate = completionDate_DateTimePicker.Value;
            task.IsCompleted = isCompleted_CheckBox.Checked;
            task.Notes = notes_TextBox.Text;
            task.CompletionNotes = completionNotes_TextBox.Text;
            InsertToDoTask(task);
        }

        public string InsertToDoTask(ToDoTask entity)
        {
            var result = string.Empty;
            var task = _appRepository.GetToDoTaskByTaskId(entity.TaskId);
            if (task.TaskId != 0)
            {
                var dialogResult = MessageBox.Show("A ToDoTask with that TaskId already exists, do you want to update instead?", "ToDoTask Update", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var updateResult = _appRepository.UpdateToDoTaskByTaskId(entity.CompletionDate, entity.TaskId, entity.CompletionNotes);
                    result = updateResult > 0 ? "Succesfully updated a record in the database. " : "Failed to UPDATE the database.";
                }
                else if (dialogResult == DialogResult.No)
                {
                    result = "Failed to INSERT into the database.";
                    MessageBox.Show("Failed to INSERT into the database. A record with that TaskId already exists.");
                }
            }
            else
            {
                //var characterName = task.CharacterName == null ? _appRepository.GetCharacterNameByUserIdAndCharacterId(entity.UserId, entity.CharacterId) : task.CharacterName;
                //var characterId = task.CharacterId== null ? _appRepository.GetCharacterIdByCharacterNameAndUserId(entity.UserId, entity.CharacterName) : task.CharacterId;
                var insertResult = _appRepository.InsertToDoTask(entity);
                result = insertResult > 0 ? "Succesfully inserted a record into the database. " : "Failed to INSERT into the database.";
            }

            return result;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DeleteToDoTask();
        }

        public string DeleteToDoTask()
        {
            var result = _appRepository.DeleteToDoTaskByTaskId(int.Parse(taskId_TextBox.Text));
            return result > 0 ? "Succesfully deleted a record from the database. " : "Failed to DELETE from the database.";
        }
    }
}