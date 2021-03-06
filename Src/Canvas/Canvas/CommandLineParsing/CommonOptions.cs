using System.Collections.Generic;
using Isas.Shared;

namespace Canvas.CommandLineParsing
{
    public class CommonOptions
    {
        public IFileLocation BAlleleSites { get; set; }
        public IDirectoryLocation OutputDirectory { get; }
        public IDirectoryLocation WholeGenomeFasta { get; }
        public IFileLocation KmerFasta { get; }
        public IFileLocation FilterBed { get; }
        public string SampleName { get; set; }
        public Dictionary<string, string> CustomParams { get; }
        public string StartCheckpoint { get; }
        public string StopCheckpoint { get; }
        public IFileLocation PloidyBed { get; }
        public bool IsDbSnpVcf { get; }

        public CommonOptions(IFileLocation bAlleleSites, bool isDbSnpVcf, IFileLocation ploidyBed, IDirectoryLocation outputDirectory, IDirectoryLocation wholeGenomeFasta, IFileLocation kmerFasta, IFileLocation filterBed, string sampleName, Dictionary<string, string> customParams, string startCheckpoint, string stopCheckpoint)
        {
            BAlleleSites = bAlleleSites;
            IsDbSnpVcf = isDbSnpVcf;
            PloidyBed = ploidyBed;
            OutputDirectory = outputDirectory;
            WholeGenomeFasta = wholeGenomeFasta;
            KmerFasta = kmerFasta;
            FilterBed = filterBed;
            SampleName = sampleName;
            CustomParams = customParams;
            StartCheckpoint = startCheckpoint;
            StopCheckpoint = stopCheckpoint;
        }
    }
}