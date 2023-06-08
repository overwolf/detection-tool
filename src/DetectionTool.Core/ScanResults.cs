using System.Collections.Generic;

namespace DetectionTool.Core {
  internal interface IScanResults {
    bool Detected { get; }
    bool FoundInPath { get; }
    bool FoundInStartUp { get; }

    IEnumerable<string>? DetectedFiles { get; }
  }

  internal class ScanResults : IScanResults {
    public bool Detected => FoundInPath || FoundInStartUp;
    public bool FoundInPath { get; set; }
    public bool FoundInStartUp { get; set; }

    public IEnumerable<string>? DetectedFiles { get; set; }
  }
}
