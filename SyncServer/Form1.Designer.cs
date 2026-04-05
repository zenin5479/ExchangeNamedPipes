namespace SyncServer
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
         buttonStop = new System.Windows.Forms.Button();
         ButtonStart = new System.Windows.Forms.Button();
         textBoxLog = new System.Windows.Forms.TextBox();
         Label = new System.Windows.Forms.Label();
         SuspendLayout();
         // 
         // buttonStop
         // 
         buttonStop.Enabled = false;
         buttonStop.Location = new System.Drawing.Point(349, 12);
         buttonStop.Name = "buttonStop";
         buttonStop.Size = new System.Drawing.Size(85, 23);
         buttonStop.TabIndex = 9;
         buttonStop.Text = "Остановить";
         buttonStop.UseVisualStyleBackColor = true;
         buttonStop.Click += buttonStop_Click;
         // 
         // ButtonStart
         // 
         ButtonStart.Location = new System.Drawing.Point(12, 12);
         ButtonStart.Name = "ButtonStart";
         ButtonStart.Size = new System.Drawing.Size(120, 23);
         ButtonStart.TabIndex = 8;
         ButtonStart.Text = "Запустить сервер";
         ButtonStart.UseVisualStyleBackColor = true;
         ButtonStart.Click += buttonStart_Click;
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
         // Form1
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(446, 194);
         Controls.Add(buttonStop);
         Controls.Add(ButtonStart);
         Controls.Add(textBoxLog);
         Controls.Add(Label);
         Name = "Form1";
         Text = "Двусторонний обмен между Windows Forms и консолью";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Button buttonStop;
      private System.Windows.Forms.Button ButtonStart;
      private System.Windows.Forms.TextBox textBoxLog;
      private System.Windows.Forms.Label Label;
   }
}