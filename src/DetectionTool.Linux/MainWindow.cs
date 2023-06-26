using Gtk;
using System.Diagnostics;
using DetectionTool.Core;

namespace DetectionToolLinux {
  public partial class MainWindow : Window {
    private readonly Button _buttonScan;
    private readonly Label _labelSummaryValue;
    private readonly Label _labelDetectedResult;
    private readonly Label _labelFoundInStartupValue;
    private readonly Label _labelSuspiciousFiles;
    private readonly TextView _textBoxSuspiciousFiles;
    private readonly LinkButton _linkButtonSupport;

    public MainWindow() : base("DetectionTool") {
      SetDefaultSize(400, 300);

      _buttonScan = new Button("Scan");
      var labelSummary = new Label("Summary:");
      _labelSummaryValue = new Label();
      var labelDetected = new Label("Detected:");
      _labelDetectedResult = new Label();
      var labelStartUp = new Label("Detected on Startup folder:");
      _labelFoundInStartupValue = new Label();
      _labelSuspiciousFiles = new Label("Suspicious Files:");
      _textBoxSuspiciousFiles = new TextView() {
        Editable = false,
        WrapMode = WrapMode.Word
      };
      _linkButtonSupport = new LinkButton(Constants.kSupportArticle, "Get Support");

      _buttonScan.Clicked += OnButtonScanClicked;
      _linkButtonSupport.Clicked += OnLinkButtonSupportClicked;

      var mainLayout = new Box(Orientation.Vertical, 0);

      mainLayout.PackStart(_buttonScan, false, false, 0);

      var labelSummaryRow = new Box(Orientation.Horizontal, 0);
      labelSummaryRow.PackStart(labelSummary, false, false, 5);
      labelSummaryRow.PackStart(_labelSummaryValue, false, false, 0);
      mainLayout.PackStart(labelSummaryRow, false, false, 0);

      var labelDetectedRow = new Box(Orientation.Horizontal, 0);
      labelDetectedRow.PackStart(labelDetected, false, false, 5);
      labelDetectedRow.PackStart(_labelDetectedResult, false, false, 0);
      mainLayout.PackStart(labelDetectedRow, false, false, 0);

      var labelStartUpRow = new Box(Orientation.Horizontal, 0);
      labelStartUpRow.PackStart(labelStartUp, false, false, 5);
      labelStartUpRow.PackStart(_labelFoundInStartupValue, false, false, 0);
      mainLayout.PackStart(labelStartUpRow, false, false, 0);
      var suspiciousFilesRow = new Box(Orientation.Horizontal, 0);
      suspiciousFilesRow.PackStart(_labelSuspiciousFiles, false, false, 0);
      mainLayout.PackStart(new Separator(Orientation.Horizontal), false, false, 0);
      mainLayout.PackStart(_textBoxSuspiciousFiles, true, true, 0);
      mainLayout.PackStart(_linkButtonSupport, false, false, 0);


      Add(mainLayout);

      LoadStyles(); // Call the LoadStyles method to load the CSS styles

      ShowAll();
    }

    private void OnButtonScanClicked(object? sender, EventArgs e) {
      var scanner = new Scanner();

      try {
        var results = scanner.Scan();
        if (results.Detected) {
          _labelDetectedResult.Text = "YES";
          _labelDetectedResult.StyleContext.AddClass("detected-label");
          _labelSummaryValue.Text = "Possible Malware traces were detected on your machine";
          _labelFoundInStartupValue.Text = results.FoundInStartUp ? "YES" : "NO";
          _labelFoundInStartupValue.StyleContext.AddClass(results.FoundInStartUp ? "detected-label" : "not-detected-label");
          _textBoxSuspiciousFiles.Buffer.Text = string.Join(Environment.NewLine, results.DetectedFiles);
          _labelSuspiciousFiles.Visible = true;
          _linkButtonSupport.Visible = true;
        } else {
          _labelDetectedResult.Text = "NO";
          _labelDetectedResult.StyleContext.AddClass("not-detected-label");
          _labelSummaryValue.Text = "Malware was not detected on your machine";
          _labelFoundInStartupValue.Text = "NO";
          _labelFoundInStartupValue.StyleContext.AddClass("not-detected-label");
        }
      } catch (Exception ex) {
        _labelDetectedResult.Text = "Inconclusive";
        _labelDetectedResult.StyleContext.AddClass("inconclusive-label");
        _labelSummaryValue.Text = $"Scan failed. {ex.Message}";
        _labelFoundInStartupValue.Text = "Inconclusive";
        _labelFoundInStartupValue.StyleContext.AddClass("inconclusive-label");
      }
    }
    private void OnLinkButtonSupportClicked(object? sender, EventArgs e) {
      var url = Constants.kSupportArticle;
      var psi = new ProcessStartInfo {
        FileName = url,
        UseShellExecute = true
      };
      Process.Start(psi);
    }



    private void LoadStyles() {
      var cssProvider = new CssProvider();
      cssProvider.LoadFromPath("style.css");

      var styleContext = _buttonScan.StyleContext;
      styleContext.AddProvider(cssProvider, StyleProviderPriority.Application);
      styleContext = _labelDetectedResult.StyleContext;
      styleContext.AddProvider(cssProvider, StyleProviderPriority.Application);
      styleContext = _labelSummaryValue.StyleContext;
      styleContext.AddProvider(cssProvider, StyleProviderPriority.Application);
      styleContext = _labelFoundInStartupValue.StyleContext;
      styleContext.AddProvider(cssProvider, StyleProviderPriority.Application);
      styleContext = _labelSuspiciousFiles.StyleContext;
      styleContext.AddProvider(cssProvider, StyleProviderPriority.Application);
      styleContext = _textBoxSuspiciousFiles.StyleContext;
      styleContext.AddProvider(cssProvider, StyleProviderPriority.Application);
      styleContext = _linkButtonSupport.StyleContext;
      styleContext.AddProvider(cssProvider, StyleProviderPriority.Application);
    }
  }
}