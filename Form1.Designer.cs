namespace ExchangeNamedPipes
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
         this.txtNumber = new System.Windows.Forms.TextBox();
         btnCalc = new System.Windows.Forms.Button();
         SuspendLayout();
         // 
         // txtNumber
         // 
         this.txtNumber.Location = new System.Drawing.Point(12, 12);
         this.txtNumber.Multiline = true;
         this.txtNumber.Name = "txtNumber";
         this.txtNumber.Size = new System.Drawing.Size(224, 185);
         this.txtNumber.TabIndex = 0;
         // 
         // btnCalc
         // 
         btnCalc.Location = new System.Drawing.Point(12, 203);
         btnCalc.Name = "btnCalc";
         btnCalc.Size = new System.Drawing.Size(75, 23);
         btnCalc.TabIndex = 1;
         btnCalc.Text = "button1";
         btnCalc.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         ClientSize = new System.Drawing.Size(800, 450);
         Controls.Add(btnCalc);
         Controls.Add(this.txtNumber);
         Name = "Form1";
         Text = "Form1";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.TextBox txtNumber;
   }
}
