namespace WinFormSecretSanta.ServiceForms
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            button_add = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox_id = new TextBox();
            textBox_name = new TextBox();
            textBox_lastname = new TextBox();
            button_back = new Button();
            label_msg = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_add
            // 
            resources.ApplyResources(button_add, "button_add");
            button_add.Name = "button_add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
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
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // textBox_id
            // 
            resources.ApplyResources(textBox_id, "textBox_id");
            textBox_id.Name = "textBox_id";
            // 
            // textBox_name
            // 
            resources.ApplyResources(textBox_name, "textBox_name");
            textBox_name.Name = "textBox_name";
            // 
            // textBox_lastname
            // 
            resources.ApplyResources(textBox_lastname, "textBox_lastname");
            textBox_lastname.Name = "textBox_lastname";
            // 
            // button_back
            // 
            resources.ApplyResources(button_back, "button_back");
            button_back.Name = "button_back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label_msg
            // 
            resources.ApplyResources(label_msg, "label_msg");
            label_msg.Name = "label_msg";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Controls.Add(button_back, 2, 4);
            tableLayoutPanel1.Controls.Add(label_msg, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox_id, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox_lastname, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox_name, 1, 1);
            tableLayoutPanel1.Controls.Add(button_add, 1, 3);
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // AddUserForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "AddUserForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_add;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_id;
        private TextBox textBox_name;
        private TextBox textBox_lastname;
        private Button button_back;
        private Label label_msg;
        private TableLayoutPanel tableLayoutPanel1;
    }
}