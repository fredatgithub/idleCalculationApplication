namespace IdleCalculationAppDemo
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.labelIdleTime = new System.Windows.Forms.Label();
      this.timerIdle = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // labelIdleTime
      // 
      this.labelIdleTime.AutoSize = true;
      this.labelIdleTime.Location = new System.Drawing.Point(24, 40);
      this.labelIdleTime.Name = "labelIdleTime";
      this.labelIdleTime.Size = new System.Drawing.Size(0, 17);
      this.labelIdleTime.TabIndex = 0;
      // 
      // timerIdle
      // 
      this.timerIdle.Enabled = true;
      this.timerIdle.Interval = 1000;
      this.timerIdle.Tick += new System.EventHandler(this.timerIdle_Tick);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(715, 99);
      this.Controls.Add(this.labelIdleTime);
      this.Name = "FormMain";
      this.Text = "Idle Calculation";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
      this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseClick);
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
      this.MouseEnter += new System.EventHandler(this.FormMain_MouseEnter);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
      this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelIdleTime;
    private System.Windows.Forms.Timer timerIdle;
  }
}

