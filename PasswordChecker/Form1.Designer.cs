﻿namespace PasswordChecker
{
  partial class PasswordForm
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
      this.button1 = new System.Windows.Forms.Button();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lblStrength = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(265, 97);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(202, 40);
      this.button1.TabIndex = 0;
      this.button1.Text = "Estimate Strength";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(265, 31);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(202, 31);
      this.txtPassword.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(19, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(195, 25);
      this.label1.TabIndex = 2;
      this.label1.Text = "Example Password";
      // 
      // lblStrength
      // 
      this.lblStrength.Location = new System.Drawing.Point(24, 97);
      this.lblStrength.Name = "lblStrength";
      this.lblStrength.Size = new System.Drawing.Size(220, 40);
      this.lblStrength.TabIndex = 3;
      this.lblStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // PasswordForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(499, 171);
      this.Controls.Add(this.lblStrength);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.button1);
      this.Name = "PasswordForm";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblStrength;
  }
}

