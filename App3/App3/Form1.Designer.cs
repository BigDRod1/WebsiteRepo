
namespace App3
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
            inputTB = new TextBox();
            addBTN = new Button();
            inputListBox = new ListBox();
            SuspendLayout();
            // 
            // inputTB
            // 
            inputTB.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputTB.Location = new Point(66, 39);
            inputTB.Name = "inputTB";
            inputTB.Size = new Size(435, 50);
            inputTB.TabIndex = 0;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(524, 39);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(174, 50);
            addBTN.TabIndex = 1;
            addBTN.Text = "Add To List";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += button1_Click;
            // 
            // inputListBox
            // 
            inputListBox.FormattingEnabled = true;
            inputListBox.ItemHeight = 15;
            inputListBox.Location = new Point(65, 142);
            inputListBox.Name = "inputListBox";
            inputListBox.Size = new Size(632, 259);
            inputListBox.TabIndex = 2;
            inputListBox.Click += inputListBox_Click;
            inputListBox.SelectedIndexChanged += inputListBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(inputListBox);
            Controls.Add(addBTN);
            Controls.Add(inputTB);
            ForeColor = Color.Purple;
            Name = "Form1";
            Text = "a";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox inputTB;
        private Button addBTN;
        private ListBox inputListBox;
    }
}
