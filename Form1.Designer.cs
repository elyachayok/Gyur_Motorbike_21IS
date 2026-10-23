namespace Gyur_Motorbike_21IS
{
    partial class MainForm
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
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.userControlName1 = new Gyur_Motorbike_21IS.UserControlName();
            this.userControlName2 = new Gyur_Motorbike_21IS.UserControlName();
            this.SuspendLayout();
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.Location = new System.Drawing.Point(21, 138);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(70, 270);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.Location = new System.Drawing.Point(937, 138);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(70, 270);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // userControlName1
            // 
            this.userControlName1.Location = new System.Drawing.Point(97, 12);
            this.userControlName1.Name = "userControlName1";
            this.userControlName1.Size = new System.Drawing.Size(414, 534);
            this.userControlName1.TabIndex = 4;
            // 
            // userControlName2
            // 
            this.userControlName2.Location = new System.Drawing.Point(517, 12);
            this.userControlName2.Name = "userControlName2";
            this.userControlName2.Size = new System.Drawing.Size(414, 534);
            this.userControlName2.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 573);
            this.Controls.Add(this.userControlName2);
            this.Controls.Add(this.userControlName1);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private UserControlName userControlName1;
        private UserControlName userControlName2;
    }
}

