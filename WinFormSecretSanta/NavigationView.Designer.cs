namespace WinFormSecretSanta
{
    partial class NavigationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationView));
            label1 = new Label();
            comboBoxTheme = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            button5 = new Button();
            button1 = new Button();
            button6 = new Button();
            button7 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label_msg = new Label();
            comboBoxLanguage = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // comboBoxTheme
            // 
            resources.ApplyResources(comboBoxTheme, "comboBoxTheme");
            comboBoxTheme.FormattingEnabled = true;
            comboBoxTheme.Name = "comboBoxTheme";
            comboBoxTheme.SelectedIndexChanged += comboBoxTheme_SelectedIndexChanged;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button6
            // 
            resources.ApplyResources(button6, "button6");
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            resources.ApplyResources(button7, "button7");
            button7.Name = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(button7, 1, 7);
            tableLayoutPanel1.Controls.Add(button6, 1, 6);
            tableLayoutPanel1.Controls.Add(button1, 1, 1);
            tableLayoutPanel1.Controls.Add(button5, 1, 5);
            tableLayoutPanel1.Controls.Add(button2, 1, 2);
            tableLayoutPanel1.Controls.Add(button4, 1, 4);
            tableLayoutPanel1.Controls.Add(button3, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBoxTheme, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label_msg, 0, 8);
            tableLayoutPanel1.Controls.Add(comboBoxLanguage, 2, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label_msg
            // 
            resources.ApplyResources(label_msg, "label_msg");
            label_msg.Name = "label_msg";
            // 
            // comboBoxLanguage
            // 
            resources.ApplyResources(comboBoxLanguage, "comboBoxLanguage");
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Name = "comboBoxLanguage";
            // 
            // NavigationView
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "NavigationView";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxTheme;
        private Button button3;
        private Button button4;
        private Button button2;
        private Button button5;
        private Button button1;
        private Button button6;
        private Button button7;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label_msg;
        private ComboBox comboBoxLanguage;
    }
}