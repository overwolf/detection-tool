using DetectionTool.Core;

RunScan();

static void RunScan() {
  var scanner = new Scanner();

  try {
    var results = scanner.Scan();

    if (results.Detected) {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Detected: YES");
      Console.WriteLine("Possible Malware traces were detected on your machine");
      Console.WriteLine();
      Console.WriteLine("Suspicious Files:");
      foreach(var detectedFile in results.DetectedFiles!) {
        Console.WriteLine($"  => {detectedFile}");
      }
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine($"For instructions on what to do next go to: {DetectionTool.Core.Constants.kSupportArticle}");

    } else {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Detected: NO");
      Console.WriteLine("Malware was not detected on your machine");
    }
  } catch (Exception ex) {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Detected: Inconclusive");
    Console.WriteLine($"Scan failed. {ex.Message}");
  }

  Console.ResetColor();
}
