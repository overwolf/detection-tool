using Gtk;
using System;
using System.Drawing;
using DetectionTool.Core;

namespace DetectionTool
{
    public partial class MainWindow : Window
    {
        private Button buttonScan;
        private Label labelDetectedResult;
        private Label labelSummaryValue;
        private Label labelFoundInStartupValue;
        private Label labelSuspiciousFiles;
        private TextView textBoxSuspiciousFiles;
        private Label labelSupport;

        public MainWindow() : base("DetectionTool")
        {
            SetDefaultSize(400, 300);

            buttonScan = new Button("Scan");
            labelDetectedResult = new Label();
            labelSummaryValue = new Label();
            labelFoundInStartupValue = new Label();
            labelSuspiciousFiles = new Label("Suspicious Files:");
            textBoxSuspiciousFiles = new TextView();
            labelSupport = new Label();
            labelSupport.Markup = "<a href=\"support\">" + Constants.kSupportArticle + "</a>";
            labelSupport.UseMarkup = true;
            labelSupport.ButtonPressEvent += OnLabelSupportClicked;

            buttonScan.Clicked += OnButtonScanClicked;

            var mainLayout = new VBox();

            mainLayout.PackStart(buttonScan, false, false, 0);
            mainLayout.PackStart(labelDetectedResult, false, false, 0);
            mainLayout.PackStart(labelSummaryValue, false, false, 0);
            mainLayout.PackStart(new HSeparator(), false, false, 0);
            mainLayout.PackStart(textBoxSuspiciousFiles, true, true, 0);
            mainLayout.PackStart(labelFoundInStartupValue, false, false, 0);
            mainLayout.PackStart(labelSuspiciousFiles, false, false, 0);
            mainLayout.PackStart(labelSupport, false, false, 0);

            Add(mainLayout);
            ShowAll();
        }

        private void OnButtonScanClicked(object? sender, EventArgs e)
        {
            var scanner = new Scanner();

            try
            {
                var results = scanner.Scan();

                if (results.Detected)
                {
                    labelDetectedResult.Text = "YES";
                    labelDetectedResult.ModifyFg(StateType.Normal, new Gdk.Color(255, 0, 0));
                    labelSummaryValue.Text = "Possible Malware traces were detected on your machine";
                    labelFoundInStartupValue.Text = results.FoundInStartUp ? "YES" : "NO";
                    labelFoundInStartupValue.ModifyFg(StateType.Normal, results.FoundInStartUp ? new Gdk.Color(255, 0, 0) : new Gdk.Color(0, 255, 0));
                    textBoxSuspiciousFiles.Buffer.Text = string.Join(Environment.NewLine, results.DetectedFiles);
                    labelSuspiciousFiles.Visible = true;
                    textBoxSuspiciousFiles.Visible = true;
                    labelSupport.Visible = true;
                }
                else
                {
                    labelDetectedResult.Text = "NO";
                    labelDetectedResult.ModifyFg(StateType.Normal, new Gdk.Color(0, 255, 0));
                    labelSummaryValue.Text = "Malware was not detected on your machine";
                    labelFoundInStartupValue.Text = "NO";
                    labelFoundInStartupValue.ModifyFg(StateType.Normal, new Gdk.Color(0, 255, 0));
                }
            }
            catch (Exception ex)
            {
                labelDetectedResult.Text = "Inconclusive";
                labelDetectedResult.ModifyFg(StateType.Normal, new Gdk.Color(255, 165, 0));
                labelSummaryValue.Text = $"Scan failed. {ex.Message}";
                labelFoundInStartupValue.Text = "Inconclusive";
                labelFoundInStartupValue.ModifyFg(StateType.Normal, new Gdk.Color(255, 165, 0));
            }
        }

        private void OnLabelSupportClicked(object? sender, ButtonPressEventArgs e)
        {
            System.Diagnostics.Process.Start(Constants.kSupportArticle);
        }
    }
}
