namespace SyncServer
{
   partial class FormOne
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
         ButtonStop = new System.Windows.Forms.Button();
         ButtonStart = new System.Windows.Forms.Button();
         textBoxLog = new System.Windows.Forms.TextBox();
         Label = new System.Windows.Forms.Label();
         SuspendLayout();
         // 
         // ButtonStop
         // 
         ButtonStop.Location = new System.Drawing.Point(349, 12);
         ButtonStop.Name = "ButtonStop";
         ButtonStop.Size = new System.Drawing.Size(85, 23);
         ButtonStop.TabIndex = 9;
         ButtonStop.Text = "Остановить";
         ButtonStop.UseVisualStyleBackColor = true;
         ButtonStop.Click += ButtonStop_Click;
         // 
         // ButtonStart
         // 
         ButtonStart.Location = new System.Drawing.Point(12, 12);
         ButtonStart.Name = "ButtonStart";
         ButtonStart.Size = new System.Drawing.Size(120, 23);
         ButtonStart.TabIndex = 8;
         ButtonStart.Text = "Запустить сервер";
         ButtonStart.UseVisualStyleBackColor = true;
         ButtonStart.Click += ButtonStart_Click;
         // 
         // textBoxLog
         // 
         textBoxLog.Location = new System.Drawing.Point(12, 56);
         textBoxLog.Multiline = true;
         textBoxLog.Name = "textBoxLog";
         textBoxLog.ReadOnly = true;
         textBoxLog.Size = new System.Drawing.Size(422, 124);
         textBoxLog.TabIndex = 7;
         // 
         // Label
         // 
         Label.AutoSize = true;
         Label.Location = new System.Drawing.Point(12, 38);
         Label.Name = "Label";
         Label.Size = new System.Drawing.Size(247, 15);
         Label.TabIndex = 6;
         Label.Text = "Сервер запущен, ожидание подключения...";
         // 
         // FormOne
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(446, 203);
         Controls.Add(ButtonStop);
         Controls.Add(ButtonStart);
         Controls.Add(textBoxLog);
         Controls.Add(Label);
         Name = "FormOne";
         Text = "Двусторонний обмен между Windows Forms и консолью";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Button ButtonStop;
      private System.Windows.Forms.Button ButtonStart;
      private System.Windows.Forms.TextBox textBoxLog;
      private System.Windows.Forms.Label Label;
   }
}