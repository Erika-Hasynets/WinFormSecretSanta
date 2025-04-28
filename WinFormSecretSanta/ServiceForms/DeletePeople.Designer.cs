namespace WinFormSecretSanta.ServiceForms
{
    partial class DeletePeople
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePeople));
            button_back = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_id = new TextBox();
            button_delete = new Button();
            label_msg = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_back
            // 
            resources.ApplyResources(button_back, "button_back");
            button_back.Name = "button_back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // textBox_id
            // 
            resources.ApplyResources(textBox_id, "textBox_id");
            textBox_id.Name = "textBox_id";
            // 
            // button_delete
            // 
            resources.ApplyResources(button_delete, "button_delete");
            button_delete.BackColor = Color.Red;
            button_delete.Name = "button_delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // label_msg
            // 
            resources.ApplyResources(label_msg, "label_msg");
            label_msg.Name = "label_msg";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(label1, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox_id, 1, 3);
            tableLayoutPanel1.Controls.Add(label_msg, 0, 5);
            tableLayoutPanel1.Controls.Add(button_back, 2, 5);
            tableLayoutPanel1.Controls.Add(button_delete, 1, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // DeletePeople
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DeletePeople";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_back;
        private Label label1;
        private Label label2;
        private TextBox textBox_id;
        private Button button_delete;
        private Label label_msg;
        private TableLayoutPanel tableLayoutPanel1;
    }
}