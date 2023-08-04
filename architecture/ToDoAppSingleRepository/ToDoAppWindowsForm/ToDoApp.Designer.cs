namespace ToDoAppWindowsForm
{
    partial class ToDoApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label9 = new Label();
            completionNotes_TextBox = new TextBox();
            deleteBtn = new Button();
            isCompleted_CheckBox = new CheckBox();
            exitBtn = new Button();
            completionDate_DateTimePicker = new DateTimePicker();
            estCompDate_DateTimePicker = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            notes_TextBox = new TextBox();
            label14 = new Label();
            description_TextBox = new TextBox();
            label8 = new Label();
            taskName_TextBox = new TextBox();
            label7 = new Label();
            charName_TextBox = new TextBox();
            label6 = new Label();
            charId_TextBox = new TextBox();
            label5 = new Label();
            userId_TextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            taskId_TextBox = new TextBox();
            submitBtn = new Button();
            label2 = new Label();
            tabPage4 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 1;
            label1.Text = "ToDoApp Windows Form";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 411);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 383);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Users";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 383);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Characters";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(completionNotes_TextBox);
            tabPage3.Controls.Add(deleteBtn);
            tabPage3.Controls.Add(isCompleted_CheckBox);
            tabPage3.Controls.Add(exitBtn);
            tabPage3.Controls.Add(completionDate_DateTimePicker);
            tabPage3.Controls.Add(estCompDate_DateTimePicker);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(notes_TextBox);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(description_TextBox);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(taskName_TextBox);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(charName_TextBox);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(charId_TextBox);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(userId_TextBox);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(taskId_TextBox);
            tabPage3.Controls.Add(submitBtn);
            tabPage3.Controls.Add(label2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 383);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Add/Update ToDoTasks";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 245);
            label9.Name = "label9";
            label9.Size = new Size(110, 15);
            label9.TabIndex = 29;
            label9.Text = "Completion Notes: ";
            // 
            // completionNotes_TextBox
            // 
            completionNotes_TextBox.Location = new Point(60, 263);
            completionNotes_TextBox.Name = "completionNotes_TextBox";
            completionNotes_TextBox.Size = new Size(206, 23);
            completionNotes_TextBox.TabIndex = 30;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(336, 316);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 28;
            deleteBtn.Text = "&Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // isCompleted_CheckBox
            // 
            isCompleted_CheckBox.AutoSize = true;
            isCompleted_CheckBox.Location = new Point(272, 267);
            isCompleted_CheckBox.Name = "isCompleted_CheckBox";
            isCompleted_CheckBox.Size = new Size(150, 19);
            isCompleted_CheckBox.TabIndex = 27;
            isCompleted_CheckBox.Text = "Has it been completed?";
            isCompleted_CheckBox.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(417, 316);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 26;
            exitBtn.Text = "E&xit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // compDate_DateTimePicker
            // 
            completionDate_DateTimePicker.Location = new Point(272, 203);
            completionDate_DateTimePicker.Name = "compDate_DateTimePicker";
            completionDate_DateTimePicker.Size = new Size(206, 23);
            completionDate_DateTimePicker.TabIndex = 17;
            // 
            // estCompDate_DateTimePicker
            // 
            estCompDate_DateTimePicker.Location = new Point(60, 203);
            estCompDate_DateTimePicker.Name = "estCompDate_DateTimePicker";
            estCompDate_DateTimePicker.Size = new Size(206, 23);
            estCompDate_DateTimePicker.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(484, 63);
            label10.Name = "label10";
            label10.Size = new Size(77, 15);
            label10.TabIndex = 3;
            label10.Text = "Character Id: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(484, 188);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 21;
            label11.Text = "Notes: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(272, 247);
            label12.Name = "label12";
            label12.Size = new Size(83, 15);
            label12.TabIndex = 20;
            label12.Text = "Is Completed: ";
            // 
            // notes_TextBox
            // 
            notes_TextBox.Location = new Point(484, 206);
            notes_TextBox.Name = "notes_TextBox";
            notes_TextBox.Size = new Size(206, 23);
            notes_TextBox.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(272, 185);
            label14.Name = "label14";
            label14.Size = new Size(103, 15);
            label14.TabIndex = 14;
            label14.Text = "Completion Date: ";
            // 
            // desc_TextBox
            // 
            description_TextBox.Location = new Point(484, 143);
            description_TextBox.Name = "desc_TextBox";
            description_TextBox.Size = new Size(206, 23);
            description_TextBox.TabIndex = 12;
            // 
            // label8
            // 
            label8.Location = new Point(60, 186);
            label8.Name = "label8";
            label8.Size = new Size(164, 21);
            label8.TabIndex = 13;
            label8.Text = "Estimated Completion Date: ";
            // 
            // taskName_TextBox
            // 
            taskName_TextBox.Location = new Point(272, 143);
            taskName_TextBox.Name = "taskName_TextBox";
            taskName_TextBox.Size = new Size(206, 23);
            taskName_TextBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(484, 125);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 9;
            label7.Text = "Description:";
            // 
            // charName_TextBox
            // 
            charName_TextBox.Location = new Point(60, 143);
            charName_TextBox.Name = "charName_TextBox";
            charName_TextBox.Size = new Size(206, 23);
            charName_TextBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(272, 125);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 8;
            label6.Text = "Task Name: ";
            // 
            // charId_TextBox
            // 
            charId_TextBox.Location = new Point(484, 81);
            charId_TextBox.Name = "charId_TextBox";
            charId_TextBox.Size = new Size(206, 23);
            charId_TextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 125);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 7;
            label5.Text = "Character Name: ";
            // 
            // userId_TextBox
            // 
            userId_TextBox.Location = new Point(272, 81);
            userId_TextBox.Name = "userId_TextBox";
            userId_TextBox.Size = new Size(206, 23);
            userId_TextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 63);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 2;
            label4.Text = "User Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(295, 14);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 7;
            label3.Text = "Update or Insert a new ToDoTask";
            // 
            // taskId_TextBox
            // 
            taskId_TextBox.Location = new Point(60, 81);
            taskId_TextBox.Name = "taskId_TextBox";
            taskId_TextBox.Size = new Size(206, 23);
            taskId_TextBox.TabIndex = 4;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(255, 316);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 25;
            submitBtn.Text = "&Save";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 63);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Task Id:";
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(768, 383);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "View ToDoTasks";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // ToDoApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "ToDoApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ToDoApp";
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DateTimePicker estCompDate_DateTimePicker;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox notes_TextBox;
        private Label label14;
        private TextBox description_TextBox;
        private Label label8;
        private TextBox taskName_TextBox;
        private Label label7;
        private TextBox charName_TextBox;
        private Label label6;
        private TextBox charId_TextBox;
        private Label label5;
        private TextBox userId_TextBox;
        private Label label4;
        private Label label3;
        private TextBox taskId_TextBox;
        private Button submitBtn;
        private Label label2;
        private Button exitBtn;
        private DateTimePicker completionDate_DateTimePicker;
        private CheckBox isCompleted_CheckBox;
        private Button deleteBtn;
        private Label label9;
        private TextBox completionNotes_TextBox;
        private TabPage tabPage4;
    }
}