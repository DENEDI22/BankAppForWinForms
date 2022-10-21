using System.ComponentModel;

namespace BankAppWFFramework4._8._1;

partial class AccountBrowser
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.label1 = new System.Windows.Forms.Label();
        this.richTextBox1 = new System.Windows.Forms.RichTextBox();
        this.panel1 = new System.Windows.Forms.Panel();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.button1 = new System.Windows.Forms.Button();
        this.timer1 = new System.Timers.Timer();
        this.panel2 = new System.Windows.Forms.Panel();
        this.label4 = new System.Windows.Forms.Label();
        this.listBox1 = new System.Windows.Forms.ListBox();
        this.panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
        this.panel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label1.Location = new System.Drawing.Point(30, 132);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(204, 35);
        this.label1.TabIndex = 0;
        this.label1.Text = "Account data:\r\n";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // richTextBox1
        // 
        this.richTextBox1.Location = new System.Drawing.Point(30, 173);
        this.richTextBox1.Name = "richTextBox1";
        this.richTextBox1.Size = new System.Drawing.Size(191, 105);
        this.richTextBox1.TabIndex = 1;
        this.richTextBox1.Text = "";
        // 
        // panel1
        // 
        this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.panel1.Controls.Add(this.label3);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.textBox2);
        this.panel1.Controls.Add(this.textBox1);
        this.panel1.Controls.Add(this.button1);
        this.panel1.Location = new System.Drawing.Point(270, 47);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(305, 310);
        this.panel1.TabIndex = 2;
        // 
        // label3
        // 
        this.label3.Location = new System.Drawing.Point(43, 100);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(177, 23);
        this.label3.TabIndex = 2;
        this.label3.Text = "Transfer amount";
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(43, 43);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(177, 23);
        this.label2.TabIndex = 2;
        this.label2.Text = "Receiver name";
        // 
        // textBox2
        // 
        this.textBox2.Location = new System.Drawing.Point(43, 126);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(225, 22);
        this.textBox2.TabIndex = 1;
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(43, 69);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(225, 22);
        this.textBox1.TabIndex = 1;
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(43, 218);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(225, 46);
        this.button1.TabIndex = 0;
        this.button1.Text = "Transfer";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // timer1
        // 
        this.timer1.Enabled = true;
        this.timer1.Interval = 60000D;
        this.timer1.SynchronizingObject = this;
        this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
        // 
        // panel2
        // 
        this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
        this.panel2.Controls.Add(this.label4);
        this.panel2.Controls.Add(this.listBox1);
        this.panel2.Location = new System.Drawing.Point(12, 394);
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(563, 252);
        this.panel2.TabIndex = 3;
        // 
        // label4
        // 
        this.label4.Location = new System.Drawing.Point(3, 8);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(253, 239);
        this.label4.TabIndex = 2;
        this.label4.Text = "label4";
        // 
        // listBox1
        // 
        this.listBox1.FormattingEnabled = true;
        this.listBox1.ItemHeight = 16;
        this.listBox1.Items.AddRange(new object[] { "Transaction 1", "Transaction 2" });
        this.listBox1.Location = new System.Drawing.Point(280, 3);
        this.listBox1.Name = "listBox1";
        this.listBox1.Size = new System.Drawing.Size(280, 244);
        this.listBox1.TabIndex = 1;
        this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
        // 
        // AccountBrowser
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(602, 658);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.richTextBox1);
        this.Controls.Add(this.label1);
        this.Name = "AccountBrowser";
        this.Text = "AccountBrowser";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountBrowser_FormClosing);
        this.Load += new System.EventHandler(this.AccountBrowser_Load);
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
        this.panel2.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.ListBox listBox1;

    private System.Windows.Forms.Panel panel2;

    private System.Timers.Timer timer1;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.RichTextBox richTextBox1;

    private System.Windows.Forms.Label label1;

    #endregion
}