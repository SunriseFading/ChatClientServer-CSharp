namespace WindowsFormsClient
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessagesLB = new System.Windows.Forms.ListBox();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.MessageTB = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(695, 393);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(93, 45);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessagesLB
            // 
            this.MessagesLB.FormattingEnabled = true;
            this.MessagesLB.ItemHeight = 15;
            this.MessagesLB.Location = new System.Drawing.Point(12, 12);
            this.MessagesLB.Name = "MessagesLB";
            this.MessagesLB.Size = new System.Drawing.Size(776, 364);
            this.MessagesLB.TabIndex = 1;
            this.MessagesLB.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(25, 390);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(220, 23);
            this.UserNameTB.TabIndex = 2;
            // 
            // MessageTB
            // 
            this.MessageTB.Location = new System.Drawing.Point(25, 419);
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.Size = new System.Drawing.Size(645, 23);
            this.MessageTB.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.MessagesLB);
            this.Controls.Add(this.SendButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SendButton;
        private ListBox MessagesLB;
        private TextBox UserNameTB;
        private TextBox MessageTB;
        private System.Windows.Forms.Timer timer1;
    }
}