namespace PasswordGenerator
{
    partial class FrmPasswordGenerator
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
            this.components = new System.ComponentModel.Container();
            this.ParamsGeneration = new System.Windows.Forms.GroupBox();
            this.trackBarPasswordLenght = new System.Windows.Forms.TrackBar();
            this.textPasswordLenght = new System.Windows.Forms.Label();
            this.CheckBoxUppercaseLetters = new System.Windows.Forms.CheckBox();
            this.CheckBoxLowercaseLetters = new System.Windows.Forms.CheckBox();
            this.CheckBoxDigits = new System.Windows.Forms.CheckBox();
            this.CheckBoxSpecialSymbols = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ButtonGeneratePassword = new System.Windows.Forms.Button();
            this.ButtonClearPassword = new System.Windows.Forms.Button();
            this.textBoxGenerationPassword = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.LabelPasswordCopiedToClipboard = new System.Windows.Forms.Label();
            this.TimerShowLabelCopy = new System.Windows.Forms.Timer(this.components);
            this.ParamsGeneration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // ParamsGeneration
            // 
            this.ParamsGeneration.Controls.Add(this.LabelPasswordCopiedToClipboard);
            this.ParamsGeneration.Controls.Add(this.trackBarPasswordLenght);
            this.ParamsGeneration.Controls.Add(this.textPasswordLenght);
            this.ParamsGeneration.Controls.Add(this.CheckBoxUppercaseLetters);
            this.ParamsGeneration.Controls.Add(this.CheckBoxLowercaseLetters);
            this.ParamsGeneration.Controls.Add(this.CheckBoxDigits);
            this.ParamsGeneration.Controls.Add(this.CheckBoxSpecialSymbols);
            this.ParamsGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParamsGeneration.Location = new System.Drawing.Point(14, 15);
            this.ParamsGeneration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParamsGeneration.Name = "ParamsGeneration";
            this.ParamsGeneration.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParamsGeneration.Size = new System.Drawing.Size(1113, 274);
            this.ParamsGeneration.TabIndex = 0;
            this.ParamsGeneration.TabStop = false;
            this.ParamsGeneration.Text = "ВЫБЕРИТЕ ПАРАМЕТРЫ ДЛЯ ГЕНЕРАЦИИ ПАРОЛЯ";
            this.ParamsGeneration.Enter += new System.EventHandler(this.ParamsGeneration_Enter);
            // 
            // trackBarPasswordLenght
            // 
            this.trackBarPasswordLenght.Location = new System.Drawing.Point(383, 156);
            this.trackBarPasswordLenght.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarPasswordLenght.Maximum = 30;
            this.trackBarPasswordLenght.Minimum = 5;
            this.trackBarPasswordLenght.Name = "trackBarPasswordLenght";
            this.trackBarPasswordLenght.Size = new System.Drawing.Size(414, 69);
            this.trackBarPasswordLenght.TabIndex = 4;
            this.trackBarPasswordLenght.Value = 5;
            this.trackBarPasswordLenght.Scroll += new System.EventHandler(this.trackBarPasswordLenght_Scroll);
            // 
            // textPasswordLenght
            // 
            this.textPasswordLenght.AutoSize = true;
            this.textPasswordLenght.Location = new System.Drawing.Point(51, 171);
            this.textPasswordLenght.Name = "textPasswordLenght";
            this.textPasswordLenght.Size = new System.Drawing.Size(193, 26);
            this.textPasswordLenght.TabIndex = 5;
            this.textPasswordLenght.Text = "ДЛИНА ПАРОЛЯ";
            this.textPasswordLenght.Click += new System.EventHandler(this.textPasswordLenght_Click);
            // 
            // CheckBoxUppercaseLetters
            // 
            this.CheckBoxUppercaseLetters.AutoSize = true;
            this.CheckBoxUppercaseLetters.Location = new System.Drawing.Point(639, 54);
            this.CheckBoxUppercaseLetters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBoxUppercaseLetters.Name = "CheckBoxUppercaseLetters";
            this.CheckBoxUppercaseLetters.Size = new System.Drawing.Size(469, 30);
            this.CheckBoxUppercaseLetters.TabIndex = 3;
            this.CheckBoxUppercaseLetters.Text = "ПРОПИСНЫЕ ЛАТИНСКИЕ БУКВЫ: A - Z";
            this.CheckBoxUppercaseLetters.UseVisualStyleBackColor = true;
            this.CheckBoxUppercaseLetters.CheckedChanged += new System.EventHandler(this.CheckBoxUppercaseLetters_CheckedChanged);
            // 
            // CheckBoxLowercaseLetters
            // 
            this.CheckBoxLowercaseLetters.AutoSize = true;
            this.CheckBoxLowercaseLetters.Location = new System.Drawing.Point(639, 100);
            this.CheckBoxLowercaseLetters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBoxLowercaseLetters.Name = "CheckBoxLowercaseLetters";
            this.CheckBoxLowercaseLetters.Size = new System.Drawing.Size(443, 30);
            this.CheckBoxLowercaseLetters.TabIndex = 2;
            this.CheckBoxLowercaseLetters.Text = "СТРОЧНЫЕ ЛАТИНСКИЕ БУКВЫ: a - z";
            this.CheckBoxLowercaseLetters.UseVisualStyleBackColor = true;
            this.CheckBoxLowercaseLetters.CheckedChanged += new System.EventHandler(this.CheckBoxLowercaseLetters_CheckedChanged);
            // 
            // CheckBoxDigits
            // 
            this.CheckBoxDigits.AutoSize = true;
            this.CheckBoxDigits.Location = new System.Drawing.Point(98, 100);
            this.CheckBoxDigits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBoxDigits.Name = "CheckBoxDigits";
            this.CheckBoxDigits.Size = new System.Drawing.Size(178, 30);
            this.CheckBoxDigits.TabIndex = 1;
            this.CheckBoxDigits.Text = "ЦИФРЫ: 0 - 9";
            this.CheckBoxDigits.UseVisualStyleBackColor = true;
            this.CheckBoxDigits.CheckedChanged += new System.EventHandler(this.CheckBoxDigits_CheckedChanged);
            // 
            // CheckBoxSpecialSymbols
            // 
            this.CheckBoxSpecialSymbols.AutoSize = true;
            this.CheckBoxSpecialSymbols.Location = new System.Drawing.Point(98, 54);
            this.CheckBoxSpecialSymbols.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBoxSpecialSymbols.Name = "CheckBoxSpecialSymbols";
            this.CheckBoxSpecialSymbols.Size = new System.Drawing.Size(535, 30);
            this.CheckBoxSpecialSymbols.TabIndex = 0;
            this.CheckBoxSpecialSymbols.Text = "СИМВОЛЫ: #  !  $  ;  _  ?  &&  ^  %  @  *  (  )  {  }  [  ]";
            this.CheckBoxSpecialSymbols.UseVisualStyleBackColor = true;
            this.CheckBoxSpecialSymbols.CheckedChanged += new System.EventHandler(this.CheckBoxSpecialSymbols_CheckedChanged);
            // 
            // ButtonGeneratePassword
            // 
            this.ButtonGeneratePassword.Location = new System.Drawing.Point(255, 329);
            this.ButtonGeneratePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonGeneratePassword.Name = "ButtonGeneratePassword";
            this.ButtonGeneratePassword.Size = new System.Drawing.Size(194, 29);
            this.ButtonGeneratePassword.TabIndex = 7;
            this.ButtonGeneratePassword.Text = "Сгенерировать пароль";
            this.ButtonGeneratePassword.UseVisualStyleBackColor = true;
            this.ButtonGeneratePassword.Click += new System.EventHandler(this.ButtonGeneratePassword_Click);
            // 
            // ButtonClearPassword
            // 
            this.ButtonClearPassword.Location = new System.Drawing.Point(788, 360);
            this.ButtonClearPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonClearPassword.Name = "ButtonClearPassword";
            this.ButtonClearPassword.Size = new System.Drawing.Size(117, 29);
            this.ButtonClearPassword.TabIndex = 9;
            this.ButtonClearPassword.Text = "Стереть";
            this.ButtonClearPassword.UseVisualStyleBackColor = true;
            this.ButtonClearPassword.Click += new System.EventHandler(this.ButtonClearPassword_Click);
            // 
            // textBoxGenerationPassword
            // 
            this.textBoxGenerationPassword.Location = new System.Drawing.Point(112, 379);
            this.textBoxGenerationPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGenerationPassword.Name = "textBoxGenerationPassword";
            this.textBoxGenerationPassword.Size = new System.Drawing.Size(498, 26);
            this.textBoxGenerationPassword.TabIndex = 10;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(788, 314);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(117, 29);
            this.buttonCopy.TabIndex = 11;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // LabelPasswordCopiedToClipboard
            // 
            this.LabelPasswordCopiedToClipboard.AutoSize = true;
            this.LabelPasswordCopiedToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPasswordCopiedToClipboard.ForeColor = System.Drawing.Color.Green;
            this.LabelPasswordCopiedToClipboard.Location = new System.Drawing.Point(391, 220);
            this.LabelPasswordCopiedToClipboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPasswordCopiedToClipboard.Name = "LabelPasswordCopiedToClipboard";
            this.LabelPasswordCopiedToClipboard.Size = new System.Drawing.Size(348, 20);
            this.LabelPasswordCopiedToClipboard.TabIndex = 12;
            this.LabelPasswordCopiedToClipboard.Text = "Пароль скопирован в буфер обмена";
            this.LabelPasswordCopiedToClipboard.Visible = false;
            // 
            // TimerShowLabelCopy
            // 
            this.TimerShowLabelCopy.Interval = 2000;
            this.TimerShowLabelCopy.Tick += new System.EventHandler(this.TimerShowLabelCopy_Tick_1);
            // 
            // FrmPasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 457);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textBoxGenerationPassword);
            this.Controls.Add(this.ButtonGeneratePassword);
            this.Controls.Add(this.ButtonClearPassword);
            this.Controls.Add(this.ParamsGeneration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPasswordGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор паролей";
            this.Load += new System.EventHandler(this.FrmPasswordGenerator_Load);
            this.ParamsGeneration.ResumeLayout(false);
            this.ParamsGeneration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ParamsGeneration;
        private System.Windows.Forms.TrackBar trackBarPasswordLenght;
        private System.Windows.Forms.Label textPasswordLenght;
        private System.Windows.Forms.CheckBox CheckBoxUppercaseLetters;
        private System.Windows.Forms.CheckBox CheckBoxLowercaseLetters;
        private System.Windows.Forms.CheckBox CheckBoxDigits;
        private System.Windows.Forms.CheckBox CheckBoxSpecialSymbols;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ButtonGeneratePassword;
        private System.Windows.Forms.Button ButtonClearPassword;
        private System.Windows.Forms.TextBox textBoxGenerationPassword;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label LabelPasswordCopiedToClipboard;
        private System.Windows.Forms.Timer TimerShowLabelCopy;
    }
}

