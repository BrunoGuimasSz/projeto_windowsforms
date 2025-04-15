namespace Projeto
{
    partial class Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobre));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(285, 361);
            label2.Name = "label2";
            label2.Size = new Size(639, 21);
            label2.TabIndex = 1;
            label2.Text = "Um simples gerenciador de tarefas feito para te auxiliar em seus compromissos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(468, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 185);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(449, 398);
            label1.Name = "label1";
            label1.Size = new Size(312, 21);
            label1.TabIndex = 3;
            label1.Text = "Criado por Augusto, Bruno e Giovanni";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.AutoEllipsis = true;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(544, 600);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Sobre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1208, 684);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "Sobre";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
    }
}