namespace _8Chp_382pg_IEnumerable_Lists
{
    partial class Form1
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
            this.listDeck1 = new System.Windows.Forms.ListBox();
            this.listDeck2 = new System.Windows.Forms.ListBox();
            this.butMoveToDeck2 = new System.Windows.Forms.Button();
            this.butMoveToDeck1 = new System.Windows.Forms.Button();
            this.butResetDeck1 = new System.Windows.Forms.Button();
            this.butShuffleDeck1 = new System.Windows.Forms.Button();
            this.butResetDeck2 = new System.Windows.Forms.Button();
            this.butShuffleDeck2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listDeck1
            // 
            this.listDeck1.FormattingEnabled = true;
            this.listDeck1.Location = new System.Drawing.Point(12, 31);
            this.listDeck1.Name = "listDeck1";
            this.listDeck1.Size = new System.Drawing.Size(170, 381);
            this.listDeck1.TabIndex = 0;
            // 
            // listDeck2
            // 
            this.listDeck2.FormattingEnabled = true;
            this.listDeck2.Location = new System.Drawing.Point(305, 31);
            this.listDeck2.Name = "listDeck2";
            this.listDeck2.Size = new System.Drawing.Size(179, 381);
            this.listDeck2.TabIndex = 1;
            // 
            // butMoveToDeck2
            // 
            this.butMoveToDeck2.Location = new System.Drawing.Point(205, 173);
            this.butMoveToDeck2.Name = "butMoveToDeck2";
            this.butMoveToDeck2.Size = new System.Drawing.Size(75, 23);
            this.butMoveToDeck2.TabIndex = 2;
            this.butMoveToDeck2.Text = ">>";
            this.butMoveToDeck2.UseVisualStyleBackColor = true;
            this.butMoveToDeck2.Click += new System.EventHandler(this.butMoveToDeck2_Click);
            // 
            // butMoveToDeck1
            // 
            this.butMoveToDeck1.Location = new System.Drawing.Point(205, 202);
            this.butMoveToDeck1.Name = "butMoveToDeck1";
            this.butMoveToDeck1.Size = new System.Drawing.Size(75, 23);
            this.butMoveToDeck1.TabIndex = 3;
            this.butMoveToDeck1.Text = "<<";
            this.butMoveToDeck1.UseVisualStyleBackColor = true;
            this.butMoveToDeck1.Click += new System.EventHandler(this.butMoveToDeck1_Click);
            // 
            // butResetDeck1
            // 
            this.butResetDeck1.Location = new System.Drawing.Point(12, 428);
            this.butResetDeck1.Name = "butResetDeck1";
            this.butResetDeck1.Size = new System.Drawing.Size(170, 23);
            this.butResetDeck1.TabIndex = 4;
            this.butResetDeck1.Text = "Reset Deck #1";
            this.butResetDeck1.UseVisualStyleBackColor = true;
            this.butResetDeck1.Click += new System.EventHandler(this.butResetDeck1_Click);
            // 
            // butShuffleDeck1
            // 
            this.butShuffleDeck1.Location = new System.Drawing.Point(12, 457);
            this.butShuffleDeck1.Name = "butShuffleDeck1";
            this.butShuffleDeck1.Size = new System.Drawing.Size(170, 23);
            this.butShuffleDeck1.TabIndex = 5;
            this.butShuffleDeck1.Text = "Shuffle Deck #1";
            this.butShuffleDeck1.UseVisualStyleBackColor = true;
            this.butShuffleDeck1.Click += new System.EventHandler(this.butShuffleDeck1_Click);
            // 
            // butResetDeck2
            // 
            this.butResetDeck2.Location = new System.Drawing.Point(305, 428);
            this.butResetDeck2.Name = "butResetDeck2";
            this.butResetDeck2.Size = new System.Drawing.Size(179, 23);
            this.butResetDeck2.TabIndex = 6;
            this.butResetDeck2.Text = "Reset Deck #2";
            this.butResetDeck2.UseVisualStyleBackColor = true;
            this.butResetDeck2.Click += new System.EventHandler(this.butResetDeck2_Click);
            // 
            // butShuffleDeck2
            // 
            this.butShuffleDeck2.Location = new System.Drawing.Point(305, 457);
            this.butShuffleDeck2.Name = "butShuffleDeck2";
            this.butShuffleDeck2.Size = new System.Drawing.Size(179, 23);
            this.butShuffleDeck2.TabIndex = 7;
            this.butShuffleDeck2.Text = "Shuffle Deck #2";
            this.butShuffleDeck2.UseVisualStyleBackColor = true;
            this.butShuffleDeck2.Click += new System.EventHandler(this.butShuffleDeck2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 505);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butShuffleDeck2);
            this.Controls.Add(this.butResetDeck2);
            this.Controls.Add(this.butShuffleDeck1);
            this.Controls.Add(this.butResetDeck1);
            this.Controls.Add(this.butMoveToDeck1);
            this.Controls.Add(this.butMoveToDeck2);
            this.Controls.Add(this.listDeck2);
            this.Controls.Add(this.listDeck1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDeck1;
        private System.Windows.Forms.ListBox listDeck2;
        private System.Windows.Forms.Button butMoveToDeck2;
        private System.Windows.Forms.Button butMoveToDeck1;
        private System.Windows.Forms.Button butResetDeck1;
        private System.Windows.Forms.Button butShuffleDeck1;
        private System.Windows.Forms.Button butResetDeck2;
        private System.Windows.Forms.Button butShuffleDeck2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

