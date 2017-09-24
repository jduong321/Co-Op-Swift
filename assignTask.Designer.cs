namespace Co_Op_Swift
{
    partial class assignTask
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
      this.memberLB = new System.Windows.Forms.ListBox();
      this.currentLB = new System.Windows.Forms.ListBox();
      this.taskCB = new System.Windows.Forms.ComboBox();
      this.Assign = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // memberLB
      // 
      this.memberLB.FormattingEnabled = true;
      this.memberLB.ItemHeight = 16;
      this.memberLB.Location = new System.Drawing.Point(34, 29);
      this.memberLB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.memberLB.Name = "memberLB";
      this.memberLB.Size = new System.Drawing.Size(159, 116);
      this.memberLB.TabIndex = 0;
      this.memberLB.SelectedIndexChanged += new System.EventHandler(this.memberLB_SelectedIndexChanged);
      // 
      // currentLB
      // 
      this.currentLB.FormattingEnabled = true;
      this.currentLB.ItemHeight = 16;
      this.currentLB.Location = new System.Drawing.Point(202, 29);
      this.currentLB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.currentLB.Name = "currentLB";
      this.currentLB.Size = new System.Drawing.Size(159, 116);
      this.currentLB.TabIndex = 1;
      // 
      // taskCB
      // 
      this.taskCB.FormattingEnabled = true;
      this.taskCB.Location = new System.Drawing.Point(370, 29);
      this.taskCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.taskCB.Name = "taskCB";
      this.taskCB.Size = new System.Drawing.Size(155, 24);
      this.taskCB.TabIndex = 2;
      this.taskCB.Text = "Task to be assigned";
      // 
      // Assign
      // 
      this.Assign.BackColor = System.Drawing.Color.Transparent;
      this.Assign.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Assign.Location = new System.Drawing.Point(370, 61);
      this.Assign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Assign.Name = "Assign";
      this.Assign.Size = new System.Drawing.Size(155, 84);
      this.Assign.TabIndex = 3;
      this.Assign.Text = "Assign";
      this.Assign.UseVisualStyleBackColor = false;
      this.Assign.Click += new System.EventHandler(this.Assign_Click_1);
      // 
      // assignTask
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::Co_Op_Swift.Properties.Resources.Background_Dark_Small;
      this.ClientSize = new System.Drawing.Size(564, 180);
      this.Controls.Add(this.Assign);
      this.Controls.Add(this.taskCB);
      this.Controls.Add(this.currentLB);
      this.Controls.Add(this.memberLB);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "assignTask";
      this.Text = "assignTask";
      this.Load += new System.EventHandler(this.assignTask_Load);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox memberLB;
        private System.Windows.Forms.ListBox currentLB;
        private System.Windows.Forms.ComboBox taskCB;
        private System.Windows.Forms.Button Assign;
    }
}