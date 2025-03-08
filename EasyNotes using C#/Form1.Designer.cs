namespace EasyNotes_using_C_
{
    partial class easyNotes
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
            Title = new Label();
            Notes = new Label();
            newNotesTitle = new TextBox();
            newNotesBox = new TextBox();
            pastNotes = new DataGridView();
            saveButton = new Button();
            loadButton = new Button();
            deleteButton = new Button();
            newNotesButtton = new Button();
            ((System.ComponentModel.ISupportInitialize)pastNotes).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(37, 24);
            Title.Name = "Title";
            Title.Size = new Size(44, 25);
            Title.TabIndex = 0;
            Title.Text = "Title";
            // 
            // Notes
            // 
            Notes.AutoSize = true;
            Notes.Location = new Point(37, 98);
            Notes.Name = "Notes";
            Notes.Size = new Size(59, 25);
            Notes.TabIndex = 1;
            Notes.Text = "Notes";
            // 
            // newNotesTitle
            // 
            newNotesTitle.BorderStyle = BorderStyle.FixedSingle;
            newNotesTitle.Location = new Point(37, 52);
            newNotesTitle.Name = "newNotesTitle";
            newNotesTitle.Size = new Size(519, 31);
            newNotesTitle.TabIndex = 3;
            // 
            // newNotesBox
            // 
            newNotesBox.BorderStyle = BorderStyle.FixedSingle;
            newNotesBox.Location = new Point(37, 126);
            newNotesBox.Multiline = true;
            newNotesBox.Name = "newNotesBox";
            newNotesBox.Size = new Size(519, 364);
            newNotesBox.TabIndex = 4;
            // 
            // pastNotes
            // 
            pastNotes.BackgroundColor = SystemColors.ControlLightLight;
            pastNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pastNotes.Location = new Point(587, 24);
            pastNotes.Name = "pastNotes";
            pastNotes.RowHeadersWidth = 62;
            pastNotes.Size = new Size(587, 367);
            pastNotes.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(821, 416);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(131, 51);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(671, 416);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(131, 51);
            loadButton.TabIndex = 7;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(975, 416);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(131, 51);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // newNotesButtton
            // 
            newNotesButtton.Location = new Point(0, 0);
            newNotesButtton.Name = "newNotesButtton";
            newNotesButtton.Size = new Size(75, 23);
            newNotesButtton.TabIndex = 0;
            // 
            // easyNotes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1231, 502);
            Controls.Add(newNotesButtton);
            Controls.Add(deleteButton);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(pastNotes);
            Controls.Add(newNotesBox);
            Controls.Add(newNotesTitle);
            Controls.Add(Notes);
            Controls.Add(Title);
            Name = "easyNotes";
            Text = "Form1";
            Load += easyNotes_Load;
            ((System.ComponentModel.ISupportInitialize)pastNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Notes;
        private TextBox newNotesTitle;
        private TextBox newNotesBox;
        private DataGridView pastNotes;
        private Button saveButton;
        private Button loadButton;
        private Button deleteButton;
        private Button newNotesButtton;
    }
}
