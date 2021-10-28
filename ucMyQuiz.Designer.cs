
namespace QuizApp
{
    partial class ucMyQuiz
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMyQuiz = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyQuiz)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMyQuiz
            // 
            this.dgvMyQuiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyQuiz.Location = new System.Drawing.Point(4, 106);
            this.dgvMyQuiz.Name = "dgvMyQuiz";
            this.dgvMyQuiz.RowHeadersWidth = 51;
            this.dgvMyQuiz.RowTemplate.Height = 29;
            this.dgvMyQuiz.Size = new System.Drawing.Size(1017, 431);
            this.dgvMyQuiz.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Quiz";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(4, 62);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(94, 29);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Click Me";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // ucMyQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMyQuiz);
            this.Name = "ucMyQuiz";
            this.Size = new System.Drawing.Size(1021, 540);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyQuiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMyQuiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTest;
    }
}
