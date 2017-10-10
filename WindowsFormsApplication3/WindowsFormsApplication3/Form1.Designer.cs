namespace WindowsFormsApplication3
{
    partial class FormForGetInfo
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurName = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelBirthDay = new System.Windows.Forms.Label();
            this.labelMaritalStatus = new System.Windows.Forms.Label();
            this.labelAdditionalInfo = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxMaritalStatus = new System.Windows.Forms.TextBox();
            this.textBoxAdditionalInfo = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 19);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя";
            // 
            // labelSurName
            // 
            this.labelSurName.AutoSize = true;
            this.labelSurName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurName.Location = new System.Drawing.Point(12, 62);
            this.labelSurName.Name = "labelSurName";
            this.labelSurName.Size = new System.Drawing.Size(74, 19);
            this.labelSurName.TabIndex = 1;
            this.labelSurName.Text = "Фамилия";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatronymic.Location = new System.Drawing.Point(12, 95);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(72, 19);
            this.labelPatronymic.TabIndex = 2;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(12, 128);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(36, 19);
            this.labelSex.TabIndex = 3;
            this.labelSex.Text = "Пол";
            // 
            // labelBirthDay
            // 
            this.labelBirthDay.AutoSize = true;
            this.labelBirthDay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDay.Location = new System.Drawing.Point(12, 194);
            this.labelBirthDay.Name = "labelBirthDay";
            this.labelBirthDay.Size = new System.Drawing.Size(158, 19);
            this.labelBirthDay.TabIndex = 4;
            this.labelBirthDay.Text = "Год и дата рождения";
            // 
            // labelMaritalStatus
            // 
            this.labelMaritalStatus.AutoSize = true;
            this.labelMaritalStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaritalStatus.Location = new System.Drawing.Point(12, 161);
            this.labelMaritalStatus.Name = "labelMaritalStatus";
            this.labelMaritalStatus.Size = new System.Drawing.Size(128, 19);
            this.labelMaritalStatus.TabIndex = 5;
            this.labelMaritalStatus.Text = "Семейный статус";
            // 
            // labelAdditionalInfo
            // 
            this.labelAdditionalInfo.AutoSize = true;
            this.labelAdditionalInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdditionalInfo.Location = new System.Drawing.Point(12, 227);
            this.labelAdditionalInfo.Name = "labelAdditionalInfo";
            this.labelAdditionalInfo.Size = new System.Drawing.Size(224, 19);
            this.labelAdditionalInfo.TabIndex = 6;
            this.labelAdditionalInfo.Text = "Дополнительная информация";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxName.Location = new System.Drawing.Point(314, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(366, 27);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxSurName.Location = new System.Drawing.Point(314, 62);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(366, 27);
            this.textBoxSurName.TabIndex = 8;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxPatronymic.Location = new System.Drawing.Point(314, 95);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(366, 27);
            this.textBoxPatronymic.TabIndex = 9;
            // 
            // textBoxMaritalStatus
            // 
            this.textBoxMaritalStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxMaritalStatus.Location = new System.Drawing.Point(314, 161);
            this.textBoxMaritalStatus.Name = "textBoxMaritalStatus";
            this.textBoxMaritalStatus.Size = new System.Drawing.Size(366, 27);
            this.textBoxMaritalStatus.TabIndex = 12;
            // 
            // textBoxAdditionalInfo
            // 
            this.textBoxAdditionalInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxAdditionalInfo.Location = new System.Drawing.Point(314, 227);
            this.textBoxAdditionalInfo.Multiline = true;
            this.textBoxAdditionalInfo.Name = "textBoxAdditionalInfo";
            this.textBoxAdditionalInfo.Size = new System.Drawing.Size(366, 113);
            this.textBoxAdditionalInfo.TabIndex = 13;
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(581, 346);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 35);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonMale.Location = new System.Drawing.Point(314, 129);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(61, 23);
            this.radioButtonMale.TabIndex = 16;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Муж";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonFemale.Location = new System.Drawing.Point(436, 130);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(57, 23);
            this.radioButtonFemale.TabIndex = 17;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Жен";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // textBoxDay
            // 
            this.textBoxDay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxDay.Location = new System.Drawing.Point(314, 194);
            this.textBoxDay.MaxLength = 2;
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(46, 27);
            this.textBoxDay.TabIndex = 18;
            this.textBoxDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonth_KeyPress);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxYear.Location = new System.Drawing.Point(418, 194);
            this.textBoxYear.MaxLength = 4;
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(56, 27);
            this.textBoxYear.TabIndex = 19;
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonth_KeyPress);
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxMonth.Location = new System.Drawing.Point(366, 194);
            this.textBoxMonth.MaxLength = 2;
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(46, 27);
            this.textBoxMonth.TabIndex = 20;
            this.textBoxMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMonth_KeyPress);
            // 
            // FormForGetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxAdditionalInfo);
            this.Controls.Add(this.textBoxMaritalStatus);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxSurName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAdditionalInfo);
            this.Controls.Add(this.labelMaritalStatus);
            this.Controls.Add(this.labelBirthDay);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelSurName);
            this.Controls.Add(this.labelName);
            this.Name = "FormForGetInfo";
            this.Text = "Информация";
            this.Load += new System.EventHandler(this.FormForGetInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelBirthDay;
        private System.Windows.Forms.Label labelMaritalStatus;
        private System.Windows.Forms.Label labelAdditionalInfo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxMaritalStatus;
        private System.Windows.Forms.TextBox textBoxAdditionalInfo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMonth;
    }
}

