namespace WinFormSecretSanta.ServiceForms
{
    partial class ShowDrawing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDrawing));
            label4 = new Label();
            label_lastname = new Label();
            label_name = new Label();
            label_id = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label_toId = new Label();
            label_toName = new Label();
            label_toLastName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label_lastname
            // 
            resources.ApplyResources(label_lastname, "label_lastname");
            label_lastname.Name = "label_lastname";
            // 
            // label_name
            // 
            resources.ApplyResources(label_name, "label_name");
            label_name.Name = "label_name";
            // 
            // label_id
            // 
            resources.ApplyResources(label_id, "label_id");
            label_id.Name = "label_id";
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label_toId
            // 
            resources.ApplyResources(label_toId, "label_toId");
            label_toId.Name = "label_toId";
            // 
            // label_toName
            // 
            resources.ApplyResources(label_toName, "label_toName");
            label_toName.Name = "label_toName";
            // 
            // label_toLastName
            // 
            resources.ApplyResources(label_toLastName, "label_toLastName");
            label_toLastName.Name = "label_toLastName";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(button2, 2, 7);
            tableLayoutPanel1.Controls.Add(button3, 1, 7);
            tableLayoutPanel1.Controls.Add(label_toLastName, 0, 6);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 7);
            tableLayoutPanel1.Controls.Add(label_toName, 0, 5);
            tableLayoutPanel1.Controls.Add(label_id, 0, 1);
            tableLayoutPanel1.Controls.Add(label_toId, 0, 4);
            tableLayoutPanel1.Controls.Add(label_name, 0, 2);
            tableLayoutPanel1.Controls.Add(label_lastname, 0, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // ShowDrawing
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "ShowDrawing";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private Label label_lastname;
        private Label label_name;
        private Label label_id;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label_toId;
        private Label label_toName;
        private Label label_toLastName;
        private TableLayoutPanel tableLayoutPanel1;
    }
}