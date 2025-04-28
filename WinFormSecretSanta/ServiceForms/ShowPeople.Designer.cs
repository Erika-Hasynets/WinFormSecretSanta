namespace WinFormSecretSanta.ServiceForms
{
    partial class ShowPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPeople));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label_id = new Label();
            label_name = new Label();
            label_lastname = new Label();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label_id
            // 
            resources.ApplyResources(label_id, "label_id");
            label_id.Name = "label_id";
            // 
            // label_name
            // 
            resources.ApplyResources(label_name, "label_name");
            label_name.Name = "label_name";
            // 
            // label_lastname
            // 
            resources.ApplyResources(label_lastname, "label_lastname");
            label_lastname.Name = "label_lastname";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(button2, 2, 4);
            tableLayoutPanel1.Controls.Add(label_lastname, 0, 3);
            tableLayoutPanel1.Controls.Add(button1, 0, 4);
            tableLayoutPanel1.Controls.Add(label_id, 0, 1);
            tableLayoutPanel1.Controls.Add(label_name, 0, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // ShowPeople
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(tableLayoutPanel1);
            Name = "ShowPeople";
            Load += ShowPeople_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label_id;
        private Label label_name;
        private Label label_lastname;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
    }
}