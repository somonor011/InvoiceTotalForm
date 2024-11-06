namespace InvoiceTotalForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_subtotal = new TextBox();
            lbl_dispercent = new Label();
            btn_cal = new Button();
            btn_exit = new Button();
            lbl_disamount = new Label();
            lbl_total = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(30, 38);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Subtotal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 87);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "Discount Percent";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 136);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 2;
            label3.Text = "Discount Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 189);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = "Total";
            // 
            // txt_subtotal
            // 
            txt_subtotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_subtotal.Location = new Point(200, 37);
            txt_subtotal.Name = "txt_subtotal";
            txt_subtotal.Size = new Size(168, 27);
            txt_subtotal.TabIndex = 4;
            // 
            // lbl_dispercent
            // 
            lbl_dispercent.BackColor = Color.FromArgb(224, 224, 224);
            lbl_dispercent.BorderStyle = BorderStyle.Fixed3D;
            lbl_dispercent.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_dispercent.Location = new Point(200, 86);
            lbl_dispercent.Name = "lbl_dispercent";
            lbl_dispercent.Size = new Size(168, 25);
            lbl_dispercent.TabIndex = 5;
            // 
            // btn_cal
            // 
            btn_cal.BackColor = Color.SeaGreen;
            btn_cal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cal.ForeColor = SystemColors.ButtonHighlight;
            btn_cal.Location = new Point(83, 239);
            btn_cal.Name = "btn_cal";
            btn_cal.Size = new Size(94, 29);
            btn_cal.TabIndex = 8;
            btn_cal.Text = "Calculate";
            btn_cal.UseVisualStyleBackColor = false;
            btn_cal.Click += btn_cal_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Red;
            btn_exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = SystemColors.ButtonHighlight;
            btn_exit.Location = new Point(200, 239);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(94, 29);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // lbl_disamount
            // 
            lbl_disamount.BackColor = Color.FromArgb(224, 224, 224);
            lbl_disamount.BorderStyle = BorderStyle.Fixed3D;
            lbl_disamount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_disamount.Location = new Point(200, 136);
            lbl_disamount.Name = "lbl_disamount";
            lbl_disamount.Size = new Size(168, 25);
            lbl_disamount.TabIndex = 9;
            // 
            // lbl_total
            // 
            lbl_total.BackColor = Color.FromArgb(224, 224, 224);
            lbl_total.BorderStyle = BorderStyle.Fixed3D;
            lbl_total.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total.Location = new Point(200, 188);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(168, 25);
            lbl_total.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(410, 290);
            Controls.Add(lbl_total);
            Controls.Add(lbl_disamount);
            Controls.Add(btn_exit);
            Controls.Add(btn_cal);
            Controls.Add(lbl_dispercent);
            Controls.Add(txt_subtotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_subtotal;
        private Label lbl_dispercent;
        private Button btn_cal;
        private Button btn_exit;
        private Label lbl_disamount;
        private Label lbl_total;
    }
}
