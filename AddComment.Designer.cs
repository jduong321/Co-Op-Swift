﻿namespace Co_Op_Swift
{
  partial class AddComment
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
      this.ok_button = new System.Windows.Forms.Button();
      this.cancel_button = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.nameBox = new System.Windows.Forms.TextBox();
      this.commentBox = new System.Windows.Forms.TextBox();
      this.taskNameBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // ok_button
      // 
      this.ok_button.BackColor = System.Drawing.Color.Transparent;
      this.ok_button.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ok_button.Location = new System.Drawing.Point(247, 315);
      this.ok_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.ok_button.Name = "ok_button";
      this.ok_button.Size = new System.Drawing.Size(196, 55);
      this.ok_button.TabIndex = 0;
      this.ok_button.Text = "OK";
      this.ok_button.UseVisualStyleBackColor = false;
      this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
      // 
      // cancel_button
      // 
      this.cancel_button.BackColor = System.Drawing.Color.Transparent;
      this.cancel_button.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cancel_button.Location = new System.Drawing.Point(16, 315);
      this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.cancel_button.Name = "cancel_button";
      this.cancel_button.Size = new System.Drawing.Size(196, 55);
      this.cancel_button.TabIndex = 1;
      this.cancel_button.Text = "Cancel";
      this.cancel_button.UseVisualStyleBackColor = false;
      this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(28, 11);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 26);
      this.label1.TabIndex = 2;
      this.label1.Text = "Name:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(28, 166);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(108, 26);
      this.label2.TabIndex = 3;
      this.label2.Text = "Comment:";
      // 
      // nameBox
      // 
      this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameBox.Location = new System.Drawing.Point(33, 39);
      this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.nameBox.Name = "nameBox";
      this.nameBox.Size = new System.Drawing.Size(376, 26);
      this.nameBox.TabIndex = 4;
      // 
      // commentBox
      // 
      this.commentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.commentBox.Location = new System.Drawing.Point(33, 194);
      this.commentBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.commentBox.Multiline = true;
      this.commentBox.Name = "commentBox";
      this.commentBox.Size = new System.Drawing.Size(376, 91);
      this.commentBox.TabIndex = 5;
      // 
      // taskNameBox
      // 
      this.taskNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.taskNameBox.Location = new System.Drawing.Point(33, 123);
      this.taskNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.taskNameBox.Name = "taskNameBox";
      this.taskNameBox.Size = new System.Drawing.Size(376, 26);
      this.taskNameBox.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(28, 95);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(121, 26);
      this.label3.TabIndex = 6;
      this.label3.Text = "Task Name:";
      // 
      // AddComment
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkOrange;
      this.BackgroundImage = global::Co_Op_Swift.Properties.Resources.Background_Dark_Small;
      this.ClientSize = new System.Drawing.Size(459, 385);
      this.Controls.Add(this.taskNameBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.commentBox);
      this.Controls.Add(this.nameBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cancel_button);
      this.Controls.Add(this.ok_button);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "AddComment";
      this.Text = "AddComment";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button ok_button;
    private System.Windows.Forms.Button cancel_button;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox nameBox;
    private System.Windows.Forms.TextBox commentBox;
    private System.Windows.Forms.TextBox taskNameBox;
    private System.Windows.Forms.Label label3;
  }
}