using System.ComponentModel;

namespace BankAppWFFramework4._8._1;

partial class UserRegisterForm
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
        this.button1 = new System.Windows.Forms.Button();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.textBox3 = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(20, 208);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(287, 81);
        this.button1.TabIndex = 0;
        this.button1.Text = "Register";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(110, 32);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(197, 22);
        this.textBox1.TabIndex = 1;
        // 
        // textBox2
        // 
        this.textBox2.Location = new System.Drawing.Point(110, 73);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(197, 22);
        this.textBox2.TabIndex = 1;
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(20, 31);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(84, 23);
        this.label1.TabIndex = 2;
        this.label1.Text = "Username";
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(20, 72);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(84, 23);
        this.label2.TabIndex = 2;
        this.label2.Text = "Password";
        // 
        // textBox3
        // 
        this.textBox3.Location = new System.Drawing.Point(110, 122);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new System.Drawing.Size(197, 22);
        this.textBox3.TabIndex = 1;
        // 
        // label3
        // 
        this.label3.Location = new System.Drawing.Point(20, 106);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(84, 38);
        this.label3.TabIndex = 2;
        this.label3.Text = "Password\r\nAgain\r\n";
        // 
        // UserRegisterForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(329, 314);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.textBox3);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.button1);
        this.Name = "UserRegisterForm";
        this.Text = "Register";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button button1;

    #endregion
}