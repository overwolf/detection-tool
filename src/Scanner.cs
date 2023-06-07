using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DetectionTool {
  internal class Scanner {
    private string[] _suspiousEdgeFiles = new string[] {
      ".ref",
      "client.jar",
      "lib.dll",
      "libWebGL64.jar",
      "run.bat"
    };
    const string kPath = "Microsoft Edge";
    const string kStartupPath = "Microsoft\\Windows\\Start Menu\\Programs\\Startup";

    private readonly string _localAppData;
    private readonly string _malwareAppDataPath;
    private readonly string _malwareStartupFilePath;

    public Scanner() {
      _localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
      _malwareAppDataPath = Path.Combine(_localAppData, kPath);
      _malwareStartupFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), kStartupPath, "run.bat");
    }

    public IScanResults Scan() {
      var scanResults = new ScanResults();

      var detectedFiles = CheckFiles();
      scanResults.DetectedFiles = detectedFiles;
      if (detectedFiles.Any()) {
        scanResults.FoundInPath = true;
      }

      scanResults.FoundInStartUp = CheckStartup();

      if (scanResults.FoundInStartUp) {
        scanResults.DetectedFiles = scanResults.DetectedFiles.Concat(new string[] { _malwareStartupFilePath });
      }

      return scanResults;
    }

    private IEnumerable<string> CheckFiles() {
      var detectedFiles = new List<string>();

      if (!Directory.Exists(_malwareAppDataPath)) {
        return detectedFiles;
      }

      foreach (var fileName in _suspiousEdgeFiles) {
        var fileFullPath = Path.Combine(_malwareAppDataPath, fileName);

        if (File.Exists(fileFullPath)) {
          detectedFiles.Add(fileFullPath);
        }
      }

      return detectedFiles;
    }

    private bool CheckStartup() {
      if (!File.Exists(_malwareStartupFilePath)) {
        return false;
      }

      return true;
    }
  }
}
