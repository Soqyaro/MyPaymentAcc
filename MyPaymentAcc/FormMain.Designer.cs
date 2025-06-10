namespace MyPaymentAcc
{
    partial class FormMain
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
            this.listBoxPayList = new System.Windows.Forms.ListBox();
            this.listViewPayAcc = new System.Windows.Forms.ListView();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelHeader2 = new System.Windows.Forms.Label();
            this.labelHeaderAuth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPayList
            // 
            this.listBoxPayList.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPayList.FormattingEnabled = true;
            this.listBoxPayList.ItemHeight = 21;
            this.listBoxPayList.Location = new System.Drawing.Point(12, 75);
            this.listBoxPayList.Name = "listBoxPayList";
            this.listBoxPayList.Size = new System.Drawing.Size(233, 319);
            this.listBoxPayList.TabIndex = 0;
            // 
            // listViewPayAcc
            // 
            this.listViewPayAcc.HideSelection = false;
            this.listViewPayAcc.Location = new System.Drawing.Point(294, 75);
            this.listViewPayAcc.Name = "listViewPayAcc";
            this.listViewPayAcc.Size = new System.Drawing.Size(233, 319);
            this.listViewPayAcc.TabIndex = 1;
            this.listViewPayAcc.UseCompatibleStateImageBehavior = false;
            this.listViewPayAcc.View = System.Windows.Forms.View.Details;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(13, 36);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(177, 27);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Список платежей";
            // 
            // labelHeader2
            // 
            this.labelHeader2.AutoSize = true;
            this.labelHeader2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader2.Location = new System.Drawing.Point(289, 36);
            this.labelHeader2.Name = "labelHeader2";
            this.labelHeader2.Size = new System.Drawing.Size(150, 27);
            this.labelHeader2.TabIndex = 3;
            this.labelHeader2.Text = "Ваши платежи";
            // 
            // labelHeaderAuth
            // 
            this.labelHeaderAuth.AutoSize = true;
            this.labelHeaderAuth.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeaderAuth.Location = new System.Drawing.Point(499, 9);
            this.labelHeaderAuth.Name = "labelHeaderAuth";
            this.labelHeaderAuth.Size = new System.Drawing.Size(68, 16);
            this.labelHeaderAuth.TabIndex = 4;
            this.labelHeaderAuth.Text = "@SoyaYeah";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.labelHeaderAuth);
            this.Controls.Add(this.labelHeader2);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.listViewPayAcc);
            this.Controls.Add(this.listBoxPayList);
            this.Name = "FormMain";
            this.Text = "Платежи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPayList;
        private System.Windows.Forms.ListView listViewPayAcc;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelHeader2;
        private System.Windows.Forms.Label labelHeaderAuth;
    }
}

