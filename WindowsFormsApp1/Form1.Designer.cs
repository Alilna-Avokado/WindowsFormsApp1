
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bT = new System.Windows.Forms.Button();
            this.bS = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Controls.Add(this.bT);
            this.panel2.Controls.Add(this.bS);
            this.panel2.Controls.Add(this.bC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(714, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 450);
            this.panel2.TabIndex = 1;
            // 
            // bT
            // 
            this.bT.Location = new System.Drawing.Point(8, 92);
            this.bT.Name = "bT";
            this.bT.Size = new System.Drawing.Size(75, 23);
            this.bT.TabIndex = 2;
            this.bT.Text = "Triangle";
            this.bT.UseVisualStyleBackColor = true;
            this.bT.Click += new System.EventHandler(this.bT_Click);
            // 
            // bS
            // 
            this.bS.Location = new System.Drawing.Point(8, 63);
            this.bS.Name = "bS";
            this.bS.Size = new System.Drawing.Size(75, 23);
            this.bS.TabIndex = 1;
            this.bS.Text = "Square";
            this.bS.UseVisualStyleBackColor = true;
            this.bS.Click += new System.EventHandler(this.bS_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(8, 34);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(75, 23);
            this.bC.TabIndex = 0;
            this.bC.Text = "Circle";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bT;
        private System.Windows.Forms.Button bS;
        private System.Windows.Forms.Button bC;
    }
}

