using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DetectionTool.Core {
  internal class Scanner {
    private string[] _suspiciousFilesWindows = new string[] {
      ".ref",
      "client.jar",
      "lib.dll",
      "libWebGL64.jar",
      "run.bat"
    };
    private string[] _suspiciousFilesLinux = new string[] {
      ".ref",
      "client.jar",
      "lib.dll",
    };

    const string kPath = "Microsoft Edge";
    const string kStartupPath = "Microsoft\\Windows\\Start Menu\\Programs\\Startup";

    private readonly string _linuxMalwarePath = Path.Combine(
      Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
      ".data");
    
    private readonly string _windowsMalwarePath;
    private readonly string _malwareStartupFilePath;

    public Scanner() {
      _windowsMalwarePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), kPath);
      _malwareStartupFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), kStartupPath, "run.bat");
    }

    public IScanResults Scan() {
      var scanResults = new ScanResults();

      var detectedFiles = Environment.OSVersion.Platform == PlatformID.Win32NT
        ? CheckFiles(_windowsMalwarePath, _suspiciousFilesWindows)
        : CheckFiles(_linuxMalwarePath, _suspiciousFilesLinux);

      scanResults.DetectedFiles = detectedFiles;
      if (detectedFiles.Any()) {
        scanResults.FoundInPath = true;
      }

      // Check startup path only on windows platform
      if (Environment.OSVersion.Platform == PlatformID.Win32NT) {
        scanResults.FoundInStartUp = CheckStartup();

        if (scanResults.FoundInStartUp) {
          scanResults.DetectedFiles = scanResults.DetectedFiles.Concat(new string[] { _malwareStartupFilePath });
        }
      }
      return scanResults;
    }

    private IEnumerable<string> CheckFiles(string path, IEnumerable<string> files) {
      var detectedFiles = new List<string>();

      if (!Directory.Exists(path)) {
        return detectedFiles;
      }

      foreach (var fileName in files) {
        var fileFullPath = Path.Combine(path, fileName);

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