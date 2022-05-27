
namespace futebol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Idade:";
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Location = new System.Drawing.Point(37, 298);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(72, 17);
            this.lb_result.TabIndex = 3;
            this.lb_result.Text = "Resultado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(92, 206);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(100, 23);
            this.txt_idade.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular Case";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 60);
            this.button2.TabIndex = 7;
            this.button2.Text = "Calcular If";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_result;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

