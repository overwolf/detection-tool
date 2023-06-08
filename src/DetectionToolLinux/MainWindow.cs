using Gtk;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using DetectionTool.Core;

namespace DetectionTool
{
    public partial class MainWindow : Window
    {
        private Button buttonScan;
        private Label labelSummary;
        private Label labelSummaryValue;
        private Label labelDetected;
        private Label labelDetectedResult;
        private Label labelStartUp;
        private Label labelFoundInStartupValue;
        private Label labelSuspiciousFiles;
        private TextView textBoxSuspiciousFiles;
        private LinkButton linkButtonSupport;

        public MainWindow() : base("DetectionTool")
        {
            SetDefaultSize(400, 300);

            buttonScan = new Button("Scan");
            labelSummary = new Label("Summary:");
            labelSummaryValue = new Label();
            labelDetected = new Label("Detected:");
            labelDetectedResult = new Label();
            labelStartUp = new Label("Detected on Startup folder:");
            labelFoundInStartupValue = new Label();
            labelSuspiciousFiles = new Label("Suspicious Files:");
            textBoxSuspiciousFiles = new TextView(){
            Editable = false,
            WrapMode = WrapMode.Word
            };
            linkButtonSupport = new LinkButton(Constants.kSupportArticle, "Get Support");

            buttonScan.Clicked += OnButtonScanClicked;
            linkButtonSupport.Clicked += OnLinkButtonSupportClicked;

            var mainLayout = new Box(Orientation.Vertical, 0);

            mainLayout.PackStart(buttonScan, false, false, 0);
            mainLayout.PackStart(labelSummary, false, false, 0);
            mainLayout.PackStart(labelSummaryValue, false, false, 0);
            mainLayout.PackStart(labelDetected, false , false, 0);
            mainLayout.PackStart(labelDetectedResult, false, false, 0);
            mainLayout.PackStart(labelStartUp, false, false, 0);
            mainLayout.PackStart(labelFoundInStartupValue, false, false, 0);
            mainLayout.PackStart(labelSuspiciousFiles, false, false, 0);
            mainLayout.PackStart(new Separator(Orientation.Horizontal), false, false, 0);
            mainLayout.PackStart(textBoxSuspiciousFiles, true, true, 0);
            mainLayout.PackStart(linkButtonSupport, false, false, 0);

            Add(mainLayout);

            LoadStyles(); // Call the LoadStyles method to load the CSS styles

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
                    labelDetectedResult.StyleContext.AddClass("detected-label");
                    labelSummaryValue.Text = "Possible Malware traces were detected on your machine";
                    labelFoundInStartupValue.Text = results.FoundInStartUp ? "YES" : "NO";
                    labelFoundInStartupValue.StyleContext.AddClass(results.FoundInStartUp ? "detected-label" : "not-detected-label");
                    textBoxSuspiciousFiles.Buffer.Text = string.Join(Environment.NewLine, results.DetectedFiles!);
                    labelSuspiciousFiles.Visible = true;
                    linkButtonSupport.Visible = true;
                }
                else
                {
                    labelDetectedResult.Text = "NO";
                    labelDetectedResult.StyleContext.AddClass("not-detected-label");
                    labelSummaryValue.Text = "Malware was not detected on your machine";
                    labelFoundInStartupValue.Text = "NO";
                    labelFoundInStartupValue.StyleContext.AddClass("not-detected-label");
                }
            }
            catch (Exception ex)
            {
                labelDetectedResult.Text = "Inconclusive";
                labelDetectedResult.StyleContext.AddClass("inconclusive-label");
                labelSummaryValue.Text = $"Scan failed. {ex.Message}";
                labelFoundInStartupValue.Text = "Inconclusive";
                labelFoundInStartupValue.StyleContext.AddClass("inconclusive-label");
            }
        }
        private void OnLinkButtonSupportClicked(object? sender, EventArgs e)
        {
            var url = Constants.kSupportArticle;
            var psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }



        private void LoadStyles()
        {
            var cssProvider = new CssProvider();
            cssProvider.LoadFromPath("style.css");

            var styleContext = buttonScan.StyleContext;
            styleContext.AddProvider(cssProvider, Gtk.StyleProviderPriority.Application);
            styleContext = labelDetectedResult.StyleContext;
            styleContext.AddProvider(cssProvider, Gtk.StyleProviderPriority.Application);
            styleContext = labelSummaryValue.StyleContext;
            styleContext.AddProvider(cssProvider, Gtk.StyleProviderPriority.Application);
            styleContext = labelFoundInStartupValue.StyleContext;
            styleContext.AddProvider(cssProvider, Gtk.StyleProviderPriority.Application);
            styleContext = labelSuspiciousFiles.StyleContext;
            styleContext.AddProvider(cssProvider, Gtk.StyleProviderPriority.Application);
            styleContext = textBoxSuspiciousFiles.StyleContext;
            styleContext.AddProvider(cssProvider, Gtk.StyleProviderPriority.Application);
            styleContext = linkButtonSupport.StyleContext;
            styleContext.AddProvider(cssProvider, Gtk.StyleProviderPriority.Application);
        }

    }
}
