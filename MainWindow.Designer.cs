using System.Windows.Forms;

namespace DetectionTool {
  partial class MainWindow {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.buttonScan = new System.Windows.Forms.Button();
      this.groupBoxScanResults = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanelResults = new System.Windows.Forms.TableLayoutPanel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.labelFoundInStartupValue = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxSuspiciousFiles = new System.Windows.Forms.TextBox();
      this.labelSuspiciousFiles = new System.Windows.Forms.Label();
      this.panelDetected = new System.Windows.Forms.Panel();
      this.labelDetectedResult = new System.Windows.Forms.Label();
      this.labelDetected = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.labelSummaryValue = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.linkLabelSupport = new System.Windows.Forms.LinkLabel();
      this.groupBoxScanResults.SuspendLayout();
      this.tableLayoutPanelResults.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panelDetected.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonScan
      // 
      this.buttonScan.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.buttonScan.Location = new System.Drawing.Point(298, 19);
      this.buttonScan.Name = "buttonScan";
      this.buttonScan.Size = new System.Drawing.Size(99, 20);
      this.buttonScan.TabIndex = 0;
      this.buttonScan.Text = "Scan";
      this.buttonScan.UseVisualStyleBackColor = true;
      this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
      // 
      // groupBoxScanResults
      // 
      this.groupBoxScanResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxScanResults.Controls.Add(this.tableLayoutPanelResults);
      this.groupBoxScanResults.Location = new System.Drawing.Point(10, 54);
      this.groupBoxScanResults.Name = "groupBoxScanResults";
      this.groupBoxScanResults.Size = new System.Drawing.Size(672, 347);
      this.groupBoxScanResults.TabIndex = 1;
      this.groupBoxScanResults.TabStop = false;
      this.groupBoxScanResults.Text = "Scan Results";
      // 
      // tableLayoutPanelResults
      // 
      this.tableLayoutPanelResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanelResults.ColumnCount = 1;
      this.tableLayoutPanelResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelResults.Controls.Add(this.panel3, 0, 2);
      this.tableLayoutPanelResults.Controls.Add(this.textBoxSuspiciousFiles, 0, 4);
      this.tableLayoutPanelResults.Controls.Add(this.labelSuspiciousFiles, 0, 3);
      this.tableLayoutPanelResults.Controls.Add(this.panelDetected, 0, 1);
      this.tableLayoutPanelResults.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanelResults.Controls.Add(this.linkLabelSupport, 0, 6);
      this.tableLayoutPanelResults.Location = new System.Drawing.Point(5, 19);
      this.tableLayoutPanelResults.Name = "tableLayoutPanelResults";
      this.tableLayoutPanelResults.RowCount = 7;
      this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanelResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanelResults.Size = new System.Drawing.Size(662, 323);
      this.tableLayoutPanelResults.TabIndex = 4;
      // 
      // panel3
      // 
      this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel3.Controls.Add(this.labelFoundInStartupValue);
      this.panel3.Controls.Add(this.label6);
      this.panel3.Controls.Add(this.label3);
      this.panel3.Controls.Add(this.label4);
      this.panel3.Location = new System.Drawing.Point(3, 70);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(656, 23);
      this.panel3.TabIndex = 10;
      // 
      // labelFoundInStartupValue
      // 
      this.labelFoundInStartupValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelFoundInStartupValue.AutoSize = true;
      this.labelFoundInStartupValue.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      this.labelFoundInStartupValue.Location = new System.Drawing.Point(194, 5);
      this.labelFoundInStartupValue.Name = "labelFoundInStartupValue";
      this.labelFoundInStartupValue.Size = new System.Drawing.Size(63, 20);
      this.labelFoundInStartupValue.TabIndex = 3;
      this.labelFoundInStartupValue.Text = "Not Run";
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      this.label6.Location = new System.Drawing.Point(3, 5);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(185, 20);
      this.label6.TabIndex = 2;
      this.label6.Text = "Detected in Startup folder:";
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      this.label3.Location = new System.Drawing.Point(113, -35);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 20);
      this.label3.TabIndex = 1;
      this.label3.Text = "Not Run";
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      this.label4.Location = new System.Drawing.Point(3, -35);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(122, 20);
      this.label4.TabIndex = 0;
      this.label4.Text = "Found in registry:";
      // 
      // textBoxSuspiciousFiles
      // 
      this.textBoxSuspiciousFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxSuspiciousFiles.Location = new System.Drawing.Point(3, 123);
      this.textBoxSuspiciousFiles.Multiline = true;
      this.textBoxSuspiciousFiles.Name = "textBoxSuspiciousFiles";
      this.textBoxSuspiciousFiles.Size = new System.Drawing.Size(656, 177);
      this.textBoxSuspiciousFiles.TabIndex = 7;
      this.textBoxSuspiciousFiles.Visible = false;
      // 
      // labelSuspiciousFiles
      // 
      this.labelSuspiciousFiles.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelSuspiciousFiles.AutoSize = true;
      this.labelSuspiciousFiles.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
      this.labelSuspiciousFiles.Location = new System.Drawing.Point(5, 100);
      this.labelSuspiciousFiles.Margin = new System.Windows.Forms.Padding(5, 4, 3, 0);
      this.labelSuspiciousFiles.Name = "labelSuspiciousFiles";
      this.labelSuspiciousFiles.Size = new System.Drawing.Size(117, 20);
      this.labelSuspiciousFiles.TabIndex = 8;
      this.labelSuspiciousFiles.Text = "Suspicious Files";
      this.labelSuspiciousFiles.Visible = false;
      // 
      // panelDetected
      // 
      this.panelDetected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelDetected.Controls.Add(this.labelDetectedResult);
      this.panelDetected.Controls.Add(this.labelDetected);
      this.panelDetected.Location = new System.Drawing.Point(3, 36);
      this.panelDetected.Name = "panelDetected";
      this.panelDetected.Size = new System.Drawing.Size(656, 28);
      this.panelDetected.TabIndex = 5;
      // 
      // labelDetectedResult
      // 
      this.labelDetectedResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelDetectedResult.AutoSize = true;
      this.labelDetectedResult.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      this.labelDetectedResult.Location = new System.Drawing.Point(71, 5);
      this.labelDetectedResult.Name = "labelDetectedResult";
      this.labelDetectedResult.Size = new System.Drawing.Size(63, 20);
      this.labelDetectedResult.TabIndex = 1;
      this.labelDetectedResult.Text = "Not Run";
      // 
      // labelDetected
      // 
      this.labelDetected.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelDetected.AutoSize = true;
      this.labelDetected.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      this.labelDetected.Location = new System.Drawing.Point(3, 5);
      this.labelDetected.Name = "labelDetected";
      this.labelDetected.Size = new System.Drawing.Size(73, 20);
      this.labelDetected.TabIndex = 0;
      this.labelDetected.Text = "Detected:";
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.Controls.Add(this.labelSummaryValue);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(656, 27);
      this.panel1.TabIndex = 6;
      // 
      // labelSummaryValue
      // 
      this.labelSummaryValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelSummaryValue.AutoSize = true;
      this.labelSummaryValue.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      this.labelSummaryValue.Location = new System.Drawing.Point(72, 5);
      this.labelSummaryValue.Name = "labelSummaryValue";
      this.labelSummaryValue.Size = new System.Drawing.Size(63, 20);
      this.labelSummaryValue.TabIndex = 1;
      this.labelSummaryValue.Text = "Not Run";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      this.label2.Location = new System.Drawing.Point(3, 5);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 20);
      this.label2.TabIndex = 0;
      this.label2.Text = "Summary:";
      // 
      // linkLabelSupport
      // 
      this.linkLabelSupport.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.linkLabelSupport.AutoSize = true;
      this.linkLabelSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
      this.linkLabelSupport.Location = new System.Drawing.Point(170, 303);
      this.linkLabelSupport.Name = "linkLabelSupport";
      this.linkLabelSupport.Size = new System.Drawing.Size(322, 20);
      this.linkLabelSupport.TabIndex = 12;
      this.linkLabelSupport.TabStop = true;
      this.linkLabelSupport.Text = "For instructions on what to do next click here";
      this.linkLabelSupport.Visible = false;
      this.linkLabelSupport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSupport_LinkClicked);
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(693, 412);
      this.Controls.Add(this.groupBoxScanResults);
      this.Controls.Add(this.buttonScan);
      this.Name = "MainWindow";
      this.Text = "Detection Tool";
      this.groupBoxScanResults.ResumeLayout(false);
      this.tableLayoutPanelResults.ResumeLayout(false);
      this.tableLayoutPanelResults.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panelDetected.ResumeLayout(false);
      this.panelDetected.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private Button buttonScan;
    private GroupBox groupBoxScanResults;
    private Label labelDetectedResult;
    private Label labelDetected;
    private TableLayoutPanel tableLayoutPanelResults;
    private Panel panelDetected;
    private Panel panel1;
    private Label labelSummaryValue;
    private Label label2;
    private TextBox textBoxSuspiciousFiles;
    private Label labelSuspiciousFiles;
    private Panel panel3;
    private Label labelFoundInStartupValue;
    private Label label6;
    private Label label3;
    private Label label4;
    private LinkLabel linkLabelSupport;
  }
}