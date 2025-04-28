namespace WinFormSecretSanta.ServiceForms
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            button_edit = new Button();
            label_msg = new Label();
            button_back = new Button();
            textBox_lastname = new TextBox();
            label3 = new Label();
            textBox_name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox_id = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_edit
            // 
            resources.ApplyResources(button_edit, "button_edit");
            button_edit.Name = "button_edit";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // label_msg
            // 
            resources.ApplyResources(label_msg, "label_msg");
            label_msg.Name = "label_msg";
            // 
            // button_back
            // 
            resources.ApplyResources(button_back, "button_back");
            button_back.Name = "button_back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // textBox_lastname
            // 
            resources.ApplyResources(textBox_lastname, "textBox_lastname");
            textBox_lastname.Name = "textBox_lastname";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // textBox_name
            // 
            resources.ApplyResources(textBox_name, "textBox_name");
            textBox_name.Name = "textBox_name";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // textBox_id
            // 
            resources.ApplyResources(textBox_id, "textBox_id");
            textBox_id.Name = "textBox_id";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(label_msg, 0, 5);
            tableLayoutPanel1.Controls.Add(button_back, 2, 5);
            tableLayoutPanel1.Controls.Add(button_edit, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox_lastname, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox_name, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox_id, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // EditForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "EditForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_edit;
        private Label label_msg;
        private Button button_back;
        private TextBox textBox_lastname;
        private Label label3;
        private TextBox textBox_name;
        private Label label2;
        private Label label1;
        private TextBox textBox_id;
        private TableLayoutPanel tableLayoutPanel1;
    }
}